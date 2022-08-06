namespace GrieeX.UserControls
{
    partial class MovieDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetail));
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnMultiAdd = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabMovieInfo = new DevExpress.XtraTab.XtraTabPage();
            this.pbImage = new DevExpress.XtraEditors.PictureEdit();
            this.mnuImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSelectImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtReleaseDate = new DevExpress.XtraEditors.TextEdit();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtBudget = new DevExpress.XtraEditors.TextEdit();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtProductionCompany = new DevExpress.XtraEditors.TextEdit();
            this.lblProductionCompany = new System.Windows.Forms.Label();
            this.cbDubbing = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cbSubTitle = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.dgCast = new DevExpress.XtraGrid.GridControl();
            this.gvCast = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtVotes = new DevExpress.XtraEditors.TextEdit();
            this.txtRuntime = new DevExpress.XtraEditors.TextEdit();
            this.txtCountry = new DevExpress.XtraEditors.TextEdit();
            this.txtLanguage = new DevExpress.XtraEditors.TextEdit();
            this.txtUserRating = new DevExpress.XtraEditors.TextEdit();
            this.txtYear = new DevExpress.XtraEditors.TextEdit();
            this.txtWriter = new DevExpress.XtraEditors.TextEdit();
            this.txtGenre = new DevExpress.XtraEditors.TextEdit();
            this.txtDirector = new DevExpress.XtraEditors.TextEdit();
            this.txtOtherName = new DevExpress.XtraEditors.TextEdit();
            this.txtOrginalName = new DevExpress.XtraEditors.TextEdit();
            this.lblDubbing = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblVotes = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblUserRating = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTurkishName = new System.Windows.Forms.Label();
            this.lblOrginalName = new System.Windows.Forms.Label();
            this.TabControlPlot = new DevExpress.XtraTab.XtraTabControl();
            this.tabTurkish = new DevExpress.XtraTab.XtraTabPage();
            this.txtOtherPlot = new DevExpress.XtraEditors.MemoEdit();
            this.tabEnglish = new DevExpress.XtraTab.XtraTabPage();
            this.txtEnglishPlot = new DevExpress.XtraEditors.MemoEdit();
            this.grbMovie = new System.Windows.Forms.GroupBox();
            this.rgMovieSeen = new DevExpress.XtraEditors.RadioGroup();
            this.tabFileInfo = new DevExpress.XtraTab.XtraTabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPlayer = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dgFileList = new DevExpress.XtraGrid.GridControl();
            this.tFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFiles = new GrieeX.DataSets.dsFiles();
            this.gvFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_FileID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_FileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_Resolution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_VideoCodec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_VideoBitrate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_Fps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_VideoAspectRatio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioCodec1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioChannels1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioBitrate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioSampleRate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioSize1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioCodec2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioChannels2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioBitrate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioSampleRate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_AudioSize2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_TotalFrames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_Lenght = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_VideoSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_FileSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_Chapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabOther = new DevExpress.XtraTab.XtraTabPage();
            this.txtTmdbNumber = new DevExpress.XtraEditors.TextEdit();
            this.cbUserColumn6 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblUserColumn6 = new System.Windows.Forms.Label();
            this.cbUserColumn5 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblUserColumn5 = new System.Windows.Forms.Label();
            this.cbRlsGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbRlsType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblRlsGroup = new System.Windows.Forms.Label();
            this.lblRlsType = new System.Windows.Forms.Label();
            this.txtTmdbVotes = new DevExpress.XtraEditors.TextEdit();
            this.txtTmdbUserRating = new DevExpress.XtraEditors.TextEdit();
            this.txtImdbVotes = new DevExpress.XtraEditors.TextEdit();
            this.txtImdbUserRating = new DevExpress.XtraEditors.TextEdit();
            this.txtPoster = new DevExpress.XtraEditors.TextEdit();
            this.cbUserColumn4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbUserColumn3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbUserColumn2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbUserColumn1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblChangeDate = new System.Windows.Forms.Label();
            this.lblDateEntered = new System.Windows.Forms.Label();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.txtPersonalRating = new DevExpress.XtraEditors.TextEdit();
            this.txtImdbNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtArchivesNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblUserColumn4 = new System.Windows.Forms.Label();
            this.lblUserColumn3 = new System.Windows.Forms.Label();
            this.lblUserColumn2 = new System.Windows.Forms.Label();
            this.lblUserColumn1 = new System.Windows.Forms.Label();
            this.lblPersonalRating = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblChangeDate22 = new System.Windows.Forms.Label();
            this.lblDateEntered22 = new System.Windows.Forms.Label();
            this.lblArchivesNumber = new System.Windows.Forms.Label();
            this.lblImdbNumber = new System.Windows.Forms.Label();
            this.btnImdb = new System.Windows.Forms.Button();
            this.mnuCastList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoToImdbPage = new System.Windows.Forms.ToolStripMenuItem();
            this.icImages = new DevExpress.Utils.ImageCollection(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabMovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage.Properties)).BeginInit();
            this.mnuImage.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReleaseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBudget.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductionCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDubbing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuntime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserRating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWriter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrginalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlPlot)).BeginInit();
            this.TabControlPlot.SuspendLayout();
            this.tabTurkish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherPlot.Properties)).BeginInit();
            this.tabEnglish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglishPlot.Properties)).BeginInit();
            this.grbMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgMovieSeen.Properties)).BeginInit();
            this.tabFileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).BeginInit();
            this.tabOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTmdbNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRlsGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRlsType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTmdbVotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTmdbUserRating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImdbVotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImdbUserRating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalRating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImdbNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArchivesNumber.Properties)).BeginInit();
            this.mnuCastList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icImages)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // btnMultiAdd
            // 
            this.btnMultiAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiAdd.Location = new System.Drawing.Point(1125, 89);
            this.btnMultiAdd.Margin = new System.Windows.Forms.Padding(8);
            this.btnMultiAdd.Name = "btnMultiAdd";
            this.btnMultiAdd.Size = new System.Drawing.Size(142, 76);
            this.btnMultiAdd.TabIndex = 2;
            this.btnMultiAdd.Text = "Toplu Ekle";
            this.btnMultiAdd.Click += new System.EventHandler(this.btnMultiAdd_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(8);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabMovieInfo;
            this.xtraTabControl1.Size = new System.Drawing.Size(2225, 840);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMovieInfo,
            this.tabFileInfo,
            this.tabOther});
            // 
            // tabMovieInfo
            // 
            this.tabMovieInfo.Controls.Add(this.pbImage);
            this.tabMovieInfo.Controls.Add(this.Panel1);
            this.tabMovieInfo.Controls.Add(this.TabControlPlot);
            this.tabMovieInfo.Controls.Add(this.grbMovie);
            this.tabMovieInfo.Margin = new System.Windows.Forms.Padding(8);
            this.tabMovieInfo.Name = "tabMovieInfo";
            this.tabMovieInfo.Size = new System.Drawing.Size(2209, 771);
            this.tabMovieInfo.Text = "Film Bilgileri";
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Location = new System.Drawing.Point(1813, 10);
            this.pbImage.Name = "pbImage";
            this.pbImage.Properties.AllowFocused = false;
            this.pbImage.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.pbImage.Properties.Appearance.Options.UseBackColor = true;
            this.pbImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.pbImage.Properties.ContextMenuStrip = this.mnuImage;
            this.pbImage.Properties.ErrorImage = global::GrieeX.Properties.Resources.GrieeXLogo;
            this.pbImage.Properties.NullText = " ";
            this.pbImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pbImage.Properties.ZoomAccelerationFactor = 1D;
            this.pbImage.Size = new System.Drawing.Size(382, 537);
            this.pbImage.TabIndex = 162;
            this.pbImage.LoadCompleted += new System.EventHandler(this.pbImage_LoadCompleted);
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // mnuImage
            // 
            this.mnuImage.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelectImage,
            this.mnuDeleteImage});
            this.mnuImage.Name = "mnuImage";
            this.mnuImage.Size = new System.Drawing.Size(267, 96);
            // 
            // mnuSelectImage
            // 
            this.mnuSelectImage.Name = "mnuSelectImage";
            this.mnuSelectImage.Size = new System.Drawing.Size(266, 46);
            this.mnuSelectImage.Text = "Resim Seç";
            this.mnuSelectImage.Click += new System.EventHandler(this.mnuSelectImage_Click);
            // 
            // mnuDeleteImage
            // 
            this.mnuDeleteImage.Name = "mnuDeleteImage";
            this.mnuDeleteImage.Size = new System.Drawing.Size(266, 46);
            this.mnuDeleteImage.Text = "Resim Sil";
            this.mnuDeleteImage.Click += new System.EventHandler(this.mnuDeleteImage_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.txtReleaseDate);
            this.Panel1.Controls.Add(this.lblReleaseDate);
            this.Panel1.Controls.Add(this.txtBudget);
            this.Panel1.Controls.Add(this.lblBudget);
            this.Panel1.Controls.Add(this.txtProductionCompany);
            this.Panel1.Controls.Add(this.lblProductionCompany);
            this.Panel1.Controls.Add(this.cbDubbing);
            this.Panel1.Controls.Add(this.cbSubTitle);
            this.Panel1.Controls.Add(this.dgCast);
            this.Panel1.Controls.Add(this.txtVotes);
            this.Panel1.Controls.Add(this.txtRuntime);
            this.Panel1.Controls.Add(this.txtCountry);
            this.Panel1.Controls.Add(this.txtLanguage);
            this.Panel1.Controls.Add(this.txtUserRating);
            this.Panel1.Controls.Add(this.txtYear);
            this.Panel1.Controls.Add(this.txtWriter);
            this.Panel1.Controls.Add(this.txtGenre);
            this.Panel1.Controls.Add(this.txtDirector);
            this.Panel1.Controls.Add(this.txtOtherName);
            this.Panel1.Controls.Add(this.txtOrginalName);
            this.Panel1.Controls.Add(this.lblDubbing);
            this.Panel1.Controls.Add(this.lblSubtitle);
            this.Panel1.Controls.Add(this.lblVotes);
            this.Panel1.Controls.Add(this.lblCountry);
            this.Panel1.Controls.Add(this.lblDirector);
            this.Panel1.Controls.Add(this.lblLanguage);
            this.Panel1.Controls.Add(this.lblRuntime);
            this.Panel1.Controls.Add(this.lblWriter);
            this.Panel1.Controls.Add(this.lblUserRating);
            this.Panel1.Controls.Add(this.lblYear);
            this.Panel1.Controls.Add(this.lblGenre);
            this.Panel1.Controls.Add(this.lblTurkishName);
            this.Panel1.Controls.Add(this.lblOrginalName);
            this.Panel1.Location = new System.Drawing.Point(2, 3);
            this.Panel1.Margin = new System.Windows.Forms.Padding(8);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1795, 564);
            this.Panel1.TabIndex = 161;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReleaseDate.Location = new System.Drawing.Point(715, 223);
            this.txtReleaseDate.Margin = new System.Windows.Forms.Padding(8);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Properties.MaxLength = 255;
            this.txtReleaseDate.Size = new System.Drawing.Size(287, 42);
            this.txtReleaseDate.TabIndex = 207;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReleaseDate.AutoEllipsis = true;
            this.lblReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.lblReleaseDate.Location = new System.Drawing.Point(520, 230);
            this.lblReleaseDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(194, 33);
            this.lblReleaseDate.TabIndex = 206;
            this.lblReleaseDate.Text = "Çýkýþ Tarihi";
            // 
            // txtBudget
            // 
            this.txtBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBudget.Location = new System.Drawing.Point(715, 333);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(8);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Properties.MaxLength = 255;
            this.txtBudget.Size = new System.Drawing.Size(287, 42);
            this.txtBudget.TabIndex = 205;
            // 
            // lblBudget
            // 
            this.lblBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudget.AutoEllipsis = true;
            this.lblBudget.ForeColor = System.Drawing.Color.Black;
            this.lblBudget.Location = new System.Drawing.Point(520, 340);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(194, 33);
            this.lblBudget.TabIndex = 204;
            this.lblBudget.Text = "Bütçe";
            // 
            // txtProductionCompany
            // 
            this.txtProductionCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductionCompany.Location = new System.Drawing.Point(282, 333);
            this.txtProductionCompany.Margin = new System.Windows.Forms.Padding(8);
            this.txtProductionCompany.Name = "txtProductionCompany";
            this.txtProductionCompany.Properties.MaxLength = 4;
            this.txtProductionCompany.Size = new System.Drawing.Size(227, 42);
            this.txtProductionCompany.TabIndex = 192;
            // 
            // lblProductionCompany
            // 
            this.lblProductionCompany.AutoEllipsis = true;
            this.lblProductionCompany.ForeColor = System.Drawing.Color.Black;
            this.lblProductionCompany.Location = new System.Drawing.Point(12, 340);
            this.lblProductionCompany.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblProductionCompany.Name = "lblProductionCompany";
            this.lblProductionCompany.Size = new System.Drawing.Size(255, 33);
            this.lblProductionCompany.TabIndex = 202;
            this.lblProductionCompany.Text = "Yapým Þirketi";
            // 
            // cbDubbing
            // 
            this.cbDubbing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDubbing.Location = new System.Drawing.Point(715, 442);
            this.cbDubbing.Margin = new System.Windows.Forms.Padding(8);
            this.cbDubbing.Name = "cbDubbing";
            this.cbDubbing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDubbing.Properties.DropDownRows = 13;
            this.cbDubbing.Size = new System.Drawing.Size(287, 42);
            this.cbDubbing.TabIndex = 201;
            this.cbDubbing.Popup += new System.EventHandler(this.cbDubbing_Popup);
            // 
            // cbSubTitle
            // 
            this.cbSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubTitle.EditValue = "";
            this.cbSubTitle.Location = new System.Drawing.Point(715, 495);
            this.cbSubTitle.Margin = new System.Windows.Forms.Padding(8);
            this.cbSubTitle.Name = "cbSubTitle";
            this.cbSubTitle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSubTitle.Properties.DropDownRows = 13;
            this.cbSubTitle.Size = new System.Drawing.Size(287, 42);
            this.cbSubTitle.TabIndex = 200;
            this.cbSubTitle.Popup += new System.EventHandler(this.cbSubTitle_Popup);
            // 
            // dgCast
            // 
            this.dgCast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCast.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.dgCast.Location = new System.Drawing.Point(1008, 10);
            this.dgCast.MainView = this.gvCast;
            this.dgCast.Margin = new System.Windows.Forms.Padding(8);
            this.dgCast.Name = "dgCast";
            this.dgCast.Size = new System.Drawing.Size(782, 536);
            this.dgCast.TabIndex = 199;
            this.dgCast.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCast});
            // 
            // gvCast
            // 
            this.gvCast.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.imageColumn,
            this.cl1,
            this.cl2});
            this.gvCast.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvCast.GridControl = this.dgCast;
            this.gvCast.GroupFormat = "{0}: [#image]{1} {2} {3}";
            this.gvCast.Name = "gvCast";
            this.gvCast.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCast.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCast.OptionsBehavior.Editable = false;
            this.gvCast.OptionsCustomization.AllowFilter = false;
            this.gvCast.OptionsCustomization.AllowGroup = false;
            this.gvCast.OptionsCustomization.AllowSort = false;
            this.gvCast.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvCast.OptionsView.ShowGroupPanel = false;
            this.gvCast.OptionsView.ShowIndicator = false;
            this.gvCast.RowHeight = 140;
            this.gvCast.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvCast_RowCellClick);
            this.gvCast.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvCast_CustomUnboundColumnData);
            this.gvCast.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvCast_KeyDown);
            this.gvCast.DoubleClick += new System.EventHandler(this.gvCast_DoubleClick);
            // 
            // imageColumn
            // 
            this.imageColumn.ColumnEdit = this.repositoryItemPictureEdit1;
            this.imageColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.imageColumn.FieldName = "Poster";
            this.imageColumn.Name = "imageColumn";
            this.imageColumn.OptionsColumn.ShowCaption = false;
            this.imageColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.imageColumn.Visible = true;
            this.imageColumn.VisibleIndex = 0;
            this.imageColumn.Width = 45;
            // 
            // cl1
            // 
            this.cl1.Caption = "Oyuncu";
            this.cl1.FieldName = "Name";
            this.cl1.Name = "cl1";
            this.cl1.OptionsFilter.AllowAutoFilter = false;
            this.cl1.OptionsFilter.AllowFilter = false;
            this.cl1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.cl1.Visible = true;
            this.cl1.VisibleIndex = 1;
            this.cl1.Width = 150;
            // 
            // cl2
            // 
            this.cl2.Caption = "Karakter";
            this.cl2.FieldName = "Character";
            this.cl2.Name = "cl2";
            this.cl2.OptionsFilter.AllowAutoFilter = false;
            this.cl2.OptionsFilter.AllowFilter = false;
            this.cl2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.cl2.Visible = true;
            this.cl2.VisibleIndex = 2;
            this.cl2.Width = 132;
            // 
            // txtVotes
            // 
            this.txtVotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVotes.Location = new System.Drawing.Point(715, 388);
            this.txtVotes.Margin = new System.Windows.Forms.Padding(8);
            this.txtVotes.Name = "txtVotes";
            this.txtVotes.Properties.Mask.EditMask = "n0";
            this.txtVotes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtVotes.Properties.Mask.ShowPlaceHolders = false;
            this.txtVotes.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVotes.Properties.MaxLength = 10;
            this.txtVotes.Size = new System.Drawing.Size(287, 42);
            this.txtVotes.TabIndex = 195;
            // 
            // txtRuntime
            // 
            this.txtRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuntime.Location = new System.Drawing.Point(715, 277);
            this.txtRuntime.Margin = new System.Windows.Forms.Padding(8);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Properties.MaxLength = 255;
            this.txtRuntime.Size = new System.Drawing.Size(287, 42);
            this.txtRuntime.TabIndex = 191;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.Location = new System.Drawing.Point(282, 495);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(8);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Properties.MaxLength = 255;
            this.txtCountry.Size = new System.Drawing.Size(227, 42);
            this.txtCountry.TabIndex = 193;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLanguage.Location = new System.Drawing.Point(282, 442);
            this.txtLanguage.Margin = new System.Windows.Forms.Padding(8);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Properties.MaxLength = 255;
            this.txtLanguage.Size = new System.Drawing.Size(227, 42);
            this.txtLanguage.TabIndex = 192;
            // 
            // txtUserRating
            // 
            this.txtUserRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserRating.Location = new System.Drawing.Point(282, 388);
            this.txtUserRating.Margin = new System.Windows.Forms.Padding(8);
            this.txtUserRating.Name = "txtUserRating";
            this.txtUserRating.Properties.MaxLength = 10;
            this.txtUserRating.Size = new System.Drawing.Size(227, 42);
            this.txtUserRating.TabIndex = 191;
            // 
            // txtYear
            // 
            this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYear.Location = new System.Drawing.Point(282, 277);
            this.txtYear.Margin = new System.Windows.Forms.Padding(8);
            this.txtYear.Name = "txtYear";
            this.txtYear.Properties.MaxLength = 4;
            this.txtYear.Size = new System.Drawing.Size(227, 42);
            this.txtYear.TabIndex = 190;
            // 
            // txtWriter
            // 
            this.txtWriter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWriter.Location = new System.Drawing.Point(282, 223);
            this.txtWriter.Margin = new System.Windows.Forms.Padding(8);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Properties.MaxLength = 255;
            this.txtWriter.Size = new System.Drawing.Size(227, 42);
            this.txtWriter.TabIndex = 189;
            // 
            // txtGenre
            // 
            this.txtGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenre.Location = new System.Drawing.Point(282, 170);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(8);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Properties.MaxLength = 255;
            this.txtGenre.Size = new System.Drawing.Size(721, 42);
            this.txtGenre.TabIndex = 188;
            // 
            // txtDirector
            // 
            this.txtDirector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirector.Location = new System.Drawing.Point(282, 117);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(8);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Properties.MaxLength = 255;
            this.txtDirector.Size = new System.Drawing.Size(721, 42);
            this.txtDirector.TabIndex = 187;
            // 
            // txtOtherName
            // 
            this.txtOtherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherName.Location = new System.Drawing.Point(282, 63);
            this.txtOtherName.Margin = new System.Windows.Forms.Padding(8);
            this.txtOtherName.Name = "txtOtherName";
            this.txtOtherName.Properties.MaxLength = 255;
            this.txtOtherName.Size = new System.Drawing.Size(721, 42);
            this.txtOtherName.TabIndex = 186;
            // 
            // txtOrginalName
            // 
            this.txtOrginalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrginalName.Location = new System.Drawing.Point(282, 10);
            this.txtOrginalName.Margin = new System.Windows.Forms.Padding(8);
            this.txtOrginalName.Name = "txtOrginalName";
            this.txtOrginalName.Properties.MaxLength = 255;
            this.txtOrginalName.Size = new System.Drawing.Size(721, 42);
            this.txtOrginalName.TabIndex = 185;
            // 
            // lblDubbing
            // 
            this.lblDubbing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDubbing.AutoEllipsis = true;
            this.lblDubbing.ForeColor = System.Drawing.Color.Black;
            this.lblDubbing.Location = new System.Drawing.Point(520, 447);
            this.lblDubbing.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDubbing.Name = "lblDubbing";
            this.lblDubbing.Size = new System.Drawing.Size(194, 33);
            this.lblDubbing.TabIndex = 183;
            this.lblDubbing.Text = "Dublaj";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.AutoEllipsis = true;
            this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
            this.lblSubtitle.Location = new System.Drawing.Point(520, 500);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(194, 33);
            this.lblSubtitle.TabIndex = 182;
            this.lblSubtitle.Text = "Altyazý";
            // 
            // lblVotes
            // 
            this.lblVotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVotes.AutoEllipsis = true;
            this.lblVotes.ForeColor = System.Drawing.Color.Black;
            this.lblVotes.Location = new System.Drawing.Point(520, 393);
            this.lblVotes.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblVotes.Name = "lblVotes";
            this.lblVotes.Size = new System.Drawing.Size(194, 33);
            this.lblVotes.TabIndex = 179;
            this.lblVotes.Text = "IMDB Oy";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoEllipsis = true;
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(15, 503);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(252, 33);
            this.lblCountry.TabIndex = 178;
            this.lblCountry.Text = "Ülke";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoEllipsis = true;
            this.lblDirector.ForeColor = System.Drawing.Color.Black;
            this.lblDirector.Location = new System.Drawing.Point(15, 124);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(252, 33);
            this.lblDirector.TabIndex = 177;
            this.lblDirector.Text = "Yönetmen";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoEllipsis = true;
            this.lblLanguage.ForeColor = System.Drawing.Color.Black;
            this.lblLanguage.Location = new System.Drawing.Point(15, 449);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(252, 33);
            this.lblLanguage.TabIndex = 176;
            this.lblLanguage.Text = "Filmin Orijinal Dili";
            // 
            // lblRuntime
            // 
            this.lblRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRuntime.AutoEllipsis = true;
            this.lblRuntime.ForeColor = System.Drawing.Color.Black;
            this.lblRuntime.Location = new System.Drawing.Point(520, 284);
            this.lblRuntime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(197, 33);
            this.lblRuntime.TabIndex = 175;
            this.lblRuntime.Text = "Süre";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoEllipsis = true;
            this.lblWriter.ForeColor = System.Drawing.Color.Black;
            this.lblWriter.Location = new System.Drawing.Point(15, 231);
            this.lblWriter.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(252, 33);
            this.lblWriter.TabIndex = 174;
            this.lblWriter.Text = "Senaryo";
            // 
            // lblUserRating
            // 
            this.lblUserRating.AutoEllipsis = true;
            this.lblUserRating.ForeColor = System.Drawing.Color.Black;
            this.lblUserRating.Location = new System.Drawing.Point(15, 396);
            this.lblUserRating.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserRating.Name = "lblUserRating";
            this.lblUserRating.Size = new System.Drawing.Size(252, 33);
            this.lblUserRating.TabIndex = 173;
            this.lblUserRating.Text = "IMDB Puaný";
            // 
            // lblYear
            // 
            this.lblYear.AutoEllipsis = true;
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(12, 284);
            this.lblYear.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(255, 33);
            this.lblYear.TabIndex = 172;
            this.lblYear.Text = "Gösterim Tarihi";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoEllipsis = true;
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(12, 178);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(255, 33);
            this.lblGenre.TabIndex = 171;
            this.lblGenre.Text = "Kategori";
            // 
            // lblTurkishName
            // 
            this.lblTurkishName.AutoEllipsis = true;
            this.lblTurkishName.ForeColor = System.Drawing.Color.Black;
            this.lblTurkishName.Location = new System.Drawing.Point(12, 71);
            this.lblTurkishName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTurkishName.Name = "lblTurkishName";
            this.lblTurkishName.Size = new System.Drawing.Size(255, 33);
            this.lblTurkishName.TabIndex = 170;
            this.lblTurkishName.Text = "Türkçe Ýsim";
            // 
            // lblOrginalName
            // 
            this.lblOrginalName.AutoEllipsis = true;
            this.lblOrginalName.ForeColor = System.Drawing.Color.Black;
            this.lblOrginalName.Location = new System.Drawing.Point(12, 18);
            this.lblOrginalName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOrginalName.Name = "lblOrginalName";
            this.lblOrginalName.Size = new System.Drawing.Size(255, 33);
            this.lblOrginalName.TabIndex = 169;
            this.lblOrginalName.Text = "Orjinal Ýsim";
            // 
            // TabControlPlot
            // 
            this.TabControlPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlPlot.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.TabControlPlot.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.TabControlPlot.Location = new System.Drawing.Point(12, 564);
            this.TabControlPlot.Margin = new System.Windows.Forms.Padding(8);
            this.TabControlPlot.Name = "TabControlPlot";
            this.TabControlPlot.SelectedTabPage = this.tabTurkish;
            this.TabControlPlot.Size = new System.Drawing.Size(1791, 207);
            this.TabControlPlot.TabIndex = 15;
            this.TabControlPlot.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabTurkish,
            this.tabEnglish});
            // 
            // tabTurkish
            // 
            this.tabTurkish.Controls.Add(this.txtOtherPlot);
            this.tabTurkish.Margin = new System.Windows.Forms.Padding(8);
            this.tabTurkish.Name = "tabTurkish";
            this.tabTurkish.PageVisible = false;
            this.tabTurkish.Size = new System.Drawing.Size(1638, 191);
            this.tabTurkish.Text = "  Türkçe";
            // 
            // txtOtherPlot
            // 
            this.txtOtherPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOtherPlot.Location = new System.Drawing.Point(0, 0);
            this.txtOtherPlot.Margin = new System.Windows.Forms.Padding(8);
            this.txtOtherPlot.Name = "txtOtherPlot";
            this.txtOtherPlot.Size = new System.Drawing.Size(1638, 191);
            this.txtOtherPlot.TabIndex = 198;
            // 
            // tabEnglish
            // 
            this.tabEnglish.Controls.Add(this.txtEnglishPlot);
            this.tabEnglish.Margin = new System.Windows.Forms.Padding(8);
            this.tabEnglish.Name = "tabEnglish";
            this.tabEnglish.Size = new System.Drawing.Size(1638, 191);
            this.tabEnglish.Text = "  Ýngilizce";
            // 
            // txtEnglishPlot
            // 
            this.txtEnglishPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEnglishPlot.Location = new System.Drawing.Point(0, 0);
            this.txtEnglishPlot.Margin = new System.Windows.Forms.Padding(8);
            this.txtEnglishPlot.Name = "txtEnglishPlot";
            this.txtEnglishPlot.Size = new System.Drawing.Size(1638, 191);
            this.txtEnglishPlot.TabIndex = 17;
            // 
            // grbMovie
            // 
            this.grbMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbMovie.Controls.Add(this.rgMovieSeen);
            this.grbMovie.Location = new System.Drawing.Point(1835, 556);
            this.grbMovie.Margin = new System.Windows.Forms.Padding(8);
            this.grbMovie.Name = "grbMovie";
            this.grbMovie.Padding = new System.Windows.Forms.Padding(8);
            this.grbMovie.Size = new System.Drawing.Size(355, 192);
            this.grbMovie.TabIndex = 31;
            this.grbMovie.TabStop = false;
            this.grbMovie.Text = "Film";
            // 
            // rgMovieSeen
            // 
            this.rgMovieSeen.EditValue = 0;
            this.rgMovieSeen.Location = new System.Drawing.Point(72, 51);
            this.rgMovieSeen.Margin = new System.Windows.Forms.Padding(8);
            this.rgMovieSeen.Name = "rgMovieSeen";
            this.rgMovieSeen.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Ýzlendi"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Ýzlenmedi")});
            this.rgMovieSeen.Size = new System.Drawing.Size(228, 112);
            this.rgMovieSeen.TabIndex = 18;
            // 
            // tabFileInfo
            // 
            this.tabFileInfo.Controls.Add(this.richTextBox1);
            this.tabFileInfo.Controls.Add(this.btnPlayer);
            this.tabFileInfo.Controls.Add(this.btnDelete);
            this.tabFileInfo.Controls.Add(this.btnMultiAdd);
            this.tabFileInfo.Controls.Add(this.btnAdd);
            this.tabFileInfo.Controls.Add(this.dgFileList);
            this.tabFileInfo.Margin = new System.Windows.Forms.Padding(8);
            this.tabFileInfo.Name = "tabFileInfo";
            this.tabFileInfo.Size = new System.Drawing.Size(2209, 771);
            this.tabFileInfo.Text = "Dosya Bilgileri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(1280, 8);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(922, 743);
            this.richTextBox1.TabIndex = 105;
            this.richTextBox1.Text = "";
            // 
            // btnPlayer
            // 
            this.btnPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayer.Image")));
            this.btnPlayer.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPlayer.Location = new System.Drawing.Point(1125, 284);
            this.btnPlayer.Margin = new System.Windows.Forms.Padding(8);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(142, 102);
            this.btnPlayer.TabIndex = 4;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1125, 170);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 76);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(1125, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 76);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgFileList
            // 
            this.dgFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFileList.DataSource = this.tFilesBindingSource;
            this.dgFileList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.dgFileList.Location = new System.Drawing.Point(8, 8);
            this.dgFileList.MainView = this.gvFiles;
            this.dgFileList.Margin = new System.Windows.Forms.Padding(8);
            this.dgFileList.Name = "dgFileList";
            this.dgFileList.Size = new System.Drawing.Size(1102, 749);
            this.dgFileList.TabIndex = 0;
            this.dgFileList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFiles});
            // 
            // tFilesBindingSource
            // 
            this.tFilesBindingSource.DataMember = "Files";
            this.tFilesBindingSource.DataSource = this.dsFiles;
            // 
            // dsFiles
            // 
            this.dsFiles.DataSetName = "dsFiles";
            this.dsFiles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvFiles
            // 
            this.gvFiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_FileID,
            this.cl_FileName,
            this.cl_Resolution,
            this.cl_VideoCodec,
            this.cl_VideoBitrate,
            this.cl_Fps,
            this.cl_VideoAspectRatio,
            this.cl_AudioCodec1,
            this.cl_AudioChannels1,
            this.cl_AudioBitrate1,
            this.cl_AudioSampleRate1,
            this.cl_AudioSize1,
            this.cl_AudioCodec2,
            this.cl_AudioChannels2,
            this.cl_AudioBitrate2,
            this.cl_AudioSampleRate2,
            this.cl_AudioSize2,
            this.cl_TotalFrames,
            this.cl_Lenght,
            this.cl_VideoSize,
            this.cl_FileSize,
            this.cl_Chapter});
            this.gvFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvFiles.GridControl = this.dgFileList;
            this.gvFiles.Name = "gvFiles";
            this.gvFiles.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvFiles.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvFiles.OptionsSelection.MultiSelect = true;
            this.gvFiles.OptionsSelection.UseIndicatorForSelection = false;
            this.gvFiles.OptionsView.ShowGroupPanel = false;
            this.gvFiles.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvFiles_SelectionChanged);
            // 
            // cl_FileID
            // 
            this.cl_FileID.Caption = "kMovie";
            this.cl_FileID.FieldName = "_id";
            this.cl_FileID.Name = "cl_FileID";
            // 
            // cl_FileName
            // 
            this.cl_FileName.Caption = "Dosya Adý";
            this.cl_FileName.FieldName = "FileName";
            this.cl_FileName.Name = "cl_FileName";
            this.cl_FileName.OptionsFilter.AllowAutoFilter = false;
            this.cl_FileName.OptionsFilter.AllowFilter = false;
            this.cl_FileName.Visible = true;
            this.cl_FileName.VisibleIndex = 0;
            // 
            // cl_Resolution
            // 
            this.cl_Resolution.Caption = "strResolution";
            this.cl_Resolution.FieldName = "Resolution";
            this.cl_Resolution.Name = "cl_Resolution";
            // 
            // cl_VideoCodec
            // 
            this.cl_VideoCodec.Caption = "strVideoCodec";
            this.cl_VideoCodec.FieldName = "VideoCodec";
            this.cl_VideoCodec.Name = "cl_VideoCodec";
            // 
            // cl_VideoBitrate
            // 
            this.cl_VideoBitrate.Caption = "strVideoBitrate";
            this.cl_VideoBitrate.FieldName = "VideoBitrate";
            this.cl_VideoBitrate.Name = "cl_VideoBitrate";
            // 
            // cl_Fps
            // 
            this.cl_Fps.Caption = "strFps";
            this.cl_Fps.FieldName = "Fps";
            this.cl_Fps.Name = "cl_Fps";
            // 
            // cl_VideoAspectRatio
            // 
            this.cl_VideoAspectRatio.Caption = "strVideoAspectRatio";
            this.cl_VideoAspectRatio.FieldName = "VideoAspectRatio";
            this.cl_VideoAspectRatio.Name = "cl_VideoAspectRatio";
            // 
            // cl_AudioCodec1
            // 
            this.cl_AudioCodec1.Caption = "strAudioCodec1";
            this.cl_AudioCodec1.FieldName = "AudioCodec1";
            this.cl_AudioCodec1.Name = "cl_AudioCodec1";
            // 
            // cl_AudioChannels1
            // 
            this.cl_AudioChannels1.Caption = "strAudioChannels1";
            this.cl_AudioChannels1.FieldName = "AudioChannels1";
            this.cl_AudioChannels1.Name = "cl_AudioChannels1";
            // 
            // cl_AudioBitrate1
            // 
            this.cl_AudioBitrate1.Caption = "strAudioBitrate1";
            this.cl_AudioBitrate1.FieldName = "AudioBitrate1";
            this.cl_AudioBitrate1.Name = "cl_AudioBitrate1";
            // 
            // cl_AudioSampleRate1
            // 
            this.cl_AudioSampleRate1.Caption = "strAudioSampleRate1";
            this.cl_AudioSampleRate1.FieldName = "AudioSampleRate1";
            this.cl_AudioSampleRate1.Name = "cl_AudioSampleRate1";
            // 
            // cl_AudioSize1
            // 
            this.cl_AudioSize1.Caption = "strAudioSize1";
            this.cl_AudioSize1.FieldName = "AudioSize1";
            this.cl_AudioSize1.Name = "cl_AudioSize1";
            // 
            // cl_AudioCodec2
            // 
            this.cl_AudioCodec2.Caption = "strAudioCodec2";
            this.cl_AudioCodec2.FieldName = "AudioCodec2";
            this.cl_AudioCodec2.Name = "cl_AudioCodec2";
            // 
            // cl_AudioChannels2
            // 
            this.cl_AudioChannels2.Caption = "strAudioChannels2";
            this.cl_AudioChannels2.FieldName = "AudioChannels2";
            this.cl_AudioChannels2.Name = "cl_AudioChannels2";
            // 
            // cl_AudioBitrate2
            // 
            this.cl_AudioBitrate2.Caption = "strAudioBitrate2";
            this.cl_AudioBitrate2.FieldName = "AudioBitrate2";
            this.cl_AudioBitrate2.Name = "cl_AudioBitrate2";
            // 
            // cl_AudioSampleRate2
            // 
            this.cl_AudioSampleRate2.Caption = "strAudioSampleRate2";
            this.cl_AudioSampleRate2.FieldName = "AudioSampleRate2";
            this.cl_AudioSampleRate2.Name = "cl_AudioSampleRate2";
            // 
            // cl_AudioSize2
            // 
            this.cl_AudioSize2.Caption = "strAudioSize2";
            this.cl_AudioSize2.FieldName = "AudioSize2";
            this.cl_AudioSize2.Name = "cl_AudioSize2";
            // 
            // cl_TotalFrames
            // 
            this.cl_TotalFrames.Caption = "strTotalFrames";
            this.cl_TotalFrames.FieldName = "TotalFrames";
            this.cl_TotalFrames.Name = "cl_TotalFrames";
            // 
            // cl_Lenght
            // 
            this.cl_Lenght.Caption = "strLenght";
            this.cl_Lenght.FieldName = "Lenght";
            this.cl_Lenght.Name = "cl_Lenght";
            // 
            // cl_VideoSize
            // 
            this.cl_VideoSize.Caption = "strVideoSize";
            this.cl_VideoSize.FieldName = "VideoSize";
            this.cl_VideoSize.Name = "cl_VideoSize";
            // 
            // cl_FileSize
            // 
            this.cl_FileSize.Caption = "strFileSize";
            this.cl_FileSize.FieldName = "FileSize";
            this.cl_FileSize.Name = "cl_FileSize";
            // 
            // cl_Chapter
            // 
            this.cl_Chapter.Caption = "Bölüm";
            this.cl_Chapter.FieldName = "Chapter";
            this.cl_Chapter.Name = "cl_Chapter";
            this.cl_Chapter.Width = 35;
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.txtTmdbNumber);
            this.tabOther.Controls.Add(this.cbUserColumn6);
            this.tabOther.Controls.Add(this.lblUserColumn6);
            this.tabOther.Controls.Add(this.cbUserColumn5);
            this.tabOther.Controls.Add(this.lblUserColumn5);
            this.tabOther.Controls.Add(this.cbRlsGroup);
            this.tabOther.Controls.Add(this.cbRlsType);
            this.tabOther.Controls.Add(this.lblRlsGroup);
            this.tabOther.Controls.Add(this.lblRlsType);
            this.tabOther.Controls.Add(this.txtTmdbVotes);
            this.tabOther.Controls.Add(this.txtTmdbUserRating);
            this.tabOther.Controls.Add(this.txtImdbVotes);
            this.tabOther.Controls.Add(this.txtImdbUserRating);
            this.tabOther.Controls.Add(this.txtPoster);
            this.tabOther.Controls.Add(this.cbUserColumn4);
            this.tabOther.Controls.Add(this.cbUserColumn3);
            this.tabOther.Controls.Add(this.cbUserColumn2);
            this.tabOther.Controls.Add(this.cbUserColumn1);
            this.tabOther.Controls.Add(this.lblChangeDate);
            this.tabOther.Controls.Add(this.lblDateEntered);
            this.tabOther.Controls.Add(this.txtNote);
            this.tabOther.Controls.Add(this.txtPersonalRating);
            this.tabOther.Controls.Add(this.txtImdbNumber);
            this.tabOther.Controls.Add(this.txtArchivesNumber);
            this.tabOther.Controls.Add(this.lblUserColumn4);
            this.tabOther.Controls.Add(this.lblUserColumn3);
            this.tabOther.Controls.Add(this.lblUserColumn2);
            this.tabOther.Controls.Add(this.lblUserColumn1);
            this.tabOther.Controls.Add(this.lblPersonalRating);
            this.tabOther.Controls.Add(this.lblNote);
            this.tabOther.Controls.Add(this.lblChangeDate22);
            this.tabOther.Controls.Add(this.lblDateEntered22);
            this.tabOther.Controls.Add(this.lblArchivesNumber);
            this.tabOther.Controls.Add(this.lblImdbNumber);
            this.tabOther.Controls.Add(this.btnImdb);
            this.tabOther.Margin = new System.Windows.Forms.Padding(8);
            this.tabOther.Name = "tabOther";
            this.tabOther.Size = new System.Drawing.Size(2209, 771);
            this.tabOther.Text = "Diðer";
            // 
            // txtTmdbNumber
            // 
            this.txtTmdbNumber.Location = new System.Drawing.Point(1842, 279);
            this.txtTmdbNumber.Margin = new System.Windows.Forms.Padding(8);
            this.txtTmdbNumber.Name = "txtTmdbNumber";
            this.txtTmdbNumber.Properties.MaxLength = 100;
            this.txtTmdbNumber.Size = new System.Drawing.Size(128, 42);
            this.txtTmdbNumber.TabIndex = 254;
            this.txtTmdbNumber.Visible = false;
            // 
            // cbUserColumn6
            // 
            this.cbUserColumn6.Location = new System.Drawing.Point(312, 690);
            this.cbUserColumn6.Margin = new System.Windows.Forms.Padding(8);
            this.cbUserColumn6.Name = "cbUserColumn6";
            this.cbUserColumn6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUserColumn6.Properties.MaxLength = 100;
            this.cbUserColumn6.Size = new System.Drawing.Size(702, 42);
            this.cbUserColumn6.TabIndex = 253;
            // 
            // lblUserColumn6
            // 
            this.lblUserColumn6.AutoEllipsis = true;
            this.lblUserColumn6.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn6.Location = new System.Drawing.Point(12, 698);
            this.lblUserColumn6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserColumn6.Name = "lblUserColumn6";
            this.lblUserColumn6.Size = new System.Drawing.Size(288, 33);
            this.lblUserColumn6.TabIndex = 252;
            this.lblUserColumn6.Text = "6. Alan";
            this.lblUserColumn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbUserColumn5
            // 
            this.cbUserColumn5.Location = new System.Drawing.Point(312, 627);
            this.cbUserColumn5.Margin = new System.Windows.Forms.Padding(8);
            this.cbUserColumn5.Name = "cbUserColumn5";
            this.cbUserColumn5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUserColumn5.Properties.MaxLength = 100;
            this.cbUserColumn5.Size = new System.Drawing.Size(702, 42);
            this.cbUserColumn5.TabIndex = 251;
            // 
            // lblUserColumn5
            // 
            this.lblUserColumn5.AutoEllipsis = true;
            this.lblUserColumn5.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn5.Location = new System.Drawing.Point(12, 635);
            this.lblUserColumn5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserColumn5.Name = "lblUserColumn5";
            this.lblUserColumn5.Size = new System.Drawing.Size(288, 33);
            this.lblUserColumn5.TabIndex = 250;
            this.lblUserColumn5.Text = "5. Alan";
            this.lblUserColumn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRlsGroup
            // 
            this.cbRlsGroup.Location = new System.Drawing.Point(312, 284);
            this.cbRlsGroup.Margin = new System.Windows.Forms.Padding(8);
            this.cbRlsGroup.Name = "cbRlsGroup";
            this.cbRlsGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRlsGroup.Properties.MaxLength = 100;
            this.cbRlsGroup.Size = new System.Drawing.Size(702, 42);
            this.cbRlsGroup.TabIndex = 249;
            // 
            // cbRlsType
            // 
            this.cbRlsType.Location = new System.Drawing.Point(312, 223);
            this.cbRlsType.Margin = new System.Windows.Forms.Padding(8);
            this.cbRlsType.Name = "cbRlsType";
            this.cbRlsType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRlsType.Properties.MaxLength = 100;
            this.cbRlsType.Size = new System.Drawing.Size(702, 42);
            this.cbRlsType.TabIndex = 248;
            // 
            // lblRlsGroup
            // 
            this.lblRlsGroup.AutoEllipsis = true;
            this.lblRlsGroup.ForeColor = System.Drawing.Color.Black;
            this.lblRlsGroup.Location = new System.Drawing.Point(12, 292);
            this.lblRlsGroup.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRlsGroup.Name = "lblRlsGroup";
            this.lblRlsGroup.Size = new System.Drawing.Size(288, 33);
            this.lblRlsGroup.TabIndex = 247;
            this.lblRlsGroup.Text = "Rls Grup";
            this.lblRlsGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRlsType
            // 
            this.lblRlsType.AutoEllipsis = true;
            this.lblRlsType.ForeColor = System.Drawing.Color.Black;
            this.lblRlsType.Location = new System.Drawing.Point(12, 231);
            this.lblRlsType.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRlsType.Name = "lblRlsType";
            this.lblRlsType.Size = new System.Drawing.Size(288, 33);
            this.lblRlsType.TabIndex = 246;
            this.lblRlsType.Text = "Rls Türü";
            this.lblRlsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTmdbVotes
            // 
            this.txtTmdbVotes.Location = new System.Drawing.Point(2088, 282);
            this.txtTmdbVotes.Margin = new System.Windows.Forms.Padding(8);
            this.txtTmdbVotes.Name = "txtTmdbVotes";
            this.txtTmdbVotes.Properties.MaxLength = 255;
            this.txtTmdbVotes.Size = new System.Drawing.Size(88, 42);
            this.txtTmdbVotes.TabIndex = 245;
            this.txtTmdbVotes.Visible = false;
            // 
            // txtTmdbUserRating
            // 
            this.txtTmdbUserRating.Location = new System.Drawing.Point(2088, 223);
            this.txtTmdbUserRating.Margin = new System.Windows.Forms.Padding(8);
            this.txtTmdbUserRating.Name = "txtTmdbUserRating";
            this.txtTmdbUserRating.Properties.MaxLength = 255;
            this.txtTmdbUserRating.Size = new System.Drawing.Size(88, 42);
            this.txtTmdbUserRating.TabIndex = 244;
            this.txtTmdbUserRating.Visible = false;
            // 
            // txtImdbVotes
            // 
            this.txtImdbVotes.Location = new System.Drawing.Point(1985, 282);
            this.txtImdbVotes.Margin = new System.Windows.Forms.Padding(8);
            this.txtImdbVotes.Name = "txtImdbVotes";
            this.txtImdbVotes.Properties.MaxLength = 255;
            this.txtImdbVotes.Size = new System.Drawing.Size(88, 42);
            this.txtImdbVotes.TabIndex = 243;
            this.txtImdbVotes.Visible = false;
            // 
            // txtImdbUserRating
            // 
            this.txtImdbUserRating.Location = new System.Drawing.Point(1985, 223);
            this.txtImdbUserRating.Margin = new System.Windows.Forms.Padding(8);
            this.txtImdbUserRating.Name = "txtImdbUserRating";
            this.txtImdbUserRating.Properties.MaxLength = 255;
            this.txtImdbUserRating.Size = new System.Drawing.Size(88, 42);
            this.txtImdbUserRating.TabIndex = 242;
            this.txtImdbUserRating.Visible = false;
            // 
            // txtPoster
            // 
            this.txtPoster.Location = new System.Drawing.Point(1152, 345);
            this.txtPoster.Margin = new System.Windows.Forms.Padding(8);
            this.txtPoster.Name = "txtPoster";
            this.txtPoster.Properties.MaxLength = 255;
            this.txtPoster.Size = new System.Drawing.Size(1028, 42);
            this.txtPoster.TabIndex = 241;
            this.txtPoster.Visible = false;
            // 
            // cbUserColumn4
            // 
            this.cbUserColumn4.Location = new System.Drawing.Point(312, 564);
            this.cbUserColumn4.Margin = new System.Windows.Forms.Padding(8);
            this.cbUserColumn4.Name = "cbUserColumn4";
            this.cbUserColumn4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUserColumn4.Properties.MaxLength = 100;
            this.cbUserColumn4.Size = new System.Drawing.Size(702, 42);
            this.cbUserColumn4.TabIndex = 240;
            // 
            // cbUserColumn3
            // 
            this.cbUserColumn3.Location = new System.Drawing.Point(312, 503);
            this.cbUserColumn3.Margin = new System.Windows.Forms.Padding(8);
            this.cbUserColumn3.Name = "cbUserColumn3";
            this.cbUserColumn3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUserColumn3.Properties.MaxLength = 100;
            this.cbUserColumn3.Size = new System.Drawing.Size(702, 42);
            this.cbUserColumn3.TabIndex = 239;
            // 
            // cbUserColumn2
            // 
            this.cbUserColumn2.Location = new System.Drawing.Point(312, 442);
            this.cbUserColumn2.Margin = new System.Windows.Forms.Padding(8);
            this.cbUserColumn2.Name = "cbUserColumn2";
            this.cbUserColumn2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUserColumn2.Properties.MaxLength = 100;
            this.cbUserColumn2.Size = new System.Drawing.Size(702, 42);
            this.cbUserColumn2.TabIndex = 238;
            // 
            // cbUserColumn1
            // 
            this.cbUserColumn1.Location = new System.Drawing.Point(312, 381);
            this.cbUserColumn1.Margin = new System.Windows.Forms.Padding(8);
            this.cbUserColumn1.Name = "cbUserColumn1";
            this.cbUserColumn1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUserColumn1.Properties.MaxLength = 100;
            this.cbUserColumn1.Size = new System.Drawing.Size(702, 42);
            this.cbUserColumn1.TabIndex = 237;
            // 
            // lblChangeDate
            // 
            this.lblChangeDate.AutoEllipsis = true;
            this.lblChangeDate.ForeColor = System.Drawing.Color.Black;
            this.lblChangeDate.Location = new System.Drawing.Point(1768, 84);
            this.lblChangeDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblChangeDate.Name = "lblChangeDate";
            this.lblChangeDate.Size = new System.Drawing.Size(408, 33);
            this.lblChangeDate.TabIndex = 235;
            this.lblChangeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateEntered
            // 
            this.lblDateEntered.AutoEllipsis = true;
            this.lblDateEntered.ForeColor = System.Drawing.Color.Black;
            this.lblDateEntered.Location = new System.Drawing.Point(1775, 20);
            this.lblDateEntered.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDateEntered.Name = "lblDateEntered";
            this.lblDateEntered.Size = new System.Drawing.Size(400, 33);
            this.lblDateEntered.TabIndex = 234;
            this.lblDateEntered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(1255, 513);
            this.txtNote.Margin = new System.Windows.Forms.Padding(8);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(932, 228);
            this.txtNote.TabIndex = 200;
            // 
            // txtPersonalRating
            // 
            this.txtPersonalRating.Location = new System.Drawing.Point(312, 157);
            this.txtPersonalRating.Margin = new System.Windows.Forms.Padding(8);
            this.txtPersonalRating.Name = "txtPersonalRating";
            this.txtPersonalRating.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPersonalRating.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPersonalRating.Size = new System.Drawing.Size(200, 42);
            this.txtPersonalRating.TabIndex = 195;
            // 
            // txtImdbNumber
            // 
            this.txtImdbNumber.Location = new System.Drawing.Point(312, 89);
            this.txtImdbNumber.Margin = new System.Windows.Forms.Padding(8);
            this.txtImdbNumber.Name = "txtImdbNumber";
            this.txtImdbNumber.Properties.MaxLength = 100;
            this.txtImdbNumber.Size = new System.Drawing.Size(302, 42);
            this.txtImdbNumber.TabIndex = 192;
            // 
            // txtArchivesNumber
            // 
            this.txtArchivesNumber.Location = new System.Drawing.Point(312, 18);
            this.txtArchivesNumber.Margin = new System.Windows.Forms.Padding(8);
            this.txtArchivesNumber.Name = "txtArchivesNumber";
            this.txtArchivesNumber.Properties.Mask.EditMask = "f0";
            this.txtArchivesNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtArchivesNumber.Properties.MaxLength = 255;
            this.txtArchivesNumber.Size = new System.Drawing.Size(302, 42);
            this.txtArchivesNumber.TabIndex = 191;
            // 
            // lblUserColumn4
            // 
            this.lblUserColumn4.AutoEllipsis = true;
            this.lblUserColumn4.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn4.Location = new System.Drawing.Point(12, 571);
            this.lblUserColumn4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserColumn4.Name = "lblUserColumn4";
            this.lblUserColumn4.Size = new System.Drawing.Size(288, 33);
            this.lblUserColumn4.TabIndex = 216;
            this.lblUserColumn4.Text = "4. Alan";
            this.lblUserColumn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserColumn3
            // 
            this.lblUserColumn3.AutoEllipsis = true;
            this.lblUserColumn3.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn3.Location = new System.Drawing.Point(12, 510);
            this.lblUserColumn3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserColumn3.Name = "lblUserColumn3";
            this.lblUserColumn3.Size = new System.Drawing.Size(288, 33);
            this.lblUserColumn3.TabIndex = 215;
            this.lblUserColumn3.Text = "3. Alan";
            this.lblUserColumn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserColumn2
            // 
            this.lblUserColumn2.AutoEllipsis = true;
            this.lblUserColumn2.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn2.Location = new System.Drawing.Point(12, 449);
            this.lblUserColumn2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserColumn2.Name = "lblUserColumn2";
            this.lblUserColumn2.Size = new System.Drawing.Size(288, 33);
            this.lblUserColumn2.TabIndex = 214;
            this.lblUserColumn2.Text = "2. Alan";
            this.lblUserColumn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserColumn1
            // 
            this.lblUserColumn1.AutoEllipsis = true;
            this.lblUserColumn1.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn1.Location = new System.Drawing.Point(12, 388);
            this.lblUserColumn1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserColumn1.Name = "lblUserColumn1";
            this.lblUserColumn1.Size = new System.Drawing.Size(288, 33);
            this.lblUserColumn1.TabIndex = 213;
            this.lblUserColumn1.Text = "1. Alan";
            this.lblUserColumn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPersonalRating
            // 
            this.lblPersonalRating.AutoEllipsis = true;
            this.lblPersonalRating.ForeColor = System.Drawing.Color.Black;
            this.lblPersonalRating.Location = new System.Drawing.Point(12, 165);
            this.lblPersonalRating.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPersonalRating.Name = "lblPersonalRating";
            this.lblPersonalRating.Size = new System.Drawing.Size(288, 38);
            this.lblPersonalRating.TabIndex = 211;
            this.lblPersonalRating.Text = "Kiþisel Puan";
            this.lblPersonalRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNote
            // 
            this.lblNote.AutoEllipsis = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Location = new System.Drawing.Point(1142, 515);
            this.lblNote.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(95, 71);
            this.lblNote.TabIndex = 209;
            this.lblNote.Text = "Not";
            // 
            // lblChangeDate22
            // 
            this.lblChangeDate22.AutoEllipsis = true;
            this.lblChangeDate22.ForeColor = System.Drawing.Color.Black;
            this.lblChangeDate22.Location = new System.Drawing.Point(1530, 84);
            this.lblChangeDate22.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblChangeDate22.Name = "lblChangeDate22";
            this.lblChangeDate22.Size = new System.Drawing.Size(222, 33);
            this.lblChangeDate22.TabIndex = 207;
            this.lblChangeDate22.Text = "Deðiþtirme Tarihi";
            // 
            // lblDateEntered22
            // 
            this.lblDateEntered22.AutoEllipsis = true;
            this.lblDateEntered22.ForeColor = System.Drawing.Color.Black;
            this.lblDateEntered22.Location = new System.Drawing.Point(1530, 20);
            this.lblDateEntered22.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDateEntered22.Name = "lblDateEntered22";
            this.lblDateEntered22.Size = new System.Drawing.Size(222, 33);
            this.lblDateEntered22.TabIndex = 206;
            this.lblDateEntered22.Text = "Eklenme Tarihi";
            // 
            // lblArchivesNumber
            // 
            this.lblArchivesNumber.AutoEllipsis = true;
            this.lblArchivesNumber.ForeColor = System.Drawing.Color.Black;
            this.lblArchivesNumber.Location = new System.Drawing.Point(12, 25);
            this.lblArchivesNumber.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblArchivesNumber.Name = "lblArchivesNumber";
            this.lblArchivesNumber.Size = new System.Drawing.Size(288, 33);
            this.lblArchivesNumber.TabIndex = 205;
            this.lblArchivesNumber.Text = "Arþiv No";
            // 
            // lblImdbNumber
            // 
            this.lblImdbNumber.AutoEllipsis = true;
            this.lblImdbNumber.ForeColor = System.Drawing.Color.Black;
            this.lblImdbNumber.Location = new System.Drawing.Point(12, 96);
            this.lblImdbNumber.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblImdbNumber.Name = "lblImdbNumber";
            this.lblImdbNumber.Size = new System.Drawing.Size(288, 33);
            this.lblImdbNumber.TabIndex = 204;
            this.lblImdbNumber.Text = "IMDB No";
            // 
            // btnImdb
            // 
            this.btnImdb.BackgroundImage = global::GrieeX.Properties.Resources.GlobeConnected;
            this.btnImdb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImdb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImdb.FlatAppearance.BorderSize = 0;
            this.btnImdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImdb.Location = new System.Drawing.Point(630, 84);
            this.btnImdb.Margin = new System.Windows.Forms.Padding(8);
            this.btnImdb.Name = "btnImdb";
            this.btnImdb.Size = new System.Drawing.Size(62, 58);
            this.btnImdb.TabIndex = 212;
            this.btnImdb.TabStop = false;
            this.btnImdb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImdb.UseVisualStyleBackColor = true;
            this.btnImdb.Click += new System.EventHandler(this.btnImdb_Click);
            // 
            // mnuCastList
            // 
            this.mnuCastList.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuCastList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuEdit,
            this.mnuDelete,
            this.mnuGoToImdbPage});
            this.mnuCastList.Name = "mnuCastList";
            this.mnuCastList.Size = new System.Drawing.Size(383, 188);
            this.mnuCastList.Text = "Deðiþtir";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Image = global::GrieeX.Properties.Resources.Add;
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(382, 46);
            this.mnuAdd.Text = "Ekle";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Image = global::GrieeX.Properties.Resources.Edit;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(382, 46);
            this.mnuEdit.Text = "Deðiþtir";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Image = global::GrieeX.Properties.Resources.Delete;
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(382, 46);
            this.mnuDelete.Text = "Sil";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuGoToImdbPage
            // 
            this.mnuGoToImdbPage.Image = global::GrieeX.Properties.Resources.Connected;
            this.mnuGoToImdbPage.Name = "mnuGoToImdbPage";
            this.mnuGoToImdbPage.Size = new System.Drawing.Size(382, 46);
            this.mnuGoToImdbPage.Text = "IMDB Sayfasýna Git";
            this.mnuGoToImdbPage.Click += new System.EventHandler(this.mnuGoToImdbPage_Click);
            // 
            // icImages
            // 
            this.icImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icImages.ImageStream")));
            this.icImages.Images.SetKeyName(0, "Connected.png");
            // 
            // btnSave
            // 
            this.btnSave.AllowFocus = false;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(2175, 8);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 41);
            this.btnSave.TabIndex = 31;
            this.btnSave.ToolTip = "Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MovieDetail";
            this.Size = new System.Drawing.Size(2225, 840);
            this.Load += new System.EventHandler(this.ucMovieDetail_Load);
            this.VisibleChanged += new System.EventHandler(this.ucMovieDetail_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabMovieInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage.Properties)).EndInit();
            this.mnuImage.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtReleaseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBudget.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductionCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDubbing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuntime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserRating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWriter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrginalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlPlot)).EndInit();
            this.TabControlPlot.ResumeLayout(false);
            this.tabTurkish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherPlot.Properties)).EndInit();
            this.tabEnglish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglishPlot.Properties)).EndInit();
            this.grbMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgMovieSeen.Properties)).EndInit();
            this.tabFileInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFileList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).EndInit();
            this.tabOther.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTmdbNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRlsGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRlsType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTmdbVotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTmdbUserRating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImdbVotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImdbUserRating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserColumn1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalRating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImdbNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArchivesNumber.Properties)).EndInit();
            this.mnuCastList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabMovieInfo;
        private DevExpress.XtraTab.XtraTabPage tabFileInfo;
        private DevExpress.XtraTab.XtraTabPage tabOther;
        private System.Windows.Forms.GroupBox grbMovie;
        private DevExpress.XtraEditors.RadioGroup rgMovieSeen;
        private DevExpress.XtraEditors.SimpleButton btnPlayer;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        internal System.Windows.Forms.Label lblUserColumn4;
        internal System.Windows.Forms.Label lblUserColumn3;
        internal System.Windows.Forms.Label lblUserColumn2;
        internal System.Windows.Forms.Label lblUserColumn1;
        internal System.Windows.Forms.Label lblPersonalRating;
        internal System.Windows.Forms.Label lblNote;
        internal System.Windows.Forms.Label lblChangeDate22;
        internal System.Windows.Forms.Label lblDateEntered22;
        internal System.Windows.Forms.Label lblArchivesNumber;
        internal System.Windows.Forms.Label lblImdbNumber;
        internal System.Windows.Forms.Button btnImdb;
        internal System.Windows.Forms.ContextMenuStrip mnuImage;
        internal System.Windows.Forms.ToolStripMenuItem mnuSelectImage;
        internal System.Windows.Forms.ToolStripMenuItem mnuDeleteImage;
        internal System.Windows.Forms.ContextMenuStrip mnuCastList;
        internal System.Windows.Forms.ToolStripMenuItem mnuAdd;
        internal System.Windows.Forms.ToolStripMenuItem mnuEdit;
        internal System.Windows.Forms.ToolStripMenuItem mnuDelete;
        internal System.Windows.Forms.ToolStripMenuItem mnuGoToImdbPage;
        private DevExpress.XtraGrid.Columns.GridColumn cl_FileID;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Resolution;
        private DevExpress.XtraGrid.Columns.GridColumn cl_VideoCodec;
        private DevExpress.XtraGrid.Columns.GridColumn cl_VideoBitrate;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Fps;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioCodec1;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioChannels1;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioBitrate1;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioSampleRate1;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioSize1;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioCodec2;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioChannels2;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioBitrate2;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioSampleRate2;
        private DevExpress.XtraGrid.Columns.GridColumn cl_AudioSize2;
        private DevExpress.XtraGrid.Columns.GridColumn cl_TotalFrames;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Lenght;
        private DevExpress.XtraGrid.Columns.GridColumn cl_VideoSize;
        private DevExpress.XtraGrid.Columns.GridColumn cl_FileSize;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Chapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public DevExpress.XtraGrid.GridControl dgFileList;
        public DevExpress.XtraGrid.Views.Grid.GridView gvFiles;
        public DevExpress.XtraGrid.Columns.GridColumn cl_FileName;
        internal DevExpress.XtraEditors.MemoEdit txtEnglishPlot;
        internal DevExpress.XtraEditors.MemoEdit txtOtherPlot;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblDubbing;
        internal System.Windows.Forms.Label lblSubtitle;
        internal System.Windows.Forms.Label lblVotes;
        internal System.Windows.Forms.Label lblCountry;
        internal System.Windows.Forms.Label lblDirector;
        internal System.Windows.Forms.Label lblLanguage;
        internal System.Windows.Forms.Label lblRuntime;
        internal System.Windows.Forms.Label lblWriter;
        internal System.Windows.Forms.Label lblUserRating;
        internal System.Windows.Forms.Label lblYear;
        internal System.Windows.Forms.Label lblGenre;
        internal System.Windows.Forms.Label lblTurkishName;
        internal System.Windows.Forms.Label lblOrginalName;
        public DevExpress.XtraTab.XtraTabControl TabControlPlot;
        public DevExpress.XtraTab.XtraTabPage tabEnglish;
        public DevExpress.XtraTab.XtraTabPage tabTurkish;
        private DevExpress.XtraEditors.SimpleButton btnMultiAdd;
        internal DevExpress.XtraEditors.TextEdit txtOrginalName;
        internal DevExpress.XtraEditors.TextEdit txtOtherName;
        internal DevExpress.XtraEditors.TextEdit txtGenre;
        internal DevExpress.XtraEditors.TextEdit txtDirector;
        internal DevExpress.XtraEditors.TextEdit txtWriter;
        internal DevExpress.XtraEditors.TextEdit txtYear;
        internal DevExpress.XtraEditors.TextEdit txtLanguage;
        internal DevExpress.XtraEditors.TextEdit txtUserRating;
        internal DevExpress.XtraEditors.TextEdit txtCountry;
        internal DevExpress.XtraEditors.TextEdit txtRuntime;
        internal DevExpress.XtraEditors.TextEdit txtVotes;
        internal DevExpress.XtraEditors.TextEdit txtArchivesNumber;
        internal DevExpress.XtraEditors.MemoEdit txtNote;
        internal DevExpress.XtraEditors.TextEdit txtPersonalRating;
        internal DevExpress.XtraEditors.TextEdit txtImdbNumber;
        private DevExpress.XtraGrid.Columns.GridColumn cl1;
        private DevExpress.XtraGrid.Columns.GridColumn cl2;
        private DevExpress.Utils.ImageCollection icImages;
        private DevExpress.XtraGrid.Columns.GridColumn cl_VideoAspectRatio;
        private System.Windows.Forms.BindingSource tFilesBindingSource;
        internal DataSets.dsFiles dsFiles;
        internal System.Windows.Forms.Label lblChangeDate;
        internal System.Windows.Forms.Label lblDateEntered;
        public DevExpress.XtraEditors.CheckedComboBoxEdit cbSubTitle;
        public DevExpress.XtraEditors.CheckedComboBoxEdit cbDubbing;
        private DevExpress.XtraEditors.ComboBoxEdit cbUserColumn1;
        private DevExpress.XtraEditors.ComboBoxEdit cbUserColumn4;
        private DevExpress.XtraEditors.ComboBoxEdit cbUserColumn3;
        private DevExpress.XtraEditors.ComboBoxEdit cbUserColumn2;
        internal DevExpress.XtraEditors.TextEdit txtPoster;
        internal DevExpress.XtraEditors.TextEdit txtBudget;
        internal System.Windows.Forms.Label lblBudget;
        internal DevExpress.XtraEditors.TextEdit txtProductionCompany;
        internal System.Windows.Forms.Label lblProductionCompany;
        internal DevExpress.XtraEditors.TextEdit txtTmdbVotes;
        internal DevExpress.XtraEditors.TextEdit txtTmdbUserRating;
        internal DevExpress.XtraEditors.TextEdit txtImdbVotes;
        internal DevExpress.XtraEditors.TextEdit txtImdbUserRating;
        private DevExpress.XtraEditors.ComboBoxEdit cbRlsGroup;
        private DevExpress.XtraEditors.ComboBoxEdit cbRlsType;
        internal System.Windows.Forms.Label lblRlsGroup;
        internal System.Windows.Forms.Label lblRlsType;
        internal DevExpress.XtraGrid.Views.Grid.GridView gvCast;
        private DevExpress.XtraEditors.ComboBoxEdit cbUserColumn6;
        internal System.Windows.Forms.Label lblUserColumn6;
        private DevExpress.XtraEditors.ComboBoxEdit cbUserColumn5;
        internal System.Windows.Forms.Label lblUserColumn5;
        public DevExpress.XtraGrid.Columns.GridColumn imageColumn;
        internal DevExpress.XtraEditors.TextEdit txtTmdbNumber;
        internal DevExpress.XtraGrid.GridControl dgCast;
        internal DevExpress.XtraEditors.PictureEdit pbImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        internal DevExpress.XtraEditors.TextEdit txtReleaseDate;
        internal System.Windows.Forms.Label lblReleaseDate;
    }
}
