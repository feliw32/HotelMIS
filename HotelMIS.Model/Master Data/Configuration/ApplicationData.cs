using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using DevExpress.Persistent.BaseImpl;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class ApplicationData : BaseObject
    {
        private Double _applicationVersion;

        public ApplicationData(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public Double ApplicationVersion
        {
            get { return _applicationVersion; }
            set { SetPropertyValue("ApplicationVersion", ref _applicationVersion, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }
    }
}