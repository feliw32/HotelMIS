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
using DevExpress.XtraGrid.Views.Grid;
using System.Runtime.InteropServices;

namespace HotelMIS.View
{
    public partial class frmDlgMasterStay2 : Form
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

        public frmDlgMasterStay2(UnitOfWork prmSession, ref MasterStay prmMasterStay)
        {
            InitializeComponent();
            oSession = prmSession;
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
            if (!oMasterStay.IsReceiptPrinted)
            {
                btnNewGuest.Focus();
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
        }

        private void btnCalculate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Recalculate();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (FormHelper.QuestionMessage("Are you sure want to cancel this data ?"))
                {
                    if (oMasterStay.Status != GlobalVar.TransactionStatus.Cancel)
                    {
                        if (!oMasterStay.IsMasterStayReferencedByPayment())
                        {
                            oMasterStay.CancelRecord();
                            WorkingShiftDetail.CreateWorkingLog(oSession, "Cancel Master Stay data " + oMasterStay.ToString, 0, 0, 0);
                            foreach (Stay objStay in oMasterStay.Stays)
                            {
                                objStay.CancelRecord();
                                objStay.Save();
                            }
                            oSession.CommitChanges();
                            this.Close();
                        }
                        else
                        {
                            FormHelper.ErrorMessage("Master Stay is still used by PaymentVoucher.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FormHelper.ErrorMessage(ex.Message);
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oMasterStay.Delete();
            this.Close();
        }

        private void btnNewGuest_Click(object sender, EventArgs e)
        {
            if (!FormHelper.QuestionMessage("Are you sure want to create new Guest ?"))
            { return; }

            frmGuest oForm = new frmGuest();
            oForm.ShowDialog();
            LoadCombo();
            luGuest.EditValue = null;
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

        private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "btnDelete")
                switch (((LookUpEdit)sender).Name)
                {
                    case "luGuest":
                        oMasterStay.Guest = null;
                        break;
                }
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
            XPCollection<Stay> xpCollStay = oMasterStay.Stays;
            xpCollStay.Filter = new BinaryOperator("Status", GlobalVar.TransactionStatus.Entry);
            bsRoom.DataSource = xpCollStay;
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
            if (seSubTotal.Value == 0 && seDiscountByPercent.Value != 100 && seDiscountByAmount.Value != seSubTotal.Value)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Sub Total is invalid.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckTotal()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (seTotal.Value == 0 && seDiscountByPercent.Value != 100 && seDiscountByAmount.Value != seSubTotal.Value)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Total is invalid.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckRoomCount()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (oMasterStay.NoOfRoom == 0)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Must input room before save or payment.";
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
            CheckRoomCount();

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
                frmPaymentVoucher oForm = new frmPaymentVoucher(oMasterStay);
                oForm.ShowDialog();
            }
        }

        private void DisableView()
        {
            luGuest.Properties.ReadOnly = true;
            btnNewGuest.Enabled = false;
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

        private void btnNewDetail_Click(object sender, EventArgs e)
        {
            //using (frmStay oForm = new frmStay(oSession,oMasterStay))
            //{
            //    oForm.ShowDialog();
            //    btnRefreshDetail.PerformClick();
            //}

            luRoomPrice.Properties.ReadOnly = false;
            luPriceType.Properties.ReadOnly = false;
            luRoomType.Properties.ReadOnly = false;
            seDurationInDays.Properties.ReadOnly = false;
            seDurationInHours.Properties.ReadOnly = false;
            seNoOfGuest.Properties.ReadOnly = false;
            chkBreakfast.Properties.ReadOnly = false;
            chkExtraBed.Properties.ReadOnly = false;
            btnSaveDetail.Enabled = true;
            
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            Stay CurrentRow = ((Stay)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                using (frmStay oForm = new frmStay(oSession, oMasterStay, CurrentRow))
                {
                    oForm.ShowDialog();
                }
                btnRefresh.PerformClick();
            }
        }

        private void btnRefreshDetail_Click(object sender, EventArgs e)
        {
            XPCollection<Stay> xpCollStay = oMasterStay.Stays;
            xpCollStay.Filter = new BinaryOperator("Status", GlobalVar.TransactionStatus.Entry);
            bsRoom.DataSource = xpCollStay;
        }

        private void btnReprint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PaymentVoucher oPaymentVoucher = oSession.FindObject<PaymentVoucher>(new BinaryOperator("PaymentForMaster.Oid", oMasterStay.Oid.ToString()));
            if (oPaymentVoucher != null)
            {
                String rptRoomPay = String.Format("{0}\\{1}.repx", Application.StartupPath, "RoomPay");
                if (oPaymentVoucher.RoomAmount > 0)
                {
                    XtraReport oRpt = new XtraReport();
                    oRpt.DataSource = GetDataSourcePaymentVoucher(oPaymentVoucher);
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
                    oMasterStay.IsReceiptPrinted = true;
                    WorkingShiftDetail.CreateWorkingLog(oSession, "Reprint Receipt " + oPaymentVoucher.Code, 0, 0, 0);
                    oSession.CommitChanges();
                }
            }
            else
            {
                FormHelper.InformationMessage("No receipt found yet.");
            }
        }
        private DataSet GetDataSourcePaymentVoucher(PaymentVoucher prmPaymentVoucher)
        {
            string strQuery = "";
            strQuery += "SELECT PaymentVoucher.Code ReceiptNo, Guest.Code GuestCodeMaster, Guest.Name GuestNameMaster, Guest.DateOfBirth GuestMasterDOB, Guest.KTP + ' ' + Guest.Passport ICNoMaster, \r\n " +
                            "Nationality.Name GuestNationalityMaster, MasterStay.NoOfGuest MasterNoOfGuest, MasterStay.NoOfRoom MasterNoOfRoom, \r\n " +
                            "PaymentMethod.Name PaymentMethod, (MasterStay.Total - MasterStay.SubTotal) Discount, MasterStay.TotalExtraCharge, MasterStay.Total, \r\n " +
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
                            " WHERE Stay.Status <> 2 AND PaymentVoucher.Oid = '" + prmPaymentVoucher.Oid.ToString() + "' ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }

        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            if (luRoomPrice.EditValue == null)
            {
                FormHelper.InformationMessage("Choose the Room field");
                return;
            }
            if (seDurationInDays.Value == 0 && seDurationInHours.Value == 0)
            {
                FormHelper.InformationMessage("Check the duration.");
                return;
            }

            if (FormHelper.QuestionMessage("Are you sure want to check-in this room ?"))
            {
                RoomType oRoomType = oSession.GetObjectByKey<RoomType>(luRoomType.EditValue);
                PriceType oPriceType = oSession.GetObjectByKey<PriceType>(luPriceType.EditValue);
                Room oRoom = oSession.GetObjectByKey<Room>(luRoomPrice.EditValue);

                Stay oStay = new Stay(oSession);
                oStay.Guest = oMasterStay.Guest;
                oStay.MasterStay = oMasterStay;
                oStay.NoOfGuest = (int)seNoOfGuest.Value;
                oStay.PriceType = oPriceType;
                oStay.Room = oRoom;
                oStay.RoomType = oRoomType;
                oStay.DateCheckIn = deFrom.DateTime;
                oStay.DateCheckOut = deUntil.DateTime;
                oStay.DurationInDays = (double)seDurationInDays.Value;
                oStay.DurationInHours = (double)seDurationInHours.Value;
                oStay.ExtraBed = chkExtraBed.Checked;
                oStay.Breakfast = chkBreakfast.Checked;
                oStay.Status = GlobalVar.TransactionStatus.Entry;
                oStay.Save();
                oStay.SubmitSchedule();
                oStay.UpdateRoomInformation(GlobalVar.RoomStatus.Filled);
                oStay.Calculate();
                oSession.CommitChanges();
                btnCalculate.PerformClick();

                luRoomType.EditValue = null;
                luPriceType.EditValue = null;
                luRoomPrice.EditValue = null;
                seDurationInHours.Value = 0;
                seDurationInDays.Value = 0;
                deFrom.DateTime = DateTime.Now;
                deUntil.DateTime = DateTime.Now;
                seNoOfGuest.Value = 1;
            }
        }

        private void frmDlgMasterStay2_Load(object sender, EventArgs e)
        {
            luRoomType.Properties.DataSource = AvailableRoomType;
            luPriceType.Properties.DataSource = AvailablePriceType;
            luRoomPrice.Properties.DataSource = AvailableRoom;

            deFrom.DateTime = DateTime.Now;
            deUntil.DateTime = DateTime.Now;
        }

        public XPCollection<PriceType> AvailablePriceType
        {
            get
            {
                if (luRoomType.EditValue != null)
                    return new XPCollection<PriceType>(oSession, new BinaryOperator("RoomType", luRoomType.EditValue));
                return null;
            }
        }

        public XPCollection<Room> AvailableRoom
        {
            get
            {
                    if (luRoomType.EditValue != null && luPriceType.EditValue != null)
                    {
                        RoomType oRoomType = oSession.GetObjectByKey<RoomType>(luRoomType.EditValue);
                        PriceType oPriceType = oSession.GetObjectByKey<PriceType>(luPriceType.EditValue);
                        if (luRoomPrice.EditValue != null)
                        {
                            Room oRoom = oSession.GetObjectByKey<Room>(luRoomPrice.EditValue);
                            return new XPCollection<Room>(oSession, CriteriaOperator.Parse(String.Format("RoomPrices[PriceType.Code = '{0}'] AND (RoomStatus = 0 OR Oid = '{1}')", oPriceType.Code, oRoom.Oid)));
                        }
                        return new XPCollection<Room>(oSession, CriteriaOperator.Parse(String.Format("RoomPrices[PriceType.Code = '{0}'] AND RoomStatus = 0", oPriceType.Code)));
                    }
                return null;
            }
        }

        public XPCollection<RoomType> AvailableRoomType
        {
            get { return new XPCollection<RoomType>(oSession); }
        }

        private void luPriceType_Leave(object sender, EventArgs e)
        {
            luRoomPrice.Properties.DataSource = null;
            luRoomPrice.Properties.DataSource = AvailableRoom;
            seDurationInDays.Value = 0;
            seDurationInHours.Value = 0;
            PriceType oPriceType = null ;
            if (luPriceType.EditValue != null)
            {
                oPriceType = oSession.GetObjectByKey<PriceType>(luPriceType.EditValue);
            }
            

            if (oPriceType != null && oPriceType.IsShortTime)
            {
                seDurationInHours.Value = oPriceType.Duration;
                seDurationInDays.Value = 0;
                seDurationInDays.Properties.ReadOnly = true;
                seDurationInHours.Properties.ReadOnly = false;
            }
            else
            {
                seDurationInHours.Value = 0;
                seDurationInHours.Properties.ReadOnly = true;
                seDurationInDays.Properties.ReadOnly = false;
            }
        }

        private void luRoomType_Leave(object sender, EventArgs e)
        {
            luPriceType.Properties.DataSource = null;
            luRoomPrice.Properties.DataSource = null;
            luPriceType.Properties.DataSource = AvailablePriceType;
        }

        private void seNoOfGuest_Enter(object sender, EventArgs e)
        {
            seNoOfGuest.SelectAll();
        }

        private void seDurationInDays_Enter(object sender, EventArgs e)
        {
            seDurationInDays.SelectAll();
        }

        private void seDurationInHours_Enter(object sender, EventArgs e)
        {
            seDurationInHours.SelectAll();
        }

        private void seDurationInDays_EditValueChanged(object sender, EventArgs e)
        {
            if (seDurationInDays.Value != 0)
            {
                seDurationInHours.Value = 0;
            }
            GetUntilTime(sender, e);
        }

        private void seDurationInHours_EditValueChanged(object sender, EventArgs e)
        {
            if (seDurationInHours.Value != 0)
            {
                seDurationInDays.Value = 0;
            }
            GetUntilTime(sender, e);
        }

        private void GetUntilTime(object sender, EventArgs e)
        {
            if (luPriceType.EditValue != null)
            {
                PriceType oPriceType;
                oPriceType = oSession.GetObjectByKey<PriceType>(luPriceType.EditValue);
                if (oPriceType.IsShortTime)
                {
                    deUntil.DateTime = GlobalVar.GetCheckOutTime(deFrom.DateTime.AddHours((double)seDurationInHours.Value), oPriceType.IsShortTime);
                    if (seDurationInDays.Value != 0) { seDurationInDays.Value = 0; }
                    return;
                }
                else
                {
                    deUntil.DateTime = GlobalVar.GetCheckOutTime(deFrom.DateTime.AddDays((double)seDurationInDays.Value), oPriceType.IsShortTime);
                    if (seDurationInHours.Value != 0) { seDurationInHours.Value = 0; }
                }
            }
        }
    }
}