using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System;
using System.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System.Data;

namespace HotelMIS.View
{
    public partial class frmListMasterStay : Form
    {
        private XPCollection<MasterStay> oDataCollection;
        private UnitOfWork oSession;

        public frmListMasterStay(UnitOfWork prmSession, XPCollection<MasterStay> prmDataCollection)
        {
            InitializeComponent();
            oSession = prmSession;
            oDataCollection = prmDataCollection;
            bs.DataSource = oDataCollection;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditRow();
            this.Close();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMasterStay oForm = new frmMasterStay();
            oForm.MdiParent = this.MdiParent;
            oForm.Show();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnFilter.PerformClick();
        }

        private void EditRow()
        {
            MasterStay CurrentRow = ((MasterStay)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                frmMasterStay oForm = new frmMasterStay(CurrentRow);
                oForm.MdiParent = this.MdiParent;
                oForm.Show();
                CurrentRow.getCheckOutString();
            }
        }

        private void frmListStay_Activated(object sender, System.EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void frmListStay_Load(object sender, System.EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            //deFrom.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //deUntil.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, deFrom.DateTime.AddMonths(1).AddDays(-1).Day);
            btnFilter.PerformClick();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            CriteriaOperator criteria;
            switch (cboStatus.SelectedIndex)
            {
                case 0:
                    criteria = new BinaryOperator("Status", GlobalVar.TransactionStatus.Entry);
                    break;
                case 1:
                    criteria = new BinaryOperator("Status", GlobalVar.TransactionStatus.Processed);
                    break;
                case 2:
                    criteria = new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel);
                    break;
                case 3:
                    criteria = GroupOperator.Or(new BinaryOperator("Status", GlobalVar.TransactionStatus.Entry),
                        new BinaryOperator("Status", GlobalVar.TransactionStatus.Processed),
                        new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel));
                    break;
                default:
                    criteria = GroupOperator.Or(new BinaryOperator("Status", GlobalVar.TransactionStatus.Entry),
                        new BinaryOperator("Status", GlobalVar.TransactionStatus.Processed),
                        new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel));
                    break;
            }

            bs.DataSource = new XPCollection<MasterStay>(oSession, criteria);
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (View.GetRowCellValue(e.RowHandle, Status).ToString() == "Cancel")
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.ForeColor = Color.Black;
                    return;
                }
                if ((Double)View.GetRowCellValue(e.RowHandle, TotalPaid) < (Double)View.GetRowCellValue(e.RowHandle, Total) + (Double)View.GetRowCellValue(e.RowHandle, PenaltiesCost))
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
                else
                {
                    if ((Double)View.GetRowCellValue(e.RowHandle, TotalDeposit) > 0)
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.White;
                        e.Appearance.ForeColor = Color.Black;
                    }
                }
                if ((Double)View.GetRowCellValue(e.RowHandle, TotalPaid) > (Double)View.GetRowCellValue(e.RowHandle, Total) + (Double)View.GetRowCellValue(e.RowHandle, PenaltiesCost))
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.White;
                }
                if ((Double)View.GetRowCellValue(e.RowHandle, Total) + (Double)View.GetRowCellValue(e.RowHandle, PenaltiesCost) == 0)
                {
                    if ((Double)View.GetRowCellValue(e.RowHandle, TotalDeposit) > 0)
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.White;
                        e.Appearance.ForeColor = Color.Black;
                    }
                }
            }
        }

        private DataSet GetDataSourceCheckOutHistory(DateTime prmDate)
        {
            String strQuery;
            strQuery = "SELECT GuestName, Room.Code Room ,PriceType.Name PriceType, DateCheckIn, DateCheckOut, AppUser.Code CheckOutBy  FROM Stay " +
                            " INNER JOIN Room ON Room.Oid = Stay.Room " +
                            " INNER JOIN PriceType ON PriceType.Oid = Stay.PriceType " +
                            " INNER JOIN AppUser ON AppUser.Oid = Stay.CheckOutBy " +
                            " WHERE Stay.Status = 1 AND DateCheckOut BETWEEN '" + prmDate.Date.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + prmDate.Date.ToString("yyyy-MM-dd") + " 23:59:59'" +
                            " ORDER BY DateCheckOut ASC ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }

        private DataSet GetDataSourceCancelHistory(DateTime prmDate)
        {
            String strQuery;
            strQuery = "SELECT GuestName, Room.Code Room ,PriceType.Name PriceType, DateCheckIn, DateCheckOut, AppUser.Code CheckInBy, Stay.Note  FROM Stay " +
                            " INNER JOIN Room ON Room.Oid = Stay.Room " +
                            " INNER JOIN PriceType ON PriceType.Oid = Stay.PriceType " +
                            " INNER JOIN AppUser ON AppUser.Oid = Stay.CheckInBy " +
                            " WHERE Stay.Status = 2 AND DateCheckIn BETWEEN '" + prmDate.Date.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + prmDate.Date.ToString("yyyy-MM-dd") + " 23:59:59'" +
                            " ORDER BY DateCheckIn ASC ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            String rptCheckOutHistory = String.Format("{0}\\{1}.repx", Application.StartupPath, "CheckOutHistory");
            XtraReport oRpt = new XtraReport();
            oRpt.DataSource = GetDataSourceCheckOutHistory(dtHistory.Value);
            oRpt.LoadLayout(rptCheckOutHistory);

            //using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
            //{
            //    objRibbonDesigner.OpenReport(oRpt);
            //    objRibbonDesigner.FileName = rptCheckOutHistory;
            //    objRibbonDesigner.ShowDialog();
            //}
            using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
            {
                objtool.ShowPreviewDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            String rptCheckOutHistory = String.Format("{0}\\{1}.repx", Application.StartupPath, "CancelHistory");
            XtraReport oRpt = new XtraReport();
            oRpt.DataSource = GetDataSourceCancelHistory(dtHistory.Value);
            oRpt.LoadLayout(rptCheckOutHistory);
            //using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
            //{
            //    objRibbonDesigner.OpenReport(oRpt);
            //    objRibbonDesigner.FileName = rptCheckOutHistory;
            //    objRibbonDesigner.ShowDialog();
            //}
            using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
            {
                objtool.ShowPreviewDialog();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            using (frmReportDlg frm = new frmReportDlg())
            {
                frm.ShowDialog();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFixRoom.Text != string.Empty)
                {
                    FormHelper.ExecuteQuery("UPDATE Room SET RoomStatus = 0 WHERE Room.Code = '" + txtFixRoom.Text + "'");
                }
                MessageBox.Show("Fix Room Success.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fix Room Fail.");
            }
        }
    }
}