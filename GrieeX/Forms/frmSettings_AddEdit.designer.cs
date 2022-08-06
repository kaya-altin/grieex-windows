namespace GrieeX.Forms
{
    partial class frmSettings_AddEdit
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
            this.grbCast = new System.Windows.Forms.GroupBox();
            this.lblS1 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.txtS1 = new DevExpress.XtraEditors.TextEdit();
            this.grbCast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtS1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCast
            // 
            this.grbCast.Controls.Add(this.txtS1);
            this.grbCast.Controls.Add(this.lblS1);
            this.grbCast.Location = new System.Drawing.Point(8, 1);
            this.grbCast.Name = "grbCast";
            this.grbCast.Size = new System.Drawing.Size(252, 71);
            this.grbCast.TabIndex = 9;
            this.grbCast.TabStop = false;
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Location = new System.Drawing.Point(6, 16);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(75, 13);
            this.lblS1.TabIndex = 4;
            this.lblS1.Text = "Durmuş ALTIN";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "İptal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(104, 78);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Tamam";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(9, 31);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(237, 20);
            this.txtS1.TabIndex = 5;
            // 
            // frmSettings_AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 109);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbCast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings_AddEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.grbCast.ResumeLayout(false);
            this.grbCast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtS1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grbCast;
        internal System.Windows.Forms.Label lblS1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        internal DevExpress.XtraEditors.TextEdit txtS1;
    }
}