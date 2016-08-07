﻿namespace HotelMIS.View
{
    partial class frmReportParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportParameter));
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
            this.chkNotActive = new DevExpress.XtraEditors.CheckEdit();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.txtFieldName = new DevExpress.XtraEditors.TextEdit();
            this.seSequence = new DevExpress.XtraEditors.SpinEdit();
            this.txtDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.txtParameter = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNotActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSequence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.chkNotActive);
            this.layoutControl1.Controls.Add(this.txtFieldName);
            this.layoutControl1.Controls.Add(this.seSequence);
            this.layoutControl1.Controls.Add(this.txtDisplayName);
            this.layoutControl1.Controls.Add(this.txtParameter);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 291);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkNotActive
            // 
            this.chkNotActive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "NotActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNotActive.Location = new System.Drawing.Point(294, 60);
            this.chkNotActive.MenuManager = this.barManager1;
            this.chkNotActive.Name = "chkNotActive";
            this.chkNotActive.Properties.Caption = "Not Active";
            this.chkNotActive.Size = new System.Drawing.Size(278, 19);
            this.chkNotActive.StyleController = this.layoutControl1;
            this.chkNotActive.TabIndex = 8;
            // 
            // txtFieldName
            // 
            this.txtFieldName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "FieldName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFieldName.Location = new System.Drawing.Point(361, 36);
            this.txtFieldName.MenuManager = this.barManager1;
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(211, 20);
            this.txtFieldName.StyleController = this.layoutControl1;
            this.txtFieldName.TabIndex = 7;
            // 
            // seSequence
            // 
            this.seSequence.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Sequence", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.seSequence.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSequence.Location = new System.Drawing.Point(79, 12);
            this.seSequence.MenuManager = this.barManager1;
            this.seSequence.Name = "seSequence";
            this.seSequence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seSequence.Size = new System.Drawing.Size(493, 20);
            this.seSequence.StyleController = this.layoutControl1;
            this.seSequence.TabIndex = 6;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DisplayName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDisplayName.Location = new System.Drawing.Point(79, 60);
            this.txtDisplayName.MenuManager = this.barManager1;
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(211, 20);
            this.txtDisplayName.StyleController = this.layoutControl1;
            this.txtDisplayName.TabIndex = 5;
            // 
            // txtParameter
            // 
            this.txtParameter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Parameter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtParameter.Location = new System.Drawing.Point(79, 36);
            this.txtParameter.MenuManager = this.barManager1;
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(211, 20);
            this.txtParameter.StyleController = this.layoutControl1;
            this.txtParameter.TabIndex = 4;
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
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 291);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtParameter;
            this.layoutControlItem1.CustomizationFormText = "Code";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem1.Text = "Parameter";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDisplayName;
            this.layoutControlItem2.CustomizationFormText = "Name";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(282, 223);
            this.layoutControlItem2.Text = "Display Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.seSequence;
            this.layoutControlItem3.CustomizationFormText = "Sequence";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem3.Text = "Sequence";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtFieldName;
            this.layoutControlItem4.CustomizationFormText = "Field Name";
            this.layoutControlItem4.Location = new System.Drawing.Point(282, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem4.Text = "Field Name";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkNotActive;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(282, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(282, 223);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmReportParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmReportParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Parameter";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkNotActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSequence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtDisplayName;
        private DevExpress.XtraEditors.TextEdit txtParameter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.CheckEdit chkNotActive;
        private DevExpress.XtraEditors.TextEdit txtFieldName;
        private DevExpress.XtraEditors.SpinEdit seSequence;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}