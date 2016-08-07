using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraReports.UserDesigner;
using System.IO;

namespace HotelMIS.View
{
    public partial class frmReservation : Form
    {
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private Reservation oReservation;
        private UnitOfWork oSession;

        public frmReservation(Reservation prmReservation = null)
        {
            InitializeComponent();
            deFrom.DateTimeChanged += DateTimeChanged;
            deUntil.DateTimeChanged += DateTimeChanged;
            luPriceType.Leave += DateTimeChanged;
            deFrom.Leave += DateTimeChanged;
            deUntil.Leave += DateTimeChanged;

            oSession = SessionProvider.GetNewUnitOfWork();
            if (prmReservation != null)
                oReservation = oSession.GetObjectByKey<Reservation>(prmReservation.Oid);
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

        private void btnCancelReservation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (oReservation.Status == GlobalVar.TransactionStatus.Entry)
            {
                if (FormHelper.QuestionMessage("Are you sure want to cancel this reservation ?"))
                {
                    if (!oReservation.IsReservationReferencedInStay())
                    {
                        oReservation.CancelRecord();
                        WorkingShiftDetail.CreateWorkingLog(oSession, "Cancel " + oReservation.ToString(), 0, 0, 0);
                        oSession.CommitChanges();
                        this.Close();
                    }
                    else
                    {
                        FormHelper.ErrorMessage("Reservation is still used by Stay / Check In record.");
                    }
                }
            }
        }

        private void btnCheckIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oReservation.Status == GlobalVar.TransactionStatus.Entry)
                {
                    if (FormHelper.QuestionMessage("Are you sure want to check in this reservation ?"))
                    {
                        ValidateForm();
                        if (isValidForm)
                        {
                            SaveForm();
                            MasterStay oCreatedStay = oReservation.CheckInReservation();
                            frmDlgMasterStay2 oForm = new frmDlgMasterStay2(oSession, ref oCreatedStay);
                            oForm.ShowDialog();

                            if (!oCreatedStay.IsDeleted)
                            {
                                oReservation.Status = GlobalVar.TransactionStatus.Processed;
                                oReservation.DeleteSchedule();
                                try
                                {
                                    WorkingShiftDetail.CreateWorkingLog(oSession, "CheckIn " + oReservation.ToString(), 0, 0, 0);
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
            oSession.RollbackTransaction();
            ResetData();
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
                if (oReservation.Status != GlobalVar.TransactionStatus.Entry)
                {
                    return;
                }
                if (FormHelper.QuestionMessage("Are you sure want to save this data ?"))
                {
                    ValidateForm();
                    if (isValidForm)
                    {
                        SaveForm();
                        this.Close();
                    }
                }
            }
            catch (ObjectDisposedException ex)
            {
                FormHelper.ErrorMessage(ex.Message);
            }
            catch (Exception ex)
            {
                FormHelper.ErrorMessage(ex.Message);
            }
        }

        private void CheckTime()
        {
            if (oReservation.PriceType != null)
            {
                if (oReservation.PriceType.IsShortTime)
                {
                    oReservation.DurationInDays = 0;
                    oReservation.DurationInHours = GlobalVar.CountDurationInHours(deFrom.DateTime, deUntil.DateTime, 0);
                }
                else
                {
                    oReservation.DurationInDays = GlobalVar.CountDurationInDays(deFrom.DateTime, deUntil.DateTime, 0);
                    oReservation.DurationInHours = 0;
                }
            }
            else
            {
                oReservation.DurationInDays = GlobalVar.CountDurationInDays(deFrom.DateTime, deUntil.DateTime, 3);
                oReservation.DurationInHours = GlobalVar.CountDurationInHours(deFrom.DateTime, deUntil.DateTime, 3);
            }
        }

        private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "btnDelete")
                switch (((LookUpEdit)sender).Name)
                {
                    case "luGuest":
                        oReservation.Guest = null;
                        break;

                    case "luRoomType":
                        oReservation.RoomType = null;
                        oReservation.PriceType = null;
                        break;

                    case "luPriceType":
                        oReservation.PriceType = null;
                        break;
                }
        }

        private void DateTimeChanged(object sender, EventArgs e)
        {
            CheckTime();
        }

        private void LoadCombo()
        {
            luGuest.Properties.DataSource = oReservation.AvailableGuest;
            luRoomType.Properties.DataSource = oReservation.AvailableRoomType;
            luPriceType.Properties.DataSource = oReservation.AvailablePriceType;
            luPaymentMethod.Properties.DataSource = oReservation.AvailablePaymentMethod;
        }

        private void luRoomType_EditValueChanged(object sender, EventArgs e)
        {
            oReservation.RoomTypeOid = (Guid)((LookUpEdit)(sender)).EditValue;
            luPriceType.Properties.DataSource = null;
            luPriceType.Properties.DataSource = oReservation.AvailablePriceType;
        }

        private void ResetData()
        {
            if (oReservation == null)
            {
                oReservation = new Reservation(oSession);
            }
            if (oSession.IsNewObject(oReservation))
            {
                oReservation.Guest = null;
                oReservation.GuestName = String.Empty;
                oReservation.Note = string.Empty;
                oReservation.PriceType = null;
                oReservation.RoomType = null;
                oReservation.DateCheckIn = DateTime.Now;
                oReservation.DateCheckOut = DateTime.Now.AddDays(1);
                oReservation.DurationInDays = 0;
                oReservation.DurationInHours = 0;
                oReservation.Status = GlobalVar.TransactionStatus.Entry;
            }
            else
            {
                oReservation.Reload();
            }
            bs.DataSource = oReservation;
            if (oReservation.Status != GlobalVar.TransactionStatus.Entry)
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
            oReservation.DeleteSchedule();
            oReservation.SubmitSchedule();
            oSession.CommitChanges();
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

        private void CheckDuration()
        {
            ValidationClass oValidationClass = new ValidationClass();
            CheckTime();
            if (seDurationInHours.Value < 1 && seDurationInDays.Value < 1)
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

        private void ValidateForm()
        {
            isValidForm = true;
            CheckGuest();
            CheckDate();
            CheckRoomType();
            CheckPriceType();
            CheckDuration();

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

        private void btnPrintReservation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FormHelper.QuestionMessage("Are you sure want to print this reservation ?"))
            {
                ValidateForm();
                if (isValidForm)
                {
                    SaveForm();
                    if (oReservation.Status != GlobalVar.TransactionStatus.Cancel)
                    {
                        String rptReservationPay = String.Format("{0}\\{1}.repx", Application.StartupPath, "ReservationPay");
                        if (oReservation.DepositAmount > 0)
                        {
                            XtraReport oRpt = new XtraReport();
                            oRpt.DataSource = GetDataSourceReservationPayment(oReservation);
                            oRpt.LoadLayout(rptReservationPay);
                            if (!Directory.Exists(String.Format("{0}\\Reservation", Application.StartupPath)))
                            {
                                Directory.CreateDirectory(String.Format("{0}\\Reservation"));
                            }
                            oRpt.ExportToPdf(String.Format("{0}\\Reservation\\{1}_{2:yyyyMMddHHmmss}.pdf", Application.StartupPath, oReservation.Guest.Name.ToString(), DateTime.Now));
                            //using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
                            //{
                            //    objRibbonDesigner.OpenReport(oRpt);
                            //    objRibbonDesigner.FileName = rptReservationPay;
                            //    objRibbonDesigner.ShowDialog();
                            //}
                            using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
                            {
                                objtool.Print();
                            }
                            oReservation.IsReceiptPrinted = true;
                            WorkingShiftDetail.CreateWorkingLog(oSession, "Reprint Reservation Form " + oReservation.Guest.Code + " " + oReservation.Guest.Name, 0, 0, 0);
                            oSession.CommitChanges();
                        }
                    }
                    else
                    {
                        FormHelper.InformationMessage("Cannot print canceled reservation");
                    }
                }
            }
        }

        private DataSet GetDataSourceReservationPayment(Reservation prmReservation)
        {
            string strQuery = "";
            strQuery += "SELECT Guest.Code GuestCode, Guest.Name GuestName, Guest.DateOfBirth GuestDOB, ISNULL(Guest.KTP,'') + ' ' + ISNULL(Guest.Passport,'') ICNoMaster, \r\n " +
                            "Nationality.Name GuestNationality, Reservation.NoOfGuest NoOfGuest, Reservation.NoOfRoom NoOfRoom, \r\n " +
                            "PaymentMethod.Name PaymentMethod, Reservation.DepositAmount, \r\n " +
                            "Reservation.ReferenceNo, Reservation.ContactNumber, \r\n " +
                            "CASE WHEN DurationInDays <> 0 THEN CONVERT(nvarchar(10),DurationInDays) ELSE CONVERT(nvarchar(10),DurationInDays) + ' hrs' END NightOfStay, \r\n " +
                            "Reservation.DateCheckIn, Reservation.DateCheckOut,PriceType.Name PriceType, RoomType.Name RoomType, AppUser.Name Responsible  \r\n " +
                            "FROM Reservation  \r\n " +
                            "LEFT JOIN PaymentMethod ON PaymentMethod.Oid = Reservation.PaymentMethod   \r\n " +
                            "INNER JOIN Guest ON Guest.Oid = Reservation.Guest  \r\n " +
                            "LEFT JOIN Nationality ON Nationality.Oid = Guest.Nationality \r\n " +
                            "INNER JOIN RoomType ON RoomType.Oid = Reservation.RoomType  \r\n " +
                            "INNER JOIN PriceType ON PriceType.Oid = Reservation.PriceType  \r\n " +
                            "INNER JOIN TransactionBase ON TransactionBase.Oid = Reservation.Oid   \r\n " +
                            "INNER JOIN AppUser ON AppUser.Code = TransactionBase.UserCreated   \r\n " +
                            " WHERE Reservation.Oid = '" + prmReservation.Oid.ToString() + "' ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }
    }
}