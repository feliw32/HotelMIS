using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using HotelMIS.Model;

namespace HotelMIS.View
{
    public partial class frmRoomService : Form
    {
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private RoomService oRoomService;
        private UnitOfWork oSession;

        public frmRoomService(RoomService prmRoomService = null)
        {
            InitializeComponent();
            luRoomServiceFor.ButtonClick += ClearComboSelection;
            luServicePerson.ButtonClick += ClearComboSelection;

            oSession = SessionProvider.GetNewUnitOfWork();
            if (prmRoomService != null)
                oRoomService = oSession.GetObjectByKey<RoomService>(prmRoomService.Oid);
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

        private void btnCancelRoomService_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (FormHelper.QuestionMessage("Are you sure want to cancel room service for this data ?"))
                {
                    if (oRoomService.Status != GlobalVar.TransactionStatus.Cancel)
                    {
                        oRoomService.CancelRecord();
                        WorkingShiftDetail.CreateWorkingLog(oSession, "Cancel " + oRoomService.ToString(), 0, 0, 0);
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

        

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            ResetData();
            this.Close();
        }

        private void btnFinish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oRoomService.Status != GlobalVar.TransactionStatus.Entry)
                {
                    return;
                }
                else
                {
                    if (!FormHelper.QuestionMessage("Are you sure want to finish the room service ?"))
                    {
                        return;
                    }
                    else
                    {
                        if (isValidForm)
                        {
                            SaveForm();
                            oRoomService.ProcessRecord();
                            WorkingShiftDetail.CreateWorkingLog(oSession, "Finish " + oRoomService.ToString(), 0, 0, 0);
                            oSession.CommitChanges();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FormHelper.ErrorMessage(ex.Message);
            }
        }

        

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oRoomService.Status != GlobalVar.TransactionStatus.Entry)
                {
                    return;
                }
                if (FormHelper.QuestionMessage("Are you sure want to save this data ?"))
                {
                    ValidateForm();
                    if (isValidForm)
                    {
                        SaveForm();
                        oRoomService.RoomServiceFor.UpdateRoomInformation(GlobalVar.RoomStatus.Cleaning);
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
                    case "luServicePerson":
                        oRoomService.ServicePerson = null;
                        break;

                    case "luRoomServiceFor":
                        oRoomService.RoomServiceFor = null;
                        break;
                }
        }

        private void LoadCombo()
        {
            luServicePerson.Properties.DataSource = oRoomService.AvailableServicePerson;
            luRoomServiceFor.Properties.DataSource = oRoomService.AvailableStay;
        }

        private void ResetData()
        {
            if (oRoomService == null)
            {
                oRoomService = new RoomService(oSession);
            }
            if (oSession.IsNewObject(oRoomService))
            {
                oRoomService.RoomServiceFor = null;
                oRoomService.CompletedTime = new DateTime();
                oRoomService.ServicePerson = null;
                oRoomService.Note = string.Empty;
                oRoomService.Status = GlobalVar.TransactionStatus.Entry;
            }
            else
            {
                oRoomService.Reload();
            }
            bs.DataSource = oRoomService;
            if (oRoomService.Status != GlobalVar.TransactionStatus.Entry)
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
            oRoomService.DeleteSchedule();
            oRoomService.SubmitSchedule();
            oSession.CommitChanges();
        }

        #region "Form Validation"

        private void CheckRoomServiceFor()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luRoomServiceFor.EditValue == new Guid())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "RoomService For is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckServicePerson()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luServicePerson.EditValue == new Guid())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Service Person is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckRoomServiceFor();
            CheckServicePerson();

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