using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;

namespace HotelMIS.View
{
    public partial class frmListPaymentMethod : Form
    {
        private XPCollection<PaymentMethod> oDataCollection;
        private UnitOfWork oSession;
        public frmListPaymentMethod(UnitOfWork prmSession, XPCollection<PaymentMethod> prmDataCollection)
        {
            InitializeComponent();
            oSession = prmSession;
            oDataCollection = prmDataCollection;
            bs.DataSource = oDataCollection;
            if (GlobalVar.CurrentLoginUser.UserRole.Code == "ADM")
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
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
            frmPaymentMethod oForm = new frmPaymentMethod();
            oForm.MdiParent = this.MdiParent;
            oForm.Show();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oDataCollection.Reload();
        }

        private void DeleteRow()
        {
            PaymentMethod CurrentRow = ((PaymentMethod)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
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
            PaymentMethod CurrentRow = ((PaymentMethod)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                frmPaymentMethod oForm = new frmPaymentMethod(CurrentRow);
                oForm.MdiParent = this.MdiParent;
                oForm.Show();
            }
        }

        private void frmListPaymentMethod_Activated(object sender, System.EventArgs e)
        {
            btnRefresh.PerformClick();
        }
    }
}