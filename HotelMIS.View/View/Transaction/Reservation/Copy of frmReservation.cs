using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using HotelMIS.Model;

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
                        WorkingShiftDetail.CreateWorkingLog(oSession, "Cancel " + oReservation.ToString(), 0);
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
                            Stay oCreatedStay = oReservation.CheckInReservation();
                            frmDlgMasterStay oForm = new frmDlgMasterStay(oSession, ref oCreatedStay);
                            oForm.ShowDialog();

                            if (!oCreatedStay.IsDeleted)
                            {
                                oReservation.Status = GlobalVar.TransactionStatus.Processed;
                                oReservation.DeleteSchedule();
                                try
                                {
                                    WorkingShiftDetail.CreateWorkingLog(oSession, "CheckIn " + oReservation.ToString(), 0);
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
    }
}