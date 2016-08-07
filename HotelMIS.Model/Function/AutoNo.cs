using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class AutoNo : MyObjectBase
    {
        private String _code;
        private int _digit;

        public AutoNo(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public String Code
        {
            get { return _code; }
            set { SetPropertyValue("Code", ref _code, value); }
        }

        public int Digit
        {
            get { return _digit; }
            set { SetPropertyValue("Digit", ref _digit, value); }
        }

        [Association("AutoNo-AutoNoDetail"), Aggregated()]
        public XPCollection<AutoNoDetail> AutoNoDetails
        {
            get
            {
                return GetCollection<AutoNoDetail>("AutoNoDetails");
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        private long GetLastNumber(String prmPrefix)
        {
            long lastNumber = 1;
            AutoNoDetail objAutoNoDetail = Session.FindObject<AutoNoDetail>(GroupOperator.And(new BinaryOperator("AutoNo.Oid", this.Oid),new BinaryOperator("Prefix",prmPrefix)));
            if (objAutoNoDetail == null)
            {
                objAutoNoDetail = new AutoNoDetail(Session);
                objAutoNoDetail.AutoNo = this;
                objAutoNoDetail.Prefix = prmPrefix;
                objAutoNoDetail.LastNumber = lastNumber;
                objAutoNoDetail.Save();
            }
            else
            {
                lastNumber = objAutoNoDetail.LastNumber + 1;
                objAutoNoDetail.LastNumber = lastNumber;
                objAutoNoDetail.Save();
            }
            return lastNumber;
        }

        public static String GetAutoNumber(Session prmSession,String prmCodeType, DateTime prmPrefix)
        {
            String lastNumber;
            String prefixFormat;
            int digitFormat;
            AutoNo objAutoNo = prmSession.FindObject<AutoNo>(new BinaryOperator("Code",prmCodeType));
            switch (prmCodeType)
            {
                case "PaymentVoucher":
                    prefixFormat = "yyMM";
                    digitFormat = 4;
                    break;
                case "Guest":
                    prefixFormat = "yy";
                    digitFormat = 5;
                    break;
                default:
                    prefixFormat = "yyMM";
                    digitFormat = 5;
                    break;
            }
            if (objAutoNo == null)
            {
                objAutoNo = new AutoNo(prmSession);
                objAutoNo.Code = prmCodeType;
                objAutoNo.Digit = digitFormat;
                objAutoNo.Save();
            }
            
            lastNumber = objAutoNo.GetLastNumber(prmPrefix.ToString(prefixFormat)).ToString();

            while (lastNumber.Length != objAutoNo.Digit)
            {
                lastNumber = "0" + lastNumber;
            }
            return prmPrefix.ToString(prefixFormat) + lastNumber;
        }
    }
}