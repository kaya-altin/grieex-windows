using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using System.Diagnostics;
using GrieeX.GrieeXBase;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SQLite;
using System.IO;
using DevExpress.XtraEditors.Controls;

namespace GrieeX.Forms
{
    public partial class frmMovie : DevExpress.XtraEditors.XtraForm
    {
        public frmMovie()
        {
            InitializeComponent();
            EmitLanguage();
        }

        private static frmMovie _GlobalForm;
        public static frmMovie GlobalForm
        {
            get
            {
                if (_GlobalForm == null || _GlobalForm.IsDisposed)
                {
                    _GlobalForm = new frmMovie();
                }
                return _GlobalForm;
            }
            set { _GlobalForm = value; }
        }

        private struct Arguments
        {
            public Enums.WebType Process;
            public Movie.Search.SearchResult ResultType;
        }

        private struct Results
        {
            public Enums.WebType Process;
            public Movie movie;
        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            MovieDetail.txtOrginalName.Select();

            if (Settings.Language == "Turkish")
            {
                btnAnimeGenTr.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnBeyazperde.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnFilmComTr.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //btnSinema.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSinemalar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSinematurk.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnTurkceAltyaziOrg.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        #region " Buttons Events "


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MovieDetail.RecordSave();

            if (Settings.AutoNewRecord == true)
            {
                MovieDetail.rType = Enums.RecordType.Insert;
                MovieDetail.Clear();


                if (!string.IsNullOrEmpty(Settings.DefaultSubtitle)) MovieDetail.cbSubTitle.SetEditValue(Settings.DefaultSubtitle);
                if (!string.IsNullOrEmpty(Settings.DefaultDubbing)) MovieDetail.cbDubbing.SetEditValue(Settings.DefaultDubbing);

            }
            if (Settings.AutoClose == true) this.Hide();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(Language.FindKey("Messages", "1").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MovieDetail.CurrentMovie.Delete();
                if (!String.IsNullOrEmpty(MovieDetail.CurrentMovie.ImdbNumber))
                {
                    if (System.IO.File.Exists(GrieeXSettings.PosterPath + MovieDetail.CurrentMovie.ImdbNumber + ".jpg") == true)
                    {
                        System.IO.File.SetAttributes(GrieeXSettings.PosterPath + MovieDetail.CurrentMovie.ImdbNumber + ".jpg", System.IO.FileAttributes.Archive);
                        System.IO.File.Delete(GrieeXSettings.PosterPath + MovieDetail.CurrentMovie.ImdbNumber + ".jpg");
                    }
                }

                //foreach (Casts item in MovieDetail.CurrentMovie.Casts)
                //{
                //    item.Delete();
                //}
                using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        sh.Execute("DELETE FROM Casts WHERE CollectionType=1 and ObjectID=" + MovieDetail.CurrentMovie.MovieID);
                        sh.Execute("DELETE FROM Files WHERE MovieID=" + MovieDetail.CurrentMovie.MovieID);

                        conn.Close();
                    }
                }
                GridView view = frmMain.GlobalForm.gvList;
                view.DeleteRow(view.FocusedRowHandle);
                this.Hide();
            }
        }

        private void btnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                MovieDetail.Clear();

                frmMain.GlobalForm.gvList.MoveNext();
                MovieDetail.RecordShow(frmMain.GlobalForm.MovieDetail.CurrentMovie.MovieID.ToString());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                MovieDetail.Clear();

                frmMain.GlobalForm.gvList.MovePrev();
                MovieDetail.RecordShow(frmMain.GlobalForm.MovieDetail.CurrentMovie.MovieID.ToString());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bw.IsBusy)
                bw.CancelAsync();

            this.Hide();
        }

        private void btnImdb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(MovieDetail.txtImdbNumber.Text))
            {
                if (XtraMessageBox.Show(Language.FindKey("Messages", "8").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ImdbNumberParse();
                }
                else
                {
                    ImdbSearchParse();
                }
            }
            else
            {
                ImdbSearchParse();
            }
        }

        public void ImdbNumberParse()
        {
            if (!bw.IsBusy)
            {
                DoWork();
                bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.IMDB, ResultType = new Movie.Search.SearchResult(MovieDetail.txtImdbNumber.Text, "") });
            }
        }

        public void ImdbSearchParse()
        {
            frmSearchMovie frm = new frmSearchMovie();
            frm.Text = frm.Text + " - www.imdb.com";
            frm.Web = Enums.WebType.IMDB;
            frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;
            frm.ShowDialog();

            if (frm.Ok == true)
            {
                if (!bw.IsBusy)
                {
                    DoWork();
                    bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.IMDB, ResultType = frm.SelectedTitle });
                }
            }
        }

        private void btnBeyazperde_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSearchMovie frm = new frmSearchMovie();
                frm.Text = frm.Text + " - www.beyazperde.com";
                frm.Web = Enums.WebType.BeyazPerde;
                frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;
                frm.ShowDialog();

                if (frm.Ok == true)
                {
                    if (!bw.IsBusy)
                    {
                        DoWork();
                        bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.BeyazPerde, ResultType = frm.SelectedTitle });
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnFilmComTr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSearchMovie frm = new frmSearchMovie();
                frm.Text = frm.Text + " - www.film.com.tr";
                frm.Web = Enums.WebType.FilmComTr;
                frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;
                frm.ShowDialog();

                if (frm.Ok == true)
                {
                    if (!bw.IsBusy)
                    {
                        DoWork();
                        bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.FilmComTr, ResultType = frm.SelectedTitle });
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnSinema_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //    frmSearchMovie frm = new frmSearchMovie();
            //    frm.Text = frm.Text + " - www.sinema.com";
            //    frm.Web = Enums.WebType.Sinema;
            //    frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;
            //    frm.btnPreview.Enabled = false;
            //    frm.ShowDialog();

            //    if (frm.Ok == true)
            //    {
            //        if (!bw.IsBusy)
            //        {
            //            DoWork();
            //            bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.Sinema, ResultType = frm.SelectedTitle });
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message);
            //    this.Close();
            //}
        }

        private void btnSinematurk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSearchMovie frm = new frmSearchMovie();
                frm.Text = frm.Text + " - www.sinematurk.com";
                frm.Web = Enums.WebType.SinemaTurk;
                frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;

                frm.ShowDialog();

                if (frm.Ok == true)
                {
                    if (!bw.IsBusy)
                    {
                        DoWork();
                        bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.SinemaTurk, ResultType = frm.SelectedTitle });
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnSinemalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSearchMovie frm = new frmSearchMovie();
                frm.Text = frm.Text + " - www.sinemalar.com";
                frm.Web = Enums.WebType.Sinemalar;
                frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;
                frm.ShowDialog();

                if (frm.Ok == true)
                {
                    if (!bw.IsBusy)
                    {
                        DoWork();
                        bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.Sinemalar, ResultType = frm.SelectedTitle });
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnAnimeGenTr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSearchMovie frm = new frmSearchMovie();
                frm.Text = frm.Text + " - www.anime.gen.tr";
                frm.Web = Enums.WebType.AnimeGenTr;
                frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;
                frm.ShowDialog();

                if (frm.Ok == true)
                {
                    if (!bw.IsBusy)
                    {
                        DoWork();
                        bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.AnimeGenTr, ResultType = frm.SelectedTitle });
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnAnimeNfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSearchMovie frm = new frmSearchMovie();
                frm.Text = frm.Text + " - www.animenfo.com";
                frm.Web = Enums.WebType.AnimeNfo;
                frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;
                frm.ShowDialog();

                if (frm.Ok == true)
                {
                    if (!bw.IsBusy)
                    {
                        DoWork();
                        bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.AnimeNfo, ResultType = frm.SelectedTitle });
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnDivxPlanet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Movie.SubTitle.DivxPlanet(MovieDetail.txtOrginalName.Text);
        }

        private void btnTurkceAltyazi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Movie.SubTitle.TurkceAltyazi(MovieDetail.txtOrginalName.Text);
        }

        private void btnOpenSubtitles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Movie.SubTitle.OpenSubtitles(MovieDetail.txtOrginalName.Text);
        }

        #endregion

        #region " Form Events "

        private void KeyEvent(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete & e.Modifiers == Keys.Control)
            {
                btnDelete.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                btnSave.PerformClick();
            }
            if (e.KeyCode == Keys.PageDown)
            {
                btnNext.PerformClick();
            }
            if (e.KeyCode == Keys.PageUp)
            {
                btnPrevious.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
            if (e.KeyCode == Keys.Enter)
            {
                ImdbSearchParse();
            }
        }

        private void DoWork()
        {
            pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            siStatus.Caption = Language.FindKey("Messages", "2").Value;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Arguments Args = (Arguments)e.Argument;
            switch (Args.Process)
            {
                case Enums.WebType.TMDB:
                        e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.Tmdb(Args.ResultType, true) };
                    break;
                case Enums.WebType.IMDB:
                        e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.Imdb(Args.ResultType, true) };
                    break;
                case Enums.WebType.BeyazPerde:
                    e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.BeyazPerde(Args.ResultType) };
                    break;
                case Enums.WebType.FilmComTr:
                    e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.FilmComTr(Args.ResultType) };
                    break;
                //case Enums.WebType.Sinema:
                //    e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.Sinema(Args.ResultType) };
                //    break;
                case Enums.WebType.SinemaTurk:
                    e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.SinemaTurk(Args.ResultType) };
                    break;
                case Enums.WebType.Sinemalar:
                    e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.Sinemalar(Args.ResultType) };
                    break;
                //case Enums.WebType.MovieMeter:
                //    break;
                case Enums.WebType.AnimeGenTr:
                    e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.AnimeGenTr(Args.ResultType, true) };
                    break;
                case Enums.WebType.AnimeNfo:
                    e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.AnimeNfo(Args.ResultType, true) };
                    break;
                case Enums.WebType.TurkceAltyaziOrg:
                    e.Result = new Results { Process = Args.Process, movie = new Movie.Parse.TurkceAltyazi(Args.ResultType) };
                    break;
                default:
                    break;
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                XtraMessageBox.Show(e.Error.Message);
            }

            Results Res = (Results)e.Result;
            switch (Res.Process)
            {
                case Enums.WebType.TMDB:
                    MovieDetail.ContentProvider = (int)Enums.WebType.TMDB;
                    MovieDetail.txtImdbNumber.Text = Res.movie.ImdbNumber;
                    MovieDetail.txtOrginalName.Text = Res.movie.OrginalName;
                    MovieDetail.txtOtherName.Text = Res.movie.OtherName;
                    MovieDetail.txtYear.Text = Res.movie.Year;
                    MovieDetail.txtDirector.Text = Res.movie.Director;
                    MovieDetail.txtEnglishPlot.Text = Res.movie.EnglishPlot;
                    MovieDetail.txtOtherPlot.Text = Res.movie.OtherPlot;
                    MovieDetail.txtGenre.Text = Res.movie.Genre;
                    MovieDetail.txtRuntime.Text = Res.movie.RunningTime;
                    MovieDetail.txtUserRating.Text = Res.movie.UserRating;
                    MovieDetail.txtVotes.Text = Res.movie.Votes.ToString();
                    MovieDetail.txtWriter.Text = Res.movie.Writer;
                    MovieDetail.txtCountry.Text = Res.movie.Country;
                    MovieDetail.txtLanguage.Text = Res.movie.Language;
                    MovieDetail.txtProductionCompany.Text = Res.movie.ProductionCompany;
                    MovieDetail.txtBudget.Text = Res.movie.Budget;
                    MovieDetail.txtPoster.Text = Res.movie.Poster;
                    MovieDetail.txtTmdbNumber.Text = Res.movie.TmdbNumber;
                    MovieDetail.txtReleaseDate.Text = Res.movie.ReleaseDate;

                    MovieDetail.txtTmdbUserRating.Text = Res.movie.UserRating;
                    MovieDetail.txtTmdbVotes.Text = Res.movie.Votes.ToString();


                    MovieDetail.CurrentMovie.Casts = Res.movie.Casts;
                    MovieDetail.dgCast.DataSource = Res.movie.Casts;

                    if (File.Exists(GrieeXSettings.PosterPath + Res.movie.ImdbNumber + @".jpg"))
                    {
                        MovieDetail.pbImage.StartAnimation();
                        MovieDetail.pbImage.LoadAsync(GrieeXSettings.PosterPath + Res.movie.ImdbNumber + @".jpg");
                    }
                    else
                    {
                        MovieDetail.pbImage.Properties.SizeMode = PictureSizeMode.Squeeze;
                        MovieDetail.pbImage.Image = GrieeX.Properties.Resources.GrieeXLogo;
                    }
                    break;
                case Enums.WebType.IMDB:
                    MovieDetail.ContentProvider = (int)Enums.WebType.IMDB;
                    MovieDetail.txtImdbNumber.Text = Res.movie.ImdbNumber;
                    MovieDetail.txtOrginalName.Text = Res.movie.OrginalName;
                    MovieDetail.txtYear.Text = Res.movie.Year;
                    MovieDetail.txtDirector.Text = Res.movie.Director;
                    MovieDetail.txtEnglishPlot.Text = Res.movie.EnglishPlot;
                    MovieDetail.txtGenre.Text = Res.movie.Genre;
                    MovieDetail.txtRuntime.Text = Res.movie.RunningTime;
                    MovieDetail.txtUserRating.Text = Res.movie.UserRating;
                    MovieDetail.txtVotes.Text = Util.convertToString(Res.movie.Votes);
                    MovieDetail.txtReleaseDate.Text = Res.movie.ReleaseDate;

                    MovieDetail.txtWriter.Text = Res.movie.Writer;
                    MovieDetail.txtCountry.Text = Res.movie.Country;
                    MovieDetail.txtLanguage.Text = Res.movie.Language;
                    MovieDetail.txtPoster.Text = Res.movie.Poster;
                    MovieDetail.txtProductionCompany.Text = Res.movie.ProductionCompany;
                    MovieDetail.txtBudget.Text = Res.movie.Budget;

                    MovieDetail.txtImdbUserRating.Text = Res.movie.UserRating;
                    MovieDetail.txtImdbVotes.Text = Util.convertToString(Res.movie.Votes);

                    MovieDetail.CurrentMovie.Casts = Res.movie.Casts;
                    MovieDetail.dgCast.DataSource = Res.movie.Casts;

                    if (File.Exists(GrieeXSettings.PosterPath + Res.movie.ImdbNumber + @".jpg"))
                    {
                        MovieDetail.pbImage.StartAnimation();
                        MovieDetail.pbImage.LoadAsync(GrieeXSettings.PosterPath + Res.movie.ImdbNumber + @".jpg");
                    }
                    else
                    {
                        MovieDetail.pbImage.Properties.SizeMode = PictureSizeMode.Squeeze;
                        MovieDetail.pbImage.Image = GrieeX.Properties.Resources.GrieeXLogo;
                    }
                    break;
                case Enums.WebType.BeyazPerde:
                    MovieDetail.txtOtherName.Text = Res.movie.OtherName;
                    MovieDetail.txtOtherPlot.Text = Res.movie.OtherPlot;
                    break;
                case Enums.WebType.TurkceAltyaziOrg:
                    MovieDetail.txtOtherName.Text = Res.movie.OtherName;
                    MovieDetail.txtOtherPlot.Text = Res.movie.OtherPlot;
                    break;
                case Enums.WebType.FilmComTr:
                    MovieDetail.txtOtherName.Text = Res.movie.OtherName;
                    MovieDetail.txtOtherPlot.Text = Res.movie.OtherPlot;
                    break;
                case Enums.WebType.SinemaTurk:
                    MovieDetail.txtOtherName.Text = Res.movie.OtherName;
                    MovieDetail.txtOtherPlot.Text = Res.movie.OtherPlot;
                    break;
                case Enums.WebType.Sinemalar:
                    MovieDetail.txtOtherName.Text = Res.movie.OtherName;
                    MovieDetail.txtOtherPlot.Text = Res.movie.OtherPlot;
                    break;
                case Enums.WebType.AnimeGenTr:
                    MovieDetail.txtOrginalName.Text = Res.movie.OrginalName;
                    MovieDetail.txtDirector.Text = Res.movie.Director;
                    MovieDetail.txtOtherPlot.Text = Res.movie.OtherPlot;
                    MovieDetail.txtGenre.Text = Res.movie.Genre;
                    MovieDetail.txtWriter.Text = Res.movie.Writer;
                    MovieDetail.txtYear.Text = Res.movie.Year;
                    MovieDetail.txtRuntime.Text = Res.movie.RunningTime;

                    MovieDetail.pbImage.StartAnimation();
                    MovieDetail.pbImage.LoadAsync(Res.movie.URL);
                    break;
                case Enums.WebType.AnimeNfo:
                    MovieDetail.txtOrginalName.Text = Res.movie.OrginalName;
                    MovieDetail.txtGenre.Text = Res.movie.Genre;
                    MovieDetail.txtYear.Text = Res.movie.Year;
                    MovieDetail.txtEnglishPlot.Text = Res.movie.EnglishPlot;
                    MovieDetail.txtDirector.Text = Res.movie.Director;
                    MovieDetail.txtUserRating.Text = Res.movie.UserRating;
                    MovieDetail.txtVotes.Text = Res.movie.Votes.ToString();
                    MovieDetail.txtWriter.Text = Res.movie.Writer;

                    MovieDetail.pbImage.StartAnimation();
                    MovieDetail.pbImage.LoadAsync(Res.movie.URL);
                    break;
                default:
                    break;
            }

            siStatus.Caption = Language.FindKey("Messages", "18").Value;
            pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }


        private void frmMovie_FormClosing(object sender, FormClosingEventArgs e)
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
        #endregion

        private void btnTurkceAltyaziOrg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSearchMovie frm = new frmSearchMovie();
                frm.Text = frm.Text + " - www.turkcealtyazi.org";
                frm.Web = Enums.WebType.TurkceAltyaziOrg;
                frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;

                frm.ShowDialog();

                if (frm.Ok == true)
                {
                    if (!bw.IsBusy)
                    {
                        DoWork();
                        bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.TurkceAltyaziOrg, ResultType = frm.SelectedTitle });
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnTmbdb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(MovieDetail.txtOrginalName.Text))
            {
                frmSearchMovie frm = new frmSearchMovie();
                frm.Text = frm.Text + " - www.themoviedb.org";
                frm.Web = Enums.WebType.TMDB;
                frm.txtSearch.Text = MovieDetail.txtOrginalName.Text;
                frm.ShowDialog();

                if (frm.Ok == true)
                {
                    if (!bw.IsBusy)
                    {
                        DoWork();
                        bw.RunWorkerAsync(new Arguments { Process = Enums.WebType.TMDB, ResultType = frm.SelectedTitle });
                    }
                }
            }

        }


    }
}