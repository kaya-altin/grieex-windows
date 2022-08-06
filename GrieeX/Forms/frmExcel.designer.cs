namespace GrieeX.Forms
{
    partial class frmExcel
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
            this.txtFolder = new DevExpress.XtraEditors.TextEdit();
            this.btnFolderSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbMovieName = new System.Windows.Forms.ComboBox();
            this.cbIMDBNumber = new System.Windows.Forms.ComboBox();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.slStatus = new DevExpress.XtraBars.BarStaticItem();
            this.pbProgress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.cbArchivesNumber = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFolder
            // 
            this.txtFolder.Enabled = false;
            this.txtFolder.Location = new System.Drawing.Point(30, 30);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(8);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(895, 45);
            this.txtFolder.TabIndex = 192;
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.Location = new System.Drawing.Point(962, 27);
            this.btnFolderSelect.Margin = new System.Windows.Forms.Padding(8);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(188, 58);
            this.btnFolderSelect.TabIndex = 191;
            this.btnFolderSelect.Text = "Seç";
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(962, 251);
            this.btnImport.Margin = new System.Windows.Forms.Padding(8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(188, 58);
            this.btnImport.TabIndex = 195;
            this.btnImport.Text = "Aktar";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 122);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 33);
            this.labelControl1.TabIndex = 196;
            this.labelControl1.Text = "Orijinal Ýsim";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 190);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 33);
            this.labelControl2.TabIndex = 197;
            this.labelControl2.Text = "IMDB No";
            // 
            // cbMovieName
            // 
            this.cbMovieName.DisplayMember = "Display";
            this.cbMovieName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovieName.FormattingEnabled = true;
            this.cbMovieName.Location = new System.Drawing.Point(250, 114);
            this.cbMovieName.Margin = new System.Windows.Forms.Padding(8);
            this.cbMovieName.Name = "cbMovieName";
            this.cbMovieName.Size = new System.Drawing.Size(668, 41);
            this.cbMovieName.TabIndex = 198;
            // 
            // cbIMDBNumber
            // 
            this.cbIMDBNumber.DisplayMember = "Display";
            this.cbIMDBNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIMDBNumber.FormattingEnabled = true;
            this.cbIMDBNumber.Location = new System.Drawing.Point(250, 183);
            this.cbIMDBNumber.Margin = new System.Windows.Forms.Padding(8);
            this.cbIMDBNumber.Name = "cbIMDBNumber";
            this.cbIMDBNumber.Size = new System.Drawing.Size(668, 41);
            this.cbIMDBNumber.TabIndex = 199;
            // 
            // bar1
            // 
            this.bar1.BarName = "Status bar";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Status bar";
            // 
            // bar2
            // 
            this.bar2.BarName = "Status bar";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Status bar";
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
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.slStatus,
            this.pbProgress});
            this.barManager1.MaxItemId = 2;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1});
            this.barManager1.StatusBar = this.bar6;
            // 
            // bar6
            // 
            this.bar6.BarName = "Status bar";
            this.bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.slStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.pbProgress)});
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Status bar";
            // 
            // slStatus
            // 
            this.slStatus.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.slStatus.Id = 0;
            this.slStatus.Name = "slStatus";
            this.slStatus.Size = new System.Drawing.Size(32, 0);
            this.slStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.slStatus.Width = 32;
            // 
            // pbProgress
            // 
            this.pbProgress.Caption = "barEditItem1";
            this.pbProgress.Edit = this.repositoryItemMarqueeProgressBar1;
            this.pbProgress.EditWidth = 100;
            this.pbProgress.Id = 1;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(8);
            this.barDockControlTop.Size = new System.Drawing.Size(1172, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 331);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(8);
            this.barDockControlBottom.Size = new System.Drawing.Size(1172, 72);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(8);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 331);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1172, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(8);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 331);
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // cbArchivesNumber
            // 
            this.cbArchivesNumber.DisplayMember = "Display";
            this.cbArchivesNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArchivesNumber.FormattingEnabled = true;
            this.cbArchivesNumber.Location = new System.Drawing.Point(250, 255);
            this.cbArchivesNumber.Margin = new System.Windows.Forms.Padding(8);
            this.cbArchivesNumber.Name = "cbArchivesNumber";
            this.cbArchivesNumber.Size = new System.Drawing.Size(668, 41);
            this.cbArchivesNumber.TabIndex = 203;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 262);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 33);
            this.labelControl4.TabIndex = 202;
            this.labelControl4.Text = "Arþiv No";
            // 
            // frmExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 403);
            this.Controls.Add(this.cbArchivesNumber);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbIMDBNumber);
            this.Controls.Add(this.cbMovieName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "frmExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel\'den Al";
            this.Load += new System.EventHandler(this.frmExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFolder;
        private DevExpress.XtraEditors.SimpleButton btnFolderSelect;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbMovieName;
        private System.Windows.Forms.ComboBox cbIMDBNumber;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem slStatus;
        private DevExpress.XtraBars.BarEditItem pbProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.ComboBox cbArchivesNumber;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}