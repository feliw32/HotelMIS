using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using DevExpress.Data.Filtering;

namespace HotelMIS.View
{
    public partial class frmDlgCheckOut : Form
    {
        private const int MF_BYCOMMAND = 0;
        private const int MF_DISABLED = 2;
        private const int SC_CLOSE = 0xF060;
        private bool isValidForm = true;
        private CheckOut oCheckOut;
        private List<ValidationClass> oErrorCollection;
        private UnitOfWork oSession;

        public frmDlgCheckOut(UnitOfWork prmSession, ref CheckOut prmCheckOut)
        {
            InitializeComponent();
            oSession = prmSession;
            oCheckOut = prmCheckOut;
            ResetData();
            LoadCombo();
            oErrorCollection = new List<ValidationClass>();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        [DllImport("user32")]
        private static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        [DllImport("user32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetData();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oCheckOut.Delete();
            this.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oCheckOut.Status != GlobalVar.TransactionStatus.Entry)
                {
                    return;
                }
                if (FormHelper.QuestionMessage("Are you sure want to save this data ?"))
                {
                    ValidateForm();
                    if (isValidForm)
                    {
                        SaveForm();
                        oCheckOut.UpdatePenaltiesToReferencedStay();
                        oSession.CommitChanges();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                FormHelper.ErrorMessage(ex.Message);
            }
        }

        private void SaveForm()
        {
            bs.EndEdit();
            oCheckOut.DeleteSchedule();
            oCheckOut.SubmitSchedule();
            oSession.CommitChanges();
        }

        private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "btnDelete")
                switch (((LookUpEdit)sender).Name)
                {
                    case "luCheckOutFor":
                        oCheckOut.CheckOutFor = null;
                        break;
                }
        }

        private void LoadCombo()
        {
            luCheckOutFor.Properties.DataSource = oCheckOut.AvailableCheckOutFor;
        }

        private void ResetData()
        {
            if (oSession.IsNewObject(oCheckOut))
            {
                oCheckOut.CheckOutDate = GlobalVar.ClearSeconds(DateTime.Now);
                oCheckOut.Penalties = 0;
                oCheckOut.Note = string.Empty;
                oCheckOut.Status = GlobalVar.TransactionStatus.Entry;
            }
            else
            {
                oCheckOut.Reload();
            }
            bs.DataSource = oCheckOut;
            if (oCheckOut.Status != GlobalVar.TransactionStatus.Entry)
            {
                foreach (Control oControl in this.Controls)
                {
                    if (oControl.Name == "layoutControl1")
                        oControl.Enabled = false;
                }
            }
        }

        #region "Form Validation"

        private void CheckCheckOutFor()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luCheckOutFor.EditValue == new Guid())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Checkout For is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckCheckOutFor();

            if (oErrorCollection.Count > 0)
            {
                isValidForm = false;
                string errMesg = string.Empty;
                foreach (ValidationClass obj in oErrorCollection)
                {
                    errMesg += obj.ErrorType + " | " + obj.Description + "\r\n";
                }
                MessageBox.Show(errMesg);
                oErrorCollection.Clear();
            }
        }

        #endregion "Form Validation"

        private void btnProcessCheckout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oCheckOut.Status == GlobalVar.TransactionStatus.Entry)
                {
                    if (FormHelper.QuestionMessage("Are you sure want to process checkout for this guest ?"))
                    {
                        ValidateForm();
                        if (isValidForm)
                        {
                            if (FormHelper.QuestionMessage("Is the deposit has been returned?"))
                            {
                                if (oCheckOut.CheckOutFor.MasterStay.TotalDeposit != 0)
                                {
                                    PaymentVoucher oPaymentVoucher = new PaymentVoucher(oSession);
                                    oPaymentVoucher.PaymentForMaster = oCheckOut.CheckOutFor.MasterStay;
                                    oPaymentVoucher.PaymentMethod = oSession.FindObject<PaymentMethod>(new BinaryOperator("Code", "CS"));
                                    oPaymentVoucher.DepositAmount = -1 * oCheckOut.CheckOutFor.MasterStay.TotalDeposit;
                                    oPaymentVoucher.PaidDate = DateTime.Now;
                                    oPaymentVoucher.Save();
                                    oPaymentVoucher.ProcessPayment(false);
                                    oPaymentVoucher.Status = GlobalVar.TransactionStatus.Processed;
                                    WorkingShiftDetail.CreateWorkingLog(oSession, "Process " + oPaymentVoucher.ToString(),0,0,oPaymentVoucher.DepositAmount + oPaymentVoucher.RoomAmount);
                                }
                            }
                            else
                            {
                                if (!FormHelper.QuestionMessage("Continue without return the deposit ?"))
                                {
                                    return;
                                }
                            }
                            SaveForm();
                            oCheckOut.ProcessRecord();
                            WorkingShiftDetail.CreateWorkingLog(oSession, "Process " + oCheckOut.ToString(), 0, 0, 0);
                            oSession.CommitChanges();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oSession.RollbackTransaction();
                FormHelper.ErrorMessage(ex.Message);
            }
        }
    }
}