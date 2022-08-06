namespace GrieeX.Forms
{
    partial class frmImdb250
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvImdb250 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_Rank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_Rating = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_Votes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ImdbNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.slStatus = new DevExpress.XtraBars.BarStaticItem();
            this.pbProgress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Button1 = new DevExpress.XtraEditors.SimpleButton();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImdb250)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "tImdb250";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gvImdb250;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(734, 418);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImdb250});
            // 
            // gvImdb250
            // 
            this.gvImdb250.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_Rank,
            this.cl_Title,
            this.cl_Rating,
            this.cl_Votes,
            this.cl_ImdbNumber});
            this.gvImdb250.GridControl = this.gridControl1;
            this.gvImdb250.Name = "gvImdb250";
            this.gvImdb250.OptionsBehavior.Editable = false;
            this.gvImdb250.OptionsCustomization.AllowFilter = false;
            this.gvImdb250.OptionsCustomization.AllowGroup = false;
            this.gvImdb250.OptionsMenu.EnableColumnMenu = false;
            this.gvImdb250.OptionsMenu.EnableFooterMenu = false;
            this.gvImdb250.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvImdb250.OptionsView.ShowGroupPanel = false;
            this.gvImdb250.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvImdb250_RowStyle);
            this.gvImdb250.DoubleClick += new System.EventHandler(this.gvImdb250_DoubleClick);
            this.gvImdb250.RowCountChanged += new System.EventHandler(this.gvImdb250_RowCountChanged);
            // 
            // cl_Rank
            // 
            this.cl_Rank.AppearanceCell.Options.UseTextOptions = true;
            this.cl_Rank.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cl_Rank.Caption = "Sýra";
            this.cl_Rank.FieldName = "Rank";
            this.cl_Rank.Name = "cl_Rank";
            this.cl_Rank.Visible = true;
            this.cl_Rank.VisibleIndex = 0;
            this.cl_Rank.Width = 46;
            // 
            // cl_Title
            // 
            this.cl_Title.Caption = "Film Adý";
            this.cl_Title.FieldName = "Title";
            this.cl_Title.Name = "cl_Title";
            this.cl_Title.Visible = true;
            this.cl_Title.VisibleIndex = 1;
            this.cl_Title.Width = 423;
            // 
            // cl_Rating
            // 
            this.cl_Rating.AppearanceCell.Options.UseTextOptions = true;
            this.cl_Rating.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cl_Rating.Caption = "Puan";
            this.cl_Rating.FieldName = "Rating";
            this.cl_Rating.Name = "cl_Rating";
            this.cl_Rating.Visible = true;
            this.cl_Rating.VisibleIndex = 2;
            this.cl_Rating.Width = 46;
            // 
            // cl_Votes
            // 
            this.cl_Votes.AppearanceCell.Options.UseTextOptions = true;
            this.cl_Votes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cl_Votes.Caption = "Oy";
            this.cl_Votes.ColumnEdit = this.repositoryItemTextEdit1;
            this.cl_Votes.FieldName = "Votes";
            this.cl_Votes.Name = "cl_Votes";
            this.cl_Votes.Visible = true;
            this.cl_Votes.VisibleIndex = 3;
            this.cl_Votes.Width = 64;
            // 
            // cl_ImdbNumber
            // 
            this.cl_ImdbNumber.AppearanceCell.Options.UseTextOptions = true;
            this.cl_ImdbNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cl_ImdbNumber.Caption = "Imdb No";
            this.cl_ImdbNumber.FieldName = "ImdbNumber";
            this.cl_ImdbNumber.Name = "cl_ImdbNumber";
            this.cl_ImdbNumber.Visible = true;
            this.cl_ImdbNumber.VisibleIndex = 4;
            this.cl_ImdbNumber.Width = 64;
            // 
            // lblCount2
            // 
            this.lblCount2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCount2.Location = new System.Drawing.Point(207, 449);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(42, 15);
            this.lblCount2.TabIndex = 156;
            this.lblCount2.Text = "0";
            this.lblCount2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 449);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(172, 13);
            this.Label2.TabIndex = 155;
            this.Label2.Text = "Listemde Olmayan Filmlerin Sayýsý :";
            // 
            // lblCount1
            // 
            this.lblCount1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCount1.Location = new System.Drawing.Point(207, 429);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(42, 15);
            this.lblCount1.TabIndex = 154;
            this.lblCount1.Text = "0";
            this.lblCount1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 429);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 13);
            this.Label1.TabIndex = 153;
            this.Label1.Text = "Listemde Olan Filmlerin Sayýsý :";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
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
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.slStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.pbProgress)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // slStatus
            // 
            this.slStatus.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.slStatus.Id = 0;
            this.slStatus.Name = "slStatus";
            this.slStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.slStatus.Width = 32;
            // 
            // pbProgress
            // 
            this.pbProgress.Edit = this.repositoryItemMarqueeProgressBar1;
            this.pbProgress.Id = 1;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.pbProgress.Width = 100;
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
            this.barDockControlTop.Size = new System.Drawing.Size(740, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Size = new System.Drawing.Size(740, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 474);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(740, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 474);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.Location = new System.Drawing.Point(420, 428);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(311, 23);
            this.Button1.TabIndex = 161;
            this.Button1.Text = "Listeyi Imdb\'den güncelle";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // frmImdb250
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 502);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lblCount2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblCount1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmImdb250";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Imdb 250";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImdb250_FormClosing);
            this.Load += new System.EventHandler(this.frmImdb250_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImdb250)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvImdb250;
        internal System.Windows.Forms.Label lblCount2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblCount1;
        internal System.Windows.Forms.Label Label1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton Button1;
        private DevExpress.XtraBars.BarStaticItem slStatus;
        private DevExpress.XtraBars.BarEditItem pbProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private System.ComponentModel.BackgroundWorker bw;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Rank;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Title;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Rating;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Votes;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ImdbNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}