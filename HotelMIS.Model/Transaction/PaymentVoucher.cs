using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class PaymentVoucher : MyObjectBase
    {
        private String _code;
        private Double _depositAmount;
        private String _note;
        private DateTime _paidDate;
        private MasterStay _paymentForMaster;
        private PaymentMethod _paymentMethod;
        private String _referenceNo;
        private AppUser _responsible;
        private Double _roomAmount;
        private String _voidReason;
        private GlobalVar.TransactionStatus _status;

        public PaymentVoucher(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public XPCollection<Stay> AvailablepaymentForMaster
        {
            get 
            {
                if (PaymentForMaster == null)
                {
                    return new XPCollection<Stay>(Session,
                    GroupOperator.And(new BinaryOperator("PaymentIsSettled", false),
                                        new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel, BinaryOperatorType.NotEqual)));
                }
                return new XPCollection<Stay>(Session,
                    GroupOperator.Or(GroupOperator.And(new BinaryOperator("PaymentIsSettled", false),
                                        new BinaryOperator("Status", GlobalVar.TransactionStatus.Cancel, BinaryOperatorType.NotEqual)),
                                        new BinaryOperator("Oid", PaymentForMaster.Oid))); 
            }
        }

        public String Code
        {
            get { return _code; }
            set { SetPropertyValue("Code", ref _code, value); }
        }

        public XPCollection<PaymentMethod> AvailablePaymentMethod
        {
            get { return new XPCollection<PaymentMethod>(Session); }
        }

        public Double DepositAmount
        {
            get { return _depositAmount; }
            set { SetPropertyValue("DepositAmount", ref _depositAmount, value); }
        }

        public String Note
        {
            get { return _note; }
            set { SetPropertyValue("Note", ref _note, value); }
        }

        public DateTime PaidDate
        {
            get { return _paidDate; }
            set { SetPropertyValue("PaidDate", ref _paidDate, value); }
        }

        public MasterStay PaymentForMaster
        {
            get { return _paymentForMaster; }
            set { SetPropertyValue("PaymentForMaster", ref _paymentForMaster, value); }
        }

        public double OutstandingAmount
        {
            get
            {
                if (PaymentForMaster != null)
                {
                    return (PaymentForMaster.Total + PaymentForMaster.PenaltiesCost) - (PaymentForMaster.TotalPaid + PaymentForMaster.TotalDeposit);
                }
                return 0;
            }
        }

        [NonPersistent()]
        public Guid paymentForMasterOid
        {
            get { if (PaymentForMaster != null) { return PaymentForMaster.Oid; } else { return Guid.Empty; } }
            set { PaymentForMaster = Session.GetObjectByKey<MasterStay>(value); }
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

        public AppUser Responsible
        {
            get { return _responsible; }
            set { SetPropertyValue("Responsible", ref _responsible, value); }
        }

        public Double RoomAmount
        {
            get { return _roomAmount; }
            set { SetPropertyValue("RoomAmount", ref _roomAmount, value); }
        }

        public String VoidReason
        {
            get { return _voidReason; }
            set { SetPropertyValue("VoidReason", ref _voidReason, value); }
        }

        public GlobalVar.TransactionStatus Status
        {
            get { return _status; }
            set { SetPropertyValue("Status", ref _status, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place here your initialization code.
            if (Session.IsNewObject(this))
            {
                Code = "[ Auto Generated ]";
            }
        }

        protected override void OnDeleted()
        {
            base.OnDeleted();
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (Session.IsNewObject(this))
            {
                Code = AutoNo.GetAutoNumber(Session, "PaymentVoucher", DateTime.Now);

            }
            if (!IsLoading && !IsDeleted)
            {
                if (Session.IsNewObject(this))
                {
                    Responsible = Session.GetObjectByKey<AppUser>(GlobalVar.CurrentLoginUser.Oid);
                    PaidDate = DateTime.Now;
                }
            }
        }

        public bool IsAlreadyPaidAll()
        {
            if (PaymentForMaster.PaymentStatus == GlobalVar.PaymentStatus.Paid && (PaymentForMaster.Total + PaymentForMaster.PenaltiesCost) == PaymentForMaster.TotalPaid)
            {
                return true;
            }
            return false;
        }

        public void ProcessPayment(bool isCancel)
        {
            if (!isCancel)
            {
                if (PaymentForMaster.TotalPaid + RoomAmount < PaymentForMaster.Total)
                {
                    PaymentForMaster.PaymentStatus = GlobalVar.PaymentStatus.UnderPaid;
                }
                if (PaymentForMaster.TotalPaid + RoomAmount == PaymentForMaster.Total)
                {
                    if (PaymentForMaster.TotalDeposit + DepositAmount > 0)
                    {
                        PaymentForMaster.PaymentStatus = GlobalVar.PaymentStatus.OverPaid;
                    }
                    else
                    {
                        PaymentForMaster.PaymentStatus = GlobalVar.PaymentStatus.Paid;
                    }
                }
                if (PaymentForMaster.TotalPaid + RoomAmount > PaymentForMaster.Total)
                {
                    PaymentForMaster.PaymentStatus = GlobalVar.PaymentStatus.OverPaid;
                }
                Status = GlobalVar.TransactionStatus.Processed;
            }
            else
            {
                if (PaymentForMaster.TotalPaid - RoomAmount < PaymentForMaster.Total)
                {
                    PaymentForMaster.PaymentStatus = GlobalVar.PaymentStatus.UnderPaid;
                }
                if (PaymentForMaster.TotalPaid - RoomAmount == PaymentForMaster.Total)
                {
                    if (PaymentForMaster.TotalDeposit - DepositAmount > 0)
                    {
                        PaymentForMaster.PaymentStatus = GlobalVar.PaymentStatus.OverPaid;
                    }
                    else
                    {
                        PaymentForMaster.PaymentStatus = GlobalVar.PaymentStatus.Paid;
                    }
                }
                if (PaymentForMaster.TotalPaid - RoomAmount > PaymentForMaster.Total)
                {
                    PaymentForMaster.PaymentStatus = GlobalVar.PaymentStatus.OverPaid;
                }
                Status = GlobalVar.TransactionStatus.Cancel;
            }
        }

        public static XPCollection<PaymentVoucher> DataCollection(Session prmSession)
        {
            return new XPCollection<PaymentVoucher>(prmSession);
        }

        public override string ToString()
        {
            String strpaymentForMaster = "";
            String strTotalPayment = "";
            String strNote = "";
            String strPaymentMethod = "";

            if (PaymentForMaster != null) { strpaymentForMaster = String.Format("Room {0} {1}", PaymentForMaster.RoomInside, PaymentForMaster.Guest.Name); }
            strTotalPayment = String.Format("Deposit : {0:#,#.##} Room Payment : {1:#,#.##}", DepositAmount, RoomAmount);
            if (Note != null) { strNote = Note; }
            if (PaymentMethod != null) { strPaymentMethod = PaymentMethod.Name; }

            return String.Format("Payment {0} {1} {2} {3}", strpaymentForMaster, strPaymentMethod, strTotalPayment, strNote);
        }
    }
}