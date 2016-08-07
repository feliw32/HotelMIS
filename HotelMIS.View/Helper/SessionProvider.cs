using System.Configuration;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using HotelMIS.Model;
using System;

namespace HotelMIS.View
{
    public sealed class SessionProvider
    {
        private static IDataLayer fDataLayer;
        private static object lockObject = new object();

        private static IDataLayer DataLayer
        {
            get
            {
                if (fDataLayer == null)
                {
                    lock (lockObject)
                    {
                        if (fDataLayer == null)
                        {
                            fDataLayer = GetDataLayer();
                        }
                    }
                }
                return fDataLayer;
            }
        }

        public static void CheckDefaultValue()
        {
            UserRole oUserRole = GlobalVar.GlobalUOW.FindObject<UserRole>(new BinaryOperator("Code", "ADM"));
            if (oUserRole == null)
            {
                oUserRole = new UserRole(GlobalVar.GlobalUOW);
                oUserRole.Code = "ADM";
                oUserRole.Name = "Administrator";
                oUserRole.AccessForMasterData = true;
                oUserRole.AccessForTransaction = true;
                oUserRole.AccessForReport = true;
                oUserRole.Save();
            }

            AppUser oAppUser = GlobalVar.GlobalUOW.FindObject<AppUser>(new BinaryOperator("Code", "hoteladmin"));
            if (oAppUser == null)
            {
                oAppUser = new AppUser(GlobalVar.GlobalUOW);
                oAppUser.Code = "hoteladmin";
                oAppUser.Address = "Default";
                oAppUser.BirthPlace = "Default";
                oAppUser.DateOfBirth = DateTime.Now;
                oAppUser.Name = "Default";
                oAppUser.PhoneNumber = "Default";
                oAppUser.SSID = "Default";
                oAppUser.Password = GlobalVar.MD5Hash("hoteladmin123");
                oAppUser.UserRole = oUserRole;
                oAppUser.Save();   
            }

            if (GlobalVar.GlobalUOW.InTransaction)
                GlobalVar.GlobalUOW.CommitTransaction();
        }

        public static void CheckObjectForSchemaUpdate()
        {
            SystemSetting oSystemSetting = GlobalVar.GlobalSession.FindObject<SystemSetting>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oSystemSetting == null)
                oSystemSetting = new SystemSetting(GlobalVar.GlobalSession);
            oSystemSetting.UserCreated = "SchemaUpdate";
            oSystemSetting.Save();

            Guest oGuest = GlobalVar.GlobalSession.FindObject<Guest>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oGuest == null)
                oGuest = new Guest(GlobalVar.GlobalSession);
            oGuest.UserCreated = "SchemaUpdate";
            oGuest.Save();

            IdentificationType oIdentificationType = GlobalVar.GlobalSession.FindObject<IdentificationType>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oIdentificationType == null)
                oIdentificationType = new IdentificationType(GlobalVar.GlobalSession);
            oIdentificationType.UserCreated = "SchemaUpdate";
            oIdentificationType.Save();

            Nationality oNationality = GlobalVar.GlobalSession.FindObject<Nationality>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oNationality == null)
                oNationality = new Nationality(GlobalVar.GlobalSession);
            oNationality.UserCreated = "SchemaUpdate";
            oNationality.Save();

            PaymentMethod oPaymentMethod = GlobalVar.GlobalSession.FindObject<PaymentMethod>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oPaymentMethod == null)
                oPaymentMethod = new PaymentMethod(GlobalVar.GlobalSession);
            oPaymentMethod.UserCreated = "SchemaUpdate";
            oPaymentMethod.Save();

            PaymentType oPaymentType = GlobalVar.GlobalSession.FindObject<PaymentType>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oPaymentType == null)
                oPaymentType = new PaymentType(GlobalVar.GlobalSession);
            oPaymentType.UserCreated = "SchemaUpdate";
            oPaymentType.Save();

            PriceType oPriceType = GlobalVar.GlobalSession.FindObject<PriceType>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oPriceType == null)
                oPriceType = new PriceType(GlobalVar.GlobalSession);
            oPriceType.UserCreated = "SchemaUpdate";
            oPriceType.Save();

            RoomType oRoomType = GlobalVar.GlobalSession.FindObject<RoomType>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oRoomType == null)
                oRoomType = new RoomType(GlobalVar.GlobalSession);
            oRoomType.UserCreated = "SchemaUpdate";
            oRoomType.Save();

            Room oRoom = GlobalVar.GlobalSession.FindObject<Room>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oRoom == null)
                oRoom = new Room(GlobalVar.GlobalSession);
            oRoom.UserCreated = "SchemaUpdate";
            oRoom.Save();

            RoomPrice oRoomPrice = GlobalVar.GlobalSession.FindObject<RoomPrice>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oRoomPrice == null)
                oRoomPrice = new RoomPrice(GlobalVar.GlobalSession);
            oRoomPrice.UserCreated = "SchemaUpdate";
            oRoomPrice.Save();

            PriceTypePeriod oPriceTypePeriod = GlobalVar.GlobalSession.FindObject<PriceTypePeriod>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oPriceTypePeriod == null)
                oPriceTypePeriod = new PriceTypePeriod(GlobalVar.GlobalSession);
            oPriceTypePeriod.UserCreated = "SchemaUpdate";
            oPriceTypePeriod.Save();

            AppUser oAppUser = GlobalVar.GlobalSession.FindObject<AppUser>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oAppUser == null)
                oAppUser = new AppUser(GlobalVar.GlobalSession);
            oAppUser.UserCreated = "SchemaUpdate";
            oAppUser.Save();

            UserRole oUserRole = GlobalVar.GlobalSession.FindObject<UserRole>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oUserRole == null)
                oUserRole = new UserRole(GlobalVar.GlobalSession);
            oUserRole.UserCreated = "SchemaUpdate";
            oUserRole.Save();

            RoomService oRoomService = GlobalVar.GlobalSession.FindObject<RoomService>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oRoomService == null)
                oRoomService = new RoomService(GlobalVar.GlobalSession);
            oRoomService.UserCreated = "SchemaUpdate";
            oRoomService.Save();

            //RoomServiceLine oRoomServiceLine = GlobalVar.GlobalSession.FindObject<RoomServiceLine>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            //if (oRoomServiceLine == null)
            //    oRoomServiceLine = new RoomServiceLine(GlobalVar.GlobalSession);
            //oRoomServiceLine.UserCreated = "SchemaUpdate";
            //oRoomServiceLine.Save();

            Stay oStay = GlobalVar.GlobalSession.FindObject<Stay>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            if (oStay == null)
                oStay = new Stay(GlobalVar.GlobalSession);
            oStay.UserCreated = "SchemaUpdate";
            oStay.Save();

            //StayPayment oStayPayment = GlobalVar.GlobalSession.FindObject<StayPayment>(new BinaryOperator("UserCreated", "SchemaUpdate"));
            //if (oStayPayment == null)
            //    oStayPayment = new StayPayment(GlobalVar.GlobalSession);
            //oStayPayment.UserCreated = "SchemaUpdate";
            //oStayPayment.Save();
        }

        public static IDataLayer GetDataLayer()
        {
            XpoDefault.Session = null;
            string conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            XPDictionary dict = new ReflectionDictionary();
            IDataStore store = XpoDefault.GetConnectionProvider(conn, AutoCreateOption.DatabaseAndSchema);
            dict.GetDataStoreSchema(typeof(SystemSetting).Assembly);
            IDataLayer dl = new SimpleDataLayer(dict, store);
            return dl;
        }

        public static Session GetNewSession()
        {
            return new Session(DataLayer);
        }

        public static UnitOfWork GetNewUnitOfWork()
        {
            return new UnitOfWork(DataLayer);
        }

        public static void UpdateSchema()
        {
            XPCollection<ApplicationData> oApplicationData = new XPCollection<ApplicationData>(GlobalVar.GlobalSession);
            if (oApplicationData.Count > 0)
            {
                if (oApplicationData[0].ApplicationVersion != GlobalVar.CurrentApplicationVersion)
                {
                    if (oApplicationData[0].ApplicationVersion < GlobalVar.CurrentApplicationVersion)
                    {
                        if (MessageBox.Show("Version is different. Update database schema ?", "Incorrect Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CheckObjectForSchemaUpdate();
                            oApplicationData[0].ApplicationVersion = GlobalVar.CurrentApplicationVersion;
                            oApplicationData[0].Save();
                        }
                        else
                        {
                            System.Environment.Exit(0);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Database version is greater than application version.", "Incorrect Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Environment.Exit(0);
                    }
                }
            }
            else
            {
                ApplicationData newApplicationData = new ApplicationData(GlobalVar.GlobalSession);
                newApplicationData.ApplicationVersion = GlobalVar.CurrentApplicationVersion;
                newApplicationData.Save();
                CheckObjectForSchemaUpdate();
            }
        }
    }
}