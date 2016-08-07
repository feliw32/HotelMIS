using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using System.Data;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.Data.Filtering;
using System.Runtime.InteropServices;

namespace HotelMIS.View
{
    public partial class frmDlgMasterStay : Form
    {
        private bool flag = true;
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private UnitOfWork oSession;
        private MasterStay oMasterStay;

        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        const int MF_BYCOMMAND = 0;
        const int MF_DISABLED = 2;
        const int SC_CLOSE = 0xF060;

        public frmDlgMasterStay(UnitOfWork prmSession,ref MasterStay prmMasterStay)
        {
            InitializeComponent();
            SetEvent();
            oSession = prmSession;
            oMasterStay = prmMasterStay;
            LoadCombo();
            ResetData();
            luGuest.EditValue = oMasterStay.GuestOid;
            oErrorCollection = new List<ValidationClass>();
        }

        public void SetEvent()
        {
            var sm = GetSystemMenu(Handle, false);
            EnableMenuItem(sm, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);
        }

        public void Recalculate()
        {
            isValidForm = true;
            flag = false;

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
                return;
            }
            oMasterStay.RecalculateDetail();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void btnCalculate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Recalculate();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            ResetData();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oMasterStay.Delete();
            this.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oMasterStay.Status != GlobalVar.TransactionStatus.Entry)
                {
                    return;
                }
                if (FormHelper.QuestionMessage("Are you sure want to save this data ?"))
                {
                    Recalculate();
                    //ValidateForm();
                    if (isValidForm)
                    {
                        SaveForm();
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
            oSession.CommitChanges();
        }

        private void LoadCombo()
        {
            luGuest.Properties.DataSource = oMasterStay.AvailableGuest;
        }

        private void ResetData()
        {
            if (oSession.IsNewObject(oMasterStay))
            {
                oMasterStay.DiscountByAmount = 0;
                oMasterStay.DiscountByPercent = 0;
                oMasterStay.Note = string.Empty;
                oMasterStay.Status = GlobalVar.TransactionStatus.Entry;
                oMasterStay.SubTotal = 0;
                oMasterStay.TotalExtraCharge = 0;
                oMasterStay.Total = 0;
            }
            else
            {
                oMasterStay.Reload();
            }
            bs.DataSource = oMasterStay;
            bsPayment.DataSource = oMasterStay.PaymentVouchers();
            bsRoom.DataSource = oMasterStay.Stays;
            if (oMasterStay.Status != GlobalVar.TransactionStatus.Entry)
            {
                panelControl1.Enabled = false;
            }
        }

        #region "Form Validation"

        private void CheckGuest()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (luGuest.EditValue == null)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Guest is required";
                oErrorCollection.Add(oValidationClass);
            }
        }
        private void CheckSubTotal()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (seSubTotal.Value == 0)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Sub Total is invalid.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckTotal()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (seTotal.Value == 0)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Total is invalid.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckGuest();
            flag = true;
            CheckSubTotal();
            CheckTotal();

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

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetData();
        }

        //private void btnCancelCheckIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        if (FormHelper.QuestionMessage("Are you sure want to cancel check in for this data ?"))
        //        {
        //            if (oMasterStay.Status != GlobalVar.TransactionStatus.Cancel)
        //            {
        //                if (!oMasterStay.IsMasterStayReferencedByPayment())
        //                {
        //                    oMasterStay.CancelRecord();
        //                    WorkingShiftDetail.CreateWorkingLog(oSession, "Cancel CheckIn " + oMasterStay.ToString, 0);
        //                    oSession.CommitChanges();
        //                    this.Close();
        //                }
        //                else
        //                {
        //                    FormHelper.ErrorMessage("Stay is still used by PaymentVoucher / Checkout record.");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        FormHelper.ErrorMessage(ex.Message);
        //    }
        //}

        private void PrintReceipt()
        {
            if (FormHelper.QuestionMessage("Are you sure want to print check in receipt for this data ?"))
                        {
                            if (oMasterStay.IsReceiptPrinted)
                            {
                                if (!FormHelper.QuestionMessage("Receipt is already printed before, do you want to re-print the receipt ?"))
                                {
                                    return;
                                }
                            }
                            if (oMasterStay.Status == GlobalVar.TransactionStatus.Entry)
                            {
                                if (oMasterStay.Oid != Guid.Empty)
                                {
                                    //PrintCheckInReceipt();
                                    oMasterStay.IsReceiptPrinted = true;
                                    oMasterStay.Save();
                                    WorkingShiftDetail.CreateWorkingLog(oSession, "Print Receipt " + oMasterStay.ToString, 0, 0, 0);
                                    oSession.CommitChanges();
                                    this.Close();
                                }
                            }
                            else
                            {
                                FormHelper.ErrorMessage("Cannot print receipt for canceled or processed data.");
                            }
                        }
        }

        private void btnPayment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Recalculate();
            ValidateForm();
            if (isValidForm)
            {
                SaveForm();
                oSession.CommitChanges();
                //frmPaymentVoucher oForm = new frmPaymentVoucher(oMasterStay);
                //oForm.ShowDialog();
            }
        }

        private void DisableView()
        {
            luGuest.Properties.ReadOnly = true;
            chkGuestIsCompany.Properties.ReadOnly = true;
            meNote.Properties.ReadOnly = true;
            seDiscountByAmount.Properties.ReadOnly = true;
            seDiscountByPercent.Properties.ReadOnly = true;
        }


        private void seDiscountByPercent_Enter(object sender, EventArgs e)
        {
            seDiscountByPercent.SelectAll();
        }

        private void seDiscountByAmount_Enter(object sender, EventArgs e)
        {
            seDiscountByAmount.SelectAll();
        }
    }
}