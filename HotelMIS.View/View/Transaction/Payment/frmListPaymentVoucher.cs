using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;
using DevExpress.Data.Filtering;
using System;

namespace HotelMIS.View
{
    public partial class frmListPaymentVoucher : Form
    {
        private XPCollection<PaymentVoucher> oDataCollection;
        private UnitOfWork oSession;

        public frmListPaymentVoucher(UnitOfWork prmSession,XPCollection<PaymentVoucher> prmDataCollection)
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
            //frmPaymentVoucher oForm = new frmPaymentVoucher();
            //oForm.MdiParent = this.MdiParent;
            //oForm.Show();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnFilter.PerformClick();
        }

        private void DeleteRow()
        {
            PaymentVoucher CurrentRow = ((PaymentVoucher)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                if (CurrentRow.Status == GlobalVar.TransactionStatus.Entry)
                {
                    if (FormHelper.QuestionMessage("Are you sure want to delete this record ?"))
                    {
                        CurrentRow.Delete();
                        oSession.CommitChanges();
                    }
                }
                else
                {
                    FormHelper.ErrorMessage("Processed or Canceled payment cannot be deleted.");
                }
            }
        }

        private void EditRow()
        {
            //PaymentVoucher CurrentRow = ((PaymentVoucher)((GridView)gcData.MainView).GetFocusedRow());
            //if (CurrentRow != null)
            //{
            //    frmPaymentVoucher oForm = new frmPaymentVoucher(CurrentRow);
            //    oForm.MdiParent = this.MdiParent;
            //    oForm.Show();
            //}
        }

        private void frmListPaymentVoucher_Activated(object sender, System.EventArgs e)
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
                criteria = GroupOperator.And(criteria, new BinaryOperator("PaidDate", deFrom.DateTime, BinaryOperatorType.GreaterOrEqual));
            }
            bs.DataSource = new XPCollection<PaymentVoucher>(oSession, criteria);
        }

        private void frmListPaymentVoucher_Load(object sender, EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            deFrom.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            btnFilter.PerformClick();
        }
    }
}