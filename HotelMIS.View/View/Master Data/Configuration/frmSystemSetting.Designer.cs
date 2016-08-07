namespace HotelMIS.View
{
    partial class frmSystemSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemSetting));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.luRoomServiceRole = new DevExpress.XtraEditors.LookUpEdit();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.seControlBoardDays = new DevExpress.XtraEditors.SpinEdit();
            this.seExtraBedPrice = new DevExpress.XtraEditors.SpinEdit();
            this.seBreakfastPrice = new DevExpress.XtraEditors.SpinEdit();
            this.seDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.seDaysForDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomServiceRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seControlBoardDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seExtraBedPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBreakfastPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDaysForDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
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
            this.btnClose});
            this.barManager1.MaxItemId = 3;
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
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveSystemSetting_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancel.Glyph")));
            this.btnCancel.Id = 1;
            this.btnCancel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelSystemSetting_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 2;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3));
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
            this.barDockControlTop.Size = new System.Drawing.Size(685, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 507);
            this.barDockControlBottom.Size = new System.Drawing.Size(685, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 460);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(685, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 460);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.luRoomServiceRole);
            this.layoutControl1.Controls.Add(this.seControlBoardDays);
            this.layoutControl1.Controls.Add(this.seExtraBedPrice);
            this.layoutControl1.Controls.Add(this.seBreakfastPrice);
            this.layoutControl1.Controls.Add(this.seDiscount);
            this.layoutControl1.Controls.Add(this.seDaysForDiscount);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(685, 460);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // luRoomServiceRole
            // 
            this.luRoomServiceRole.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "RoomServiceRoleOid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.luRoomServiceRole.Location = new System.Drawing.Point(440, 36);
            this.luRoomServiceRole.MenuManager = this.barManager1;
            this.luRoomServiceRole.Name = "luRoomServiceRole";
            this.luRoomServiceRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "X", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "btnDelete", null, true)});
            this.luRoomServiceRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.luRoomServiceRole.Properties.DisplayMember = "Name";
            this.luRoomServiceRole.Properties.NullText = "Choose Item ..";
            this.luRoomServiceRole.Properties.ValueMember = "Oid";
            this.luRoomServiceRole.Size = new System.Drawing.Size(233, 20);
            this.luRoomServiceRole.StyleController = this.layoutControl1;
            this.luRoomServiceRole.TabIndex = 11;
            // 
            // seControlBoardDays
            // 
            this.seControlBoardDays.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "ControlBoardDays", true));
            this.seControlBoardDays.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seControlBoardDays.Location = new System.Drawing.Point(108, 84);
            this.seControlBoardDays.MenuManager = this.barManager1;
            this.seControlBoardDays.Name = "seControlBoardDays";
            this.seControlBoardDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seControlBoardDays.Size = new System.Drawing.Size(232, 20);
            this.seControlBoardDays.StyleController = this.layoutControl1;
            this.seControlBoardDays.TabIndex = 8;
            // 
            // seExtraBedPrice
            // 
            this.seExtraBedPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "ExtraBedPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seExtraBedPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seExtraBedPrice.Location = new System.Drawing.Point(108, 60);
            this.seExtraBedPrice.MenuManager = this.barManager1;
            this.seExtraBedPrice.Name = "seExtraBedPrice";
            this.seExtraBedPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seExtraBedPrice.Size = new System.Drawing.Size(232, 20);
            this.seExtraBedPrice.StyleController = this.layoutControl1;
            this.seExtraBedPrice.TabIndex = 7;
            // 
            // seBreakfastPrice
            // 
            this.seBreakfastPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "BreakfastPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seBreakfastPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seBreakfastPrice.Location = new System.Drawing.Point(108, 36);
            this.seBreakfastPrice.MenuManager = this.barManager1;
            this.seBreakfastPrice.Name = "seBreakfastPrice";
            this.seBreakfastPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seBreakfastPrice.Size = new System.Drawing.Size(232, 20);
            this.seBreakfastPrice.StyleController = this.layoutControl1;
            this.seBreakfastPrice.TabIndex = 6;
            // 
            // seDiscount
            // 
            this.seDiscount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Discount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDiscount.Location = new System.Drawing.Point(440, 12);
            this.seDiscount.MenuManager = this.barManager1;
            this.seDiscount.Name = "seDiscount";
            this.seDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seDiscount.Size = new System.Drawing.Size(233, 20);
            this.seDiscount.StyleController = this.layoutControl1;
            this.seDiscount.TabIndex = 5;
            // 
            // seDaysForDiscount
            // 
            this.seDaysForDiscount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "DaysForDiscount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seDaysForDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDaysForDiscount.Location = new System.Drawing.Point(108, 12);
            this.seDaysForDiscount.MenuManager = this.barManager1;
            this.seDaysForDiscount.Name = "seDaysForDiscount";
            this.seDaysForDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seDaysForDiscount.Size = new System.Drawing.Size(232, 20);
            this.seDaysForDiscount.StyleController = this.layoutControl1;
            this.seDaysForDiscount.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(685, 460);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.seDaysForDiscount;
            this.layoutControlItem1.CustomizationFormText = "Days For Discount";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem1.Text = "Days For Discount";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.seDiscount;
            this.layoutControlItem2.CustomizationFormText = "Discount";
            this.layoutControlItem2.Location = new System.Drawing.Point(332, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(333, 24);
            this.layoutControlItem2.Text = "Discount";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.seBreakfastPrice;
            this.layoutControlItem3.CustomizationFormText = "Breakfast Price";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem3.Text = "Breakfast Price";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.seControlBoardDays;
            this.layoutControlItem5.CustomizationFormText = "Control Board Days";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(332, 368);
            this.layoutControlItem5.Text = "Control Board Days";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.seExtraBedPrice;
            this.layoutControlItem4.CustomizationFormText = "ExtraBed Price";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem4.Text = "ExtraBed Price";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.luRoomServiceRole;
            this.layoutControlItem8.CustomizationFormText = "Room Service Role";
            this.layoutControlItem8.Location = new System.Drawing.Point(332, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(333, 416);
            this.layoutControlItem8.Text = "Room Service Role";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(93, 13);
            // 
            // frmSystemSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 530);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSystemSetting";
            this.Text = "System Setting";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luRoomServiceRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seControlBoardDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seExtraBedPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBreakfastPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDaysForDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
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
        private DevExpress.XtraEditors.SpinEdit seDiscount;
        private DevExpress.XtraEditors.SpinEdit seDaysForDiscount;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraEditors.SpinEdit seExtraBedPrice;
        private DevExpress.XtraEditors.SpinEdit seBreakfastPrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SpinEdit seControlBoardDays;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LookUpEdit luRoomServiceRole;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}