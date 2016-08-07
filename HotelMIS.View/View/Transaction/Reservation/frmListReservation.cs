using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;
using DevExpress.Data.Filtering;
using System;

namespace HotelMIS.View
{
    public partial class frmListReservation : Form
    {
        private XPCollection<Reservation> oDataCollection;
        private UnitOfWork oSession;

        public frmListReservation(UnitOfWork prmSession,XPCollection<Reservation> prmDataCollection)
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
            frmReservation oForm = new frmReservation();
            oForm.MdiParent = this.MdiParent;
            oForm.Show();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnFilter.PerformClick();
        }

        private void DeleteRow()
        {
            Reservation CurrentRow = ((Reservation)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                if (CurrentRow.Status == GlobalVar.TransactionStatus.Processed)
                {
                    FormHelper.ErrorMessage("Processed record cannot be deleted.");
                    return;
                }
                if (FormHelper.QuestionMessage("Are you sure want to delete this record ?"))
                {
                    CurrentRow.Delete();
                    WorkingShiftDetail.CreateWorkingLog(oSession, "Delete " + CurrentRow.ToString(), 0, 0, 0);
                    oSession.CommitChanges();
                }
            }
        }

        private void EditRow()
        {
            Reservation CurrentRow = ((Reservation)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                frmReservation oForm = new frmReservation(CurrentRow);
                oForm.MdiParent = this.MdiParent;
                oForm.Show();
            }
        }

        private void frmListReservation_Activated(object sender, System.EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnFilter_Click(object sender, System.EventArgs e)
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

            if (deFrom.DateTime != new DateTime() && deFrom.DateTime != null)
            {
                criteria = GroupOperator.And(criteria, new BinaryOperator("DateCheckIn", deFrom.DateTime, BinaryOperatorType.GreaterOrEqual));
            }
            if (deUntil.DateTime != new DateTime() && deUntil.DateTime != null)
            {
                criteria = GroupOperator.And(criteria, new BinaryOperator("DateCheckOut", deUntil.DateTime.AddDays(1).AddMinutes(-1), BinaryOperatorType.LessOrEqual));
            }

            bs.DataSource = new XPCollection<Reservation>(oSession, criteria);
        }

        private void frmListReservation_Load(object sender, EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            deFrom.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            deUntil.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, deFrom.DateTime.AddMonths(1).AddDays(-1).Day);
            btnFilter.PerformClick();
        }
    }
}