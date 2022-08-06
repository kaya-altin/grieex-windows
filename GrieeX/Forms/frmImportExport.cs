using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using GrieeX.GrieeXBase;


namespace GrieeX.Forms
{
    public partial class frmImportExport : Form
    {
        public frmImportExport()
        {
            InitializeComponent();
            EmitLanguage();

            con = new OleDbConnection();
            con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;DATA SOURCE=" + Application.StartupPath + "\\Database\\dbGrieeX.mdb";
            con.Open();
        }
        private formType _FormType;
        private string _FileLocation;



        OleDbConnection con;
        OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
        OleDbCommand dc = new OleDbCommand();
        OleDbDataReader reader;
        OleDbConnection con1 = new OleDbConnection();
        public int i = 0;

        bool bEndProccess = false;
        ListView exlist = new ListView();
        ListView lstPicture = new ListView();

        string strPictureFolder;

        public enum formType
        {
            Diviks,
            DivxTurk,
            PivX,
            DivxARC,
            AllMyMovies,
            eXtremeMovieManager
        }

        public formType FormType
        {
            get { return _FormType; }
            set { _FormType = value; }
        }

        public string FileLocation
        {
            get { return _FileLocation; }
            set { _FileLocation = value; }
        }

        public void Connection1()
        {
            con1 = new OleDbConnection();
            con1.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;DATA SOURCE=" + FileLocation;
            con1.Open();
        }

        private void frmImportExport_Load(object sender, EventArgs e)
        {
            try
            {
                int nCount = 0;

                switch (FormType)
                {
                    case formType.Diviks:
                        dc.CommandText = "SELECT COUNT(*) FROM Diviks";
                        break;
                    case formType.DivxTurk:
                        dc.CommandText = "SELECT COUNT(*) FROM Movies";
                        break;
                    case formType.PivX:
                        dc.CommandText = "SELECT COUNT(*) FROM divx";
                        break;
                    case formType.DivxARC:
                        dc.CommandText = "SELECT COUNT(*) FROM arsiv";
                        break;
                    case formType.AllMyMovies:
                        dc.CommandText = "SELECT COUNT(*) FROM movies";
                        break;
                    case formType.eXtremeMovieManager:
                        dc.CommandText = "SELECT COUNT(*) FROM Movies";
                        break;
                    default:
                        nCount = 0;
                        break
                            ;
                }
                Connection1();

                dc.Connection = con1;
                dc.CommandType = CommandType.Text;

                nCount = Convert.ToInt32(dc.ExecuteScalar());

                txtCount.Text = nCount.ToString();
                ToolStripProgressBar.Maximum = nCount;

            }
            catch (Exception)
            {
                MessageBox.Show(Language.FindKey("Messages", "16").Value);
                this.Close();
            }

        }

        #region " Diviks "

        public void DiviksComboFill()
        {
            cbArchivesNumber.Items.Add("");
            cbArchivesNumber.Items.Add("Film ID");
            cbArchivesNumber.Items.Add("1. Alan");
            cbArchivesNumber.Items.Add("2. Alan");
            cbArchivesNumber.Items.Add("3. Alan");
            cbArchivesNumber.Items.Add("4. Alan");

            cbSeen.Items.Add("");
            cbSeen.Items.Add("1. İzleyici");
            cbSeen.Items.Add("2. İzleyici");
            cbSeen.Items.Add("3. İzleyici");
            cbSeen.Items.Add("4. İzleyici");
            cbSeen.Items.Add("5. İzleyici");

            cbUserColumn1.Items.Add("");
            cbUserColumn1.Items.Add("1. Alan");
            cbUserColumn1.Items.Add("2. Alan");
            cbUserColumn1.Items.Add("3. Alan");
            cbUserColumn1.Items.Add("4. Alan");

            cbUserColumn2.Items.Add("");
            cbUserColumn2.Items.Add("1. Alan");
            cbUserColumn2.Items.Add("2. Alan");
            cbUserColumn2.Items.Add("3. Alan");
            cbUserColumn2.Items.Add("4. Alan");

            cbUserColumn3.Items.Add("");
            cbUserColumn3.Items.Add("1. Alan");
            cbUserColumn3.Items.Add("2. Alan");
            cbUserColumn3.Items.Add("3. Alan");
            cbUserColumn3.Items.Add("4. Alan");

            cbUserColumn4.Items.Add("");
            cbUserColumn4.Items.Add("1. Alan");
            cbUserColumn4.Items.Add("2. Alan");
            cbUserColumn4.Items.Add("3. Alan");
            cbUserColumn4.Items.Add("4. Alan");

            cbArchivesNumber.SelectedIndex = 0;
            cbSeen.SelectedIndex = 0;
            cbUserColumn1.SelectedIndex = 0;
            cbUserColumn2.SelectedIndex = 0;
            cbUserColumn3.SelectedIndex = 0;
            cbUserColumn4.SelectedIndex = 0;
        }

        public void DiviksImport()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "11").Value;

            dc.CommandText = "SELECT * FROM Diviks ORDER BY OrgName ASC;";
            dc.Connection = con1;
            dc.CommandType = CommandType.Text;

            reader = dc.ExecuteReader();

            OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM tMovies", con);
            DataSet ds2 = new DataSet();
            da2.FillSchema(ds2, SchemaType.Source);


            while (reader.Read())
            {
                Application.DoEvents();

                DataRow dr = ds2.Tables[0].NewRow();

                ToolStripStatusLabel1.Text = reader["OrgName"].ToString();

                if (reader["OrgName"] != Convert.DBNull) dr["strOrginalName"] = reader["OrgName"]; else dr["strOrginalName"] = DBNull.Value;
                if (reader["TurName"] != Convert.DBNull) dr["strOtherName"] = reader["TurName"]; else dr["strOtherName"] = DBNull.Value;
                if (reader["Director"] != Convert.DBNull) dr["strDirector"] = reader["Director"]; else dr["strDirector"] = DBNull.Value;
                if (reader["Type"] != Convert.DBNull) dr["strGenre"] = reader["Type"]; else dr["strGenre"] = DBNull.Value;
                if (reader["Year"] != Convert.DBNull)
                {
                    string str = reader["Year"].ToString();
                    if (str.Length > 0) dr["strYear"] = str.Substring(0, 4);
                }
                else
                {
                    dr["strYear"] = DBNull.Value;
                }
                if (reader["Rating"] != Convert.DBNull) dr["strUserRating"] = reader["Rating"]; else dr["strUserRating"] = DBNull.Value;
                if (reader["Plot"] != Convert.DBNull) dr["strEnglishPlot"] = reader["Plot"]; else dr["strEnglishPlot"] = DBNull.Value;
                if (reader["TPlot"] != Convert.DBNull) dr["strOtherPlot"] = reader["TPlot"]; else dr["strOtherPlot"] = DBNull.Value;
                if (reader["Lang"] != Convert.DBNull) dr["strLanguage"] = reader["Lang"]; else dr["strLanguage"] = DBNull.Value;
                if (reader["Time"] != Convert.DBNull) dr["strRunningTime"] = reader["Time"]; else dr["strRunningTime"] = DBNull.Value;

                if (reader["WebSite"] != Convert.DBNull)
                {
                    string strImdbNumber = reader["WebSite"].ToString();
                    if (strImdbNumber.StartsWith("http://www.imdb.com/title/tt") | strImdbNumber.StartsWith("http://us.imdb.com/title/tt") | strImdbNumber.StartsWith("http://us.imdb.com/Title?") | strImdbNumber.StartsWith("http://imdb.com/title/tt"))
                    {
                        strImdbNumber = strImdbNumber.Replace("http://www.imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("http://us.imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("http://us.imdb.com/Title?", "");
                        strImdbNumber = strImdbNumber.Replace("http://imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("/", "");

                        dr["strImdbNumber"] = strImdbNumber;
                    }
                }
                else
                {
                    dr["strImdbNumber"] = DBNull.Value;
                }

                if (reader["Picture"] != Convert.DBNull)
                {
                    lstPicture.Items.Add(reader["Picture"].ToString());
                }
                else
                {
                    lstPicture.Items.Add("0");
                }

                if (reader["ACast"] != Convert.DBNull) dr["strCast"] = EmitCast(reader["ACast"].ToString()); else dr["strCast"] = DBNull.Value;

                if (cbArchivesNumber.SelectedIndex == 1) if (reader["FilmID"] != Convert.DBNull) dr["strArchivesNumber"] = reader["FilmID"].ToString().Replace(",","-"); else dr["strArchivesNumber"] = DBNull.Value;
                if (cbArchivesNumber.SelectedIndex == 2) if (reader["Field01"] != Convert.DBNull) dr["strArchivesNumber"] = reader["Field01"].ToString().Replace(",", "-"); else dr["strArchivesNumber"] = DBNull.Value;
                if (cbArchivesNumber.SelectedIndex == 3) if (reader["Field02"] != Convert.DBNull) dr["strArchivesNumber"] = reader["Field02"].ToString().Replace(",", "-"); else dr["strArchivesNumber"] = DBNull.Value;
                if (cbArchivesNumber.SelectedIndex == 4) if (reader["Field03"] != Convert.DBNull) dr["strArchivesNumber"] = reader["Field03"].ToString().Replace(",", "-"); else dr["strArchivesNumber"] = DBNull.Value;
                if (cbArchivesNumber.SelectedIndex == 5) if (reader["Field04"] != Convert.DBNull) dr["strArchivesNumber"] = reader["Field04"].ToString().Replace(",", "-"); else dr["strArchivesNumber"] = DBNull.Value;


                if (reader["Seen"] != Convert.DBNull & cbSeen.SelectedIndex != 0)
                {
                    string s = reader["Seen"].ToString();
                    if (Convert.ToInt32(s.Substring(cbSeen.SelectedIndex - 1, 1)) == 1) dr["bSeen"] = false; else dr["bSeen"] = true;
                }
                else
                {
                    dr["bSeen"] = false;
                }

                //if (reader["RlsType"] != Convert.DBNull)
                //{
                //    switch (reader["RlsType"].ToString())
                //    {
                //        case "DVD Rip":
                //            dr["nRlsType"] = "1";
                //            break;
                //        case "DVDScr Rip":
                //            dr["nRlsType"] = "2";
                //            break;
                //        case "VHS Rip":
                //            dr["nRlsType"] = "15";
                //            break;
                //        case "TV Rip":
                //            dr["nRlsType"] = "14";
                //            break;
                //        case "VCD Rip":
                //            dr["nRlsType"] = "13";
                //            break;
                //        case "SVCD Rip":
                //            dr["nRlsType"] = "11";
                //            break;
                //        case "Telesync":
                //            dr["nRlsType"] = "16";
                //            break;
                //        case "Blu-Ray Rip":
                //            dr["nRlsType"] = "3";
                //            break;
                //        case "":
                //            dr["nRlsType"] = DBNull.Value;
                //            break;
                //    }

                //}
                //else
                //{
                //    dr["nRlsType"] = DBNull.Value;
                //}

                //if (reader["RlsGroup"] != Convert.DBNull)
                //{
                //    if (reader["RlsGroup"].ToString() != "")
                //    {
                //        if ((int)Data.Execute("SELECT COUNT(*) FROM tRlsGroups Where strRlsGroup=@#" + reader["RlsGroup"].ToString() + "@#", Data.ReturnType.Scalar) > 0)
                //        {
                //            string value = Data.Execute("SELECT kRlsGroup FROM tRlsGroups Where strRlsGroup=@#" + reader["RlsGroup"].ToString() + "@#", Data.ReturnType.Scalar).ToString();
                //            dr["nRlsGroup"] = value;
                //        }
                //        else
                //        {
                //            string value = Record.Insert("tRlsGroups", "strRlsGroup", "@#" + reader["RlsGroup"].ToString() + "@#", true).ToString();
                //            dr["nRlsGroup"] = value;
                //        }
                //    }
                //    else
                //    {
                //        dr["nRlsGroup"] = DBNull.Value;
                //    }    
                //}
                //else
                //{
                //    dr["nRlsGroup"] = DBNull.Value;
                //}

                if (reader["Subtitle1"] != Convert.DBNull)
                {
                    switch (reader["Subtitle1"].ToString())
                    {
                        case "Yok":
                            dr["strSubtitle"] = DBNull.Value;
                            break;
                        case "Türkçe":
                            dr["strSubtitle"] = "Turkish";
                            break;
                        case "İngilizce":
                            dr["strSubtitle"] = "English";
                            break;
                        case "Almanca":
                            dr["strSubtitle"] = "German";
                            break;
                        case "Fransızca":
                            dr["strSubtitle"] = "French";
                            break;
                        case "İspanyolca":
                            dr["strSubtitle"] = "Spanish";
                            break;
                        case "İtalyanca":
                            dr["strSubtitle"] = "Italian";
                            break;
                        case "":
                            dr["strSubtitle"] = DBNull.Value;
                            break;
                    }
                }
                else
                {
                    dr["strSubtitle"] = DBNull.Value;
                }

                switch (cbUserColumn1.SelectedIndex)
                {
                    case 1:
                        if (reader["Field01"] != Convert.DBNull) dr["strUserColumn1"] = reader["Field01"]; else dr["strUserColumn1"] = DBNull.Value;
                        break;
                    case 2:
                        if (reader["Field02"] != Convert.DBNull) dr["strUserColumn1"] = reader["Field02"]; else dr["strUserColumn1"] = DBNull.Value;
                        break;
                    case 3:
                        if (reader["Field03"] != Convert.DBNull) dr["strUserColumn1"] = reader["Field03"]; else dr["strUserColumn1"] = DBNull.Value;
                        break;
                    case 4:
                        if (reader["Field04"] != Convert.DBNull) dr["strUserColumn1"] = reader["Field04"]; else dr["strUserColumn1"] = DBNull.Value;
                        break;
                }
                switch (cbUserColumn2.SelectedIndex)
                {
                    case 1:
                        if (reader["Field01"] != Convert.DBNull) dr["strUserColumn2"] = reader["Field01"]; else dr["strUserColumn2"] = DBNull.Value;
                        break;
                    case 2:
                        if (reader["Field02"] != Convert.DBNull) dr["strUserColumn2"] = reader["Field02"]; else dr["strUserColumn2"] = DBNull.Value;
                        break;
                    case 3:
                        if (reader["Field03"] != Convert.DBNull) dr["strUserColumn2"] = reader["Field03"]; else dr["strUserColumn2"] = DBNull.Value;
                        break;
                    case 4:
                        if (reader["Field04"] != Convert.DBNull) dr["strUserColumn2"] = reader["Field04"]; else dr["strUserColumn2"] = DBNull.Value;
                        break;
                }
                switch (cbUserColumn3.SelectedIndex)
                {
                    case 1:
                        if (reader["Field01"] != Convert.DBNull) dr["strUserColumn3"] = reader["Field01"]; else dr["strUserColumn3"] = DBNull.Value;
                        break;
                    case 2:
                        if (reader["Field02"] != Convert.DBNull) dr["strUserColumn3"] = reader["Field02"]; else dr["strUserColumn3"] = DBNull.Value;
                        break;
                    case 3:
                        if (reader["Field03"] != Convert.DBNull) dr["strUserColumn3"] = reader["Field03"]; else dr["strUserColumn3"] = DBNull.Value;
                        break;
                    case 4:
                        if (reader["Field04"] != Convert.DBNull) dr["strUserColumn3"] = reader["Field04"]; else dr["strUserColumn3"] = DBNull.Value;
                        break;
                }
                switch (cbUserColumn4.SelectedIndex)
                {
                    case 1:
                        if (reader["Field01"] != Convert.DBNull) dr["strUserColumn4"] = reader["Field01"]; else dr["strUserColumn4"] = DBNull.Value;
                        break;
                    case 2:
                        if (reader["Field02"] != Convert.DBNull) dr["strUserColumn4"] = reader["Field02"]; else dr["strUserColumn4"] = DBNull.Value;
                        break;
                    case 3:
                        if (reader["Field03"] != Convert.DBNull) dr["strUserColumn4"] = reader["Field03"]; else dr["strUserColumn4"] = DBNull.Value;
                        break;
                    case 4:
                        if (reader["Field04"] != Convert.DBNull) dr["strUserColumn4"] = reader["Field04"]; else dr["strUserColumn4"] = DBNull.Value;
                        break;
                }

                if (reader["EnterDate"] != Convert.DBNull) dr["dtDateEntered"] = reader["EnterDate"]; else dr["dtDateEntered"] = DateTime.Now.Date;
                dr["strDubbing"] = DBNull.Value;
                dr["kMovies_Type"] = 1;

                ds2.Tables[0].Rows.Add(dr);

                ToolStripProgressBar.Value += 1;
                //ToolStripProgressBar.Refresh
                txtNo.Text = ToolStripProgressBar.Value.ToString();

                dsFilesImportExport.Files.AddFilesRow("0", "0",
                reader["FileName"] == Convert.DBNull ? "" : reader["FileName"].ToString(),
                reader["ResWidth"] + " x " + reader["ResHeight"],
                reader["Codec"] == Convert.DBNull ? "" : reader["Codec"].ToString(),
                reader["Bitrate"] == Convert.DBNull ? "" : reader["Bitrate"].ToString(),
                reader["Fps"] == Convert.DBNull ? "" : reader["Fps"].ToString(),
                string.Empty,
                reader["Audio"] == Convert.DBNull ? "" : reader["Audio"].ToString(),
                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 0);

                if (bEndProccess == true) return;

            }
            reader.Close();

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "12").Value;
            da2.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da2);
            da2.Update(ds2);

            ds2.Dispose();
            ds2 = null;
            da2.Dispose();

            exlist.Items.Clear();
            tFiles_Diviks();
        }

        public void tFiles_Diviks()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "13").Value;
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tFiles", con);
            DataSet ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source);

            int a = 0;

            for (a = 0; a <= dsFilesImportExport.Files.Rows.Count - 1; a++)
            {
                if (dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString() != "")
                {
                    Application.DoEvents();
                    DataRow dr = ds.Tables[0].NewRow();

                    dr["kMovie"] = dsFilesImportExport.Tables[0].Rows[a]["kMovie"];
                    if (dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString() != "") dr["strFileName"] = dsFilesImportExport.Tables[0].Rows[a]["strFileName"]; else dr["strFileName"] = DBNull.Value;
                    if (dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"].ToString() != "") dr["strVideoCodec"] = dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"]; else dr["strVideoCodec"] = DBNull.Value;
                    if (dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"].ToString() != "") dr["strVideoBitrate"] = dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"]; else dr["strVideoBitrate"] = DBNull.Value;
                    if (dsFilesImportExport.Tables[0].Rows[a]["strResolution"].ToString() != "")
                    {
                        Application.DoEvents();
                        string strR = dsFilesImportExport.Tables[0].Rows[a]["strResolution"].ToString();
                        if (strR.Length > 10)
                        {
                            dr["strResolution"] = strR.Substring(0, 10);
                        }
                        else
                        {
                            dr["strResolution"] = strR;
                        }
                    }
                    else
                    {
                        dr["strResolution"] = DBNull.Value;
                    }
                    if (dsFilesImportExport.Tables[0].Rows[a]["strFps"].ToString() != "") dr["strFps"] = dsFilesImportExport.Tables[0].Rows[a]["strFps"]; else dr["strFps"] = DBNull.Value;

                    if (dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"].ToString() != "")
                    {
                        dr["strAudioCodec1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"];
                    }
                    ds.Tables[0].Rows.Add(dr);
                }

                if (bEndProccess == true) return;

            }

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "14").Value;

            da.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated2);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da);
            da.Update(ds);
            ds.Dispose();
            ds = null;

            ToolStripProgressBar.Value = 0;
            ToolStripProgressBar.Style = ProgressBarStyle.Blocks;
            this.ToolStripStatusLabel1.Text = Language.FindKey("Messages", "15").Value;
            this.Close();
        }

        #endregion

        #region " PivX "

        public void PivXImport()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "11").Value;

            dc.CommandText = "SELECT * FROM divx ORDER BY isim ASC;";
            dc.Connection = con1;
            dc.CommandType = CommandType.Text;

            reader = dc.ExecuteReader();

            OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM tMovies", con);
            DataSet ds2 = new DataSet();
            da2.FillSchema(ds2, SchemaType.Source);


            while (reader.Read())
            {
                Application.DoEvents();

                DataRow dr = ds2.Tables[0].NewRow();

                ToolStripStatusLabel1.Text = reader["isim"].ToString();

                if (reader["isim"] != Convert.DBNull) dr["strOrginalName"] = reader["isim"]; else dr["strOrginalName"] = DBNull.Value;
                if (reader["tisim"] != Convert.DBNull) dr["strOtherName"] = reader["tisim"]; else dr["strOtherName"] = DBNull.Value;
                if (reader["yonetmen"] != Convert.DBNull) dr["strDirector"] = reader["yonetmen"]; else dr["strDirector"] = DBNull.Value;
                if (reader["yil"] != Convert.DBNull)
                {
                    string strY = reader["yil"].ToString();
                    if (strY.Length > 0) dr["strYear"] = strY.Substring(0, 4);
                }
                else
                {
                    dr["strYear"] = DBNull.Value;
                }
                if (reader["imdbpuan"] != Convert.DBNull) dr["strUserRating"] = StringReplace(reader["imdbpuan"].ToString()); else dr["strUserRating"] = DBNull.Value;
                if (reader["imdboy"] != Convert.DBNull) dr["nVotes"] = StringReplace(reader["imdboy"].ToString()); else dr["nVotes"] = DBNull.Value;
                if (reader["tur"] != Convert.DBNull) dr["strGenre"] = reader["tur"]; else dr["strGenre"] = DBNull.Value;
                if (reader["ulke"] != Convert.DBNull) dr["strCountry"] = reader["ulke"]; else dr["strCountry"] = DBNull.Value;
                if (reader["senaryo"] != Convert.DBNull) dr["strWriter"] = reader["senaryo"]; else dr["strWriter"] = DBNull.Value;
                if (reader["konusu"] != Convert.DBNull) dr["strOtherPlot"] = reader["konusu"]; else dr["strOtherPlot"] = DBNull.Value;
                if (reader["konusueng"] != Convert.DBNull) dr["strEnglishPlot"] = reader["konusueng"]; else dr["strEnglishPlot"] = DBNull.Value;
                if (reader["orjinaldil"] != Convert.DBNull) dr["strLanguage"] = reader["orjinaldil"]; else dr["strLanguage"] = DBNull.Value;
                if (reader["sure"] != Convert.DBNull) dr["strRunningTime"] = reader["sure"]; else dr["strRunningTime"] = DBNull.Value;
                if (reader["izlenme"] != Convert.DBNull) dr["bSeen"] = reader["izlenme"]; else dr["bSeen"] = DBNull.Value;
                if (reader["arsivno"] != Convert.DBNull) dr["strArchivesNumber"] = reader["arsivno"]; else dr["strArchivesNumber"] = DBNull.Value;
                if (reader["izlenme"] != Convert.DBNull) dr["bSeen"] = reader["izlenme"]; else dr["bSeen"] = false;

                if (reader["Kaynak"] != Convert.DBNull)
                {
                    switch (reader["Kaynak"].ToString())
                    {
                        case "DVD Rip":
                            dr["nRlsType"] = "1";
                            break;
                        case "DVD Screener":
                            dr["nRlsType"] = "2";
                            break;
                        case "PDVD Rip":
                            dr["nRlsType"] = "6";
                            break;
                        case "TeleCine":
                            dr["nRlsType"] = "7";
                            break;
                        case "Screener":
                            dr["nRlsType"] = "8";
                            break;
                        case "KVCD":
                            dr["nRlsType"] = "9";
                            break;
                        case "MVCD":
                            dr["nRlsType"] = "10";
                            break;
                        case "SVCD Rip":
                            dr["nRlsType"] = "11";
                            break;
                        case "STV-Rip":
                            dr["nRlsType"] = "12";
                            break;
                        case "Orjinal VCD Rip":
                            dr["nRlsType"] = "13";
                            break;
                        case "VCD Rip":
                            dr["nRlsType"] = "13";
                            break;
                        case "TV-Rip":
                            dr["nRlsType"] = "14";
                            break;
                        case "VHS Rip":
                            dr["nRlsType"] = "15";
                            break;
                        case "Telesync":
                            dr["nRlsType"] = "16";
                            break;
                        case "Cam":
                            dr["nRlsType"] = "17";
                            break;
                        case "WorkPrint":
                            dr["nRlsType"] = "18";
                            break;
                    }
                }
                else
                {
                    dr["nRlsType"] = DBNull.Value;
                }


                if (reader["altyazi"] != Convert.DBNull)
                {
                    switch (reader["altyazi"].ToString())
                    {
                        case "Yok":
                            dr["strSubtitle"] = DBNull.Value;
                            break;
                        case "Türkçe":
                            dr["strSubtitle"] = "Turkish";
                            break;
                        case "İngilizce":
                            dr["strSubtitle"] = "English";
                            break;
                        case "Almanca":
                            dr["strSubtitle"] = "German";
                            break;
                        case "Fransızca":
                            dr["strSubtitle"] = "French";
                            break;
                        case "İspanyolca":
                            dr["strSubtitle"] = "Spanish";
                            break;
                        case "İtalyanca":
                            dr["strSubtitle"] = "Italian";
                            break;
                        case "Diğer":
                            dr["strSubtitle"] = "Other";
                            break;
                    }
                }
                else
                {
                    dr["strSubtitle"] = DBNull.Value;
                }


                string strImdbNumber = null;
                strImdbNumber = reader["imdbno"].ToString();
                if (strImdbNumber.Contains("titl") == true)
                {
                    strImdbNumber = strImdbNumber.Remove(strImdbNumber.ToString().IndexOf("titl")).Trim();
                    strImdbNumber = strImdbNumber.Remove(strImdbNumber.Length - 1);
                }
                if (!string.IsNullOrEmpty(strImdbNumber)) dr["strImdbNumber"] = StringReplace(strImdbNumber); else dr["strImdbNumber"] = DBNull.Value;


                if (reader["resimler"] != Convert.DBNull)
                {
                    string[] splitter = null;
                    string shortName = null;
                    string folder = null;

                    splitter = FileLocation.Split('\\');
                    shortName = splitter[splitter.GetUpperBound(0)];
                    folder = FileLocation.Replace("Database\\" + shortName, "");

                    lstPicture.Items.Add(folder + "\\images\\" + reader["resimler"]);
                }
                else
                {
                    lstPicture.Items.Add("0");
                }


                if (reader["oyuncular"] != Convert.DBNull) dr["strCast"] = EmitCast(reader["oyuncular"].ToString()); else dr["strCast"] = DBNull.Value;

                if (reader["eklemetarihi"] != Convert.DBNull) dr["dtDateEntered"] = reader["eklemetarihi"]; else dr["dtDateEntered"] = DateTime.Now.Date;

                dr["strDubbing"] = DBNull.Value;
                dr["kMovies_Type"] = 1;

                ds2.Tables[0].Rows.Add(dr);

                ToolStripProgressBar.Value += 1;
                txtNo.Text = ToolStripProgressBar.Value.ToString();


                dsFilesImportExport.Files.AddFilesRow("0", "0",
                reader["dosyaadi"] == Convert.DBNull ? "" : reader["dosyaadi"].ToString(),
                reader["cozunulurluk"] == Convert.DBNull ? "" : reader["cozunulurluk"].ToString(),
                reader["VideoCodec"] == Convert.DBNull ? "" : reader["VideoCodec"].ToString(),
                reader["bitrate"] == Convert.DBNull ? "" : reader["bitrate"].ToString(),
                reader["fps"] == Convert.DBNull ? "" : reader["fps"].ToString(),
                string.Empty,
                reader["audiocodec"] == Convert.DBNull ? "" : reader["audiocodec"].ToString(),
                reader["kanal"] == Convert.DBNull ? "" : reader["kanal"].ToString(),
                reader["abitrate"] == Convert.DBNull ? "" : reader["abitrate"].ToString() + "000",
                reader["samplerate"] == Convert.DBNull ? "" : reader["samplerate"].ToString(),
                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 0);

                if (bEndProccess == true) return;

            }
            reader.Close();

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "12").Value;
            da2.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da2);
            da2.Update(ds2);

            ds2.Dispose();
            ds2 = null;
            da2.Dispose();

            tFiles_PivX();
        }


        public void tFiles_PivX()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "13").Value;
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tFiles", con);
            DataSet ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source);

            int a = 0;

            for (a = 0; a <= dsFilesImportExport.Files.Rows.Count - 1; a++)
            {
                if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString()))
                {
                    Application.DoEvents();
                    DataRow dr = ds.Tables[0].NewRow();

                    dr["kMovie"] = dsFilesImportExport.Tables[0].Rows[a]["kMovie"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString())) dr["strFileName"] = dsFilesImportExport.Tables[0].Rows[a]["strFileName"]; else dr["strFileName"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"].ToString())) dr["strVideoCodec"] = dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"]; else dr["strVideoCodec"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"].ToString())) dr["strVideoBitrate"] = dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"]; else dr["strVideoBitrate"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strResolution"].ToString()))
                    {
                        Application.DoEvents();
                        string strR = dsFilesImportExport.Tables[0].Rows[a]["strResolution"].ToString();
                        if (strR.Length > 10)
                        {
                            dr["strResolution"] = strR.Substring(0, 10);
                        }
                        else
                        {
                            dr["strResolution"] = strR;
                        }
                    }
                    else
                    {
                        dr["strResolution"] = DBNull.Value;
                    }
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFps"].ToString())) dr["strFps"] = dsFilesImportExport.Tables[0].Rows[a]["strFps"]; else dr["strFps"] = DBNull.Value;

                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"].ToString()))
                    {
                        dr["strAudioCodec1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"];
                    }
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels1"].ToString())) dr["strAudioChannels1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels1"]; else dr["strAudioChannels1"] = DBNull.Value;
                    if (dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate1"].ToString() != "000") dr["strAudioBitrate1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate1"]; else dr["strAudioBitrate1"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate1"].ToString())) dr["strAudioSampleRate1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate1"]; else dr["strAudioSampleRate1"] = DBNull.Value;

                    ds.Tables[0].Rows.Add(dr);
                }

                if (bEndProccess == true) return;

            }

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "14").Value;

            da.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated2);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da);
            da.Update(ds);
            ds.Dispose();
            ds = null;

            ToolStripProgressBar.Value = 0;
            ToolStripProgressBar.Style = ProgressBarStyle.Blocks;
            this.ToolStripStatusLabel1.Text = Language.FindKey("Messages", "15").Value;
            this.Close();
        }

        #endregion

        #region " DivxARC "

        public void DivxARCComboFill()
        {
            cbArchivesNumber.Items.Add("");
            cbArchivesNumber.Items.Add("Disk Kodu");

            cbSeen.Items.Add("");
            cbSeen.Items.Add("İzleyici 1");
            cbSeen.Items.Add("İzleyici 2");
            cbSeen.Items.Add("İzleyici 3");
            cbSeen.Items.Add("İzleyici 4");
            cbSeen.Items.Add("İzleyici 5");

            cbArchivesNumber.SelectedIndex = 0;
            cbSeen.SelectedIndex = 0;
            cbUserColumn1.Visible = false;
            cbUserColumn2.Visible = false;
            cbUserColumn3.Visible = false;
            cbUserColumn4.Visible = false;
            lblUserColumn1.Visible = false;
            lblUserColumn2.Visible = false;
            lblUserColumn3.Visible = false;
            lblUserColumn4.Visible = false;

        }

        public void DivxARCImport()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "11").Value;

            dc.CommandText = "SELECT * FROM Arsiv ORDER BY EN_Name ASC;";
            dc.Connection = con1;
            dc.CommandType = CommandType.Text;

            reader = dc.ExecuteReader();

            OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM tMovies", con);
            DataSet ds2 = new DataSet();
            da2.FillSchema(ds2, SchemaType.Source);


            while (reader.Read())
            {
                Application.DoEvents();

                DataRow dr = ds2.Tables[0].NewRow();

                ToolStripStatusLabel1.Text = reader["EN_Name"].ToString();

                if (reader["EN_Name"] != Convert.DBNull) dr["strOrginalName"] = reader["EN_Name"]; else dr["strOrginalName"] = DBNull.Value;
                if (reader["TR_Name"] != Convert.DBNull) dr["strOtherName"] = reader["TR_Name"]; else dr["strOtherName"] = DBNull.Value;
                if (reader["Genre"] != Convert.DBNull) dr["strGenre"] = reader["Genre"]; else dr["strGenre"] = DBNull.Value;
                if (reader["Lang"] != Convert.DBNull) dr["strLanguage"] = reader["Lang"]; else dr["strLanguage"] = DBNull.Value;
                if (reader["Rating"] != Convert.DBNull) dr["strUserRating"] = StringReplace(reader["Rating"].ToString()); else dr["strUserRating"] = DBNull.Value;
                if (reader["Runtime"] != Convert.DBNull) dr["strRunningTime"] = StringReplace(reader["Runtime"].ToString()); else dr["strRunningTime"] = DBNull.Value;
                if (reader["Directed"] != Convert.DBNull) dr["strDirector"] = reader["Directed"]; else dr["strDirector"] = DBNull.Value;
                if (reader["Writing"] != Convert.DBNull) dr["strWriter"] = reader["Writing"]; else dr["strWriter"] = DBNull.Value;
                if (reader["Country"] != Convert.DBNull) dr["strCountry"] = reader["Country"]; else dr["strCountry"] = DBNull.Value;
                if (reader["ACast"] != Convert.DBNull) dr["strCast"] = EmitCast(reader["ACast"].ToString()); else dr["strCast"] = DBNull.Value;
                if (reader["Plot_TR"] != Convert.DBNull) dr["strOtherPlot"] = reader["Plot_TR"]; else dr["strOtherPlot"] = DBNull.Value;
                if (reader["RlsType"] != Convert.DBNull)
                {
                    switch (reader["RlsType"].ToString())
                    {
                        case "DVD Rip":
                            dr["nRlsType"] = "1";
                            break;
                        case "DVDScr Rip":
                            dr["nRlsType"] = "2";
                            break;
                        case "HD Rip":
                            dr["nRlsType"] = "4";
                            break;
                        case "LaserDisk Rip":
                            dr["nRlsType"] = "3";
                            break;
                        case "SVCD Rip":
                            dr["nRlsType"] = "11";
                            break;
                        case "Telecine":
                            dr["nRlsType"] = "7";
                            break;
                        case "Telesyns ":
                            dr["nRlsType"] = "16";
                            break;
                        case "TV Rip":
                            dr["nRlsType"] = "14";
                            break;
                        case "VCD Rip":
                            dr["nRlsType"] = "13";
                            break;
                        case "VHS Rip":
                            dr["nRlsType"] = "15";
                            break;
                    }
                }
                else
                {
                    dr["nRlsType"] = DBNull.Value;
                }

                if (reader["Subtitle1"] != Convert.DBNull)
                {
                    switch (reader["Subtitle1"].ToString())
                    {
                        case "Türkçe":
                            dr["strSubtitle"] = "Turkish";
                            break;
                        case "İngilizce":
                            dr["strSubtitle"] = "English";
                            break;
                        case "Almanca":
                            dr["strSubtitle"] = "German";
                            break;
                        case "Fransızca":
                            dr["strSubtitle"] = "French";
                            break;
                        case "İspanyolca":
                            dr["strSubtitle"] = "Spanish";
                            break;
                        case "İtalyanca":
                            dr["strSubtitle"] = "Italian";
                            break;
                        case "Diğer":
                            dr["strSubtitle"] = "Other";
                            break;
                    }
                }
                else
                {
                    dr["strSubtitle"] = DBNull.Value;
                }

                if (reader["YYear"] != Convert.DBNull)
                {
                    string strY = reader["YYear"].ToString();
                    if (strY.Length > 0) dr["strYear"] = strY.Substring(0, 4);
                }
                else
                {
                    dr["strYear"] = DBNull.Value;
                }

                if (reader["Picture"] != Convert.DBNull)
                {
                    lstPicture.Items.Add(strPictureFolder + "\\" + reader["Picture"].ToString());
                }
                else
                {
                    lstPicture.Items.Add("0");
                }


                if (reader["WebSite"] != Convert.DBNull)
                {
                    string strImdbNumber = reader["WebSite"].ToString();
                    if (strImdbNumber.StartsWith("http://www.imdb.com/title/tt") | strImdbNumber.StartsWith("http://us.imdb.com/title/tt") | strImdbNumber.StartsWith("http://us.imdb.com/Title?") | strImdbNumber.StartsWith("http://imdb.com/title/tt"))
                    {
                        strImdbNumber = strImdbNumber.Replace("http://www.imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("http://us.imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("http://us.imdb.com/Title?", "");
                        strImdbNumber = strImdbNumber.Replace("http://imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("/", "");

                        dr["strImdbNumber"] = strImdbNumber;
                    }
                }
                else
                {
                    dr["strImdbNumber"] = DBNull.Value;
                }


                if (cbArchivesNumber.SelectedIndex == 1) if (reader["Disccode"] != Convert.DBNull) dr["strArchivesNumber"] = reader["Disccode"]; else dr["strArchivesNumber"] = DBNull.Value;

                if (cbSeen.SelectedIndex == 1) if (reader["User1_Seen"] != Convert.DBNull) dr["bSeen"] = reader["User1_Seen"]; else dr["bSeen"] = false;
                if (cbSeen.SelectedIndex == 2) if (reader["User2_Seen"] != Convert.DBNull) dr["bSeen"] = reader["User2_Seen"]; else dr["bSeen"] = false;
                if (cbSeen.SelectedIndex == 3) if (reader["User3_Seen"] != Convert.DBNull) dr["bSeen"] = reader["User3_Seen"]; else dr["bSeen"] = false;
                if (cbSeen.SelectedIndex == 4) if (reader["User4_Seen"] != Convert.DBNull) dr["bSeen"] = reader["User4_Seen"]; else dr["bSeen"] = false;
                if (cbSeen.SelectedIndex == 5) if (reader["User5_Seen"] != Convert.DBNull) dr["bSeen"] = reader["User5_Seen"]; else dr["bSeen"] = false;


                if (reader["EnterDate"] != Convert.DBNull) dr["dtDateEntered"] = reader["EnterDate"]; else dr["dtDateEntered"] = DateTime.Now.Date;

                dr["strDubbing"] = DBNull.Value;
                dr["kMovies_Type"] = 1;

                ds2.Tables[0].Rows.Add(dr);

                ToolStripProgressBar.Value += 1;
                txtNo.Text = ToolStripProgressBar.Value.ToString();

                string str = null;
                if (reader["A_Aud_AvgBitrate"] != Convert.DBNull)
                {
                    str = reader["A_Aud_AvgBitrate"].ToString();
                    str = str.Replace(",", "");
                    str = str + "0";
                }
                else
                {
                    str = "";
                }

                dsFilesImportExport.Files.AddFilesRow("0", "0",
                reader["A_Vid_Filename"] == Convert.DBNull ? "" : reader["A_Vid_Filename"].ToString(),
                reader["A_Vid_Resolution"] == Convert.DBNull ? "" : reader["A_Vid_Resolution"].ToString(),
                reader["A_Vid_Codec"] == Convert.DBNull ? "" : reader["A_Vid_Codec"].ToString(),
                reader["A_Vid_Bitrate"] == Convert.DBNull ? "" : reader["A_Vid_Bitrate"].ToString(),
                reader["A_Vid_Framerate"] == Convert.DBNull ? "" : reader["A_Vid_Framerate"].ToString(),
                string.Empty,
                reader["A_Aud_WaveType"] == Convert.DBNull ? "" : reader["A_Aud_WaveType"].ToString(),
                reader["A_Aud_Channels"] == Convert.DBNull ? "" : reader["A_Aud_Channels"].ToString(),
                str,
                reader["A_Aud_SampleRate"] == Convert.DBNull ? string.Empty : reader["A_Aud_SampleRate"].ToString(),
                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 0);

                if (bEndProccess == true) return;

            }
            reader.Close();

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "12").Value;
            da2.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da2);
            da2.Update(ds2);

            ds2.Dispose();
            ds2 = null;
            da2.Dispose();

            tFiles_DivxARC();
        }


        public void tFiles_DivxARC()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "13").Value;
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tFiles", con);
            DataSet ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source);

            int a = 0;

            for (a = 0; a <= dsFilesImportExport.Files.Rows.Count - 1; a++)
            {
                if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString()))
                {
                    Application.DoEvents();
                    DataRow dr = ds.Tables[0].NewRow();

                    dr["kMovie"] = dsFilesImportExport.Tables[0].Rows[a]["kMovie"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString())) dr["strFileName"] = dsFilesImportExport.Tables[0].Rows[a]["strFileName"]; else dr["strFileName"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"].ToString())) dr["strVideoCodec"] = dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"]; else dr["strVideoCodec"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"].ToString())) dr["strVideoBitrate"] = StringReplace(dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"].ToString()); else dr["strVideoBitrate"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate1"].ToString())) dr["strAudioSampleRate1"] = StringReplace(dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate1"].ToString()); else dr["strAudioSampleRate1"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate1"].ToString())) dr["strAudioBitrate1"] = StringReplace(dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate1"].ToString()); else dr["strAudioBitrate1"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strResolution"].ToString())) dr["strResolution"] = dsFilesImportExport.Tables[0].Rows[a]["strResolution"]; else dr["strResolution"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFps"].ToString())) dr["strFps"] = StringReplace(dsFilesImportExport.Tables[0].Rows[a]["strFps"].ToString()); else dr["strFps"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"].ToString())) dr["strAudioCodec1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels1"].ToString())) dr["strAudioChannels1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels1"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strTotalFrames"].ToString())) dr["strTotalFrames"] = dsFilesImportExport.Tables[0].Rows[a]["strTotalFrames"];


                    ds.Tables[0].Rows.Add(dr);
                }

                if (bEndProccess == true) return;

            }

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "14").Value;

            da.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated2);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da);
            da.Update(ds);
            ds.Dispose();
            ds = null;

            ToolStripProgressBar.Value = 0;
            ToolStripProgressBar.Style = ProgressBarStyle.Blocks;
            this.ToolStripStatusLabel1.Text = Language.FindKey("Messages", "15").Value;
            this.Close();
        }



        #endregion

        #region " DivxTurk "

        public void DivxTurkComboFill()
        {
            cbArchivesNumber.Items.Add("");
            cbArchivesNumber.Items.Add("Katalog No");
            cbArchivesNumber.Items.Add("Kullancı Not #1");
            cbArchivesNumber.Items.Add("Kullancı Not #2");
            cbArchivesNumber.Items.Add("Kullancı Not #3");
            cbArchivesNumber.Items.Add("DivxTurk ID");

            cbSeen.Items.Add("");
            cbSeen.Items.Add("1. İzleyici");
            cbSeen.Items.Add("2. İzleyici");
            cbSeen.Items.Add("3. İzleyici");

            cbUserColumn1.Items.Add("");
            cbUserColumn1.Items.Add("Kullancı Not #1");
            cbUserColumn1.Items.Add("Kullancı Not #2");
            cbUserColumn1.Items.Add("Kullancı Not #3");
            cbUserColumn1.Items.Add("DivxTurk ID");

            cbUserColumn2.Items.Add("");
            cbUserColumn2.Items.Add("Kullancı Not #1");
            cbUserColumn2.Items.Add("Kullancı Not #2");
            cbUserColumn2.Items.Add("Kullancı Not #3");
            cbUserColumn2.Items.Add("DivxTurk ID");

            cbUserColumn3.Items.Add("");
            cbUserColumn3.Items.Add("Kullancı Not #1");
            cbUserColumn3.Items.Add("Kullancı Not #2");
            cbUserColumn3.Items.Add("Kullancı Not #3");
            cbUserColumn3.Items.Add("DivxTurk ID");

            cbUserColumn4.Items.Add("");
            cbUserColumn4.Items.Add("Kullancı Not #1");
            cbUserColumn4.Items.Add("Kullancı Not #2");
            cbUserColumn4.Items.Add("Kullancı Not #3");
            cbUserColumn4.Items.Add("DivxTurk ID");

            cbArchivesNumber.SelectedIndex = 0;
            cbSeen.SelectedIndex = 0;
            cbUserColumn1.SelectedIndex = 0;
            cbUserColumn2.SelectedIndex = 0;
            cbUserColumn3.SelectedIndex = 0;
            cbUserColumn4.SelectedIndex = 0;
        }

        public void DivxTurkImport()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "11").Value;

            dc.CommandText = "SELECT * FROM Movies ORDER BY M_Name ASC;";
            dc.Connection = con1;
            dc.CommandType = CommandType.Text;

            reader = dc.ExecuteReader();

            OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM tMovies", con);
            DataSet ds2 = new DataSet();
            da2.FillSchema(ds2, SchemaType.Source);



            while (reader.Read())
            {
                Application.DoEvents();

                DataRow dr = ds2.Tables[0].NewRow();

                ToolStripStatusLabel1.Text = reader["M_Name"].ToString();

                exlist.Items.Add(reader["M_KaySiraNo"].ToString());
                exlist.Items[i].SubItems.Add(reader["M_DivXTurkId"].ToString());
                i = i + 1;

                if (reader["M_ImdbName"] != Convert.DBNull)
                {
                    if (reader["M_ImdbName"] != Convert.DBNull) dr["strOrginalName"] = reader["M_ImdbName"]; else dr["strOrginalName"] = DBNull.Value;
                }
                else
                {
                    if (reader["M_Name"] != Convert.DBNull) dr["strOrginalName"] = reader["M_Name"]; else dr["strOrginalName"] = DBNull.Value;
                }
                if (reader["M_TR_Name"] != Convert.DBNull) dr["strOtherName"] = reader["M_TR_Name"]; else dr["strOtherName"] = DBNull.Value;
                if (reader["M_Directed"] != Convert.DBNull) dr["strDirector"] = reader["M_Directed"]; else dr["strDirector"] = DBNull.Value;
                if (reader["M_Writing"] != Convert.DBNull) dr["strWriter"] = reader["M_Writing"]; else dr["strWriter"] = DBNull.Value;
                if (reader["M_Genre"] != Convert.DBNull) dr["strGenre"] = reader["M_Genre"]; else dr["strGenre"] = DBNull.Value;
                if (reader["M_Year"] != Convert.DBNull)
                {
                    string str = reader["M_Year"].ToString();
                    if (str.Length > 0) dr["strYear"] = str.Substring(0, 4);
                }
                else
                {
                    dr["strYear"] = DBNull.Value;
                }
                if (reader["M_Rate"] != Convert.DBNull) dr["strUserRating"] = reader["M_Rate"]; else dr["strUserRating"] = DBNull.Value;
                if (reader["M_Plot_EN"] != Convert.DBNull) dr["strEnglishPlot"] = reader["M_Plot_EN"]; else dr["strEnglishPlot"] = DBNull.Value;
                if (reader["M_Plot_TR"] != Convert.DBNull) dr["strOtherPlot"] = reader["M_Plot_TR"]; else dr["strOtherPlot"] = DBNull.Value;
                if (reader["M_Lang"] != Convert.DBNull) dr["strLanguage"] = reader["M_Lang"]; else dr["strLanguage"] = DBNull.Value;
                if (reader["M_Runtime"] != Convert.DBNull) dr["strRunningTime"] = reader["M_Runtime"]; else dr["strRunningTime"] = DBNull.Value;
                if (reader["M_ImdbId"] != Convert.DBNull) dr["strImdbNumber"] = StringReplace(reader["M_ImdbId"].ToString()); else dr["strImdbNumber"] = DBNull.Value;
                if (reader["M_Country"] != Convert.DBNull) dr["strCountry"] = reader["M_Country"]; else dr["strCountry"] = DBNull.Value;


                if (reader["M_DivXTurkId"] != Convert.DBNull & reader["M_ImdbId"] != Convert.DBNull)
                {
                    string[] splitter = null;
                    string shortName = null;
                    string folder = null;

                    splitter = FileLocation.Split('\\');
                    shortName = splitter[splitter.GetUpperBound(0)];

                    folder = FileLocation.Replace(shortName, "");
                    shortName = shortName.Replace(".dbDXT", "");
                    folder = folder + shortName + "_IMG";

                    lstPicture.Items.Add(folder + "\\" + reader["M_DivXTurkId"] + ".jpg");
                }
                else
                {
                    lstPicture.Items.Add("0");
                }

                if (reader["M_Cast"] != Convert.DBNull) dr["strCast"] = EmitCast(reader["M_Cast"].ToString()); else dr["strCast"] = DBNull.Value;

                if (cbArchivesNumber.SelectedIndex == 1) if (reader["M_CatNo"] != Convert.DBNull) dr["strArchivesNumber"] = reader["M_CatNo"]; else dr["strArchivesNumber"] = DBNull.Value;
                if (cbArchivesNumber.SelectedIndex == 2) if (reader["M_User1"] != Convert.DBNull) dr["strArchivesNumber"] = reader["M_User1"]; else dr["strArchivesNumber"] = DBNull.Value;
                if (cbArchivesNumber.SelectedIndex == 3) if (reader["M_User2"] != Convert.DBNull) dr["strArchivesNumber"] = reader["M_User2"]; else dr["strArchivesNumber"] = DBNull.Value;
                if (cbArchivesNumber.SelectedIndex == 4) if (reader["M_User3"] != Convert.DBNull) dr["strArchivesNumber"] = reader["M_User3"]; else dr["strArchivesNumber"] = DBNull.Value;
                if (cbArchivesNumber.SelectedIndex == 5) if (reader["M_DivXTurkId"] != Convert.DBNull) dr["strArchivesNumber"] = reader["M_DivXTurkId"]; else dr["strArchivesNumber"] = DBNull.Value;


                if (cbSeen.SelectedIndex == 1) if (reader["M_Seen1"] != Convert.DBNull) dr["bSeen"] = reader["M_Seen1"]; else dr["bSeen"] = false;
                if (cbSeen.SelectedIndex == 2) if (reader["M_Seen2"] != Convert.DBNull) dr["bSeen"] = reader["M_Seen1"]; else dr["bSeen"] = false;
                if (cbSeen.SelectedIndex == 3) if (reader["M_Seen3"] != Convert.DBNull) dr["bSeen"] = reader["M_Seen1"]; else dr["bSeen"] = false;

                if (reader["M_SubLng1"] != Convert.DBNull)
                {
                    switch (reader["M_SubLng1"].ToString())
                    {
                        case "Yok":
                        case "Altyazı Yok":
                        case "":
                            dr["strSubtitle"] = DBNull.Value;
                            break;
                        case "Türkçe":
                            dr["strSubtitle"] = "Turkish";
                            break;
                        case "TR":
                            dr["strSubtitle"] = "Turkish";
                            break;
                        case "İngilizce":
                            dr["strSubtitle"] = "English";
                            break;
                        case "EN":
                            dr["strSubtitle"] = "English";
                            break;
                        case "Almanca":
                            dr["strSubtitle"] = "German";
                            break;
                        case "DE":
                            dr["strSubtitle"] = "German";
                            break;
                        case "Fransızca":
                            dr["strSubtitle"] = "French";
                            break;
                        case "FR":
                            dr["strSubtitle"] = "French";
                            break;
                        case "İspanyolca":
                            dr["strSubtitle"] = "Spanish";
                            break;
                        case "İtalyanca":
                            dr["strSubtitle"] = "Italian";
                            break;
                    }
                }
                else
                {
                     dr["strSubtitle"] = DBNull.Value;
                }

                switch (cbUserColumn1.SelectedIndex)
                {
                    case 1:
                        if (reader["M_User1"] != Convert.DBNull) dr["strUserColumn1"] = reader["M_User1"]; else dr["strUserColumn1"] = DBNull.Value;
                        break;
                    case 2:
                        if (reader["M_User2"] != Convert.DBNull) dr["strUserColumn1"] = reader["M_User2"]; else dr["strUserColumn1"] = DBNull.Value;
                        break;
                    case 3:
                        if (reader["M_User3"] != Convert.DBNull) dr["strUserColumn1"] = reader["M_User3"]; else dr["strUserColumn1"] = DBNull.Value;
                        break;
                    case 4:
                        if (reader["M_DivXTurkId"] != Convert.DBNull) dr["strUserColumn1"] = reader["M_DivXTurkId"]; else dr["strUserColumn1"] = DBNull.Value;
                        break;
                }
                switch (cbUserColumn2.SelectedIndex)
                {
                    case 1:
                        if (reader["M_User1"] != Convert.DBNull) dr["strUserColumn2"] = reader["M_User1"]; else dr["strUserColumn2"] = DBNull.Value;
                        break;
                    case 2:
                        if (reader["M_User2"] != Convert.DBNull) dr["strUserColumn2"] = reader["M_User2"]; else dr["strUserColumn2"] = DBNull.Value;
                        break;
                    case 3:
                        if (reader["M_User3"] != Convert.DBNull) dr["strUserColumn2"] = reader["M_User3"]; else dr["strUserColumn2"] = DBNull.Value;
                        break;
                    case 4:
                        if (reader["M_DivXTurkId"] != Convert.DBNull) dr["strUserColumn2"] = reader["M_DivXTurkId"]; else dr["strUserColumn2"] = DBNull.Value;
                        break;
                }
                switch (cbUserColumn3.SelectedIndex)
                {
                    case 1:
                        if (reader["M_User1"] != Convert.DBNull) dr["strUserColumn3"] = reader["M_User1"]; else dr["strUserColumn3"] = DBNull.Value;
                        break;
                    case 2:
                        if (reader["M_User2"] != Convert.DBNull) dr["strUserColumn3"] = reader["M_User2"]; else dr["strUserColumn3"] = DBNull.Value;
                        break;
                    case 3:
                        if (reader["M_User3"] != Convert.DBNull) dr["strUserColumn3"] = reader["M_User3"]; else dr["strUserColumn3"] = DBNull.Value;
                        break;
                    case 4:
                        if (reader["M_DivXTurkId"] != Convert.DBNull) dr["strUserColumn3"] = reader["M_DivXTurkId"]; else dr["strUserColumn3"] = DBNull.Value;
                        break;
                }


                if (reader["M_CatDate"] != Convert.DBNull) dr["dtDateEntered"] = reader["M_CatDate"]; else dr["dtDateEntered"] = DateTime.Now.Date;
                dr["strDubbing"] = DBNull.Value;
                dr["nRlsType"] = "1";
                dr["kMovies_Type"] = 1;

                ds2.Tables[0].Rows.Add(dr);

                ToolStripProgressBar.Value += 1;
                txtNo.Text = ToolStripProgressBar.Value.ToString();

                if (bEndProccess == true) return;

            }

            reader.Close();
            i = 0;
            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "12").Value;
            da2.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated3);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da2);

            da2.Update(ds2);

            ds2.Dispose();
            ds2 = null;
            da2.Dispose();

            ToolStripProgressBar.Value = 0;
            ToolStripProgressBar.Style = ProgressBarStyle.Blocks;
            this.Close();

            tFiles_DivxTurk();
        }


        public void tFiles_DivxTurk()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "13").Value;
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tFiles", con);
            DataSet ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source);

            int a = 0;

            for (a = 0; a <= dsFilesImportExport.Files.Rows.Count - 1; a++)
            {
                if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString()))
                {
                    Application.DoEvents();
                    DataRow dr = ds.Tables[0].NewRow();

                    dr["kMovie"] = dsFilesImportExport.Tables[0].Rows[a]["kMovie"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString())) dr["strFileName"] = dsFilesImportExport.Tables[0].Rows[a]["strFileName"]; else dr["strFileName"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"].ToString())) dr["strVideoCodec"] = dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"]; else dr["strVideoCodec"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"].ToString())) dr["strVideoBitrate"] = dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"]; else dr["strVideoBitrate"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strResolution"].ToString()))
                    {
                        Application.DoEvents();
                        string strR = dsFilesImportExport.Tables[0].Rows[a]["strResolution"].ToString();
                        if (strR.Length > 10)
                        {
                            dr["strResolution"] = strR.Substring(0, 10);
                        }
                        else
                        {
                            dr["strResolution"] = strR;
                        }
                    }
                    else
                    {
                        dr["strResolution"] = DBNull.Value;
                    }
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFps"].ToString())) dr["strFps"] = dsFilesImportExport.Tables[0].Rows[a]["strFps"]; else dr["strFps"] = DBNull.Value;

                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"].ToString())) dr["strAudioCodec1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels1"].ToString())) dr["strAudioChannels1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels1"];
                    if (Util.ValidCommand(dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate1"].ToString()) == true)
                    {
                        if (dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate1"].ToString() != "000") dr["strAudioBitrate1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate1"] + "000";
                    }
                    if (Util.ValidCommand(dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate1"].ToString()) == true)
                    {
                        if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate1"].ToString())) dr["strAudioSampleRate1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate1"];
                    }

                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec2"].ToString())) dr["strAudioCodec2"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec2"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels2"].ToString())) dr["strAudioChannels2"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels2"];
                    if (Util.ValidCommand(dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate2"].ToString()) == true)
                    {
                        if (dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate2"].ToString() != "000") dr["strAudioBitrate2"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate2"] + "000";
                    }
                    if (Util.ValidCommand(dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate2"].ToString()) == true)
                    {
                        if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate2"].ToString())) dr["strAudioSampleRate2"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate2"];
                    }


                    ds.Tables[0].Rows.Add(dr);
                }

                if (bEndProccess == true) return;

            }

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "14").Value;

            da.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated2);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da);
            da.Update(ds);
            ds.Dispose();
            ds = null;

            ToolStripProgressBar.Value = 0;
            ToolStripProgressBar.Style = ProgressBarStyle.Blocks;
            this.ToolStripStatusLabel1.Text = Language.FindKey("Messages", "15").Value;
            this.Close();
        }

        public void OnRowUpdated3(object sender, OleDbRowUpdatedEventArgs args)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", con);

            if (args.StatementType == StatementType.Insert)
            {
                Application.DoEvents();
                newID = (int)idCMD.ExecuteScalar();

                dc.CommandText = "SELECT AVIFiles.*, AVIFiles.A_MovieID FROM AVIFiles WHERE (((AVIFiles.A_MovieID)=" + exlist.Items[i].Text + "));";
                dc.Connection = con1;
                dc.CommandType = CommandType.Text;

                reader = dc.ExecuteReader();

                while (reader.Read())
                {
                    dsFilesImportExport.Files.AddFilesRow(newID.ToString(), "0",
                    reader["A_File"] == Convert.DBNull ? "" : reader["A_File"].ToString(),
                    reader["A_Width"] + " x " + reader["A_Height"].ToString(),
                    reader["A_VidCod"] == Convert.DBNull ? "" : reader["A_VidCod"].ToString(),
                    reader["A_VidBit"] == Convert.DBNull ? "" : reader["A_VidBit"].ToString(),
                    reader["A_FPS"] == Convert.DBNull ? "" : reader["A_FPS"].ToString(),
                    string.Empty,
                    reader["A_1AudCod"] == Convert.DBNull ? "" : reader["A_1AudCod"].ToString(),
                    reader["A_1AudCh"] == Convert.DBNull ? "" : reader["A_1AudCh"].ToString(),
                    reader["A_1AudBit"] == Convert.DBNull ? "" : reader["A_1AudBit"].ToString(),
                    reader["A_1AudSmp"] == Convert.DBNull ? "" : reader["A_1AudSmp"].ToString(),
                    "",
                    reader["A_2AudCod"] == Convert.DBNull ? "" : reader["A_2AudCod"].ToString(),
                    reader["A_2AudCh"] == Convert.DBNull ? "" : reader["A_2AudCh"].ToString(),
                    reader["A_2AudBit"] == Convert.DBNull ? "" : reader["A_2AudBit"].ToString(),
                    reader["A_2AudSmp"] == Convert.DBNull ? "" : reader["A_2AudSmp"].ToString(), "", "", "", "", "", 0);
                }

                reader.Close();

                if (System.IO.File.Exists(lstPicture.Items[i].Text)) System.IO.File.Copy(lstPicture.Items[i].Text, Application.StartupPath + "\\Images\\" + newID + ".jpg", true);
                i += 1;
            }
        }

        #endregion

        #region " All My Movies "

        public void AllMyMoviesComboFill()
        {
            cbArchivesNumber.Items.Add("");
            cbArchivesNumber.Items.Add("Film Numarası");
            cbArchivesNumber.Items.Add("Etiket");

            cbArchivesNumber.SelectedIndex = 0;
        }

        public void AllMyMoviesImport()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "11").Value;

            dc.CommandText = "SELECT * FROM movies ORDER BY originaltitle ASC;";
            dc.Connection = con1;
            dc.CommandType = CommandType.Text;

            reader = dc.ExecuteReader();

            OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM tMovies", con);
            DataSet ds2 = new DataSet();
            da2.FillSchema(ds2, SchemaType.Source);


            while (reader.Read())
            {
                Application.DoEvents();

                DataRow dr = ds2.Tables[0].NewRow();

                ToolStripStatusLabel1.Text = reader["originaltitle"].ToString();

                if (reader["originaltitle"] != Convert.DBNull) dr["strOrginalName"] = reader["originaltitle"]; else dr["strOrginalName"] = DBNull.Value;
                if (reader["name"] != Convert.DBNull) dr["strOtherName"] = reader["name"]; else dr["strOtherName"] = DBNull.Value;
                if (reader["year"] != Convert.DBNull)
                {
                    string strY = reader["year"].ToString();
                    if (strY.Length > 0) dr["strYear"] = strY.Substring(0, 4);
                }
                else
                {
                    dr["strYear"] = DBNull.Value;
                }
                if (reader["rating"] != Convert.DBNull) dr["strUserRating"] = StringReplace(reader["rating"].ToString()); else dr["strUserRating"] = DBNull.Value;
                if (reader["seen"] != Convert.DBNull) dr["bSeen"] = reader["seen"]; else dr["bSeen"] = false;

                if (reader["url"] != Convert.DBNull)
                {
                    string strImdbNumber = reader["url"].ToString();
                    if (strImdbNumber.StartsWith("http://www.imdb.com/title/tt") | strImdbNumber.StartsWith("http://us.imdb.com/title/tt") | strImdbNumber.StartsWith("http://us.imdb.com/Title?") | strImdbNumber.StartsWith("http://imdb.com/title/tt"))
                    {
                        strImdbNumber = strImdbNumber.Replace("http://www.imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("http://us.imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("http://us.imdb.com/Title?", "");
                        strImdbNumber = strImdbNumber.Replace("http://imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("/", "");

                        dr["strImdbNumber"] = strImdbNumber;
                    }
                }
                else
                {
                    dr["strImdbNumber"] = DBNull.Value;
                }
                if (reader["description"] != Convert.DBNull) dr["strEnglishPlot"] = reader["description"]; else dr["strEnglishPlot"] = DBNull.Value;

                if (cbArchivesNumber.SelectedIndex == 1) if (reader["movienum"] != Convert.DBNull) dr["strArchivesNumber"] = reader["movienum"]; else dr["strArchivesNumber"] = DBNull.Value;
                if (cbArchivesNumber.SelectedIndex == 2) if (reader["medialabel"] != Convert.DBNull) dr["strArchivesNumber"] = reader["medialabel"]; else dr["strArchivesNumber"] = DBNull.Value;


                if (reader["adddate"] != Convert.DBNull) dr["dtDateEntered"] = reader["adddate"]; else dr["dtDateEntered"] = DateTime.Now.Date;

                dr["strDubbing"] = DBNull.Value;
                dr["kMovies_Type"] = 1;

                ds2.Tables[0].Rows.Add(dr);

                ToolStripProgressBar.Value += 1;
                txtNo.Text = ToolStripProgressBar.Value.ToString();

                //**********************************************

                string strVideoInfo = reader["videoinfo"].ToString();
                string[] split1 = strVideoInfo.Split(new Char[] { '~' });
                string strVideoCodec = null;
                string strFPS = null;
                string strVideoBitrate = null;

                string s = null;
                int r = 0;
                foreach (string s_loopVariable in split1)
                {
                    s = s_loopVariable;
                    if (!string.IsNullOrEmpty(s.Trim()))
                    {
                        s = s.Trim();
                        if (r == 0) strVideoCodec = s;
                        if (r == 1) strFPS = s;
                        if (r == 3) strVideoBitrate = StringReplace(s);
                    }
                    r = r + 1;
                }

                string strAudioInfo = reader["audioinfo"].ToString();
                strAudioInfo = strAudioInfo.Replace(", ", "~");
                string[] split2 = strAudioInfo.Split(new Char[] { '~' });
                string strAudioCodec1 = null;
                string strAudioBitrate1 = null;
                string strAudioSampleRate1 = null;
                string strAudioChannels1 = null;

                s = string.Empty;
                r = 0;
                foreach (string s_loopVariable in split2)
                {
                    s = s_loopVariable;
                    if (!string.IsNullOrEmpty(s.Trim()))
                    {
                        s = s.Trim();
                        if (r == 0) strAudioCodec1 = s;
                        if (r == 1)
                        {
                            s = s.Substring(0, s.IndexOf(","));
                            strAudioBitrate1 = StringReplace(s) + "000";
                        }

                        if (r == 2) strAudioSampleRate1 = StringReplace(s);
                        if (r == 4) strAudioChannels1 = StringReplace(s);
                    }
                    r = r + 1;
                }


                string strFileName = reader["LocalPath"].ToString();
                string[] splitter = strFileName.Split('\\');
                strFileName = splitter[splitter.GetUpperBound(0)];

                dsFilesImportExport.Files.AddFilesRow("0", "0", strFileName,
                reader["resolution"] == Convert.DBNull ? "" : reader["resolution"].ToString(),
                strVideoCodec, strVideoBitrate, strFPS, string.Empty, strAudioCodec1, strAudioChannels1, strAudioBitrate1, strAudioSampleRate1,
                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 0);

                if (bEndProccess == true) return;

            }
            reader.Close();

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "12").Value;
            da2.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated4);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da2);
            da2.Update(ds2);

            ds2.Dispose();
            ds2 = null;
            da2.Dispose();

            tFiles_PivX();
        }

        public void OnRowUpdated4(object sender, OleDbRowUpdatedEventArgs args)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", con);

            if (args.StatementType == StatementType.Insert)
            {
                Application.DoEvents();
                newID = (int)idCMD.ExecuteScalar();
                dsFilesImportExport.Tables[0].Rows[i]["kMovie"] = newID;
                i += 1;
            }
        }

        #endregion

        #region " eXtreme Movie Manager "

        public void eXtremeMovieManagerImport()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "11").Value;

            dc.CommandText = "SELECT * FROM Movies ORDER BY OriginalTitle ASC;";
            dc.Connection = con1;
            dc.CommandType = CommandType.Text;

            reader = dc.ExecuteReader();

            OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM tMovies", con);
            DataSet ds2 = new DataSet();
            da2.FillSchema(ds2, SchemaType.Source);


            while (reader.Read())
            {
                Application.DoEvents();

                DataRow dr = ds2.Tables[0].NewRow();

                ToolStripStatusLabel1.Text = reader["OriginalTitle"].ToString();

                if (reader["OriginalTitle"] != Convert.DBNull) dr["strOrginalName"] = reader["OriginalTitle"]; else dr["strOrginalName"] = DBNull.Value;
                if (reader["Title"] != Convert.DBNull) dr["strOtherName"] = reader["Title"]; else dr["strOtherName"] = DBNull.Value;
                if (reader["Director"] != Convert.DBNull) dr["strDirector"] = reader["Director"]; else dr["strDirector"] = DBNull.Value;
                if (reader["Subgenre"] != Convert.DBNull) dr["strGenre"] = reader["Subgenre"]; else dr["strGenre"] = DBNull.Value;
                if (reader["Year"] != Convert.DBNull)
                {
                    string str = reader["Year"].ToString();
                    if (str.Length > 0) dr["strYear"] = str.Substring(0, 4);
                }
                else
                {
                    dr["strYear"] = DBNull.Value;
                }
                if (reader["Country"] != Convert.DBNull) dr["strCountry"] = reader["Country"]; else dr["strCountry"] = DBNull.Value;
                if (reader["Writer"] != Convert.DBNull) dr["strWriter"] = reader["Writer"]; else dr["strWriter"] = DBNull.Value;

                if (reader["Rating"] != Convert.DBNull) dr["strUserRating"] = reader["Rating"]; else dr["strUserRating"] = DBNull.Value;
                if (reader["Plot"] != Convert.DBNull) dr["strEnglishPlot"] = reader["Plot"]; else dr["strEnglishPlot"] = DBNull.Value;
                if (reader["OriginalLanguage"] != Convert.DBNull) dr["strLanguage"] = reader["OriginalLanguage"]; else dr["strLanguage"] = DBNull.Value;
                if (reader["Length"] != Convert.DBNull) dr["strRunningTime"] = reader["Length"]; else dr["strRunningTime"] = DBNull.Value;
                if (reader["CatalogNo"] != Convert.DBNull) dr["strArchivesNumber"] = reader["CatalogNo"]; else dr["strArchivesNumber"] = DBNull.Value;
                if (reader["PersonalRating"] != Convert.DBNull) dr["nPersonalRating"] = reader["PersonalRating"]; else dr["nPersonalRating"] = DBNull.Value;

                if (reader["WebLinkScript"] != Convert.DBNull)
                {
                    string strImdbNumber = reader["WebLinkScript"].ToString();
                    if (strImdbNumber.StartsWith("http://www.imdb.com/title/tt") | strImdbNumber.StartsWith("http://us.imdb.com/title/tt") | strImdbNumber.StartsWith("http://us.imdb.com/Title?") | strImdbNumber.StartsWith("http://imdb.com/title/tt"))
                    {
                        strImdbNumber = strImdbNumber.Replace("http://www.imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("http://us.imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("http://us.imdb.com/Title?", "");
                        strImdbNumber = strImdbNumber.Replace("http://imdb.com/title/tt", "");
                        strImdbNumber = strImdbNumber.Replace("/", "");

                        dr["strImdbNumber"] = strImdbNumber;
                    }
                }
                else
                {
                    dr["strImdbNumber"] = DBNull.Value;
                }

                if (reader["Cover"] != Convert.DBNull)
                {
                    string[] splitter = null;
                    string shortName = null;
                    string folder = null;

                    splitter = FileLocation.Split('\\');
                    shortName = splitter[splitter.GetUpperBound(0)];

                    folder = FileLocation.Replace(shortName, "");
                    shortName = shortName.Replace(".mdb", "");
                    folder = folder + shortName + "_cover";

                    lstPicture.Items.Add(folder + "\\" + reader["Cover"]);
                }
                else
                {
                    lstPicture.Items.Add("0");
                }

                if (reader["Actors"] != Convert.DBNull) dr["strCast"] = RemoveImdbNumber(EmitCast(reader["Actors"].ToString())); else dr["strCast"] = DBNull.Value;
                if (reader["seen"] != Convert.DBNull) dr["bSeen"] = reader["seen"]; else dr["bSeen"] = false;

                if (reader["DateInsert"] != Convert.DBNull)
                {
                    string ee = reader["DateInsert"].ToString();
                    dr["dtDateEntered"] = DateTime.Now.Date;
                }
                else
                {
                    dr["dtDateEntered"] = DateTime.Now.Date;
                }
                dr["strDubbing"] = DBNull.Value;
                dr["kMovies_Type"] = 1;

                ds2.Tables[0].Rows.Add(dr);

                ToolStripProgressBar.Value += 1;
                txtNo.Text = ToolStripProgressBar.Value.ToString();

                dsFilesImportExport.Files.AddFilesRow("0", "0",
                reader["MovieFile1"] == Convert.DBNull ? "" : reader["MovieFile1"].ToString(),
                reader["Resolution"].ToString(),
                reader["Codec"] == Convert.DBNull ? "" : reader["Codec"].ToString(),
                reader["Bitrate"] == Convert.DBNull ? "" : reader["Bitrate"].ToString(),
                reader["FPS"] == Convert.DBNull ? "" : reader["FPS"].ToString(),
                string.Empty,
                reader["AudioCodec"] == Convert.DBNull ? "" : reader["AudioCodec"].ToString(),
                reader["Channels"] == Convert.DBNull ? "" : reader["Channels"].ToString(),
                reader["AudioBitRate"] == Convert.DBNull ? "" : reader["AudioBitRate"].ToString(),
                reader["SampleRate"] == Convert.DBNull ? "" : reader["SampleRate"].ToString(),
                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 0);

                if (bEndProccess == true) return;

            }
            reader.Close();

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "12").Value;
            da2.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da2);
            da2.Update(ds2);

            ds2.Dispose();
            ds2 = null;
            da2.Dispose();

            exlist.Items.Clear();
            tFiles_eXtremeMovieManager();
        }

        public string RemoveImdbNumber(string strCast)
        {
            string functionReturnValue = null;
            // ERROR: Not supported in C#: OnErrorStatement

            string[] split1 = strCast.Split(new Char[] { '#' });
            string Remove = string.Empty;
            functionReturnValue = null;

            string s = null;
            //int r = 0;

            foreach (string s_loopVariable in split1)
            {
                s = s_loopVariable;
                if (!string.IsNullOrEmpty(s.Trim()))
                {
                    s = s.Trim();
                    Remove = s.Substring(s.IndexOf("@"), s.Length - s.IndexOf("@"));
                    s = s.Replace(Remove, "@");
                    functionReturnValue += s;
                }
            }
            return functionReturnValue;
        }


        public void tFiles_eXtremeMovieManager()
        {
            Application.DoEvents();
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "13").Value;
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tFiles", con);
            DataSet ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source);

            int a = 0;

            for (a = 0; a <= dsFilesImportExport.Files.Rows.Count - 1; a++)
            {
                if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString()))
                {
                    Application.DoEvents();
                    DataRow dr = ds.Tables[0].NewRow();

                    dr["kMovie"] = dsFilesImportExport.Tables[0].Rows[a]["kMovie"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFileName"].ToString())) dr["strFileName"] = dsFilesImportExport.Tables[0].Rows[a]["strFileName"]; else dr["strFileName"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"].ToString())) dr["strVideoCodec"] = dsFilesImportExport.Tables[0].Rows[a]["strVideoCodec"]; else dr["strVideoCodec"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"].ToString())) dr["strVideoBitrate"] = StringReplace(dsFilesImportExport.Tables[0].Rows[a]["strVideoBitrate"].ToString()); else dr["strVideoBitrate"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate1"].ToString())) dr["strAudioSampleRate1"] = StringReplace(dsFilesImportExport.Tables[0].Rows[a]["strAudioSampleRate1"].ToString()) + "000"; else dr["strAudioSampleRate1"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate1"].ToString())) dr["strAudioBitrate1"] = StringReplace(dsFilesImportExport.Tables[0].Rows[a]["strAudioBitrate1"].ToString()) + "000"; else dr["strAudioBitrate1"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strResolution"].ToString())) dr["strResolution"] = dsFilesImportExport.Tables[0].Rows[a]["strResolution"]; else dr["strResolution"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strFps"].ToString())) dr["strFps"] = StringReplace(dsFilesImportExport.Tables[0].Rows[a]["strFps"].ToString()); else dr["strFps"] = DBNull.Value;
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"].ToString())) dr["strAudioCodec1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioCodec1"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels1"].ToString())) dr["strAudioChannels1"] = dsFilesImportExport.Tables[0].Rows[a]["strAudioChannels1"];
                    if (!string.IsNullOrEmpty(dsFilesImportExport.Tables[0].Rows[a]["strTotalFrames"].ToString())) dr["strTotalFrames"] = dsFilesImportExport.Tables[0].Rows[a]["strTotalFrames"];


                    ds.Tables[0].Rows.Add(dr);
                }

                if (bEndProccess == true) return;

            }

            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ToolStripStatusLabel1.Text = Language.FindKey("Messages", "14").Value;

            da.RowUpdated += new OleDbRowUpdatedEventHandler(OnRowUpdated2);
            OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(da);
            da.Update(ds);
            ds.Dispose();
            ds = null;

            ToolStripProgressBar.Value = 0;
            ToolStripProgressBar.Style = ProgressBarStyle.Blocks;
            this.ToolStripStatusLabel1.Text = Language.FindKey("Messages", "15").Value;
            this.Close();
        }

        #endregion

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.cbArchivesNumber.Enabled = false;
            this.cbSeen.Enabled = false;
            this.btnImport.Enabled = false;
            cbUserColumn1.Enabled = false;
            cbUserColumn2.Enabled = false;
            cbUserColumn3.Enabled = false;
            cbUserColumn4.Enabled = false;

            switch (FormType)
            {
                case formType.Diviks:
                    DiviksImport();
                    break;
                case formType.DivxTurk:
                    DivxTurkImport();
                    break;
                case formType.PivX:
                    PivXImport();
                    break;
                case formType.DivxARC:
                    DivxARCImport();
                    break;
                case formType.AllMyMovies:
                    AllMyMoviesImport();
                    break;
                case formType.eXtremeMovieManager:
                    eXtremeMovieManagerImport();
                    break;
                default:
                    break;
            }
        }

        public void OnRowUpdated(object sender, OleDbRowUpdatedEventArgs args)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", con);

            if (args.StatementType == StatementType.Insert)
            {
                Application.DoEvents();
                newID = (int)idCMD.ExecuteScalar();
                dsFilesImportExport.Tables[0].Rows[i]["kMovie"] = newID;
                if (System.IO.File.Exists(lstPicture.Items[i].Text)) System.IO.File.Copy(lstPicture.Items[i].Text, Application.StartupPath + "\\Images\\" + newID + ".jpg", true);
                i += 1;
            }
        }

        public void OnRowUpdated2(object sender, OleDbRowUpdatedEventArgs args)
        {
            Application.DoEvents();
        }

        public string EmitCast(string strCast)
        {
            string functionReturnValue = null;
            strCast = strCast.Replace("\r", "@");
            //strCast = Strings.Replace(strCast, Constants.vbCr, "@");
            //strCast = (Strings.Replace(strCast, Constants.vbLf, ""));
            strCast = strCast.Replace(" · ", "@");
            strCast = strCast.Replace(" - ", "@");
            strCast = strCast.Replace("[", "@");
            strCast = strCast.Replace("];", "@");
            strCast = strCast.Replace("[];", "@");
            strCast = strCast.Replace(" , ", "@");
            strCast = strCast.Replace("|", "@");
            strCast = strCast.Replace("§", "");
            strCast = strCast.Trim();

            string[] split1 = strCast.Split(new Char[] { '@' });
            functionReturnValue = null;

            string s = null;
            int r = 0;

            foreach (string s_loopVariable in split1)
            {
                s = s_loopVariable;
                if (!string.IsNullOrEmpty(s.Trim()))
                {
                    s = s.Trim();
                    s = s.Trim(new Char[] { '#' });
                    if (r == 0) functionReturnValue += s + ";";
                    if (r == 1) functionReturnValue += s + "@";
                }
                r = r + 1;
                if (r == 2) r = 0;
            }
            return functionReturnValue;
        }

        public string StringReplace(string str)
        {
            str = str.Replace(" kbit/s", "");
            str = str.Replace(" Hz", "");
            str = str.Replace(" Kbit/s", "");
            str = str.Replace(" FPS", "");
            str = str.Replace(" min", "");
            str = str.Replace(" dk.", "");
            str = str.Replace(",", ".");
            str = str.Replace("/", "");
            str = str.Replace(" channel(s)", "");
            str = str.Replace(" Kbps", "");
            str = str.Replace(" KHz", "");

            return str;
        }

        public void FormSize(int Width, int Height)
        {
            this.Height = Height;
            this.Width = Width;
            this.Refresh();
        }

        private void frmImportExport_FormClosed(object sender, FormClosedEventArgs e)
        {
            con1.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bEndProccess = true;
            if (reader != null)
            {
                if (reader.IsClosed == false) reader.Close();
            }

            this.Close();
            Application.DoEvents();

            MessageBox.Show(Language.FindKey("Messages", "17").Value);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FO = new FolderBrowserDialog();
            FO.Description = "Resimlerin olduğu klasörü seçiniz.";

            if (FO.ShowDialog() == DialogResult.OK)
            {
                strPictureFolder = FO.SelectedPath;
                MessageBox.Show("Resimler " + strPictureFolder + " klasöründen alınacaktır.");
            }
        }
    }

}
