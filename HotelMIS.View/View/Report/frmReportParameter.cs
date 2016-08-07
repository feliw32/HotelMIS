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
using DevExpress.Data.Filtering;

namespace HotelMIS.View
{
    public partial class frmReportParameter : Form
    {
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private NestedUnitOfWork nSession;
        private ReportParameter oReportParameter;
        private UnitOfWork oSession;

        public frmReportParameter(UnitOfWork prmSession, ReportParameter prmReportParameter)
        {
            InitializeComponent();
            oSession = prmSession;
            nSession = oSession.BeginNestedUnitOfWork();
            oReportParameter = nSession.GetNestedObject<ReportParameter>(oReportParameter);
            if (oReportParameter == null)
            {
                oReportParameter = new ReportParameter(nSession);
            }
            bs.DataSource = oReportParameter;
            oErrorCollection = new List<ValidationClass>();
        }

        public frmReportParameter(UnitOfWork prmSession, ReportDesign prmReportDesign)
        {
            InitializeComponent();
            oSession = prmSession;
            nSession = oSession.BeginNestedUnitOfWork();
            if (oReportParameter == null)
            {
                oReportParameter = new ReportParameter(nSession);
            }
            bs.DataSource = oReportParameter;
            oReportParameter.ReportDesign = nSession.GetNestedObject(prmReportDesign);
            oErrorCollection = new List<ValidationClass>();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nSession.RollbackTransaction();
            ResetData();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nSession.RollbackTransaction();
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
                        nSession.CommitChanges();
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
            if (nSession.IsNewObject(oReportParameter))
            {
                oReportParameter.DisplayName = String.Empty;
                oReportParameter.FieldName = String.Empty;
                oReportParameter.Parameter = String.Empty;
            }
            else
            {
                oReportParameter.Reload();
            }
        }

        #region "Form Validation"

        private void CheckDisplayName()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtDisplayName.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Display Name is required.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckFieldName()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtFieldName.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Field Name is required.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckParameter()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtParameter.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Parameter Name is required.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckDisplayName();
            CheckFieldName();
            CheckParameter();

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
