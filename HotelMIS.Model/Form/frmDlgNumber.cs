using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HotelMIS.Model
{
    public partial class frmDlgNumber : Form
    {
        private const int MF_BYCOMMAND = 0;
        private const int MF_DISABLED = 2;
        private const int SC_CLOSE = 0xF060;

        [DllImport("user32")]
        private static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        [DllImport("user32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);


        public double newAmount = 0;
        public frmDlgNumber()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            newAmount = (double)seAmount.Value;
            if (MessageBox.Show("Continue to save the amount ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                seAmount.Focus();
            }
        }
    }
}
