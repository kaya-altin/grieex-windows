namespace GrieeX.Forms
{
    partial class frmMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovie));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.btnNext = new DevExpress.XtraBars.BarButtonItem();
            this.btnInternet = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnMovie = new DevExpress.XtraBars.BarSubItem();
            this.btnImdb = new DevExpress.XtraBars.BarButtonItem();
            this.btnTmbdb = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubtitle = new DevExpress.XtraBars.BarSubItem();
            this.btnDivxPlanet = new DevExpress.XtraBars.BarButtonItem();
            this.btnTurkceAltyazi = new DevExpress.XtraBars.BarButtonItem();
            this.btnOpenSubtitles = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.pbProgress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.icBig = new DevExpress.Utils.ImageCollection(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.btnBeyazperde = new DevExpress.XtraBars.BarButtonItem();
            this.btnFilmComTr = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinema = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinematurk = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinemalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDvdEmpire = new DevExpress.XtraBars.BarButtonItem();
            this.btnMovieGoods = new DevExpress.XtraBars.BarButtonItem();
            this.btnAmazon = new DevExpress.XtraBars.BarButtonItem();
            this.btnGoogle = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnimeGenTr = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnimeNfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnPoster = new DevExpress.XtraBars.BarSubItem();
            this.btnAnime = new DevExpress.XtraBars.BarSubItem();
            this.btnTurkceAltyaziOrg = new DevExpress.XtraBars.BarButtonItem();
            this.MovieDetail = new GrieeX.UserControls.MovieDetail();
            this.bw = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icBig)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.icBig;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDelete,
            this.btnPrevious,
            this.btnNext,
            this.barButtonItem2,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.btnSave,
            this.btnInternet,
            this.btnTmbdb,
            this.btnImdb,
            this.btnBeyazperde,
            this.btnFilmComTr,
            this.btnSinema,
            this.btnSinematurk,
            this.btnSinemalar,
            this.btnDvdEmpire,
            this.btnMovieGoods,
            this.btnAmazon,
            this.btnGoogle,
            this.btnClose,
            this.siStatus,
            this.pbProgress,
            this.btnAnimeGenTr,
            this.btnAnimeNfo,
            this.btnMovie,
            this.btnPoster,
            this.btnAnime,
            this.btnSubtitle,
            this.btnDivxPlanet,
            this.btnTurkceAltyazi,
            this.btnOpenSubtitles,
            this.btnTurkceAltyaziOrg});
            this.barManager1.LargeImages = this.icBig;
            this.barManager1.MaxItemId = 49;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrevious),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNext),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInternet, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Kaydet ";
            this.btnSave.Id = 12;
            this.btnSave.ImageIndex = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Sil ";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Caption = "Önceki ";
            this.btnPrevious.Id = 3;
            this.btnPrevious.ImageIndex = 3;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrevious_ItemClick);
            // 
            // btnNext
            // 
            this.btnNext.Caption = "Sonraki ";
            this.btnNext.Id = 4;
            this.btnNext.ImageIndex = 4;
            this.btnNext.Name = "btnNext";
            this.btnNext.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNext_ItemClick);
            // 
            // btnInternet
            // 
            this.btnInternet.ActAsDropDown = true;
            this.btnInternet.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnInternet.Caption = "Ýnternetten Bilgi Al  ";
            this.btnInternet.DropDownControl = this.popupMenu1;
            this.btnInternet.Id = 16;
            this.btnInternet.ImageIndex = 2;
            this.btnInternet.Name = "btnInternet";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMovie, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSubtitle)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnMovie
            // 
            this.btnMovie.Caption = "Film";
            this.btnMovie.Id = 35;
            this.btnMovie.ImageIndex = 17;
            this.btnMovie.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImdb),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTmbdb)});
            this.btnMovie.Name = "btnMovie";
            // 
            // btnTmbdb
            // 
            this.btnTmbdb.Caption = "www.themoviedb.org";
            this.btnTmbdb.Id = 44;
            this.btnTmbdb.ImageIndex = 21;
            this.btnTmbdb.Name = "btnTmbdb";
            this.btnTmbdb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTmbdb_ItemClick);
            // 
            // btnImdb
            // 
            this.btnImdb.Caption = "www.imdb.com";
            this.btnImdb.Id = 18;
            this.btnImdb.ImageIndex = 6;
            this.btnImdb.Name = "btnImdb";
            this.btnImdb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImdb_ItemClick);
            // 
            // btnSubtitle
            // 
            this.btnSubtitle.Caption = "Altyazý";
            this.btnSubtitle.Id = 38;
            this.btnSubtitle.ImageIndex = 19;
            this.btnSubtitle.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDivxPlanet),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTurkceAltyazi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOpenSubtitles)});
            this.btnSubtitle.Name = "btnSubtitle";
            // 
            // btnDivxPlanet
            // 
            this.btnDivxPlanet.Caption = "www.planetdp.org";
            this.btnDivxPlanet.Id = 39;
            this.btnDivxPlanet.ImageIndex = 19;
            this.btnDivxPlanet.Name = "btnDivxPlanet";
            this.btnDivxPlanet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDivxPlanet_ItemClick);
            // 
            // btnTurkceAltyazi
            // 
            this.btnTurkceAltyazi.Caption = "www.turkcealtyazi.org";
            this.btnTurkceAltyazi.Id = 40;
            this.btnTurkceAltyazi.ImageIndex = 19;
            this.btnTurkceAltyazi.Name = "btnTurkceAltyazi";
            this.btnTurkceAltyazi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTurkceAltyazi_ItemClick);
            // 
            // btnOpenSubtitles
            // 
            this.btnOpenSubtitles.Caption = "www.opensubtitles.org";
            this.btnOpenSubtitles.Id = 42;
            this.btnOpenSubtitles.ImageIndex = 19;
            this.btnOpenSubtitles.Name = "btnOpenSubtitles";
            this.btnOpenSubtitles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpenSubtitles_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnClose.Caption = "Kapat";
            this.btnClose.Id = 28;
            this.btnClose.ImageIndex = 5;
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.siStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.pbProgress)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // siStatus
            // 
            this.siStatus.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.siStatus.Id = 29;
            this.siStatus.Name = "siStatus";
            this.siStatus.Size = new System.Drawing.Size(32, 0);
            this.siStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.siStatus.Width = 32;
            // 
            // pbProgress
            // 
            this.pbProgress.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.pbProgress.Edit = this.repositoryItemMarqueeProgressBar1;
            this.pbProgress.EditWidth = 100;
            this.pbProgress.Id = 30;
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
            this.barDockControlTop.Size = new System.Drawing.Size(910, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 375);
            this.barDockControlBottom.Size = new System.Drawing.Size(910, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 328);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(910, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 328);
            // 
            // icBig
            // 
            this.icBig.ImageSize = new System.Drawing.Size(32, 32);
            this.icBig.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icBig.ImageStream")));
            this.icBig.InsertGalleryImage("save_32x32.png", "images/save/save_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/save/save_32x32.png"), 0);
            this.icBig.Images.SetKeyName(0, "save_32x32.png");
            this.icBig.InsertGalleryImage("delete_32x32.png", "images/edit/delete_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/delete_32x32.png"), 1);
            this.icBig.Images.SetKeyName(1, "delete_32x32.png");
            this.icBig.InsertGalleryImage("backward_32x32.png", "images/navigation/backward_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/backward_32x32.png"), 3);
            this.icBig.Images.SetKeyName(3, "backward_32x32.png");
            this.icBig.InsertGalleryImage("forward_32x32.png", "images/navigation/forward_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/forward_32x32.png"), 4);
            this.icBig.Images.SetKeyName(4, "forward_32x32.png");
            this.icBig.InsertGalleryImage("close_32x32.png", "images/actions/close_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_32x32.png"), 5);
            this.icBig.Images.SetKeyName(5, "close_32x32.png");
            this.icBig.Images.SetKeyName(20, "turkcealtyazi.png");
            this.icBig.Images.SetKeyName(21, "themoviedb.png");
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ýngilizce Bilgi (www.imdb.com)";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.ImageIndex = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Türkçe Bilgi (beyazperde.mynet.com)";
            this.barStaticItem1.Id = 9;
            this.barStaticItem1.ImageIndex = 7;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Ýngilizce Bilgi (www.imdb.com)";
            this.barStaticItem2.Id = 10;
            this.barStaticItem2.ImageIndex = 6;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Türkçe Bilgi (www.film.com.tr)";
            this.barStaticItem3.Id = 11;
            this.barStaticItem3.ImageIndex = 10;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnBeyazperde
            // 
            this.btnBeyazperde.Caption = "Türkçe Bilgi (beyazperde.mynet.com)";
            this.btnBeyazperde.Id = 19;
            this.btnBeyazperde.ImageIndex = 8;
            this.btnBeyazperde.Name = "btnBeyazperde";
            this.btnBeyazperde.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnBeyazperde.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBeyazperde_ItemClick);
            // 
            // btnFilmComTr
            // 
            this.btnFilmComTr.Caption = "Türkçe Bilgi (www.film.com.tr)";
            this.btnFilmComTr.Id = 20;
            this.btnFilmComTr.ImageIndex = 10;
            this.btnFilmComTr.Name = "btnFilmComTr";
            this.btnFilmComTr.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnFilmComTr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFilmComTr_ItemClick);
            // 
            // btnSinema
            // 
            this.btnSinema.Caption = "Türkçe Bilgi (www.sinema.com)";
            this.btnSinema.Id = 21;
            this.btnSinema.ImageIndex = 12;
            this.btnSinema.Name = "btnSinema";
            this.btnSinema.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnSinema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinema_ItemClick);
            // 
            // btnSinematurk
            // 
            this.btnSinematurk.Caption = "Türkçe Bilgi (www.sinematurk.com)";
            this.btnSinematurk.Id = 22;
            this.btnSinematurk.ImageIndex = 14;
            this.btnSinematurk.Name = "btnSinematurk";
            this.btnSinematurk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnSinematurk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinematurk_ItemClick);
            // 
            // btnSinemalar
            // 
            this.btnSinemalar.Caption = "Türkçe Bilgi (www.sinemalar.com)";
            this.btnSinemalar.Id = 23;
            this.btnSinemalar.ImageIndex = 13;
            this.btnSinemalar.Name = "btnSinemalar";
            this.btnSinemalar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnSinemalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinemalar_ItemClick);
            // 
            // btnDvdEmpire
            // 
            this.btnDvdEmpire.Id = 45;
            this.btnDvdEmpire.Name = "btnDvdEmpire";
            // 
            // btnMovieGoods
            // 
            this.btnMovieGoods.Id = 46;
            this.btnMovieGoods.Name = "btnMovieGoods";
            // 
            // btnAmazon
            // 
            this.btnAmazon.Id = 47;
            this.btnAmazon.Name = "btnAmazon";
            // 
            // btnGoogle
            // 
            this.btnGoogle.Id = 48;
            this.btnGoogle.Name = "btnGoogle";
            // 
            // btnAnimeGenTr
            // 
            this.btnAnimeGenTr.Caption = "Türkçe Anime (www.anime.gen.tr)";
            this.btnAnimeGenTr.Id = 31;
            this.btnAnimeGenTr.ImageIndex = 16;
            this.btnAnimeGenTr.Name = "btnAnimeGenTr";
            this.btnAnimeGenTr.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnAnimeGenTr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnimeGenTr_ItemClick);
            // 
            // btnAnimeNfo
            // 
            this.btnAnimeNfo.Caption = "Ýngilizce Anime (www.animenfo.com)";
            this.btnAnimeNfo.Id = 32;
            this.btnAnimeNfo.ImageIndex = 16;
            this.btnAnimeNfo.Name = "btnAnimeNfo";
            this.btnAnimeNfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnimeNfo_ItemClick);
            // 
            // btnPoster
            // 
            this.btnPoster.Caption = "Afiþ";
            this.btnPoster.Id = 36;
            this.btnPoster.ImageIndex = 18;
            this.btnPoster.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGoogle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAmazon),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDvdEmpire),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMovieGoods)});
            this.btnPoster.Name = "btnPoster";
            // 
            // btnAnime
            // 
            this.btnAnime.Caption = "Anime";
            this.btnAnime.Id = 37;
            this.btnAnime.ImageIndex = 16;
            this.btnAnime.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAnimeGenTr),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAnimeNfo)});
            this.btnAnime.Name = "btnAnime";
            // 
            // btnTurkceAltyaziOrg
            // 
            this.btnTurkceAltyaziOrg.Caption = "Türkçe Bilgi (www.turkcealtyazi.org)";
            this.btnTurkceAltyaziOrg.Id = 43;
            this.btnTurkceAltyaziOrg.ImageIndex = 20;
            this.btnTurkceAltyaziOrg.Name = "btnTurkceAltyaziOrg";
            this.btnTurkceAltyaziOrg.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnTurkceAltyaziOrg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTurkceAltyaziOrg_ItemClick);
            // 
            // MovieDetail
            // 
            this.MovieDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieDetail.Location = new System.Drawing.Point(0, 47);
            this.MovieDetail.Name = "MovieDetail";
            this.MovieDetail.Size = new System.Drawing.Size(910, 328);
            this.MovieDetail.TabIndex = 4;
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // frmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 400);
            this.Controls.Add(this.MovieDetail);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Kartý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMovie_FormClosing);
            this.Load += new System.EventHandler(this.frmMovie_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvent);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection icBig;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnInternet;
        private DevExpress.XtraBars.BarButtonItem btnImdb;
        private DevExpress.XtraBars.BarButtonItem btnBeyazperde;
        private DevExpress.XtraBars.BarButtonItem btnFilmComTr;
        private DevExpress.XtraBars.BarButtonItem btnSinema;
        private DevExpress.XtraBars.BarButtonItem btnSinematurk;
        private DevExpress.XtraBars.BarButtonItem btnSinemalar;
        private DevExpress.XtraBars.BarButtonItem btnDvdEmpire;
        private DevExpress.XtraBars.BarButtonItem btnMovieGoods;
        private DevExpress.XtraBars.BarButtonItem btnAmazon;
        private DevExpress.XtraBars.BarButtonItem btnGoogle;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private System.ComponentModel.BackgroundWorker bw;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarEditItem pbProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        internal GrieeX.UserControls.MovieDetail MovieDetail;
        internal DevExpress.XtraBars.BarButtonItem btnDelete;
        internal DevExpress.XtraBars.BarButtonItem btnPrevious;
        internal DevExpress.XtraBars.BarButtonItem btnNext;
        private DevExpress.XtraBars.BarButtonItem btnAnimeGenTr;
        private DevExpress.XtraBars.BarButtonItem btnAnimeNfo;
        private DevExpress.XtraBars.BarSubItem btnMovie;
        private DevExpress.XtraBars.BarSubItem btnPoster;
        private DevExpress.XtraBars.BarSubItem btnAnime;
        private DevExpress.XtraBars.BarSubItem btnSubtitle;
        private DevExpress.XtraBars.BarButtonItem btnDivxPlanet;
        private DevExpress.XtraBars.BarButtonItem btnTurkceAltyazi;
        private DevExpress.XtraBars.BarButtonItem btnOpenSubtitles;
        private DevExpress.XtraBars.BarButtonItem btnTurkceAltyaziOrg;
        private DevExpress.XtraBars.BarButtonItem btnTmbdb;

    }
}