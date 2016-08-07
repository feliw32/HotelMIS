using System;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class ReportDesign : MyObjectBase
    {
        private String _code;
        private String _name;
        private String _query;
        private String _reportFile;

        public ReportDesign(Session session)
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

        public String Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        [Size(4000)]
        public String Query
        {
            get { return _query; }
            set { SetPropertyValue("Query", ref _query, value); }
        }

        public String ReportFile
        {
            get { return _reportFile; }
            set { SetPropertyValue("ReportFile", ref _reportFile, value); }
        }

        [Association("ReportDesign-ReportParameter"), Aggregated()]
        public XPCollection<ReportParameter> ReportParameters
        {
            get
            {
                return GetCollection<ReportParameter>("ReportParameters");
            }
        }

        public static XPCollection<ReportDesign> DataCollection(Session prmSession)
        {
            return new XPCollection<ReportDesign>(prmSession);
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