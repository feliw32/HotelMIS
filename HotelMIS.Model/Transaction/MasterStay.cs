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
    public class MasterStay : TransactionBase
    {
        private Double _discountByAmount;
        private Guest _guest;
        private int _discountByPercent;
        private int _noOfGuest;
        private int _noOfRoom;
        private String _note;
        private GlobalVar.PaymentStatus _paymentStatus;
        private Reservation _reservation;
        private Double _totalExtraCharge;
        private Double _breakfastPrice;
        private Double _extraBedPrice;
        private GlobalVar.TransactionStatus _status;
        private Double _subTotal;
        private Double _total;
        private bool _isReceiptPrinted;

        public MasterStay(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
            if (Session.IsNewObject(this) && !IsDeleted)
            {
                ExtraBedPrice = GlobalVar.GlobalSetting.ExtraBedPrice;
                BreakfastPrice = GlobalVar.GlobalSetting.BreakfastPrice;
            }
        }

        public XPCollection<Guest> AvailableGuest
        {
            get { return new XPCollection<Guest>(Session); }
        }

        [Association("MasterStay-Stay"), Aggregated()]
        public XPCollection<Stay> Stays
        {
            get
            {
                return GetCollection<Stay>("Stays");
            }
        }

        public XPCollection<Stay> Stays2
        {
            get
            {
                XPCollection<Stay> oColl = new XPCollection<Stay>(Session, new BinaryOperator("MasterStay.Oid", Oid.ToString()));
                return oColl;
            }
        }

        public Boolean IsReceiptPrinted
        {
            get { return _isReceiptPrinted; }
            set { SetPropertyValue("IsReceiptPrinted", ref _isReceiptPrinted, value); }
        }

        public Double DiscountByAmount
        {
            get { return _discountByAmount; }
            set { SetPropertyValue("DiscountByAmount", ref _discountByAmount, value); }
        }

        public Double ExtraBedPrice
        {
            get { return _extraBedPrice; }
            set { SetPropertyValue("ExtraBedPrice", ref _extraBedPrice, value); }
        }

        public Double BreakfastPrice
        {
            get { return _breakfastPrice; }
            set { SetPropertyValue("BreakfastPrice", ref _breakfastPrice, value); }
        }

        public int DiscountByPercent
        {
            get { return _discountByPercent; }
            set { SetPropertyValue("DiscountByPercent", ref _discountByPercent, value); }
        }

        public Guest Guest
        {
            get { return _guest; }
            set
            {
                SetPropertyValue("Guest", ref _guest, value);
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

        public int NoOfRoom
        {
            get { return _noOfRoom; }
            set { SetPropertyValue("NoOfRoom", ref _noOfRoom, value); }
        }

        public String Note
        {
            get { return _note; }
            set { SetPropertyValue("Note", ref _note, value); }
        }

        public GlobalVar.PaymentStatus PaymentStatus
        {
            get { return _paymentStatus; }
            set { SetPropertyValue("PaymentStatus", ref _paymentStatus, value); }
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

        public Reservation Reservation
        {
            get { return _reservation; }
            set { SetPropertyValue("Reservation", ref _reservation, value); }
        }

        public Double TotalExtraCharge
        {
            get { return _totalExtraCharge; }
            set { SetPropertyValue("TotalExtraCharge", ref _totalExtraCharge, value); }
        }

        public GlobalVar.TransactionStatus Status
        {
            get { return _status; }
            set { SetPropertyValue("Status", ref _status, value); }
        }

        public Double SubTotal
        {
            get { return _subTotal; }
            set { SetPropertyValue("SubTotal", ref _subTotal, value); }
        }

        public String ToString
        {
            get
            {
                String strRoomTotal = string.Empty;
                String strGuest = string.Empty;
                strRoomTotal = Stays.Count.ToString();
                if (Guest != null) { strGuest += Guest.Name + " "; }
                return String.Format("Guest {0} make stay for {1} room(s).", strGuest, strRoomTotal);
            }
        }

        public Double Total
        {
            get { return _total; }
            set { SetPropertyValue("Total", ref _total, value); }
        }

        public void CheckRoomCheckout()
        {
            bool allCheckout = true;
            foreach (Stay objStay in Stays)
            {
                if (objStay.Status == GlobalVar.TransactionStatus.Entry)
                {
                    allCheckout = false;
                }
            }
            if (allCheckout)
            {
                Status = GlobalVar.TransactionStatus.Processed;
            }
        }
        public Double TotalDeposit
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

        public Double TotalPaid
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
                if (TotalPaid == (Total + TotalExtraCharge) && TotalDeposit == 0)
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

        public static XPCollection<MasterStay> DataCollection(Session prmSession)
        {
            return new XPCollection<MasterStay>(prmSession);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
        }

        public bool IsMasterStayReferencedByPayment()
        {
            bool flag = false;
            PaymentVoucher oPaymentVoucher = Session.FindObject<PaymentVoucher>(PersistentCriteriaEvaluationBehavior.InTransaction,
                GroupOperator.And(new BinaryOperator("PaymentForMaster.Oid", this.Oid), new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel, BinaryOperatorType.NotEqual)));
            if (oPaymentVoucher != null)
            {
                flag = true;
            }
            return flag;
        }

        public void Calculate()
        {
            //GetUntilTime();
            //if (Room == null)
            //{
            //    RoomRate = 0;
            //    SubTotal = 0;
            //    Total = 0;
            //    if (Breakfast == false) { BreakfastPrice = 0; }
            //    if (ExtraBed == false) { ExtraBedPrice = 0; }
            //}
            //else
            //{
            //    if (Breakfast == true) { BreakfastPrice = GlobalVar.GlobalSetting.BreakfastPrice; } else { BreakfastPrice = 0; }
            //    if (ExtraBed == true) { ExtraBedPrice = GlobalVar.GlobalSetting.ExtraBedPrice; } else { ExtraBedPrice = 0; }
            //    RoomRate = PriceType.CurrentPrice;
            //    Double HourDurationInDays = 0;
            //    if (DurationInHours != 0)
            //    {
            //        if (PriceType.Duration == 0)
            //        {
            //            HourDurationInDays = DurationInHours / DurationInHours;
            //        }
            //        else
            //        {
            //            HourDurationInDays = DurationInHours / PriceType.Duration;
            //        }
            //    }
            //    SubTotal = (RoomRate + BreakfastPrice + ExtraBedPrice) * (DurationInDays + HourDurationInDays);
            //    Total = SubTotal - (((Double)DiscountByPercent / 100) * SubTotal) - DiscountByAmount;
            //}
        }

        //public Stay CheckRoom()
        //{
        //    List<DateRange> lsDate = GlobalVar.GenerateDateList(DateCheckIn, DateCheckOut);
        //    foreach (DateRange objDate in lsDate)
        //    {
        //        RoomScheduleDetail objRoomScheduleDetail = Session.FindObject<RoomScheduleDetail>(
        //            GroupOperator.And(new BinaryOperator("RoomSchedule.Reference.Oid", this.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("TransDate", objDate.From.Date), new BinaryOperator("ScheduleType", GlobalVar.ScheduleType.CheckIn), new BinaryOperator("Room.Oid", Room.Oid)));
        //        if (objRoomScheduleDetail != null)
        //        {
        //            if (objRoomScheduleDetail.IsAllDay != true)
        //            {
        //                DateRange oRoomDateRange = new DateRange() { From = objRoomScheduleDetail.From, Until = objRoomScheduleDetail.Until, IsAllDay = objRoomScheduleDetail.IsAllDay };
        //                if (GlobalVar.DateIsIntersect(objDate, oRoomDateRange))
        //                {
        //                    return (Stay)objRoomScheduleDetail.RoomSchedule.Reference;
        //                }
        //            }
        //        }
        //    }
        //    return null;
        //}

        //public void UpdateRoomInformation(GlobalVar.RoomStatus prmStatus)
        //{
        //    if (Room != null)
        //    {
        //        Room.RoomStatus = prmStatus ;
        //    }
        //}

        //public CheckOut CreateCheckOut()
        //{
        //    CheckOut oNewCheckOut = new CheckOut(Session);
        //    oNewCheckOut.CheckOutFor = this;
        //    oNewCheckOut.CheckOutDate = GlobalVar.ClearSeconds(DateTime.Now);
        //    oNewCheckOut.Note = string.Empty;
        //    oNewCheckOut.Penalties = 0;
        //    oNewCheckOut.Status = GlobalVar.TransactionStatus.Entry;
        //    return oNewCheckOut;
        //}

        //public void DeleteSchedule()
        //{
        //    Session.ExecuteNonQuery("DELETE FROM RoomScheduleDetail WHERE RoomSchedule IN(SELECT Oid FROM RoomSchedule WHERE Reference = '" + this.Oid.ToString() + "')");
        //    Session.ExecuteNonQuery("DELETE FROM RoomSchedule WHERE Reference = '" + this.Oid.ToString() + "'");
        //}

        public XPCollection<PaymentVoucher> PaymentVouchers()
        {
            return new XPCollection<PaymentVoucher>(Session, new BinaryOperator("PaymentForMaster.Oid", this.Oid));
        }

        public void CancelRecord()
        {
            Status = GlobalVar.TransactionStatus.Cancel;
        }

        //public void SubmitSchedule()
        //{
        //    if (Status == GlobalVar.TransactionStatus.Entry)
        //    {
        //        Room.RoomStatus = GlobalVar.RoomStatus.Filled;
        //        RoomSchedule objRoomSchedule = new RoomSchedule(Session);
        //        objRoomSchedule.Reference = this;
        //        objRoomSchedule.Room = Room;
        //        objRoomSchedule.Subject = GuestName;
        //        objRoomSchedule.Description = "Stay " + RoomType.Name + " " + PriceType.Name + " From : " + DateCheckIn.ToString("dd-MM-yyyy HH:mm") + " - " + DateCheckOut.ToString("dd-MM-yyyy HH:mm") + "\r\n" +
        //                                        "Duration In Days: " + DurationInDays + "\r\n" +
        //                                        "Duration In Hours: " + DurationInHours;
        //        objRoomSchedule.ScheduleType = GlobalVar.ScheduleType.CheckIn;
        //        objRoomSchedule.From = GlobalVar.ClearSeconds(DateCheckIn);
        //        objRoomSchedule.Until = GlobalVar.ClearSeconds(DateCheckOut);
        //        objRoomSchedule.LabelId = PriceType.Color;
        //        objRoomSchedule.ResourceId = Room.Code;
        //        objRoomSchedule.Save();

        //        List<DateRange> lsDate = GlobalVar.GenerateDateList(DateCheckIn, DateCheckOut);

        //        foreach (DateRange objDate in lsDate)
        //        {
        //            RoomScheduleDetail objRoomScheduleDetail = new RoomScheduleDetail(Session);
        //            objRoomScheduleDetail.RoomSchedule = objRoomSchedule;
        //            objRoomScheduleDetail.Room = Room;
        //            objRoomScheduleDetail.ScheduleType = GlobalVar.ScheduleType.CheckIn;
        //            objRoomScheduleDetail.TransDate = objDate.From.Date;
        //            objRoomScheduleDetail.From = objDate.From;
        //            objRoomScheduleDetail.Until = objDate.Until;
        //            objRoomScheduleDetail.IsAllDay = objDate.IsAllDay;
        //            objRoomScheduleDetail.Save();
        //        }
        //    }
        //}

        //protected override void OnDeleting()
        //{
        //    base.OnDeleting();
        //    if (!IsLoading)
        //    {
        //        DeleteSchedule();
        //    }
        //}

        protected override void OnSaving()
        {
            base.OnSaving();
            RecalculateDetail();
            //UpdatePaymentStatus();
            if (Session.IsNewObject(this) && !IsDeleted)
            {
                WorkingShiftDetail.CreateWorkingLog(Session, "Save " + this.ToString, 0, 0, 0);
            }
        }

        //public void UpdatePaymentStatus()
        //{
        //    if (TotalPayments < Total + PenaltiesCost)
        //    {
        //        PaymentStatus = GlobalVar.PaymentStatus.UnderPaid;
        //    }
        //    if (TotalPayments == Total + PenaltiesCost)
        //    {
        //        if (TotalDepositPayment > 0)
        //        {
        //            PaymentStatus = GlobalVar.PaymentStatus.OverPaid;
        //        }
        //        else
        //        {
        //            PaymentStatus = GlobalVar.PaymentStatus.Paid;
        //        }
        //    }
        //    if (TotalPayments > Total + PenaltiesCost)
        //    {
        //        PaymentStatus = GlobalVar.PaymentStatus.OverPaid;
        //    }
        //}

        public void RecalculateDetail()
        {
            TotalExtraCharge = 0;
            BreakfastPrice = GlobalVar.GlobalSetting.BreakfastPrice;
            ExtraBedPrice = GlobalVar.GlobalSetting.ExtraBedPrice;
            SubTotal = 0;
            Total = 0;
            NoOfGuest = 0;
            NoOfRoom = 0;
            foreach (Stay objStay in Stays2)
            {
                if (objStay.Status != GlobalVar.TransactionStatus.Cancel)
                {
                    if (objStay.Breakfast) { TotalExtraCharge += objStay.DurationInDays * BreakfastPrice; }
                    if (objStay.ExtraBed) { TotalExtraCharge += objStay.DurationInDays * ExtraBedPrice; }
                    SubTotal += objStay.Total;
                    NoOfGuest += objStay.NoOfGuest;
                    NoOfRoom += 1;
                }
            }
            Double dblDiscountAmount = DiscountByAmount + ((DiscountByPercent * (SubTotal - TotalExtraCharge))/100);
            Total = SubTotal - dblDiscountAmount;
        }

        public String CheckIn
        {
            get
            {
                if (Stays.Count > 0)
                {
                    return Stays[0].DateCheckIn.ToString("MM/dd HH:mm");
                }
                return "";
            }
        }

        public String CheckOut
        {
            get
            {
                if (Stays.Count == 1)
                {
                    if (Stays[0].Status == GlobalVar.TransactionStatus.Entry)
                    {
                        if (Stays[0].PriceType.IsShortTime)
                        {
                            return Stays[0].DateCheckOut.ToString("MM/dd HH:mm") + " [" + Stays[0].Room.Code + "]";
                        }
                    }
                    else
                    {
                        return "";
                    }
                }
                if (Stays.Count > 0)
                {
                    return getCheckOutString();
                }
                return "";
            }
        }

        public String getCheckOutString()
        {
            Stays.Sorting = new SortingCollection(new SortProperty("DateCheckOut", SortingDirection.Ascending));
            string strCheckout = "";
            DateTime lastDate = new DateTime();
            string strDate = "";
            string strRoom = "";
            foreach (Stay obj in Stays)
            {
                if (obj.Status == GlobalVar.TransactionStatus.Entry)
                {
                    if (lastDate == new DateTime())
                    {
                        lastDate = obj.DateCheckOut;
                        strDate += " | " + lastDate.ToString("MM/dd") + " ";
                        strRoom += obj.Room.Code;
                    }
                    else
                    {
                        if (lastDate == obj.DateCheckOut)
                        {
                            strRoom += "," + obj.Room.Code;
                        }
                        else
                        {
                            lastDate = obj.DateCheckOut;
                            strCheckout += strDate + "[" + strRoom + "]" ;
                            strDate = " | " + lastDate.ToString("dd/MM") + " ";
                            strRoom = obj.Room.Code;
                        }
                    }
                }
                
            }
            strCheckout += strDate + "[" + strRoom + "]";
            if (strCheckout != "[]" && strCheckout.Substring(0, 3) == " | ")
            {
                strCheckout = strCheckout.Substring(2, strCheckout.Length - 2);
            }
            return strCheckout;
        }

        public String RoomInside
        {
            get
            {
                if (Stays.Count == 1)
                {
                    return Stays[0].Room.Code;
                }
                if (Stays.Count > 0)
                {
                    return getRoomString();
                }
                return "";
            }
        }

        public String getRoomString()
        {
            Stays.Sorting = new SortingCollection(new SortProperty("DateCheckOut", SortingDirection.Ascending));
            string strRoom = "";
            
            foreach (Stay obj in Stays)
            {
                if (obj.Status == GlobalVar.TransactionStatus.Entry)
                {
                    strRoom += "," + obj.RoomCode;
                }
            }
            if (strRoom.Substring(0, 1) == ",")
            {
                strRoom = strRoom.Substring(1, strRoom.Length - 1);
            }
            strRoom = "[" + strRoom + "]";
            return strRoom;
        }
    }
}