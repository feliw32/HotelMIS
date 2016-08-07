using System;
using System.Collections.Generic;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class CheckOut : TransactionBase
    {
        private DateTime _checkOutDate;
        private Stay _checkOutFor;
        private String _note;
        private Double _penalties;
        private GlobalVar.TransactionStatus _status;

        public CheckOut(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public XPCollection<Stay> AvailableCheckOutFor
        {
            get { return new XPCollection<Stay>(Session); }
        }

        public DateTime CheckOutDate
        {
            get { return _checkOutDate; }
            set { SetPropertyValue("CheckOutDate", ref _checkOutDate, value); }
        }

        public Stay CheckOutFor
        {
            get { return _checkOutFor; }
            set { SetPropertyValue("CheckOutFor", ref _checkOutFor, value); }
        }

        [NonPersistent()]
        public Guid CheckOutForOid
        {
            get { if (CheckOutFor != null) { return CheckOutFor.Oid; } else { return Guid.Empty; } }
            set { CheckOutFor = Session.GetObjectByKey<Stay>(value); }
        }

        public String CheckOutForToString
        {
            get
            {
                if (CheckOutFor != null)
                {
                    return CheckOutFor.ToString;
                }
                return string.Empty;
            }
        }

        public String Note
        {
            get { return _note; }
            set { SetPropertyValue("Note", ref _note, value); }
        }

        public Double Penalties
        {
            get { return _penalties; }
            set { SetPropertyValue("Penalties", ref _penalties, value); }
        }

        public GlobalVar.TransactionStatus Status
        {
            get { return _status; }
            set { SetPropertyValue("Status", ref _status, value); }
        }

        public static XPCollection<CheckOut> DataCollection(Session prmSession)
        {
            return new XPCollection<CheckOut>(prmSession);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        public void CancelRecord()
        {
            Status = GlobalVar.TransactionStatus.Cancel;
            DeleteSchedule();
            CheckOutFor.UpdateRoomInformation(GlobalVar.RoomStatus.Filled);
            CheckOutFor.Status = GlobalVar.TransactionStatus.Entry;
            CheckOutFor.SubmitSchedule();
            //CheckOutFor.UpdatePaymentStatus();
            CheckOutFor.IsCheckOut = false;
        }

        public void DeleteSchedule()
        {
            Session.ExecuteNonQuery("DELETE FROM RoomScheduleDetail WHERE RoomSchedule IN(SELECT Oid FROM RoomSchedule WHERE Reference = '" + this.Oid.ToString() + "')");
            Session.ExecuteNonQuery("DELETE FROM RoomSchedule WHERE Reference = '" + this.Oid.ToString() + "'");
            CreatePastSchedule();
        }

        public void ProcessRecord()
        {
            Status = GlobalVar.TransactionStatus.Processed;
            DeleteSchedule();
            UpdatePenaltiesToReferencedStay();
            CheckOutFor.UpdateRoomInformation(GlobalVar.RoomStatus.Vacant);
            CheckOutFor.IsCheckOut = true;

            
        }

        public void SubmitSchedule()
        {
            if (Status == GlobalVar.TransactionStatus.Entry)
            {
                RoomSchedule objRoomSchedule = new RoomSchedule(Session);
                objRoomSchedule.Reference = this;
                objRoomSchedule.Room = CheckOutFor.Room;
                objRoomSchedule.Subject = CheckOutFor.GuestName;
                objRoomSchedule.Description = "Checkout " + CheckOutFor.RoomType.Name + " " + CheckOutFor.PriceType.Name + " From : " + CheckOutFor.DateCheckIn.ToString("dd-MM-yyyy HH:mm") + " - " + CheckOutFor.DateCheckOut.ToString("dd-MM-yyyy HH:mm") + "\r\n" +
                                                "Duration In Days: " + CheckOutFor.DurationInDays + "\r\n" +
                                                "Duration In Hours: " + CheckOutFor.DurationInHours;
                objRoomSchedule.ScheduleType = GlobalVar.ScheduleType.CheckOut;
                objRoomSchedule.From = GlobalVar.ClearSeconds(CheckOutFor.DateCheckIn);
                objRoomSchedule.Until = GlobalVar.ClearSeconds(CheckOutFor.DateCheckOut);
                objRoomSchedule.LabelId = GlobalVar.LabelColor.RedPink;
                objRoomSchedule.ResourceId = CheckOutFor.Room.Code;
                objRoomSchedule.Save();

                List<DateRange> lsDate = GlobalVar.GenerateDateList(CheckOutFor.DateCheckIn, CheckOutFor.DateCheckOut);

                foreach (DateRange objDate in lsDate)
                {
                    RoomScheduleDetail objRoomScheduleDetail = new RoomScheduleDetail(Session);
                    objRoomScheduleDetail.RoomSchedule = objRoomSchedule;
                    objRoomScheduleDetail.Room = CheckOutFor.Room;
                    objRoomScheduleDetail.ScheduleType = GlobalVar.ScheduleType.CheckOut;
                    objRoomScheduleDetail.TransDate = objDate.From.Date;
                    objRoomScheduleDetail.From = objDate.From;
                    objRoomScheduleDetail.Until = objDate.Until;
                    objRoomScheduleDetail.IsAllDay = objDate.IsAllDay;
                    objRoomScheduleDetail.Save();
                }
            }
        }

        public void CreatePastSchedule()
        {
    
            RoomSchedule objRoomSchedule = new RoomSchedule(Session);
            objRoomSchedule.Reference = this;
            objRoomSchedule.Room = CheckOutFor.Room;
            objRoomSchedule.Subject = CheckOutFor.GuestName;
            objRoomSchedule.Description = "History " + CheckOutFor.RoomType.Name + " " + CheckOutFor.PriceType.Name + " From : " + CheckOutFor.DateCheckIn.ToString("dd-MM-yyyy HH:mm") + " - " + CheckOutFor.DateCheckOut.ToString("dd-MM-yyyy HH:mm") + "\r\n" +
                                            "Duration In Days: " + CheckOutFor.DurationInDays + "\r\n" +
                                            "Duration In Hours: " + CheckOutFor.DurationInHours;
            objRoomSchedule.ScheduleType = GlobalVar.ScheduleType.History;
            objRoomSchedule.From = GlobalVar.ClearSeconds(CheckOutFor.DateCheckIn);
            objRoomSchedule.Until = GlobalVar.ClearSeconds(CheckOutFor.DateCheckOut);
            objRoomSchedule.LabelId = GlobalVar.LabelColor.None;
            objRoomSchedule.ResourceId = CheckOutFor.Room.Code;
            objRoomSchedule.Save();

            List<DateRange> lsDate = GlobalVar.GenerateDateList(CheckOutFor.DateCheckIn, CheckOutFor.DateCheckOut);

            foreach (DateRange objDate in lsDate)
            {
                RoomScheduleDetail objRoomScheduleDetail = new RoomScheduleDetail(Session);
                objRoomScheduleDetail.RoomSchedule = objRoomSchedule;
                objRoomScheduleDetail.Room = CheckOutFor.Room;
                objRoomScheduleDetail.ScheduleType = GlobalVar.ScheduleType.History;
                objRoomScheduleDetail.TransDate = objDate.From.Date;
                objRoomScheduleDetail.From = objDate.From;
                objRoomScheduleDetail.Until = objDate.Until;
                objRoomScheduleDetail.IsAllDay = objDate.IsAllDay;
                objRoomScheduleDetail.Save();
            }
        }

        public void UpdatePenaltiesToReferencedStay()
        {
            if (CheckOutFor != null)
            {
                //CheckOutFor.UpdatePaymentStatus();
            }
        }

        protected override void OnDeleted()
        {
            base.OnDeleted();
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (!IsLoading && !IsDeleted)
            {
                if (Session.IsNewObject(this))
                {
                    CheckOutDate = DateTime.Now;
                    WorkingShiftDetail.CreateWorkingLog(Session, "Save " + this.ToString(), 0, 0, 0);
                }
            }
        }

        public override string ToString()
        {
            String strCheckOut = "";
            if (CheckOutFor != null) { strCheckOut = CheckOutFor.RoomCode + " - " + CheckOutFor.GuestName; }
            return "Checkout " + strCheckOut;
        }
    }
}