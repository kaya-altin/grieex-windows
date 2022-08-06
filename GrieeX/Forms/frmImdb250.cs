using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using GrieeX.GrieeXBase;
using System.Data.SQLite;

namespace GrieeX.Forms
{
    public partial class frmImdb250 : DevExpress.XtraEditors.XtraForm
    {
        public frmImdb250()
        {
            InitializeComponent();
            EmitLanguage();
            CheckForIllegalCrossThreadCalls = false;
        }

        Int32 nCount1, nCount2;

        private void frmImdb250_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SQLiteConnection con = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    con.Open();
                    cmd.Connection = con;

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    DataTable dt = sh.Select("SELECT * FROM Imdb250");
                    gridControl1.DataSource = dt;


                    con.Close();
                }
            }
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (!bw.IsBusy)
                {
                    Button1.Enabled = false;
                    nCount1 = 0;
                    nCount2 = 0;
                    pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    slStatus.Caption = Language.FindKey("Messages", "2").Value;

                 

                    bw.RunWorkerAsync();
                }
            }
            catch (System.Exception exc)
            {
                XtraMessageBox.Show(exc.Message);
            }
        }


        public void GetMatches(string urlType)
        {
            try
            {
                System.Uri url = new System.Uri(urlType);

                string stringData = null;
                System.Uri responseUri = null;
                stringData = HTTPRetriever._GET.Retrieve(url, System.Text.Encoding.UTF8, out responseUri);


                if (responseUri != null)
                {
                    GetSearchMatches(stringData);

                }
                else
                {
                }
            }
            catch (System.Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }

        private void GetSearchMatches(string stringData)
        {
            System.Text.RegularExpressions.Regex moviesRegex = new System.Text.RegularExpressions.Regex("<td class=\"posterColumn\">");

            MatchCollection movieMatches = null;
            if (stringData.Length > 0)
            {
                movieMatches = moviesRegex.Matches(stringData);

                if (movieMatches.Count != 0)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand())
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            int nRowCount = 1;
                            SQLiteHelper sh = new SQLiteHelper(cmd);

                            sh.Execute("DELETE FROM Imdb250");

                            foreach (Match movieMatch in movieMatches)
                            {
                                int nStartPos = movieMatch.Index;// stringData.IndexOf("<td class=\"posterColumn\">", movieMatch.Index);
                                int nEndPos = 0;

                                nStartPos = stringData.IndexOf("<img src=\"", nStartPos);
                                nEndPos = stringData.IndexOf(".jpg", nStartPos);
                                String ImageUrl = stringData.Substring(nStartPos + 10, nEndPos - nStartPos - 6);
                                ImageUrl = ImageUrl.Substring(0, ImageUrl.LastIndexOf("._")) + ".jpg";

                                //id
                                int startpos = stringData.IndexOf("/title/tt", movieMatch.Index);
                                int endpos = 0;

                                startpos = stringData.IndexOf("tt", movieMatch.Index);
                                endpos = stringData.IndexOf("/", startpos);
                                string ImdbNumber = stringData.Substring(startpos, endpos - startpos);
                                //   ImdbNumber = ImdbNumber.Replace("tt", "");

                                //title
                                startpos = stringData.IndexOf(" >", movieMatch.Index);
                                endpos = stringData.IndexOf("</a>", startpos);
                                string Title = stringData.Substring(startpos + 2, endpos - startpos - 2);
                                Title = Movie.Parse.StripHTML(Title);
                                Title = Movie.Parse.Decode(Title);

                                startpos = stringData.IndexOf("<td class=\"ratingColumn imdbRating\">", movieMatch.Index);
                                endpos = stringData.IndexOf("</td>", startpos);
                                string Rating = stringData.Substring(startpos + 38, endpos - startpos - 40);
                                Rating = Movie.Parse.StripHTML(Rating).Trim();


                                //Votes
                                startpos = stringData.IndexOf("<td class=\"ratingColumn imdbRating\">", movieMatch.Index);
                                endpos = stringData.IndexOf("</td>", startpos);
                                string Votes = stringData.Substring(startpos + 30, endpos - startpos - 32);
                                startpos=Votes.IndexOf("based on ");
                                endpos = Votes.IndexOf("user ratings", startpos);
                                Votes = Votes.Substring(startpos+9, endpos - startpos-10);
                                Votes = Votes.Replace(",", "");


                                var dic = new Dictionary<string, object>();
                                dic["Rank"] = nRowCount++;
                                dic["ImdbNumber"] = ImdbNumber;
                                dic["Title"] = Title;
                                dic["Rating"] = Rating;
                                dic["Votes"] = Votes;
                                sh.Insert("Imdb250", dic);
                            }

                  
                            conn.Close();

                            slStatus.Caption = Language.FindKey("Messages", "18").Value;
                            pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        }
                    }

                }
                else
                {
                }
            }

        }

        private bool GrieeXControl(string ImdbNumber)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    DataTable dt = sh.Select("SELECT ImdbNumber FROM Movies WHERE ImdbNumber='" + ImdbNumber + "'");
                    conn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }



                }
            }

        }

        //private void dGrid_Click(object sender, System.EventArgs e)
        //{
        //    if (dGrid.CurrentCell.ColumnIndex == 4)
        //    {
        //        Process.Start("http://www.imdb.com/title/tt" + dGrid.CurrentRow.Cells["cl_ImdbNo"].Value);
        //    }
        //}


        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            GetMatches("http://www.imdb.com/chart/top");
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadData();
            slStatus.Caption = Language.FindKey("Messages", "18").Value;
            pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void frmImdb250_FormClosing(object sender, FormClosingEventArgs e)
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


        private void gvImdb250_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (GrieeXControl(gvImdb250.GetRowCellValue(e.RowHandle, cl_ImdbNumber).ToString()) != true)
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }

        private void gvImdb250_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                if (gvImdb250.RowCount == 0) { return; }

                for (int i = 0; i < gvImdb250.RowCount; i++)
                {
                    if (GrieeXControl(gvImdb250.GetRowCellValue(i, cl_ImdbNumber).ToString()) == true)
                    {
                        nCount1++;
                        lblCount1.Text = nCount1.ToString();
                    }
                    else
                    {
                        nCount2++;
                        lblCount2.Text = nCount2.ToString();
                    }
                }
            }
            catch (Exception)
            {
            }
        }


        private void gvImdb250_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("http://www.imdb.com/title/" + gvImdb250.GetRowCellValue(gvImdb250.GetSelectedRows()[0], cl_ImdbNumber));
        }







    }
}