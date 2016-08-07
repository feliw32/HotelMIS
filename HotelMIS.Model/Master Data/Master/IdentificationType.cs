using System;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    [DefaultProperty("Name")]
    public class IdentificationType : MyObjectBase
    {
        private String _code;

        private String _name;

        public IdentificationType(Session session)
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

        public static XPCollection<IdentificationType> DataCollection(Session prmSession)
        {
            return new XPCollection<IdentificationType>(prmSession);
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
            return String.Format("IdentificationType {0}-{1}", strCode, strName);
        }
    }
}