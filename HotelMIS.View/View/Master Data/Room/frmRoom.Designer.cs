namespace HotelMIS.View
{
    partial class frmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnMaintenance = new DevExpress.XtraBars.BarButtonItem();
            this.btnAvailable = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMaintenanceStatus = new DevExpress.XtraEditors.TextEdit();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtRoomPrices = new DevExpress.XtraTab.XtraTabPage();
            this.gcRoomPrices = new DevExpress.XtraGrid.GridControl();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PriceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Duration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CurrentPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefreshDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewDetail = new DevExpress.XtraEditors.SimpleButton();
            this.luRoomType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFloor = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaintenanceStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtRoomPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFloor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSave,
            this.btnCancel,
            this.btnClose,
            this.btnMaintenance,
            this.btnAvailable});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMaintenance, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAvailable, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancel.Glyph")));
            this.btnCancel.Id = 1;
            this.btnCancel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Caption = "Maintenance";
            this.btnMaintenance.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMaintenance.Glyph")));
            this.btnMaintenance.Id = 3;
            this.btnMaintenance.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M));
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMaintenance_ItemClick);
            // 
            // btnAvailable
            // 
            this.btnAvailable.Caption = "Available";
            this.btnAvailable.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAvailable.Glyph")));
            this.btnAvailable.Id = 4;
            this.btnAvailable.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAvailable_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 2;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(584, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 338);
            this.barDockControlBottom.Size = new System.Drawing.Size(584, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 291);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(584, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 291);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMaintenanceStatus);
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Controls.Add(this.luRoomType);
            this.layoutControl1.Controls.Add(this.txtFloor);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 291);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMaintenanceStatus
            // 
            this.txtMaintenanceStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "MaintenanceStatus", true));
            this.txtMaintenanceStatus.Location = new System.Drawing.Point(110, 84);
            this.txtMaintenanceStatus.MenuManager = this.barManager1;
            this.txtMaintenanceStatus.Name = "txtMaintenanceStatus";
            this.txtMaintenanceStatus.Properties.ReadOnly = true;
            this.txtMaintenanceStatus.Size = new System.Drawing.Size(462, 20);
            this.txtMaintenanceStatus.StyleController = this.layoutControl1;
            this.txtMaintenanceStatus.TabIndex = 9;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 108);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtRoomPrices;
            this.xtraTabControl1.Size = new System.Drawing.Size(560, 171);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtRoomPrices});
            // 
            // xtRoomPrices
            // 
            this.xtRoomPrices.Controls.Add(this.gcRoomPrices);
            this.xtRoomPrices.Controls.Add(this.btnRefreshDetail);
            this.xtRoomPrices.Controls.Add(this.btnDeleteDetail);
            this.xtRoomPrices.Controls.Add(this.btnEditDetail);
            this.xtRoomPrices.Controls.Add(this.btnNewDetail);
            this.xtRoomPrices.Name = "xtRoomPrices";
            this.xtRoomPrices.Size = new System.Drawing.Size(554, 143);
            this.xtRoomPrices.Text = "Room Prices";
            // 
            // gcRoomPrices
            // 
            this.gcRoomPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRoomPrices.DataSource = this.bsDetail;
            this.gcRoomPrices.Location = new System.Drawing.Point(3, 29);
            this.gcRoomPrices.MainView = this.gridView1;
            this.gcRoomPrices.MenuManager = this.barManager1;
            this.gcRoomPrices.Name = "gcRoomPrices";
            this.gcRoomPrices.Size = new System.Drawing.Size(548, 113);
            this.gcRoomPrices.TabIndex = 1;
            this.gcRoomPrices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PriceType,
            this.Duration,
            this.CurrentPrice});
            this.gridView1.GridControl = this.gcRoomPrices;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            // 
            // PriceType
            // 
            this.PriceType.Caption = "Price Type";
            this.PriceType.FieldName = "PriceType.Name";
            this.PriceType.Name = "PriceType";
            this.PriceType.Visible = true;
            this.PriceType.VisibleIndex = 0;
            // 
            // Duration
            // 
            this.Duration.Caption = "Duration";
            this.Duration.FieldName = "PriceType.Duration";
            this.Duration.Name = "Duration";
            this.Duration.Visible = true;
            this.Duration.VisibleIndex = 1;
            // 
            // CurrentPrice
            // 
            this.CurrentPrice.Caption = "Current Price";
            this.CurrentPrice.DisplayFormat.FormatString = "#,#";
            this.CurrentPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CurrentPrice.FieldName = "PriceType.CurrentPrice";
            this.CurrentPrice.Name = "CurrentPrice";
            this.CurrentPrice.Visible = true;
            this.CurrentPrice.VisibleIndex = 2;
            // 
            // btnRefreshDetail
            // 
            this.btnRefreshDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRefreshDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDetail.Image")));
            this.btnRefreshDetail.Location = new System.Drawing.Point(231, 3);
            this.btnRefreshDetail.Name = "btnRefreshDetail";
            this.btnRefreshDetail.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDetail.TabIndex = 0;
            this.btnRefreshDetail.Text = "Refresh";
            this.btnRefreshDetail.Click += new System.EventHandler(this.btnRefreshDetail_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDeleteDetail.Enabled = false;
            this.btnDeleteDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDetail.Image")));
            this.btnDeleteDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDeleteDetail.Location = new System.Drawing.Point(155, 3);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDetail.TabIndex = 0;
            this.btnDeleteDetail.Text = "Delete";
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEditDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDetail.Image")));
            this.btnEditDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEditDetail.Location = new System.Drawing.Point(79, 3);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(75, 23);
            this.btnEditDetail.TabIndex = 0;
            this.btnEditDetail.Text = "Edit";
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // btnNewDetail
            // 
            this.btnNewDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNewDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDetail.Image")));
            this.btnNewDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewDetail.Location = new System.Drawing.Point(3, 3);
            this.btnNewDetail.Name = "btnNewDetail";
            this.btnNewDetail.Size = new System.Drawing.Size(75, 23);
            this.btnNewDetail.TabIndex = 0;
            this.btnNewDetail.Text = "New";
            this.btnNewDetail.Click += new System.EventHandler(this.btnNewDetail_Click);
            // 
            // luRoomType
            // 
            this.luRoomType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "RoomTypeOid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.luRoomType.Location = new System.Drawing.Point(110, 60);
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
            this.luRoomType.Size = new System.Drawing.Size(462, 20);
            this.luRoomType.StyleController = this.layoutControl1;
            this.luRoomType.TabIndex = 7;
            this.luRoomType.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ClearComboSelection);
            // 
            // txtFloor
            // 
            this.txtFloor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Floor", true));
            this.txtFloor.Location = new System.Drawing.Point(392, 36);
            this.txtFloor.MenuManager = this.barManager1;
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(180, 20);
            this.txtFloor.StyleController = this.layoutControl1;
            this.txtFloor.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Name", true));
            this.txtName.Location = new System.Drawing.Point(110, 36);
            this.txtName.MenuManager = this.barManager1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(110, 12);
            this.txtCode.MenuManager = this.barManager1;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(462, 20);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 291);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCode;
            this.layoutControlItem1.CustomizationFormText = "Code";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem1.Text = "Code";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.CustomizationFormText = "Name";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem2.Text = "Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.luRoomType;
            this.layoutControlItem4.CustomizationFormText = "Room Type";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem4.Text = "Room Type";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtFloor;
            this.layoutControlItem3.CustomizationFormText = "Floor";
            this.layoutControlItem3.Location = new System.Drawing.Point(282, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem3.Text = "Floor";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.xtraTabControl1;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(564, 175);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtMaintenanceStatus;
            this.layoutControlItem6.CustomizationFormText = "Maintenance Status";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem6.Text = "Maintenance Status";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(95, 13);
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaintenanceStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtRoomPrices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFloor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtFloor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit luRoomType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraTab.XtraTabPage xtRoomPrices;
        private DevExpress.XtraEditors.SimpleButton btnDeleteDetail;
        private DevExpress.XtraEditors.SimpleButton btnEditDetail;
        private DevExpress.XtraEditors.SimpleButton btnNewDetail;
        private DevExpress.XtraEditors.SimpleButton btnRefreshDetail;
        private DevExpress.XtraGrid.GridControl gcRoomPrices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn PriceType;
        private DevExpress.XtraGrid.Columns.GridColumn Duration;
        private DevExpress.XtraGrid.Columns.GridColumn CurrentPrice;
        private System.Windows.Forms.BindingSource bsDetail;
        private DevExpress.XtraBars.BarButtonItem btnMaintenance;
        private DevExpress.XtraBars.BarButtonItem btnAvailable;
        private DevExpress.XtraEditors.TextEdit txtMaintenanceStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}