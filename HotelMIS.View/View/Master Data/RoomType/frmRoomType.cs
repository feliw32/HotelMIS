using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using HotelMIS.Model;

namespace HotelMIS.View
{
    public partial class frmRoomType : Form
    {
        private bool isValidForm = true;
        private RoomType oRoomType;
        private List<ValidationClass> oErrorCollection;
        private UnitOfWork oSession;

        public frmRoomType(RoomType prmRoomType = null)
        {
            InitializeComponent();
            oSession = SessionProvider.GetNewUnitOfWork();
            if (prmRoomType != null)
                oRoomType = oSession.GetObjectByKey<RoomType>(prmRoomType.Oid);
            ResetData();
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

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            ResetData();
            this.Close();
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

        private void ResetData()
        {
            if (oRoomType == null)
            {
                oRoomType = new RoomType(oSession);
            }
            if (oSession.IsNewObject(oRoomType))
            {
                oRoomType.Code = String.Empty;
                oRoomType.Name = String.Empty;
            }
            else
            {
                oRoomType.Reload();
            }
            bs.DataSource = oRoomType;
        }

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
            if (oSession.FindObject<RoomType>(PersistentCriteriaEvaluationBehavior.InTransaction,
              GroupOperator.And(new BinaryOperator("Oid", oRoomType.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("Code", txtCode.Text))) != null)
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

        private void ValidateForm()
        {
            isValidForm = true;
            CheckCode();
            CheckName();

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