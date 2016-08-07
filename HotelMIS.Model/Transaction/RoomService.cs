using System;
using System.Collections.Generic;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class RoomService : TransactionBase
    {
        private DateTime _completedTime;
        private String _note;
        private Stay _roomServiceFor;
        private AppUser _servicePerson;
        private GlobalVar.TransactionStatus _status;

        public RoomService(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public XPCollection<AppUser> AvailableServicePerson
        {
            get { return new XPCollection<AppUser>(Session, new BinaryOperator("UserRole.Oid", GlobalVar.GlobalSetting.RoomServiceRoleOid)); }
        }
        public void ProcessRecord()
        {
            DeleteSchedule();
            RevertRoomStatus();
            CompletedTime = GlobalVar.ClearSeconds(DateTime.Now);
            Status = GlobalVar.TransactionStatus.Processed;
        }
        public XPCollection<Stay> AvailableStay
        {
            get
            {
                return new XPCollection<Stay>(Session, GroupOperator.And(new BinaryOperator("Status",GlobalVar.TransactionStatus.Cancel,BinaryOperatorType.NotEqual),new BinaryOperator("IsCheckOut",false)));
            }
        }

        public DateTime CompletedTime
        {
            get { return _completedTime; }
            set { SetPropertyValue("CompletedTime", ref _completedTime, value); }
        }

        public String Note
        {
            get { return _note; }
            set { SetPropertyValue("Note", ref _note, value); }
        }

        public Stay RoomServiceFor
        {
            get { return _roomServiceFor; }
            set { SetPropertyValue("RoomServiceFor", ref _roomServiceFor, value); }
        }

        [NonPersistent()]
        public Guid RoomServiceForOid
        {
            get { if (RoomServiceFor != null) { return RoomServiceFor.Oid; } else { return Guid.Empty; } }
            set { RoomServiceFor = Session.GetObjectByKey<Stay>(value); }
        }

        public AppUser ServicePerson
        {
            get { return _servicePerson; }
            set { SetPropertyValue("ServicePerson", ref _servicePerson, value); }
        }

        [NonPersistent()]
        public Guid ServicePersonOid
        {
            get { if (ServicePerson != null) { return ServicePerson.Oid; } else { return Guid.Empty; } }
            set { ServicePerson = Session.GetObjectByKey<AppUser>(value); }
        }

        public GlobalVar.TransactionStatus Status
        {
            get { return _status; }
            set { SetPropertyValue("Status", ref _status, value); }
        }

        public static XPCollection<RoomService> DataCollection(Session prmSession)
        {
            return new XPCollection<RoomService>(prmSession);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        public void CancelRecord()
        {
            DeleteSchedule();
            RevertRoomStatus();
            Status = GlobalVar.TransactionStatus.Cancel;
        }

        public void DeleteSchedule()
        {
            Session.ExecuteNonQuery("DELETE FROM RoomScheduleDetail WHERE RoomSchedule IN(SELECT Oid FROM RoomSchedule WHERE Reference = '" + this.Oid.ToString() + "')");
            Session.ExecuteNonQuery("DELETE FROM RoomSchedule WHERE Reference = '" + this.Oid.ToString() + "'");
        }

        public void RevertRoomStatus()
        {
            if (RoomServiceFor.Status == GlobalVar.TransactionStatus.Entry)
            {
                RoomServiceFor.UpdateRoomInformation(GlobalVar.RoomStatus.Filled);
                return;
            }
            CheckOut objCheckOut = Session.FindObject<CheckOut>(GroupOperator.And(new BinaryOperator("CheckOutFor.Oid", RoomServiceFor.Oid), new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel, BinaryOperatorType.NotEqual)));
            if (objCheckOut != null)
            {
                if (objCheckOut.Status == GlobalVar.TransactionStatus.Entry)
                {
                    RoomServiceFor.UpdateRoomInformation(GlobalVar.RoomStatus.Filled);
                }
                else
                {
                    RoomServiceFor.UpdateRoomInformation(GlobalVar.RoomStatus.Vacant);
                }
            }
        }

        public void SubmitSchedule()
        {
            if (Status == GlobalVar.TransactionStatus.Entry)
            {
                RoomServiceFor.Room.RoomStatus = GlobalVar.RoomStatus.Cleaning;
                RoomSchedule objRoomSchedule = new RoomSchedule(Session);
                objRoomSchedule.Reference = this;
                objRoomSchedule.Room = RoomServiceFor.Room;
                objRoomSchedule.Subject = "Cleaning : " + RoomServiceFor.GuestName;
                objRoomSchedule.Description = "Room Service " + RoomServiceFor.RoomType.Name + " " + RoomServiceFor.PriceType.Name + " From : " + RoomServiceFor.DateCheckIn.ToString("dd-MM-yyyy HH:mm") + " - " + RoomServiceFor.DateCheckOut.ToString("dd-MM-yyyy HH:mm") + "\r\n" +
                                                "Duration In Days: " + RoomServiceFor.DurationInDays + "\r\n" +
                                                "Duration In Hours: " + RoomServiceFor.DurationInHours;
                objRoomSchedule.ScheduleType = GlobalVar.ScheduleType.Cleaning;
                objRoomSchedule.From = GlobalVar.ClearSeconds(RoomServiceFor.DateCheckIn);
                objRoomSchedule.Until = GlobalVar.ClearSeconds(RoomServiceFor.DateCheckOut);
                objRoomSchedule.LabelId = GlobalVar.LabelColor.YellowSkin;
                objRoomSchedule.ResourceId = RoomServiceFor.Room.Code;
                objRoomSchedule.Save();

                List<DateRange> lsDate = GlobalVar.GenerateDateList(RoomServiceFor.DateCheckIn, RoomServiceFor.DateCheckOut);

                foreach (DateRange objDate in lsDate)
                {
                    RoomScheduleDetail objRoomScheduleDetail = new RoomScheduleDetail(Session);
                    objRoomScheduleDetail.RoomSchedule = objRoomSchedule;
                    objRoomScheduleDetail.Room = RoomServiceFor.Room;
                    objRoomScheduleDetail.ScheduleType = GlobalVar.ScheduleType.CheckIn;
                    objRoomScheduleDetail.TransDate = objDate.From.Date;
                    objRoomScheduleDetail.From = objDate.From;
                    objRoomScheduleDetail.Until = objDate.Until;
                    objRoomScheduleDetail.IsAllDay = objDate.IsAllDay;
                    objRoomScheduleDetail.Save();
                }
            }
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (Session.IsNewObject(this) && !IsDeleted)
            {
                WorkingShiftDetail.CreateWorkingLog(Session, "Save " + this.ToString(), 0, 0, 0);
            }
        }

        public override string ToString()
        {
            String strRoom = "";
            String strServicePerson = "";
            String strCompletedTime = "";
            String strNote = "";

            if (RoomServiceFor != null) { strRoom = RoomServiceFor.RoomCode; }
            if (ServicePerson != null) { strServicePerson = ServicePerson.Name; }
            if (CompletedTime != null && CompletedTime != new DateTime()) { strCompletedTime = CompletedTime.ToString("dd-MM-yyyy HH:mm"); }
            if (Note != null) { strNote = Note; }

            return String.Format("Room Service {0} by {1} complete at : {2}. {3}", strRoom, strServicePerson, strCompletedTime, strNote);

        }
    }
}