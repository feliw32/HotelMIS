namespace HotelMIS.View
{
    partial class frmReportDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportDesign));
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
            this.xtcReportParameter = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnRefreshDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewDetail = new DevExpress.XtraEditors.SimpleButton();
            this.gcReportParameters = new DevExpress.XtraGrid.GridControl();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sequence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Parameter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NotActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.meQuery = new DevExpress.XtraEditors.MemoEdit();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.txtReportFile = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcReportParameter)).BeginInit();
            this.xtcReportParameter.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReportFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.xtcReportParameter);
            this.layoutControl1.Controls.Add(this.meQuery);
            this.layoutControl1.Controls.Add(this.txtReportFile);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1030, 490, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 291);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xtcReportParameter
            // 
            this.xtcReportParameter.Location = new System.Drawing.Point(12, 104);
            this.xtcReportParameter.Name = "xtcReportParameter";
            this.xtcReportParameter.SelectedTabPage = this.xtraTabPage2;
            this.xtcReportParameter.Size = new System.Drawing.Size(560, 175);
            this.xtcReportParameter.TabIndex = 12;
            this.xtcReportParameter.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnRefreshDetail);
            this.xtraTabPage2.Controls.Add(this.btnDeleteDetail);
            this.xtraTabPage2.Controls.Add(this.btnEditDetail);
            this.xtraTabPage2.Controls.Add(this.btnNewDetail);
            this.xtraTabPage2.Controls.Add(this.gcReportParameters);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(554, 149);
            this.xtraTabPage2.Text = "Report Parameters";
            // 
            // btnRefreshDetail
            // 
            this.btnRefreshDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRefreshDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDetail.Image")));
            this.btnRefreshDetail.Location = new System.Drawing.Point(231, 3);
            this.btnRefreshDetail.Name = "btnRefreshDetail";
            this.btnRefreshDetail.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDetail.TabIndex = 9;
            this.btnRefreshDetail.Text = "Refresh";
            this.btnRefreshDetail.Click += new System.EventHandler(this.btnRefreshDetail_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDeleteDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDetail.Image")));
            this.btnDeleteDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDeleteDetail.Location = new System.Drawing.Point(155, 3);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDetail.TabIndex = 10;
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
            this.btnEditDetail.TabIndex = 7;
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
            this.btnNewDetail.TabIndex = 8;
            this.btnNewDetail.Text = "New";
            this.btnNewDetail.Click += new System.EventHandler(this.btnNewDetail_Click);
            // 
            // gcReportParameters
            // 
            this.gcReportParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcReportParameters.DataSource = this.bsDetail;
            this.gcReportParameters.Location = new System.Drawing.Point(3, 30);
            this.gcReportParameters.MainView = this.gridView1;
            this.gcReportParameters.MenuManager = this.barManager1;
            this.gcReportParameters.Name = "gcReportParameters";
            this.gcReportParameters.Size = new System.Drawing.Size(548, 168);
            this.gcReportParameters.TabIndex = 6;
            this.gcReportParameters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sequence,
            this.Parameter,
            this.FieldName,
            this.NotActive});
            this.gridView1.GridControl = this.gcReportParameters;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            // 
            // Sequence
            // 
            this.Sequence.Caption = "Sequence";
            this.Sequence.FieldName = "Sequence";
            this.Sequence.Name = "Sequence";
            this.Sequence.Visible = true;
            this.Sequence.VisibleIndex = 0;
            // 
            // Parameter
            // 
            this.Parameter.Caption = "Parameter";
            this.Parameter.FieldName = "Parameter";
            this.Parameter.Name = "Parameter";
            this.Parameter.Visible = true;
            this.Parameter.VisibleIndex = 1;
            // 
            // FieldName
            // 
            this.FieldName.Caption = "Field Name";
            this.FieldName.FieldName = "FieldName";
            this.FieldName.Name = "FieldName";
            this.FieldName.Visible = true;
            this.FieldName.VisibleIndex = 2;
            // 
            // NotActive
            // 
            this.NotActive.Caption = "Not Active";
            this.NotActive.FieldName = "NotActive";
            this.NotActive.Name = "NotActive";
            this.NotActive.Visible = true;
            this.NotActive.VisibleIndex = 3;
            // 
            // meQuery
            // 
            this.meQuery.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Query", true));
            this.meQuery.Location = new System.Drawing.Point(67, 84);
            this.meQuery.MenuManager = this.barManager1;
            this.meQuery.Name = "meQuery";
            this.meQuery.Size = new System.Drawing.Size(505, 16);
            this.meQuery.StyleController = this.layoutControl1;
            this.meQuery.TabIndex = 11;
            // 
            // txtReportFile
            // 
            this.txtReportFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "ReportFile", true));
            this.txtReportFile.Location = new System.Drawing.Point(67, 60);
            this.txtReportFile.MenuManager = this.barManager1;
            this.txtReportFile.Name = "txtReportFile";
            this.txtReportFile.Size = new System.Drawing.Size(505, 20);
            this.txtReportFile.StyleController = this.layoutControl1;
            this.txtReportFile.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Name", true));
            this.txtName.Location = new System.Drawing.Point(67, 36);
            this.txtName.MenuManager = this.barManager1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(505, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(67, 12);
            this.txtCode.MenuManager = this.barManager1;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(505, 20);
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
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem8});
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
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.CustomizationFormText = "Name";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem2.Text = "Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtReportFile;
            this.layoutControlItem5.CustomizationFormText = "Birth Place";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem5.Text = "Report File";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.xtcReportParameter;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(564, 179);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.meQuery;
            this.layoutControlItem8.CustomizationFormText = "Address";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(564, 20);
            this.layoutControlItem8.Text = "Query";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(52, 13);
            // 
            // frmReportDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmReportDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Design";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcReportParameter)).EndInit();
            this.xtcReportParameter.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcReportParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReportFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.MemoEdit meQuery;
        private DevExpress.XtraEditors.TextEdit txtReportFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraTab.XtraTabControl xtcReportParameter;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gcReportParameters;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Sequence;
        private DevExpress.XtraGrid.Columns.GridColumn Parameter;
        private DevExpress.XtraGrid.Columns.GridColumn FieldName;
        private DevExpress.XtraGrid.Columns.GridColumn NotActive;
        private DevExpress.XtraEditors.SimpleButton btnRefreshDetail;
        private DevExpress.XtraEditors.SimpleButton btnDeleteDetail;
        private DevExpress.XtraEditors.SimpleButton btnEditDetail;
        private DevExpress.XtraEditors.SimpleButton btnNewDetail;
        private System.Windows.Forms.BindingSource bsDetail;
    }
}