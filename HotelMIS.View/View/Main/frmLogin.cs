using System;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using HotelMIS.Model;
using System.Diagnostics;
using DevExpress.Xpo;
using System.Collections.Generic;
using System.IO;
using DevExpress.XtraReports.UI;
using System.Data;

namespace HotelMIS.View
{
    public partial class frmLogin : Form
    {
        private frmMain oMDIForm;
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;

        public frmLogin(frmMain oForm)
        {
            InitializeComponent();
            oMDIForm = oForm;
            oMDIForm.rcMenuBar.Enabled = false;
            if (Debugger.IsAttached)
            {
                txtUsername.Text = "FO001";
                txtPassword.Text = "123";
            }
            oErrorCollection = new List<ValidationClass>();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();
                if (isValidForm)
                {
                    GlobalVar.CurrentLoginUser = GlobalVar.GlobalUOW.FindObject<AppUser>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("Code", txtUsername.Text));
                    if (GlobalVar.CurrentLoginUser != null)
                    {
                        if (GlobalVar.CurrentLoginUser.Password == GlobalVar.MD5Hash(txtPassword.Text))
                        {
                            if (GlobalVar.GlobalSetting == null)
                                GlobalVar.GlobalSetting = SystemSetting.GetInstance(GlobalVar.GlobalUOW);
                            RoleAccessCheck(GlobalVar.CurrentLoginUser);
                            oMDIForm.rcMenuBar.Enabled = true;
                            oMDIForm.rcMenuBar.Refresh();
                            oMDIForm.lblConnection.Caption = FormHelper.GetCurrentUsageInformation();
                            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
                            WorkingShift.CheckWorkingShift(oSession);
                            oSession.CommitChanges();
                            this.Close();
                        }
                        else
                        {
                            FormHelper.InformationMessage("Password Incorrect");
                            txtPassword.Focus();
                            txtPassword.SelectAll();
                        }
                    }
                    else
                    {
                        FormHelper.InformationMessage("Username Invalid");
                        txtUsername.Focus();
                        txtPassword.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                FormHelper.ErrorMessage(ex.Message);
            }
        }

        private void frmLogin_FormActivated(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVar.CurrentLoginUser == null)
            {
                e.Cancel = true;
            }
        }

        private void RoleAccessCheck(AppUser prmAppUser)
        {
            oMDIForm.rpCatData.Visible = true;
            oMDIForm.rpgMasterData.Visible = true;
            oMDIForm.rpgSecurity.Visible = true;
            oMDIForm.rpCatTransaction.Visible = true;
            oMDIForm.rpgTransaction.Visible = true;
            oMDIForm.rpCatReport.Visible = false;
            oMDIForm.rpgReport.Visible = true;

            if (!prmAppUser.UserRole.AccessForReport)
            {
                oMDIForm.rpCatReport.Visible = false;
                oMDIForm.rpgReport.Visible = false;
            }
            else
            {
                oMDIForm.rcMenuBar.SelectedPage = oMDIForm.rpReportPage;
            }
 
            if (!prmAppUser.UserRole.AccessForTransaction)
            {
                oMDIForm.rpCatTransaction.Visible = false;
                oMDIForm.rpgTransaction.Visible = false;
            }
            else
            {
                oMDIForm.rcMenuBar.SelectedPage = oMDIForm.rpTransactionPage;
            }
            if (!prmAppUser.UserRole.AccessForMasterData)
            {
                oMDIForm.rpCatData.Visible = false;
                oMDIForm.rpgMasterData.Visible = false;
                oMDIForm.rpgSecurity.Visible = false;
            }
            else
            {
                oMDIForm.rcMenuBar.SelectedPage = oMDIForm.rpDataPage;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        #region "Form Validation"

        private void CheckUsername()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtUsername.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Username is required.";
                oErrorCollection.Add(oValidationClass);
                isValidForm = false;
            }
        }

        private void CheckPassword()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (txtPassword.Text == string.Empty)
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Password is required.";
                oErrorCollection.Add(oValidationClass);
                isValidForm = false;
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckUsername();
            CheckPassword();

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to print the last session report ?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                XPCollection<WorkingShift> oShift = new XPCollection<WorkingShift>(GlobalVar.GlobalUOW, new DevExpress.Data.Filtering.BinaryOperator("IsClosed", true));
                oShift.Sorting = new SortingCollection(new SortProperty("ShiftStart", DevExpress.Xpo.DB.SortingDirection.Descending));
                if (oShift.Count == 0)
                {
                    MessageBox.Show("No file found.");
                    return;
                }
                try
                {
                    String rptWorkingShiftSummary = String.Format("{0}\\{1}.repx", Application.StartupPath, "WorkingShiftSummary");
                    using (XtraReport oRpt = new XtraReport())
                    {
                        oRpt.DataSource = GetDataSourceAmount(GlobalVar.GlobalUOW, oShift[0]);
                        oRpt.LoadLayout(rptWorkingShiftSummary);
                        //using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
                        //{
                        //    objRibbonDesigner.OpenReport(oRpt);
                        //    objRibbonDesigner.FileName = rptWorkingShiftSummary;
                        //    objRibbonDesigner.ShowDialog();
                        //}
                        using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
                        {
                            objtool.Print();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private DataSet GetDataSourceAmount(Session prmSession, WorkingShift prmWorkingShift)
        {
            string strQuery = "";
            strQuery += "SELECT (SELECT TOP 1 Amount FROM WorkingShiftDetail wsd INNER JOIN WorkingShift ws ON ws.Oid = wsd.WorkingShift WHERE wsd.Description = 'Beginning Balance' AND ws.Oid = WorkingShift.Oid) BeginningBalance, (ISNULL(WorkingShiftDetail.Amount,0) + ISNULL(WorkingShiftDetail.NonCashAmount,0)) TotalAmount , WorkingShift.ShiftStart, WorkingShift.ShiftEnd, WorkingShift.IsClosed, AppUser.Code AppUserCode, AppUser.Name AppUserName, WorkingShiftDetail.* FROM WorkingShift " +
                        "INNER JOIN AppUser ON WorkingShift.AppUser = AppUser.Oid " +
                        "INNER JOIN WorkingShiftDetail ON WorkingShiftDetail.WorkingShift = WorkingShift.Oid " +
                        "WHERE ((ISNULL(WorkingShiftDetail.Amount,0) + ISNULL(WorkingShiftDetail.NonCashAmount,0) + ISNULL(WorkingShiftDetail.DepositAmount,0)) <> 0 OR WorkingShiftDetail.[Description] LIKE '%Process Payment Room%') " +
                        "AND WorkingShiftDetail.Description <> 'Beginning Balance' AND WorkingShift.Oid = '" + prmWorkingShift.Oid.ToString() + "' " +
                        "ORDER BY WorkingShiftDetail.LogTime ASC ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }

    }
}