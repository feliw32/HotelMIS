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
    public partial class frmDlgPasswordBox : Form
    {
        public string newPassword = string.Empty;
        public frmDlgPasswordBox()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            newPassword = txtPassword.Text;
            this.Close();
        }
    }
}
