using System;
using System.Collections.Generic;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class Reservation : TransactionBase
    {
        private DateTime _dateCheckIn;
        private DateTime _dateCheckOut;
        private Double _durationInDays;
        private Double _durationInHours;
        private Double _noOfGuest;
        private Double _noOfRoom;
        private Guest _guest;
        private String _guestName;
        private String _contactNumber;
        private String _referenceNo;
        private PaymentMethod _paymentMethod;
        private String _note;
        private PriceType _priceType;
        private RoomType _roomType;
        private GlobalVar.TransactionStatus _status;
        private bool _isReceiptPrinted;
        private double _depositAmount;

        public Reservation(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public XPCollection<PaymentMethod> AvailablePaymentMethod
        {
            get { return new XPCollection<PaymentMethod>(Session); }
        }

        public XPCollection<Guest> AvailableGuest
        {
            get { return new XPCollection<Guest>(Session); }
        }

        public void CancelRecord()
        {
            Status = GlobalVar.TransactionStatus.Cancel;
            DeleteSchedule();
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

        public XPCollection<RoomType> AvailableRoomType
        {
            get { return new XPCollection<RoomType>(Session); }
        }

        public PaymentMethod PaymentMethod
        {
            get { return _paymentMethod; }
            set { SetPropertyValue("PaymentMethod", ref _paymentMethod, value); }
        }

        [NonPersistent()]
        public Guid PaymentMethodOid
        {
            get { if (PaymentMethod != null) { return PaymentMethod.Oid; } else { return Guid.Empty; } }
            set { PaymentMethod = Session.GetObjectByKey<PaymentMethod>(value); }
        }

        public String ReferenceNo
        {
            get { return _referenceNo; }
            set { SetPropertyValue("ReferenceNo", ref _referenceNo, value); }
        }

        public DateTime DateCheckIn
        {
            get { return _dateCheckIn; }
            set
            {
                SetPropertyValue("DateCheckIn", ref _dateCheckIn, value);
            }
        }

        public DateTime DateCheckOut
        {
            get { return _dateCheckOut; }
            set
            {
                SetPropertyValue("DateCheckOut", ref _dateCheckOut, value);
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

        public Double NoOfGuest
        {
            get { return _noOfGuest; }
            set { SetPropertyValue("NoOfGuest", ref _noOfGuest, value); }
        }

        public Double NoOfRoom
        {
            get { return _noOfRoom; }
            set { SetPropertyValue("NoOfRoom", ref _noOfRoom, value); }
        }

        public Double DepositAmount
        {
            get { return _depositAmount; }
            set { SetPropertyValue("DepositAmount", ref _depositAmount, value); }
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

        public String GuestName
        {
            get { return _guestName; }
            set { SetPropertyValue("GuestName", ref _guestName, value); }
        }

        public String ContactNumber
        {
            get { return _contactNumber; }
            set { SetPropertyValue("ContactNumber", ref _contactNumber, value); }
        }

        public bool IsReceiptPrinted
        {
            get { return _isReceiptPrinted; }
            set { SetPropertyValue("IsReceiptPrinted", ref _isReceiptPrinted, value); }
        }

        [NonPersistent()]
        public Guid GuestOid
        {
            get { if (Guest != null) { return Guest.Oid; } else { return Guid.Empty; } }
            set { Guest = Session.GetObjectByKey<Guest>(value); }
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

        public String Note
        {
            get { return _note; }
            set { SetPropertyValue("Note", ref _note, value); }
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

        public static XPCollection<Reservation> DataCollection(Session prmSession)
        {
            return new XPCollection<Reservation>(prmSession);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        public void DeleteSchedule()
        {
            Session.ExecuteNonQuery("DELETE FROM RoomScheduleDetail WHERE RoomSchedule IN(SELECT Oid FROM RoomSchedule WHERE Reference = '" + this.Oid.ToString() + "')");
            Session.ExecuteNonQuery("DELETE FROM RoomSchedule WHERE Reference = '" + this.Oid.ToString() + "'");
        }

        public void SubmitSchedule()
        {
            if (Status == GlobalVar.TransactionStatus.Entry)
            {
                RoomSchedule objRoomSchedule = new RoomSchedule(Session);
                objRoomSchedule.Reference = this;
                objRoomSchedule.Room = null;
                objRoomSchedule.Subject = GuestName;
                objRoomSchedule.Description =   "Reservation " + RoomType.Name + " " + PriceType.Name + " From : " + DateCheckIn.ToString("dd-MM-yyyy HH:mm") + " - " + DateCheckOut.ToString("dd-MM-yyyy HH:mm") + "\r\n" +
                                                "Duration In Days: " + DurationInDays + "\r\n" +
                                                "Duration In Hours: " + DurationInHours;
                objRoomSchedule.ScheduleType = GlobalVar.ScheduleType.Reservation;
                objRoomSchedule.From = GlobalVar.ClearSeconds(DateCheckIn);
                objRoomSchedule.Until = GlobalVar.ClearSeconds(DateCheckOut);
                objRoomSchedule.LabelId = GlobalVar.LabelColor.LightYellow;
                objRoomSchedule.ResourceId = "Reservation";
                objRoomSchedule.Save();

                List<DateRange> lsDate = GlobalVar.GenerateDateList(DateCheckIn, DateCheckOut);

                foreach (DateRange objDate in lsDate)
                {
                    RoomScheduleDetail objRoomScheduleDetail = new RoomScheduleDetail(Session);
                    objRoomScheduleDetail.RoomSchedule = objRoomSchedule;
                    objRoomScheduleDetail.Room = null;
                    objRoomScheduleDetail.ScheduleType = GlobalVar.ScheduleType.Reservation;
                    objRoomScheduleDetail.TransDate = objDate.From.Date;
                    objRoomScheduleDetail.From = objDate.From;
                    objRoomScheduleDetail.Until = objDate.Until;
                    objRoomScheduleDetail.IsAllDay = objDate.IsAllDay;
                    objRoomScheduleDetail.Save();
                }
            }
        }

        public MasterStay CheckInReservation()
        {
            MasterStay oNewStay = new MasterStay(Session);
            oNewStay.Guest = Guest;
            oNewStay.Note = Note;
            oNewStay.Reservation = this;
            oNewStay.Status = GlobalVar.TransactionStatus.Entry;
            return oNewStay;
        }

        public bool IsReservationReferencedInStay()
        {
            bool flag = false;
            MasterStay oStay = Session.FindObject<MasterStay>(PersistentCriteriaEvaluationBehavior.InTransaction,
                GroupOperator.And(new BinaryOperator("Reservation.Oid", this.Oid), new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel, BinaryOperatorType.NotEqual)));
            if (oStay != null)
            {
                flag = true;
            }
            return flag;
        }

        public override string ToString()
        {
            string strGuestName = "";
            string strDateCheckIn = "";
            string strDateCheckOut = "";

            if (GuestName != null) { strGuestName = GuestName; }
            if (DateCheckIn != null && DateCheckIn != new DateTime()) { strDateCheckIn = DateCheckIn.ToString("dd-MM-yyyy HH:mm"); }
            if (DateCheckOut != null && DateCheckOut != new DateTime()) { strDateCheckOut = DateCheckOut.ToString("dd-MM-yyyy HH:mm"); }

            return "Reservation " + strGuestName + " Date : " + strDateCheckIn + " - " + strDateCheckOut + " Deposit : " + DepositAmount.ToString();
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (Session.IsNewObject(this) && !IsDeleted)
            {
                WorkingShiftDetail.CreateWorkingLog(Session, "Save " + this.ToString(), 0, 0, DepositAmount);
            }
        }
    }
}