namespace HotelMIS.View
{
    partial class frmListMasterStay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListMasterStay));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Oid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountByAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountByPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Guest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuestName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalExtraCharge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalDeposit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoOfRoom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PenaltiesCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnReports = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckout = new DevExpress.XtraEditors.SimpleButton();
            this.dtHistory = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFixRoom = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnFix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.btnNew,
            this.btnClose,
            this.btnEdit,
            this.btnRefresh});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNew.Glyph")));
            this.btnNew.Id = 0;
            this.btnNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1));
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.Glyph")));
            this.btnEdit.Id = 3;
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 4;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 2;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(954, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 530);
            this.barDockControlBottom.Size = new System.Drawing.Size(954, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 483);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(954, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 483);
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.DataSource = this.bs;
            this.gcData.Location = new System.Drawing.Point(12, 56);
            this.gcData.MainView = this.gridView1;
            this.gcData.MenuManager = this.barManager1;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(930, 415);
            this.gcData.TabIndex = 0;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Oid,
            this.DiscountByAmount,
            this.DiscountByPercent,
            this.Guest,
            this.GuestName,
            this.CheckOut,
            this.Note,
            this.SubTotal,
            this.Total,
            this.UserCreated,
            this.DateCreated,
            this.UserUpdated,
            this.DateUpdated,
            this.Status,
            this.TotalPaid,
            this.TotalExtraCharge,
            this.TotalDeposit,
            this.NoOfRoom,
            this.PenaltiesCost,
            this.CheckIn});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(519, 490, 216, 190);
            this.gridView1.GridControl = this.gcData;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // Oid
            // 
            this.Oid.Caption = "Oid";
            this.Oid.FieldName = "Oid";
            this.Oid.Name = "Oid";
            // 
            // DiscountByAmount
            // 
            this.DiscountByAmount.Caption = "Discount By Amount";
            this.DiscountByAmount.FieldName = "DiscountByAmount";
            this.DiscountByAmount.Name = "DiscountByAmount";
            // 
            // DiscountByPercent
            // 
            this.DiscountByPercent.Caption = "Discount By Percent";
            this.DiscountByPercent.FieldName = "DiscountByPercent";
            this.DiscountByPercent.Name = "DiscountByPercent";
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
            this.GuestName.FieldName = "Guest.Name";
            this.GuestName.Name = "GuestName";
            this.GuestName.Visible = true;
            this.GuestName.VisibleIndex = 0;
            this.GuestName.Width = 58;
            // 
            // CheckOut
            // 
            this.CheckOut.Caption = "Check Out";
            this.CheckOut.FieldName = "CheckOut";
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Visible = true;
            this.CheckOut.VisibleIndex = 2;
            this.CheckOut.Width = 150;
            // 
            // Note
            // 
            this.Note.Caption = "Note";
            this.Note.FieldName = "Note";
            this.Note.Name = "Note";
            this.Note.Visible = true;
            this.Note.VisibleIndex = 4;
            this.Note.Width = 46;
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
            this.Total.VisibleIndex = 5;
            this.Total.Width = 46;
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
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 10;
            this.Status.Width = 55;
            // 
            // TotalPaid
            // 
            this.TotalPaid.Caption = "Total Paid";
            this.TotalPaid.DisplayFormat.FormatString = "#,#";
            this.TotalPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPaid.FieldName = "TotalPaid";
            this.TotalPaid.GroupFormat.FormatString = "#,#";
            this.TotalPaid.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPaid.Name = "TotalPaid";
            this.TotalPaid.Visible = true;
            this.TotalPaid.VisibleIndex = 9;
            this.TotalPaid.Width = 46;
            // 
            // TotalExtraCharge
            // 
            this.TotalExtraCharge.Caption = "Total Extra";
            this.TotalExtraCharge.DisplayFormat.FormatString = "#,#";
            this.TotalExtraCharge.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalExtraCharge.FieldName = "TotalExtraCharge";
            this.TotalExtraCharge.GroupFormat.FormatString = "#,#";
            this.TotalExtraCharge.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalExtraCharge.Name = "TotalExtraCharge";
            this.TotalExtraCharge.Visible = true;
            this.TotalExtraCharge.VisibleIndex = 6;
            this.TotalExtraCharge.Width = 46;
            // 
            // TotalDeposit
            // 
            this.TotalDeposit.Caption = "Total Deposit";
            this.TotalDeposit.DisplayFormat.FormatString = "#,#";
            this.TotalDeposit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalDeposit.FieldName = "TotalDeposit";
            this.TotalDeposit.Name = "TotalDeposit";
            this.TotalDeposit.Visible = true;
            this.TotalDeposit.VisibleIndex = 8;
            this.TotalDeposit.Width = 46;
            // 
            // NoOfRoom
            // 
            this.NoOfRoom.Caption = "No Of Room";
            this.NoOfRoom.FieldName = "NoOfRoom";
            this.NoOfRoom.Name = "NoOfRoom";
            this.NoOfRoom.Visible = true;
            this.NoOfRoom.VisibleIndex = 3;
            this.NoOfRoom.Width = 46;
            // 
            // PenaltiesCost
            // 
            this.PenaltiesCost.Caption = "Penalties Cost";
            this.PenaltiesCost.DisplayFormat.FormatString = "#,#.##";
            this.PenaltiesCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PenaltiesCost.FieldName = "PenaltiesCost";
            this.PenaltiesCost.Name = "PenaltiesCost";
            this.PenaltiesCost.Visible = true;
            this.PenaltiesCost.VisibleIndex = 7;
            this.PenaltiesCost.Width = 46;
            // 
            // CheckIn
            // 
            this.CheckIn.Caption = "Check In";
            this.CheckIn.FieldName = "CheckIn";
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Visible = true;
            this.CheckIn.VisibleIndex = 1;
            this.CheckIn.Width = 58;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.gcData);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(954, 483);
            this.layoutControl1.TabIndex = 17;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFix);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtFixRoom);
            this.panelControl1.Controls.Add(this.btnReports);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnCheckout);
            this.panelControl1.Controls.Add(this.dtHistory);
            this.panelControl1.Controls.Add(this.cboStatus);
            this.panelControl1.Controls.Add(this.btnFilter);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.MaximumSize = new System.Drawing.Size(0, 40);
            this.panelControl1.MinimumSize = new System.Drawing.Size(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(930, 40);
            this.panelControl1.TabIndex = 10;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(212, 11);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(97, 23);
            this.btnReports.TabIndex = 26;
            this.btnReports.Text = "REPORTS";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(989, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel History";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(886, 11);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(97, 23);
            this.btnCheckout.TabIndex = 25;
            this.btnCheckout.Text = "Checkout History";
            this.btnCheckout.Visible = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // dtHistory
            // 
            this.dtHistory.CustomFormat = "dd/MM/yyyy";
            this.dtHistory.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHistory.Location = new System.Drawing.Point(1092, 11);
            this.dtHistory.Name = "dtHistory";
            this.dtHistory.Size = new System.Drawing.Size(94, 20);
            this.dtHistory.TabIndex = 24;
            this.dtHistory.Visible = false;
            // 
            // cboStatus
            // 
            this.cboStatus.EditValue = "Entry";
            this.cboStatus.Location = new System.Drawing.Point(5, 14);
            this.cboStatus.MenuManager = this.barManager1;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "btnCombo", null, true)});
            this.cboStatus.Properties.Items.AddRange(new object[] {
            "Entry",
            "Processed",
            "Cancel",
            "All"});
            this.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStatus.Size = new System.Drawing.Size(120, 20);
            this.cboStatus.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(131, 11);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Status";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(954, 483);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcData;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(934, 419);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(934, 44);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // txtFixRoom
            // 
            this.txtFixRoom.Location = new System.Drawing.Point(376, 12);
            this.txtFixRoom.Name = "txtFixRoom";
            this.txtFixRoom.Size = new System.Drawing.Size(100, 20);
            this.txtFixRoom.TabIndex = 27;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(327, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Fix Room";
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(481, 11);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 29;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // frmListMasterStay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 530);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmListMasterStay";
            this.Text = "Check In";
            this.Activated += new System.EventHandler(this.frmListStay_Activated);
            this.Load += new System.EventHandler(this.frmListStay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Oid;
        private DevExpress.XtraGrid.Columns.GridColumn Guest;
        private DevExpress.XtraGrid.Columns.GridColumn UserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn DateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn UserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn DateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn GuestName;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountByAmount;
        private DevExpress.XtraGrid.Columns.GridColumn CheckOut;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private DevExpress.XtraGrid.Columns.GridColumn SubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.ComboBoxEdit cboStatus;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPaid;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountByPercent;
        private DevExpress.XtraGrid.Columns.GridColumn TotalExtraCharge;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDeposit;
        private DevExpress.XtraGrid.Columns.GridColumn NoOfRoom;
        private DevExpress.XtraGrid.Columns.GridColumn PenaltiesCost;
        private DevExpress.XtraGrid.Columns.GridColumn CheckIn;
        private System.Windows.Forms.DateTimePicker dtHistory;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnCheckout;
        private DevExpress.XtraEditors.SimpleButton btnReports;
        private System.Windows.Forms.Button btnFix;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtFixRoom;
    }
}