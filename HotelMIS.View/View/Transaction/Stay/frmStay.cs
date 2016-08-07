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
    public partial class frmStay : Form
    {
        private bool flag = true;
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private UnitOfWork oSession;
        private Stay oStay;
        private MasterStay oMasterStay;

        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        const int MF_BYCOMMAND = 0;
        const int MF_DISABLED = 2;
        const int SC_CLOSE = 0xF060;

        public frmStay(UnitOfWork prmSession, MasterStay prmMasterStay , Stay prmRoom = null)
        {
            InitializeComponent();
            SetEvent();
            oSession = prmSession;
            oMasterStay = prmMasterStay;
            if (prmRoom != null)
                oStay = prmRoom;
            ResetData();
            LoadCombo();
            if (oStay.Guest == null)
            {
                oStay.Guest = oMasterStay.Guest;
            }
            oErrorCollection = new List<ValidationClass>();
            if (oStay.MasterStay.IsReceiptPrinted)
            {
                DisableView();
            }
        }

        public void Recalculate()
        {
            btnNewGuest.Focus();
            isValidForm = true;
            CheckDuration();
            flag = false;
            CheckRoom();

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
            oStay.Calculate();
        }

        public void SetEvent()
        {
            var sm = GetSystemMenu(Handle, false);
            EnableMenuItem(sm, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);

            luRoomType.Leave += luRoomType_Leave;
            luPriceType.Leave += luPriceType_Leave;
        }

        private void btnCalculate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (oStay.IsCheckOut == true || oStay.MasterStay.IsReceiptPrinted)
            {
                return;
            }
            Recalculate();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            ResetData();
        }

        private bool CanCheckOut()
        {
            int totalRoom = 0;
            foreach (Stay obj in oMasterStay.Stays)
            {
                if (obj.Status == 0)
                {
                    totalRoom += 1;
                }
            }
            if (totalRoom > 1)
            {
                return true;
            }
            if (oMasterStay.PaymentStatus != GlobalVar.PaymentStatus.UnderPaid )
            {
                return true;
            }
            return false;
        }

        private void btnCheckOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oStay.Status != GlobalVar.TransactionStatus.Entry || oStay.IsCheckOut == true)
                {
                    return;
                }
                else
                {
                    if (!FormHelper.QuestionMessage("Are you sure want to Check Out the selected Guest ?"))
                    {
                        return;
                    }
                    else
                    {
                        if (!CanCheckOut())
                        {
                            FormHelper.ErrorMessage("Cannot checkout last stay before complete the payment.");
                            return;
                        }
                        Recalculate();
                        ValidateForm();
                        if (isValidForm)
                        {
                            SaveForm();

                            if (oStay.MasterStay.TotalPaid < oStay.MasterStay.Total)
                            {
                                if (!FormHelper.QuestionMessage("Payment is not completed, are you sure want to continue ?"))
                                    return;
                            }
                            CheckOut oCreatedCheckOut = oStay.CreateCheckOut();
                            frmDlgCheckOut oForm = new frmDlgCheckOut(oSession, ref oCreatedCheckOut);
                            oForm.ShowDialog();
                            
                            if (!oCreatedCheckOut.IsDeleted)
                            {
                                oStay.DeleteSchedule();
                                oStay.CheckOutBy = oSession.GetObjectByKey<AppUser>(GlobalVar.CurrentLoginUser.Oid);
                                oStay.Status = GlobalVar.TransactionStatus.Processed;
                                try
                                {
                                    oCreatedCheckOut.DeleteSchedule();
                                    oCreatedCheckOut.SubmitSchedule();
                                    oSession.CommitChanges();
                                    this.Close();
                                }
                                catch (Exception ex)
                                {
                                    FormHelper.ErrorMessage(ex.Message);
                                }
                            }
                            else
                            {
                                oSession.RollbackTransaction();
                                ResetData();
                            }
                            oMasterStay.CheckRoomCheckout();
                            oSession.CommitChanges();
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
            if (oSession.IsNewObject(oStay))
            {
                oStay.Delete();
            }
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
            txtGuestName.Text = string.Empty;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oStay.Status != GlobalVar.TransactionStatus.Entry)
                {
                    return;
                }
                if (FormHelper.QuestionMessage("Are you sure want to save this data ?"))
                {
                    Recalculate();
                    ValidateForm();
                    if (isValidForm)
                    {
                        if (deUntil.DateTime < DateTime.Now.Date)
                        {
                            FormHelper.ErrorMessage("Invalid | Date Until must be greater than today");
                            oStay.Reload();
                            return;
                        }
                        SaveForm();
                        oStay.UpdateRoomInformation(GlobalVar.RoomStatus.Filled);
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
            oStay.IsRoomChanged();
            oStay.DeleteSchedule();
            oStay.SubmitSchedule();
            oSession.CommitChanges();
        }

        private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "btnDelete")
                switch (((LookUpEdit)sender).Name)
                {
                    case "luGuest":
                        oStay.Guest = null;
                        break;

                    case "luRoomType":
                        oStay.RoomType = null;
                        oStay.PriceType = null;
                        oStay.Room = null;
                        break;

                    case "luPriceType":
                        oStay.PriceType = null;
                        oStay.Room = null;
                        break;

                    case "luRoomPrice":
                        oStay.Room = null;
                        break;
                }
        }

        private void GetUntilTime(object sender, EventArgs e)
        {
            oStay.GetUntilTime();
            deUntil.EditValue = oStay.DateCheckOut;
        }

        private void LoadCombo()
        {
            luGuest.Properties.DataSource = oStay.AvailableGuest;
            luRoomType.Properties.DataSource = oStay.AvailableRoomType;
            luPriceType.Properties.DataSource = oStay.AvailablePriceType;
            luRoomPrice.Properties.DataSource = oStay.AvailableRoom;
        }

        private void luPriceType_Leave(object sender, EventArgs e)
        {
            luRoomPrice.Properties.DataSource = null;
            luRoomPrice.Properties.DataSource = oStay.AvailableRoom;
            oStay.DurationInDays = 0;
            oStay.DurationInHours = 0;
            if (oStay.PriceType != null && oStay.PriceType.IsShortTime)
            {
                seDurationInHours.Value = oStay.PriceType.Duration;
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
            luPriceType.Properties.DataSource = oStay.AvailablePriceType;
            if ((Guid)luRoomPrice.EditValue != new Guid())
            {
                luRoomPrice.Properties.DataSource = oStay.AvailableRoom;
            }
        }

        private void ResetData()
        {
            if (oStay == null)
            {
                oStay = new Stay(oSession);
            }
            if (oSession.IsNewObject(oStay))
            {
                oStay.MasterStay = oMasterStay;
                oStay.CheckInBy = oSession.GetObjectByKey<AppUser>(GlobalVar.CurrentLoginUser.Oid);
                oStay.Breakfast = false;
                oStay.CheckOutBy = null;
                oStay.DateCheckIn = DateTime.Now;
                oStay.DateCheckOut = DateTime.Now.AddDays(1);
                oStay.DurationInDays = 0;
                oStay.DurationInHours = 0;
                oStay.ExtraBed = false;
                oStay.Guest = null;
                oStay.GuestName = string.Empty;
                oStay.NoOfGuest = 0;
                oStay.Note = string.Empty;
                oStay.PriceType = null;
                oStay.Room = null;
                oStay.RoomType = null;
                oStay.RoomRate = 0;
                oStay.Status = GlobalVar.TransactionStatus.Entry;
                oStay.Total = 0;
            }
            else
            {
                oStay.Reload();
            }
            bs.DataSource = oStay;
            seDurationInDays.Value = (decimal)oStay.DurationInDays;
            seDurationInHours.Value = (decimal)oStay.DurationInHours;
            bsPayment.DataSource = oStay.PaymentVouchers();
            if (oStay.Status != GlobalVar.TransactionStatus.Entry)
            {
                panelControl1.Enabled = false;
            }
        }

        #region "Form Validation"

        private void CheckDate()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (deFrom.DateTime == new DateTime())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Date From is required";
                oErrorCollection.Add(oValidationClass);
            }
            if (deUntil.DateTime == new DateTime())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Date Until is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void PrintCheckInReceipt()
        {

            String rptCheckInReceipt = String.Format("{0}\\{1}.repx", Application.StartupPath, "CheckInReceipt");

            XtraReport oRpt = new XtraReport();
            oRpt.DataSource = GetDataSource();
            oRpt.LoadLayout(rptCheckInReceipt);
            oRpt.ExportToPdf(String.Format("{0}\\CheckInReceipt\\{1}_{2:yyyyMMddHHmmss}.pdf", Application.StartupPath, oStay.RoomCode + "-" + oStay.GuestName, DateTime.Now));
            using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
            {
                objtool.Print();
            }
            //using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
            //{
            //    objRibbonDesigner.OpenReport(oRpt);
            //    objRibbonDesigner.FileName = rptCheckInReceipt;
            //    objRibbonDesigner.ShowDialog();
            //}
        }

        private DataSet GetDataSource()
        {
            string strQuery = "";
            strQuery += "SELECT GuestName, Guest.CompanyName, NoOfGuest, SUM(DepositAmount) DepositAmount, SUM(RoomAmount) PaidAmount, " +
                        "       Stay.DateCheckIn, Stay.DateCheckOut,PriceType.Name PriceType, RoomType.Name RoomType, Room.Name Room, " +
                        "        CASE WHEN Stay.ExtraBed = 1 THEN 'Yes' ELSE 'No' END ExtraBed, " +
                        "        CASE WHEN Stay.Breakfast = 1 THEN 'Yes' ELSE 'No' END Breakfast, " +
                        "        Stay.SubTotal, Stay.DiscountByAmount, Stay.DiscountByPercent, Stay.Total, AppUser.Name CheckInStaff " +
                        "FROM Stay " +
                        "LEFT JOIN PaymentVoucher ON Stay.Oid = PaymentVoucher.PaymentFor " +
                        "LEFT JOIN Guest ON Guest.Oid = Stay.Guest " +
                        "LEFT JOIN PaymentMethod ON PaymentMethod.Oid = PaymentVoucher.PaymentMethod " +
                        "INNER JOIN Room ON Room.Oid = Stay.Room " +
                        "INNER JOIN RoomType ON RoomType.Oid = Stay.RoomType " +
                        "INNER JOIN PriceType ON PriceType.Oid = Stay.PriceType " +
                        "INNER JOIN AppUser ON AppUser.Oid = Stay.CheckInBy " +
                        "WHERE Stay.Oid = '" + oStay.Oid.ToString() + "' " +
                        "GROUP BY " +
                        "GuestName, Guest.CompanyName, NoOfGuest, Stay.DateCheckIn, Stay.DateCheckOut,PriceType.Name, RoomType.Name, Room.Name, " +
                        "        Stay.ExtraBed, Stay.Breakfast, " +
                        "        Stay.SubTotal, Stay.DiscountByAmount, Stay.DiscountByPercent, Stay.Total, AppUser.Name ";

            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }

        private void CheckDuration()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (seDurationInHours.Value == 0 && seDurationInDays.Value == 0)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Duration is invalid";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckGuest()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtGuestName.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Guest is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckPriceType()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luPriceType.EditValue == new Guid())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Price Type is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckRoom()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luRoomPrice.EditValue == new Guid() || luRoomPrice.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Room is required";
                oErrorCollection.Add(oValidationClass);
            }
            else
            {
                Stay findedRoom = oStay.CheckRoom();
                if (findedRoom != null)
                {
                    oValidationClass.ErrorType = "Rule";
                    oValidationClass.Description = String.Format("Room is currently in used by {0} \r\n From {1} until {2}.", findedRoom.GuestName, findedRoom.DateCheckIn.ToString("dd-MM-yyyy HH:mm"), findedRoom.DateCheckOut.ToString("dd-MM-yyyy HH:mm"));
                    oErrorCollection.Add(oValidationClass);
                }
            }
        }

        private void CheckRoomRate()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (seRoomRate.Value == 0)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Room Rate is invalid.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckRoomType()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luRoomType.EditValue == new Guid())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Room Type is required";
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
            CheckDate();
            CheckRoomType();
            CheckPriceType();
            CheckDuration();
            if (flag != false)
            {
                CheckRoom();
            }
            flag = true;
            CheckRoomRate();
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

        private void btnCancelCheckIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oStay.IsCheckOut == true || oStay.MasterStay.IsReceiptPrinted)
                {
                    return;
                }
                if (FormHelper.QuestionMessage("Are you sure want to cancel check in for this data ?"))
                {
                    if (oStay.Status != GlobalVar.TransactionStatus.Cancel)
                    {
                        if (oStay.Note == string.Empty || oStay.Note == null)
                        {
                            FormHelper.InformationMessage("Rule | Must input note for cancel data.");
                            return;
                        }
                        if (!oStay.IsStayReferencedByPaymentOrCheckout())
                        {
                            oStay.CancelRecord();
                            WorkingShiftDetail.CreateWorkingLog(oSession, "Cancel CheckIn " + oStay.ToString, 0, 0, 0);
                            oSession.CommitChanges();
                            this.Close();
                        }
                        else
                        {
                            FormHelper.ErrorMessage("Stay is still used by PaymentVoucher / Checkout record.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FormHelper.ErrorMessage(ex.Message);
            }
        }

        private void PrintReceipt()
        {
            if (FormHelper.QuestionMessage("Are you sure want to print check in receipt for this data ?"))
                        {
                            if (oStay.MasterStay.IsReceiptPrinted)
                            {
                                if (!FormHelper.QuestionMessage("Receipt is already printed before, do you want to re-print the receipt ?"))
                                {
                                    return;
                                }
                            }
                            if (oStay.Status == GlobalVar.TransactionStatus.Entry)
                            {
                                if (oStay.Oid != Guid.Empty)
                                {
                                    PrintCheckInReceipt();
                                    oStay.Save();
                                    WorkingShiftDetail.CreateWorkingLog(oSession, "Print Receipt " + oStay.ToString, 0, 0, 0);
                                    
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

        private void DisableView()
        {
            luGuest.Properties.ReadOnly = true;
            //luRoomPrice.Properties.ReadOnly = true;
            luRoomType.Properties.ReadOnly = true;
            btnNewGuest.Enabled = false;
            luPriceType.Properties.ReadOnly = true;
            txtGuestName.Properties.ReadOnly = true;
            chkGuestIsCompany.Properties.ReadOnly = true;
            seDurationInDays.Properties.ReadOnly = true;
            seDurationInHours.Properties.ReadOnly = true;
            seNoOfGuest.Properties.ReadOnly = true;
            chkExtraBed.Properties.ReadOnly = true;
            chkBreakfast.Properties.ReadOnly = true;
            meNote.Properties.ReadOnly = true;
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
            oStay.DurationInDays = (double)seDurationInDays.Value;
            if (oStay.DurationInDays != 0)
            {
                seDurationInHours.Value = 0;
            }
            GetUntilTime(sender, e);
        }

        private void seDurationInHours_EditValueChanged(object sender, EventArgs e)
        {
            oStay.DurationInHours = (double)seDurationInHours.Value;
            if (oStay.DurationInHours != 0)
            {
                seDurationInDays.Value = 0;
            }
            GetUntilTime(sender,e);
        }
    }
}