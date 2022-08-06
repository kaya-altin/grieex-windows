namespace GrieeX.Forms
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabAbout = new DevExpress.XtraTab.XtraTabPage();
            this.hyperLinkEdit2 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLicanse = new System.Windows.Forms.Label();
            this.lblLicanse2 = new System.Windows.Forms.Label();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.tabTranslations = new DevExpress.XtraTab.XtraTabPage();
            this.ımageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imgFlags = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            this.tabTranslations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlags)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(9, 20);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(44, 13);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "Sürüm";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblV.ForeColor = System.Drawing.Color.Black;
            this.lblV.Location = new System.Drawing.Point(97, 20);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(14, 13);
            this.lblV.TabIndex = 13;
            this.lblV.Text = "V";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.ForeColor = System.Drawing.Color.Black;
            this.lblC.Location = new System.Drawing.Point(97, 44);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(75, 13);
            this.lblC.TabIndex = 11;
            this.lblC.Text = "Durmuş ALTIN";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::GrieeX.Properties.Resources.GrieeXLogo;
            this.pbLogo.Location = new System.Drawing.Point(11, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(117, 59);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 74);
            this.panel1.TabIndex = 16;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 75);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabAbout;
            this.xtraTabControl1.Size = new System.Drawing.Size(456, 242);
            this.xtraTabControl1.TabIndex = 17;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabAbout,
            this.tabTranslations});
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.hyperLinkEdit2);
            this.tabAbout.Controls.Add(this.label1);
            this.tabAbout.Controls.Add(this.lblLicanse);
            this.tabAbout.Controls.Add(this.lblLicanse2);
            this.tabAbout.Controls.Add(this.hyperLinkEdit1);
            this.tabAbout.Controls.Add(this.lblCopyright);
            this.tabAbout.Controls.Add(this.lblWeb);
            this.tabAbout.Controls.Add(this.lblVersion);
            this.tabAbout.Controls.Add(this.lblV);
            this.tabAbout.Controls.Add(this.lblC);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(451, 216);
            this.tabAbout.Text = "Hakkında";
            // 
            // hyperLinkEdit2
            // 
            this.hyperLinkEdit2.EditValue = "https://play.google.com/store/apps/details?id=com.grieex";
            this.hyperLinkEdit2.Location = new System.Drawing.Point(100, 117);
            this.hyperLinkEdit2.Name = "hyperLinkEdit2";
            this.hyperLinkEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperLinkEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.hyperLinkEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit2.Size = new System.Drawing.Size(295, 18);
            this.hyperLinkEdit2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Android";
            // 
            // lblLicanse
            // 
            this.lblLicanse.AutoSize = true;
            this.lblLicanse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLicanse.ForeColor = System.Drawing.Color.Black;
            this.lblLicanse.Location = new System.Drawing.Point(9, 70);
            this.lblLicanse.Name = "lblLicanse";
            this.lblLicanse.Size = new System.Drawing.Size(42, 13);
            this.lblLicanse.TabIndex = 24;
            this.lblLicanse.Text = "Lisans";
            // 
            // lblLicanse2
            // 
            this.lblLicanse2.AutoSize = true;
            this.lblLicanse2.ForeColor = System.Drawing.Color.Black;
            this.lblLicanse2.Location = new System.Drawing.Point(97, 70);
            this.lblLicanse2.Name = "lblLicanse2";
            this.lblLicanse2.Size = new System.Drawing.Size(45, 13);
            this.lblLicanse2.TabIndex = 23;
            this.lblLicanse2.Text = "Ücretsiz";
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "www.griee.com";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(100, 93);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit1.Size = new System.Drawing.Size(84, 18);
            this.hyperLinkEdit1.TabIndex = 21;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCopyright.ForeColor = System.Drawing.Color.Black;
            this.lblCopyright.Location = new System.Drawing.Point(9, 44);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(51, 13);
            this.lblCopyright.TabIndex = 19;
            this.lblCopyright.Text = "Yapımcı";
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblWeb.ForeColor = System.Drawing.Color.Black;
            this.lblWeb.Location = new System.Drawing.Point(9, 95);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(32, 13);
            this.lblWeb.TabIndex = 18;
            this.lblWeb.Text = "Web";
            // 
            // tabTranslations
            // 
            this.tabTranslations.Controls.Add(this.ımageListBoxControl1);
            this.tabTranslations.Name = "tabTranslations";
            this.tabTranslations.Size = new System.Drawing.Size(451, 216);
            this.tabTranslations.Text = "Çeviriler";
            // 
            // ımageListBoxControl1
            // 
            this.ımageListBoxControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.ımageListBoxControl1.ImageList = this.imgFlags;
            this.ımageListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageListBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageListBoxItem("Durmuş Altın", 0),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem("Seçil Güreşci", 1),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem("Paulo Fogaça", 2),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem("Ayhan Özgür", 3)});
            this.ımageListBoxControl1.Location = new System.Drawing.Point(5, 4);
            this.ımageListBoxControl1.Name = "ımageListBoxControl1";
            this.ımageListBoxControl1.Size = new System.Drawing.Size(439, 205);
            this.ımageListBoxControl1.TabIndex = 1;
            // 
            // imgFlags
            // 
            this.imgFlags.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgFlags.ImageStream")));
            this.imgFlags.Images.SetKeyName(2, "Brazil.png");
            this.imgFlags.Images.SetKeyName(3, "Bulgaria.png");
            // 
            // frmAbout
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 317);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            this.tabTranslations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ımageListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblV;
        internal System.Windows.Forms.Label lblC;
        internal System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabAbout;
        private DevExpress.XtraTab.XtraTabPage tabTranslations;
        private DevExpress.XtraEditors.ImageListBoxControl ımageListBoxControl1;
        private DevExpress.Utils.ImageCollection imgFlags;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private System.Windows.Forms.Label lblVersion;
        internal System.Windows.Forms.Label lblCopyright;
        internal System.Windows.Forms.Label lblWeb;
        internal System.Windows.Forms.Label lblLicanse;
        internal System.Windows.Forms.Label lblLicanse2;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit2;
        internal System.Windows.Forms.Label label1;
    }
}