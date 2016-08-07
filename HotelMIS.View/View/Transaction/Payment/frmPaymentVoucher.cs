using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports;
using HotelMIS.Model;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System.Data;

namespace HotelMIS.View
{
    public partial class frmPaymentVoucher : Form
    {
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private PaymentVoucher oPaymentVoucher;
        private MasterStay oMasterStay;
        private UnitOfWork oSession;

        public frmPaymentVoucher(MasterStay prmPaymentFor)
        {
            InitializeComponent();
            oSession = SessionProvider.GetNewUnitOfWork();
            oMasterStay = oSession.GetObjectByKey<MasterStay>(prmPaymentFor.Oid);
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

        private void btnCancelPaymentVoucher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (oPaymentVoucher.Status != GlobalVar.TransactionStatus.Cancel)
            {
                if (FormHelper.QuestionMessage("Are you sure want to cancel this PaymentVoucher ?"))
                {
                    if (!oPaymentVoucher.IsAlreadyPaidAll())
                    {
                        using (frmDlgVoidReason frmVoidReason = new frmDlgVoidReason())
                        {
                            frmVoidReason.ShowDialog();
                            if (frmVoidReason.voidReason != "" || frmVoidReason.voidReason != string.Empty)
                            {
                                if (FormHelper.ReAuthenticatePassword())
                                {
                                    oPaymentVoucher.VoidReason = frmVoidReason.voidReason + " by " + GlobalVar.CurrentLoginUser.Code;
                                    oPaymentVoucher.ProcessPayment(true);
                                    oPaymentVoucher.Status = GlobalVar.TransactionStatus.Cancel;
                                    //WorkingShiftDetail.CreateWorkingLog(oSession, "Void " + oPaymentVoucher.ToString() + frmVoidReason.voidReason, oPaymentVoucher.RoomAmount + oPaymentVoucher.DepositAmount, 0, 0);
                                    if (oPaymentVoucher.PaymentMethod != null && oPaymentVoucher.PaymentMethod.Code == "CS")
                                    {
                                        WorkingShiftDetail.CreateWorkingLog(oSession, "Void " + oPaymentVoucher.ToString() + frmVoidReason.voidReason, oPaymentVoucher.RoomAmount, 0, oPaymentVoucher.DepositAmount);
                                    }
                                    else
                                    {
                                        WorkingShiftDetail.CreateWorkingLog(oSession, "Void " + oPaymentVoucher.ToString() + frmVoidReason.voidReason, 0, oPaymentVoucher.RoomAmount, oPaymentVoucher.DepositAmount);
                                    }
                                    oSession.CommitChanges();
                                    this.Close();
                                }
                                else
                                {
                                    FormHelper.ErrorMessage("Wrong Password, try again.");
                                }
                            }
                        }
                    }
                    else
                    {
                        FormHelper.ErrorMessage("Payment for this stay record already completed paid.");
                    }
                }
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            ResetData();
            this.Close();
        }

        private void btnProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (oPaymentVoucher.Status == GlobalVar.TransactionStatus.Entry)
            {
                if (FormHelper.QuestionMessage("Are you sure want to process this PaymentVoucher ?"))
                {
                    if (!oPaymentVoucher.IsAlreadyPaidAll())
                    {
                        oPaymentVoucher.ProcessPayment(false);
                        if (oPaymentVoucher.PaymentMethod != null && oPaymentVoucher.PaymentMethod.Code == "CS")
                        {
                            WorkingShiftDetail.CreateWorkingLog(oSession, "Process " + oPaymentVoucher.ToString() + "ReceiptNo : " + oPaymentVoucher.Code, oPaymentVoucher.RoomAmount, 0, oPaymentVoucher.DepositAmount);
                        }
                        else
                        {
                            WorkingShiftDetail.CreateWorkingLog(oSession, "Process " + oPaymentVoucher.ToString() + "ReceiptNo : " + oPaymentVoucher.Code, 0, oPaymentVoucher.RoomAmount, oPaymentVoucher.DepositAmount);
                        }
                        oPaymentVoucher.PaymentForMaster.IsReceiptPrinted = true;
                        oSession.CommitChanges();
                        PrintPaymentVoucher();
                        this.Close();
                    }
                    else
                    {
                        FormHelper.ErrorMessage("Payment for this stay record already completed paid.");
                    }
                }
            }
        }

        private void PrintPaymentVoucher()
        {
            
            String rptDepositPay = String.Format("{0}\\{1}.repx", Application.StartupPath, "DepositPay");
            String rptDepositBack = String.Format("{0}\\{1}.repx", Application.StartupPath, "DepositBack");
            String rptRoomPay = String.Format("{0}\\{1}.repx", Application.StartupPath, "RoomPay");
            String rptRoomBack = String.Format("{0}\\{1}.repx", Application.StartupPath, "RoomBack");

            if (oPaymentVoucher.RoomAmount > 0 || oMasterStay.DiscountByPercent == 100 || oMasterStay.DiscountByAmount == oMasterStay.SubTotal)
            {
                XtraReport oRpt = new XtraReport();
                oRpt.DataSource = GetDataSource();
                oRpt.LoadLayout(rptRoomPay);
                oRpt.ExportToPdf(String.Format("{0}\\PaymentVoucher\\{1}_{2:yyyyMMddHHmmss}.pdf", Application.StartupPath, oPaymentVoucher.PaymentForMaster.ToString(), DateTime.Now));
                //using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
                //{
                //    objRibbonDesigner.OpenReport(oRpt);
                //    objRibbonDesigner.FileName = rptRoomPay;
                //    objRibbonDesigner.ShowDialog();
                //}
                using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
                {
                    objtool.Print();
                }
            }
        }

        private DataSet GetDataSource()
        {
            string strQuery = "";
            strQuery += "SELECT PaymentVoucher.Code ReceiptNo, Guest.Code GuestCodeMaster, Guest.Name GuestNameMaster, Guest.DateOfBirth GuestMasterDOB, ISNULL(Guest.KTP,'') + ' ' + ISNULL(Guest.Passport,'') ICNoMaster, \r\n " +
                            "Nationality.Name GuestNationalityMaster, MasterStay.NoOfGuest MasterNoOfGuest, MasterStay.NoOfRoom MasterNoOfRoom, \r\n " +
                            "PaymentMethod.Name PaymentMethod, (MasterStay.Total - MasterStay.SubTotal) * -1 Discount, MasterStay.TotalExtraCharge,  (MasterStay.SubTotal - MasterStay.TotalExtraCharge) Total, \r\n " +
                            "ReferenceNo, PaidDate, DepositAmount, RoomAmount, Guest2.Name GuestNameChild, Stay.RoomRate, Stay.Total ChildTotal, \r\n " +
                            "CASE WHEN DurationInDays <> 0 THEN CONVERT(nvarchar(10),DurationInDays) ELSE CONVERT(nvarchar(10),DurationInDays) + ' hrs' END NightOfStay, \r\n " +
                            "PaymentVoucher.UserCreated,PaymentVoucher.UserUpdated, Stay.DateCheckIn, Stay.DateCheckOut,PriceType.Name PriceType, RoomType.Name RoomType, Room.Name Room, AppUser.Name Responsible  \r\n " +
                            "FROM PaymentVoucher  \r\n " +
                            "INNER JOIN MasterStay ON MasterStay.Oid = PaymentVoucher.PaymentForMaster   \r\n " +
                            "INNER JOIN Stay ON Stay.MasterStay = MasterStay.Oid \r\n " +
                            "LEFT JOIN PaymentMethod ON PaymentMethod.Oid = PaymentVoucher.PaymentMethod   \r\n " +
                            "INNER JOIN Room ON Room.Oid = Stay.Room  \r\n " +
                            "INNER JOIN Guest ON Guest.Oid = MasterStay.Guest  \r\n " +
                            "INNER JOIN Guest Guest2 ON Guest2.Oid = Stay.Guest  \r\n " +
                            "LEFT JOIN Nationality ON Nationality.Oid = Guest.Nationality \r\n " +
                            "INNER JOIN RoomType ON RoomType.Oid = Stay.RoomType  \r\n " +
                            "INNER JOIN PriceType ON PriceType.Oid = Stay.PriceType  \r\n " +
                            "INNER JOIN AppUser ON AppUser.Oid = PaymentVoucher.Responsible   \r\n " +
                            " WHERE Stay.Status <> 2 AND PaymentVoucher.Oid = '" + oPaymentVoucher.Oid.ToString() + "' ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oPaymentVoucher.Status != GlobalVar.TransactionStatus.Entry)
                {
                    return;
                }
                if (FormHelper.QuestionMessage("Are you sure want to save this data ?"))
                {
                    ValidateForm();
                    if (isValidForm)
                    {
                        bs.EndEdit();
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
                    case "luPaymentFor":
                        oPaymentVoucher.PaymentForMaster = null;
                        break;

                    case "luPaymentMethod":
                        oPaymentVoucher.PaymentMethod = null;
                        break;
                }
        }

        private void LoadCombo()
        {
            //luPaymentFor.Properties.DataSource = oPaymentVoucher.AvailablePaymentFor;
            luPaymentMethod.Properties.DataSource = oPaymentVoucher.AvailablePaymentMethod;
        }

        private void ResetData()
        {
            if (oPaymentVoucher == null)
            {
                oPaymentVoucher = new PaymentVoucher(oSession);
            }
            if (oSession.IsNewObject(oPaymentVoucher))
            {
                oPaymentVoucher.PaymentForMaster = oMasterStay;
                seOutstandingAmount.Value = (decimal)((oMasterStay.Total + oMasterStay.PenaltiesCost) - (oMasterStay.TotalPaid + oMasterStay.TotalDeposit));
                oPaymentVoucher.PaymentMethod = null;
                oPaymentVoucher.Note = string.Empty;
                oPaymentVoucher.PaidDate = DateTime.Now;
                oPaymentVoucher.ReferenceNo = string.Empty;
                oPaymentVoucher.DepositAmount = 0;
                oPaymentVoucher.RoomAmount = 0;
                oPaymentVoucher.VoidReason = string.Empty;
                oPaymentVoucher.Responsible = null;
                oPaymentVoucher.Status = GlobalVar.TransactionStatus.Entry;
            }
            else
            {
                oPaymentVoucher.Reload();
            }
            bs.DataSource = oPaymentVoucher;
            if (oPaymentVoucher.Status != GlobalVar.TransactionStatus.Entry)
            {
                foreach (Control oControl in this.Controls)
                {
                    if (oControl.Name == "layoutControl1")
                        oControl.Enabled = false;
                }
            }
        }

        #region "Form Validation"

        private void CheckAmount()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (seDeposit.Value + seRoom.Value == 0)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Amount is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckPaymentFor()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luPaymentFor.EditValue == new Guid())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Payment For is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckPaymentMethod()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luPaymentMethod.EditValue == new Guid())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Payment Method is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckRoomType()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luPaymentMethod.EditValue == new Guid())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Room Type is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckPaymentFor();
            CheckPaymentMethod();
            CheckAmount();

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

        private void seDeposit_Click(object sender, EventArgs e)
        {
            seDeposit.SelectAll();
        }

        private void seRoom_Click(object sender, EventArgs e)
        {
            seRoom.SelectAll();
        }
    }
}