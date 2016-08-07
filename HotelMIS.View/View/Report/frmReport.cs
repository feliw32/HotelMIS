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

namespace HotelMIS
{
    public partial class frmReport : Form
    {
        private XPCollection<ReportDesign> xpDataCollection;
        public frmReport(XPCollection<ReportDesign> prmCollection)
        {
            InitializeComponent();
            xpDataCollection = prmCollection;
            gcReport.DataSource = xpDataCollection;
            LoadCombo();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            deFrom.DateTime = DateTime.Now;
            deTo.DateTime = DateTime.Now;
        }

        private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "btnDelete")
                switch (((LookUpEdit)sender).Name)
                {
                    case "luGuest":
                        luGuest.EditValue = null;
                        break;
                    case "luRoomType":
                        luRoomType.EditValue = null;
                        break;
                    case "luRoom":
                        luRoom.EditValue = null;
                        break;
                    case "luPriceType":
                        luPriceType.EditValue = null;
                        break;
                    case "luIdentificationType":
                        luIdentificationType.EditValue = null;
                        break;
                    case "luPaymentMethod":
                        luPaymentMethod.EditValue = null;
                        break;
                    case "luPaymentType":
                        luPaymentType.EditValue = null;
                        break;
                    case "luNationality":
                        luNationality.EditValue = null;
                        break;
                    case "luAppUser":
                        luAppUser.EditValue = null;
                        break;
                }
        }

        private void LoadCombo()
        {
            luGuest.Properties.DataSource = Guest.DataCollection(GlobalVar.GlobalUOW);
            luRoomType.Properties.DataSource = RoomType.DataCollection(GlobalVar.GlobalUOW);
            luRoom.Properties.DataSource = Room.DataCollection(GlobalVar.GlobalUOW);
            luPriceType.Properties.DataSource = PriceType.DataCollection(GlobalVar.GlobalUOW);
            luIdentificationType.Properties.DataSource = IdentificationType.DataCollection(GlobalVar.GlobalUOW);
            luPaymentMethod.Properties.DataSource = PaymentMethod.DataCollection(GlobalVar.GlobalUOW);
            luPaymentType.Properties.DataSource = PaymentType.DataCollection(GlobalVar.GlobalUOW);
            luNationality.Properties.DataSource = Nationality.DataCollection(GlobalVar.GlobalUOW);
            luAppUser.Properties.DataSource = AppUser.DataCollection(GlobalVar.GlobalUOW);
        }

        private void deTo_EditValueChanged(object sender, EventArgs e)
        {
            if (deFrom.DateTime != null)
                if (deFrom.DateTime > deTo.DateTime)
                {
                    deTo.DateTime = deFrom.DateTime;
                }
        }

        private void deFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (deTo.DateTime != null)
                if (deFrom.DateTime > deTo.DateTime)
                {
                    deTo.DateTime = deFrom.DateTime;
                }
        }
    }
}
