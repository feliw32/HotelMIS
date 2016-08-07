namespace HotelMIS.View
{
    partial class frmDlgMasterStay
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (oSession != null)
                {
                    oSession.Dispose();
                    oSession = null;
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgMasterStay));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalculate = new DevExpress.XtraBars.BarButtonItem();
            this.btnPayment = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheckOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.chkIsReceiptPrinted = new DevExpress.XtraEditors.CheckEdit();
            this.sePenalties = new DevExpress.XtraEditors.SpinEdit();
            this.chkGuestIsCompany = new DevExpress.XtraEditors.CheckEdit();
            this.seDiscountByAmount = new DevExpress.XtraEditors.SpinEdit();
            this.seTotalPayment = new DevExpress.XtraEditors.SpinEdit();
            this.seDeposit = new DevExpress.XtraEditors.SpinEdit();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsCheckOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsCheckIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seTotal = new DevExpress.XtraEditors.SpinEdit();
            this.seSubTotal = new DevExpress.XtraEditors.SpinEdit();
            this.seDiscountByPercent = new DevExpress.XtraEditors.SpinEdit();
            this.meNote = new DevExpress.XtraEditors.MemoEdit();
            this.luGuest = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControllItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Room = new DevExpress.XtraTab.XtraTabPage();
            this.btnRefreshDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewDetail = new DevExpress.XtraEditors.SimpleButton();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.bsRoom = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Breakfast = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BreakfastPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckInBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckOutBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DurationInDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DurationInHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExtraBed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExtraBedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Guest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuestName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoOfGuest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PenaltiesCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcPaymentVouchers = new DevExpress.XtraGrid.GridControl();
            this.bsPayment = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Oid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PaymentFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferenceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Responsible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepositAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsReceiptPrinted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePenalties.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGuestIsCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiscountByAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDeposit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiscountByPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luGuest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControllItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.Room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPaymentVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSave,
            this.btnCancel,
            this.btnClose,
            this.btnCheckOut,
            this.btnCalculate,
            this.btnRefresh,
            this.btnPayment});
            this.barManager1.MaxItemId = 12;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCalculate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPayment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCheckOut, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSave.Glyph")));
            this.btnSave.Id = 0;
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancel.Glyph")));
            this.btnCancel.Id = 1;
            this.btnCancel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Caption = "Calculate";
            this.btnCalculate.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCalculate.Glyph")));
            this.btnCalculate.Id = 7;
            this.btnCalculate.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3));
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalculate_ItemClick);
            // 
            // btnPayment
            // 
            this.btnPayment.Caption = "Payment";
            this.btnPayment.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPayment.Glyph")));
            this.btnPayment.Id = 10;
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPayment_ItemClick);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Id = 11;
            this.btnCheckOut.Name = "btnCheckOut";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 8;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F6));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 2;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F7));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(880, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 629);
            this.barDockControlBottom.Size = new System.Drawing.Size(880, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 582);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(880, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 582);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 47);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(880, 582);
            this.xtraTabControl1.TabIndex = 10;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.Room,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(874, 554);
            this.xtraTabPage1.Text = "Data Information";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(874, 554);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spinEdit2);
            this.layoutControl1.Controls.Add(this.spinEdit1);
            this.layoutControl1.Controls.Add(this.chkIsReceiptPrinted);
            this.layoutControl1.Controls.Add(this.sePenalties);
            this.layoutControl1.Controls.Add(this.chkGuestIsCompany);
            this.layoutControl1.Controls.Add(this.seDiscountByAmount);
            this.layoutControl1.Controls.Add(this.seTotalPayment);
            this.layoutControl1.Controls.Add(this.seDeposit);
            this.layoutControl1.Controls.Add(this.xtraTabControl2);
            this.layoutControl1.Controls.Add(this.seTotal);
            this.layoutControl1.Controls.Add(this.seSubTotal);
            this.layoutControl1.Controls.Add(this.seDiscountByPercent);
            this.layoutControl1.Controls.Add(this.meNote);
            this.layoutControl1.Controls.Add(this.luGuest);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem19});
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(708, 304, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(870, 550);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spinEdit2
            // 
            this.spinEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "NoOfRoom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(536, 59);
            this.spinEdit2.MenuManager = this.barManager1;
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Properties.DisplayFormat.FormatString = "#,#.##";
            this.spinEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit2.Properties.EditFormat.FormatString = "#,#.##";
            this.spinEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit2.Properties.Mask.EditMask = "#,#.##";
            this.spinEdit2.Properties.ReadOnly = true;
            this.spinEdit2.Size = new System.Drawing.Size(322, 20);
            this.spinEdit2.StyleController = this.layoutControl1;
            this.spinEdit2.TabIndex = 45;
            // 
            // spinEdit1
            // 
            this.spinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "NoOfGuest", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(111, 59);
            this.spinEdit1.MenuManager = this.barManager1;
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.DisplayFormat.FormatString = "#,#.##";
            this.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Properties.EditFormat.FormatString = "#,#.##";
            this.spinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Properties.Mask.EditMask = "#,#.##";
            this.spinEdit1.Properties.ReadOnly = true;
            this.spinEdit1.Size = new System.Drawing.Size(322, 20);
            this.spinEdit1.StyleController = this.layoutControl1;
            this.spinEdit1.TabIndex = 44;
            // 
            // chkIsReceiptPrinted
            // 
            this.chkIsReceiptPrinted.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "IsReceiptPrinted", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkIsReceiptPrinted.Location = new System.Drawing.Point(437, 36);
            this.chkIsReceiptPrinted.MenuManager = this.barManager1;
            this.chkIsReceiptPrinted.Name = "chkIsReceiptPrinted";
            this.chkIsReceiptPrinted.Properties.Caption = "Is Receipt Printed";
            this.chkIsReceiptPrinted.Properties.ReadOnly = true;
            this.chkIsReceiptPrinted.Size = new System.Drawing.Size(421, 19);
            this.chkIsReceiptPrinted.StyleController = this.layoutControl1;
            this.chkIsReceiptPrinted.TabIndex = 43;
            // 
            // sePenalties
            // 
            this.sePenalties.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "TotalExtraCharge", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sePenalties.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePenalties.Location = new System.Drawing.Point(536, 83);
            this.sePenalties.MenuManager = this.barManager1;
            this.sePenalties.Name = "sePenalties";
            this.sePenalties.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.sePenalties.Properties.Appearance.Options.UseFont = true;
            this.sePenalties.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.sePenalties.Properties.DisplayFormat.FormatString = "#,#";
            this.sePenalties.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePenalties.Properties.ReadOnly = true;
            this.sePenalties.Size = new System.Drawing.Size(322, 20);
            this.sePenalties.StyleController = this.layoutControl1;
            this.sePenalties.TabIndex = 42;
            // 
            // chkGuestIsCompany
            // 
            this.chkGuestIsCompany.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "IsCompany", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkGuestIsCompany.Location = new System.Drawing.Point(12, 36);
            this.chkGuestIsCompany.MenuManager = this.barManager1;
            this.chkGuestIsCompany.Name = "chkGuestIsCompany";
            this.chkGuestIsCompany.Properties.Caption = "Guest Is Company";
            this.chkGuestIsCompany.Properties.ReadOnly = true;
            this.chkGuestIsCompany.Size = new System.Drawing.Size(421, 19);
            this.chkGuestIsCompany.StyleController = this.layoutControl1;
            this.chkGuestIsCompany.TabIndex = 41;
            // 
            // seDiscountByAmount
            // 
            this.seDiscountByAmount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "DiscountByAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seDiscountByAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDiscountByAmount.Location = new System.Drawing.Point(536, 107);
            this.seDiscountByAmount.MenuManager = this.barManager1;
            this.seDiscountByAmount.Name = "seDiscountByAmount";
            this.seDiscountByAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seDiscountByAmount.Properties.Appearance.Options.UseFont = true;
            this.seDiscountByAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seDiscountByAmount.Properties.DisplayFormat.FormatString = "#,#.##";
            this.seDiscountByAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seDiscountByAmount.Properties.EditFormat.FormatString = "#,#.##";
            this.seDiscountByAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seDiscountByAmount.Size = new System.Drawing.Size(322, 20);
            this.seDiscountByAmount.StyleController = this.layoutControl1;
            this.seDiscountByAmount.TabIndex = 40;
            this.seDiscountByAmount.Enter += new System.EventHandler(this.seDiscountByAmount_Enter);
            // 
            // seTotalPayment
            // 
            this.seTotalPayment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "TotalRoomPayment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seTotalPayment.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTotalPayment.Location = new System.Drawing.Point(111, 155);
            this.seTotalPayment.MenuManager = this.barManager1;
            this.seTotalPayment.Name = "seTotalPayment";
            this.seTotalPayment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seTotalPayment.Properties.Appearance.Options.UseFont = true;
            this.seTotalPayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seTotalPayment.Properties.DisplayFormat.FormatString = "#,#";
            this.seTotalPayment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTotalPayment.Properties.ReadOnly = true;
            this.seTotalPayment.Size = new System.Drawing.Size(322, 20);
            this.seTotalPayment.StyleController = this.layoutControl1;
            this.seTotalPayment.TabIndex = 34;
            // 
            // seDeposit
            // 
            this.seDeposit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "TotalDeposit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seDeposit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDeposit.Location = new System.Drawing.Point(536, 155);
            this.seDeposit.MenuManager = this.barManager1;
            this.seDeposit.Name = "seDeposit";
            this.seDeposit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seDeposit.Properties.Appearance.Options.UseFont = true;
            this.seDeposit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seDeposit.Properties.DisplayFormat.FormatString = "#,#";
            this.seDeposit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seDeposit.Properties.ReadOnly = true;
            this.seDeposit.Size = new System.Drawing.Size(322, 20);
            this.seDeposit.StyleController = this.layoutControl1;
            this.seDeposit.TabIndex = 33;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl2.Size = new System.Drawing.Size(170, 22);
            this.xtraTabControl2.TabIndex = 32;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(164, 0);
            this.xtraTabPage3.Text = "Lines";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView3;
            this.gridControl1.MaximumSize = new System.Drawing.Size(400, 0);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(164, 0);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.IsCheckOut,
            this.IsCheckIn});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsDetail.AllowZoomDetail = false;
            this.gridView3.OptionsDetail.EnableMasterViewMode = false;
            this.gridView3.OptionsDetail.ShowDetailTabs = false;
            this.gridView3.OptionsView.ShowDetailButtons = false;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Room";
            this.gridColumn1.FieldName = "RoomPrice.Room.Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Date";
            this.gridColumn2.FieldName = "TransDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Reservation Status";
            this.gridColumn3.FieldName = "ReservationStatus";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Duration";
            this.gridColumn4.FieldName = "Duration";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // IsCheckOut
            // 
            this.IsCheckOut.Caption = "IsCheckOut";
            this.IsCheckOut.FieldName = "IsCheckOut";
            this.IsCheckOut.Name = "IsCheckOut";
            this.IsCheckOut.Visible = true;
            this.IsCheckOut.VisibleIndex = 4;
            // 
            // IsCheckIn
            // 
            this.IsCheckIn.Caption = "IsCheckIn";
            this.IsCheckIn.FieldName = "IsCheckIn";
            this.IsCheckIn.Name = "IsCheckIn";
            this.IsCheckIn.Visible = true;
            this.IsCheckIn.VisibleIndex = 5;
            // 
            // seTotal
            // 
            this.seTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Total", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTotal.Location = new System.Drawing.Point(111, 131);
            this.seTotal.MenuManager = this.barManager1;
            this.seTotal.Name = "seTotal";
            this.seTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seTotal.Properties.Appearance.Options.UseFont = true;
            this.seTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seTotal.Properties.DisplayFormat.FormatString = "#,#";
            this.seTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTotal.Properties.ReadOnly = true;
            this.seTotal.Size = new System.Drawing.Size(747, 20);
            this.seTotal.StyleController = this.layoutControl1;
            this.seTotal.TabIndex = 31;
            // 
            // seSubTotal
            // 
            this.seSubTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "SubTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seSubTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSubTotal.Location = new System.Drawing.Point(111, 83);
            this.seSubTotal.MenuManager = this.barManager1;
            this.seSubTotal.Name = "seSubTotal";
            this.seSubTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seSubTotal.Properties.Appearance.Options.UseFont = true;
            this.seSubTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seSubTotal.Properties.DisplayFormat.FormatString = "#,#";
            this.seSubTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seSubTotal.Properties.ReadOnly = true;
            this.seSubTotal.Size = new System.Drawing.Size(322, 20);
            this.seSubTotal.StyleController = this.layoutControl1;
            this.seSubTotal.TabIndex = 30;
            // 
            // seDiscountByPercent
            // 
            this.seDiscountByPercent.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "DiscountByPercent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seDiscountByPercent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDiscountByPercent.Location = new System.Drawing.Point(111, 107);
            this.seDiscountByPercent.MenuManager = this.barManager1;
            this.seDiscountByPercent.Name = "seDiscountByPercent";
            this.seDiscountByPercent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seDiscountByPercent.Properties.Appearance.Options.UseFont = true;
            this.seDiscountByPercent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seDiscountByPercent.Size = new System.Drawing.Size(322, 20);
            this.seDiscountByPercent.StyleController = this.layoutControl1;
            this.seDiscountByPercent.TabIndex = 28;
            this.seDiscountByPercent.Enter += new System.EventHandler(this.seDiscountByPercent_Enter);
            // 
            // meNote
            // 
            this.meNote.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Note", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.meNote.Location = new System.Drawing.Point(111, 179);
            this.meNote.MenuManager = this.barManager1;
            this.meNote.Name = "meNote";
            this.meNote.Properties.LinesCount = 3;
            this.meNote.Properties.ReadOnly = true;
            this.meNote.Size = new System.Drawing.Size(747, 359);
            this.meNote.StyleController = this.layoutControl1;
            this.meNote.TabIndex = 24;
            // 
            // luGuest
            // 
            this.luGuest.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "GuestOid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.luGuest.Location = new System.Drawing.Point(111, 12);
            this.luGuest.MenuManager = this.barManager1;
            this.luGuest.Name = "luGuest";
            this.luGuest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "X", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "btnDelete", null, true)});
            this.luGuest.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KTP", "KTP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIM", "SIM"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Passport", "Passport"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DateOfBirth", "DOB")});
            this.luGuest.Properties.DisplayMember = "Name";
            this.luGuest.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch;
            this.luGuest.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.luGuest.Properties.ImmediatePopup = true;
            this.luGuest.Properties.NullText = "Choose Item ..";
            this.luGuest.Properties.ReadOnly = true;
            this.luGuest.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.luGuest.Properties.ValueMember = "Oid";
            this.luGuest.Size = new System.Drawing.Size(747, 20);
            this.luGuest.StyleController = this.layoutControl1;
            this.luGuest.TabIndex = 7;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.xtraTabControl2;
            this.layoutControlItem19.CustomizationFormText = "layoutControlItem19";
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(174, 26);
            this.layoutControlItem19.Text = "layoutControlItem19";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextToControlDistance = 0;
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem13,
            this.layoutControlItem4,
            this.layoutControlItem18,
            this.layoutControlItem21,
            this.layoutControlItem26,
            this.layoutControllItem20,
            this.layoutControlItem27,
            this.layoutControlItem22,
            this.layoutControlItem15,
            this.layoutControlItem28,
            this.layoutControlItem17,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(870, 550);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.seDiscountByPercent;
            this.layoutControlItem13.CustomizationFormText = "Discount (%)";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem13.Text = "Discount (%)";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.luGuest;
            this.layoutControlItem4.CustomizationFormText = "Guest";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(850, 24);
            this.layoutControlItem4.Text = "Guest";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.seTotal;
            this.layoutControlItem18.CustomizationFormText = "Total";
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(850, 24);
            this.layoutControlItem18.Text = "Total";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.seTotalPayment;
            this.layoutControlItem21.CustomizationFormText = "Total Payment";
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 143);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem21.Text = "Total Payment";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.seDiscountByAmount;
            this.layoutControlItem26.CustomizationFormText = "Discount By Amount";
            this.layoutControlItem26.Location = new System.Drawing.Point(425, 95);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem26.Text = "Discount By Amount";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControllItem20
            // 
            this.layoutControllItem20.Control = this.seDeposit;
            this.layoutControllItem20.CustomizationFormText = "Deposit";
            this.layoutControllItem20.Location = new System.Drawing.Point(425, 143);
            this.layoutControllItem20.Name = "layoutControllItem20";
            this.layoutControllItem20.Size = new System.Drawing.Size(425, 24);
            this.layoutControllItem20.Text = "Total Deposit";
            this.layoutControllItem20.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.chkGuestIsCompany;
            this.layoutControlItem27.CustomizationFormText = "layoutControlItem27";
            this.layoutControlItem27.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(425, 23);
            this.layoutControlItem27.Text = "layoutControlItem27";
            this.layoutControlItem27.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem27.TextToControlDistance = 0;
            this.layoutControlItem27.TextVisible = false;
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.chkIsReceiptPrinted;
            this.layoutControlItem22.CustomizationFormText = "layoutControlItem22";
            this.layoutControlItem22.Location = new System.Drawing.Point(425, 24);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(425, 23);
            this.layoutControlItem22.Text = "layoutControlItem22";
            this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem22.TextToControlDistance = 0;
            this.layoutControlItem22.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.seSubTotal;
            this.layoutControlItem15.CustomizationFormText = "Sub Total";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem15.Text = "Sub Total";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.sePenalties;
            this.layoutControlItem28.CustomizationFormText = "Penalties";
            this.layoutControlItem28.Location = new System.Drawing.Point(425, 71);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem28.Text = "Total Extra";
            this.layoutControlItem28.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.meNote;
            this.layoutControlItem17.CustomizationFormText = "Note";
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 167);
            this.layoutControlItem17.MinSize = new System.Drawing.Size(133, 20);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(850, 363);
            this.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem17.Text = "Note";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.spinEdit1;
            this.layoutControlItem1.CustomizationFormText = "No Of Guest";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem1.Text = "No Of Guest";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinEdit2;
            this.layoutControlItem2.CustomizationFormText = "No Of Room";
            this.layoutControlItem2.Location = new System.Drawing.Point(425, 47);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem2.Text = "No Of Room";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 13);
            // 
            // Room
            // 
            this.Room.Controls.Add(this.btnRefreshDetail);
            this.Room.Controls.Add(this.btnEditDetail);
            this.Room.Controls.Add(this.btnNewDetail);
            this.Room.Controls.Add(this.gcData);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(874, 554);
            this.Room.Text = "Room";
            // 
            // btnRefreshDetail
            // 
            this.btnRefreshDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRefreshDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDetail.Image")));
            this.btnRefreshDetail.Location = new System.Drawing.Point(162, 9);
            this.btnRefreshDetail.Name = "btnRefreshDetail";
            this.btnRefreshDetail.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDetail.TabIndex = 4;
            this.btnRefreshDetail.Text = "Refresh";
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEditDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDetail.Image")));
            this.btnEditDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEditDetail.Location = new System.Drawing.Point(81, 9);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(75, 23);
            this.btnEditDetail.TabIndex = 2;
            this.btnEditDetail.Text = "Edit";
            // 
            // btnNewDetail
            // 
            this.btnNewDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNewDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDetail.Image")));
            this.btnNewDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewDetail.Location = new System.Drawing.Point(5, 9);
            this.btnNewDetail.Name = "btnNewDetail";
            this.btnNewDetail.Size = new System.Drawing.Size(75, 23);
            this.btnNewDetail.TabIndex = 3;
            this.btnNewDetail.Text = "New";
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.DataSource = this.bsRoom;
            this.gcData.Location = new System.Drawing.Point(3, 38);
            this.gcData.MainView = this.gridView2;
            this.gcData.MenuManager = this.barManager1;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(864, 516);
            this.gcData.TabIndex = 1;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView2.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView2.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.Breakfast,
            this.BreakfastPrice,
            this.CheckInBy,
            this.CheckOutBy,
            this.CheckIn,
            this.CheckOut,
            this.DurationInDays,
            this.DurationInHours,
            this.ExtraBed,
            this.ExtraBedPrice,
            this.Guest,
            this.GuestName,
            this.NoOfGuest,
            this.gridColumn6,
            this.RoomPrice,
            this.gridColumn7,
            this.RoomRate,
            this.SubTotal,
            this.Total,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.PenaltiesCost});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(519, 490, 216, 190);
            this.gridView2.GridControl = this.gcData;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.AllowZoomDetail = false;
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Oid";
            this.gridColumn5.FieldName = "Oid";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // Breakfast
            // 
            this.Breakfast.Caption = "Breakfast";
            this.Breakfast.FieldName = "Breakfast";
            this.Breakfast.Name = "Breakfast";
            this.Breakfast.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            // 
            // BreakfastPrice
            // 
            this.BreakfastPrice.Caption = "Breakfast Price";
            this.BreakfastPrice.FieldName = "BreakfastPrice";
            this.BreakfastPrice.Name = "BreakfastPrice";
            // 
            // CheckInBy
            // 
            this.CheckInBy.Caption = "Staff In";
            this.CheckInBy.FieldName = "CheckInBy.Code";
            this.CheckInBy.Name = "CheckInBy";
            // 
            // CheckOutBy
            // 
            this.CheckOutBy.Caption = "Staff Out";
            this.CheckOutBy.FieldName = "CheckOutBy.Code";
            this.CheckOutBy.Name = "CheckOutBy";
            // 
            // CheckIn
            // 
            this.CheckIn.Caption = "Check In";
            this.CheckIn.DisplayFormat.FormatString = "dd-MMM-yyyy HH:mm";
            this.CheckIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CheckIn.FieldName = "DateCheckIn";
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Visible = true;
            this.CheckIn.VisibleIndex = 1;
            // 
            // CheckOut
            // 
            this.CheckOut.Caption = "Check Out";
            this.CheckOut.DisplayFormat.FormatString = "dd-MMM-yyyy HH:mm";
            this.CheckOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CheckOut.FieldName = "DateCheckOut";
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Visible = true;
            this.CheckOut.VisibleIndex = 2;
            // 
            // DurationInDays
            // 
            this.DurationInDays.Caption = "Duration In Days";
            this.DurationInDays.FieldName = "DurationInDays";
            this.DurationInDays.Name = "DurationInDays";
            // 
            // DurationInHours
            // 
            this.DurationInHours.Caption = "Duration In Hours";
            this.DurationInHours.FieldName = "DurationInHours";
            this.DurationInHours.Name = "DurationInHours";
            // 
            // ExtraBed
            // 
            this.ExtraBed.Caption = "ExtraBed";
            this.ExtraBed.FieldName = "ExtraBed";
            this.ExtraBed.Name = "ExtraBed";
            this.ExtraBed.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            // 
            // ExtraBedPrice
            // 
            this.ExtraBedPrice.Caption = "Extra Bed Price";
            this.ExtraBedPrice.FieldName = "ExtraBedPrice";
            this.ExtraBedPrice.Name = "ExtraBedPrice";
            // 
            // Guest
            // 
            this.Guest.Caption = "Guest";
            this.Guest.FieldName = "Guest.Name";
            this.Guest.Name = "Guest";
            // 
            // GuestName
            // 
            this.GuestName.Caption = "Guest";
            this.GuestName.FieldName = "GuestName";
            this.GuestName.Name = "GuestName";
            this.GuestName.Visible = true;
            this.GuestName.VisibleIndex = 0;
            // 
            // NoOfGuest
            // 
            this.NoOfGuest.Caption = "No Of Guest";
            this.NoOfGuest.FieldName = "NoOfGuest";
            this.NoOfGuest.Name = "NoOfGuest";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Note";
            this.gridColumn6.FieldName = "Note";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // RoomPrice
            // 
            this.RoomPrice.Caption = "Price Type";
            this.RoomPrice.FieldName = "PriceType.Name";
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.Visible = true;
            this.RoomPrice.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Room";
            this.gridColumn7.FieldName = "RoomCode";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // RoomRate
            // 
            this.RoomRate.Caption = "Rate";
            this.RoomRate.DisplayFormat.FormatString = "#,#";
            this.RoomRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RoomRate.FieldName = "RoomRate";
            this.RoomRate.Name = "RoomRate";
            this.RoomRate.Visible = true;
            this.RoomRate.VisibleIndex = 5;
            // 
            // SubTotal
            // 
            this.SubTotal.Caption = "SubTotal";
            this.SubTotal.DisplayFormat.FormatString = "#,#";
            this.SubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SubTotal.FieldName = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.DisplayFormat.FormatString = "#,#";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "User Created";
            this.gridColumn8.FieldName = "UserCreated";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Date Created";
            this.gridColumn9.FieldName = "DateCreated";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "User Updated";
            this.gridColumn10.FieldName = "UserUpdated";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Date Updated";
            this.gridColumn11.FieldName = "DateUpdated";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Status";
            this.gridColumn12.FieldName = "Status";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 8;
            // 
            // PenaltiesCost
            // 
            this.PenaltiesCost.Caption = "Penalties";
            this.PenaltiesCost.DisplayFormat.FormatString = "#,#";
            this.PenaltiesCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PenaltiesCost.FieldName = "PenaltiesCost";
            this.PenaltiesCost.GroupFormat.FormatString = "#,#";
            this.PenaltiesCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PenaltiesCost.Name = "PenaltiesCost";
            this.PenaltiesCost.Visible = true;
            this.PenaltiesCost.VisibleIndex = 7;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panelControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(874, 554);
            this.xtraTabPage2.Text = "Payments";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcPaymentVouchers);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(874, 554);
            this.panelControl2.TabIndex = 0;
            // 
            // gcPaymentVouchers
            // 
            this.gcPaymentVouchers.DataSource = this.bsPayment;
            this.gcPaymentVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPaymentVouchers.Location = new System.Drawing.Point(2, 2);
            this.gcPaymentVouchers.MainView = this.gridView1;
            this.gcPaymentVouchers.MenuManager = this.barManager1;
            this.gcPaymentVouchers.Name = "gcPaymentVouchers";
            this.gcPaymentVouchers.Size = new System.Drawing.Size(870, 550);
            this.gcPaymentVouchers.TabIndex = 5;
            this.gcPaymentVouchers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Oid,
            this.PaymentFor,
            this.PaymentMethod,
            this.PaidDate,
            this.ReferenceNo,
            this.Responsible,
            this.UserCreated,
            this.DateCreated,
            this.UserUpdated,
            this.DateUpdated,
            this.RoomAmount,
            this.DepositAmount,
            this.Status,
            this.Note});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(519, 490, 216, 190);
            this.gridView1.GridControl = this.gcPaymentVouchers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.PaidDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Oid
            // 
            this.Oid.Caption = "Oid";
            this.Oid.FieldName = "Oid";
            this.Oid.Name = "Oid";
            // 
            // PaymentFor
            // 
            this.PaymentFor.Caption = "Payment For";
            this.PaymentFor.FieldName = "PaymentFor.ToString";
            this.PaymentFor.Name = "PaymentFor";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.Caption = "Payment Method";
            this.PaymentMethod.FieldName = "PaymentMethod.Name";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Visible = true;
            this.PaymentMethod.VisibleIndex = 0;
            // 
            // PaidDate
            // 
            this.PaidDate.Caption = "Paid Date";
            this.PaidDate.DisplayFormat.FormatString = "dd-MMM-yyyy HH:mm";
            this.PaidDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.PaidDate.FieldName = "PaidDate";
            this.PaidDate.Name = "PaidDate";
            // 
            // ReferenceNo
            // 
            this.ReferenceNo.Caption = "Reference No";
            this.ReferenceNo.FieldName = "ReferenceNo";
            this.ReferenceNo.Name = "ReferenceNo";
            // 
            // Responsible
            // 
            this.Responsible.Caption = "Responsible";
            this.Responsible.FieldName = "Responsible.Name";
            this.Responsible.Name = "Responsible";
            // 
            // UserCreated
            // 
            this.UserCreated.Caption = "User Created";
            this.UserCreated.FieldName = "UserCreated";
            this.UserCreated.Name = "UserCreated";
            // 
            // DateCreated
            // 
            this.DateCreated.Caption = "Date Created";
            this.DateCreated.FieldName = "DateCreated";
            this.DateCreated.Name = "DateCreated";
            // 
            // UserUpdated
            // 
            this.UserUpdated.Caption = "User Updated";
            this.UserUpdated.FieldName = "UserUpdated";
            this.UserUpdated.Name = "UserUpdated";
            // 
            // DateUpdated
            // 
            this.DateUpdated.Caption = "Date Updated";
            this.DateUpdated.FieldName = "DateUpdated";
            this.DateUpdated.Name = "DateUpdated";
            // 
            // RoomAmount
            // 
            this.RoomAmount.Caption = "Room";
            this.RoomAmount.DisplayFormat.FormatString = "#,#";
            this.RoomAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RoomAmount.FieldName = "RoomAmount";
            this.RoomAmount.GroupFormat.FormatString = "#,#";
            this.RoomAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RoomAmount.Name = "RoomAmount";
            this.RoomAmount.Visible = true;
            this.RoomAmount.VisibleIndex = 1;
            // 
            // DepositAmount
            // 
            this.DepositAmount.Caption = "Deposit";
            this.DepositAmount.DisplayFormat.FormatString = "#,#";
            this.DepositAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DepositAmount.FieldName = "DepositAmount";
            this.DepositAmount.GroupFormat.FormatString = "#,#";
            this.DepositAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DepositAmount.Name = "DepositAmount";
            this.DepositAmount.Visible = true;
            this.DepositAmount.VisibleIndex = 2;
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            // 
            // Note
            // 
            this.Note.Caption = "Note";
            this.Note.FieldName = "Note";
            this.Note.Name = "Note";
            // 
            // frmDlgMasterStay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 629);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDlgMasterStay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsReceiptPrinted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePenalties.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGuestIsCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiscountByAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDeposit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiscountByPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luGuest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControllItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.Room.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPaymentVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraBars.BarButtonItem btnCheckOut;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit seDiscountByAmount;
        private DevExpress.XtraEditors.SpinEdit seTotalPayment;
        private DevExpress.XtraEditors.SpinEdit seDeposit;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn IsCheckOut;
        private DevExpress.XtraGrid.Columns.GridColumn IsCheckIn;
        private DevExpress.XtraEditors.SpinEdit seTotal;
        private DevExpress.XtraEditors.SpinEdit seSubTotal;
        private DevExpress.XtraEditors.SpinEdit seDiscountByPercent;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraEditors.LookUpEdit luGuest;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControllItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.BarButtonItem btnCalculate;
        private DevExpress.XtraEditors.CheckEdit chkGuestIsCompany;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraGrid.GridControl gcPaymentVouchers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Oid;
        private DevExpress.XtraGrid.Columns.GridColumn PaymentFor;
        private DevExpress.XtraGrid.Columns.GridColumn PaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn PaidDate;
        private DevExpress.XtraGrid.Columns.GridColumn ReferenceNo;
        private DevExpress.XtraGrid.Columns.GridColumn Responsible;
        private DevExpress.XtraGrid.Columns.GridColumn UserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn DateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn UserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn DateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn RoomAmount;
        private DevExpress.XtraGrid.Columns.GridColumn DepositAmount;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private System.Windows.Forms.BindingSource bsPayment;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraEditors.SpinEdit sePenalties;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraBars.BarButtonItem btnPayment;
        private DevExpress.XtraEditors.CheckEdit chkIsReceiptPrinted;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraTab.XtraTabPage Room;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn Breakfast;
        private DevExpress.XtraGrid.Columns.GridColumn BreakfastPrice;
        private DevExpress.XtraGrid.Columns.GridColumn CheckInBy;
        private DevExpress.XtraGrid.Columns.GridColumn CheckOutBy;
        private DevExpress.XtraGrid.Columns.GridColumn CheckIn;
        private DevExpress.XtraGrid.Columns.GridColumn CheckOut;
        private DevExpress.XtraGrid.Columns.GridColumn DurationInDays;
        private DevExpress.XtraGrid.Columns.GridColumn DurationInHours;
        private DevExpress.XtraGrid.Columns.GridColumn ExtraBed;
        private DevExpress.XtraGrid.Columns.GridColumn ExtraBedPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Guest;
        private DevExpress.XtraGrid.Columns.GridColumn GuestName;
        private DevExpress.XtraGrid.Columns.GridColumn NoOfGuest;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn RoomPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn RoomRate;
        private DevExpress.XtraGrid.Columns.GridColumn SubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn PenaltiesCost;
        private System.Windows.Forms.BindingSource bsRoom;
        private DevExpress.XtraEditors.SimpleButton btnRefreshDetail;
        private DevExpress.XtraEditors.SimpleButton btnEditDetail;
        private DevExpress.XtraEditors.SimpleButton btnNewDetail;
    }
}