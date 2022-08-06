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
    public partial class frmDatabaseUpdater : DevExpress.XtraEditors.XtraForm
    {
        Boolean bRepair = false;
        Boolean bIsCompleted = false;

        string strImagePath = Application.StartupPath + "\\Images\\";
        string strPosterPath = Application.StartupPath + "\\Images\\Posters\\";
        string strCastPath = Application.StartupPath + "\\Images\\Casts\\";

        public frmDatabaseUpdater()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            EmitLanguage();
        }


        private void frmDatabaseUpdater_Load(object sender, EventArgs e)
        {
            bwUpdate.RunWorkerAsync();
        }


        private void bwUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource);

            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = conn;
                conn.Open();
                try
                {
                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    int OldDatabaseVersion = sh.ExecuteScalar<int>("Select version From android_database_version");

                    if (OldDatabaseVersion < 2)
                    {
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN ImdbUserRating TEXT"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN ImdbVotes TEXT"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN TmdbUserRating TEXT"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN TmdbVotes TEXT"); }
                        catch { }
                    }

                    if (OldDatabaseVersion < 3)
                    {
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN TmdbNumber TEXT"); }
                        catch { }
                        try { sh.Execute("CREATE TABLE Trailers (`_id` INTEGER PRIMARY KEY AUTOINCREMENT, ObjectID INTEGER, Url TEXT, Type TEXT)"); }
                        catch { }
                    }

                    if (OldDatabaseVersion < 4)
                    {
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN RlsType TEXT"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN RlsGroup TEXT"); }
                        catch { }
                    }

                    if (OldDatabaseVersion < 5)
                    {
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN UserColumn5 TEXT"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN UserColumn6 TEXT"); }
                        catch { }
                    }

                    if (OldDatabaseVersion < 6)
                    {
                        bRepair = true;
                    }

                    if (OldDatabaseVersion < 8)
                    {
                        try { sh.Execute("Delete From Imdb250"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Imdb250 ADD COLUMN Type INTEGER"); }
                        catch { }
                    }

                    if (OldDatabaseVersion < 9)
                    {
                        try { sh.Execute("ALTER TABLE Series ADD COLUMN ImdbUserRating TEXT"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Series ADD COLUMN ImdbVotes TEXT"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Series ADD COLUMN TmdbUserRating TEXT"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Series ADD COLUMN TmdbVotes TEXT"); }
                        catch { }
                    }

                    if (OldDatabaseVersion < 10)
                    {
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN ReleaseDate TEXT"); }
                        catch { }
                    }

                    if (OldDatabaseVersion < 11)
                    {
                        try { sh.Execute("ALTER TABLE Lists ADD COLUMN ListType INTEGER"); }
                        catch { }
                        try { sh.Execute("CREATE TABLE ListsSeries (`_id` INTEGER PRIMARY KEY AUTOINCREMENT, ListID INTEGER, SeriesID INTEGER)"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Series ADD COLUMN Tags TEXT"); }
                        catch { }
                        try { sh.Execute("ALTER TABLE Movies ADD COLUMN Tags TEXT"); }
                        catch { }
                        try { sh.Execute("UPDATE Lists SET ListType=1"); }
                        catch { }
                    }

                    if (!bRepair)
                        setDatabaseVersion();



                }
                catch (Exception ex)
                {
                }
                finally
                {
                    if (conn != null && conn.State != ConnectionState.Closed)
                        conn.Close();

                    bIsCompleted = true;
                }
            }
        }

        private void setDatabaseVersion()
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.Execute("UPDATE android_database_version SET version=" + GrieeXSettings.DB_VERSION);


                    conn.Close();
                }
            }
        }


        private void bwUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bRepair)
            {
                bwRepair.RunWorkerAsync();
            }
            else
            {
                frmMain.GlobalForm.Search();
                this.Close();
            }


        }

        private void frmDatabaseUpdater_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bIsCompleted)
            {
                if (bwUpdate.IsBusy)
                {
                    if (XtraMessageBox.Show(Language.FindKey("Messages", "19").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bwUpdate.CancelAsync();
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

                if (bwRepair.IsBusy)
                {
                    if (XtraMessageBox.Show(Language.FindKey("Messages", "19").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bwUpdate.CancelAsync();
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

            }
        }

        private void bwUpdate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bwRepair_DoWork(object sender, DoWorkEventArgs e)
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

                    marqueeProgress.Visible = false;// = DevExpress.XtraBars.BarItemVisibility.Never;
                    pbProgress.Properties.Step = 1;
                    pbProgress.Properties.PercentView = true;
                    pbProgress.Properties.Maximum = dtOld_Movies.Rows.Count;
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
                            bwRepair.ReportProgress(0);

                            var dic = new Dictionary<string, object>();
                            dic["OrginalName"] = Util.convertToString(dr["OrginalName"]);
                            dic["OtherName"] = Util.convertToString(dr["OtherName"]);
                            dic["Director"] = Util.convertToString(dr["Director"]);
                            dic["Writer"] = Util.convertToString(dr["Writer"]);
                            dic["Genre"] = Util.convertToString(dr["Genre"]);
                            dic["Year"] = Util.convertToString(dr["Year"]);
                            dic["UserRating"] = Util.convertToString(dr["UserRating"]);
                            dic["Votes"] = Util.convertToInt(dr["Votes"]);
                            dic["RunningTime"] = Util.convertToString(dr["RunningTime"]);
                            dic["Country"] = Util.convertToString(dr["Country"]);
                            dic["Language"] = Util.convertToString(dr["Language"]);
                            dic["EnglishPlot"] = Util.convertToString(dr["EnglishPlot"]);
                            dic["OtherPlot"] = Util.convertToString(dr["OtherPlot"]);
                            dic["Budget"] = Util.convertToString(dr["Budget"]);
                            dic["ProductionCompany"] = Util.convertToString(dr["ProductionCompany"]);
                            dic["ImdbNumber"] = Util.convertToString(dr["ImdbNumber"]);
                            dic["ArchivesNumber"] = Util.convertToString(dr["ArchivesNumber"]);
                            dic["Subtitle"] = Util.convertToString(dr["Subtitle"]);
                            dic["Dubbing"] = Util.convertToString(dr["Dubbing"]);
                            dic["PersonalRating"] = Util.convertToString(dr["PersonalRating"]);
                            dic["UserColumn1"] = Util.convertToString(dr["UserColumn1"]);
                            dic["UserColumn2"] = Util.convertToString(dr["UserColumn2"]);
                            dic["UserColumn3"] = Util.convertToString(dr["UserColumn3"]);
                            dic["UserColumn4"] = Util.convertToString(dr["UserColumn4"]);
                            dic["UserColumn5"] = Util.convertToString(dr["UserColumn5"]);
                            dic["UserColumn6"] = Util.convertToString(dr["UserColumn6"]);
                            dic["RlsType"] = dr["RlsType"];
                            dic["RlsGroup"] = dr["RlsGroup"];
                            dic["Poster"] = Util.convertToString(dr["Poster"]);
                            dic["Note"] = Util.convertToString(dr["Note"]);
                            dic["Seen"] = Util.convertToInt(Util.convertToBoolean(dr["Seen"]));
                            dic["ContentProvider"] = Util.convertToString(dr["ContentProvider"]);
                            dic["IsSyncWaiting"] = 0;
                            dic["InsertDate"] = dr["InsertDate"];
                            dic["UpdateDate"] = dr["UpdateDate"];


                            shRepair.Insert("Movies", dic);

                            id = shRepair.LastInsertRowId();


                            DataRow[] files = dtOld_Files.Select("MovieID=" + dr["_id"]);
                            foreach (DataRow dr2 in files)
                            {
                                var dic2 = new Dictionary<string, object>();
                                dic2["MovieID"] = id;
                                dic2["FileName"] = Util.convertToString(dr2["FileName"]);
                                dic2["Resolution"] = Util.convertToString(dr2["Resolution"]);
                                dic2["VideoCodec"] = Util.convertToString(dr2["VideoCodec"]);
                                dic2["VideoBitrate"] = Util.convertToString(dr2["VideoBitrate"]);
                                dic2["Fps"] = Util.convertToString(dr2["Fps"]);
                                dic2["VideoAspectRatio"] = Util.convertToString(dr2["VideoAspectRatio"]);
                                dic2["AudioCodec1"] = Util.convertToString(dr2["AudioCodec1"]);
                                dic2["AudioChannels1"] = Util.convertToString(dr2["AudioChannels1"]);
                                dic2["AudioBitrate1"] = Util.convertToString(dr2["AudioBitrate1"]);
                                dic2["AudioSampleRate1"] = Util.convertToString(dr2["AudioSampleRate1"]);
                                dic2["AudioSize1"] = Util.convertToString(dr2["AudioSize1"]);
                                dic2["AudioCodec2"] = Util.convertToString(dr2["AudioCodec2"]);
                                dic2["AudioChannels2"] = Util.convertToString(dr2["AudioChannels2"]);
                                dic2["AudioBitrate2"] = Util.convertToString(dr2["AudioBitrate2"]);
                                dic2["AudioSampleRate2"] = Util.convertToString(dr2["AudioSampleRate2"]);
                                dic2["AudioSize2"] = Util.convertToString(dr2["AudioSize2"]);
                                dic2["TotalFrames"] = Util.convertToString(dr2["TotalFrames"]);
                                dic2["Lenght"] = Util.convertToString(dr2["Lenght"]);
                                dic2["VideoSize"] = Util.convertToString(dr2["VideoSize"]);
                                dic2["FileSize"] = Util.convertToString(dr2["FileSize"]);
                                dic2["Chapter"] = Util.convertToString(dr2["Chapter"]);

                                shRepair.Insert("Files", dic2);
                            }


                            DataRow[] casts = dtOld_Casts.Select("ObjectID=" + dr["_id"]);
                            foreach (DataRow dr3 in casts)
                            {
                                var dic2 = new Dictionary<string, object>();
                                dic2["ObjectID"] = id;
                                dic2["Name"] = Util.convertToString(dr3["Name"]);
                                dic2["Character"] = Util.convertToString(dr3["Character"]);
                                dic2["Url"] = Util.convertToString(dr3["Url"]);
                                dic2["ImageUrl"] = Util.convertToString(dr3["ImageUrl"]);
                                dic2["CastID"] = Util.convertToString(dr3["CastID"]);
                                if (dr3.Table.Columns.Contains("CollectionType"))
                                    dic2["CollectionType"] = Util.convertToString(dr3["CollectionType"]);
                                else
                                    dic2["CollectionType"] = 1;

                                // dic2["CollectionType"] = Util.convertToString(dr3["CollectionType"]);

                                shRepair.Insert("Casts", dic2);
                            }
                        }
                        shRepair.Commit();
                    }
                    #endregion

                    setDatabaseVersion();

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

        private void bwRepair_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {

            }
            else if (!(e.Error == null))
            {

            }
            else
            {
                Application.Restart();
            }
        }

        private void bwRepair_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProgress.PerformStep();
            pbProgress.Update();
        }

    }
}