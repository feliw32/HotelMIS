namespace HotelMIS.View
{
    partial class frmDlgVoidReason
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
            this.meVoidReason = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.meVoidReason.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(249, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 94);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "OK";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // meVoidReason
            // 
            this.meVoidReason.Location = new System.Drawing.Point(2, 3);
            this.meVoidReason.Name = "meVoidReason";
            this.meVoidReason.Size = new System.Drawing.Size(241, 96);
            this.meVoidReason.TabIndex = 1;
            // 
            // frmDlgVoidReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 100);
            this.Controls.Add(this.meVoidReason);
            this.Controls.Add(this.btnChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDlgVoidReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Value";
            ((System.ComponentModel.ISupportInitialize)(this.meVoidReason.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private DevExpress.XtraEditors.MemoEdit meVoidReason;
    }
}