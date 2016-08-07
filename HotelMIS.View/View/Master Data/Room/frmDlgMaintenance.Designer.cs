namespace HotelMIS.View
{
    partial class frmDlgMaintenance
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnSaveMaintenance = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(219, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Input Maintenance Reason on text box below";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 31);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(355, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // btnSaveMaintenance
            // 
            this.btnSaveMaintenance.Location = new System.Drawing.Point(292, 57);
            this.btnSaveMaintenance.Name = "btnSaveMaintenance";
            this.btnSaveMaintenance.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMaintenance.TabIndex = 2;
            this.btnSaveMaintenance.Text = "Save";
            this.btnSaveMaintenance.Click += new System.EventHandler(this.btnSaveMaintenance_Click);
            // 
            // frmDlgMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 92);
            this.Controls.Add(this.btnSaveMaintenance);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDlgMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSaveMaintenance;
    }
}