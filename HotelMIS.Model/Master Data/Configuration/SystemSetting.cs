using System;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class SystemSetting : MyObjectBase
    {
        private Double _breakfastPrice;
        private int _daysForDiscount;
        private int _controlBoardDays;
        private UserRole _roomServiceRole;
        private int _discount;
        private Double _extraBedPrice;

        public SystemSetting(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public XPCollection<PaymentType> AvailablePaymentType
        {
            get
            {
                return new XPCollection<PaymentType>(Session);
            }
        }

        public XPCollection<UserRole> AvailableRole
        {
            get
            {
                return new XPCollection<UserRole>(Session);
            }
        }

        public Double BreakfastPrice
        {
            get { return _breakfastPrice; }
            set { SetPropertyValue("BreakfastPrice", ref _breakfastPrice, value); }
        }

        public UserRole RoomServiceRole
        {
            get { return _roomServiceRole; }
            set { SetPropertyValue("RoomServiceRole", ref _roomServiceRole, value); }
        }

        [NonPersistent()]
        public Guid RoomServiceRoleOid
        {
            get { if (RoomServiceRole != null) { return RoomServiceRole.Oid; } else { return Guid.Empty; } }
            set { RoomServiceRole = Session.GetObjectByKey<UserRole>(value); }
        }
        
        public int DaysForDiscount
        {
            get { return _daysForDiscount; }
            set { SetPropertyValue("DaysForDiscount", ref _daysForDiscount, value); }
        }

        public int ControlBoardDays
        {
            get { return _controlBoardDays; }
            set { SetPropertyValue("ControlBoardDays", ref _controlBoardDays, value); }
        }

        public int Discount
        {
            get { return _discount; }
            set { SetPropertyValue("Discount", ref _discount, value); }
        }

        public Double ExtraBedPrice
        {
            get { return _extraBedPrice; }
            set { SetPropertyValue("ExtraBedPrice", ref _extraBedPrice, value); }
        }

        public static SystemSetting GetInstance(Session prmSession)
        {
            SystemSetting oSystemSetting = prmSession.FindObject<SystemSetting>(null);
            if (oSystemSetting == null)
            {
                oSystemSetting = new SystemSetting(prmSession);
                oSystemSetting.Save();
            }
            return oSystemSetting;
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        protected override void OnSaving()
        {
            base.OnSaving();
        }
    }
}