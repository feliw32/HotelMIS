using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using System.Windows.Forms;

namespace HotelMIS.Model
{
    [DefaultClassOptions]
    public class WorkingShift : MyObjectBase
    {
        private AppUser _appUser;
        private DateTime _shiftStart;
        private DateTime _shiftEnd;
        private Boolean _isClosed;
        private string _filename;

        public WorkingShift(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }

        public AppUser AppUser
        {
            get { return _appUser; }
            set { SetPropertyValue("AppUser", ref _appUser, value); }
        }

        public DateTime ShiftStart
        {
            get { return _shiftStart; }
            set { SetPropertyValue("ShiftStart", ref _shiftStart, value); }
        }

        public DateTime ShiftEnd
        {
            get { return _shiftEnd; }
            set { SetPropertyValue("ShiftEnd", ref _shiftEnd, value); }
        }

        public Boolean IsClosed
        {
            get { return _isClosed; }
            set { SetPropertyValue("IsClosed", ref _isClosed, value); }
        }

        public String FileName
        {
            get { return _filename; }
            set { SetPropertyValue("FileName", ref _filename, value); }
        }

        [Association("WorkingShift-WorkingShiftDetail"), Aggregated()]
        public XPCollection<WorkingShiftDetail> WorkingShiftDetails
        {
            get
            {
                return GetCollection<WorkingShiftDetail>("WorkingShiftDetails");
            }
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

        public static void CheckWorkingShift(Session prmSession)
        {
            if (GlobalVar.CurrentLoginUser.UserRole.Code != "ADM")
            {
                WorkingShift oWorkingShift = prmSession.FindObject<WorkingShift>(
                                        GroupOperator.And(new BinaryOperator("IsClosed", false),
                                                            new BinaryOperator("AppUser.Oid", GlobalVar.CurrentLoginUser.Oid)));

                if (oWorkingShift == null)
                {
                    oWorkingShift = new WorkingShift(prmSession);
                    oWorkingShift.AppUser = prmSession.GetObjectByKey<AppUser>(GlobalVar.CurrentLoginUser.Oid);
                    oWorkingShift.ShiftStart = DateTime.Now;
                    oWorkingShift.IsClosed = false;
                    oWorkingShift.Save();
                    MessageBox.Show("Your working session is started from " + oWorkingShift.ShiftStart.ToString("dd MMMM yyyy HH:mm"));
                    WorkingShiftDetail.CreateWorkingLog(prmSession, "Beginning Balance", GlobalVar.CallNumberBox(),0,0);
                }
                else
                {
                    MessageBox.Show("Your working session is started from " + oWorkingShift.ShiftStart.ToString("dd MMMM yyyy HH:mm"));
                }
            }
        }

        public static WorkingShift EndWorkingShift(Session prmSession)
        {
            if (GlobalVar.CurrentLoginUser.UserRole.Code != "ADM")
            {
                WorkingShift oWorkingShift = prmSession.FindObject<WorkingShift>(
                                        GroupOperator.And(new BinaryOperator("IsClosed", false),
                                                            new BinaryOperator("AppUser.Oid", GlobalVar.CurrentLoginUser.Oid)));

                oWorkingShift.ShiftEnd = DateTime.Now;
                oWorkingShift.IsClosed = true;
                oWorkingShift.Save();

                return oWorkingShift;
            }
            return null;
        }
    }
}