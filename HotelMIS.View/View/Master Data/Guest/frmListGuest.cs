using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;

namespace HotelMIS.View
{
    public partial class frmListGuest : Form
    {
        private XPCollection<Guest> oDataCollection;
        private UnitOfWork oSession;
        public frmListGuest(UnitOfWork prmSession, XPCollection<Guest> prmDataCollection)
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
            frmGuest oForm = new frmGuest();
            oForm.MdiParent = this.MdiParent;
            oForm.Show();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oDataCollection.Reload();
        }

        private void DeleteRow()
        {
            Guest CurrentRow = ((Guest)((GridView)gcData.MainView).GetFocusedRow());
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
            Guest CurrentRow = ((Guest)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                frmGuest oForm = new frmGuest(CurrentRow);
                oForm.MdiParent = this.MdiParent;
                oForm.Show();
            }
        }

        private void frmListGuest_Activated(object sender, System.EventArgs e)
        {
            btnRefresh.PerformClick();
        }
    }
}