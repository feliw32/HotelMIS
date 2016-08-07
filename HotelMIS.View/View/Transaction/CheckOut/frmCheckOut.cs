using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using DevExpress.XtraReports.UI;
using System.Data;

namespace HotelMIS.View
{
    public partial class frmCheckOut : Form
    {
        private bool isValidForm = true;
        private CheckOut oCheckOut;
        private List<ValidationClass> oErrorCollection;
        private UnitOfWork oSession;

        public frmCheckOut(CheckOut prmCheckOut = null)
        {
            InitializeComponent();
            oSession = SessionProvider.GetNewUnitOfWork();
            if (prmCheckOut != null)
                oCheckOut = oSession.GetObjectByKey<CheckOut>(prmCheckOut.Oid);
            ResetData();
            LoadCombo();
            oErrorCollection = new List<ValidationClass>();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            oSession.Dispose();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            ResetData();
        }

        private void btnCancelCheckOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (oCheckOut.Status == GlobalVar.TransactionStatus.Entry)
            {
                if (FormHelper.QuestionMessage("Are you sure want to cancel checkout for this guest ?"))
                {
                    SaveForm();
                    oCheckOut.CancelRecord();
                    WorkingShiftDetail.CreateWorkingLog(oSession, "Cancel " + oCheckOut.ToString(), 0, 0, 0);
                    oSession.CommitChanges();
                    this.Close();
                }
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            ResetData();
            this.Close();
        }

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
                            SaveForm();
                            oCheckOut.ProcessRecord();
                            WorkingShiftDetail.CreateWorkingLog(oSession, "Process " + oCheckOut.ToString(), 0, 0, 0);
                            oSession.CommitChanges();
                            PrintSummaryReceipt();
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

        private void PrintSummaryReceipt()
        {
            //String rptCheckoutReceipt = String.Format("{0}\\{1}.repx", Application.StartupPath, "CheckoutReceipt");
            //XtraReport oRpt = new XtraReport();
            //oRpt.DataSource = GetDataSource();
            //oRpt.LoadLayout(rptCheckoutReceipt);
            //using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
            //{
            //    objtool.Print();
            //}
            ////using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
            ////{
            ////    objRibbonDesigner.OpenReport(oRpt);
            ////    objRibbonDesigner.FileName = rptCheckoutReceipt;
            ////    objRibbonDesigner.ShowDialog();
            ////}
        }

        private object GetDataSource()
        {
            string strQuery = "";
            strQuery += "SELECT PaymentMethod.Name PaymentMethod, ReferenceNo, PaidDate, DepositAmount, RoomAmount,(DepositAmount * -1) DepositBackAmount, (RoomAmount * -1) RoomBackAmount, PaymentVoucher.UserCreated,PaymentVoucher.UserUpdated, Stay.GuestName, Stay.DateCheckIn, Stay.DateCheckOut,PriceType.Name PriceType, RoomType.Name RoomType, Room.Name Room, AppUser.Name Responsible FROM PaymentVoucher " +
                        "INNER JOIN Stay ON Stay.Oid = PaymentVoucher.PaymentFor " +
                        "INNER JOIN PaymentMethod ON PaymentMethod.Oid = PaymentVoucher.PaymentMethod " +
                        "INNER JOIN Room ON Room.Oid = Stay.Room " +
                        "INNER JOIN RoomType ON RoomType.Oid = Stay.RoomType " +
                        "INNER JOIN PriceType ON PriceType.Oid = Stay.PriceType " +
                        "INNER JOIN AppUser ON AppUser.Oid = PaymentVoucher.Responsible " +
                        "INNER JOIN CheckOut ON CheckOut.CheckOutFor = Stay.Oid " +
                        " WHERE CheckOut.Oid = '" + oCheckOut.Oid.ToString() + "' ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
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
            if (oCheckOut == null)
            {
                oCheckOut = new CheckOut(oSession);
            }
            if (oSession.IsNewObject(oCheckOut))
            {
                oCheckOut.CheckOutFor = null;
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

        private void SaveForm()
        {
            bs.EndEdit();
            oCheckOut.DeleteSchedule();
            oCheckOut.SubmitSchedule();
            oSession.CommitChanges();
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
    }
}