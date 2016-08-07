using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class AutoNoDetail : MyObjectBase
    {
        private AutoNo _autoNo;
        private String _prefix;
        private long _lastNumber;

        public AutoNoDetail(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        [Association("AutoNo-AutoNoDetail")]
        public AutoNo AutoNo
        {
            get { return _autoNo; }
            set { SetPropertyValue("AutoNo", ref _autoNo, value); }
        }

        public String Prefix
        {
            get { return _prefix; }
            set { SetPropertyValue("Prefix", ref _prefix, value); }
        }

        public long LastNumber
        {
            get { return _lastNumber; }
            set { SetPropertyValue("LastNumber", ref _lastNumber, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }
}