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
using TMDbLib.Objects.Search;
using TMDbLib.Objects.General;


namespace GrieeX.Forms
{
    public partial class frmSearchMovie : DevExpress.XtraEditors.XtraForm
    {
        public frmSearchMovie()
        {
            InitializeComponent();
            EmitLanguage();
        }

        private Movie.Search.SearchResult _selectedTitle;
        private Movie.Search.SearchResultCollection _initialResults;
        private Enums.WebType _Web;
        private bool _Ok = false;
        private Movie.Search.SearchResultCollection list = default(Movie.Search.SearchResultCollection);


        public Movie.Search.SearchResultCollection InitialResults
        {
            get { return _initialResults; }
            set { _initialResults = value; }
        }

        public Enums.WebType Web
        {
            get { return _Web; }
            set { _Web = value; }
        }

        public bool Ok
        {
            get { return _Ok; }
            set { _Ok = value; }
        }

        public Movie.Search.SearchResult SelectedTitle
        {
            get { return _selectedTitle; }
            set { _selectedTitle = value; }
        }

        private void frmSearchMovie_Shown(object sender, EventArgs e)
        {
            if (_initialResults != null)
            {
                PopulateList(_initialResults);
            }
            else
            {
                if (txtSearch.Text.Length > 0)
                {
                    if (!bw.IsBusy)
                    {
                        txtSearch.Text = txtSearch.Text.Replace(", The", "");
                        slStatus.Caption = Language.FindKey("Messages", "2").Value;
                        pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        bw.RunWorkerAsync();
                    }
                }
            }
        }

        //protected override void OnActivated(EventArgs e)
        //{
        //    base.OnActivated(e);
        //}

        private void FetchMovies()
        {
            switch (Web)
            {
                case Enums.WebType.TMDB:
                    list = Movie.Search.TMDB.Run(txtSearch.Text);
                    break;
                case Enums.WebType.IMDB:
                    list = Movie.Search.IMDB.Run(txtSearch.Text);
                    break;
                case Enums.WebType.BeyazPerde:
                    list = Movie.Search.BeyazPerde.Run(txtSearch.Text);
                    break;
                case Enums.WebType.FilmComTr:
                    list = Movie.Search.FilmComTr.Run(txtSearch.Text);
                    break;
                case Enums.WebType.SinemaTurk:
                    list = Movie.Search.SinemaTurk.Run(txtSearch.Text);
                    break;
                case Enums.WebType.Sinemalar:
                    list = Movie.Search.Sinemalar.Run(txtSearch.Text);
                    break;
                case Enums.WebType.AnimeGenTr:
                    list = Movie.Search.AnimeGenTr.Run(txtSearch.Text);
                    break;
                case Enums.WebType.AnimeNfo:
                    list = Movie.Search.AnimeNfo.Run(txtSearch.Text);
                    break;
                case Enums.WebType.TurkceAltyaziOrg:
                    list = Movie.Search.TurkceAltyazi.Run(txtSearch.Text);
                    break;
                default:
                    break;
            }

        }

        public void PopulateList(Movie.Search.SearchResultCollection list)
        {
            lbMovies.Items.Clear();
            lbMovies.DisplayMember = "Title";
            if (list != null)
            {
                foreach (Movie.Search.SearchResult result in list)
                {
                    lbMovies.Items.Add(result);
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                if (txtSearch.Text.Length > 0)
                {
                    if (!bw.IsBusy)
                    {
                        btnSearch.Enabled = false;
                        pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        slStatus.Caption = Language.FindKey("Messages", "2").Value;
                        bw.RunWorkerAsync();
                    }
                }
            }
        }

        private void lbMovies_DoubleClick(object sender, EventArgs e)
        {
            Ok = true;
            ResultSelect();
        }

        private void frmSearchMovie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Focused == true)
                    if (!bw.IsBusy)
                    {
                        pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        slStatus.Caption = Language.FindKey("Messages", "2").Value;
                        bw.RunWorkerAsync();
                    };
                if (lbMovies.Focused == true) pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always; ResultSelect();
            }
        }

        public void ResultSelect()
        {
            if (lbMovies.SelectedItem != null)
            {

                this.SelectedTitle = (Movie.Search.SearchResult)lbMovies.SelectedItem;
                this.Close();

            }

        }

        private void lbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
       
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
            btnSearch.Enabled = true;
            pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            slStatus.Caption = Language.FindKey("Messages", "18").Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lbMovies.SelectedItems.Count != 0)
            {
                Ok = true;
                ResultSelect();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void frmSearchMovie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bw.IsBusy)
            {
                if (XtraMessageBox.Show(Language.FindKey("Messages", "19").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bw.CancelAsync();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }



    }
}