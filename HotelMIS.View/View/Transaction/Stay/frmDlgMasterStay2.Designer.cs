namespace HotelMIS.View
{
    partial class frmDlgMasterStay2
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgMasterStay2));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalculate = new DevExpress.XtraBars.BarButtonItem();
            this.btnPayment = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheckOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnReprint = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnNewGuest = new DevExpress.XtraEditors.SimpleButton();
            this.meNote = new DevExpress.XtraEditors.MemoEdit();
            this.luGuest = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seNoOfGuest = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBreakfast = new DevExpress.XtraEditors.CheckEdit();
            this.luRoomType = new DevExpress.XtraEditors.LookUpEdit();
            this.chkExtraBed = new DevExpress.XtraEditors.CheckEdit();
            this.luPriceType = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSaveDetail = new DevExpress.XtraEditors.SimpleButton();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.deUntil = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.seDurationInHours = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.seDurationInDays = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.luRoomPrice = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshDetail = new DevExpress.XtraEditors.SimpleButton();
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditDetail = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seNoOfGuest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBreakfast.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExtraBed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luPriceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deUntil.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deUntil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDurationInHours.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDurationInDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomPrice.Properties)).BeginInit();
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
            this.btnPayment,
            this.btnReprint});
            this.barManager1.MaxItemId = 13;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReprint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnCancel.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.btnCancel.Caption = "Cancel Data";
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
            // btnReprint
            // 
            this.btnReprint.Caption = "Reprint Receipt";
            this.btnReprint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReprint.Glyph")));
            this.btnReprint.Id = 12;
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReprint_ItemClick);
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
            this.layoutControl1.Controls.Add(this.btnNewGuest);
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
            this.spinEdit2.Location = new System.Drawing.Point(536, 61);
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
            this.spinEdit1.Location = new System.Drawing.Point(111, 61);
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
            this.chkIsReceiptPrinted.Location = new System.Drawing.Point(437, 38);
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
            this.sePenalties.Location = new System.Drawing.Point(536, 85);
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
            this.chkGuestIsCompany.Location = new System.Drawing.Point(12, 38);
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
            this.seDiscountByAmount.Location = new System.Drawing.Point(536, 109);
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
            this.seTotalPayment.Location = new System.Drawing.Point(111, 157);
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
            this.seDeposit.Location = new System.Drawing.Point(536, 157);
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
            this.seTotal.Location = new System.Drawing.Point(111, 133);
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
            this.seSubTotal.Location = new System.Drawing.Point(111, 85);
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
            this.seDiscountByPercent.Location = new System.Drawing.Point(111, 109);
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
            // btnNewGuest
            // 
            this.btnNewGuest.Location = new System.Drawing.Point(758, 12);
            this.btnNewGuest.MaximumSize = new System.Drawing.Size(100, 0);
            this.btnNewGuest.Name = "btnNewGuest";
            this.btnNewGuest.Size = new System.Drawing.Size(100, 22);
            this.btnNewGuest.StyleController = this.layoutControl1;
            this.btnNewGuest.TabIndex = 27;
            this.btnNewGuest.Text = "New Guest";
            this.btnNewGuest.Click += new System.EventHandler(this.btnNewGuest_Click);
            // 
            // meNote
            // 
            this.meNote.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Note", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.meNote.Location = new System.Drawing.Point(111, 181);
            this.meNote.MenuManager = this.barManager1;
            this.meNote.Name = "meNote";
            this.meNote.Properties.LinesCount = 3;
            this.meNote.Size = new System.Drawing.Size(747, 357);
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "X", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject10, "", "btnDelete", null, true)});
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
            this.luGuest.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.luGuest.Properties.ValueMember = "Oid";
            this.luGuest.Size = new System.Drawing.Size(643, 20);
            this.luGuest.StyleController = this.layoutControl1;
            this.luGuest.TabIndex = 7;
            this.luGuest.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ClearComboSelection);
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
            this.layoutControlItem11,
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
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnNewGuest;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(746, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem11.Text = "layoutControlItem11";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 0;
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.seDiscountByPercent;
            this.layoutControlItem13.CustomizationFormText = "Discount (%)";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 97);
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
            this.layoutControlItem4.Size = new System.Drawing.Size(746, 26);
            this.layoutControlItem4.Text = "Guest";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.seTotal;
            this.layoutControlItem18.CustomizationFormText = "Total";
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(850, 24);
            this.layoutControlItem18.Text = "Total";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.seTotalPayment;
            this.layoutControlItem21.CustomizationFormText = "Total Payment";
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 145);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem21.Text = "Total Payment";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.seDiscountByAmount;
            this.layoutControlItem26.CustomizationFormText = "Discount By Amount";
            this.layoutControlItem26.Location = new System.Drawing.Point(425, 97);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem26.Text = "Discount By Amount";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControllItem20
            // 
            this.layoutControllItem20.Control = this.seDeposit;
            this.layoutControllItem20.CustomizationFormText = "Deposit";
            this.layoutControllItem20.Location = new System.Drawing.Point(425, 145);
            this.layoutControllItem20.Name = "layoutControllItem20";
            this.layoutControllItem20.Size = new System.Drawing.Size(425, 24);
            this.layoutControllItem20.Text = "Total Deposit";
            this.layoutControllItem20.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.chkGuestIsCompany;
            this.layoutControlItem27.CustomizationFormText = "layoutControlItem27";
            this.layoutControlItem27.Location = new System.Drawing.Point(0, 26);
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
            this.layoutControlItem22.Location = new System.Drawing.Point(425, 26);
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
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem15.Text = "Sub Total";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.sePenalties;
            this.layoutControlItem28.CustomizationFormText = "Penalties";
            this.layoutControlItem28.Location = new System.Drawing.Point(425, 73);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem28.Text = "Total Extra";
            this.layoutControlItem28.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.meNote;
            this.layoutControlItem17.CustomizationFormText = "Note";
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 169);
            this.layoutControlItem17.MinSize = new System.Drawing.Size(133, 20);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(850, 361);
            this.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem17.Text = "Note";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.spinEdit1;
            this.layoutControlItem1.CustomizationFormText = "No Of Guest";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem1.Text = "No Of Guest";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinEdit2;
            this.layoutControlItem2.CustomizationFormText = "No Of Room";
            this.layoutControlItem2.Location = new System.Drawing.Point(425, 49);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(425, 24);
            this.layoutControlItem2.Text = "No Of Room";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 13);
            // 
            // Room
            // 
            this.Room.Controls.Add(this.groupBox1);
            this.Room.Controls.Add(this.btnRefreshDetail);
            this.Room.Controls.Add(this.gcData);
            this.Room.Controls.Add(this.simpleButton2);
            this.Room.Controls.Add(this.simpleButton1);
            this.Room.Controls.Add(this.btnEditDetail);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(874, 554);
            this.Room.Text = "Room";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seNoOfGuest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkBreakfast);
            this.groupBox1.Controls.Add(this.luRoomType);
            this.groupBox1.Controls.Add(this.chkExtraBed);
            this.groupBox1.Controls.Add(this.luPriceType);
            this.groupBox1.Controls.Add(this.btnSaveDetail);
            this.groupBox1.Controls.Add(this.deFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.deUntil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.seDurationInHours);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.seDurationInDays);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.luRoomPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 145);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Room";
            // 
            // seNoOfGuest
            // 
            this.seNoOfGuest.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seNoOfGuest.Location = new System.Drawing.Point(514, 84);
            this.seNoOfGuest.MenuManager = this.barManager1;
            this.seNoOfGuest.Name = "seNoOfGuest";
            this.seNoOfGuest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seNoOfGuest.Properties.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.seNoOfGuest.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seNoOfGuest.Size = new System.Drawing.Size(106, 20);
            this.seNoOfGuest.StyleController = this.layoutControl1;
            this.seNoOfGuest.TabIndex = 6;
            this.seNoOfGuest.Enter += new System.EventHandler(this.seNoOfGuest_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Room Type";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.Location = new System.Drawing.Point(88, 114);
            this.chkBreakfast.MenuManager = this.barManager1;
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Properties.Caption = "Breakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(91, 19);
            this.chkBreakfast.StyleController = this.layoutControl1;
            this.chkBreakfast.TabIndex = 8;
            // 
            // luRoomType
            // 
            this.luRoomType.Location = new System.Drawing.Point(8, 41);
            this.luRoomType.MenuManager = this.barManager1;
            this.luRoomType.Name = "luRoomType";
            this.luRoomType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "X", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "btnDelete", null, true)});
            this.luRoomType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.luRoomType.Properties.DisplayMember = "Name";
            this.luRoomType.Properties.NullText = "Choose Item ..";
            this.luRoomType.Properties.ValueMember = "Oid";
            this.luRoomType.Size = new System.Drawing.Size(200, 20);
            this.luRoomType.StyleController = this.layoutControl1;
            this.luRoomType.TabIndex = 1;
            this.luRoomType.Leave += new System.EventHandler(this.luRoomType_Leave);
            // 
            // chkExtraBed
            // 
            this.chkExtraBed.Location = new System.Drawing.Point(7, 114);
            this.chkExtraBed.MaximumSize = new System.Drawing.Size(75, 0);
            this.chkExtraBed.MenuManager = this.barManager1;
            this.chkExtraBed.Name = "chkExtraBed";
            this.chkExtraBed.Properties.Caption = "Extra Bed";
            this.chkExtraBed.Size = new System.Drawing.Size(75, 19);
            this.chkExtraBed.StyleController = this.layoutControl1;
            this.chkExtraBed.TabIndex = 7;
            // 
            // luPriceType
            // 
            this.luPriceType.Location = new System.Drawing.Point(214, 41);
            this.luPriceType.MenuManager = this.barManager1;
            this.luPriceType.Name = "luPriceType";
            this.luPriceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "X", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", "btnDelete", null, true)});
            this.luPriceType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.luPriceType.Properties.DisplayMember = "Name";
            this.luPriceType.Properties.NullText = "Choose Item ..";
            this.luPriceType.Properties.ValueMember = "Oid";
            this.luPriceType.Size = new System.Drawing.Size(200, 20);
            this.luPriceType.StyleController = this.layoutControl1;
            this.luPriceType.TabIndex = 2;
            this.luPriceType.Leave += new System.EventHandler(this.luPriceType_Leave);
            // 
            // btnSaveDetail
            // 
            this.btnSaveDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSaveDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDetail.Image")));
            this.btnSaveDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSaveDetail.Location = new System.Drawing.Point(641, 38);
            this.btnSaveDetail.Name = "btnSaveDetail";
            this.btnSaveDetail.Size = new System.Drawing.Size(108, 66);
            this.btnSaveDetail.TabIndex = 9;
            this.btnSaveDetail.Text = "Save";
            this.btnSaveDetail.Click += new System.EventHandler(this.btnSaveDetail_Click);
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(214, 84);
            this.deFrom.MenuManager = this.barManager1;
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.EditFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.deFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.Mask.EditMask = "dd-MM-yyyy HH:mm";
            this.deFrom.Properties.ReadOnly = true;
            this.deFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFrom.Size = new System.Drawing.Size(145, 20);
            this.deFrom.StyleController = this.layoutControl1;
            this.deFrom.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Duration In Days";
            // 
            // deUntil
            // 
            this.deUntil.EditValue = null;
            this.deUntil.Location = new System.Drawing.Point(365, 84);
            this.deUntil.MenuManager = this.barManager1;
            this.deUntil.Name = "deUntil";
            this.deUntil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deUntil.Properties.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.deUntil.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deUntil.Properties.EditFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.deUntil.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deUntil.Properties.Mask.EditMask = "dd-MM-yyyy HH:mm";
            this.deUntil.Properties.ReadOnly = true;
            this.deUntil.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deUntil.Size = new System.Drawing.Size(143, 20);
            this.deUntil.StyleController = this.layoutControl1;
            this.deUntil.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Duration In Hours";
            // 
            // seDurationInHours
            // 
            this.seDurationInHours.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDurationInHours.Location = new System.Drawing.Point(115, 84);
            this.seDurationInHours.MenuManager = this.barManager1;
            this.seDurationInHours.Name = "seDurationInHours";
            this.seDurationInHours.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seDurationInHours.Properties.Appearance.Options.UseFont = true;
            this.seDurationInHours.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seDurationInHours.Size = new System.Drawing.Size(93, 20);
            this.seDurationInHours.StyleController = this.layoutControl1;
            this.seDurationInHours.TabIndex = 5;
            this.seDurationInHours.EditValueChanged += new System.EventHandler(this.seDurationInHours_EditValueChanged);
            this.seDurationInHours.Enter += new System.EventHandler(this.seDurationInHours_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "From";
            // 
            // seDurationInDays
            // 
            this.seDurationInDays.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDurationInDays.Location = new System.Drawing.Point(9, 84);
            this.seDurationInDays.MenuManager = this.barManager1;
            this.seDurationInDays.Name = "seDurationInDays";
            this.seDurationInDays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seDurationInDays.Properties.Appearance.Options.UseFont = true;
            this.seDurationInDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seDurationInDays.Size = new System.Drawing.Size(100, 20);
            this.seDurationInDays.StyleController = this.layoutControl1;
            this.seDurationInDays.TabIndex = 4;
            this.seDurationInDays.EditValueChanged += new System.EventHandler(this.seDurationInDays_EditValueChanged);
            this.seDurationInDays.Enter += new System.EventHandler(this.seDurationInDays_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "No Of Guest";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Until";
            // 
            // luRoomPrice
            // 
            this.luRoomPrice.Location = new System.Drawing.Point(420, 41);
            this.luRoomPrice.MenuManager = this.barManager1;
            this.luRoomPrice.Name = "luRoomPrice";
            this.luRoomPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "X", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", "btnDelete", null, true)});
            this.luRoomPrice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoomStatus", "RoomStatus")});
            this.luRoomPrice.Properties.DisplayMember = "Name";
            this.luRoomPrice.Properties.NullText = "Choose Item ..";
            this.luRoomPrice.Properties.ValueMember = "Oid";
            this.luRoomPrice.Size = new System.Drawing.Size(200, 20);
            this.luRoomPrice.StyleController = this.layoutControl1;
            this.luRoomPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Price Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Room";
            // 
            // btnRefreshDetail
            // 
            this.btnRefreshDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRefreshDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDetail.Image")));
            this.btnRefreshDetail.Location = new System.Drawing.Point(84, 160);
            this.btnRefreshDetail.Name = "btnRefreshDetail";
            this.btnRefreshDetail.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDetail.TabIndex = 3;
            this.btnRefreshDetail.Text = "Refresh";
            this.btnRefreshDetail.Click += new System.EventHandler(this.btnRefreshDetail_Click);
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.DataSource = this.bsRoom;
            this.gcData.Location = new System.Drawing.Point(3, 189);
            this.gcData.MainView = this.gridView2;
            this.gcData.MenuManager = this.barManager1;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(864, 365);
            this.gcData.TabIndex = 4;
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
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton2.Location = new System.Drawing.Point(693, 160);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(91, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Check Out";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.btnNewDetail_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(790, 160);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEditDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDetail.Image")));
            this.btnEditDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEditDetail.Location = new System.Drawing.Point(3, 160);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(75, 23);
            this.btnEditDetail.TabIndex = 0;
            this.btnEditDetail.Text = "Edit";
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
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
            // frmDlgMasterStay2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 629);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDlgMasterStay2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.frmDlgMasterStay2_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seNoOfGuest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBreakfast.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExtraBed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luPriceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deUntil.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deUntil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDurationInHours.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDurationInDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomPrice.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnNewGuest;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraEditors.LookUpEdit luGuest;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
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
        private DevExpress.XtraEditors.SimpleButton btnSaveDetail;
        private DevExpress.XtraBars.BarButtonItem btnReprint;
        private DevExpress.XtraEditors.LookUpEdit luRoomType;
        private DevExpress.XtraEditors.LookUpEdit luPriceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit luRoomPrice;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SpinEdit seDurationInHours;
        private DevExpress.XtraEditors.SpinEdit seDurationInDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit deFrom;
        private DevExpress.XtraEditors.DateEdit deUntil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.CheckEdit chkExtraBed;
        private DevExpress.XtraEditors.CheckEdit chkBreakfast;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SpinEdit seNoOfGuest;
        private System.Windows.Forms.Label label8;
    }
}