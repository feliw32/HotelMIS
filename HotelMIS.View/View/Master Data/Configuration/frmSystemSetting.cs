using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using HotelMIS.Model;
using DevExpress.XtraEditors;

namespace HotelMIS.View
{
    public partial class frmSystemSetting : Form
    {
        private Session oSession;
        SystemSetting oSystemSetting;
        public frmSystemSetting()
        {
            InitializeComponent();
            oSession = SessionProvider.GetNewUnitOfWork();
            oSystemSetting = SystemSetting.GetInstance(oSession);
            LoadCombo();
            bs.DataSource = oSystemSetting;
        }

        private void LoadCombo()
        {
            luRoomServiceRole.Properties.DataSource = oSystemSetting.AvailableRole;
        }

        private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "btnDelete")
                switch (((LookUpEdit)sender).Name)
                {
                    case "luRoomServiceRole":
                        oSystemSetting.RoomServiceRole = null;
                        break;
                }
        }

        private void btnSaveSystemSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (FormHelper.QuestionMessage("Are you sure want to save this data ?"))
                {
                    bs.EndEdit();
                    oSystemSetting.Save();
                    if (oSession.InTransaction)
                        oSession.CommitTransaction();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                FormHelper.ErrorMessage(ex.Message);
            }
        }

        private void btnCancelSystemSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bs.CancelEdit();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oSystemSetting.Reload();
            FormHelper.InformationMessage("Close and Open program for setting to take effect");
            this.Close();
        }
    }
}
