using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;

namespace HotelMIS.View
{
    public partial class frmListRoom : Form
    {
        private XPCollection<Room> oDataCollection;
        private UnitOfWork oSession;

        public frmListRoom(UnitOfWork prmSession, XPCollection<Room> prmDataCollection)
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

            frmRoom oForm = new frmRoom();
            oForm.MdiParent = this.MdiParent;
            oForm.Show();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oDataCollection.Reload();
        }

        private void DeleteRow()
        {
            Room CurrentRow = ((Room)((GridView)gcData.MainView).GetFocusedRow());
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
            Room CurrentRow = ((Room)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                frmRoom oForm = new frmRoom(CurrentRow);
                oForm.MdiParent = this.MdiParent;
                oForm.Show();
            }
        }

        private void frmListRoom_Activated(object sender, System.EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void frmListRoom_Load(object sender, System.EventArgs e)
        {
            if (GlobalVar.CurrentLoginUser.UserRole.Code != "ADM")
            {
                btnNew.Enabled = false;
            }
        }
    }
}