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
    public partial class frmUpdater : DevExpress.XtraEditors.XtraForm
    {
        string strImagePath = Application.StartupPath + "\\Images\\";
        string strPosterPath = Application.StartupPath + "\\Images\\Posters\\";
        string strCastPath = Application.StartupPath + "\\Images\\Casts\\";

        public frmUpdater()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            // EmitLanguage();
        }


        private void frmBackup_Load(object sender, EventArgs e)
        {
            bwBackup.RunWorkerAsync();
        }


        private void bwBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            Updatee();
        }

        private void bwBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frmMain.GlobalForm.Search();

            // File.Move(Application.StartupPath + "\\Database\\dbGrieeX.mdb", Application.StartupPath + "\\Database\\dbGrieeX.backup");


            this.Close();

        }

        private void frmBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (bwBackup.IsBusy)
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

                File.Copy(Application.StartupPath + "\\Database\\dbGrieeX.mdb", Application.StartupPath + "\\Database\\dbGrieeX.backup", true);
                if (File.Exists(Application.StartupPath + "\\Database\\dbGrieeX.mdb"))
                {
                    System.IO.File.SetAttributes(Application.StartupPath + "\\Database\\dbGrieeX.mdb", System.IO.FileAttributes.Archive);
                    File.Delete(Application.StartupPath + "\\Database\\dbGrieeX.mdb");
                }
                // frmMain.GlobalForm.SyncImdb();
            }
            catch (Exception ex)
            {

            }
        }



        private void Updatee()
        {
            try
            {
                Data.OleDb.Connect();

                DataTable dtAccess_Movies = Data.Execute("SELECT * FROM tMovies Order By strOrginalName asc", Data.ReturnType.Datatable) as DataTable;
                DataTable dtAccess_Files = Data.Execute("SELECT * FROM tFiles", Data.ReturnType.Datatable) as DataTable;
                DataTable dtAccess_RlsTypes = Data.Execute("SELECT * FROM tRlsTypes", Data.ReturnType.Datatable) as DataTable;
                DataTable dtAccess_RlsGroup = Data.Execute("SELECT * FROM tRlsGroups", Data.ReturnType.Datatable) as DataTable;

                pbProgress.Properties.Step = 1;
                pbProgress.Properties.PercentView = true;
                pbProgress.Properties.Maximum = dtAccess_Movies.Rows.Count;
                pbProgress.Properties.Minimum = 0;


                using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        sh.BeginTransaction();
                        foreach (DataRow dr in dtAccess_Movies.Rows)
                        {
                            bwBackup.ReportProgress(0);

                            long id = 0;
                            lblStatus.Text = Util.convertToString(dr["strOrginalName"]);

                            var dic = new Dictionary<string, object>();
                            dic["OrginalName"] = Util.convertToString(dr["strOrginalName"]);
                            dic["OtherName"] = Util.convertToString(dr["strOtherName"]);
                            dic["Director"] = Util.convertToString(dr["strDirector"]);
                            dic["Writer"] = Util.convertToString(dr["strWriter"]);
                            dic["Genre"] = Util.convertToString(dr["strGenre"]);
                            dic["Year"] = Util.convertToString(dr["strYear"]);
                            dic["UserRating"] = Util.convertToString(dr["strUserRating"]);
                            dic["Votes"] = Util.convertToInt(dr["nVotes"]);
                            dic["RunningTime"] = Util.convertToString(dr["strRunningTime"]);
                            dic["Country"] = Util.convertToString(dr["strCountry"]);
                            dic["Language"] = Util.convertToString(dr["strLanguage"]);
                            dic["EnglishPlot"] = Util.convertToString(dr["strEnglishPlot"]);
                            dic["OtherPlot"] = Util.convertToString(dr["strOtherPlot"]);

                            String strImdbNumber = Util.convertToString(dr["strImdbNumber"]); ;
                            if (!String.IsNullOrEmpty(strImdbNumber) && !strImdbNumber.Contains("tt"))
                            {
                                strImdbNumber = "tt" + strImdbNumber;
                            }
                            dic["ImdbNumber"] = strImdbNumber;

                            dic["ArchivesNumber"] = Util.convertToString(dr["strArchivesNumber"]);
                            dic["Subtitle"] = Util.convertToString(dr["strSubtitle"]);
                            dic["Dubbing"] = Util.convertToString(dr["strDubbing"]);
                            dic["PersonalRating"] = Util.convertToString(dr["nPersonalRating"]);
                            dic["UserColumn1"] = Util.convertToString(dr["strUserColumn1"]);
                            dic["UserColumn2"] = Util.convertToString(dr["strUserColumn2"]);
                            dic["UserColumn3"] = Util.convertToString(dr["strUserColumn3"]);
                            dic["UserColumn4"] = Util.convertToString(dr["strUserColumn4"]);
                            dic["Note"] = Util.convertToString(dr["strNote"]);
                            dic["InsertDate"] = dr["dtDateEntered"];
                            dic["UpdateDate"] = DateTime.Now;
                            dic["Seen"] = Util.convertToInt(Util.convertToBoolean(dr["bSeen"]));
                            dic["IsSyncWaiting"] = 0;
                            dic["ContentProvider"] = (int)Enums.WebType.IMDB;

                            if (dtAccess_RlsTypes != null && dtAccess_RlsTypes.Rows.Count > 0)
                            {
                                if (!String.IsNullOrEmpty(dr["nRlsType"].ToString()))
                                {
                                    DataRow[] RlsType = dtAccess_RlsTypes.Select("kRlsType=" + dr["nRlsType"]);
                                    if (RlsType != null && RlsType.Length > 0)
                                    {
                                        dic["RlsType"] = RlsType[0]["strRlsType"];
                                    }
                                }

                            }

                            if (dtAccess_RlsGroup != null && dtAccess_RlsGroup.Rows.Count > 0)
                            {
                                if (!String.IsNullOrEmpty(dr["nRlsGroup"].ToString()))
                                {
                                    DataRow[] RlsGroup = dtAccess_RlsGroup.Select("kRlsGroup=" + dr["nRlsGroup"]);
                                    if (RlsGroup != null && RlsGroup.Length > 0)
                                    {
                                        dic["RlsGroup"] = RlsGroup[0]["strRlsGroup"];
                                    }
                                }

                            }



                            sh.Insert("Movies", dic);

                            id = sh.LastInsertRowId();


                            DataRow[] files = dtAccess_Files.Select("kMovie=" + dr["kMovie"]);
                            foreach (DataRow dr2 in files)
                            {
                                var dic2 = new Dictionary<string, object>();
                                dic2["MovieID"] = id;
                                dic2["FileName"] = Util.convertToString(dr2["strFileName"]);
                                dic2["Resolution"] = Util.convertToString(dr2["strResolution"]);
                                dic2["VideoCodec"] = Util.convertToString(dr2["strVideoCodec"]);
                                dic2["VideoBitrate"] = Util.convertToString(dr2["strVideoBitrate"]);
                                dic2["Fps"] = Util.convertToString(dr2["strFps"]);
                                dic2["VideoAspectRatio"] = Util.convertToString(dr2["strVideoAspectRatio"]);
                                dic2["AudioCodec1"] = Util.convertToString(dr2["strAudioCodec1"]);
                                dic2["AudioChannels1"] = Util.convertToString(dr2["strAudioChannels1"]);
                                dic2["AudioBitrate1"] = Util.convertToString(dr2["strAudioBitrate1"]);
                                dic2["AudioSampleRate1"] = Util.convertToString(dr2["strAudioSampleRate1"]);
                                dic2["AudioSize1"] = Util.convertToString(dr2["strAudioSize1"]);
                                dic2["AudioCodec2"] = Util.convertToString(dr2["strAudioCodec2"]);
                                dic2["AudioChannels2"] = Util.convertToString(dr2["strAudioChannels2"]);
                                dic2["AudioBitrate2"] = Util.convertToString(dr2["strAudioBitrate2"]);
                                dic2["AudioSampleRate2"] = Util.convertToString(dr2["strAudioSampleRate2"]);
                                dic2["AudioSize2"] = Util.convertToString(dr2["strAudioSize2"]);
                                dic2["TotalFrames"] = Util.convertToString(dr2["strTotalFrames"]);
                                dic2["Lenght"] = Util.convertToString(dr2["strLenght"]);
                                dic2["VideoSize"] = Util.convertToString(dr2["strVideoSize"]);
                                dic2["FileSize"] = Util.convertToString(dr2["strFileSize"]);
                                dic2["Chapter"] = Util.convertToString(dr2["nChapter"]);

                                sh.Insert("Files", dic2);
                            }
                        }
                        sh.Commit();



                        conn.Close();
                    }
                }

                Data.OleDb.Disconnect();

            }
            catch (Exception e)
            {
            }
        }

        private void bwBackup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProgress.PerformStep();
            pbProgress.Update();
        }
    }
}