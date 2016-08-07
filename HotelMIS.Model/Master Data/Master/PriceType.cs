using System;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class PriceType : MyObjectBase
    {
        private String _code;
        private bool _isShortTime;
        private String _name;
        private int _duration;
        private RoomType _roomType;
        private GlobalVar.LabelColor _color;

        public PriceType(Session session)
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
            get
            {
                return new XPCollection<RoomType>(Session);
            }
        }

        public String Code
        {
            get { return _code; }
            set { SetPropertyValue("Code", ref _code, value); }
        }

        public GlobalVar.LabelColor Color
        {
            get { return _color; }
            set { SetPropertyValue("Color", ref _color, value); }
        }

        public Double CurrentPrice(DateTime prmDate)
        {
                PriceTypePeriod tmp = getActivePeriod(prmDate);
                if (tmp == null)
                    return 0;
                return tmp.Price;
        }

        public bool IsShortTime
        {
            get { return _isShortTime; }
            set { SetPropertyValue("IsShortTime", ref _isShortTime, value); }
        }

        public int Duration
        {
            get { return _duration; }
            set { SetPropertyValue("Duration", ref _duration, value); }
        }

        public String Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        [Association("PriceType-PriceTypePeriods"), Aggregated()]
        public XPCollection<PriceTypePeriod> PriceTypePeriods
        {
            get
            {
                return GetCollection<PriceTypePeriod>("PriceTypePeriods");
            }
        }

        public RoomType RoomType
        {
            get { return _roomType; }
            set { SetPropertyValue("RoomType", ref _roomType, value); }
        }

        [NonPersistent()]
        public Guid RoomTypeOid
        {
            get { if (RoomType != null) { return RoomType.Oid; } else { return Guid.Empty; } }
            set { RoomType = Session.GetObjectByKey<RoomType>(value); }
        }

        public static XPCollection<PriceType> DataCollection(Session prmSession)
        {
            return new XPCollection<PriceType>(prmSession);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            Color = GlobalVar.LabelColor.BlueSky;
            if (Session.IsNewObject(this) && !IsDeleted)
            {
                WorkingShiftDetail.CreateWorkingLog(Session, "Save New " + this.ToString(), 0, 0, 0);
            }
            else if (!IsDeleted)
            {
                WorkingShiftDetail.CreateWorkingLog(Session, "Edit " + this.ToString(), 0, 0, 0);
            }
        }

        private PriceTypePeriod getActivePeriod(DateTime prmDate)
        {
            PriceTypePeriod tmp;
            tmp = Session.FindObject<PriceTypePeriod>(GroupOperator.And(new BinaryOperator("PriceType", this), 
                GroupOperator.And(new BinaryOperator("StartDate", prmDate, BinaryOperatorType.LessOrEqual), new BinaryOperator("UntilDate", prmDate, BinaryOperatorType.GreaterOrEqual))));
            if (tmp == null)
            {
                tmp = Session.FindObject<PriceTypePeriod>(GroupOperator.And(new BinaryOperator("PriceType", this), GroupOperator.Or(new NullOperator("UntilDate"),
                GroupOperator.And(new BinaryOperator("StartDate", prmDate, BinaryOperatorType.LessOrEqual), new BinaryOperator("UntilDate", prmDate, BinaryOperatorType.GreaterOrEqual)))));
            }
            if (tmp == null)
            {
                XPCollection<PriceTypePeriod> tmpCollection = new XPCollection<PriceTypePeriod>(Session, new BinaryOperator("PriceType", this));
                tmpCollection.Sorting = new SortingCollection(new SortProperty("UntilDate", DevExpress.Xpo.DB.SortingDirection.Descending));
                if (tmpCollection.Count > 0)
                    tmp = tmpCollection[0];
                tmpCollection.Dispose();
            }
            return tmp;
        }

        public override string ToString()
        {
            String strCode = "";
            String strName = "";
            if (Code != null) { strCode = Code; }
            if (Name != null) { strName = Name; }
            return String.Format("PriceType {0}-{1}", strCode, strName);
        }
    }
}