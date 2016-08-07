using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using System;
using DevExpress.Xpo;
using System.Collections.Generic;
using DevExpress.Data.Filtering;

namespace HotelMIS.View
{
    public partial class frmGuest : Form
    {
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private Guest oGuest;
        private UnitOfWork oSession;

        public frmGuest(Guest prmGuest = null)
        {
            InitializeComponent();
            oSession = SessionProvider.GetNewUnitOfWork();
            if (prmGuest != null)
                oGuest = oSession.GetObjectByKey<Guest>(prmGuest.Oid);
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
                        if (FormHelper.ReAuthenticatePassword())
                        {
                            bs.EndEdit();
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
                    case "luIdentificationType":
                        oGuest.IdentificationType = null;
                        break;

                    case "luNationality":
                        oGuest.Nationality = null;
                        break;
                }
        }

        private void LoadCombo()
        {
            //luIdentificationType.Properties.DataSource = oGuest.AvailableIdentificationType;
            luNationality.Properties.DataSource = oGuest.AvailableNationality;
            cbGender.Properties.Items.Add(GlobalVar.Gender.Mr);
            cbGender.Properties.Items.Add(GlobalVar.Gender.Mrs);
        }

        private void ResetData()
        {
            if (oGuest == null)
            {
                oGuest = new Guest(oSession);
            }
            if (oSession.IsNewObject(oGuest))
            {
                oGuest.Name = string.Empty;
                oGuest.CompanyName = string.Empty;
                oGuest.IsCompany = false;
                oGuest.DateOfBirth = DateTime.Now;
                oGuest.SSID = string.Empty;
                oGuest.IdentificationType = null;
                oGuest.PhoneNumber = string.Empty;
                oGuest.Nationality = null;
            }
            else
            {
                oGuest.Reload();
            }
            bs.DataSource = oGuest;
        }

        #region "Form Validation"

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
        private void CheckNationality()
        {
            if ((Guid)luNationality.EditValue == new Guid())
            {
                ValidationClass oValidationClass = new ValidationClass();
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Nationality is required";
                oErrorCollection.Add(oValidationClass);
            }
        }
        //private void CheckSSIDUnique()
        //{
        //    ValidationClass oValidationClass = new ValidationClass();
        //    if (txtSSID.Text == string.Empty)
        //    {
        //        return;
        //    }
        //    if (oSession.FindObject<Guest>(PersistentCriteriaEvaluationBehavior.InTransaction,
        //        GroupOperator.And(new BinaryOperator("Oid", oGuest.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("SSID", txtSSID.Text))) != null)
        //    {
        //        oValidationClass.ErrorType = "Duplicate";
        //        oValidationClass.Description = "SSID must be unique.";
        //        oErrorCollection.Add(oValidationClass);
        //    }
        //}

        private void CheckKTPUnique()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtKTP.Text == string.Empty)
            {
                return;
            }
            if (oSession.FindObject<Guest>(PersistentCriteriaEvaluationBehavior.InTransaction,
                GroupOperator.And(new BinaryOperator("Oid", oGuest.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("KTP", txtKTP.Text))) != null)
            {
                oValidationClass.ErrorType = "Duplicate";
                oValidationClass.Description = "KTP must be unique.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckSIMUnique()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtSIM.Text == string.Empty)
            {
                return;
            }
            if (oSession.FindObject<Guest>(PersistentCriteriaEvaluationBehavior.InTransaction,
                GroupOperator.And(new BinaryOperator("Oid", oGuest.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("SIM", txtSIM.Text))) != null)
            {
                oValidationClass.ErrorType = "Duplicate";
                oValidationClass.Description = "SIM must be unique.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckPassportUnique()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtPassport.Text == string.Empty)
            {
                return;
            }
            if (oSession.FindObject<Guest>(PersistentCriteriaEvaluationBehavior.InTransaction,
                GroupOperator.And(new BinaryOperator("Oid", oGuest.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("Passport", txtPassport.Text))) != null)
            {
                oValidationClass.ErrorType = "Duplicate";
                oValidationClass.Description = "Passport must be unique.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckName();
            CheckNationality();
            CheckKTPUnique();
            CheckSIMUnique();
            CheckPassportUnique();

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