using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using HotelMIS.Model;
using System.Drawing.Drawing2D;
using System.Drawing;
using DevExpress.Data.Filtering;
using DevExpress.Services;
using DevExpress.XtraScheduler.Services;

namespace HotelMIS.View
{
    public partial class frmControlBoard : Form
    {
        private UnitOfWork oSession;

        public frmControlBoard(UnitOfWork prmSession)
        {
            InitializeComponent();
            tpController.BeforeShow += new ToolTipControllerBeforeShowEventHandler(tpController_BeforeShow);

            oSession = prmSession;
            InitScheduler();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            oSession.Dispose();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitScheduler();
        }

        private void InitScheduler()
        {
            schedulerControlBoard.GoToDate(DateTime.Now.AddDays(-3));
            MappingResources();
            MappingAppointments();
            schedulerControlBoard.Storage = dsSchedule;
            schedulerControlBoard.ToolTipController = tpController;
            SetSchedulerBehaviour();
        }

        private void MappingAppointments()
        {
            XPCollection<RoomSchedule> xpSchedule;

            if (chkShowPast.Checked)
            {
                DateTime historyDate;
                if (GlobalVar.GlobalSetting.ControlBoardDays == 0 || GlobalVar.GlobalSetting.ControlBoardDays == null)
                {
                    historyDate = DateTime.Now.Date.AddDays(-30);
                }
                else
                {
                    historyDate = DateTime.Now.Date.AddDays(GlobalVar.GlobalSetting.ControlBoardDays * -1);
                }

                CriteriaOperator oCriteria = GroupOperator.Or(GroupOperator.And(new BinaryOperator("ScheduleType", GlobalVar.ScheduleType.History, BinaryOperatorType.Equal),
                                                                                new BinaryOperator("From", historyDate, BinaryOperatorType.GreaterOrEqual)),
                                                            new BinaryOperator("ScheduleType", GlobalVar.ScheduleType.History, BinaryOperatorType.NotEqual));
                xpSchedule = new XPCollection<RoomSchedule>(oSession, oCriteria);
            }
            else
            {
                CriteriaOperator oCriteria = GroupOperator.And(new BinaryOperator("ScheduleType", GlobalVar.ScheduleType.History, BinaryOperatorType.NotEqual), 
                                                               new BinaryOperator("ScheduleType", GlobalVar.ScheduleType.CheckOut, BinaryOperatorType.NotEqual));
                xpSchedule = new XPCollection<RoomSchedule>(oSession,oCriteria);
            }

            xpSchedule.Sorting = new SortingCollection(new SortProperty("From", DevExpress.Xpo.DB.SortingDirection.Ascending), new SortProperty("Until", DevExpress.Xpo.DB.SortingDirection.Ascending));
            dsSchedule.Appointments.DataSource = xpSchedule;
            dsSchedule.Appointments.Mappings.AppointmentId = "Oid";
            dsSchedule.Appointments.Mappings.Description = "Description";
            dsSchedule.Appointments.Mappings.Label = "LabelId";
            dsSchedule.Appointments.Mappings.ResourceId = "ResourceId";
            dsSchedule.Appointments.Mappings.Start = "From";
            dsSchedule.Appointments.Mappings.End = "Until";
            dsSchedule.Appointments.Mappings.Subject = "Subject";
            dsSchedule.Appointments.Mappings.AllDay = "IsAllDay";
        }

        private void MappingResources()
        {
            XPCollection<Room> xpRoom = new XPCollection<Room>(oSession);
            xpRoom.Sorting = new SortingCollection(new SortProperty("Code", DevExpress.Xpo.DB.SortingDirection.Ascending));

            dsSchedule.Resources.Clear();

            Resource reservationResource = new Resource("Reservation", "Reservation");
            reservationResource.Caption = "Reservation";
            dsSchedule.Resources.Add(reservationResource);

            foreach (Room obj in xpRoom)
            {
                Resource newResource = new Resource(obj.Code,obj.Name);
                newResource.Caption = obj.Name;
                if (obj.RoomStatus == GlobalVar.RoomStatus.Maintenance)
                {
                    newResource.Color = System.Drawing.Color.Red;
                }
                dsSchedule.Resources.Add(newResource);
            }
        }

        private void SetSchedulerBehaviour()
        {
            schedulerControlBoard.MonthView.CompressWeekend = false;
            schedulerControlBoard.GroupType = SchedulerGroupType.Resource;
            schedulerControlBoard.OptionsView.ResourceHeaders.Height = 70;
            schedulerControlBoard.TimelineView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never;
            schedulerControlBoard.TimelineView.ResourcesPerPage = 10;
            schedulerControlBoard.DayView.ResourcesPerPage = 10;
            schedulerControlBoard.GanttView.ResourcesPerPage = 10;
            schedulerControlBoard.TimelineView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never;
            schedulerControlBoard.TimelineView.AppointmentDisplayOptions.TimeDisplayType = AppointmentTimeDisplayType.Text;
            schedulerControlBoard.TimelineView.AppointmentDisplayOptions.SnapToCellsMode = AppointmentSnapToCellsMode.Always;
            schedulerControlBoard.TimelineView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            schedulerControlBoard.TimelineView.AppointmentDisplayOptions.ContinueArrowDisplayType = AppointmentContinueArrowDisplayType.ArrowWithText;
            schedulerControlBoard.TimelineView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Time;
            schedulerControlBoard.TimelineView.CellsAutoHeightOptions.Enabled = true;
            schedulerControlBoard.OptionsView.ToolTipVisibility = ToolTipVisibility.Always;
            
        }

        private void tpController_BeforeShow(object sender, ToolTipControllerShowEventArgs e)
        {
            ToolTipController controller = sender as ToolTipController;
            AppointmentViewInfo aptViewInfo = controller.ActiveObject as AppointmentViewInfo;
            if (aptViewInfo == null) return;
            e.IconType = ToolTipIconType.Information;
            e.Title = aptViewInfo.Appointment.Subject;
            e.ToolTip = "Description: " + aptViewInfo.Appointment.Description;
        }

        private void schedulerControlBoard_CustomDrawTimeCell(object sender, CustomDrawObjectEventArgs e)
        {
            Brush todayBrush = new SolidBrush(Color.Yellow);
            Brush solidBrush = new SolidBrush(Color.SkyBlue);
            SelectableIntervalViewInfo cell = e.ObjectInfo as SelectableIntervalViewInfo;
            if (cell != null)
            {
                if (cell.Selected)
                {
                    e.Graphics.FillRectangle(solidBrush, e.Bounds);
                    e.Handled = true;
                }
                else if (cell.Interval.Start == DateTime.Now.Date)
                {
                    e.Graphics.FillRectangle(todayBrush, e.Bounds);
                    e.Handled = true;
                }
            }
        }

        private void chkShowPast_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitScheduler();
        }

        private void frmControlBoard_Load(object sender, EventArgs e)
        {
            IMouseHandlerService oldMouseHandler = (IMouseHandlerService)schedulerControlBoard.GetService(typeof(IMouseHandlerService));
            if (oldMouseHandler != null)
            {
                MyMouseHandlerService newMouseHandler = new MyMouseHandlerService(schedulerControlBoard, oldMouseHandler);
                schedulerControlBoard.RemoveService(typeof(IMouseHandlerService));
                schedulerControlBoard.AddService(typeof(IMouseHandlerService), newMouseHandler);
            }
        }

    }

    public class MyMouseHandlerService : MouseHandlerServiceWrapper
    {
        IServiceProvider provider;

        public MyMouseHandlerService(IServiceProvider provider, IMouseHandlerService service)
            : base(service)
        {
            this.provider = provider;
        }

        public override void OnMouseWheel(MouseEventArgs e)
        {
            if (provider != null)
            {
                IResourceNavigationService svc = (IResourceNavigationService)provider.GetService(typeof(IResourceNavigationService));
                if (svc != null)
                {
                    if (e.Delta < 0)
                        svc.NavigateForward();
                    else
                        svc.NavigateBackward();
                    return;
                }
            }
            base.OnMouseWheel(e);
        }
    }
}