using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using System.Runtime.InteropServices;

namespace HotelMIS.View
{
    public partial class frmDlgStay : Form
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

        public frmDlgStay(UnitOfWork prmSession,ref Stay prmStay)
        {
            InitializeComponent();
            SetEvent();
            oSession = prmSession;
            oMasterStay = prmStay;
            ResetData();
            LoadCombo();
            oErrorCollection = new List<ValidationClass>();
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
            oMasterStay.Calculate();
        }

        public void SetEvent()
        {
            var sm = GetSystemMenu(Handle, false);
            EnableMenuItem(sm, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);
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
            ResetData();
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
            txtGuestName.Text = string.Empty;
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
                    ValidateForm();
                    if (isValidForm)
                    {
                        bs.EndEdit();
                        oMasterStay.DeleteSchedule();
                        oMasterStay.SubmitSchedule();
                        oMasterStay.UpdateRoomInformation(GlobalVar.RoomStatus.Filled);
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
                    case "luGuest":
                        oMasterStay.Guest = null;
                        break;

                    case "luRoomType":
                        oMasterStay.RoomType = null;
                        oMasterStay.PriceType = null;
                        oMasterStay.Room = null;
                        break;

                    case "luPriceType":
                        oMasterStay.PriceType = null;
                        oMasterStay.Room = null;
                        break;

                    case "luRoomPrice":
                        oMasterStay.Room = null;
                        break;
                }
        }

        private void GetUntilTime(object sender, EventArgs e)
        {
            oMasterStay.GetUntilTime();
        }

        private void LoadCombo()
        {
            luGuest.Properties.DataSource = oMasterStay.AvailableGuest;
            luRoomType.Properties.DataSource = oMasterStay.AvailableRoomType;
            luPriceType.Properties.DataSource = oMasterStay.AvailablePriceType;
            luRoomPrice.Properties.DataSource = oMasterStay.AvailableRoom;
        }

        private void luPriceType_Leave(object sender, EventArgs e)
        {
            luRoomPrice.Properties.DataSource = null;
            luRoomPrice.Properties.DataSource = oMasterStay.AvailableRoom;
            seDurationInDays.Value = 0;
            seDurationInHours.Value = 0;
            if (oMasterStay.PriceType != null && oMasterStay.PriceType.IsShortTime)
            {
                seDurationInHours.Value = oMasterStay.PriceType.Duration;
            }
        }

        private void luRoomType_Leave(object sender, EventArgs e)
        {
            luPriceType.Properties.DataSource = null;
            luRoomPrice.Properties.DataSource = null;
            luPriceType.Properties.DataSource = oMasterStay.AvailablePriceType;
            if ((Guid)luRoomPrice.EditValue != new Guid())
            {
                luRoomPrice.Properties.DataSource = oMasterStay.AvailableRoom;
            }
        }

        private void ResetData()
        {
            if (oSession.IsNewObject(oMasterStay))
            {
                oMasterStay.Breakfast = false;
                oMasterStay.BreakfastPrice = 0;
                oMasterStay.DiscountByAmount = 0;
                oMasterStay.DiscountByPercent = 0;
                oMasterStay.ExtraBed = false;
                oMasterStay.ExtraBedPrice = 0;
                oMasterStay.NoOfGuest = 0;
                oMasterStay.Room = null;
                oMasterStay.RoomRate = 0;
                oMasterStay.Status = GlobalVar.TransactionStatus.Entry;
                oMasterStay.SubTotal = 0;
                oMasterStay.Total = 0;
            }
            else
            {
                oMasterStay.Reload();
            }
            bs.DataSource = oMasterStay;
            if (oMasterStay.Status != GlobalVar.TransactionStatus.Entry)
            {
                foreach (Control oControl in this.Controls)
                {
                    if (oControl.Name == "layoutControl1")
                        oControl.Enabled = false;
                }
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
                Stay findedRoom = oMasterStay.CheckRoom();
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

        private void seNoOfGuest_Click(object sender, EventArgs e)
        {
            seNoOfGuest.SelectAll();
        }

        private void seDiscountByPercent_Click(object sender, EventArgs e)
        {
            seDiscountByPercent.SelectAll();
        }

        private void seDiscountByAmount_Enter(object sender, EventArgs e)
        {
            seDiscountByAmount.SelectAll();
        }
    }
}