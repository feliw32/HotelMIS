namespace HotelMIS.View
{
    partial class frmRoomService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomService));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnFinish = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelRoomService = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.meNote = new DevExpress.XtraEditors.MemoEdit();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.luRoomServiceFor = new DevExpress.XtraEditors.LookUpEdit();
            this.deCompletedTime = new DevExpress.XtraEditors.DateEdit();
            this.luServicePerson = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomServiceFor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCompletedTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCompletedTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luServicePerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.btnSave,
            this.btnCancel,
            this.btnClose,
            this.btnFinish,
            this.btnCancelRoomService});
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnFinish, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelRoomService, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnFinish
            // 
            this.btnFinish.Caption = "Finish Room Service";
            this.btnFinish.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFinish.Glyph")));
            this.btnFinish.Id = 3;
            this.btnFinish.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3));
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFinish_ItemClick);
            // 
            // btnCancelRoomService
            // 
            this.btnCancelRoomService.Caption = "Cancel Room Service";
            this.btnCancelRoomService.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancelRoomService.Glyph")));
            this.btnCancelRoomService.Id = 4;
            this.btnCancelRoomService.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnCancelRoomService.Name = "btnCancelRoomService";
            this.btnCancelRoomService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelRoomService_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(584, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 361);
            this.barDockControlBottom.Size = new System.Drawing.Size(584, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 314);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(584, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 314);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.meNote);
            this.layoutControl1.Controls.Add(this.luRoomServiceFor);
            this.layoutControl1.Controls.Add(this.deCompletedTime);
            this.layoutControl1.Controls.Add(this.luServicePerson);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 314);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // meNote
            // 
            this.meNote.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Note", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.meNote.Location = new System.Drawing.Point(99, 84);
            this.meNote.MenuManager = this.barManager1;
            this.meNote.Name = "meNote";
            this.meNote.Size = new System.Drawing.Size(473, 218);
            this.meNote.StyleController = this.layoutControl1;
            this.meNote.TabIndex = 11;
            // 
            // luRoomServiceFor
            // 
            this.luRoomServiceFor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "RoomServiceForOid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.luRoomServiceFor.Location = new System.Drawing.Point(99, 12);
            this.luRoomServiceFor.MenuManager = this.barManager1;
            this.luRoomServiceFor.Name = "luRoomServiceFor";
            this.luRoomServiceFor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "btnDelete", null, true)});
            this.luRoomServiceFor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ToString", "RoomService For", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.luRoomServiceFor.Properties.DisplayMember = "ToString";
            this.luRoomServiceFor.Properties.NullText = "Choose Item ..";
            this.luRoomServiceFor.Properties.ValueMember = "Oid";
            this.luRoomServiceFor.Size = new System.Drawing.Size(473, 20);
            this.luRoomServiceFor.StyleController = this.layoutControl1;
            this.luRoomServiceFor.TabIndex = 10;
            // 
            // deCompletedTime
            // 
            this.deCompletedTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "CompletedTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deCompletedTime.EditValue = null;
            this.deCompletedTime.Location = new System.Drawing.Point(99, 60);
            this.deCompletedTime.MenuManager = this.barManager1;
            this.deCompletedTime.Name = "deCompletedTime";
            this.deCompletedTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCompletedTime.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy HH:mm";
            this.deCompletedTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deCompletedTime.Properties.EditFormat.FormatString = "dd-MMM-yyyy HH:mm";
            this.deCompletedTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deCompletedTime.Properties.Mask.EditMask = "dd-MMM-yyyy HH:mm";
            this.deCompletedTime.Properties.ReadOnly = true;
            this.deCompletedTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deCompletedTime.Size = new System.Drawing.Size(473, 20);
            this.deCompletedTime.StyleController = this.layoutControl1;
            this.deCompletedTime.TabIndex = 9;
            // 
            // luServicePerson
            // 
            this.luServicePerson.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "ServicePersonOid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.luServicePerson.Location = new System.Drawing.Point(99, 36);
            this.luServicePerson.MenuManager = this.barManager1;
            this.luServicePerson.Name = "luServicePerson";
            this.luServicePerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "X", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", "btnDelete", null, true)});
            this.luServicePerson.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.luServicePerson.Properties.DisplayMember = "Name";
            this.luServicePerson.Properties.NullText = "Choose Item ..";
            this.luServicePerson.Properties.ValueMember = "Oid";
            this.luServicePerson.Size = new System.Drawing.Size(473, 20);
            this.luServicePerson.StyleController = this.layoutControl1;
            this.luServicePerson.TabIndex = 7;
            this.luServicePerson.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ClearComboSelection);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 314);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.luServicePerson;
            this.layoutControlItem4.CustomizationFormText = "Room Type";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem4.Text = "Service Person";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.deCompletedTime;
            this.layoutControlItem1.CustomizationFormText = "Document Date";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem1.Text = "Completed Time";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.meNote;
            this.layoutControlItem3.CustomizationFormText = "Note";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(564, 222);
            this.layoutControlItem3.Text = "Note";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.luRoomServiceFor;
            this.layoutControlItem2.CustomizationFormText = "Stay";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem2.Text = "Room Service For";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 13);
            // 
            // frmRoomService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmRoomService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Service";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luRoomServiceFor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCompletedTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCompletedTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luServicePerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraEditors.LookUpEdit luServicePerson;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit deCompletedTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit luRoomServiceFor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarButtonItem btnFinish;
        private DevExpress.XtraBars.BarButtonItem btnCancelRoomService;
    }
}