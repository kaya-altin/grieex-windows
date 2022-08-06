using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;
using System.Reflection;
using GrieeX.GrieeXBase;
using System.IO;
using DevExpress.Utils.Win;
using System.Data.SQLite;
using System.Resources;

namespace GrieeX.UserControls
{
    public partial class MovieDetail : DevExpress.XtraEditors.XtraUserControl
    {
        public MovieDetail()
        {
            InitializeComponent();

            if (Settings.Language == "Turkish")
            {
                tabTurkish.PageVisible = true;
                TabControlPlot.SelectedTabPage = tabTurkish;
            }
        }

        public Enums.RecordType rType;
        public Movie CurrentMovie = new Movie();
        public int? ContentProvider;


        private void ucMovieDetail_Load(object sender, EventArgs e)
        {
            pbImage.Properties.SizeMode = PictureSizeMode.Squeeze;
            pbImage.Image = GrieeX.Properties.Resources.GrieeXLogo;

            EmitLanguage();


            foreach (Key item in Language.FindSection("Languages").Keys)
            {
                CheckedListBoxItem itemSubTitle = new CheckedListBoxItem();
                itemSubTitle.CheckState = CheckState.Unchecked;
                itemSubTitle.Value = item.Name;
                itemSubTitle.Description = item.Value;
                cbSubTitle.Properties.Items.Add(itemSubTitle);

                CheckedListBoxItem itemDubbing = new CheckedListBoxItem();
                itemDubbing.CheckState = CheckState.Unchecked;
                itemDubbing.Value = item.Name;
                itemDubbing.Description = item.Value;
                cbDubbing.Properties.Items.Add(itemDubbing);
            }

            //Data.EmitCombo("SELECT kRlsType AS ID, strRlsType AS STR FROM tRlsTypes;", cbRlsType, true);
            //Data.EmitCombo("SELECT kRlsGroup AS ID, strRlsGroup AS STR FROM tRlsGroups ORDER BY strRlsGroup ASC;", cbRlsGroup, true);
            //Data.EmitCombo("SELECT kMovies_Type AS ID, strMovies_Type AS STR FROM tMovies_Types;", cbMovies_Type, false, "ArchiveTypes");


            if (!string.IsNullOrEmpty(Settings.UserColumn1)) this.lblUserColumn1.Text = Settings.UserColumn1;
            if (!string.IsNullOrEmpty(Settings.UserColumn2)) this.lblUserColumn2.Text = Settings.UserColumn2;
            if (!string.IsNullOrEmpty(Settings.UserColumn3)) this.lblUserColumn3.Text = Settings.UserColumn3;
            if (!string.IsNullOrEmpty(Settings.UserColumn4)) this.lblUserColumn4.Text = Settings.UserColumn4;
            if (!string.IsNullOrEmpty(Settings.UserColumn5)) this.lblUserColumn5.Text = Settings.UserColumn5;
            if (!string.IsNullOrEmpty(Settings.UserColumn6)) this.lblUserColumn6.Text = Settings.UserColumn6;


            if (Settings.ImageLeft == true)
            {
                pbImage.Location = new System.Drawing.Point(8, 3);
                pbImage.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);
                Panel1.Location = new System.Drawing.Point(148, 0);
            }

            if (!Settings.ShowCastImage)
            {
                imageColumn.Visible = false;
            }

            LoadUserColumns();

            if (txtArchivesNumber.Text == "")
            {
                getArchiveNumber();
            }
        }

        private void LoadUserColumns()
        {
            try
            {
                cbRlsType.Properties.Items.Clear();
                cbRlsGroup.Properties.Items.Clear();

                cbUserColumn1.Properties.Items.Clear();
                cbUserColumn2.Properties.Items.Clear();
                cbUserColumn3.Properties.Items.Clear();
                cbUserColumn4.Properties.Items.Clear();
                cbUserColumn5.Properties.Items.Clear();
                cbUserColumn6.Properties.Items.Clear();

                DataRowCollection drc;

                using (SQLiteConnection con = new SQLiteConnection(GrieeXSettings.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        con.Open();
                        cmd.Connection = con;

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        drc = sh.Select("SELECT DISTINCT RlsType From Movies Where RlsType Is Not Null ORDER BY RlsType").Rows;
                        foreach (DataRow item in drc)
                        {
                            cbRlsType.Properties.Items.Add(item[0]);
                        }

                        drc = sh.Select("SELECT DISTINCT RlsGroup From Movies Where RlsGroup Is Not Null ORDER BY RlsGroup").Rows;
                        foreach (DataRow item in drc)
                        {
                            cbRlsGroup.Properties.Items.Add(item[0]);
                        }


                        drc = sh.Select("SELECT DISTINCT UserColumn1 From Movies Where UserColumn1 Is Not Null ORDER BY UserColumn1").Rows;
                        foreach (DataRow item in drc)
                        {
                            cbUserColumn1.Properties.Items.Add(item[0]);
                        }

                        drc = sh.Select("SELECT DISTINCT UserColumn2 From Movies Where UserColumn2 Is Not Null ORDER BY UserColumn2").Rows;
                        foreach (DataRow item in drc)
                        {
                            cbUserColumn2.Properties.Items.Add(item[0]);
                        }

                        drc = sh.Select("SELECT DISTINCT UserColumn3 From Movies Where UserColumn3 Is Not Null ORDER BY UserColumn3").Rows;
                        foreach (DataRow item in drc)
                        {
                            cbUserColumn3.Properties.Items.Add(item[0]);
                        }

                        drc = sh.Select("SELECT DISTINCT UserColumn4 From Movies Where UserColumn4 Is Not Null ORDER BY UserColumn4").Rows;
                        foreach (DataRow item in drc)
                        {
                            cbUserColumn4.Properties.Items.Add(item[0]);
                        }

                        drc = sh.Select("SELECT DISTINCT UserColumn5 From Movies Where UserColumn5 Is Not Null ORDER BY UserColumn5").Rows;
                        foreach (DataRow item in drc)
                        {
                            cbUserColumn5.Properties.Items.Add(item[0]);
                        }

                        drc = sh.Select("SELECT DISTINCT UserColumn6 From Movies Where UserColumn6 Is Not Null ORDER BY UserColumn6").Rows;
                        foreach (DataRow item in drc)
                        {
                            cbUserColumn6.Properties.Items.Add(item[0]);
                        }

                        con.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void getArchiveNumber()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(GrieeXSettings.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        con.Open();
                        cmd.Connection = con;

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        String strMax = sh.ExecuteScalar<String>("SELECT MAX(CAST(ArchivesNumber as INTEGER))+1 FROM Movies");
                        txtArchivesNumber.Text = strMax;

                        con.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        #region " Buttons Events "

        private void btnSave_Click(object sender, EventArgs e)
        {
            rType = Enums.RecordType.Update;
            RecordSave();
        }

        private void btnMultiAdd_Click(object sender, EventArgs e)
        {
            Forms.frmMultiFile frm = new Forms.frmMultiFile();
            frm.kMovie = CurrentMovie.MovieID;
            frm.FormType = GrieeX.Forms.frmMultiFile.ft.Single;
            frm.ShowDialog();

            dsFiles.Clear();
            tFiles_Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FileOpen();
            gvFiles.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 RowIndex = gvFiles.FocusedRowHandle;
            if (gvFiles.RowCount != 0) gvFiles.DeleteRow(RowIndex);
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            if (gvFiles.RowCount > 0)
            {
                if (!string.IsNullOrEmpty(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_FileName).ToString()))
                {
                    string strFile = gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_FileName).ToString();
                    Util.PlayVideo(strFile);
                }
            }
        }

        private void btnImdb_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtImdbNumber.Text))
            {
                System.Diagnostics.Process.Start("http://www.imdb.com/title/" + this.txtImdbNumber.Text + "/");
            }
            else
            {
                XtraMessageBox.Show(Language.FindKey("Messages", "9").Value);
            }
        }


        #endregion

        #region " Menu Events "

        private void mnuAdd_Click(System.Object sender, System.EventArgs e)
        {
            Forms.frmChangeCast frm = new Forms.frmChangeCast();
            frm.ShowDialog();


            if (frm.bOk == true)
            {
                if (gvCast.DataSource == null)
                {
                    DataTable dtSource = new DataTable();
                    dtSource.Columns.Add("cl1");
                    dtSource.Columns.Add("cl2");
                    dgCast.DataSource = dtSource;
                }

                DataTable dt = ((System.Data.DataView)(gvCast.DataSource)).Table;
                DataRow row = dt.NewRow();

                row["cl1"] = frm.txtS1.Text;
                row["cl2"] = frm.txtS2.Text;

                dt.Rows.Add(row);
            }

        }

        private void mnuEdit_Click(object sender, System.EventArgs e)
        {
            if (gvCast.SelectedRowsCount != 0)
            {
                Forms.frmChangeCast frm = new Forms.frmChangeCast();
                frm.txtS1.Text = gvCast.GetRowCellValue(gvCast.GetSelectedRows()[0], cl1).ToString();
                if (!string.IsNullOrEmpty(gvCast.GetRowCellValue(gvCast.GetSelectedRows()[0], cl2).ToString()))
                {
                    frm.txtS2.Text = gvCast.GetRowCellValue(gvCast.GetSelectedRows()[0], cl2).ToString();
                }
                frm.ShowDialog();
                if (frm.bOk == true)
                {
                    gvCast.SetRowCellValue(gvCast.GetSelectedRows()[0], cl1, frm.txtS1.Text);
                    gvCast.SetRowCellValue(gvCast.GetSelectedRows()[0], cl2, frm.txtS2.Text);
                }
            }
        }

        //private string GetCast()
        //{
        //    DataView dv = gvCast.DataSource as DataView;
        //    if (gvCast.DataSource == null)
        //        return string.Empty;

        //    StringBuilder sb = new StringBuilder();

        //    foreach (DataRowView item in dv)
        //    {
        //        sb.Append(item["cl1"].ToString());
        //        sb.Append(";");
        //        sb.Append(item["cl2"].ToString());
        //        sb.Append("@");
        //    }


        //    if (sb.ToString().Length > 0)
        //        return sb.ToString().Remove(sb.ToString().Length - 1, 1);
        //    else
        //        return sb.ToString();
        //}

        private void mnuDelete_Click(System.Object sender, System.EventArgs e)
        {
            if (gvCast.SelectedRowsCount > 0)
            {
                gvCast.DeleteSelectedRows();
            }
        }

        private void mnuGoToImdbPage_Click(object sender, System.EventArgs e)
        {
            if (gvCast.SelectedRowsCount != 0)
            {
                Process.Start("http://www.imdb.com/find?tt=on;nm=on;mx=20;q=" + gvCast.GetRowCellValue(gvCast.GetSelectedRows()[0], cl1).ToString());
            }
        }

        private void mnuSelectImage_Click(System.Object sender, System.EventArgs e)
        {
            OpenFileDialog FO = new OpenFileDialog();
            FO.Filter = "Picture Files (*.jpg)|*.jpg";

            if (FO.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.Copy(FO.FileName, GrieeXSettings.PosterPath + txtImdbNumber.Text + ".jpg", true);
                pbImage.LoadAsync(GrieeXSettings.PosterPath + txtImdbNumber.Text + @".jpg");
            }
        }

        private void mnuDeleteImage_Click(System.Object sender, System.EventArgs e)
        {
            if (File.Exists(GrieeXSettings.PosterPath + CurrentMovie.ImdbNumber + @".jpg"))
            {
                if (XtraMessageBox.Show(Language.FindKey("Messages", "4").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.IO.File.Delete(GrieeXSettings.PosterPath + CurrentMovie.ImdbNumber + @".jpg");
                    pbImage.Properties.SizeMode = PictureSizeMode.Squeeze;
                    pbImage.Image = GrieeX.Properties.Resources.GrieeXLogo;
                }
            }
        }

        #endregion

        #region " Form Events "

        public void RecordShow(string MovieID)
        {
            // Clear();
            dsFiles.Clear();


            CurrentMovie.Get(MovieID);
            ContentProvider = CurrentMovie.ContentProvider;

            txtOrginalName.Text = CurrentMovie.OrginalName;
            txtOtherName.Text = CurrentMovie.OtherName;
            txtDirector.Text = CurrentMovie.Director;
            txtWriter.Text = CurrentMovie.Writer;
            txtGenre.Text = CurrentMovie.Genre;
            txtYear.Text = CurrentMovie.Year;
            txtUserRating.Text = CurrentMovie.UserRating;
            txtVotes.Text = Util.convertToString(CurrentMovie.Votes);
            txtRuntime.Text = CurrentMovie.RunningTime;
            txtCountry.Text = CurrentMovie.Country;
            txtLanguage.Text = CurrentMovie.Language;
            txtOtherPlot.Text = CurrentMovie.OtherPlot;
            txtEnglishPlot.Text = CurrentMovie.EnglishPlot;
            txtProductionCompany.Text = CurrentMovie.ProductionCompany;
            txtBudget.Text = CurrentMovie.Budget;
            txtImdbNumber.Text = CurrentMovie.ImdbNumber;
            txtTmdbNumber.Text = CurrentMovie.TmdbNumber;
            txtReleaseDate.Text = CurrentMovie.ReleaseDate;
            txtArchivesNumber.Text = CurrentMovie.ArchivesNumber;
            txtPersonalRating.Text = Util.convertToString(CurrentMovie.PersonalRating);
            cbSubTitle.SetEditValue(CurrentMovie.Subtitle);
            cbDubbing.SetEditValue(CurrentMovie.Dubbing);
            cbUserColumn1.Text = CurrentMovie.UserColumn1;
            cbUserColumn2.Text = CurrentMovie.UserColumn2;
            cbUserColumn3.Text = CurrentMovie.UserColumn3;
            cbUserColumn4.Text = CurrentMovie.UserColumn4;
            cbUserColumn5.Text = CurrentMovie.UserColumn5;
            cbUserColumn6.Text = CurrentMovie.UserColumn6;
            cbRlsType.Text = CurrentMovie.RlsType;
            cbRlsGroup.Text = CurrentMovie.RlsGroup;
            txtNote.Text = CurrentMovie.Note;
            txtPoster.Text = CurrentMovie.Poster;

            if (CurrentMovie.InsertDate.HasValue)
                lblDateEntered.Text = CurrentMovie.InsertDate.Value.ToString();
            else lblDateEntered.Text = "";

            if (CurrentMovie.UpdateDate.HasValue)
                lblChangeDate.Text = CurrentMovie.UpdateDate.Value.ToString();
            else lblChangeDate.Text = "";



            if (File.Exists(GrieeXSettings.PosterPath + CurrentMovie.ImdbNumber + @".jpg"))
            {
                pbImage.StartAnimation();
                pbImage.LoadAsync(GrieeXSettings.PosterPath + CurrentMovie.ImdbNumber + @".jpg");
            }
            else
            {
                pbImage.Properties.SizeMode = PictureSizeMode.Squeeze;
                pbImage.Image = GrieeX.Properties.Resources.GrieeXLogo;
            }

            if (CurrentMovie.Seen == true)
            {
                rgMovieSeen.SelectedIndex = 0;
            }
            else
            {
                rgMovieSeen.SelectedIndex = 1;
            }

            dgCast.DataSource = CurrentMovie.Casts;


            tFiles_Show();

            rType = Enums.RecordType.Update;

        }

        public void Clear()
        {
            Util.ClearControls(this);

            if (CurrentMovie.Casts != null)
                CurrentMovie.Casts.Clear();

            dgCast.DataSource = null;

            dsFiles.Clear();

            pbImage.Properties.SizeMode = PictureSizeMode.Squeeze;
            pbImage.Image = GrieeX.Properties.Resources.GrieeXLogo;
        }




        private void tFiles_Show()
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    DataRow[] drs = sh.Select("SELECT * FROM Files WHERE Files.MovieID=" + CurrentMovie.MovieID).Select("");

                    foreach (DataRow dr in drs)
                    {
                        dsFiles.Files.ImportRow(dr);
                    }

                    gvFiles.SelectRow(0);

                    conn.Close();
                }
            }

        }


        public void FileOpen()
        {
            OpenFileDialog FO = new OpenFileDialog();
            DialogResult Svar;
            MediaInfo MI = new MediaInfo();

            FO.Filter = "Video Files|*.avi;*.mkv;*.ts;*.ogm;*.ogg;*.divx;*.wmv;*.mov;*.mpg;*.mpeg;*.mp4;*.dat;*.vob;*.asf;*.rm;*.ra;*.rmvb;*.flv";
            FO.Filter += "|Kalýp Dosyalarý|*.nrg;*.iso";



            Svar = FO.ShowDialog();
            if (!(Svar == DialogResult.OK))
                return;

            if (Path.GetExtension(FO.FileName) == ".nrg" | Path.GetExtension(FO.FileName) == ".iso")
            {
                dsFiles.Files.AddFilesRow("", FO.FileName, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "0");
                return;
            }


            MI.Open(FO.FileName);

            if (txtOrginalName.Text == "")
                txtOrginalName.Text = MI.Get(StreamKind.General, 0, "FileName");
            //MI.Get(StreamKind.General, 0, "FileName") & "." & MI.Get(StreamKind.General, 0, "FileExtension"), _ 
            if (Convert.ToInt32(MI.Get(StreamKind.Audio, 0, "StreamCount")) == 1)
            {
                dsFiles.Files.AddFilesRow(
                    "",
                    FO.FileName,
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
                dsFiles.Files.AddFilesRow("", FO.FileName, MI.Get(StreamKind.Video, 0, "Width") + " x " + MI.Get(StreamKind.Video, 0, "Height"), MI.Get(StreamKind.Video, 0, "Codec/String"), MI.Get(StreamKind.Video, 0, "BitRate/String"), MI.Get(StreamKind.Video, 0, "FrameRate"), MI.Get(StreamKind.Video, 0, "DisplayAspectRatio/String"), MI.Get(StreamKind.Audio, 0, "Codec/String"), MI.Get(StreamKind.Audio, 0, "Channel(s)"), MI.Get(StreamKind.Audio, 0, "BitRate/String"), MI.Get(StreamKind.Audio, 0, "SamplingRate"), MI.Get(StreamKind.Audio, 0, "StreamSize"), MI.Get(StreamKind.Audio, 1, "Codec/String"), MI.Get(StreamKind.Audio, 1, "Channel(s)"), MI.Get(StreamKind.Audio, 1, "BitRate/String"), MI.Get(StreamKind.Audio, 1, "SamplingRate"), MI.Get(StreamKind.Audio, 1, "StreamSize"), MI.Get(StreamKind.Video, 0, "FrameCount"), MI.Get(StreamKind.General, 0, "PlayTime"), MI.Get(StreamKind.Video, 0, "StreamSize"), MI.Get(StreamKind.General, 0, "FileSize"), "0");
            }


        }

        private void AddRow(DevExpress.XtraGrid.Views.Grid.GridView View)
        {
            int currentRow;
            currentRow = View.FocusedRowHandle;
            if (currentRow < 0)
            {
                currentRow = View.GetDataRowHandleByGroupRowHandle(currentRow);
            }
            View.AddNewRow();

            View.SetRowCellValue(View.FocusedRowHandle, "_id", CurrentMovie.MovieID);
            View.SetRowCellValue(View.FocusedRowHandle, "Seen", CurrentMovie.Seen);
            View.SetRowCellValue(View.FocusedRowHandle, "OrginalName", CurrentMovie.OrginalName);
            View.SetRowCellValue(View.FocusedRowHandle, "OtherName", CurrentMovie.OtherName);
            View.SetRowCellValue(View.FocusedRowHandle, "Director", CurrentMovie.Director);
            View.SetRowCellValue(View.FocusedRowHandle, "Writer", CurrentMovie.Writer);
            View.SetRowCellValue(View.FocusedRowHandle, "Year", CurrentMovie.Year);
            View.SetRowCellValue(View.FocusedRowHandle, "RunningTime", CurrentMovie.RunningTime);
            View.SetRowCellValue(View.FocusedRowHandle, "UserRating", CurrentMovie.UserRating);
            View.SetRowCellValue(View.FocusedRowHandle, "Votes", CurrentMovie.Votes);
            View.SetRowCellValue(View.FocusedRowHandle, "Country", CurrentMovie.Country);
            View.SetRowCellValue(View.FocusedRowHandle, "Budget", CurrentMovie.Budget);
            View.SetRowCellValue(View.FocusedRowHandle, "ProductionCompany", CurrentMovie.ProductionCompany);
            View.SetRowCellValue(View.FocusedRowHandle, "Language", CurrentMovie.Language);
            View.SetRowCellValue(View.FocusedRowHandle, "Genre", CurrentMovie.Genre);
            View.SetRowCellValue(View.FocusedRowHandle, "ArchivesNumber", CurrentMovie.ArchivesNumber);
            View.SetRowCellValue(View.FocusedRowHandle, "Subtitle", CurrentMovie.Subtitle);
            View.SetRowCellValue(View.FocusedRowHandle, "Dubbing", CurrentMovie.Dubbing);
            View.SetRowCellValue(View.FocusedRowHandle, "ImdbNumber", CurrentMovie.ImdbNumber);
            View.SetRowCellValue(View.FocusedRowHandle, "PersonalRating", CurrentMovie.PersonalRating);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn1", CurrentMovie.UserColumn1);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn2", CurrentMovie.UserColumn2);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn3", CurrentMovie.UserColumn3);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn4", CurrentMovie.UserColumn4);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn5", CurrentMovie.UserColumn5);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn6", CurrentMovie.UserColumn6);
            View.SetRowCellValue(View.FocusedRowHandle, "RlsType", CurrentMovie.RlsType);
            View.SetRowCellValue(View.FocusedRowHandle, "RlsGroup", CurrentMovie.RlsGroup);
            View.SetRowCellValue(View.FocusedRowHandle, "InsertDate", CurrentMovie.InsertDate);



            View.UpdateCurrentRow();
            View.MakeRowVisible(View.FocusedRowHandle, true);
            View.SelectRow(View.FocusedRowHandle);


            if (View.GroupedColumns.Count == 0)
                return;

            // Initialize group values
            foreach (DevExpress.XtraGrid.Columns.GridColumn groupColumn in View.GroupedColumns)
            {
                object value = View.GetRowCellValue(currentRow, groupColumn);
                View.SetRowCellValue(View.FocusedRowHandle, groupColumn, value);
            }
            View.UpdateCurrentRow();
            View.MakeRowVisible(View.FocusedRowHandle, true);
            View.ShowEditor();
        }

        private void UpdateRow(DevExpress.XtraGrid.Views.Grid.GridView View)
        {
            int currentRow;
            currentRow = View.FocusedRowHandle;
            if (currentRow < 0)
            {
                currentRow = View.GetDataRowHandleByGroupRowHandle(currentRow);
            }

            View.SetRowCellValue(View.FocusedRowHandle, "_id", CurrentMovie.MovieID);
            View.SetRowCellValue(View.FocusedRowHandle, "Seen", CurrentMovie.Seen);
            View.SetRowCellValue(View.FocusedRowHandle, "OrginalName", CurrentMovie.OrginalName);
            View.SetRowCellValue(View.FocusedRowHandle, "OtherName", CurrentMovie.OtherName);
            View.SetRowCellValue(View.FocusedRowHandle, "Director", CurrentMovie.Director);
            View.SetRowCellValue(View.FocusedRowHandle, "Writer", CurrentMovie.Writer);
            View.SetRowCellValue(View.FocusedRowHandle, "Year", CurrentMovie.Year);
            View.SetRowCellValue(View.FocusedRowHandle, "RunningTime", CurrentMovie.RunningTime);
            View.SetRowCellValue(View.FocusedRowHandle, "UserRating", CurrentMovie.UserRating);
            View.SetRowCellValue(View.FocusedRowHandle, "Votes", CurrentMovie.Votes);
            View.SetRowCellValue(View.FocusedRowHandle, "Country", CurrentMovie.Country);
            View.SetRowCellValue(View.FocusedRowHandle, "Budget", CurrentMovie.Budget);
            View.SetRowCellValue(View.FocusedRowHandle, "ProductionCompany", CurrentMovie.ProductionCompany);
            View.SetRowCellValue(View.FocusedRowHandle, "Language", CurrentMovie.Language);
            View.SetRowCellValue(View.FocusedRowHandle, "Genre", CurrentMovie.Genre);
            View.SetRowCellValue(View.FocusedRowHandle, "ArchivesNumber", CurrentMovie.ArchivesNumber);
            View.SetRowCellValue(View.FocusedRowHandle, "Subtitle", CurrentMovie.Subtitle);
            View.SetRowCellValue(View.FocusedRowHandle, "Dubbing", CurrentMovie.Dubbing);
            View.SetRowCellValue(View.FocusedRowHandle, "ImdbNumber", CurrentMovie.ImdbNumber);
            View.SetRowCellValue(View.FocusedRowHandle, "PersonalRating", CurrentMovie.PersonalRating);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn1", CurrentMovie.UserColumn1);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn2", CurrentMovie.UserColumn2);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn3", CurrentMovie.UserColumn3);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn4", CurrentMovie.UserColumn4);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn5", CurrentMovie.UserColumn5);
            View.SetRowCellValue(View.FocusedRowHandle, "UserColumn6", CurrentMovie.UserColumn6);
            View.SetRowCellValue(View.FocusedRowHandle, "RlsType", CurrentMovie.RlsType);
            View.SetRowCellValue(View.FocusedRowHandle, "RlsGroup", CurrentMovie.RlsGroup);
            View.SetRowCellValue(View.FocusedRowHandle, "InsertDate", CurrentMovie.InsertDate);

            View.UpdateCurrentRow();
            View.MakeRowVisible(View.FocusedRowHandle, true);

            if (View.GroupedColumns.Count == 0)
                return;

            // Initialize group values
            foreach (DevExpress.XtraGrid.Columns.GridColumn groupColumn in View.GroupedColumns)
            {
                object value = View.GetRowCellValue(currentRow, groupColumn);
                View.SetRowCellValue(View.FocusedRowHandle, groupColumn, value);
            }
            View.UpdateCurrentRow();
            View.MakeRowVisible(View.FocusedRowHandle, true);
            View.ShowEditor();
        }

        public void RecordSave()
        {
            switch (rType)
            {
                case Enums.RecordType.Insert:
                    if (DuplicateRecord() == true)
                    {
                        if (XtraMessageBox.Show(Language.FindKey("Messages", "22").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    CurrentMovie = new Movie();
                    CurrentMovie.OrginalName = txtOrginalName.Text;
                    CurrentMovie.OtherName = txtOtherName.Text;
                    CurrentMovie.Director = txtDirector.Text;
                    CurrentMovie.Writer = txtWriter.Text;
                    CurrentMovie.Genre = txtGenre.Text;
                    CurrentMovie.Year = txtYear.Text;
                    CurrentMovie.UserRating = txtUserRating.Text;
                    CurrentMovie.Votes = Util.RemoveSpecialChars(txtVotes.Text);
                    CurrentMovie.ImdbUserRating = txtImdbUserRating.Text;
                    CurrentMovie.ImdbVotes = txtImdbVotes.Text;
                    CurrentMovie.TmdbUserRating = txtTmdbUserRating.Text;
                    CurrentMovie.TmdbVotes = txtTmdbVotes.Text;
                    CurrentMovie.RunningTime = txtRuntime.Text;
                    CurrentMovie.Country = txtCountry.Text;
                    CurrentMovie.Language = txtLanguage.Text;
                    CurrentMovie.OtherPlot = txtOtherPlot.Text;
                    CurrentMovie.Budget = txtBudget.Text;
                    CurrentMovie.ProductionCompany = txtProductionCompany.Text;
                    CurrentMovie.EnglishPlot = txtEnglishPlot.Text;
                    CurrentMovie.ImdbNumber = txtImdbNumber.Text;
                    CurrentMovie.TmdbNumber = txtTmdbNumber.Text;
                    CurrentMovie.ReleaseDate = txtReleaseDate.Text;
                    CurrentMovie.ArchivesNumber = txtArchivesNumber.Text.Replace(",", "-");
                    CurrentMovie.PersonalRating = txtPersonalRating.Text;
                    CurrentMovie.Subtitle = cbSubTitle.EditValue.ToString();
                    CurrentMovie.Dubbing = cbDubbing.EditValue.ToString();
                    CurrentMovie.UserColumn1 = cbUserColumn1.Text;
                    CurrentMovie.UserColumn2 = cbUserColumn2.Text;
                    CurrentMovie.UserColumn3 = cbUserColumn3.Text;
                    CurrentMovie.UserColumn4 = cbUserColumn4.Text;
                    CurrentMovie.UserColumn5 = cbUserColumn5.Text;
                    CurrentMovie.UserColumn6 = cbUserColumn6.Text;
                    CurrentMovie.RlsType = cbRlsType.Text;
                    CurrentMovie.RlsGroup = cbRlsGroup.Text;
                    CurrentMovie.Note = txtNote.Text;
                    CurrentMovie.Seen = rgMovieSeen.SelectedIndex == 0 ? true : false;
                    CurrentMovie.Poster = txtPoster.Text;
                    CurrentMovie.ContentProvider = ContentProvider;
                    CurrentMovie.InsertDate = DateTime.Now;

                    if (dgCast.DataSource != null)
                        CurrentMovie.Casts = (List<Casts>)dgCast.DataSource;

                    CurrentMovie.Save();


                    //foreach (Casts cast in CurrentMovie.Casts)
                    //{
                    //    cast.ObjectID = CurrentMovie.MovieID;
                    //    cast.Save();
                    //}
                    if (CurrentMovie.Casts != null)
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                        {
                            using (SQLiteCommand cmd = new SQLiteCommand())
                            {
                                cmd.Connection = conn;
                                conn.Open();

                                SQLiteHelper sh = new SQLiteHelper(cmd);

                                sh.BeginTransaction();
                                try
                                {
                                    foreach (Casts cast in CurrentMovie.Casts)
                                    {
                                        var dic = new Dictionary<string, object>();
                                        dic["Name"] = cast.Name;
                                        dic["Character"] = cast.Character;
                                        dic["Url"] = cast.Url;
                                        dic["ImageUrl"] = cast.ImageUrl;
                                        dic["CastID"] = cast.CastID;
                                        dic["ObjectID"] = CurrentMovie.MovieID;
                                        dic["CollectionType"] = cast.CollectionType;
                                        sh.Insert("Casts", dic);
                                    }
                                    sh.Commit();
                                }
                                catch (Exception)
                                {
                                    sh.Rollback();
                                }


                                conn.Close();
                            }
                        }
                    }

                    AddRow(GrieeX.Forms.frmMain.GlobalForm.gvList);

                    break;
                case Enums.RecordType.Update:

                    CurrentMovie.OrginalName = txtOrginalName.Text;
                    CurrentMovie.OtherName = txtOtherName.Text;
                    CurrentMovie.Director = txtDirector.Text;
                    CurrentMovie.Writer = txtWriter.Text;
                    CurrentMovie.Genre = txtGenre.Text;
                    CurrentMovie.Year = txtYear.Text;
                    CurrentMovie.UserRating = txtUserRating.Text;
                    CurrentMovie.Votes = Util.RemoveSpecialChars(txtVotes.Text);
                    CurrentMovie.ImdbUserRating = txtImdbUserRating.Text;
                    CurrentMovie.ImdbVotes = txtImdbVotes.Text;
                    CurrentMovie.TmdbUserRating = txtTmdbUserRating.Text;
                    CurrentMovie.TmdbVotes = txtTmdbVotes.Text;
                    CurrentMovie.RunningTime = txtRuntime.Text;
                    CurrentMovie.Country = txtCountry.Text;
                    CurrentMovie.Language = txtLanguage.Text;
                    CurrentMovie.OtherPlot = txtOtherPlot.Text;
                    CurrentMovie.EnglishPlot = txtEnglishPlot.Text;
                    CurrentMovie.Budget = txtBudget.Text;
                    CurrentMovie.ProductionCompany = txtProductionCompany.Text;
                    CurrentMovie.ImdbNumber = txtImdbNumber.Text;
                    CurrentMovie.TmdbNumber = txtTmdbNumber.Text;
                    CurrentMovie.ReleaseDate = txtReleaseDate.Text;
                    CurrentMovie.ArchivesNumber = txtArchivesNumber.Text.Replace(",", "-");
                    CurrentMovie.PersonalRating = txtPersonalRating.Text;
                    CurrentMovie.Subtitle = cbSubTitle.EditValue.ToString();
                    CurrentMovie.Dubbing = cbDubbing.EditValue.ToString();
                    CurrentMovie.UserColumn1 = cbUserColumn1.Text;
                    CurrentMovie.UserColumn2 = cbUserColumn2.Text;
                    CurrentMovie.UserColumn3 = cbUserColumn3.Text;
                    CurrentMovie.UserColumn4 = cbUserColumn4.Text;
                    CurrentMovie.UserColumn5 = cbUserColumn5.Text;
                    CurrentMovie.UserColumn6 = cbUserColumn6.Text;
                    CurrentMovie.RlsType = cbRlsType.Text;
                    CurrentMovie.RlsGroup = cbRlsGroup.Text;
                    CurrentMovie.Note = txtNote.Text;
                    CurrentMovie.Seen = rgMovieSeen.SelectedIndex == 0 ? true : false;
                    CurrentMovie.Poster = txtPoster.Text;
                    CurrentMovie.ContentProvider = ContentProvider;

                    CurrentMovie.Save();

                    if (CurrentMovie.Casts != null)
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                        {
                            using (SQLiteCommand cmd = new SQLiteCommand())
                            {
                                cmd.Connection = conn;
                                conn.Open();

                                SQLiteHelper sh = new SQLiteHelper(cmd);
                                sh.Execute("Delete FROM Casts WHERE CollectionType=1 and ObjectID=" + CurrentMovie.MovieID);


                                sh.BeginTransaction();
                                try
                                {
                                    foreach (Casts cast in CurrentMovie.Casts)
                                    {
                                        var dic = new Dictionary<string, object>();
                                        dic["Name"] = cast.Name;
                                        dic["Character"] = cast.Character;
                                        dic["Url"] = cast.Url;
                                        dic["ImageUrl"] = cast.ImageUrl;
                                        dic["CastID"] = cast.CastID;
                                        dic["ObjectID"] = CurrentMovie.MovieID;
                                        dic["CollectionType"] = cast.CollectionType;
                                        sh.Insert("Casts", dic);
                                    }
                                    sh.Commit();
                                }
                                catch (Exception)
                                {
                                    sh.Rollback();
                                }


                                conn.Close();
                            }
                        }
                    }

                    UpdateRow(GrieeX.Forms.frmMain.GlobalForm.gvList);

                    break;
            }



            tFiles_Save();

            LoadUserColumns();
            GrieeX.Forms.frmMain.GlobalForm.MovieDetail.RecordShow(CurrentMovie.MovieID.ToString());
            GrieeX.Forms.frmMain.GlobalForm.MovieDetail.LoadUserColumns();
            GrieeX.Forms.frmMovie.GlobalForm.MovieDetail.LoadUserColumns();
        }


        public void tFiles_Save()
        {
            for (int i = 0; i <= dsFiles.Tables[0].Rows.Count - 1; i++)
            {
                switch (dsFiles.Tables[0].Rows[i].RowState)
                {
                    case DataRowState.Added:
                        Files t = new Files();
                        t.MovieID = CurrentMovie.MovieID;
                        t.FileName = dsFiles.Tables[0].Rows[i]["FileName"].ToString();
                        t.Resolution = dsFiles.Tables[0].Rows[i]["Resolution"].ToString();
                        t.VideoCodec = dsFiles.Tables[0].Rows[i]["VideoCodec"].ToString();
                        t.VideoBitrate = dsFiles.Tables[0].Rows[i]["VideoBitrate"].ToString();
                        t.Fps = dsFiles.Tables[0].Rows[i]["Fps"].ToString();
                        t.VideoAspectRatio = dsFiles.Tables[0].Rows[i]["VideoAspectRatio"].ToString();
                        t.AudioCodec1 = dsFiles.Tables[0].Rows[i]["AudioCodec1"].ToString();
                        t.AudioChannels1 = dsFiles.Tables[0].Rows[i]["AudioChannels1"].ToString();
                        t.AudioBitrate1 = dsFiles.Tables[0].Rows[i]["AudioBitrate1"].ToString();
                        t.AudioSampleRate1 = dsFiles.Tables[0].Rows[i]["AudioSampleRate1"].ToString();
                        t.AudioSize1 = dsFiles.Tables[0].Rows[i]["AudioSize1"].ToString();
                        t.AudioCodec2 = dsFiles.Tables[0].Rows[i]["AudioCodec2"].ToString();
                        t.AudioChannels2 = dsFiles.Tables[0].Rows[i]["AudioChannels2"].ToString();
                        t.AudioBitrate2 = dsFiles.Tables[0].Rows[i]["AudioBitrate2"].ToString();
                        t.AudioSampleRate2 = dsFiles.Tables[0].Rows[i]["AudioSampleRate2"].ToString();
                        t.AudioSize2 = dsFiles.Tables[0].Rows[i]["AudioSize2"].ToString();
                        t.TotalFrames = dsFiles.Tables[0].Rows[i]["TotalFrames"].ToString();
                        t.Lenght = dsFiles.Tables[0].Rows[i]["Lenght"].ToString();
                        t.VideoSize = dsFiles.Tables[0].Rows[i]["VideoSize"].ToString();
                        t.FileSize = dsFiles.Tables[0].Rows[i]["FileSize"].ToString();
                        t.Chapter = dsFiles.Tables[0].Rows[i]["Chapter"].ToString();

                        t.Save();
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


        }


        private void pbImage_Click(object sender, EventArgs e)
        {
            if (File.Exists(GrieeXSettings.PosterPath + CurrentMovie.ImdbNumber + @".jpg"))
            {
                Forms.frmImage frm = new Forms.frmImage();
                frm.ImageShow(GrieeXSettings.PosterPath + CurrentMovie.ImdbNumber + @".jpg");
                frm.Text = txtOrginalName.Text;
                frm.slResolution.Caption = Language.FindKey("Strings", "21").Value + ": " + pbImage.Image.Width + " x " + pbImage.Image.Height;
                frm.Show();
            }
        }

        private void gvCast_DoubleClick(object sender, EventArgs e)
        {
            //if (gvCast.SelectedRowsCount != 0)
            //{
            //    Process.Start(gvCast.GetRowCellValue(gvCast.GetSelectedRows()[0], cl3).ToString());
            //}

            if (gvCast.SelectedRowsCount != 0)
            {
                Casts c = CurrentMovie.Casts[gvCast.FocusedRowHandle];
                if (!String.IsNullOrEmpty(c.Url))
                    Process.Start(c.Url);
            }
        }

        public bool DuplicateRecord()
        {
            if (String.IsNullOrEmpty(txtImdbNumber.Text))
            {
                return false;
            }

            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    DataTable dt = sh.Select("SELECT * FROM Movies WHERE ImdbNumber='" + txtImdbNumber.Text + "'");

                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                    conn.Close();
                }
            }

        }

        private void txtPersonalRating_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //if (!Utilities.IsNumeric(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            base.OnKeyPress(e);
        }


        public void LogTextEvent(RichTextBox TextEventLog, Color TextColor, string EventText)
        {
            TextEventLog.SelectionStart = TextEventLog.Text.Length;
            TextEventLog.SelectionColor = TextColor;
            // newline if first line, append if else.        
            if (TextEventLog.Lines.Length == 0)
            {
                TextEventLog.AppendText(EventText);
                TextEventLog.ScrollToCaret();
                TextEventLog.AppendText(System.Environment.NewLine);
            }
            else
            {
                TextEventLog.AppendText(EventText + System.Environment.NewLine);
                TextEventLog.ScrollToCaret();
            }
        }

        private void gvFiles_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            richTextBox1.Text = "";
            if (gvFiles.RowCount > 0 && gvFiles.SelectedRowsCount > 0)
            {
                LogTextEvent(richTextBox1, Color.Red, " -------  " + Language.FindKey("Strings", "18").Value + " -------");
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "21").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_Resolution).ToString());
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "19").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_VideoCodec).ToString());
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "20").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_VideoBitrate).ToString());
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "22").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_Fps).ToString());
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "129").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_VideoAspectRatio).ToString());
                if (!string.IsNullOrEmpty(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_Lenght).ToString()))
                {
                    LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "8").Value + ": " + Util.FormatTime(Convert.ToDouble(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_Lenght).ToString())));
                }
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "32").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_TotalFrames).ToString());

                if (Util.ValidCommand(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_VideoSize).ToString()) == true)
                {
                    LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "23").Value + ": " + String.Format("{0:n}", Convert.ToDouble(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_VideoSize).ToString()) / Convert.ToInt32(Enums.ByteTypes.MegaByte)) + " MB");
                }
                if (Util.ValidCommand(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_FileSize).ToString()) == true)
                {
                    LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "33").Value + ": " + String.Format("{0:n}", Convert.ToDouble(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_FileSize).ToString()) / Convert.ToInt32(Enums.ByteTypes.MegaByte)) + " MB");
                }

                richTextBox1.AppendText(System.Environment.NewLine);

                LogTextEvent(richTextBox1, Color.Red, " ------- " + Language.FindKey("Strings", "24").Value + " -------");
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "25").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioCodec1).ToString());
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "27").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioChannels1).ToString());
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "26").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioBitrate1).ToString());
                LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "28").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioSampleRate1).ToString());

                if (Util.ValidCommand(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioSize1).ToString()) == true)
                {
                    LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "29").Value + ": " + String.Format("{0:n}", Convert.ToDouble(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioSize1).ToString()) / Convert.ToInt32(Enums.ByteTypes.MegaByte)) + " MB");
                }

                if (!string.IsNullOrEmpty(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioCodec2).ToString()))
                {
                    richTextBox1.AppendText(System.Environment.NewLine);

                    LogTextEvent(richTextBox1, Color.Red, "------- " + Language.FindKey("Strings", "24").Value + " -------");
                    LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "25").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioCodec2).ToString());
                    LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "27").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioChannels2).ToString());
                    LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "26").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioBitrate2).ToString());
                    LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "28").Value + ": " + gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioSampleRate2).ToString());

                    if (Util.ValidCommand(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioSize2).ToString()) == true)
                    {
                        LogTextEvent(richTextBox1, Color.Black, " " + Language.FindKey("Strings", "29").Value + ": " + String.Format("{0:n}", Convert.ToDouble(gvFiles.GetRowCellValue(gvFiles.GetSelectedRows()[0], cl_AudioSize2).ToString()) / Convert.ToInt32(Enums.ByteTypes.MegaByte)) + " MB");
                    }
                }
            }
        }


        #endregion

        private void ucMovieDetail_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true & rType == Enums.RecordType.Insert)
            {
                if (!string.IsNullOrEmpty(Settings.DefaultDubbing)) cbDubbing.SetEditValue(Settings.DefaultDubbing);
                if (!string.IsNullOrEmpty(Settings.DefaultSubtitle)) cbSubTitle.SetEditValue(Settings.DefaultSubtitle);
            }

        }


        private void cbSubTitle_Popup(object sender, EventArgs e)
        {
            foreach (Control c in ((IPopupControl)sender).PopupWindow.Controls)
            {
                if (c.GetType().FullName == "DevExpress.XtraEditors.SimpleButton")
                {
                    switch (c.Text)
                    {
                        case "OK":
                            c.Text = Language.FindKey("Buttons", "10").Value;
                            break;
                        case "Cancel":
                            c.Text = Language.FindKey("Buttons", "11").Value;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void cbDubbing_Popup(object sender, EventArgs e)
        {
            foreach (Control c in ((IPopupControl)sender).PopupWindow.Controls)
            {
                if (c.GetType().FullName == "DevExpress.XtraEditors.SimpleButton")
                {
                    switch (c.Text)
                    {
                        case "OK":
                            c.Text = Language.FindKey("Buttons", "10").Value;
                            break;
                        case "Cancel":
                            c.Text = Language.FindKey("Buttons", "11").Value;
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        private void gvCast_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                int iOldIndex = gvCast.GetSelectedRows()[0];
                if (iOldIndex == 0)
                    return;
                int iNewIndex = iOldIndex - 1;

                string strOld1 = gvCast.GetRowCellValue(iOldIndex, cl1).ToString();
                string strOld2 = gvCast.GetRowCellValue(iOldIndex, cl2).ToString();
                string strNew1 = gvCast.GetRowCellValue(iNewIndex, cl1).ToString();
                string strNew2 = gvCast.GetRowCellValue(iNewIndex, cl2).ToString();

                gvCast.SetRowCellValue(iOldIndex, cl1, strNew1);
                gvCast.SetRowCellValue(iOldIndex, cl2, strNew2);
                gvCast.SetRowCellValue(iNewIndex, cl1, strOld1);
                gvCast.SetRowCellValue(iNewIndex, cl2, strOld2);
            }
            else if (e.KeyCode == Keys.Down)
            {
                int iOldIndex = gvCast.GetSelectedRows()[0];
                if (iOldIndex == gvCast.RowCount)
                    return;
                int iNewIndex = iOldIndex + 1;

                string strOld1 = gvCast.GetRowCellValue(iOldIndex, cl1).ToString();
                string strOld2 = gvCast.GetRowCellValue(iOldIndex, cl2).ToString();
                string strNew1 = gvCast.GetRowCellValue(iNewIndex, cl1).ToString();
                string strNew2 = gvCast.GetRowCellValue(iNewIndex, cl2).ToString();

                gvCast.SetRowCellValue(iOldIndex, cl1, strNew1);
                gvCast.SetRowCellValue(iOldIndex, cl2, strNew2);
                gvCast.SetRowCellValue(iNewIndex, cl1, strOld1);
                gvCast.SetRowCellValue(iNewIndex, cl2, strOld2);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (gvCast.SelectedRowsCount > 0)
                    gvCast.DeleteSelectedRows();
            }

        }

        private void gvCast_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column == imageColumn && e.IsGetData)
            {
                try
                {
                    String strCastID = ((Casts)e.Row).CastID;

                    if (File.Exists(GrieeXSettings.CastPath + strCastID + ".jpg"))
                    {
                        using (FileStream stream = new FileStream(GrieeXSettings.CastPath + strCastID + ".jpg", FileMode.Open, FileAccess.Read))
                        {
                            e.Value = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        e.Value = GrieeX.Properties.Resources.contact;
                    }

                }
                catch (Exception)
                {
                    e.Value = GrieeX.Properties.Resources.contact;
                }

            }
            else if (e.Column == cl1)
            {
                e.Value = ((Casts)e.Row).Name;
            }
            else if (e.Column == cl2)
            {
                e.Value = ((Casts)e.Row).Character;
            }
        }



        private void gvCast_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == imageColumn)
            {
                if (gvCast.SelectedRowsCount != 0)
                {
                    Casts c = CurrentMovie.Casts[gvCast.FocusedRowHandle];

                    if (File.Exists(GrieeXSettings.CastPath + c.CastID + ".jpg"))
                    {
                        Forms.frmImage frm = new Forms.frmImage();
                        frm.ImageShow(GrieeXSettings.CastPath + c.CastID + ".jpg");
                        frm.Text = c.Name + " - " + c.Character;
                        //frm.slResolution.Caption = Language.FindKey("Strings", "21").Value + ": " + pbImage.Image.Width + " x " + pbImage.Image.Height;
                        frm.HideButtons();
                        frm.Show();
                    }

                }
            }


        }

        private void pbImage_LoadCompleted(object sender, EventArgs e)
        {
            pbImage.Properties.SizeMode = PictureSizeMode.Stretch;
            pbImage.StopAnimation();
        }
    }
}

