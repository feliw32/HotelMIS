using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using HotelMIS.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;

namespace HotelMIS.View
{
    public partial class frmPriceType : Form
    {
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private PriceType oPriceType;
        private UnitOfWork oSession;

        public frmPriceType(PriceType prmPriceType = null)
        {
            InitializeComponent();
            oSession = SessionProvider.GetNewUnitOfWork();
            if (prmPriceType != null)
                oPriceType = oSession.GetObjectByKey<PriceType>(prmPriceType.Oid);
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

        private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "btnDelete")
                switch (((LookUpEdit)sender).Name)
                {
                    case "luRoomType":
                        oPriceType.RoomType = null;
                        break;
                }
        }

        private void LoadCombo()
        {
            luRoomType.Properties.DataSource = oPriceType.AvailableRoomType;
            cboColor.Properties.Items.AddEnum(typeof(GlobalVar.LabelColor));
        }

        private void ResetData()
        {
            if (oPriceType == null)
            {
                oPriceType = new PriceType(oSession);
            }
            if (oSession.IsNewObject(oPriceType))
            {
                oPriceType.Code = String.Empty;
                oPriceType.Name = String.Empty;
                oPriceType.IsShortTime = false;
                oPriceType.Duration = 0;
                oPriceType.RoomType = null;
            }
            else
            {
                oPriceType.Reload();
                oPriceType.PriceTypePeriods.Reload();
                foreach (PriceTypePeriod objRP in oPriceType.PriceTypePeriods)
                {
                    objRP.Reload();
                }
            }
            bs.DataSource = oPriceType;
            bsDetail.DataSource = oPriceType.PriceTypePeriods;
        }

        #region "Detail button"

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            PriceTypePeriod CurrentRow = ((PriceTypePeriod)((GridView)gcPriceTypePeriod.MainView).GetFocusedRow());
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
            PriceTypePeriod CurrentRow = ((PriceTypePeriod)((GridView)gcPriceTypePeriod.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                using (frmPriceTypePeriod oForm = new frmPriceTypePeriod(oSession, CurrentRow))
                {
                    oForm.ShowDialog();
                }
            }
        }

        private void btnNewDetail_Click(object sender, EventArgs e)
        {
            using (frmPriceTypePeriod oForm = new frmPriceTypePeriod(oSession, oPriceType))
            {
                oForm.ShowDialog();
                btnRefreshDetail.PerformClick();
            }
        }

        private void btnRefreshDetail_Click(object sender, EventArgs e)
        {
            bsDetail.DataSource = oPriceType.PriceTypePeriods;
        }

        #endregion "Detail button"

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
              GroupOperator.And(new BinaryOperator("Oid", oPriceType.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("Code", txtCode.Text))) != null)
            {
                oValidationClass.ErrorType = "Duplicate";
                oValidationClass.Description = "Code must be unique.";
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

        private void chkIsShortTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsShortTime.Checked == true)
            {
                seDuration.Properties.ReadOnly = false;
            }
            else
            {
                seDuration.Properties.ReadOnly = true;
                seDuration.Value = 0;
            }
        }
    }
}
