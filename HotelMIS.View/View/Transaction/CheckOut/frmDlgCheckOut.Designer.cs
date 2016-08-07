namespace HotelMIS.View
{
    partial class frmDlgCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgCheckOut));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnProcessCheckout = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sePenalties = new DevExpress.XtraEditors.SpinEdit();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xpLines = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsCheckOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsCheckIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luRoomStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.meNote = new DevExpress.XtraEditors.MemoEdit();
            this.deCheckoutDate = new DevExpress.XtraEditors.DateEdit();
            this.luCheckOutFor = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sePenalties.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xpLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCheckoutDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCheckoutDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luCheckOutFor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
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
            this.btnProcessCheckout});
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnProcessCheckout, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1));
            this.btnSave.Name = "btnSave";
            this.btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancel.Glyph")));
            this.btnCancel.Id = 1;
            this.btnCancel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnProcessCheckout
            // 
            this.btnProcessCheckout.Caption = "Process Checkout";
            this.btnProcessCheckout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProcessCheckout.Glyph")));
            this.btnProcessCheckout.Id = 5;
            this.btnProcessCheckout.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3));
            this.btnProcessCheckout.Name = "btnProcessCheckout";
            this.btnProcessCheckout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProcessCheckout_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 2;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Size = new System.Drawing.Size(584, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(584, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sePenalties);
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Controls.Add(this.luRoomStatus);
            this.layoutControl1.Controls.Add(this.meNote);
            this.layoutControl1.Controls.Add(this.deCheckoutDate);
            this.layoutControl1.Controls.Add(this.luCheckOutFor);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem11});
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1281, 290, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 442);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sePenalties
            // 
            this.sePenalties.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Penalties", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sePenalties.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePenalties.Location = new System.Drawing.Point(86, 60);
            this.sePenalties.MenuManager = this.barManager1;
            this.sePenalties.Name = "sePenalties";
            this.sePenalties.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.sePenalties.Properties.DisplayFormat.FormatString = "#,#";
            this.sePenalties.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePenalties.Properties.EditFormat.FormatString = "#,#";
            this.sePenalties.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePenalties.Size = new System.Drawing.Size(486, 20);
            this.sePenalties.StyleController = this.layoutControl1;
            this.sePenalties.TabIndex = 33;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(185, 134);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xpLines;
            this.xtraTabControl1.Size = new System.Drawing.Size(169, 273);
            this.xtraTabControl1.TabIndex = 31;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xpLines});
            // 
            // xpLines
            // 
            this.xpLines.Controls.Add(this.gridControl1);
            this.xpLines.Name = "xpLines";
            this.xpLines.Size = new System.Drawing.Size(163, 245);
            this.xpLines.Text = "Lines";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.MaximumSize = new System.Drawing.Size(400, 0);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(163, 245);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.IsCheckOut,
            this.IsCheckIn});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.AllowZoomDetail = false;
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
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
            this.gridColumn3.Caption = "CheckOut Status";
            this.gridColumn3.FieldName = "CheckOutStatus";
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
            // luRoomStatus
            // 
            this.luRoomStatus.Location = new System.Drawing.Point(76, 108);
            this.luRoomStatus.MenuManager = this.barManager1;
            this.luRoomStatus.Name = "luRoomStatus";
            this.luRoomStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "X", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "btnDelete", null, true)});
            this.luRoomStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.luRoomStatus.Properties.NullText = "Choose Item ..";
            this.luRoomStatus.Properties.ReadOnly = true;
            this.luRoomStatus.Size = new System.Drawing.Size(496, 20);
            this.luRoomStatus.StyleController = this.layoutControl1;
            this.luRoomStatus.TabIndex = 27;
            // 
            // meNote
            // 
            this.meNote.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Note", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.meNote.Location = new System.Drawing.Point(86, 84);
            this.meNote.MenuManager = this.barManager1;
            this.meNote.Name = "meNote";
            this.meNote.Properties.LinesCount = 3;
            this.meNote.Size = new System.Drawing.Size(486, 346);
            this.meNote.StyleController = this.layoutControl1;
            this.meNote.TabIndex = 24;
            // 
            // deCheckoutDate
            // 
            this.deCheckoutDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "CheckOutDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deCheckoutDate.EditValue = null;
            this.deCheckoutDate.Location = new System.Drawing.Point(86, 36);
            this.deCheckoutDate.MenuManager = this.barManager1;
            this.deCheckoutDate.Name = "deCheckoutDate";
            this.deCheckoutDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCheckoutDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.deCheckoutDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deCheckoutDate.Properties.EditFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.deCheckoutDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deCheckoutDate.Properties.Mask.EditMask = "dd-MM-yyyy HH:mm";
            this.deCheckoutDate.Properties.ReadOnly = true;
            this.deCheckoutDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deCheckoutDate.Size = new System.Drawing.Size(486, 20);
            this.deCheckoutDate.StyleController = this.layoutControl1;
            this.deCheckoutDate.TabIndex = 14;
            // 
            // luCheckOutFor
            // 
            this.luCheckOutFor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "CheckOutForOid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.luCheckOutFor.Location = new System.Drawing.Point(86, 12);
            this.luCheckOutFor.MenuManager = this.barManager1;
            this.luCheckOutFor.Name = "luCheckOutFor";
            this.luCheckOutFor.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.luCheckOutFor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "btnCombo", null, true)});
            this.luCheckOutFor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ToString", "Checkout For")});
            this.luCheckOutFor.Properties.DisplayMember = "ToString";
            this.luCheckOutFor.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch;
            this.luCheckOutFor.Properties.NullText = "Choose Item ..";
            this.luCheckOutFor.Properties.ReadOnly = true;
            this.luCheckOutFor.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.luCheckOutFor.Properties.ValueMember = "Oid";
            this.luCheckOutFor.Size = new System.Drawing.Size(486, 20);
            this.luCheckOutFor.StyleController = this.layoutControl1;
            this.luCheckOutFor.TabIndex = 7;
            this.luCheckOutFor.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ClearComboSelection);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.luRoomStatus;
            this.layoutControlItem5.CustomizationFormText = "Room Status";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem5.Text = "Room Status";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(346, 277);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.xtraTabControl1;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(173, 122);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(173, 277);
            this.layoutControlItem11.Text = "layoutControlItem11";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 0;
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem17,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 442);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.luCheckOutFor;
            this.layoutControlItem4.CustomizationFormText = "Guest";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem4.Text = "Checkout For";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.deCheckoutDate;
            this.layoutControlItem7.CustomizationFormText = "CheckIn Date";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem7.Text = "Checkout Date";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.meNote;
            this.layoutControlItem17.CustomizationFormText = "Note";
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(564, 350);
            this.layoutControlItem17.Text = "Note";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sePenalties;
            this.layoutControlItem6.CustomizationFormText = "Duration In Hours";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem6.Text = "Penalties";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(71, 13);
            // 
            // frmDlgCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 489);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDlgCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Out";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sePenalties.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xpLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCheckoutDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCheckoutDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luCheckOutFor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit luCheckOutFor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraEditors.DateEdit deCheckoutDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraEditors.LookUpEdit luRoomStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarButtonItem btnProcessCheckout;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xpLines;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn IsCheckOut;
        private DevExpress.XtraGrid.Columns.GridColumn IsCheckIn;
        private DevExpress.XtraEditors.SpinEdit sePenalties;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}