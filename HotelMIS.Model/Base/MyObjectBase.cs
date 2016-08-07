using System;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace HotelMIS.Model
{
    [NonPersistent()]
    public class MyObjectBase : BaseObject
    {
        private System.DateTime _dateCreated;

        private System.DateTime _dateUpdated;

        private string _userCreated;

        private string _userUpdated;

        public MyObjectBase(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        [Custom("DisplayFormat", "{0:g}")]
        public System.DateTime DateCreated
        {
            get { return _dateCreated; }
            set { SetPropertyValue("DateCreated", ref _dateCreated, value); }
        }

        [Custom("DisplayFormat", "{0:g}")]
        public System.DateTime DateUpdated
        {
            get { return _dateUpdated; }
            set { SetPropertyValue("DateTimeUpdated", ref _dateUpdated, value); }
        }

        public string UserCreated
        {
            get { return _userCreated; }
            set { SetPropertyValue("UserCreated", ref _userCreated, value); }
        }

        public string UserUpdated
        {
            get { return _userUpdated; }
            set { SetPropertyValue("UserUpdated", ref _userUpdated, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (!this.IsLoading & !IsDeleted)
            {
                if (Session.IsNewObject(this))
                {
                    this.DateCreated = DateTime.Now;
                    if (GlobalVar.CurrentLoginUser != null)
                    {
                        this.UserCreated = GlobalVar.CurrentLoginUser.Code;
                    }
                    else
                    {
                        this.UserCreated = "System";
                    }
                }
                this.DateUpdated = DateTime.Now;
                if (GlobalVar.CurrentLoginUser != null)
                {
                    this.UserUpdated = GlobalVar.CurrentLoginUser.Code;
                }
                else
                {
                    this.UserUpdated = "System";
                }
            }
        }
    }
}