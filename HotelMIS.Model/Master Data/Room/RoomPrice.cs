using System;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class RoomPrice : MyObjectBase
    {
        private PriceType _priceType;
        private Room _room;
        
        public RoomPrice(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public XPCollection<PriceType> AvailablePriceType
        {
            get { return new XPCollection<PriceType>(Session, new BinaryOperator("RoomType", Room.RoomType)); }
        }

        public PriceType PriceType
        {
            get { return _priceType; }
            set { SetPropertyValue("PriceType", ref _priceType, value); }
        }

        public string PriceTypeName
        {
            get
            {
                if (PriceType != null)
                    return PriceType.Name;
                return null;
            }
        }

        [NonPersistent()]
        public Guid PriceTypeOid
        {
            get { if (PriceType != null) { return PriceType.Oid; } else { return Guid.Empty; } }
            set { PriceType = Session.GetObjectByKey<PriceType>(value); }
        }

        [Association("Room-RoomPrices")]
        public Room Room
        {
            get { return _room; }
            set { SetPropertyValue("Room", ref _room, value); }
        }

        public string RoomCode
        {
            get
            {
                if (Room != null)
                    return Room.Code;
                return null;
            }
        }

        public string RoomName
        {
            get
            {
                if (Room != null)
                    return Room.Name;
                return null;
            }
        }

        public GlobalVar.RoomStatus RoomStatus
        {
            get
            {
                if (Room != null)
                    return Room.RoomStatus;
                return GlobalVar.RoomStatus.Vacant;
            }
        }

        public string RoomPriceCode
        {
            get
            {
                if (Room != null && PriceType != null)
                    return Room.Code + "-" + PriceType.Code;
                return null;
            }
        }

        public string RoomPriceName
        {
            get
            {
                if (Room != null && PriceType != null)
                    return Room.Name + "-" + PriceType.Name;
                return null;
            }
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
            String strRoom = "";
            String strPriceType = "";
            if (Room != null) { strRoom = RoomCode; }
            if (PriceType != null) { strPriceType = PriceTypeName; }
            return String.Format("RoomPrice {0}-{1}", strRoom, strPriceType);
        }
    }
}