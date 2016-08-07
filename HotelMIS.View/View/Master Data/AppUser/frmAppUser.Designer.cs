namespace HotelMIS.View
{
    partial class frmAppUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppUser));
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
            this.deDateOfBirth = new DevExpress.XtraEditors.DateEdit();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.meAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtBirthPlace = new DevExpress.XtraEditors.TextEdit();
            this.luUserRole = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtSSID = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luUserRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSSID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
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
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancel.Glyph")));
            this.btnCancel.Id = 1;
            this.btnCancel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 2;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3));
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
            this.layoutControl1.Controls.Add(this.deDateOfBirth);
            this.layoutControl1.Controls.Add(this.meAddress);
            this.layoutControl1.Controls.Add(this.txtBirthPlace);
            this.layoutControl1.Controls.Add(this.luUserRole);
            this.layoutControl1.Controls.Add(this.txtPhoneNumber);
            this.layoutControl1.Controls.Add(this.txtSSID);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(937, 151, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 291);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // deDateOfBirth
            // 
            this.deDateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "DateOfBirth", true));
            this.deDateOfBirth.EditValue = null;
            this.deDateOfBirth.Location = new System.Drawing.Point(85, 84);
            this.deDateOfBirth.MenuManager = this.barManager1;
            this.deDateOfBirth.Name = "deDateOfBirth";
            this.deDateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateOfBirth.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDateOfBirth.Size = new System.Drawing.Size(205, 20);
            this.deDateOfBirth.StyleController = this.layoutControl1;
            this.deDateOfBirth.TabIndex = 12;
            // 
            // meAddress
            // 
            this.meAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Address", true));
            this.meAddress.Location = new System.Drawing.Point(85, 156);
            this.meAddress.MenuManager = this.barManager1;
            this.meAddress.Name = "meAddress";
            this.meAddress.Size = new System.Drawing.Size(487, 123);
            this.meAddress.StyleController = this.layoutControl1;
            this.meAddress.TabIndex = 11;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "BirthPlace", true));
            this.txtBirthPlace.Location = new System.Drawing.Point(367, 84);
            this.txtBirthPlace.MenuManager = this.barManager1;
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(205, 20);
            this.txtBirthPlace.StyleController = this.layoutControl1;
            this.txtBirthPlace.TabIndex = 10;
            // 
            // luUserRole
            // 
            this.luUserRole.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "UserRoleOid", true));
            this.luUserRole.Location = new System.Drawing.Point(85, 108);
            this.luUserRole.MenuManager = this.barManager1;
            this.luUserRole.Name = "luUserRole";
            this.luUserRole.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.luUserRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "btnCombo", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "X", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "btnDelete", null, true)});
            this.luUserRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.luUserRole.Properties.DisplayMember = "Name";
            this.luUserRole.Properties.NullText = "Choose Item ..";
            this.luUserRole.Properties.ValueMember = "Oid";
            this.luUserRole.Properties.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ClearComboSelection);
            this.luUserRole.Size = new System.Drawing.Size(487, 20);
            this.luUserRole.StyleController = this.layoutControl1;
            this.luUserRole.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "PhoneNumber", true));
            this.txtPhoneNumber.Location = new System.Drawing.Point(85, 132);
            this.txtPhoneNumber.MenuManager = this.barManager1;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(487, 20);
            this.txtPhoneNumber.StyleController = this.layoutControl1;
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // txtSSID
            // 
            this.txtSSID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "SSID", true));
            this.txtSSID.Location = new System.Drawing.Point(85, 36);
            this.txtSSID.MenuManager = this.barManager1;
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(487, 20);
            this.txtSSID.StyleController = this.layoutControl1;
            this.txtSSID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Name", true));
            this.txtName.Location = new System.Drawing.Point(85, 60);
            this.txtName.MenuManager = this.barManager1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(487, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(85, 12);
            this.txtCode.MenuManager = this.barManager1;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(487, 20);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 291);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtPhoneNumber;
            this.layoutControlItem4.CustomizationFormText = "Phone Number";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem4.Text = "Phone Number";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCode;
            this.layoutControlItem1.CustomizationFormText = "Code";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem1.Text = "Code";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.CustomizationFormText = "Name";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem2.Text = "Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.luUserRole;
            this.layoutControlItem6.CustomizationFormText = "Identification Type";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem6.Text = "User Role";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.meAddress;
            this.layoutControlItem8.CustomizationFormText = "Address";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(564, 127);
            this.layoutControlItem8.Text = "Address";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtSSID;
            this.layoutControlItem3.CustomizationFormText = "SSID";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem3.Text = "SSID";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtBirthPlace;
            this.layoutControlItem5.CustomizationFormText = "Birth Place";
            this.layoutControlItem5.Location = new System.Drawing.Point(282, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem5.Text = "Birth Place";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.deDateOfBirth;
            this.layoutControlItem9.CustomizationFormText = "Date Of Birth";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem9.Text = "Date Of Birth";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.luUserRole;
            this.layoutControlItem7.CustomizationFormText = "Identification Type";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem7.Name = "layoutControlItem6";
            this.layoutControlItem7.Size = new System.Drawing.Size(564, 152);
            this.layoutControlItem7.Text = "Identification Type";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(90, 13);
            this.layoutControlItem7.TextToControlDistance = 5;
            // 
            // frmAppUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmAppUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppUser";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luUserRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSSID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtSSID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LookUpEdit luUserRole;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.DateEdit deDateOfBirth;
        private DevExpress.XtraEditors.MemoEdit meAddress;
        private DevExpress.XtraEditors.TextEdit txtBirthPlace;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}