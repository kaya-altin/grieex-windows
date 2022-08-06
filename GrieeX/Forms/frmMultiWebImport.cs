using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.IO;
using GrieeX.GrieeXBase;
using System.Data.SQLite;

namespace GrieeX.Forms
{
    public partial class frmMultiWebImport : DevExpress.XtraEditors.XtraForm
    {
        public frmMultiWebImport()
        {
            InitializeComponent();
            EmitLanguage();
            CheckForIllegalCrossThreadCalls = false;
        }

        private Movie movie;


        private void frmMultiWebImport_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    DataRow[] drs = sh.Select("SELECT _id, OrginalName, ImdbNumber FROM Movies ORDER BY OrginalName").Select();
                    int n = 0;
                    foreach (DataRow dr in drs)
                    {
                        ExList.Items.Add(dr["OrginalName"].ToString().Replace(", The", ""));
                        ExList.Items[n].SubItems.Add(dr["ImdbNumber"].ToString());
                        ExList.Items[n].SubItems.Add(dr["_id"].ToString());
                        n += 1;
                    }

                    conn.Close();
                }
            }

        }

        private void updateValue(String str, string id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.Execute("UPDATE Movies SET " + str + " WHERE _id=" + id);

                    conn.Close();
                }
            }
        }

        private string Escape(string data)
        {
            if (String.IsNullOrEmpty(data))
                return "";

            data = data.Replace("'", "''");
            data = data.Replace("\\", "\\\\");
            return data;
        }

        public void MultiWebImport(int kMovie, string strTitle, string strImdbNumber)
        {
            try
            {
                Movie.Search.SearchResultCollection list = default(Movie.Search.SearchResultCollection);

                //Application.DoEvents();
                if (chkImdb.Checked == true)
                {
                    if (!string.IsNullOrEmpty(strImdbNumber))
                    {
                        string str = string.Empty;
                        movie = new Movie.Parse.Imdb(new Movie.Search.SearchResult(strImdbNumber, ""), chkPoster.Checked);

                        str = Area(kMovie);

                        updateValue(str, kMovie.ToString());
                    }
                    else
                    {
                        list = Movie.Search.IMDB.Run(strTitle);

                        if (list.Count != 0)
                        {
                            string str = string.Empty;
                            movie = new Movie.Parse.Imdb(new Movie.Search.SearchResult(list.Item(0).Key, ""), chkPoster.Checked);

                            str = Area(kMovie);
                            updateValue(str, kMovie.ToString());
                        }
                    }
                }

                if (chkTmdb.Checked == true)
                {
                    if (!string.IsNullOrEmpty(strImdbNumber))
                    {
                        string str = string.Empty;
                        movie = new Movie.Parse.Tmdb(new Movie.Search.SearchResult(strImdbNumber, ""), chkPoster.Checked);

                        str = Area(kMovie);

                        updateValue(str, kMovie.ToString());
                    }
                    else
                    {
                        list = Movie.Search.IMDB.Run(strTitle);

                        if (list.Count != 0)
                        {
                            string str = string.Empty;
                            movie = new Movie.Parse.Tmdb(new Movie.Search.SearchResult(list.Item(0).Key, ""), chkPoster.Checked);

                            str = Area(kMovie);
                            updateValue(str, kMovie.ToString());
                        }
                    }
                }

                if (chkBeyazperde.Checked == true)
                {
                    list = Movie.Search.BeyazPerde.Run(strTitle);

                    if (list.Count != 0)
                    {
                        movie = new Movie.Parse.BeyazPerde(new Movie.Search.SearchResult(list.Item(0).Key, ""));

                        updateValue("OtherName = '" + Escape(movie.OtherName) + "', OtherPlot = '" + Escape(movie.OtherPlot) + "'", kMovie.ToString());
                    }
                }


                //if (chkSinema.Checked == true)
                //{
                //    list = Movie.Search.Sinema.Run(strTitle);

                //    if (list.Count != 0)
                //    {
                //        movie = new Movie.Parse.Sinema(new Movie.Search.SearchResult(list.Item(0).Key, ""));


                //        Record.Update("tMovies", "strOtherName = '" + movie.OtherName + "', strOtherPlot = '" + movie.OtherPlot + "'", "kMovie", kMovie.ToString());
                //        insertLink(kMovie, Enums.WebType.Sinema);
                //    }
                //}

                if (chkSinemalar.Checked == true)
                {
                    list = Movie.Search.Sinemalar.Run(strTitle);

                    if (list.Count != 0)
                    {
                        movie = new Movie.Parse.Sinemalar(new Movie.Search.SearchResult(list.Item(0).Key, ""));

                        updateValue("OtherName = '" + Escape(movie.OtherName) + "', OtherPlot = '" + Escape(movie.OtherPlot) + "'", kMovie.ToString());

                    }
                }

                if (chkSinemaTurk.Checked == true)
                {
                    list = Movie.Search.SinemaTurk.Run(strTitle);

                    if (list.Count != 0)
                    {
                        movie = new Movie.Parse.SinemaTurk(new Movie.Search.SearchResult(list.Item(0).Key, ""));

                        updateValue("OtherName = '" + Escape(movie.OtherName) + "', OtherPlot = '" + Escape(movie.OtherPlot) + "'", kMovie.ToString());
                    }
                }

                if (chkTurkcealtyazi.Checked == true)
                {
                    list = Movie.Search.TurkceAltyazi.Run(strTitle);

                    if (list.Count != 0)
                    {
                        movie = new Movie.Parse.TurkceAltyazi(new Movie.Search.SearchResult(list.Item(0).Key, ""));

                        updateValue("OtherName = '" + Escape(movie.OtherName) + "', OtherPlot = '" + Escape(movie.OtherPlot) + "'", kMovie.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
            }
        }



        private string Area(int id)
        {
            string str = string.Empty;

            str = str + "ImdbNumber = '" + movie.ImdbNumber + "'";


            if (chkTmdb.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "ContentProvider = " + (int)Enums.WebType.TMDB;
            }
            else if (chkImdb.Checked)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "ContentProvider = " + (int)Enums.WebType.IMDB;
            }

            if (chkDirector.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "Director = '" + Escape(movie.Director) + "'";
            }
            if (chkWriter.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "Writer = '" + Escape(movie.Writer) + "'";
            }
            if (chkGenre.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "Genre = '" + Escape(movie.Genre) + "'";
            }
            if (chkYear.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "Year = '" + Escape(movie.Year) + "'";
            }
            if (chkUserRating.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "UserRating = '" + Escape(movie.UserRating) + "'";
            }
            if (chkVotes.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "Votes = '" + Util.convertToString(movie.Votes) + "'";
            }

            if (chkImdb.Checked == true)
            {
                if (chkUserRating.Checked == true)
                {
                    if (str != string.Empty) str = str + ", ";
                    str = str + "ImdbUserRating = '" + Escape(movie.UserRating) + "'";
                }
                if (chkVotes.Checked == true)
                {
                    if (str != string.Empty) str = str + ", ";
                    str = str + "ImdbVotes = '" + Util.convertToString(movie.Votes) + "'";
                }
            }

            if (chkTmdb.Checked == true)
            {
                if (chkUserRating.Checked == true)
                {
                    if (str != string.Empty) str = str + ", ";
                    str = str + "TmdbUserRating = '" + Escape(movie.UserRating) + "'";
                }
                if (chkVotes.Checked == true)
                {
                    if (str != string.Empty) str = str + ", ";
                    str = str + "TmdbVotes = '" + Util.convertToString(movie.Votes) + "'";
                }
            }

            if (chkRunningTime.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "RunningTime = '" + Escape(movie.RunningTime) + "'";
            }
            if (chkReleaseDate.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "ReleaseDate = '" + Escape(movie.ReleaseDate) + "'";
            }
            if (chkCountry.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "Country = '" + Escape(movie.Country) + "'";
            }
            if (chkLanguage.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "Language = '" + Escape(movie.Language) + "'";
            }
            if (chkPlot.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "EnglishPlot = '" + Escape(movie.EnglishPlot) + "'";
            }
            if (chkBudget.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "Budget = '" + Escape(movie.Budget) + "'";
            }
            if (chkProductionCompany.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "ProductionCompany = '" + Escape(movie.ProductionCompany) + "'";
            }

            if (chkPoster.Checked == true)
            {
                if (str != string.Empty) str = str + ", ";
                str = str + "Poster = '" + Escape(movie.Poster) + "'";
            }

            if (chkTmdb.Checked)
            {
                str = str + ",TmdbNumber = '" + Escape(movie.TmdbNumber) + "'";
            }


            if (chkCast.Checked == true)
            {
                if (movie.Casts.Count > 0)
                {
                    deleteCasts(id);
                    foreach (Casts cast in movie.Casts)
                    {
                        cast.ObjectID = id;
                        cast.Save();
                    }
                }


            }


            return str;
        }


        private void deleteCasts(int id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        sh.Execute("Delete From Casts WHERE CollectionType=1 and ObjectID=" + id);

                        conn.Close();
                    }
                }
            }
            catch { }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
            {
                btnStart.Enabled = false;
                grbWebs.Enabled = false;
                grbValues.Enabled = false;
                pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                bw.RunWorkerAsync();
            }
        }

        private void frmMultiWebImport_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            ListViewItem Item = null;
            {
                foreach (ListViewItem Item_loopVariable in ExList.Items)
                {
                    Item = Item_loopVariable;
                    Item.Checked = true;
                }
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            ListViewItem Item = null;
            {
                foreach (ListViewItem Item_loopVariable in ExList.Items)
                {
                    Item = Item_loopVariable;
                    Item.Checked = false;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bw.CancelAsync();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            //{


            ListViewItem Item = null;

            int i = 0;
            foreach (ListViewItem Item_loopVariable in ExList.Items)
            {
                Item = Item_loopVariable;
                if (Item.Checked == true)
                {
                    i += 1;
                }
            }

            //progressBarSample.Properties.Maximum = i;
            this.txtCount.Text = i.ToString();




            //progressBarSample.Position = 0;

            Int32 n = 1;
            foreach (ListViewItem Item_loopVariable in ExList.Items)
            {
                try
                {
                    if (bw.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        Item = Item_loopVariable;

                        if (Item.Checked == true)
                        {
                            // bw.ReportProgress(n++);
                            txtNo.Text = n++.ToString();
                            slStatus.Caption = Item.Text;
                            Item.Checked = false;

                            MultiWebImport(Convert.ToInt32(Item.SubItems[2].Text), Item.SubItems[0].Text, Item.SubItems[1].Text);

                        }
                    }
                }
                catch (Exception)
                {
                    Item_loopVariable.Checked = true;
                }
            }
            //}


            //catch (Exception ex)
            //{
            //    //XtraMessageBox.Show(ex.Message);
            //}
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnStart.Enabled = true;
                    grbWebs.Enabled = true;
                    grbValues.Enabled = true;
                    //pbProgress.Step = 0;
                    //slStatus.Text = Utilities.dINI.FindKey("Messages", "17").Value;
                }
                else
                {
                    pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //pbProgress.Step = 0;
                    slStatus.Caption = Language.FindKey("Messages", "18").Value;
                    btnStop.Enabled = false;
                    btnStart.Enabled = true;
                    grbWebs.Enabled = true;
                    grbValues.Enabled = true;
                    frmMain.GlobalForm.Search();
                }
            }
            catch (Exception)
            {

            }

        }

        private void chkIMDB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImdb.Checked == true)
            {
                grbValues.Visible = true;
            }
            else
            {
                if (!chkTmdb.Checked)
                {
                    grbValues.Visible = false;
                }
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.CheckState == CheckState.Checked)
            {
                chkDirector.CheckState = CheckState.Checked;
                chkWriter.CheckState = CheckState.Checked;
                chkCast.CheckState = CheckState.Checked;
                chkGenre.CheckState = CheckState.Checked;
                chkYear.CheckState = CheckState.Checked;
                chkUserRating.CheckState = CheckState.Checked;
                chkVotes.CheckState = CheckState.Checked;
                chkPlot.CheckState = CheckState.Checked;
                chkRunningTime.CheckState = CheckState.Checked;
                chkCountry.CheckState = CheckState.Checked;
                chkLanguage.CheckState = CheckState.Checked;
                chkBudget.CheckState = CheckState.Checked;
                chkProductionCompany.CheckState = CheckState.Checked;
                chkPoster.CheckState = CheckState.Checked;
            }
            else
            {
                chkDirector.CheckState = CheckState.Unchecked;
                chkWriter.CheckState = CheckState.Unchecked;
                chkCast.CheckState = CheckState.Unchecked;
                chkGenre.CheckState = CheckState.Unchecked;
                chkYear.CheckState = CheckState.Unchecked;
                chkUserRating.CheckState = CheckState.Unchecked;
                chkVotes.CheckState = CheckState.Unchecked;
                chkPlot.CheckState = CheckState.Unchecked;
                chkRunningTime.CheckState = CheckState.Unchecked;
                chkCountry.CheckState = CheckState.Unchecked;
                chkLanguage.CheckState = CheckState.Unchecked;
                chkBudget.CheckState = CheckState.Unchecked;
                chkProductionCompany.CheckState = CheckState.Unchecked;
                chkPoster.CheckState = CheckState.Unchecked;
            }
        }


        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            if (bw.CancellationPending == false)
            {

            }
        }

        private void chkTmdb_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTmdb.Checked == true)
            {
                grbValues.Visible = true;
            }
            else
            {
                if (!chkImdb.Checked)
                {
                    grbValues.Visible = false;
                }
            }
        }


    }
}