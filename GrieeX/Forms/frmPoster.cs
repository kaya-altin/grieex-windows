using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GrieeX.GrieeXBase;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;


namespace GrieeX.Forms
{
    public partial class frmPoster : DevExpress.XtraEditors.XtraForm
    {
        public frmPoster()
        {
            InitializeComponent();
           // EmitLanguage();
        }



        private GrieeX.GrieeXBase.Movie.Search.SearchResult _selectedTitle;
        private GrieeX.GrieeXBase.Movie.Search.SearchResultCollection list;
 

        public GrieeX.GrieeXBase.Movie.Search.SearchResult SelectedTitle
        {
            get { return _selectedTitle; }
            set { _selectedTitle = value; }
        }

        private void frmSearchMovie_Shown(object sender, System.EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                if (!bw.IsBusy)
                {
                    pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    slStatus.Caption = Language.FindKey("Messages", "2").Value;
                    bw.RunWorkerAsync();
                }
            }
        }

        private void FetchMovies()
        {
        //    SearchResultCollection moviesArrayList = new SearchResultCollection();
            list = new GrieeX.GrieeXBase.Movie.Search.SearchResultCollection();

            TMDbClient client = new TMDbClient(GrieeXSettings.TmdbApiKey);
            client.GetConfig();
            SearchContainer<SearchMovie> results = client.SearchMovieAsync(txtSearch.Text).Result;



            foreach (SearchMovie sm in results.Results)
            {
                TMDbLib.Objects.Movies.Movie movie = client.GetMovieAsync(sm.Id, MovieMethods.Images).Result;

                foreach (TMDbLib.Objects.General.ImageData imageData in movie.Images.Posters)
                {
                    if (imageData.Iso_639_1 != null && imageData.Iso_639_1.Equals("en"))
                    {
                        //foreach (string size in client.Config.Images.PosterSizes)
                        //{
                        Uri imageUri = client.GetImageUrl("original", imageData.FilePath);
                            GrieeX.GrieeXBase.Movie.Search.SearchResult c = new GrieeX.GrieeXBase.Movie.Search.SearchResult();
                            c.Poster = imageUri.AbsoluteUri;
                            c.Size = imageData.Width + "x" + imageData.Height;
                            c.Title = imageData.FilePath;
                            list.Add(c);
                        //}  
                    }
                }   
            }
           



           // list = Movie.Search.Google.Run(txtSearch.Text + "&start=" + Convert.ToString(nPage * 18));
        }

        public void PopulateList(GrieeX.GrieeXBase.Movie.Search.SearchResultCollection list)
        {
            if (list != null)
            {
                foreach (GrieeX.GrieeXBase.Movie.Search.SearchResult result in list)
                {
                    try
                    {
                        Application.DoEvents();

                        PictureBox pb = new PictureBox();
                        pb.Location = new System.Drawing.Point(1, 1);

                        // pb.WaitOnLoad = true;
                        pb.LoadAsync(result.Poster);
                        // pb.LoadAsync("http://images.google.com/images?q=tbn:" + result.Key + result.Title);
                        // pb.ImageLocation = "http://images.google.com/images?q=tbn:" + result.Key + result.Title;
                        //pb.LoadAsync(result.Title);
                        pb.Size = new System.Drawing.Size(220, 140);
                        pb.Tag = result.Title;
                        pb.Cursor = Cursors.Hand;
                        pb.SizeMode = PictureBoxSizeMode.CenterImage;
                                         pb.MouseClick += pic_Click;

                        Label lbl = new Label();
                        lbl.Text = result.Size;
                        lbl.Location = new System.Drawing.Point(4, 143);
                        lbl.Size = new System.Drawing.Size(218, 15);
                        lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                        Panel pnl = new Panel();
                        pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        pnl.Controls.Add(lbl);
                        pnl.Controls.Add(pb);
                        pnl.Size = new System.Drawing.Size(225, 164);

                        flp.Controls.Add(pnl);
                        //flp.Controls.AddRange(new Control[] {pb, label});
                    }
                    catch (Exception ex)
                    {
                    }
                }

            }
        }


        private void pic_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = sender as PictureBox;
                this.SelectedTitle = new GrieeX.GrieeXBase.Movie.Search.SearchResult(pic.Tag.ToString(), pic.Tag.ToString());
                this.Close();
            }
            else if (e.Button == MouseButtons.Right)
            {
                PictureBox pic = sender as PictureBox;

                frmImage frm = new frmImage();
                frm.ImageShow(pic.Tag.ToString());
                frm.Show();
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                if (!bw.IsBusy)
                {
                    flp.Controls.Clear();
                    pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    slStatus.Caption = Language.FindKey("Messages", "2").Value;
                    bw.RunWorkerAsync();
                }
            }
        }

        private void KeyEvent(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Focused == true)
                {
                    if (!bw.IsBusy)
                    {
                        flp.Controls.Clear();
                        pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        slStatus.Caption = Language.FindKey("Messages", "2").Value;
                        bw.RunWorkerAsync();
                    }
                }

            }
        }



        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            this.FetchMovies();
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PopulateList(list);
            pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            slStatus.Caption = Language.FindKey("Messages", "18").Value;
        }
    }
}