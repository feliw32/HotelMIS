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
    public partial class frmDlgMaintenance : Form
    {
        public string strReason = "";
        public frmDlgMaintenance()
        {
            InitializeComponent();
        }

        private void btnSaveMaintenance_Click(object sender, EventArgs e)
        {
            strReason = textEdit1.Text;
            this.Close();
        }       
    }
}
