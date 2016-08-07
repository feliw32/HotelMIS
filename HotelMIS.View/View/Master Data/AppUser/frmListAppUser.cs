using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using HotelMIS.Model;

namespace HotelMIS.View
{
    public partial class frmListAppUser : Form
    {
        private XPCollection<AppUser> oDataCollection;
        private UnitOfWork oSession;
        public frmListAppUser(UnitOfWork prmSession,XPCollection<AppUser> prmDataCollection)
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
            frmAppUser oForm = new frmAppUser();
            oForm.MdiParent = this.MdiParent;
            oForm.Show();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oDataCollection.Reload();
        }

        private void btnResetPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppUser CurrentRow = ((AppUser)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                if (FormHelper.QuestionMessage("Are you sure want to reset password for this user ?"))
                {
                    string newPassword = "";
                    newPassword = FormHelper.CallPasswordBox("Input New Password");
                    if (newPassword != "" || newPassword != string.Empty)
                    {
                        CurrentRow.Password = newPassword;
                        CurrentRow.Save();
                        oSession.CommitChanges();
                    }
                }
            }
        }

        private void DeleteRow()
        {
            AppUser CurrentRow = ((AppUser)((GridView)gcData.MainView).GetFocusedRow());
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
            AppUser CurrentRow = ((AppUser)((GridView)gcData.MainView).GetFocusedRow());
            if (CurrentRow != null)
            {
                frmAppUser oForm = new frmAppUser(CurrentRow);
                oForm.MdiParent = this.MdiParent;
                oForm.Show();
            }
        }

        private void frmListAppUser_Activated(object sender, System.EventArgs e)
        {
            btnRefresh.PerformClick();
        }
    }
}