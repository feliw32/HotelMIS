using System;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class Room : MyObjectBase
    {
        private String _code;
        private String _floor;
        private String _name;
        private RoomType _roomType;
        private GlobalVar.RoomStatus _roomStatus;
        private String _maintenanceStatus;

        public Room(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public XPCollection<RoomType> AvailableRoomType
        {
            get { return new XPCollection<RoomType>(Session); }
        }

        public String Code
        {
            get { return _code; }
            set { SetPropertyValue("Code", ref _code, value); }
        }

        public String Floor
        {
            get { return _floor; }
            set { SetPropertyValue("Floor", ref _floor, value); }
        }

        public String Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        public String MaintenanceStatus
        {
            get { return _maintenanceStatus; }
            set { SetPropertyValue("MaintenanceStatus", ref _maintenanceStatus, value); }
        }

        [Association("Room-RoomPrices"), Aggregated()]
        public XPCollection<RoomPrice> RoomPrices
        {
            get
            {
                return GetCollection<RoomPrice>("RoomPrices");
            }
        }

        public RoomType RoomType
        {
            get { return _roomType; }
            set { SetPropertyValue("RoomType", ref _roomType, value); }
        }

        public GlobalVar.RoomStatus RoomStatus
        {
            get { return _roomStatus; }
            set { SetPropertyValue("RoomStatus", ref _roomStatus, value); }
        }

        [NonPersistent()]
        public Guid RoomTypeOid
        {
            get { if (RoomType != null) { return RoomType.Oid; } else { return Guid.Empty; } }
            set { RoomType = Session.GetObjectByKey<RoomType>(value); }
        }

        public static XPCollection<Room> DataCollection(Session prmSession)
        {
            return new XPCollection<Room>(prmSession);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (Session.IsNewObject(this) && !IsDeleted)
            {
                WorkingShiftDetail.CreateWorkingLog(Session, "Save New " + this.ToString(), 0, 0, 0);
            }
            else if (!IsDeleted)
            {
                WorkingShiftDetail.CreateWorkingLog(Session, "Edit " + this.ToString(), 0, 0, 0);
            }
        }

        public override string ToString()
        {
            String strCode = "";
            String strName = "";
            if (Code != null) { strCode = Code; }
            if (Name != null) { strName = Name; }
            return String.Format("Room {0}-{1}", strCode, strName);
        }

        public String CurrentGuest
        {
            get
            {
                if (RoomStatus == GlobalVar.RoomStatus.Vacant)
                {
                    return "";
                }
                Stay oStay = Session.FindObject<Stay>(GroupOperator.And(new BinaryOperator("Room.Oid",this.Oid.ToString()), new BinaryOperator("Status",GlobalVar.TransactionStatus.Entry)));
                if (oStay != null)
                {
                    return String.Format("{0} From: {1:dd/MM HH:mm} Until: {2:dd/MM HH:mm}", oStay.Guest.Name, oStay.DateCheckIn, oStay.DateCheckOut); 
                }
                return "";
            }
        }

        public static int GetTotalVacant(Session prmSession)
        {
            using (XPCollection<Room> xPCollection = new XPCollection<Room>(prmSession, new BinaryOperator("RoomStatus", GlobalVar.RoomStatus.Vacant)))
            {
                return xPCollection.Count;
            }
        }

        public static int GetTotalFilled(Session prmSession)
        {
            using (XPCollection<Room> xPCollection = new XPCollection<Room>(prmSession, new BinaryOperator("RoomStatus", GlobalVar.RoomStatus.Filled)))
            {
                return xPCollection.Count;
            }
        }

        public static int GetTotalMaintenance(Session prmSession)
        {
            using (XPCollection<Room> xPCollection = new XPCollection<Room>(prmSession, new BinaryOperator("RoomStatus", GlobalVar.RoomStatus.Maintenance)))
            {
                return xPCollection.Count;
            }
        }
    }
}