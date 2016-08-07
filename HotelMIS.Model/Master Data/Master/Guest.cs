using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class Guest : MyObjectBase
    {
        private String _code;
        private IdentificationType _identificationType;
        private Boolean _isCompany;
        private String _companyName;
        private String _name;
        private DateTime _dateOfBirth;
        private Nationality _nationality;
        private String _phoneNumber;
        private String _SSID;
        private String _KTP;
        private String _SIM;
        private String _passport;
        private String _note;
        private GlobalVar.Gender _gender;

        public Guest(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public XPCollection<IdentificationType> AvailableIdentificationType
        {
            get
            {
                return new XPCollection<IdentificationType>(Session);
            }
        }

        public XPCollection<Nationality> AvailableNationality
        {
            get
            {
                return new XPCollection<Nationality>(Session);
            }
        }

        public override string ToString()
        {
            String strCode = "";
            String strName = "";
            if (Code != null) { strCode = Code; }
            if (Name != null) { strName = Name; }
            return String.Format("Guest {0}-{1}", strCode, strName);
        }

        public String Code
        {
            get { return _code; }
            set { SetPropertyValue("Code", ref _code, value); }
        }


        public GlobalVar.Gender Gender
        {
            get { return _gender; }
            set { SetPropertyValue("Gender", ref _gender, value); }
        }

        public IdentificationType IdentificationType
        {
            get { return _identificationType; }
            set { SetPropertyValue("IdentificationType", ref _identificationType, value); }
        }

        [NonPersistent()]
        public Guid IdentificationTypeOid
        {
            get { if (IdentificationType != null) { return IdentificationType.Oid; } else { return Guid.Empty; } }
            set { IdentificationType = Session.GetObjectByKey<IdentificationType>(value); }
        }

        public Boolean IsCompany
        {
            get { return _isCompany; }
            set { SetPropertyValue("IsCompany", ref _isCompany, value); }
        }

        public String Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        public String CompanyName
        {
            get { return _companyName; }
            set { SetPropertyValue("CompanyName", ref _companyName, value); }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { SetPropertyValue("DateOfBirth", ref _dateOfBirth, value); }
        }

        public Nationality Nationality
        {
            get { return _nationality; }
            set { SetPropertyValue("Nationality", ref _nationality, value); }
        }

        [NonPersistent()]
        public Guid NationalityOid
        {
            get { if (Nationality != null) { return Nationality.Oid; } else { return Guid.Empty; } }
            set { Nationality = Session.GetObjectByKey<Nationality>(value); }
        }

        public String PhoneNumber
        {
            get { return _phoneNumber; }
            set
            { SetPropertyValue("PhoneNumber", ref _phoneNumber, value); }
        }

        public String SSID
        {
            get { return _SSID; }
            set { SetPropertyValue("SSID", ref _SSID, value); }
        }

        public String KTP
        {
            get { return _KTP; }
            set { SetPropertyValue("KTP", ref _KTP, value); }
        }

        public String SIM
        {
            get { return _SIM; }
            set { SetPropertyValue("SIM", ref _SIM, value); }
        }

        public String Passport
        {
            get { return _passport; }
            set { SetPropertyValue("Passport", ref _passport, value); }
        }

        [Size(5000)]
        public String Note
        {
            get { return _note; }
            set { SetPropertyValue("Note", ref _note, value); }
        }

        public static XPCollection<Guest> DataCollection(Session prmSession)
        {
            return new XPCollection<Guest>(prmSession);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
            if (Session.IsNewObject(this))
            {
                Code = "[ Auto Generated ]";
            }
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (Session.IsNewObject(this))
            {
                Code = AutoNo.GetAutoNumber(Session, "Guest", DateTime.Now);
                
            }
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