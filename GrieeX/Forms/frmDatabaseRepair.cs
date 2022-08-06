using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using GrieeX.GrieeXBase;
using System.Diagnostics;
using System.Threading;
using System.Data.SQLite;

namespace GrieeX.Forms
{
    public partial class frmDatabaseRepair : DevExpress.XtraEditors.XtraForm
    {


        public frmDatabaseRepair()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            EmitLanguage();
        }


        private void frmBackup_Load(object sender, EventArgs e)
        {
            bwBackup.RunWorkerAsync();
        }


        private void bwBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            Repair();
        }

        private void bwBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.Restart();
        }

        private void frmBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if ( bwBackup.IsBusy)
                {
                    if (XtraMessageBox.Show(Language.FindKey("Messages", "19").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bwBackup.CancelAsync();
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }



        private void Repair()
        {
            SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource);
            SQLiteConnection connRepair = new SQLiteConnection(GrieeXSettings.DataSourceRepair);

            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = conn;
                conn.Open();
                try
                {
                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    #region MyRegion
                    Util.WriteResourceToFile("GrieeX.GrieeX.db", Application.StartupPath + "\\Database\\GrieeX.db.repair");

                    DataTable dtOld_Movies = sh.Select("Select * From Movies Order By OrginalName asc");
                    DataTable dtOld_Files = sh.Select("Select * FROM Files");
                    DataTable dtOld_Casts = sh.Select("Select * FROM Casts");
                    DataTable dtOld_Backdrops = sh.Select("Select * FROM Backdrops");

                    DataTable dtOld_Series = sh.Select("Select * FROM Series");
                    DataTable dtOld_Seasons = sh.Select("Select * FROM Seasons");
                    DataTable dtOld_Episodes = sh.Select("Select * FROM Episodes");

                    //DataTable dtOld_Lists = sh.Select("Select * FROM Lists");
                    //DataTable dtOld_ListsMovies = sh.Select("Select * FROM ListsMovies");

                    pbProgress.Properties.Step = 1;
                    pbProgress.Properties.PercentView = true;
                    pbProgress.Properties.Maximum = dtOld_Movies.Rows.Count + dtOld_Series.Rows.Count;
                    pbProgress.Properties.Minimum = 0;

                    using (SQLiteCommand cmdRepair = new SQLiteCommand())
                    {
                        cmdRepair.Connection = connRepair;
                        connRepair.Open();

                        SQLiteHelper shRepair = new SQLiteHelper(cmdRepair);
                        shRepair.BeginTransaction();
                        foreach (DataRow dr in dtOld_Movies.Rows)
                        {
                            long id = 0;
                            //lblStatus.Text = Util.convertToString(dr["OrginalName"]);
                            ///bwUpdate.ReportProgress(id);

                            pbProgress.PerformStep();
                            pbProgress.Update();

                            var dic = new Dictionary<string, object>();
                            dic["OrginalName"] = dr["OrginalName"];
                            dic["OtherName"] = dr["OtherName"];
                            dic["Director"] = dr["Director"];
                            dic["Writer"] = dr["Writer"];
                            dic["Genre"] = dr["Genre"];
                            dic["Year"] = dr["Year"];
                            dic["UserRating"] = dr["UserRating"];
                            dic["Votes"] = dr["Votes"];
                            dic["ImdbUserRating"] = dr["ImdbUserRating"];
                            dic["ImdbVotes"] = dr["ImdbVotes"];
                            dic["TmdbUserRating"] = dr["TmdbUserRating"];
                            dic["TmdbVotes"] = dr["TmdbVotes"];
                            dic["RunningTime"] = dr["RunningTime"];
                            dic["Country"] = dr["Country"];
                            dic["Language"] = dr["Language"];
                            dic["EnglishPlot"] = dr["EnglishPlot"];
                            dic["OtherPlot"] = dr["OtherPlot"];
                            dic["Budget"] = dr["Budget"];
                            dic["ProductionCompany"] = dr["ProductionCompany"];
                            dic["ImdbNumber"] = dr["ImdbNumber"];
                            dic["TmdbNumber"] = dr["TmdbNumber"];
                            dic["ArchivesNumber"] = dr["ArchivesNumber"];
                            dic["Subtitle"] = dr["Subtitle"];
                            dic["Dubbing"] = dr["Dubbing"];
                            dic["PersonalRating"] = dr["PersonalRating"];
                            dic["UserColumn1"] = dr["UserColumn1"];
                            dic["UserColumn2"] = dr["UserColumn2"];
                            dic["UserColumn3"] = dr["UserColumn3"];
                            dic["UserColumn4"] = dr["UserColumn4"];
                            dic["UserColumn5"] = dr["UserColumn5"];
                            dic["UserColumn6"] = dr["UserColumn6"];
                            dic["RlsType"] = dr["RlsType"];
                            dic["RlsGroup"] = dr["RlsGroup"];
                            dic["Poster"] = dr["Poster"];
                            dic["Note"] = dr["Note"];
                            dic["Seen"] = dr["Seen"];
                            dic["IsSyncWaiting"] = dr["IsSyncWaiting"];
                            dic["ContentProvider"] = dr["ContentProvider"];
                            dic["InsertDate"] = dr["InsertDate"];
                            dic["UpdateDate"] = dr["UpdateDate"];


                            shRepair.Insert("Movies", dic);

                            id = shRepair.LastInsertRowId();


                            DataRow[] files = dtOld_Files.Select("MovieID=" + dr["_id"]);
                            foreach (DataRow dr2 in files)
                            {
                                var dic2 = new Dictionary<string, object>();
                                dic2["MovieID"] = id;
                                dic2["FileName"] = dr2["FileName"];
                                dic2["Resolution"] = dr2["Resolution"];
                                dic2["VideoCodec"] = dr2["VideoCodec"];
                                dic2["VideoBitrate"] = dr2["VideoBitrate"];
                                dic2["Fps"] = dr2["Fps"];
                                dic2["VideoAspectRatio"] = dr2["VideoAspectRatio"];
                                dic2["AudioCodec1"] = dr2["AudioCodec1"];
                                dic2["AudioChannels1"] = dr2["AudioChannels1"];
                                dic2["AudioBitrate1"] = dr2["AudioBitrate1"];
                                dic2["AudioSampleRate1"] = dr2["AudioSampleRate1"];
                                dic2["AudioSize1"] = dr2["AudioSize1"];
                                dic2["AudioCodec2"] = dr2["AudioCodec2"];
                                dic2["AudioChannels2"] = dr2["AudioChannels2"];
                                dic2["AudioBitrate2"] = dr2["AudioBitrate2"];
                                dic2["AudioSampleRate2"] = dr2["AudioSampleRate2"];
                                dic2["AudioSize2"] = dr2["AudioSize2"];
                                dic2["TotalFrames"] = dr2["TotalFrames"];
                                dic2["Lenght"] = dr2["Lenght"];
                                dic2["VideoSize"] = dr2["VideoSize"];
                                dic2["FileSize"] = dr2["FileSize"];
                                dic2["Chapter"] = dr2["Chapter"];

                                shRepair.Insert("Files", dic2);
                            }


                            DataRow[] casts = dtOld_Casts.Select("ObjectID=" + dr["_id"]);
                            foreach (DataRow dr3 in casts)
                            {
                                var dic2 = new Dictionary<string, object>();
                                dic2["ObjectID"] = id;
                                dic2["Name"] = dr3["Name"];
                                dic2["Character"] = dr3["Character"];
                                dic2["Url"] = dr3["Url"];
                                dic2["ImageUrl"] = dr3["ImageUrl"];
                                dic2["CastID"] = dr3["CastID"];
                                dic2["CollectionType"] = dr3["CollectionType"];

                                shRepair.Insert("Casts", dic2);
                            }

                            DataRow[] Backdrops = dtOld_Backdrops.Select("ObjectID=" + dr["_id"]);
                            foreach (DataRow dr3 in Backdrops)
                            {
                                var dic2 = new Dictionary<string, object>();
                                dic2["ObjectID"] = id;
                                dic2["Url"] = dr3["Url"];
                                dic2["ImdbNumber"] = dr3["ImdbNumber"];
                                dic2["CollectionType"] = dr3["CollectionType"];

                                shRepair.Insert("Backdrops", dic2);
                            }
                        }
                        shRepair.Commit();



                        // Series
                        shRepair.BeginTransaction();
                        foreach (DataRow dr in dtOld_Series.Rows)
                        {
                            long id = 0;
                            pbProgress.PerformStep();
                            pbProgress.Update();

                            var dic = new Dictionary<string, object>();
                            dic["SeriesName"] = dr["SeriesName"];
                            dic["Overview"] = dr["Overview"];
                            dic["FirstAired"] = dr["FirstAired"];
                            dic["Network"] = dr["Network"];
                            dic["ImdbId"] = dr["ImdbId"];
                            dic["TvdbId"] = dr["TvdbId"];
                            dic["TraktId"] = dr["TraktId"];
                            dic["Language"] = dr["Language"];
                            dic["Country"] = dr["Country"];
                            dic["Genres"] = dr["Genres"];
                            dic["Runtime"] = dr["Runtime"];
                            dic["Certification"] = dr["Certification"];
                            dic["AirDay"] = dr["AirDay"];
                            dic["AirTime"] = dr["AirTime"];
                            dic["AirYear"] = dr["AirYear"];
                            dic["Timezone"] = dr["Timezone"];
                            dic["Status"] = dr["Status"];
                            dic["Rating"] = dr["Rating"];
                            dic["Votes"] = dr["Votes"];
                            dic["SeriesLastUpdate"] = dr["SeriesLastUpdate"];
                            dic["Poster"] = dr["Poster"];
                            dic["Fanart"] = dr["Fanart"];
                            dic["Homepage"] = dr["Homepage"];
                            dic["ContentProvider"] = dr["ContentProvider"];
                            dic["InsertDate"] = dr["InsertDate"];
                            dic["UpdateDate"] = dr["SeriesName"];


                            shRepair.Insert("Series", dic);

                            id = shRepair.LastInsertRowId();


                            DataRow[] Seasons = dtOld_Seasons.Select("SeriesId=" + dr["_id"]);
                            foreach (DataRow s in Seasons)
                            {
                                var dic2 = new Dictionary<string, object>();
                                dic2["SeriesId"] = id;
                                dic2["AiredEpisodes"] = s["AiredEpisodes"];
                                dic2["EpisodeCount"] = s["EpisodeCount"];
                                dic2["Number"] = s["Number"];
                                dic2["Overview"] = s["Overview"];
                                dic2["Rating"] = s["Rating"];
                                dic2["TmdbId"] = s["TmdbId"];
                                dic2["TvdbId"] = s["TvdbId"];
                                dic2["TraktId"] = s["TraktId"];
                                dic2["Votes"] = s["Votes"];
                                dic2["Poster"] = s["Poster"];


                                shRepair.Insert("Seasons", dic2);
                            }

                            DataRow[] Episodes = dtOld_Episodes.Select("SeriesId=" + dr["_id"]);
                            foreach (DataRow s in Episodes)
                            {
                                var dic2 = new Dictionary<string, object>();
                                dic2["SeriesId"] = id;
                                dic2["SeasonId"] = s["SeasonId"];
                                dic2["EpisodeName"] = s["EpisodeName"];
                                dic2["EpisodeNumber"] = s["EpisodeNumber"];
                                dic2["FirstAiredMs"] = s["FirstAiredMs"];
                                dic2["GuestStars"] = s["GuestStars"];
                                dic2["Overview"] = s["Overview"];
                                dic2["Rating"] = s["Rating"];
                                dic2["RatingCount"] = s["RatingCount"];
                                dic2["SeasonNumber"] = s["SeasonNumber"];
                                dic2["AirsAfterSeason"] = s["AirsAfterSeason"];
                                dic2["AirsBeforeSeason"] = s["AirsBeforeSeason"];
                                dic2["AirsBeforeEpisode"] = s["AirsBeforeEpisode"];
                                dic2["EpisodeImage"] = s["EpisodeImage"];
                                dic2["LastUpdated"] = s["LastUpdated"];
                                dic2["TvdbEpisodeId"] = s["TvdbEpisodeId"];
                                dic2["TvdbSeriesId"] = s["TvdbSeriesId"];
                                dic2["TvdbSeasonId"] = s["TvdbSeasonId"];
                                dic2["Collected"] = s["Collected"];
                                dic2["Watched"] = s["Watched"];
                                dic2["Favorite"] = s["Favorite"];

                                shRepair.Insert("Episodes", dic2);
                            }
                        }
                        shRepair.Commit();





                        //// Lists
                        //shRepair.BeginTransaction();
                        //foreach (DataRow dr in dtOld_Lists.Rows)
                        //{
                        //    long id = 0;

                        //    var dic = new Dictionary<string, object>();
                        //    dic["ListName"] = dr["ListName"];
                        //    dic["UpdateDate"] = dr["UpdateDate"];

                        //    shRepair.Insert("Lists", dic);

                        //    id = shRepair.LastInsertRowId();


                        //    DataRow[] ListsMovies = dtOld_ListsMovies.Select("SeriesId=" + dr["_id"]);
                        //    foreach (DataRow s in ListsMovies)
                        //    {
                        //        var dic2 = new Dictionary<string, object>();
                        //        dic2["SeriesId"] = id;
                        //        dic2["AiredEpisodes"] = s["AiredEpisodes"];



                        //        shRepair.Insert("Seasons", dic2);
                        //    }
                        //}
                        //shRepair.Commit();
                    }
                    #endregion


                    if (conn != null && conn.State != ConnectionState.Closed)
                        conn.Close();

                    if (connRepair != null && connRepair.State != ConnectionState.Closed)
                        connRepair.Close();
                }
                catch (Exception ex)
                {
                    if (conn != null && conn.State != ConnectionState.Closed)
                        conn.Close();

                    if (connRepair != null && connRepair.State != ConnectionState.Closed)
                        connRepair.Close();

                    if (File.Exists(Application.StartupPath + "\\Database\\GrieeX.db.repair"))
                        File.Delete(Application.StartupPath + "\\Database\\GrieeX.db.repair");

                    this.Close();
                    XtraMessageBox.Show(Language.FindKey("Messages", "17").Value.ToString());
                }
            }
        }
    }
}