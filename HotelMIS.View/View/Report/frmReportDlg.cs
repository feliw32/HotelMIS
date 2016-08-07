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
using DevExpress.XtraReports.UI;
using HotelMIS.View;
using DevExpress.XtraReports.UserDesigner;

namespace HotelMIS
{
    public partial class frmReportDlg : Form
    {
        public frmReportDlg()
        {
            InitializeComponent();
            //xpDataCollection = prmCollection;
            //gcReport.DataSource = xpDataCollection;
            //LoadCombo();
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

        //private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    if (e.Button.Tag.ToString() == "btnDelete")
        //        switch (((LookUpEdit)sender).Name)
        //        {
        //            case "luGuest":
        //                luGuest.EditValue = null;
        //                break;
        //            case "luRoomType":
        //                luRoomType.EditValue = null;
        //                break;
        //            case "luRoom":
        //                luRoom.EditValue = null;
        //                break;
        //            case "luPriceType":
        //                luPriceType.EditValue = null;
        //                break;
        //            case "luIdentificationType":
        //                luIdentificationType.EditValue = null;
        //                break;
        //            case "luPaymentMethod":
        //                luPaymentMethod.EditValue = null;
        //                break;
        //            case "luPaymentType":
        //                luPaymentType.EditValue = null;
        //                break;
        //            case "luNationality":
        //                luNationality.EditValue = null;
        //                break;
        //            case "luAppUser":
        //                luAppUser.EditValue = null;
        //                break;
        //        }
        //}

        //private void LoadCombo()
        //{
        //    luGuest.Properties.DataSource = Guest.DataCollection(GlobalVar.GlobalUOW);
        //    luRoomType.Properties.DataSource = RoomType.DataCollection(GlobalVar.GlobalUOW);
        //    luRoom.Properties.DataSource = Room.DataCollection(GlobalVar.GlobalUOW);
        //    luPriceType.Properties.DataSource = PriceType.DataCollection(GlobalVar.GlobalUOW);
        //    luIdentificationType.Properties.DataSource = IdentificationType.DataCollection(GlobalVar.GlobalUOW);
        //    luPaymentMethod.Properties.DataSource = PaymentMethod.DataCollection(GlobalVar.GlobalUOW);
        //    luPaymentType.Properties.DataSource = PaymentType.DataCollection(GlobalVar.GlobalUOW);
        //    luNationality.Properties.DataSource = Nationality.DataCollection(GlobalVar.GlobalUOW);
        //    luAppUser.Properties.DataSource = AppUser.DataCollection(GlobalVar.GlobalUOW);
        //}

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

        private void btnRoomLog_Click(object sender, EventArgs e)
        {
            String rptFile = String.Format("{0}\\{1}.repx", Application.StartupPath, "RoomLog");
            XtraReport oRpt = new XtraReport();
            oRpt.DataSource = RoomLogDataSource(deFrom.DateTime.ToString("yyyy-MM-dd"), deTo.DateTime.ToString("yyyy-MM-dd"));
            oRpt.LoadLayout(rptFile);

            //using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
            //{
            //    objRibbonDesigner.OpenReport(oRpt);
            //    objRibbonDesigner.FileName = rptFile;
            //    objRibbonDesigner.ShowDialog();
            //}

            using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
            {
                objtool.ShowPreviewDialog();
            }
        }

        private void btnCheckOutHistory_Click(object sender, EventArgs e)
        {
            String rptFile = String.Format("{0}\\{1}.repx", Application.StartupPath, "CheckOutHistory");
            XtraReport oRpt = new XtraReport();
            oRpt.DataSource = CheckOutHistoryDataSource(deFrom.DateTime.ToString("yyyy-MM-dd"), deTo.DateTime.ToString("yyyy-MM-dd"));
            oRpt.LoadLayout(rptFile);

            //using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
            //{
            //    objRibbonDesigner.OpenReport(oRpt);
            //    objRibbonDesigner.FileName = rptFile;
            //    objRibbonDesigner.ShowDialog();
            //}
            using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
            {
                objtool.ShowPreviewDialog();
            }
        }

        private void btnCancelHistory_Click(object sender, EventArgs e)
        {
            String rptFile = String.Format("{0}\\{1}.repx", Application.StartupPath, "CancelHistory");
            XtraReport oRpt = new XtraReport();
            oRpt.DataSource = CancelHistoryDataSource(deFrom.DateTime.ToString("yyyy-MM-dd"), deTo.DateTime.ToString("yyyy-MM-dd"));
            oRpt.LoadLayout(rptFile);
            //using (XRDesignRibbonFormEx objRibbonDesigner = new XRDesignRibbonFormEx())
            //{
            //    objRibbonDesigner.OpenReport(oRpt);
            //    objRibbonDesigner.FileName = rptFile;
            //    objRibbonDesigner.ShowDialog();
            //}
            using (ReportPrintTool objtool = new ReportPrintTool(oRpt))
            {
                objtool.ShowPreviewDialog();
            }
        }

        private DataSet CheckOutHistoryDataSource(String from, String until)
        {
            String strQuery;
            strQuery = "SELECT GuestName, Room.Code Room ,PriceType.Code PriceType, CONVERT(date,DateCheckIn) DateCheckIn,CONVERT(time,DateCheckIn) TimeCheckIn, CONVERT(date,DateCheckOut) DateCheckOut,CONVERT(time,DateCheckOut) TimeCheckOut, AppUser.Code CheckOutBy  FROM Stay " +
                            " INNER JOIN Room ON Room.Oid = Stay.Room " +
                            " INNER JOIN PriceType ON PriceType.Oid = Stay.PriceType " +
                            " LEFT JOIN AppUser ON AppUser.Oid = Stay.CheckOutBy " +
                            " WHERE Stay.Status = 1 AND DateCheckOut BETWEEN '" + from + " 00:00:00' AND '" + until + " 23:59:59'" +
                            " ORDER BY DateCheckOut ASC ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }

        private DataSet CancelHistoryDataSource(String from, String until)
        {
            String strQuery;
            strQuery = "SELECT GuestName, Room.Code Room ,PriceType.Code PriceType, CONVERT(date,DateCheckIn) DateCheckIn,CONVERT(time,DateCheckIn) TimeCheckIn, CONVERT(date,DateCancel) DateCancel,CONVERT(time,DateCancel) TimeCancel, AppUser.Code CancelBy, Stay.Note  FROM Stay " +
                            " INNER JOIN Room ON Room.Oid = Stay.Room " +
                            " INNER JOIN PriceType ON PriceType.Oid = Stay.PriceType " +
                            " LEFT JOIN AppUser ON AppUser.Oid = Stay.CancelBy " +
                            " WHERE Stay.Status = 2 AND DateCancel BETWEEN '" + from + " 00:00:00' AND '" + until + " 23:59:59'" +
                            " ORDER BY DateCheckIn ASC ";
            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }

        private DataSet RoomLogDataSource(String from, String until)
        {
            String strQuery;
            strQuery = "Declare @start datetime, \r\n" +
                                "@end datetime \r\n" +

                                "set @start = '" + from + "' \r\n" +
                                "set @end = '" + until + "' \r\n" +
                                "; \r\n" +
                                "with calendar(tanggal,isweekday, y, q,m,d,dw,monthname,dayname,w) as \r\n" +
                                "( \r\n" +
                                "select @start , \r\n" +
                                "case when datepart(dw,@start) in (1,7) then 0 else 1 end, \r\n" +
                                "year(@start), \r\n" +
                                "datepart(qq,@start), \r\n" +
                                "datepart(mm,@start), \r\n" +
                                "datepart(dd,@start), \r\n" +
                                "datepart(dw,@start), \r\n" +
                                "datename(month, @start), \r\n" +
                                "datename(dw, @start), \r\n" +
                                "datepart(wk, @start) \r\n" +
                                "union all \r\n" +
                                "select tanggal + 1, \r\n" +
                                "case when datepart(dw,tanggal + 1) in (1,7) then 0 else 1 end, \r\n" +
                                "year(tanggal + 1), \r\n" +
                                "datepart(qq,tanggal + 1), \r\n" +
                                "datepart(mm,tanggal + 1), \r\n" +
                                "datepart(dd,tanggal + 1), \r\n" +
                                "datepart(dw,tanggal + 1), \r\n" +
                                "datename(month, tanggal + 1), \r\n" +
                                "datename(dw, tanggal + 1), \r\n" +
                                "datepart(wk, tanggal + 1) from calendar where tanggal + 1< @end \r\n" +
                                ") \r\n" +

                                "SELECT calendar.tanggal,Room.Code Room, CONVERT(date,DateCheckIn) DateCheckIn,CONVERT(time,DateCheckIn) TimeCheckIn, CONVERT(date,DateCheckOut) DateCheckOut,CONVERT(time,DateCheckOut) TimeCheckOut, \r\n" +
                                "PriceType.Code PriceType, Stay.GuestName, CheckIn.Name CheckInBy,CheckOut.Name CheckOutBy \r\n" +
                                "FROM MasterStay \r\n" +
                                "INNER JOIN Stay ON Stay.MasterStay = MasterStay.Oid AND MasterStay.Status <> 2 \r\n" +
                                "INNER JOIN PriceType ON PriceType.Oid= Stay.PriceType \r\n" +
                                "INNER JOIN Room ON Stay.Room = Room.Oid \r\n" +
                                "LEFT JOIN calendar ON calendar.tanggal BETWEEN CONVERT(date,stay.DateCheckIn) AND CONVERT(date,Stay.DateCheckOut) \r\n" +
                                "LEFT JOIN AppUser CheckIn ON CheckIn.Oid = Stay.CheckInBy \r\n" +
                                "LEFT JOIN AppUser CheckOut ON CheckOut.Oid = Stay.CheckOutBy \r\n" +
                                "WHERE calendar.tanggal is NOT null \r\n" +
                                "ORDER BY calendar.tanggal,Room.Code,CONVERT(date,DateCheckIn),CONVERT(time,DateCheckIn) \r\n OPTION (MAXRECURSION 10000)";

            DataSet dt = FormHelper.ExecuteQuery(strQuery);
            return dt;
        }
    }
}
