using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;

namespace HotelMIS.View
{
    public partial class frmChangePassword : Form
    {
        private bool isValidForm = true;
        private AppUser oAppUser;
        private List<ValidationClass> oErrorCollection;
        private UnitOfWork oSession;

        public frmChangePassword(AppUser prmAppUser)
        {
            InitializeComponent();
            oSession = GlobalVar.GlobalUOW;
            oAppUser = prmAppUser;
            oErrorCollection = new List<ValidationClass>();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSession.RollbackTransaction();
            oAppUser.Reload();
            this.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ValidateForm();
                if (isValidForm)
                {
                    oAppUser.Password = GlobalVar.MD5Hash(txtNewPassword.Text);
                    oSession.CommitChanges();
                    FormHelper.InformationMessage("Password is changed");
                    return;
                }
            }
            catch (Exception ex)
            {
                oAppUser.Reload();
                FormHelper.ErrorMessage("Password failed to changes \r\n" + ex.Message);
                return;
            }
        }
        #region "Form Validation"

        private void CheckForm()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (oAppUser.Password != GlobalVar.MD5Hash(txtOldPassword.Text))
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Old password did not match.";
                oErrorCollection.Add(oValidationClass);
                isValidForm = false;
            }
            if (txtNewPassword.Text != txtRetypeNewPassword.Text)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Check your new password.";
                oErrorCollection.Add(oValidationClass);
                isValidForm = false;    
            }
        }

        private void CheckOldPassword()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtOldPassword.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Old Password is required.";
                oErrorCollection.Add(oValidationClass);
                isValidForm = false;
            }
        }

        private void CheckNewPassword()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtNewPassword.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "New Password is required.";
                oErrorCollection.Add(oValidationClass);
                isValidForm = false;
            }
        }

        private void CheckRetypePassword()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtRetypeNewPassword.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Retype Password is required.";
                oErrorCollection.Add(oValidationClass);
                isValidForm = false;
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckOldPassword();
            CheckNewPassword();
            CheckRetypePassword();
            CheckForm();
            
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