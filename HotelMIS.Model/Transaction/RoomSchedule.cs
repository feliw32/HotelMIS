using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class RoomSchedule : MyObjectBase
    {
        private String _description;
        private DateTime _from;
        private TransactionBase _reference;
        private String _resourceId;
        private Room _room;
        private GlobalVar.ScheduleType _scheduleType;
        private String _subject;
        private GlobalVar.LabelColor _labelId;
        private DateTime _until;

        public RoomSchedule(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        [Size(1000)]
        public String Description
        {
            get { return _description; }
            set { SetPropertyValue("Description", ref _description, value); }
        }

        public DateTime From
        {
            get { return _from; }
            set { SetPropertyValue("From", ref _from, value); }
        }

        public TransactionBase Reference
        {
            get { return _reference; }
            set { SetPropertyValue("Reference", ref _reference, value); }
        }

        public String ResourceId
        {
            get { return _resourceId; }
            set { SetPropertyValue("ResourceId", ref _resourceId, value); }
        }

        public Room Room
        {
            get { return _room; }
            set { SetPropertyValue("Room", ref _room, value); }
        }

        public GlobalVar.ScheduleType ScheduleType
        {
            get { return _scheduleType; }
            set { SetPropertyValue("ScheduleType", ref _scheduleType, value); }
        }

        public String Subject
        {
            get { return _subject; }
            set { SetPropertyValue("Subject", ref _subject, value); }
        }

        public DateTime Until
        {
            get { return _until; }
            set { SetPropertyValue("Until", ref _until, value); }
        }

        public GlobalVar.LabelColor LabelId
        {
            get 
            {
                if (ScheduleType == GlobalVar.ScheduleType.History)
                {
                    return GlobalVar.LabelColor.None;
                }
                if (Until.Subtract(DateTime.Now).TotalMinutes < 65)
                {
                    return GlobalVar.LabelColor.RedPink;
                }
                return _labelId; 
            }
            set { SetPropertyValue("LabelId", ref _labelId, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        [Association("RoomSchedule-RoomScheduleDetail"), Aggregated()]
        public XPCollection<RoomScheduleDetail> RoomScheduleDetails
        {
            get { return GetCollection<RoomScheduleDetail>("RoomScheduleDetails"); }
        }
    }

    
}