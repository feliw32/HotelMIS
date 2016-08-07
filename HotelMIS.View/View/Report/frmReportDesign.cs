using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Xpo;
using System.Collections.Generic;
using DevExpress.Data.Filtering;

namespace HotelMIS.View
{
    public partial class frmReportDesign : Form
    {
        private bool isValidForm = true;
        private ReportDesign oReportDesign;
        private UnitOfWork oSession;
        private List<ValidationClass> oErrorCollection;

        public frmReportDesign(UnitOfWork prmSession, ReportDesign prmReportDesign = null)
        {
            InitializeComponent();
            oSession = SessionProvider.GetNewUnitOfWork();
            if (prmReportDesign != null)
                oReportDesign = oSession.GetObjectByKey<ReportDesign>(prmReportDesign.Oid);
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
            if (oReportDesign == null)
            {
                oReportDesign = new ReportDesign(oSession);
            }
            if (oSession.IsNewObject(oReportDesign))
            {
                oReportDesign.Code = String.Empty;
                oReportDesign.Name = String.Empty;
                oReportDesign.ReportFile = String.Empty;
                oReportDesign.Query = String.Empty;
            }
            else
            {
                oReportDesign.Reload();
                oReportDesign.ReportParameters.Reload();
                foreach (ReportParameter objRP in oReportDesign.ReportParameters)
                {
                    objRP.Reload();
                }
            }
            bs.DataSource = oReportDesign;
            bsDetail.DataSource = oReportDesign.ReportParameters;
        }

        #region "Detail button"

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            ReportParameter CurrentRow = ((ReportParameter)((GridView)gcReportParameters.MainView).GetFocusedRow());
            if (CurrentRow != null)
                if (FormHelper.QuestionMessage("Are you sure want to delete this record ?"))
                    CurrentRow.Delete();
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            ReportParameter CurrentRow = ((ReportParameter)((GridView)gcReportParameters.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                using (frmReportParameter oForm = new frmReportParameter(oSession, CurrentRow))
                {
                    oForm.ShowDialog();
                }
            }
        }

        private void btnNewDetail_Click(object sender, EventArgs e)
        {
            using (frmReportParameter oForm = new frmReportParameter(oSession, oReportDesign))
            {
                oForm.ShowDialog();
                btnRefreshDetail.PerformClick();
            }
        }

        private void btnRefreshDetail_Click(object sender, EventArgs e)
        {
            bsDetail.DataSource = oReportDesign.ReportParameters;
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
            if (oSession.FindObject<ReportDesign>(PersistentCriteriaEvaluationBehavior.InTransaction,
              GroupOperator.And(new BinaryOperator("Oid", oReportDesign.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("Code", txtCode.Text))) != null)
            {
                oValidationClass.ErrorType = "Duplicate";
                oValidationClass.Description = "Code must be unique.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckReportFile()
        {
            if (txtReportFile.Text == String.Empty)
            {
                ValidationClass oValidationClass = new ValidationClass();
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Report file is required";
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

        private void CheckQuery()
        {
            if (meQuery.Text == String.Empty)
            {
                ValidationClass oValidationClass = new ValidationClass();
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Query is required";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckCode();
            CheckName();
            CheckReportFile();
            CheckQuery();

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