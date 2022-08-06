using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GrieeX.GrieeXBase;
using System.Data.SQLite;
using System.IO;

namespace GrieeX.Forms
{
    public partial class frmMultiFile : DevExpress.XtraEditors.XtraForm
    {
        public frmMultiFile()
        {
            InitializeComponent();
            EmitLanguage();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                txtFolder.Text = fbd.SelectedPath;

                btnImport.Enabled = false;
                pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                lvColumns.Items.Clear();

                bw2.RunWorkerAsync();
            }
            catch (Exception)
            {

            }
        }

        private void GetDirectorys(string strFolder)
        {
            try
            {
                if (string.IsNullOrEmpty(strFolder))
                {
                    return;
                }

                GetFiles(strFolder);

                foreach (string d in System.IO.Directory.GetDirectories(strFolder))
                {
                    if (bw2.CancellationPending == true)
                    {
                        break;
                    }
                    else
                    {
                        GetDirectorys(d);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void GetFiles(string strFolder)
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

                        foreach (string s in System.IO.Directory.GetFiles(strFolder))
                        {

                            try
                            {

                                if (bw2.CancellationPending == true)
                                {
                                    break;
                                }
                                else
                                {
                                    slStatus.Caption = s;

                                    if (fileext(s) == true)
                                    {
                                        if (chkRepeated.Checked == true)
                                        {
                                            string strFile = Path.GetFileName(s);

                                            String str = sh.ExecuteScalar("SELECT COUNT(*) FROM Files Where FileName Like '%" + strFile + "'").ToString();
                                            if (str == "0")
                                            {
                                                ListViewItem Item = new ListViewItem();
                                                Item.Text = s;
                                                lvColumns.Items.Add(Item);
                                            }
                                            else
                                            {

                                            }
                                        }
                                        else
                                        {
                                            ListViewItem Item = new ListViewItem();
                                            Item.Text = s;
                                            lvColumns.Items.Add(Item);
                                        }
                                    }

                                }
                            }
                            catch (Exception)
                            {
                            }




                        }
                    }

                    conn.Close();
                }


            }
            catch (Exception ex)
            {
            }
        }

        private bool fileext(string strFile)
        {
            strFile = strFile.ToLower();

            if (strFile.EndsWith(".avi") | strFile.EndsWith(".mkv") | strFile.EndsWith(".ts") | strFile.EndsWith(".ogm") | strFile.EndsWith(".ogg") | strFile.EndsWith(".divx") | strFile.EndsWith(".wmv") | strFile.EndsWith(".mov") | strFile.EndsWith(".mpg") | strFile.EndsWith(".mpeg") | strFile.EndsWith(".mp4") | strFile.EndsWith(".vob") | strFile.EndsWith(".asf") | strFile.EndsWith(".rm") | strFile.EndsWith(".ra") | strFile.EndsWith(".rmvb") | strFile.EndsWith(".dat") | strFile.EndsWith(".flv"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            ListViewItem Item = null;
            {
                foreach (ListViewItem Item_loopVariable in lvColumns.Items)
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
                foreach (ListViewItem Item_loopVariable in lvColumns.Items)
                {
                    Item = Item_loopVariable;
                    Item.Checked = false;
                }
            }
        }



        private void btnImport_Click(object sender, EventArgs e)
        {
            //pbProgress.Maximum = lvColumns.CheckedItems.Count;
            //pbProgress.Visible = true;
            pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnCancel.Enabled = true;
            btnImport.Enabled = false;

            if (!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }
        }

        public void tFiles_Save()
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    for (int i = 0; i <= dsFiles.Tables[0].Rows.Count - 1; i++)
                    {
                        try
                        {
                            switch (dsFiles.Tables[0].Rows[i].RowState)
                            {
                                case DataRowState.Added:
                                    var dic = new Dictionary<string, object>();
                                    dic["MovieID"] = kMovie;
                                    dic["FileName"] = dsFiles.Tables[0].Rows[i]["FileName"].ToString();
                                    dic["Resolution"] = dsFiles.Tables[0].Rows[i]["Resolution"].ToString();
                                    dic["VideoCodec"] = dsFiles.Tables[0].Rows[i]["VideoCodec"].ToString();
                                    dic["VideoBitrate"] = dsFiles.Tables[0].Rows[i]["VideoBitrate"].ToString();
                                    dic["Fps"] = dsFiles.Tables[0].Rows[i]["Fps"].ToString();
                                    dic["VideoAspectRatio"] = dsFiles.Tables[0].Rows[i]["VideoAspectRatio"].ToString();
                                    dic["AudioCodec1"] = dsFiles.Tables[0].Rows[i]["AudioCodec1"].ToString();
                                    dic["AudioChannels1"] = dsFiles.Tables[0].Rows[i]["AudioChannels1"].ToString();
                                    dic["AudioBitrate1"] = dsFiles.Tables[0].Rows[i]["AudioBitrate1"].ToString();
                                    dic["AudioSampleRate1"] = dsFiles.Tables[0].Rows[i]["AudioSampleRate1"].ToString();
                                    dic["AudioSize1"] = dsFiles.Tables[0].Rows[i]["AudioSize1"].ToString();
                                    dic["AudioCodec2"] = dsFiles.Tables[0].Rows[i]["AudioCodec2"].ToString();
                                    dic["AudioChannels2"] = dsFiles.Tables[0].Rows[i]["AudioChannels2"].ToString();
                                    dic["AudioBitrate2"] = dsFiles.Tables[0].Rows[i]["AudioBitrate2"].ToString();
                                    dic["AudioSampleRate2"] = dsFiles.Tables[0].Rows[i]["AudioSampleRate2"].ToString();
                                    dic["AudioSize2"] = dsFiles.Tables[0].Rows[i]["AudioSize2"].ToString();
                                    dic["TotalFrames"] = dsFiles.Tables[0].Rows[i]["TotalFrames"].ToString();
                                    dic["Lenght"] = dsFiles.Tables[0].Rows[i]["Lenght"].ToString();
                                    dic["VideoSize"] = dsFiles.Tables[0].Rows[i]["VideoSize"].ToString();
                                    dic["FileSize"] = dsFiles.Tables[0].Rows[i]["FileSize"].ToString();
                                    dic["Chapter"] = dsFiles.Tables[0].Rows[i]["Chapter"].ToString();

                                    sh.Insert("Files", dic);

                                    break;
                                case DataRowState.Deleted:
                                    Files tDeleted = new Files(dsFiles.Tables[0].Rows[i][0, DataRowVersion.Original].ToString());
                                    tDeleted.Delete();
                                    break;
                                case DataRowState.Modified:
                                    Files tModified = new Files(dsFiles.Tables[0].Rows[i]["_id"].ToString());
                                    tModified.FileName = dsFiles.Tables[0].Rows[i]["FileName"].ToString();
                                    if (!String.IsNullOrEmpty(dsFiles.Tables[0].Rows[i]["Chapter"].ToString()) && Util.IsNumeric(dsFiles.Tables[0].Rows[i]["Chapter"].ToString()))
                                    {
                                        tModified.Chapter = dsFiles.Tables[0].Rows[i]["Chapter"].ToString();
                                    }

                                    tModified.Save();
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }


                    conn.Close();
                }
            }
        }


        public long kMovie;
        private ft _FormType;

        public enum ft
        {
            Single, Multi
        }
        public ft FormType
        {
            get { return _FormType; }
            set { _FormType = value; }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (ListViewItem Item in lvColumns.Items)
            {
                if (bw.CancellationPending == true)
                {
                    try
                    {
                        btnCancel.Enabled = false;
                        btnImport.Enabled = true;
                        pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        slStatus.Caption = Language.FindKey("Messages", "17").Value;
                        e.Cancel = true;
                        break;
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    try
                    {
                        if (Item.Checked == true)
                        {
                            dsFiles.Clear();

                            string strOrginalName = Item.Text;
                            strOrginalName = Path.GetFileName(strOrginalName);
                            string ext = Path.GetExtension(strOrginalName);
                            strOrginalName = strOrginalName.Replace(ext, "");
                            slStatus.Caption = strOrginalName;

                            if (FormType == ft.Multi)
                            {
                                using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                                {
                                    using (SQLiteCommand cmd = new SQLiteCommand())
                                    {
                                        cmd.Connection = conn;
                                        conn.Open();

                                        SQLiteHelper sh = new SQLiteHelper(cmd);

                                        var dic = new Dictionary<string, object>();
                                        dic["OrginalName"] = strOrginalName;
                                        dic["Seen"] = 0;
                                        dic["InsertDate"] = DateTime.Now;

                                        sh.Insert("Movies", dic);

                                        kMovie = sh.LastInsertRowId();

                                        conn.Close();
                                    }
                                }
                            }

                            FileOpen(Item.Text);
                            tFiles_Save();
                            Item.Checked = false;
                            bw.ReportProgress(Item.Index);
                        }
                    }
                    catch (Exception ee)
                    {

                    }
                }
            }
        }

        public void FileOpen(string FileName)
        {
            MediaInfo MI = new MediaInfo();


            MI.Open(FileName);

            String str = MI.Get(StreamKind.Audio, 0, "StreamCount");
            if (string.IsNullOrEmpty(str))
            {
                return;
            }

            if (Convert.ToInt32(str) == 1)
            {
                dsFiles.Files.AddFilesRow(
                    "",
                    FileName,
                    MI.Get(StreamKind.Video, 0, "Width") + " x " + MI.Get(StreamKind.Video, 0, "Height"),
                    MI.Get(StreamKind.Video, 0, "Codec/String"),
                    (MI.Get(StreamKind.Video, 0, "BitRate/String") == "" ? MI.Get(StreamKind.General, 0, "BitRate/String") : MI.Get(StreamKind.Video, 0, "BitRate/String")),
                    MI.Get(StreamKind.Video, 0, "FrameRate"),
                    MI.Get(StreamKind.Video, 0, "DisplayAspectRatio/String"),
                    MI.Get(StreamKind.Audio, 0, "Codec/String"),
                    MI.Get(StreamKind.Audio, 0, "Channel(s)"),
                    MI.Get(StreamKind.Audio, 0, "BitRate/String"),
                    MI.Get(StreamKind.Audio, 0, "SamplingRate"),
                    MI.Get(StreamKind.Audio, 0, "StreamSize"),
                    String.Empty, String.Empty, String.Empty, String.Empty, String.Empty,
                    MI.Get(StreamKind.Video, 0, "FrameCount"),
                    MI.Get(StreamKind.General, 0, "PlayTime"),
                    MI.Get(StreamKind.Video, 0, "StreamSize"),
                    MI.Get(StreamKind.General, 0, "FileSize"), "0");
            }
            else
            {
                dsFiles.Files.AddFilesRow("", FileName, MI.Get(StreamKind.Video, 0, "Width") + " x " + MI.Get(StreamKind.Video, 0, "Height"), MI.Get(StreamKind.Video, 0, "Codec/String"), MI.Get(StreamKind.Video, 0, "BitRate/String"), MI.Get(StreamKind.Video, 0, "FrameRate"), MI.Get(StreamKind.Video, 0, "DisplayAspectRatio/String"), MI.Get(StreamKind.Audio, 0, "Codec/String"), MI.Get(StreamKind.Audio, 0, "Channel(s)"), MI.Get(StreamKind.Audio, 0, "BitRate/String"), MI.Get(StreamKind.Audio, 0, "SamplingRate"), MI.Get(StreamKind.Audio, 0, "StreamSize"), MI.Get(StreamKind.Audio, 1, "Codec/String"), MI.Get(StreamKind.Audio, 1, "Channel(s)"), MI.Get(StreamKind.Audio, 1, "BitRate/String"), MI.Get(StreamKind.Audio, 1, "SamplingRate"), MI.Get(StreamKind.Audio, 1, "StreamSize"), MI.Get(StreamKind.Video, 0, "FrameCount"), MI.Get(StreamKind.General, 0, "PlayTime"), MI.Get(StreamKind.Video, 0, "StreamSize"), MI.Get(StreamKind.General, 0, "FileSize"), "0");
            }
        }

        private void frmMultiFile_FormClosing(object sender, FormClosingEventArgs e)
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
            if (bw2.IsBusy)
            {
                if (XtraMessageBox.Show(Language.FindKey("Messages", "19").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bw2.CancelAsync();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    //btnCancel.Enabled = false;
                    //btnImport.Enabled = true;
                    //pbProgress.Visible = false;
                    //slStatus.Text = "Ýþleminiz iptal edildi...";
                }
                else
                {
                    pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnCancel.Enabled = false;
                    btnImport.Enabled = true;
                    slStatus.Caption = Language.FindKey("Messages", "18").Value;
                    frmMain.GlobalForm.Search();
                    this.Close();
                }
            }
            catch (Exception)
            {
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            bw.CancelAsync();
        }

        private void bw2_DoWork(object sender, DoWorkEventArgs e)
        {
            GetDirectorys(txtFolder.Text);
        }

        private void bw2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                }
                else
                {
                    btnImport.Enabled = true;
                    pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    slStatus.Caption = string.Format(Language.FindKey("Strings", "116").Value, lvColumns.Items.Count.ToString());
                }
            }
            catch (Exception)
            {

            }
        }

    }
}