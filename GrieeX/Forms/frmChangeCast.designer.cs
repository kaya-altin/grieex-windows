namespace GrieeX.Forms
{
    partial class frmChangeCast
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
            this.txtS2 = new DevExpress.XtraEditors.TextEdit();
            this.txtS1 = new DevExpress.XtraEditors.TextEdit();
            this.lblS2 = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.grbCast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtS2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtS1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCast
            // 
            this.grbCast.Controls.Add(this.txtS2);
            this.grbCast.Controls.Add(this.txtS1);
            this.grbCast.Controls.Add(this.lblS2);
            this.grbCast.Controls.Add(this.lblS1);
            this.grbCast.Location = new System.Drawing.Point(7, 0);
            this.grbCast.Name = "grbCast";
            this.grbCast.Size = new System.Drawing.Size(245, 80);
            this.grbCast.TabIndex = 12;
            this.grbCast.TabStop = false;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(69, 44);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(170, 20);
            this.txtS2.TabIndex = 7;
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(69, 18);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(170, 20);
            this.txtS1.TabIndex = 6;
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.Location = new System.Drawing.Point(10, 47);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(48, 13);
            this.lblS2.TabIndex = 5;
            this.lblS2.Text = "Karakter";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Location = new System.Drawing.Point(9, 21);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(44, 13);
            this.lblS1.TabIndex = 4;
            this.lblS1.Text = "Oyuncu";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(96, 86);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Tamam";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Ýptal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmChangeCast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 115);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbCast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeCast";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyuncu Deðiþtir";
            this.TopMost = true;
            this.grbCast.ResumeLayout(false);
            this.grbCast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtS2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtS1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grbCast;
        internal System.Windows.Forms.Label lblS2;
        internal System.Windows.Forms.Label lblS1;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.TextEdit txtS2;
        internal DevExpress.XtraEditors.TextEdit txtS1;
    }
}