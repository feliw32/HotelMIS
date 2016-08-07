using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace HotelMIS.View
{
    public partial class frmListStay : Form
    {
        private XPCollection<Stay> oDataCollection;
        private UnitOfWork oSession;

        public frmListStay(UnitOfWork prmSession,XPCollection<Stay> prmDataCollection)
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

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteRow();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditRow();
            this.Close();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStay oForm = new frmStay();
            oForm.MdiParent = this.MdiParent;
            oForm.Show();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnFilter.PerformClick();
        }

        private void DeleteRow()
        {
            Stay CurrentRow = ((Stay)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                if (CurrentRow.Status == GlobalVar.TransactionStatus.Processed)
                {
                    FormHelper.ErrorMessage("Processed record cannot be deleted.");
                    return;
                }
                if (FormHelper.QuestionMessage("Are you sure want to delete this record ?"))
                {
                    if (CurrentRow.IsPaymentMade)
                    {
                        FormHelper.InformationMessage("Payment already made for this record, cannot delete this record.");
                        return;
                    }
                    CurrentRow.CancelRecord();
                    CurrentRow.Delete();
                    WorkingShiftDetail.CreateWorkingLog(oSession, "Delete " + CurrentRow.ToString, 0);
                    oSession.CommitChanges();
                }
            }
        }

        private void EditRow()
        {
            Stay CurrentRow = ((Stay)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                frmStay oForm = new frmStay(CurrentRow);
                oForm.MdiParent = this.MdiParent;
                oForm.Show();
            }
        }

        private void frmListStay_Activated(object sender, System.EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void frmListStay_Load(object sender, System.EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            deFrom.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            deUntil.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, deFrom.DateTime.AddMonths(1).AddDays(-1).Day);
            btnFilter.PerformClick();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            CriteriaOperator criteria;
            switch (cboStatus.SelectedIndex)
            {
                case 0:
                    criteria = new BinaryOperator("Status", GlobalVar.TransactionStatus.Entry);
                    bs.DataSource = new XPCollection<Stay>(oSession, criteria);
                    return;
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

            if (deFrom.DateTime != new DateTime() && deFrom.DateTime != null)
            {
                criteria = GroupOperator.And(criteria, new BinaryOperator("DateCheckIn", deFrom.DateTime, BinaryOperatorType.GreaterOrEqual));
            }
            if (deUntil.DateTime != new DateTime() && deUntil.DateTime != null)
            {
                criteria = GroupOperator.And(criteria, new BinaryOperator("DateCheckOut", deUntil.DateTime.AddDays(1).AddMinutes(-1), BinaryOperatorType.LessOrEqual));
            }

            bs.DataSource = new XPCollection<Stay>(oSession, criteria);
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
                if ((Double)View.GetRowCellValue(e.RowHandle, TotalPaid) > (Double)View.GetRowCellValue(e.RowHandle, Total) + (Double)View.GetRowCellValue(e.RowHandle, PenaltiesCost))
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.White;
                }
                if ((Double)View.GetRowCellValue(e.RowHandle, TotalPaid) == (Double)View.GetRowCellValue(e.RowHandle, Total) + (Double)View.GetRowCellValue(e.RowHandle, PenaltiesCost))
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
    }
}