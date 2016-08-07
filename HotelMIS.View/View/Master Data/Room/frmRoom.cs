using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;
using DevExpress.Data.Filtering;

namespace HotelMIS.View
{
    public partial class frmRoom : Form
    {
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private Room oRoom;
        private UnitOfWork oSession;

        #region "Form Operation"

        public frmRoom(Room prmRoom = null)
        {
            InitializeComponent();
            oSession = SessionProvider.GetNewUnitOfWork();
            if (prmRoom != null)
                oRoom = oSession.GetObjectByKey<Room>(prmRoom.Oid);
            ResetData();
            LoadCombo();
            oErrorCollection = new List<ValidationClass>();
            if (GlobalVar.CurrentLoginUser.UserRole.Code == "ADM")
            {
                btnDeleteDetail.Enabled = true;
            }
            else
            {
                btnDeleteDetail.Enabled = false;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            oSession.Dispose();
        }

        private void btnAvailable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormHelper.QuestionMessage("Are you sure want to set to Available ?"))
                return;
            if (oRoom.RoomStatus != GlobalVar.RoomStatus.Maintenance)
            {
                FormHelper.ErrorMessage("Room must be in Maintenance status");
                return;
            }
            oRoom.RoomStatus = GlobalVar.RoomStatus.Vacant;
            oRoom.MaintenanceStatus = string.Empty;
            ValidateForm();
            if (isValidForm)
            {
                bs.EndEdit();
                oSession.CommitChanges();
                this.Close();
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            ResetData();
            btnRefreshDetail.PerformClick();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            ResetData();
            this.Close();
        }

        private void btnMaintenance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (oRoom.RoomStatus != GlobalVar.RoomStatus.Vacant)
            {
                FormHelper.ErrorMessage("Room must be in Vacant status");
                return;
            }
            using (frmDlgMaintenance frmDlg = new frmDlgMaintenance())
            {
                frmDlg.ShowDialog();
                if (frmDlg.strReason != string.Empty || frmDlg.strReason != "")
                {
                    oRoom.RoomStatus = GlobalVar.RoomStatus.Maintenance;
                    oRoom.MaintenanceStatus = frmDlg.strReason;
                    ValidateForm();
                    if (isValidForm)
                    {
                        bs.EndEdit();
                        oSession.CommitChanges();
                        this.Close();
                    }
                }
            }
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
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

        #endregion "Form Operation"

        #region "Detail button"

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            RoomPrice CurrentRow = ((RoomPrice)((GridView)gcRoomPrices.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                if (FormHelper.QuestionMessage("Are you sure want to delete this record ?"))
                {
                    CurrentRow.Delete();
                    WorkingShiftDetail.CreateWorkingLog(oSession, "Delete " + CurrentRow.ToString(), 0, 0, 0);
                }
            }
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            RoomPrice CurrentRow = ((RoomPrice)((GridView)gcRoomPrices.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                using (frmRoomPrice oForm = new frmRoomPrice(oSession, CurrentRow))
                {
                    oForm.ShowDialog();
                }
            }
        }

        private void btnNewDetail_Click(object sender, EventArgs e)
        {
            using (frmRoomPrice oForm = new frmRoomPrice(oSession, oRoom))
            {
                oForm.ShowDialog();
                btnRefreshDetail.PerformClick();
            }
        }

        private void btnRefreshDetail_Click(object sender, EventArgs e)
        {
            bsDetail.DataSource = oRoom.RoomPrices;
        }

        #endregion "Detail button"

        #region "Function"

        private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "btnDelete")
                switch (((LookUpEdit)sender).Name)
                {
                    case "luRoomType":
                        oRoom.RoomType = null;
                        break;
                }
        }

        private void LoadCombo()
        {
            luRoomType.Properties.DataSource = oRoom.AvailableRoomType;
        }

        private void ResetData()
        {
            if (oRoom == null)
            {
                oRoom = new Room(oSession);
            }
            if (oSession.IsNewObject(oRoom))
            {
                oRoom.Code = String.Empty;
                oRoom.Name = String.Empty;
                oRoom.Floor = String.Empty;
                oRoom.RoomType = null;
                oRoom.MaintenanceStatus = String.Empty;
            }
            else
            {
                oRoom.Reload();
                oRoom.RoomPrices.Reload();
                foreach (RoomPrice objRP in oRoom.RoomPrices)
                {
                    objRP.Reload();
                }
            }
            bs.DataSource = oRoom;
            bsDetail.DataSource = oRoom.RoomPrices;
        }

        #endregion "Function"

        #region "Form Validation"

        private void CheckCode()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtCode.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Code is required";
                oErrorCollection.Add(oValidationClass);
            }
            if (oSession.FindObject<Room>(PersistentCriteriaEvaluationBehavior.InTransaction,
              GroupOperator.And(new BinaryOperator("Oid", oRoom.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("Code", txtCode.Text))) != null)
            {
                oValidationClass.ErrorType = "Duplicate";
                oValidationClass.Description = "Code must be unique.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckFloor()
        {
            if (txtFloor.Text == string.Empty)
            {
                ValidationClass oValidationClass = new ValidationClass();
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Floor is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckName()
        {
            if (txtName.Text == string.Empty)
            {
                ValidationClass oValidationClass = new ValidationClass();
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Name is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckRoomType()
        {
            if ((Guid)luRoomType.EditValue == new Guid())
            {
                ValidationClass oValidationClass = new ValidationClass();
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Room Type is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckCode();
            CheckName();
            CheckFloor();
            CheckRoomType();

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

        private void frmRoom_Load(object sender, EventArgs e)
        {
            if (GlobalVar.CurrentLoginUser.UserRole.Code != "ADM")
            {
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnNewDetail.Enabled = false;
                btnDeleteDetail.Enabled = false;
                btnEditDetail.Enabled =false;
                txtCode.Properties.ReadOnly = true;
                txtName.Properties.ReadOnly = true;
                txtFloor.Properties.ReadOnly = true;
                luRoomType.Properties.ReadOnly = true;
            }
        }
    }
}