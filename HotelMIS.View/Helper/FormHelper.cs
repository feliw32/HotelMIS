using System;
using System.Windows.Forms;
using HotelMIS.Model;
using System.Data.SqlClient;
using System.Data;

namespace HotelMIS.View
{
    public static class FormHelper
    {
        public static string GetCurrentUsageInformation()
        {
            string strConnected = string.Empty;
            string strCurrentLogin = string.Empty;
            string strRoomStatistic = string.Empty;
            strConnected = "Connected To : " + ((SqlConnection)(GlobalVar.GlobalUOW.Connection)).Database + "@" + ((SqlConnection)(GlobalVar.GlobalUOW.Connection)).DataSource + "; ";
            if (GlobalVar.CurrentLoginUser != null)
            {
                strCurrentLogin = "Current Login : " + GlobalVar.CurrentLoginUser.Code + "-" + GlobalVar.CurrentLoginUser.Name;
                strRoomStatistic = String.Format("| Room Vacant: {0} | Room Filled: {1} | Room Maintenance: {2}", Room.GetTotalVacant(GlobalVar.GlobalUOW), Room.GetTotalFilled(GlobalVar.GlobalUOW), Room.GetTotalMaintenance(GlobalVar.GlobalUOW));
            }
            
            return strConnected + strCurrentLogin + strRoomStatistic;
        }

        public static void CheckIsLogin(Form prmMDIForm)
        {
            if (GlobalVar.CurrentLoginUser == null)
                using (frmLogin oLogin = new frmLogin((frmMain)prmMDIForm))
                {
                    oLogin.ShowDialog();
                    if (prmMDIForm != null)
                    {
                        //((frmMain)prmMDIForm).rcMenuBar.SelectedPage = ((frmMain)prmMDIForm).rpDataPage;
                    }
                }
        }

        public static void DisposeAllChildForm(Form prmMDIForm)
        {
            foreach (Form frm in prmMDIForm.MdiChildren)
            {
                frm.Close();
            }
        }

        public static void ErrorMessage(String prmMessage)
        {
            MessageBox.Show(prmMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InformationMessage(String prmMessage)
        {
            MessageBox.Show(prmMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool QuestionMessage(String prmMessage)
        {
            if (MessageBox.Show(prmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            return false;
        }

        public static string CallPasswordBox(string prmCaption = "Password")
        {
            using (frmDlgPasswordBox oPasswordBox = new frmDlgPasswordBox())
            {
                oPasswordBox.Text = prmCaption;
                oPasswordBox.ShowDialog();
                if (oPasswordBox.newPassword != "" || oPasswordBox.newPassword != string.Empty)
                {
                    return GlobalVar.MD5Hash(oPasswordBox.newPassword);
                }
                return "";
            }
        }

        public static bool ReAuthenticatePassword()
        {
            string inputPassword = "";
            inputPassword = FormHelper.CallPasswordBox("Input Current Password");
            if (inputPassword != "" || inputPassword != string.Empty)
            {
                if (GlobalVar.CurrentLoginUser.Password == inputPassword)
                {
                    return true;
                }
            }
            return false;
        }

        public static DataSet ExecuteQuery(string prmQuery)
        {
            SqlConnection sqlConn = new SqlConnection(GlobalVar.PubConnectionString);
            try
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand(prmQuery, sqlConn);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                DataSet dt = new DataSet();
                sqlAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}