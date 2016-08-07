using System;
using System.Windows.Forms;
using HotelMIS.Model;
using System.Configuration;

namespace HotelMIS.View
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            GlobalVar.PubConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            Application.SetCompatibleTextRenderingDefault(false);
            SessionProvider.GetNewSession().UpdateSchema();
            GlobalVar.GlobalUOW = SessionProvider.GetNewUnitOfWork();
            GlobalVar.GlobalSetting = SystemSetting.GetInstance(GlobalVar.GlobalUOW);
            //SessionProvider.UpdateSchema();

            SessionProvider.CheckDefaultValue();
            Application.Run(new frmMain());
        }
    }
}