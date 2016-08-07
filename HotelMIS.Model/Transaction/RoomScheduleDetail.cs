using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class RoomScheduleDetail : MyObjectBase
    {
        private DateTime _transDate;
        private DateTime _from;
        private bool _isAllDay;
        private Room _room;
        private RoomSchedule _roomSchedule;
        private GlobalVar.ScheduleType _scheduleType;
        private DateTime _until;

        public RoomScheduleDetail(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public DateTime TransDate
        {
            get { return _transDate; }
            set { SetPropertyValue("TransDate", ref _transDate, value); }
        }

        public DateTime From
        {
            get { return _from; }
            set { SetPropertyValue("From", ref _from, value); }
        }

        public bool IsAllDay
        {
            get { return _isAllDay; }
            set { SetPropertyValue("IsAllDay", ref _isAllDay, value); }
        }

        public Room Room
        {
            get { return _room; }
            set { SetPropertyValue("Room", ref _room, value); }
        }

        [Association("RoomSchedule-RoomScheduleDetail")]
        public RoomSchedule RoomSchedule
        {
            get { return _roomSchedule; }
            set { SetPropertyValue("RoomSchedule ", ref _roomSchedule, value); }
        }

        public GlobalVar.ScheduleType ScheduleType
        {
            get { return _scheduleType; }
            set { SetPropertyValue("ScheduleType", ref _scheduleType, value); }
        }

        public DateTime Until
        {
            get { return _until; }
            set { SetPropertyValue("Until", ref _until, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }
    }
}