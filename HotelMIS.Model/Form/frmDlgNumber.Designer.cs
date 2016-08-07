namespace HotelMIS.Model
{
    partial class frmDlgNumber
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
            this.btnChange = new System.Windows.Forms.Button();
            this.seAmount = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.seAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(249, 12);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 30);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "OK";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // seAmount
            // 
            this.seAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAmount.Location = new System.Drawing.Point(12, 12);
            this.seAmount.Name = "seAmount";
            this.seAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seAmount.Properties.Appearance.Options.UseFont = true;
            this.seAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seAmount.Properties.DisplayFormat.FormatString = "#,#.##";
            this.seAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAmount.Properties.EditFormat.FormatString = "#,#.##";
            this.seAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAmount.Size = new System.Drawing.Size(231, 30);
            this.seAmount.TabIndex = 0;
            // 
            // frmDlgNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 54);
            this.Controls.Add(this.seAmount);
            this.Controls.Add(this.btnChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDlgNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beginning Amount";
            ((System.ComponentModel.ISupportInitialize)(this.seAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private DevExpress.XtraEditors.SpinEdit seAmount;
    }
}