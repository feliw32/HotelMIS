using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class AppUser : MyObjectBase
    {
        private String _address;
        private String _birthPlace;
        private String _code;
        private DateTime _dateOfBirth;
        private String _name;
        private String _password;
        private String _phoneNumber;
        private String _SSID;
        private UserRole _userRole;

        public AppUser(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public String Address
        {
            get { return _address; }
            set { SetPropertyValue("Address", ref _address, value); }
        }

        public String BirthPlace
        {
            get { return _birthPlace; }
            set { SetPropertyValue("BirthPlace", ref _birthPlace, value); }
        }

        public String Code
        {
            get { return _code; }
            set { SetPropertyValue("Code", ref _code, value); }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { SetPropertyValue("DateOfBirth", ref _dateOfBirth, value); }
        }

        public String Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        public String Password
        {
            get { return _password; }
            set { SetPropertyValue("Password", ref _password, value); }
        }

        public String PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetPropertyValue("PhoneNumber", ref _phoneNumber, value); }
        }

        public String SSID
        {
            get { return _SSID; }
            set { SetPropertyValue("SSID", ref _SSID, value); }
        }

        public UserRole UserRole
        {
            get { return _userRole; }
            set { SetPropertyValue("UserRole", ref _userRole, value); }
        }

        [NonPersistent()]
        public Guid UserRoleOid
        {
            get { if (UserRole != null) { return UserRole.Oid; } else { return Guid.Empty; } }
            set { UserRole = Session.GetObjectByKey<UserRole>(value); }
        }

        public static XPCollection<AppUser> DataCollection(Session prmSession)
        {
            return new XPCollection<AppUser>(prmSession);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        public XPCollection<UserRole> AvailableUserRole()
        {
            return new XPCollection<UserRole>(Session);
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (Session.IsNewObject(this))
            {
                if (Password == null)
                    GlobalVar.MD5Hash("password123");
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

        public override string ToString()
        {
            String strCode = "";
            String strName = "";
            if (Code != null) { strCode = Code; }
            if (Name != null) { strName = Name; }
            return String.Format("AppUser {0}-{1}", strCode, strName);
        }
    }
}