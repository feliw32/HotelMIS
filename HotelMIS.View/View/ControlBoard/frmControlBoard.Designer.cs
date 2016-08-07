namespace HotelMIS.View
{
    partial class frmControlBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlBoard));
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.chkShowPast = new DevExpress.XtraBars.BarCheckItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemDuration1 = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.schedulerControlBoard = new DevExpress.XtraScheduler.SchedulerControl();
            this.dsSchedule = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.tpController = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControlBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DisableCustomization = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnClose,
            this.btnRefresh,
            this.chkShowPast});
            this.barManager1.MaxItemId = 17;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDuration1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.chkShowPast, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Tools";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 4;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // chkShowPast
            // 
            this.chkShowPast.Caption = "Show History Transaction";
            this.chkShowPast.Glyph = ((System.Drawing.Image)(resources.GetObject("chkShowPast.Glyph")));
            this.chkShowPast.Id = 16;
            this.chkShowPast.ItemInMenuAppearance.Pressed.BackColor = System.Drawing.Color.Silver;
            this.chkShowPast.ItemInMenuAppearance.Pressed.Options.UseBackColor = true;
            this.chkShowPast.Name = "chkShowPast";
            this.chkShowPast.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkShowPast_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 2;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1020, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 701);
            this.barDockControlBottom.Size = new System.Drawing.Size(1020, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 654);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1020, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 654);
            // 
            // repositoryItemDuration1
            // 
            this.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDuration1.AutoHeight = false;
            this.repositoryItemDuration1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDuration1.Name = "repositoryItemDuration1";
            this.repositoryItemDuration1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemDuration1.ShowEmptyItem = true;
            this.repositoryItemDuration1.ValidateOnEnterKey = true;
            // 
            // schedulerControlBoard
            // 
            this.schedulerControlBoard.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerControlBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControlBoard.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControlBoard.Location = new System.Drawing.Point(0, 47);
            this.schedulerControlBoard.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.schedulerControlBoard.MenuManager = this.barManager1;
            this.schedulerControlBoard.Name = "schedulerControlBoard";
            this.schedulerControlBoard.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControlBoard.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControlBoard.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControlBoard.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControlBoard.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControlBoard.OptionsCustomization.AllowAppointmentMultiSelect = false;
            this.schedulerControlBoard.OptionsCustomization.AllowDisplayAppointmentDependencyForm = DevExpress.XtraScheduler.AllowDisplayAppointmentDependencyForm.Never;
            this.schedulerControlBoard.OptionsCustomization.AllowDisplayAppointmentForm = DevExpress.XtraScheduler.AllowDisplayAppointmentForm.Never;
            this.schedulerControlBoard.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.Custom;
            this.schedulerControlBoard.OptionsView.NavigationButtons.NextCaption = "Next";
            this.schedulerControlBoard.OptionsView.NavigationButtons.PrevCaption = "Previous";
            this.schedulerControlBoard.OptionsView.NavigationButtons.Visibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
            this.schedulerControlBoard.OptionsView.ResourceHeaders.RotateCaption = false;
            this.schedulerControlBoard.OptionsView.ToolTipVisibility = DevExpress.XtraScheduler.ToolTipVisibility.Always;
            this.schedulerControlBoard.Size = new System.Drawing.Size(1020, 654);
            this.schedulerControlBoard.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.schedulerControlBoard.Storage = this.dsSchedule;
            this.schedulerControlBoard.TabIndex = 10;
            this.schedulerControlBoard.Text = "schedulerControl1";
            this.schedulerControlBoard.ToolTipController = this.tpController;
            timeRuler1.TimeZone.Id = "SE Asia Standard Time";
            timeRuler1.UseClientTimeZone = false;
            this.schedulerControlBoard.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControlBoard.Views.GanttView.Enabled = false;
            this.schedulerControlBoard.Views.TimelineView.Appearance.ResourceHeaderCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerControlBoard.Views.TimelineView.Appearance.ResourceHeaderCaption.Options.UseFont = true;
            this.schedulerControlBoard.Views.TimelineView.CellsAutoHeightOptions.Enabled = true;
            this.schedulerControlBoard.Views.WeekView.Enabled = false;
            this.schedulerControlBoard.Views.WorkWeekView.Enabled = false;
            timeRuler2.TimeZone.Id = "SE Asia Standard Time";
            timeRuler2.UseClientTimeZone = false;
            this.schedulerControlBoard.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControlBoard.CustomDrawTimeCell += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.schedulerControlBoard_CustomDrawTimeCell);
            // 
            // tpController
            // 
            this.tpController.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tpController.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpController.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.tpController.Appearance.Options.UseBackColor = true;
            this.tpController.Appearance.Options.UseBorderColor = true;
            this.tpController.AutoPopDelay = 20000;
            this.tpController.InitialDelay = 1;
            this.tpController.ReshowDelay = 10;
            this.tpController.Rounded = true;
            this.tpController.ToolTipType = DevExpress.Utils.ToolTipType.Standard;
            // 
            // frmControlBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 701);
            this.Controls.Add(this.schedulerControlBoard);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmControlBoard";
            this.Text = "Control Board";
            this.Load += new System.EventHandler(this.frmControlBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControlBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControlBoard;
        private DevExpress.XtraScheduler.SchedulerStorage dsSchedule;
        private DevExpress.Utils.ToolTipController tpController;
        private DevExpress.XtraScheduler.UI.RepositoryItemDuration repositoryItemDuration1;
        private DevExpress.XtraBars.BarCheckItem chkShowPast;
    }
}