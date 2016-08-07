using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class PriceTypePeriod : MyObjectBase
    {
        private Double _price;
        private PriceType _priceType;
        private DateTime _startDate;
        private DateTime _untilDate;

        public PriceTypePeriod(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public override string ToString()
        {
            String strStart = "";
            String strUntil = "";
            String strPriceType = "";
            if (StartDate != null && StartDate != new DateTime()) { strStart = StartDate.ToString("dd-MM-yyyy HH:mm"); }
            if (UntilDate != null && UntilDate != new DateTime()) { strUntil = UntilDate.ToString("dd-MM-yyyy HH:mm"); }
            if (PriceType != null) { strPriceType = PriceType.Name; }
            return String.Format("Price Period {0} {1}-{2} : {3}", strPriceType, strStart, strUntil, Price.ToString("#,#.##"));
        }

        public Double Price
        {
            get { return _price; }
            set { SetPropertyValue("Price", ref _price, value); }
        }

        [Association("PriceType-PriceTypePeriods")]
        public PriceType PriceType
        {
            get { return _priceType; }
            set { SetPropertyValue("PriceType", ref _priceType, value); }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { SetPropertyValue("StartDate", ref _startDate, value); }
        }

        public DateTime UntilDate
        {
            get { return _untilDate; }
            set { SetPropertyValue("UntilDate", ref _untilDate, value); }
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
    }
}