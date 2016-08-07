using System;
using System.Security.Cryptography;
using System.Text;
using DevExpress.Xpo;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using DevExpress.Data.Filtering;

namespace HotelMIS.Model
{
    public static class GlobalVar
    {
        public static Double _currentApplicationVersion = 1.1;
        public static AppUser _currentLoginUser;
        public static Session _globalSession;
        public static UnitOfWork _globalUOW;
        public static SystemSetting _globalSetting;
        public static string _pubConnectionString;

        public static string PubConnectionString
        {
            get { return _pubConnectionString; }
            set { _pubConnectionString = value; }
        }

        public enum ServiceStatus
        {
            None,
            NotCleaned,
            Cleaned
        }

        public enum LabelColor
        {
            None,
            RedPink,
            BlueSea,
            LightGreen,
            YellowSkin,
            LightBrown,
            BlueSky,
            OldGreen,
            LightPurple,
            Aquamarine,
            LightYellow,
        }

        public enum RoomStatus
        {
            Vacant,
            Filled,
            Cleaning,
            Maintenance
        }

        public enum ScheduleType
        {
            Reservation,
            CheckIn,
            CheckOut,
            Cleaning,
            History
        }

        public enum CheckType
        {
            CheckIn,
            CheckOut
        }

        public enum TransactionStatus
        {
            Entry,
            Processed,
            Cancel,
        }

        public enum PaymentStatus
        {
            UnderPaid,
            Paid,
            OverPaid
        }

        public enum ReservationStatus
        {
            Waiting,
            Confirm,
            CheckIn,
            Staying,
            CheckOut,
            Cancel
        }

        public static double CallNumberBox()
        {
            using (frmDlgNumber oNumberBox = new frmDlgNumber())
            {
                oNumberBox.ShowDialog();
                if (oNumberBox.newAmount != 0)
                {
                    return oNumberBox.newAmount;
                }
                return 0;
            }
        }

        public static Double CurrentApplicationVersion
        {
            get { return _currentApplicationVersion; }
        }

        public static AppUser CurrentLoginUser
        {
            get { return _currentLoginUser; }
            set { _currentLoginUser = value; }
        }

        public static SystemSetting GlobalSetting
        {
            get { return _globalSetting; }
            set { _globalSetting = value; }
        }

        public static Session GlobalSession
        {
            get { return _globalSession; }
            set { _globalSession = value; }
        }

        public static UnitOfWork GlobalUOW
        {
            get { return _globalUOW; }
            set { _globalUOW = value; }
        }

        public static String GetObjectString(Object prmObject)
        {
            String oString = "";
            if (prmObject != null)
            {
                oString = prmObject.ToString();
            }
            return oString;
        }

        public static WorkingShift GetCurrentWorkingShift(Session prmSession)
        {
            if (GlobalVar.CurrentLoginUser == null)
            {
                return null;
            }
            WorkingShift oWorkingShift = prmSession.FindObject<WorkingShift>(PersistentCriteriaEvaluationBehavior.InTransaction,
                                        GroupOperator.And(new BinaryOperator("IsClosed", false),
                                                            new BinaryOperator("AppUser.Oid", GlobalVar.CurrentLoginUser.Oid)));
            return oWorkingShift;
        }

        public static DateTime GetCheckOutTime(DateTime prmDate,bool isShortTime)
        {
            if (!isShortTime)
            {
                if (prmDate.Hour >= 6)
                {
                    return new DateTime(prmDate.Year, prmDate.Month, prmDate.Day, 12, 0, 0);
                }
                return new DateTime(prmDate.Year, prmDate.Month, prmDate.Day, 12, 0, 0).AddDays(-1);
            }
            else
            {
                return ClearSeconds(prmDate);
            }
        }

        public static Double Percentage(Double prmPercent)
        {
            return Math.Round(prmPercent / 100, 3);
        }

        public static Double CountDurationInDays(DateTime dateStart,DateTime dateEnd, int precision)
        {
            return Math.Round((DateDiff(DateInterval.Minute,dateStart,dateEnd)/60)/24,precision);
        }

        public static Double CountDurationInHours(DateTime dateStart, DateTime dateEnd, int precision)
        {
            return Math.Round(DateDiff(DateInterval.Minute, dateStart, dateEnd)/60, precision);
        }

        //public long ExecuteNonQuery(IDbConnection objCon, String strQuery, IDbTransaction objTransaction = null)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = strQuery;
        //        cmd.CommandTimeout = 1200;
        //        cmd.Connection = (SqlConnection)objCon;

        //        if (!(objTransaction == null))
        //            cmd.Transaction = (SqlTransaction)objTransaction;
        //        return cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static DataTable ExecuteQuery(IDbConnection objCon, string strQuery, IDbTransaction objTransaction = null)
        {
            DataTable functionReturnValue = new DataTable();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = strQuery,
                Connection = (SqlConnection)objCon
            };
            cmd.CommandTimeout = 120;
            if ((objTransaction != null))
                cmd.Transaction = (SqlTransaction)objTransaction;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(functionReturnValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            da.Dispose();
            return functionReturnValue;
        }


        //public object ExecuteScalar(IDbConnection objCon, string strQuery, IDbTransaction objTransaction = null)
        //{
        //    SqlCommand cmd = new SqlCommand
        //    {
        //        CommandText = strQuery,
        //        Connection = (SqlConnection)objCon
        //    };
        //    if ((objTransaction != null))
        //        cmd.Transaction = (SqlTransaction)objTransaction;
        //    try
        //    {
        //        return cmd.ExecuteScalar();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static String MD5Hash(String prmString)
        {
            String result = "";

            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                result = BitConverter.ToString(md5.ComputeHash(ASCIIEncoding.Default.GetBytes(prmString)));
            }

            return result.Replace("-", String.Empty);
        }

        public enum DateInterval
        {
            Year,
            Month,
            Weekday,
            Day,
            Hour,
            Minute,
            Second
        }

        public enum Gender
        {
            Mr,
            Mrs
        }

        public static bool DateIsIntersect(DateRange prmDate1, DateRange prmDate2)
        {
            if (!((prmDate1.From > prmDate2.From && prmDate1.From > prmDate2.Until) && ( prmDate1.Until > prmDate2.From && prmDate1.Until > prmDate2.Until)))
            {
                return true;
            }
            return false;
        }

        public static List<DateRange> GenerateDateList(DateTime prmFrom,DateTime prmUntil)
        {
            List<DateRange> lsDate = new List<DateRange>();
            DateTime startDate = GlobalVar.ClearSeconds(prmFrom);
            DateTime endDate = GlobalVar.ClearSeconds(prmUntil);

            while (!GlobalVar.DateTimeIsEqual(startDate, endDate))
            {
                DateRange oDateRange = new DateRange();
                if (startDate.Date == endDate.Date)
                {
                    oDateRange.From = startDate;
                    oDateRange.Until = endDate;
                    if (GlobalVar.DateDiff(GlobalVar.DateInterval.Minute, oDateRange.From, oDateRange.Until) >= 1400) { oDateRange.IsAllDay = true; } else { oDateRange.IsAllDay = false; } //1400 is +-23.5 hours
                    lsDate.Add(oDateRange);
                    //startDate = startDate.AddSeconds(GlobalVar.DateDiff(GlobalVar.DateInterval.Second, oDateRange.From, oDateRange.Until));
                    startDate = endDate;
                }
                else
                {
                    oDateRange.From = startDate;
                    oDateRange.Until = startDate.Date.AddDays(1).AddSeconds(-1);
                    if (GlobalVar.DateDiff(GlobalVar.DateInterval.Minute, oDateRange.From, oDateRange.Until) >= 1400) { oDateRange.IsAllDay = true; } else { oDateRange.IsAllDay = false; } //1400 is +-23.5 hours
                    lsDate.Add(oDateRange);
                    startDate = startDate.Date.AddDays(1);
                }
            }

            return lsDate;
        }

        public static DateTime ClearSeconds(DateTime date)
        {
            date = date.AddTicks((date.Second * TimeSpan.TicksPerSecond) * -1);
            date = date.AddTicks((date.Millisecond * TimeSpan.TicksPerMillisecond) * -1);
            return date;
        }

        public static bool DateTimeIsEqual(DateTime date1, DateTime date2)
        {
            bool flag = true;

            if (date1.Year != date2.Year) { flag = false; }
            if (date1.Month != date2.Month) { flag = false; }
            if (date1.Day != date2.Day) { flag = false; }
            if (date1.Hour != date2.Hour) { flag = false; }
            if (date1.Minute != date2.Minute) { flag = false; }
            if (date1.Second != date2.Second) { flag = false; }
            if (date1.Millisecond != date2.Millisecond) { flag = false; }

            return flag;
        }

        public static Double DateDiff(DateInterval interval, DateTime date1, DateTime date2)
        {

            TimeSpan ts = date2 - date1;

            switch (interval)
            {
                case DateInterval.Year:
                    return date2.Year - date1.Year;
                case DateInterval.Month:
                    return (date2.Month - date1.Month) + (12 * (date2.Year - date1.Year));
                case DateInterval.Weekday:
                    return Fix(ts.TotalDays) / 7;
                case DateInterval.Day:
                    return Fix(ts.TotalDays);
                case DateInterval.Hour:
                    return Fix(ts.TotalHours);
                case DateInterval.Minute:
                    return Fix(ts.TotalMinutes);
                default:
                    return Fix(ts.TotalSeconds);
            }
        }

        private static Double Fix(double Number)
        {
            if (Number >= 0)
            {
                return (long)Math.Floor(Number);
            }
            return (long)Math.Ceiling(Number);
        }        
    }

    public class DateRange
    {
        private DateTime _from;
        private DateTime _until;
        private bool _isAllDay;

        public DateTime From
        {
            get { return _from; }
            set { _from = value; }
        }

        public DateTime Until
        {
            get { return _until; }
            set { _until = value; }
        }

        public bool IsAllDay
        {
            get { return _isAllDay; }
            set { _isAllDay = value; }
        }
    }

    public class ValidationClass
    {
        private String _errorType;
        private String _description;

        public String ErrorType
        {
            get { return _errorType; }
            set { _errorType = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description= value; }
        }
    }

}