namespace GrieeX.Forms
{
    partial class frmSearch
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
            this.grbMain = new System.Windows.Forms.GroupBox();
            this.lbMovies = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.grbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMain
            // 
            this.grbMain.Controls.Add(this.lbMovies);
            this.grbMain.Controls.Add(this.txtSearch);
            this.grbMain.Controls.Add(this.btnOk);
            this.grbMain.Controls.Add(this.btnCancel);
            this.grbMain.Controls.Add(this.btnSearch);
            this.grbMain.Location = new System.Drawing.Point(12, 12);
            this.grbMain.Name = "grbMain";
            this.grbMain.Size = new System.Drawing.Size(439, 339);
            this.grbMain.TabIndex = 29;
            this.grbMain.TabStop = false;
            // 
            // lbMovies
            // 
            this.lbMovies.FormattingEnabled = true;
            this.lbMovies.Location = new System.Drawing.Point(13, 47);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(416, 251);
            this.lbMovies.TabIndex = 38;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(349, 21);
            this.txtSearch.TabIndex = 37;
            // 
            // btnOk
            // 
            this.btnOk.ImageIndex = 1;
            this.btnOk.Location = new System.Drawing.Point(273, 308);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 24);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "Tamam";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 2;
            this.btnCancel.Location = new System.Drawing.Point(354, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "İptal";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.Location = new System.Drawing.Point(368, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 24);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Ara";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 466);
            this.Controls.Add(this.grbMain);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.grbMain.ResumeLayout(false);
            this.grbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.ListBox lbMovies;
        public System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}