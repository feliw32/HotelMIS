using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class ReportParameter : MyObjectBase
    {
        private ReportDesign _reportDesign;

        private int _sequence;
        private String _parameter;
        private String _displayName;
        private String _fieldName;
        private Boolean _notActive;

        public ReportParameter(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        [Association("ReportDesign-ReportParameter")]
        public ReportDesign ReportDesign
        {
            get { return _reportDesign; }
            set { SetPropertyValue("ReportDesign", ref _reportDesign, value); }
        }

        public int Sequence
        {
            get { return _sequence; }
            set { SetPropertyValue("Sequence", ref _sequence, value); }
        }

        public String Parameter
        {
            get { return _parameter; }
            set { SetPropertyValue("Parameter", ref _parameter, value); }
        }

        public String DisplayName
        {
            get { return _displayName; }
            set { SetPropertyValue("DisplayName", ref _displayName, value); }
        }

        public String FieldName
        {
            get { return _fieldName; }
            set { SetPropertyValue("FieldName", ref _fieldName, value); }
        }

        public Boolean NotActive
        {
            get { return _notActive; }
            set { SetPropertyValue("NotActive", ref _notActive, value); }
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

        public static XPCollection<ReportDesign> DataCollection(Session prmSession)
        {
            return new XPCollection<ReportDesign>(prmSession);
        }
    }
}