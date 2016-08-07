using System;
using System.Collections.Generic;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.Data;
using DevExpress.Xpo.DB;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class Stay : TransactionBase
    {
        private MasterStay _masterStay;
        private Boolean _breakfast;
        private AppUser _checkInBy;
        private AppUser _checkOutBy;
        private AppUser _cancelBy;
        private DateTime _dateCheckIn;
        private DateTime _dateCheckOut;
        private DateTime _dateCancel;
        private Double _durationInDays;
        private Double _durationInHours;
        private Boolean _extraBed;
        private Guest _guest;
        private String _guestName;
        private int _noOfGuest;
        private String _note;
        private PriceType _priceType;
        private Room _room;
        private Double _roomRate;
        private RoomType _roomType;
        private GlobalVar.TransactionStatus _status;
        private Double _total;
        private bool _isCheckOut;

        public Stay(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public XPCollection<Guest> AvailableGuest
        {
            get { return new XPCollection<Guest>(Session); }
        }

        public XPCollection<PriceType> AvailablePriceType
        {
            get
            {
                if (RoomType != null)
                    return new XPCollection<PriceType>(Session, new BinaryOperator("RoomType", RoomType));
                return null;
            }
        }

        public XPCollection<Room> AvailableRoom
        {
            get
            {
                if (!IsLoading && !IsDeleted)
                {
                    if (RoomType != null && PriceType != null)
                    {
                        if (Room != null)
                        {
                            return new XPCollection<Room>(Session, CriteriaOperator.Parse(String.Format("RoomPrices[PriceType.Code = '{0}'] AND (RoomStatus = 0 OR Oid = '{1}')", PriceType.Code, Room.Oid)));
                        }
                        return new XPCollection<Room>(Session, CriteriaOperator.Parse(String.Format("RoomPrices[PriceType.Code = '{0}'] AND RoomStatus = 0", PriceType.Code)));
                    }
                }
                return null;
            }
        }

        public XPCollection<RoomType> AvailableRoomType
        {
            get { return new XPCollection<RoomType>(Session); }
        }

        [Association("MasterStay-Stay")]
        public MasterStay MasterStay
        {
            get { return _masterStay; }
            set { SetPropertyValue("MasterStay", ref _masterStay, value); }
        }
        public Boolean Breakfast
        {
            get { return _breakfast; }
            set { SetPropertyValue("Breakfast", ref _breakfast, value); }
        }

        public Boolean IsCheckOut
        {
            get { return _isCheckOut; }
            set { SetPropertyValue("IsCheckOut", ref _isCheckOut, value); }
        }

        public AppUser CheckInBy
        {
            get { return _checkInBy; }
            set { SetPropertyValue("CheckInBy", ref _checkInBy, value); }
        }

        public String CheckInByName
        {
            get
            {
                if (CheckInBy != null)
                {
                    return CheckInBy.Name;
                }
                return string.Empty;
            }
        }

        public AppUser CheckOutBy
        {
            get { return _checkOutBy; }
            set { SetPropertyValue("CheckOutBy", ref _checkOutBy, value); }
        }

        public AppUser CancelBy
        {
            get { return _cancelBy; }
            set { SetPropertyValue("CancelBy", ref _cancelBy, value); }
        }

        public String CheckOutByName
        {
            get
            {
                if (CheckOutBy != null)
                {
                    return CheckOutBy.Name;
                }
                return string.Empty;
            }
        }

        public DateTime DateCheckIn
        {
            get { return _dateCheckIn; }
            set
            {
                if (value.Second > 0 || value.Millisecond > 0) { value = GlobalVar.ClearSeconds(value); }
                SetPropertyValue("DateCheckIn", ref _dateCheckIn, value);
            }
        }

        public DateTime DateCheckOut
        {
            get { return _dateCheckOut; }
            set
            {
                if (value.Second > 0 || value.Millisecond > 0) { value = GlobalVar.ClearSeconds(value); }
                SetPropertyValue("DateCheckOut", ref _dateCheckOut, value);
            }
        }

        public DateTime DateCancel
        {
            get { return _dateCancel; }
            set
            {
                if (value.Second > 0 || value.Millisecond > 0) { value = GlobalVar.ClearSeconds(value); }
                SetPropertyValue("DateCancel", ref _dateCancel, value);
            }
        }

        public Double DurationInDays
        {
            get { return _durationInDays; }
            set { SetPropertyValue("DurationInDays", ref _durationInDays, value); }
        }

        public Double DurationInHours
        {
            get { return _durationInHours; }
            set { SetPropertyValue("DurationInHours", ref _durationInHours, value); }
        }

        public Boolean ExtraBed
        {
            get { return _extraBed; }
            set { SetPropertyValue("ExtraBed", ref _extraBed, value); }
        }

        public Guest Guest
        {
            get { return _guest; }
            set
            {
                SetPropertyValue("Guest", ref _guest, value);
                if (Guest != null) { GuestName = Guest.Name; }
            }
        }

        public String GuestKTP
        {
            get
            {
                if (Guest != null)
                {
                    return Guest.KTP;
                }
                return string.Empty;
            }
        }

        public String GuestName
        {
            get { return _guestName; }
            set { SetPropertyValue("GuestName", ref _guestName, value); }
        }

        [NonPersistent()]
        public Guid GuestOid
        {
            get { if (Guest != null) { return Guest.Oid; } else { return Guid.Empty; } }
            set { Guest = Session.GetObjectByKey<Guest>(value); }
        }

        public String GuestPassport
        {
            get
            {
                if (Guest != null)
                {
                    return Guest.Passport;
                }
                return string.Empty;
            }
        }

        public String GuestSIM
        {
            get
            {
                if (Guest != null)
                {
                    return Guest.SIM;
                }
                return string.Empty;
            }
        }

        public Boolean IsCompany
        {
            get
            {
                if (Guest != null)
                    return Guest.IsCompany;
                return false;
            }
        }

        public bool IsPaymentMade
        {
            get
            {
                XPCollection<PaymentVoucher> coll = new XPCollection<PaymentVoucher>(Session,
                    GroupOperator.And(new BinaryOperator("PaymentForMaster.Oid", this.Oid),
                                        (new BinaryOperator("Status", GlobalVar.TransactionStatus.Processed))));
                return coll.Count > 0;
            }
        }

        public int NoOfGuest
        {
            get { return _noOfGuest; }
            set { SetPropertyValue("NoOfGuest", ref _noOfGuest, value); }
        }

        public String Note
        {
            get { return _note; }
            set { SetPropertyValue("Note", ref _note, value); }
        }

        public Double PenaltiesCost
        {
            get
            {
                CheckOut oCheckOut = Session.FindObject<CheckOut>(PersistentCriteriaEvaluationBehavior.InTransaction,new BinaryOperator("CheckOutFor.Oid", this.Oid));
                if (oCheckOut != null)
                {
                    return oCheckOut.Penalties;
                }
                return 0;
            }
        }

        public PriceType PriceType
        {
            get { return _priceType; }
            set { SetPropertyValue("PriceType", ref _priceType, value); }
        }

        public String PriceTypeName
        {
            get
            {
                if (PriceType != null)
                    return PriceType.Name;
                return null;
            }
        }

        [NonPersistent()]
        public Guid PriceTypeOid
        {
            get { if (PriceType != null) { return PriceType.Oid; } else { return Guid.Empty; } }
            set { PriceType = Session.GetObjectByKey<PriceType>(value); }
        }

        public Room Room
        {
            get { return _room; }
            set 
            {
                SetPropertyValue("Room", ref _room, value); 
            }
        }

        public void IsRoomChanged()
        {
            SelectedData dt = Session.ExecuteQuery("SELECT TOP 1 Room FROM Stay WHERE Stay.Oid = '" + Oid.ToString() + "'");
            if (dt.ResultSet[0].Rows.Length != 0)
            {
                if (dt.ResultSet[0].Rows[0].Values[0].ToString() != RoomOid.ToString())
                {
                    Room prmRoom = Session.GetObjectByKey<Room>(dt.ResultSet[0].Rows[0].Values[0]);
                    prmRoom.RoomStatus = GlobalVar.RoomStatus.Vacant;
                    prmRoom.Save();
                }
            }
        }

        public String RoomCode
        {
            get
            {
                if (Room != null)
                {
                    return Room.Code;
                }
                return string.Empty;
            }
        }

        [NonPersistent()]
        public Guid RoomOid
        {
            get { if (Room != null) { return Room.Oid; } else { return Guid.Empty; } }
            set { Room = Session.GetObjectByKey<Room>(value); }
        }

        public Double RoomRate
        {
            get { return _roomRate; }
            set { SetPropertyValue("RoomRate", ref _roomRate, value); }
        }

        public RoomType RoomType
        {
            get { return _roomType; }
            set { SetPropertyValue("RoomType", ref _roomType, value); }
        }

        [NonPersistent()]
        public Guid RoomTypeOid
        {
            get { if (RoomType != null) { return RoomType.Oid; } else { return Guid.Empty; } }
            set { RoomType = Session.GetObjectByKey<RoomType>(value); }
        }

        public GlobalVar.TransactionStatus Status
        {
            get { return _status; }
            set { SetPropertyValue("Status", ref _status, value); }
        }

        public String ToString
        {
            get
            {
                String strRoom = string.Empty;
                String strGuest = string.Empty;
                String strFrom = string.Empty;
                String strUntil = string.Empty;
                if (Room != null) { strRoom += "[" + Room.Code + "] "; }
                if (GuestName != null) { strGuest += GuestName + " "; }
                if (DateCheckIn != new DateTime()) { strFrom += "[ From : " + DateCheckIn.ToString("dd-MM-yyyy HH:mm") + " - Until : "; }
                if (DateCheckOut != new DateTime()) { strUntil += DateCheckOut.ToString("dd-MM-yyyy HH:mm") + "]"; }
                return String.Format("Stay {0}{1}{2}{3}", strRoom, strGuest, strFrom, strUntil);
            }
        }

        public Double Total
        {
            get { return _total; }
            set { SetPropertyValue("Total", ref _total, value); }
        }

        public Double TotalDepositPayment
        {
            get
            {
                Double Amount = 0;
                XPCollection<PaymentVoucher> coll = new XPCollection<PaymentVoucher>(Session,
                    GroupOperator.And(new BinaryOperator("PaymentForMaster.Oid", this.Oid),
                                        (new BinaryOperator("Status", GlobalVar.TransactionStatus.Processed))));
                foreach (PaymentVoucher obj in coll)
                {
                    Amount += obj.DepositAmount;
                }
                return Amount;
            }
        }

        public Double TotalPayments
        {
            get
            {
                return TotalRoomPayment;
            }
        }

        public bool PaymentIsSettled
        {
            get
            {
                if (TotalPayments == (Total + PenaltiesCost) && TotalDepositPayment == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Double TotalRoomPayment
        {
            get
            {
                Double Amount = 0;
                XPCollection<PaymentVoucher> coll = new XPCollection<PaymentVoucher>(PersistentCriteriaEvaluationBehavior.InTransaction,Session,
                    GroupOperator.And(new BinaryOperator("PaymentForMaster.Oid", this.Oid),
                                        (new BinaryOperator("Status", GlobalVar.TransactionStatus.Processed))));
                foreach (PaymentVoucher obj in coll)
                {
                    Amount += obj.RoomAmount;
                }
                return Amount;
            }
        }

        public static XPCollection<Stay> DataCollection(Session prmSession)
        {
            return new XPCollection<Stay>(prmSession);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        public bool IsStayReferencedByPaymentOrCheckout()
        {
            bool flag = false;
            PaymentVoucher oPaymentVoucher = Session.FindObject<PaymentVoucher>(PersistentCriteriaEvaluationBehavior.InTransaction,
                GroupOperator.And(new BinaryOperator("PaymentForMaster.Oid", this.Oid), new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel, BinaryOperatorType.NotEqual)));
            if (oPaymentVoucher != null)
            {
                flag = true;
            }
            CheckOut oCheckout = Session.FindObject<CheckOut>(PersistentCriteriaEvaluationBehavior.InTransaction,
                GroupOperator.And(new BinaryOperator("CheckOutFor.Oid", this.Oid), new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel, BinaryOperatorType.NotEqual)));
            if (oCheckout != null)
            {
                flag = true;
            }
            return flag;
        }

        public void Calculate()
        {
            GetUntilTime();
            if (Room == null)
            {
                RoomRate = 0;
                Total = 0;
            }
            else
            {
                RoomRate = PriceType.CurrentPrice(DateCheckIn);
                Double HourDurationInDays = 0;
                if (DurationInHours != 0)
                {
                    if (PriceType.Duration == 0)
                    {
                        HourDurationInDays = DurationInHours / DurationInHours;
                    }
                    else
                    {
                        HourDurationInDays = DurationInHours / PriceType.Duration;
                    }
                }
                Double dblExtraPrice = 0;
                if (Breakfast == true) { dblExtraPrice += MasterStay.BreakfastPrice; }
                if (ExtraBed == true) { dblExtraPrice += MasterStay.ExtraBedPrice; } 
                Total = (RoomRate + dblExtraPrice) * (DurationInDays + HourDurationInDays);
            }
        }

        public Stay CheckRoom()
        {
            List<DateRange> lsDate = GlobalVar.GenerateDateList(DateCheckIn, DateCheckOut);
            foreach (DateRange objDate in lsDate)
            {
                RoomScheduleDetail objRoomScheduleDetail = Session.FindObject<RoomScheduleDetail>(
                    GroupOperator.And(new BinaryOperator("RoomSchedule.Reference.Oid", this.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("TransDate", objDate.From.Date), new BinaryOperator("ScheduleType", GlobalVar.ScheduleType.CheckIn), new BinaryOperator("Room.Oid", Room.Oid)));
                if (objRoomScheduleDetail != null)
                {
                    if (objRoomScheduleDetail.IsAllDay != true)
                    {
                        DateRange oRoomDateRange = new DateRange() { From = objRoomScheduleDetail.From, Until = objRoomScheduleDetail.Until, IsAllDay = objRoomScheduleDetail.IsAllDay };
                        if (GlobalVar.DateIsIntersect(objDate, oRoomDateRange))
                        {
                            return (Stay)objRoomScheduleDetail.RoomSchedule.Reference;
                        }
                    }
                }
            }
            return null;
        }

        public void UpdateRoomInformation(GlobalVar.RoomStatus prmStatus)
        {
            if (Room != null)
            {
                Room.RoomStatus = prmStatus ;
            }
        }

        public CheckOut CreateCheckOut()
        {
            CheckOut oNewCheckOut = new CheckOut(Session);
            oNewCheckOut.CheckOutFor = this;
            oNewCheckOut.CheckOutDate = GlobalVar.ClearSeconds(DateTime.Now);
            oNewCheckOut.Note = string.Empty;
            oNewCheckOut.Penalties = 0;
            oNewCheckOut.Status = GlobalVar.TransactionStatus.Entry;
            return oNewCheckOut;
        }

        public void DeleteSchedule()
        {
            Session.ExecuteNonQuery(String.Format("DELETE FROM RoomScheduleDetail WHERE RoomSchedule IN(SELECT Oid FROM RoomSchedule WHERE Reference = '{0}')", this.Oid));
            Session.ExecuteNonQuery(String.Format("DELETE FROM RoomSchedule WHERE Reference = '{0}'", this.Oid));
        }

        public void GetUntilTime()
        {
            if (PriceType != null)
            {
                if (PriceType.IsShortTime)
                {
                    DateCheckOut = GlobalVar.GetCheckOutTime(DateCheckIn.AddHours(DurationInHours), PriceType.IsShortTime);
                    if (DurationInDays != 0) { DurationInDays = 0; }
                    return;
                }
                else
                {
                    DateCheckOut = GlobalVar.GetCheckOutTime(DateCheckIn.AddDays(DurationInDays), PriceType.IsShortTime);
                    if (DurationInHours != 0) { DurationInHours = 0; }
                }
            }
        }

        public XPCollection<PaymentVoucher> PaymentVouchers()
        {
            return new XPCollection<PaymentVoucher>(Session, new BinaryOperator("PaymentForMaster.Oid", this.Oid));
        }

        public void CancelRecord()
        {
            DeleteSchedule();
            UpdateRoomInformation(GlobalVar.RoomStatus.Vacant);
            CancelBy = Session.GetObjectByKey<AppUser>(GlobalVar.CurrentLoginUser.Oid);
            DateCancel = DateTime.Now;
            Status = GlobalVar.TransactionStatus.Cancel;
        }

        public void SubmitSchedule()
        {
            if (Status == GlobalVar.TransactionStatus.Entry)
            {
                Room.RoomStatus = GlobalVar.RoomStatus.Filled;
                RoomSchedule objRoomSchedule = new RoomSchedule(Session);
                objRoomSchedule.Reference = this;
                objRoomSchedule.Room = Room;
                objRoomSchedule.Subject = GuestName;
                objRoomSchedule.Description = "Stay " + RoomType.Name + " " + PriceType.Name + " From : " + DateCheckIn.ToString("dd-MM-yyyy HH:mm") + " - " + DateCheckOut.ToString("dd-MM-yyyy HH:mm") + "\r\n" +
                                                "Duration In Days: " + DurationInDays + "\r\n" +
                                                "Duration In Hours: " + DurationInHours;
                objRoomSchedule.ScheduleType = GlobalVar.ScheduleType.CheckIn;
                objRoomSchedule.From = GlobalVar.ClearSeconds(DateCheckIn);
                objRoomSchedule.Until = GlobalVar.ClearSeconds(DateCheckOut);
                objRoomSchedule.LabelId = PriceType.Color;
                objRoomSchedule.ResourceId = Room.Code;
                objRoomSchedule.Save();

                List<DateRange> lsDate = GlobalVar.GenerateDateList(DateCheckIn, DateCheckOut);

                foreach (DateRange objDate in lsDate)
                {
                    RoomScheduleDetail objRoomScheduleDetail = new RoomScheduleDetail(Session);
                    objRoomScheduleDetail.RoomSchedule = objRoomSchedule;
                    objRoomScheduleDetail.Room = Room;
                    objRoomScheduleDetail.ScheduleType = GlobalVar.ScheduleType.CheckIn;
                    objRoomScheduleDetail.TransDate = objDate.From.Date;
                    objRoomScheduleDetail.From = objDate.From;
                    objRoomScheduleDetail.Until = objDate.Until;
                    objRoomScheduleDetail.IsAllDay = objDate.IsAllDay;
                    objRoomScheduleDetail.Save();
                }
            }
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            if (!IsLoading)
            {
                DeleteSchedule();
            }
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            MasterStay.RecalculateDetail();
            if (Session.IsNewObject(this) && !IsDeleted)
            {
                WorkingShiftDetail.CreateWorkingLog(Session, "Save " + this.ToString, 0, 0, 0);
            }
        }
    }
}