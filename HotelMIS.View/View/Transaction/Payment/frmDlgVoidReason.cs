using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelMIS.View
{
    public partial class frmDlgVoidReason : Form
    {
        public string voidReason = string.Empty;
        public frmDlgVoidReason()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            voidReason = meVoidReason.Text;
            this.Close();
        }
    }
}
