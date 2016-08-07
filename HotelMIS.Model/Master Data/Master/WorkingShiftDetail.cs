using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class WorkingShiftDetail : MyObjectBase
    {
        private WorkingShift _workingShift;
        private DateTime _logTime;
        private String _description;
        private Double _amount;
        private Double _noncashAmount;
        private Double _depositAmount;
        
        public WorkingShiftDetail(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        [Association("WorkingShift-WorkingShiftDetail")]
        public WorkingShift WorkingShift
        {
            get { return _workingShift; }
            set { SetPropertyValue("WorkingShift", ref _workingShift, value); }
        }

        public DateTime LogTime
        {
            get { return _logTime; }
            set { SetPropertyValue("LogTime", ref _logTime, value); }
        }

        [Size(5000)]
        public String Description
        {
            get { return _description; }
            set { SetPropertyValue("Description", ref _description, value); }
        }

        public Double Amount
        {
            get { return _amount; }
            set { SetPropertyValue("Amount", ref _amount, value); }
        }

        public Double NonCashAmount
        {
            get { return _noncashAmount; }
            set { SetPropertyValue("NonCashAmount", ref _noncashAmount, value); }
        }

        public Double DepositAmount
        {
            get { return _depositAmount; }
            set { SetPropertyValue("DepositAmount", ref _depositAmount, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        protected override void OnSaving()
        {
            base.OnSaving();
        }

        public static void CreateWorkingLog(Session prmSession, String prmDescription, Double prmAmount, Double prmNonCashAmount, Double prmDepositAmount)
        {
            if (GlobalVar.GetCurrentWorkingShift(prmSession) != null)
            {
                WorkingShiftDetail oLogger = new WorkingShiftDetail(prmSession);
                oLogger.Description = prmDescription;
                oLogger.Amount = prmAmount;
                oLogger.DepositAmount = prmDepositAmount;
                oLogger.NonCashAmount = prmNonCashAmount;
                oLogger.LogTime = DateTime.Now;
                oLogger.WorkingShift = GlobalVar.GetCurrentWorkingShift(prmSession);
                oLogger.Save();
            }
        }
    }
}