using System;
using System.Windows.Forms;
using DevExpress.Xpo;
using HotelMIS.Model;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UserDesigner;
using System.IO;

namespace HotelMIS.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnReportForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Session oSession = SessionProvider.GetNewUnitOfWork();
            frmReport oForm = new frmReport(ReportDesign.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnAppUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListAppUser oForm = new frmListAppUser(oSession, AppUser.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword oForm = new frmChangePassword(GlobalVar.CurrentLoginUser);
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnCheckIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListMasterStay oForm = new frmListMasterStay(oSession, MasterStay.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnCheckOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListCheckOut oForm = new frmListCheckOut(oSession, CheckOut.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnControlBoard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmControlBoard oForm = new frmControlBoard(oSession);
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnGuest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListGuest oForm = new frmListGuest(oSession, Guest.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnLogOff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FormHelper.QuestionMessage("Are you sure want to log off ?"))
            {
                if (MessageBox.Show("End your working session ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (FormHelper.ReAuthenticatePassword())
                    {
                        String prmFileName = String.Format("{0}_{1:yyyyMMddHHmmss}", GlobalVar.CurrentLoginUser.Code, DateTime.Now);
                        UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
                        WorkingShift oShift = WorkingShift.EndWorkingShift(oSession);
                        oShift.FileName = prmFileName;
                        oSession.CommitChanges();
                        PrintWorkingShiftSummary(prmFileName,oSession,oShift);
                    }
                }
                GlobalVar.CurrentLoginUser = null;
                GlobalVar.GlobalSetting = null;
                FormHelper.DisposeAllChildForm(this);
                FormHelper.CheckIsLogin(this);
            }
        }

        private void PrintWorkingShiftSummary(String FileName,Session prmSession, WorkingShift prmWorkingShift)
        {
            if (prmWorkingShift != null)
            {
                String rptWorkingShiftSummary = String.Format("{0}\\{1}.repx", Application.StartupPath, "WorkingShiftSummary");
                using (XtraReport oRpt = new XtraReport())
                {
                    oRpt.DataSource = GetDataSource(prmSession, prmWorkingShift);
                    oRpt.LoadLayout(rptWorkingShiftSummary);
                    if (!Directory.Exists(String.Format("{0}\\Session", Application.StartupPath)))
                    {
                        Directory.CreateDirectory(String.Format("{0}\\Session", Application.StartupPath));
                    }
                    oRpt.ExportToPdf(String.Format("{0}\\Session\\{1}.pdf", Application.StartupPath, FileName));
                }

                using (XtraReport oRpt = new XtraReport())
                {
                    oRpt.DataSource = GetDataSourceAmount(prmSession, prmWorkingShift);
                    oRpt.LoadLayout(rptWorkingShiftSummary);
                    oRpt.ExportToPdf(String.Format("{0}\\Session\\{1}Amount.pdf", Application.StartupPath, FileName));
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
        }

        private DataSet GetDataSource(Session prmSession, WorkingShift prmWorkingShift)
        {
            string strQuery = "";
            strQuery += "SELECT (SELECT TOP 1 Amount FROM WorkingShiftDetail wsd INNER JOIN WorkingShift ws ON ws.Oid = wsd.WorkingShift WHERE wsd.Description = 'Beginning Balance' AND ws.Oid = WorkingShift.Oid) BeginningBalance, (ISNULL(WorkingShiftDetail.Amount,0) + ISNULL(WorkingShiftDetail.NonCashAmount,0)) TotalAmount , WorkingShift.ShiftStart, WorkingShift.ShiftEnd, WorkingShift.IsClosed, AppUser.Code AppUserCode, AppUser.Name AppUserName, WorkingShiftDetail.* FROM WorkingShift " +
                        "INNER JOIN AppUser ON WorkingShift.AppUser = AppUser.Oid " +
                        "INNER JOIN WorkingShiftDetail ON WorkingShiftDetail.WorkingShift = WorkingShift.Oid " +
                        "WHERE WorkingShiftDetail.Description <> 'Beginning Balance' AND WorkingShift.Oid = '" + prmWorkingShift.Oid.ToString() + "' " +
                        "ORDER BY WorkingShiftDetail.LogTime ASC ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
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

        private void btnNationality_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListNationality oForm = new frmListNationality(oSession, Nationality.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnPaymentMethod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListPaymentMethod oForm = new frmListPaymentMethod(oSession, PaymentMethod.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnPaymentType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListPaymentType oForm = new frmListPaymentType(oSession, PaymentType.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnPriceType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListPriceType oForm = new frmListPriceType(oSession, PriceType.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListReportDesign oForm = new frmListReportDesign(oSession, ReportDesign.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnReservation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListReservation oForm = new frmListReservation(oSession, Reservation.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListRoom oForm = new frmListRoom(oSession, Room.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnRoomFO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListRoom oForm = new frmListRoom(oSession, Room.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnRoomService_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListRoomService oForm = new frmListRoomService(oSession, RoomService.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnRoomType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListRoomType oForm = new frmListRoomType(oSession, RoomType.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnSystemSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSystemSetting oForm = new frmSystemSetting();
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnUserRole_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListUserRole oForm = new frmListUserRole(oSession, UserRole.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private Boolean CheckIsOpened(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FormHelper.CheckIsLogin(this);
        }

        private void rcMenuBar_Click(object sender, EventArgs e)
        {
            FormHelper.CheckIsLogin(this);
        }

        private void btnPaymentVoucher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListPaymentVoucher oForm = new frmListPaymentVoucher(oSession, PaymentVoucher.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void btnGuestFO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitOfWork oSession = SessionProvider.GetNewUnitOfWork();
            frmListGuest oForm = new frmListGuest(oSession, Guest.DataCollection(oSession));
            if (!CheckIsOpened(oForm) == true)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnLogOff.PerformClick();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            lblConnection.Caption = FormHelper.GetCurrentUsageInformation();
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            lblConnection.Caption = FormHelper.GetCurrentUsageInformation();
        }
    }
}