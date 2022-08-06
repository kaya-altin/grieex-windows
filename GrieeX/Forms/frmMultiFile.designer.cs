namespace GrieeX.Forms
{
    partial class frmMultiFile
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.slStatus = new DevExpress.XtraBars.BarStaticItem();
            this.pbProgress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.bw2 = new System.ComponentModel.BackgroundWorker();
            this.lvColumns = new System.Windows.Forms.ListView();
            this.Dosya = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFolderSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectNone = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.txtFolder = new DevExpress.XtraEditors.TextEdit();
            this.chkRepeated = new DevExpress.XtraEditors.CheckEdit();
            this.dsFiles = new GrieeX.DataSets.dsFiles();
            this.tFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRepeated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFilesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.barManager1.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Always;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.bar3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.bar3.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.bar3.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.bar3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.bar3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.slStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.pbProgress)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.BarState = DevExpress.XtraBars.BarState.Expanded;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // slStatus
            // 
            this.slStatus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Default;
            this.slStatus.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.slStatus.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.slStatus.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.slStatus.Id = 0;
            this.slStatus.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Default;
            this.slStatus.MergeType = DevExpress.XtraBars.BarMenuMerge.Add;
            this.slStatus.Name = "slStatus";
            this.slStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.slStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.slStatus.Width = 32;
            // 
            // pbProgress
            // 
            this.pbProgress.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Default;
            this.pbProgress.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.pbProgress.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.pbProgress.CaptionAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.pbProgress.Edit = this.repositoryItemMarqueeProgressBar1;
            this.pbProgress.EditorShowMode = DevExpress.Utils.EditorShowMode.Default;
            this.pbProgress.Id = 1;
            this.pbProgress.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Default;
            this.pbProgress.MergeType = DevExpress.XtraBars.BarMenuMerge.Add;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.pbProgress.Width = 100;
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.repositoryItemMarqueeProgressBar1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemMarqueeProgressBar1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemMarqueeProgressBar1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemMarqueeProgressBar1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemMarqueeProgressBar1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemMarqueeProgressBar1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemMarqueeProgressBar1.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemMarqueeProgressBar1.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemMarqueeProgressBar1.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemMarqueeProgressBar1.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemMarqueeProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.repositoryItemMarqueeProgressBar1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemMarqueeProgressBar1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.repositoryItemMarqueeProgressBar1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            this.repositoryItemMarqueeProgressBar1.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Default;
            this.repositoryItemMarqueeProgressBar1.ProgressKind = DevExpress.XtraEditors.Controls.ProgressKind.Horizontal;
            this.repositoryItemMarqueeProgressBar1.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Broken;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.barDockControlTop.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.barDockControlTop.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.barDockControlTop.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.barDockControlTop.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.barDockControlTop.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(656, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.barDockControlBottom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.barDockControlBottom.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.barDockControlBottom.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.barDockControlBottom.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.barDockControlBottom.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 416);
            this.barDockControlBottom.Size = new System.Drawing.Size(656, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.barDockControlLeft.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.barDockControlLeft.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.barDockControlLeft.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.barDockControlLeft.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.barDockControlLeft.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 416);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.barDockControlRight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.barDockControlRight.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.barDockControlRight.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.barDockControlRight.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.barDockControlRight.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(656, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 416);
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw2_RunWorkerCompleted);
            // 
            // bw2
            // 
            this.bw2.WorkerSupportsCancellation = true;
            this.bw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw2_DoWork);
            this.bw2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw2_RunWorkerCompleted);
            // 
            // lvColumns
            // 
            this.lvColumns.AllowColumnReorder = true;
            this.lvColumns.CheckBoxes = true;
            this.lvColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dosya});
            this.lvColumns.FullRowSelect = true;
            this.lvColumns.Location = new System.Drawing.Point(12, 66);
            this.lvColumns.Name = "lvColumns";
            this.lvColumns.Size = new System.Drawing.Size(632, 315);
            this.lvColumns.TabIndex = 179;
            this.lvColumns.UseCompatibleStateImageBehavior = false;
            this.lvColumns.View = System.Windows.Forms.View.Details;
            // 
            // Dosya
            // 
            this.Dosya.Text = "Dosya";
            this.Dosya.Width = 610;
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btnFolderSelect.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnFolderSelect.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btnFolderSelect.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btnFolderSelect.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btnFolderSelect.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btnFolderSelect.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnFolderSelect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnFolderSelect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFolderSelect.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btnFolderSelect.Location = new System.Drawing.Point(569, 38);
            this.btnFolderSelect.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(75, 23);
            this.btnFolderSelect.TabIndex = 185;
            this.btnFolderSelect.Text = "Seç";
            this.btnFolderSelect.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btnCancel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnCancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btnCancel.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btnCancel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btnCancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btnCancel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btnCancel.Location = new System.Drawing.Point(488, 387);
            this.btnCancel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 186;
            this.btnCancel.Text = "Ýptal";
            this.btnCancel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btnImport.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnImport.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btnImport.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btnImport.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btnImport.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btnImport.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnImport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImport.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btnImport.Location = new System.Drawing.Point(569, 387);
            this.btnImport.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 187;
            this.btnImport.Text = "Aktar";
            this.btnImport.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btnSelectNone.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnSelectNone.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btnSelectNone.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btnSelectNone.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btnSelectNone.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btnSelectNone.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnSelectNone.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnSelectNone.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelectNone.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btnSelectNone.Location = new System.Drawing.Point(129, 387);
            this.btnSelectNone.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(109, 23);
            this.btnSelectNone.TabIndex = 189;
            this.btnSelectNone.Text = "Hiçbirini Seçme";
            this.btnSelectNone.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btnSelectAll.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnSelectAll.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btnSelectAll.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btnSelectAll.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btnSelectAll.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btnSelectAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnSelectAll.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnSelectAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelectAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btnSelectAll.Location = new System.Drawing.Point(12, 387);
            this.btnSelectAll.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(109, 23);
            this.btnSelectAll.TabIndex = 188;
            this.btnSelectAll.Text = "Tümünü Seç";
            this.btnSelectAll.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txtFolder.Enabled = false;
            this.txtFolder.Location = new System.Drawing.Point(12, 40);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txtFolder.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txtFolder.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtFolder.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtFolder.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtFolder.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtFolder.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtFolder.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtFolder.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtFolder.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtFolder.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtFolder.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtFolder.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtFolder.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtFolder.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtFolder.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtFolder.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtFolder.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtFolder.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtFolder.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtFolder.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtFolder.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtFolder.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtFolder.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtFolder.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtFolder.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtFolder.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtFolder.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFolder.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtFolder.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txtFolder.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.txtFolder.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txtFolder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtFolder.Size = new System.Drawing.Size(551, 20);
            this.txtFolder.TabIndex = 190;
            this.txtFolder.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // chkRepeated
            // 
            this.chkRepeated.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.chkRepeated.Location = new System.Drawing.Point(12, 15);
            this.chkRepeated.Name = "chkRepeated";
            this.chkRepeated.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.chkRepeated.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.chkRepeated.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkRepeated.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.chkRepeated.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.chkRepeated.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.chkRepeated.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.chkRepeated.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.chkRepeated.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkRepeated.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.chkRepeated.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.chkRepeated.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.chkRepeated.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.chkRepeated.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.chkRepeated.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkRepeated.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.chkRepeated.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.chkRepeated.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.chkRepeated.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.chkRepeated.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.chkRepeated.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkRepeated.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.chkRepeated.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.chkRepeated.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.chkRepeated.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.chkRepeated.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chkRepeated.Properties.Caption = "Arþivimde olmayan dosyalarý getir.";
            this.chkRepeated.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard;
            this.chkRepeated.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.chkRepeated.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.chkRepeated.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.chkRepeated.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.InactiveChecked;
            this.chkRepeated.Size = new System.Drawing.Size(190, 19);
            this.chkRepeated.TabIndex = 191;
            this.chkRepeated.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // dsFiles
            // 
            this.dsFiles.DataSetName = "dsFiles";
            this.dsFiles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tFilesBindingSource
            // 
            this.tFilesBindingSource.DataMember = "Files";
            this.tFilesBindingSource.DataSource = this.dsFiles;
            // 
            // frmMultiFile
            // 
            this.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 444);
            this.Controls.Add(this.chkRepeated);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.lvColumns);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.MaximizeBox = false;
            this.Name = "frmMultiFile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplu Dosya Ekleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMultiFile_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRepeated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFilesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.ComponentModel.BackgroundWorker bw;
        private System.ComponentModel.BackgroundWorker bw2;
        private System.Windows.Forms.ListView lvColumns;
        private DevExpress.XtraEditors.SimpleButton btnFolderSelect;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSelectNone;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraBars.BarStaticItem slStatus;
        private DevExpress.XtraBars.BarEditItem pbProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraEditors.TextEdit txtFolder;
        private DevExpress.XtraEditors.CheckEdit chkRepeated;
        public System.Windows.Forms.ColumnHeader Dosya;
        internal DataSets.dsFiles dsFiles;
        private System.Windows.Forms.BindingSource tFilesBindingSource;
    }
}