using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;

namespace HotelMIS.View
{
    public partial class frmListReportDesign : Form
    {
        private XPCollection<ReportDesign> oDataCollection;
        private UnitOfWork oSession;
        public frmListReportDesign(UnitOfWork prmSession, XPCollection<ReportDesign> prmDataCollection)
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
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReportDesign oForm = new frmReportDesign(oSession);
            oForm.MdiParent = this.MdiParent;
            oForm.Show();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oDataCollection.Reload();
        }

        private void DeleteRow()
        {
            ReportDesign CurrentRow = ((ReportDesign)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
                if (FormHelper.QuestionMessage("Are you sure want to delete this record ?"))
                    CurrentRow.Delete();
            oSession.CommitChanges();
        }

        private void EditRow()
        {
            ReportDesign CurrentRow = ((ReportDesign)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                frmReportDesign oForm = new frmReportDesign(oSession, CurrentRow);
                oForm.MdiParent = this.MdiParent;
                oForm.Show();
            }
        }

        private void frmListReportDesign_Activated(object sender, System.EventArgs e)
        {
            btnRefresh.PerformClick();
        }
    }
}