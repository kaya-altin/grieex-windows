using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using System.Diagnostics;
using System.IO;
using GrieeX.GrieeXBase;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraBars.Helpers;
using System.Data.SQLite;
using System.Reflection;
using System.Threading.Tasks;




namespace GrieeX.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            try
            {
                this.defaultLookAndFeel.LookAndFeel.ActiveLookAndFeel.SetSkinStyle(Settings.ActiveSkinName);
                dGrid.MainView.RestoreLayoutFromXml(Application.StartupPath + "\\Layouts\\GridView.xml");
                dockManager1.RestoreLayoutFromXml(Application.StartupPath + "\\Layouts\\Form.xml");

                if (!Directory.Exists(GrieeXSettings.TempPath))
                    Directory.CreateDirectory(GrieeXSettings.TempPath);

                if (!Directory.Exists(GrieeXSettings.CastPath))
                    Directory.CreateDirectory(GrieeXSettings.CastPath);

                if (!Directory.Exists(GrieeXSettings.PosterPath))
                    Directory.CreateDirectory(GrieeXSettings.PosterPath);

                if (File.Exists(Application.StartupPath + "\\Database\\GrieeX.db.repair"))
                {
                    if (File.Exists(Application.StartupPath + "\\Database\\GrieeX." + DateTime.Now.ToShortDateString() + ".db.backup"))
                        File.Delete(Application.StartupPath + "\\Database\\GrieeX." + DateTime.Now.ToShortDateString() + ".db.backup");

                    File.Move(Application.StartupPath + "\\Database\\GrieeX.db", Application.StartupPath + "\\Database\\GrieeX." + DateTime.Now.ToShortDateString() + ".db.backup");

                    if (File.Exists(Application.StartupPath + "\\Database\\GrieeX.db"))
                        File.Delete(Application.StartupPath + "\\Database\\GrieeX.db");

                    File.Move(Application.StartupPath + "\\Database\\GrieeX.db.repair", Application.StartupPath + "\\Database\\GrieeX.db");             
                }


                if (!File.Exists(Application.StartupPath + "\\Database\\GrieeX.db"))
                {
                    Util.WriteResourceToFile("GrieeX.GrieeX.db", Application.StartupPath + "\\Database\\GrieeX.db");
                }


                if (File.Exists(Application.StartupPath + "\\Database\\dbGrieeX.mdb"))
                {
                    frmUpdater frm = new frmUpdater();
                    frm.Show();
                }

                if (Util.NewVersionFound())
                {
                    frmDatabaseUpdater frmU = new frmDatabaseUpdater();
                    frmU.Show();
                }
                //if (File.Exists(Application.StartupPath+"\\Database\\GrieeX.tmp"))
                //{
                //    File.Delete(Application.StartupPath + "\\Database\\GrieeX.db");
                //    File.Move(Application.StartupPath + "\\Database\\GrieeX.tmp", Application.StartupPath + "\\Database\\GrieeX.db");
                //}
            }
            catch (Exception e)
            {
            }

            EmitLanguage();
        }

        private static frmMain _GlobalForm;
        public static frmMain GlobalForm
        {
            get
            {
                if (_GlobalForm == null || _GlobalForm.IsDisposed)
                {
                    _GlobalForm = new frmMain();
                }
                return _GlobalForm;
            }
            set { _GlobalForm = value; }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

            GlobalForm = this;

            MovieDetail.btnSave.Visible = true;
            if (dockPanel2.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
            {
                chkMovieDetail.Checked = true;
                chkMovieDetail.Caption = Language.FindKey("Buttons", "41").Value.ToString();
            }
            else
            {
                chkMovieDetail.Checked = false;
                chkMovieDetail.Caption = Language.FindKey("Buttons", "40").Value.ToString();
            }

            cbFilterType.Strings.Add(Language.FindKey("Strings", "103").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "1").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "2").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "3").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "5").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "49").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "4").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "6").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "36").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "35").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "10").Value);
            cbFilterType.Strings.Add(Language.FindKey("Strings", "11").Value);
            if (!string.IsNullOrEmpty(Settings.UserColumn1)) { cbFilterType.Strings.Add(Settings.UserColumn1); } else { cbFilterType.Strings.Add(Language.FindKey("Strings", "66").Value); }
            if (!string.IsNullOrEmpty(Settings.UserColumn2)) { cbFilterType.Strings.Add(Settings.UserColumn2); } else { cbFilterType.Strings.Add(Language.FindKey("Strings", "67").Value); }
            if (!string.IsNullOrEmpty(Settings.UserColumn3)) { cbFilterType.Strings.Add(Settings.UserColumn3); } else { cbFilterType.Strings.Add(Language.FindKey("Strings", "68").Value); }
            if (!string.IsNullOrEmpty(Settings.UserColumn4)) { cbFilterType.Strings.Add(Settings.UserColumn4); } else { cbFilterType.Strings.Add(Language.FindKey("Strings", "69").Value); }
            if (!string.IsNullOrEmpty(Settings.UserColumn5)) { cbFilterType.Strings.Add(Settings.UserColumn5); } else { cbFilterType.Strings.Add(Language.FindKey("Strings", "151").Value); }
            if (!string.IsNullOrEmpty(Settings.UserColumn6)) { cbFilterType.Strings.Add(Settings.UserColumn6); } else { cbFilterType.Strings.Add(Language.FindKey("Strings", "152").Value); }


            if (cl_UserColumn1.Visible == true & !string.IsNullOrEmpty(Settings.UserColumn1)) { cl_UserColumn1.Caption = Settings.UserColumn1; }
            if (cl_UserColumn2.Visible == true & !string.IsNullOrEmpty(Settings.UserColumn2)) { cl_UserColumn2.Caption = Settings.UserColumn2; }
            if (cl_UserColumn3.Visible == true & !string.IsNullOrEmpty(Settings.UserColumn3)) { cl_UserColumn3.Caption = Settings.UserColumn3; }
            if (cl_UserColumn4.Visible == true & !string.IsNullOrEmpty(Settings.UserColumn4)) { cl_UserColumn4.Caption = Settings.UserColumn4; }
            if (cl_UserColumn5.Visible == true & !string.IsNullOrEmpty(Settings.UserColumn5)) { cl_UserColumn5.Caption = Settings.UserColumn5; }
            if (cl_UserColumn6.Visible == true & !string.IsNullOrEmpty(Settings.UserColumn6)) { cl_UserColumn6.Caption = Settings.UserColumn6; }

            slDate.Caption = DateTime.Now.Date.ToString("dd/MM/yyyy");
            slVersion.Caption = "v " + Util.GrieeXVersion;
            beiLanguage.EditValue = Settings.Language;


            if (Settings.StartUpVersionControl == true)
            {
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += new DoWorkEventHandler(bw_DoWork);
                bw.RunWorkerAsync();

            }

            //frmWD frm = new frmWD();
            //frm.Show();

            //using (SQLiteConnection con = new SQLiteConnection(GrieeXSettings.DataSource))
            //{
            //    using (SQLiteCommand cmd = new SQLiteCommand())
            //    {
            //        con.Open();
            //        cmd.Connection = con;

            //        SQLiteHelper sh = new SQLiteHelper(cmd);
            //        DataTable dt = sh.Select("Select * From Movies");

            //        foreach (DataRow item in dt.Rows)
            //        {
            //            String[] arys = item["ArchivesNumber"].ToString().Split(new[] { "-" }, StringSplitOptions.None);

            //            var dic = new Dictionary<string, object>();
            //            dic["UserColumn1"] = arys[0];
            //            dic["ArchivesNumber"] = arys[1];
            //            sh.Update("Movies", dic, "_id", item["_id"]);
            //        }


            //        con.Close();
            //    }
            //}

        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Util.CheckForUpdate(false);
        }


        private void frmMain_Shown(object sender, EventArgs e)
        {
            //InitSkinGallery();
            SkinHelper.InitSkinGallery(rgbiSkins, true);
            Search();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dGrid.MainView.SaveLayoutToXml(Application.StartupPath + "\\Layouts\\GridView.xml");
            dockManager1.SaveLayoutToXml(Application.StartupPath + "\\Layouts\\Form.xml");
            Settings.ActiveSkinName = this.defaultLookAndFeel.LookAndFeel.ActiveLookAndFeel.ActiveSkinName;
            Settings.Save();

            Util.EmptyTemp();
        }

        #region SkinGallery
        void InitSkinGallery()
        {
            SimpleButton imageButton = new SimpleButton();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName);
                GalleryItem gItem = new GalleryItem();
                int groupIndex = 0;
                if (cnt.SkinName.IndexOf("Office") > -1) groupIndex = 1;
                rgbiSkins.Gallery.Groups[groupIndex].Items.Add(gItem);
                gItem.Caption = cnt.SkinName;

                gItem.Image = GetSkinImage(imageButton, 32, 17, 2);
                gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5);
                gItem.Caption = cnt.SkinName;
                gItem.Hint = cnt.SkinName;
                rgbiSkins.Gallery.Groups[1].Visible = false;
            }
        }
        Bitmap GetSkinImage(SimpleButton button, int width, int height, int indent)
        {
            Bitmap image = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(image))
            {
                StyleObjectInfoArgs info = new StyleObjectInfoArgs(new GraphicsCache(g));
                info.Bounds = new Rectangle(0, 0, width, height);
                button.LookAndFeel.Painter.GroupPanel.DrawObject(info);
                button.LookAndFeel.Painter.Border.DrawObject(info);
                info.Bounds = new Rectangle(indent, indent, width - indent * 2, height - indent * 2);
                button.LookAndFeel.Painter.Button.DrawObject(info);
            }
            return image;
        }
        private void rgbiSkins_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption);
        }

        private void rgbiSkins_Gallery_InitDropDownGallery(object sender, DevExpress.XtraBars.Ribbon.InplaceGalleryEventArgs e)
        {
            e.PopupGallery.CreateFrom(rgbiSkins.Gallery);
            e.PopupGallery.AllowFilter = false;
            e.PopupGallery.ShowItemText = true;
            e.PopupGallery.ShowGroupCaption = true;
            e.PopupGallery.AllowHoverImages = false;
            foreach (GalleryItemGroup galleryGroup in e.PopupGallery.Groups)
                foreach (GalleryItem item in galleryGroup.Items)
                    item.Image = item.HoverImage;
            e.PopupGallery.ColumnCount = 2;
            e.PopupGallery.ImageSize = new Size(70, 36);
        }
        #endregion

        #region " Form Events "

        public void Search()
        {
            try
            {
                string strSQL, strWhere = string.Empty;
                int n = 0;
                strWhere = " WHERE ";

                strSQL = "SELECT Movies._id, Movies.Seen, Movies.OrginalName, Movies.OtherName, Movies.Director, Movies.Writer, Movies.Year, Movies.RunningTime,  CAST(Movies.ArchivesNumber as INTEGER) as ArchivesNumber, Movies.UserRating, CAST(Movies.Votes as INTEGER) as Votes, Movies.Country, Movies.Language, Movies.Genre, Movies.Budget, Movies.ProductionCompany, Movies.Subtitle, Movies.Dubbing, Movies.ImdbNumber, Movies.PersonalRating, Movies.UserColumn1, Movies.UserColumn2, Movies.UserColumn3, Movies.UserColumn4, Movies.UserColumn5, Movies.UserColumn6, Movies.RlsType, Movies.RlsGroup, Movies.InsertDate, (SELECT COUNT(*) FROM Files Where Files.MovieID=Movies._id) AS FileCount, (SELECT SUM(CAST(FileSize AS DOUBLE)) / 1048576 FROM Files Where Files.MovieID=Movies._id) AS FileSize";
                strSQL += " FROM Movies ";


                if (txtFilter.EditValue != null)
                {
                    if (!string.IsNullOrEmpty(txtFilter.EditValue.ToString()))
                    {
                        switch (cbFilterType.ItemIndex)
                        {
                            case 0:
                                strWhere += (n == 1 ? " and " : "") +
                                    "Movies.OrginalName like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.ImdbNumber like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.OtherName like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.Director like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.Writer like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies._id in (SELECT ObjectID FROM Casts Where Casts.CollectionType=1 and Casts.Name like '%" + txtFilter.EditValue.ToString() + "%') OR " +
                                    "Movies.Genre like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.Year like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.ArchivesNumber like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.Language like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.Country like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.UserColumn1 like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.UserColumn2 like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.UserColumn3 like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.UserColumn4 like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.UserColumn5 like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.UserColumn6 like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.RlsType like '%" + txtFilter.EditValue.ToString() + "%' OR " +
                                    "Movies.RlsGroup like '%" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 1:
                                strWhere += (n == 1 ? "and " : "") + "Movies.OrginalName like '" + "%" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 2:
                                strWhere += (n == 1 ? "and " : "") + "Movies.OtherName like '" + "%" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 3:
                                strWhere += (n == 1 ? "and " : "") + "Movies.Director like '" + "%" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 4:
                                strWhere += (n == 1 ? "and " : "") + "Movies.Writer like '" + "%" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 5:
                                strWhere += (n == 1 ? "and " : "") + "Movies._id in (SELECT ObjectID FROM Casts Where Casts.CollectionType=1 and Casts.Name like '" + "%" + txtFilter.EditValue.ToString() + "%')";
                                n = 1;
                                break;
                            case 6:
                                strWhere += (n == 1 ? "and " : "") + "Movies.Genre Like '%" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 7:
                                strWhere += (n == 1 ? "and " : "") + "Movies.Year like '" + txtFilter.EditValue.ToString() + "'";
                                n = 1;
                                break;
                            case 8:
                                strWhere += (n == 1 ? "and " : "") + "Movies.ArchivesNumber like '" + "%" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 9:
                                strWhere += (n == 1 ? "and " : "") + "Movies.ImdbNumber like '" + "%" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 10:
                                strWhere += (n == 1 ? "and " : "") + "Movies.Language like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 11:
                                strWhere += (n == 1 ? "and " : "") + "Movies.Country like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 12:
                                strWhere += (n == 1 ? "and " : "") + "Movies.UserColumn1 like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 13:
                                strWhere += (n == 1 ? "and " : "") + "Movies.UserColumn2 like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 14:
                                strWhere += (n == 1 ? "and " : "") + "Movies.UserColumn3 like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 15:
                                strWhere += (n == 1 ? "and " : "") + "Movies.UserColumn4 like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 16:
                                strWhere += (n == 1 ? "and " : "") + "Movies.UserColumn5 like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 17:
                                strWhere += (n == 1 ? "and " : "") + "Movies.UserColumn6 like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 18:
                                strWhere += (n == 1 ? "and " : "") + "Movies.RlsType like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            case 19:
                                strWhere += (n == 1 ? "and " : "") + "Movies.RlsGroup like '" + txtFilter.EditValue.ToString() + "%'";
                                n = 1;
                                break;
                            default:
                                break;
                        }
                    }

                }

                if (n == 1)
                    strSQL = strSQL + strWhere;

                using (SQLiteConnection con = new SQLiteConnection(GrieeXSettings.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        con.Open();
                        cmd.Connection = con;

                        SQLiteHelper sh = new SQLiteHelper(cmd);
                        dGrid.DataSource = sh.Select(strSQL);

                        try
                        {
                            String strImdbAverage = sh.ExecuteScalar("SELECT avg(Movies.UserRating) FROM Movies").ToString();
                            decimal dImdbAverage = Decimal.Parse(strImdbAverage);

                            slImdbAverage.Caption = Language.FindKey("Strings", "98").Value + ": " + dImdbAverage.ToString("#.##"); ;
                        }
                        catch (Exception)
                        {
                        }


                        con.Close();
                    }
                }


            }
            catch (Exception ex)
            {
            }
        }

        private void KeyEvent(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //If txtOrginalName.Focused = True Or txtTurkishName.Focused = True Or txtYear.Focused = True Or txtDirector.Focused = True Or txtArchivesNumber.Focused = True Or txtCast.Focused = True Then Search()

            if (e.KeyCode == Keys.Delete)
            {
                if (dGrid.Focused == true) btnDelete.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                Search();
            }
            if (dGrid.Focused == true & gvList.RowCount > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dGrid_DoubleClick(sender, e);
                }
            }

        }

        private void gvList_RowCountChanged(object sender, EventArgs e)
        {
            slRowCount.Caption = Language.FindKey("Strings", "57").Value + ": " + dGrid.MainView.RowCount + "   ";
        }

        private void gvList_ColumnFilterChanged(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            foreach (GridColumn col in view.Columns)
            {
                string filter = string.Format("[{0}] Is Null", col.FieldName);
                if (filter == col.FilterInfo.FilterString)
                {
                    filter = string.Format("{0} Or [{1}] == ''", filter, col.FieldName);
                    col.FilterInfo = new ColumnFilterInfo(filter);
                }
            }
        }

        private void gvList_ShowCustomizationForm(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            view.CustomizationForm.Text = Language.FindKey("Menu", "11").Value;
        }

        private void gvList_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            if (Settings.Language == "Turkish")
            {
                if (e.MenuType == GridMenuType.Column)
                {
                    for (int i = 0; i < e.Menu.Items.Count; i++)

                        switch (e.Menu.Items[i].Caption)
                        {
                            case "Sort Ascending":
                                e.Menu.Items[i].Caption = "Artan Sýralama";
                                break;
                            case "Sort Descending":
                                e.Menu.Items[i].Caption = "Azalan Sýralama";
                                break;
                            case "Clear Sorting":
                                e.Menu.Items[i].Caption = "Sýralamayý Temizle";
                                break;
                            case "Group By This Column":
                                e.Menu.Items[i].Caption = "Bu Kolona Göre Grupla";
                                break;
                            case "Show Group By Box":
                                e.Menu.Items[i].Caption = "Grup Kutusunu Göster/Gizle";
                                break;
                            case "Hide Group By Box":
                                e.Menu.Items[i].Caption = "Grup Kutusunu Gizle";
                                break;
                            case "Remove This Column":
                                e.Menu.Items[i].Caption = "Bu Kolonu Gizle";
                                break;
                            case "Column Chooser":
                                e.Menu.Items[i].Caption = "Kolon Seçici";
                                break;
                            case "Best Fit":
                                e.Menu.Items[i].Caption = "Azalan Sýralama";
                                break;
                            case "Filter Editor...":
                                e.Menu.Items[i].Caption = "Geliþmiþ Filitre";
                                break;
                            case "Best Fit (all columns)":
                                e.Menu.Items[i].Caption = "En Ýyi Yerleþim (tüm kolonlar)";
                                break;
                            default:
                                break;
                        }
                }
            }
        }

        private void gvList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvList.RowCount == 0)
            {
                MovieDetail.Clear();
                return;
            }

            if (gvList.SelectedRowsCount != 0)
            {
                if (gvList.GetRowCellValue(gvList.GetSelectedRows()[0], cl_MovieID) != null)
                    MovieDetail.RecordShow(gvList.GetRowCellValue(gvList.GetSelectedRows()[0], cl_MovieID).ToString());

                slkMovie.Caption = Language.FindKey("Strings", "61").Value + ": " + MovieDetail.CurrentMovie.MovieID.ToString();

                btnPlay.ItemLinks.Clear();

                //Durmuþ
                //for (int i = 0; i < MovieDetail.dsFiles.tFiles.Rows.Count; i++)
                //{
                //    BarItem iMovie = new DevExpress.XtraBars.BarButtonItem();
                //    iMovie.Glyph = global::GrieeX.Properties.Resources.MovieFile;
                //    iMovie.Caption = MovieDetail.dsFiles.tFiles.Rows[i]["FileName"].ToString();
                //    iMovie.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPlay_ItemClick);
                //    btnPlay.ItemLinks.Add(iMovie);
                //}

            }
        }

        private void btnPlay_Click(object sender, ItemClickEventArgs e)
        {
            if (MovieDetail.dsFiles.Files.Rows.Count == 1)
            {
                string strFile = MovieDetail.dsFiles.Files.Rows[0]["FileName"].ToString().Replace("’", "'");
                Util.PlayVideo(strFile);
            }
        }

        private void btnPlay_ItemClick(object sender, ItemClickEventArgs e)
        {
            Util.PlayVideo(e.Item.Caption);
        }


        private void dGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmMovie.GlobalForm.MovieDetail.rType = Enums.RecordType.Update;
                frmMovie.GlobalForm.Show();
                frmMovie.GlobalForm.MovieDetail.RecordShow(gvList.GetRowCellValue(gvList.GetSelectedRows()[0], cl_MovieID).ToString());
            }
            catch (Exception)
            {
                //    XtraMessageBox.Show(exp.Message.ToString());
            }
        }

        private void DoUpdateViewStyle(string viewName)
        {
            DevExpress.XtraGrid.Views.Base.BaseView oldView = dGrid.MainView;
            dGrid.MainView = dGrid.CreateView(viewName);
            if (oldView != null) oldView.Dispose();

        }

        private void slLink_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.griee.com");
        }

        private void chkMovieDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dockPanel2.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
            {
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                chkMovieDetail.Checked = false;
                chkMovieDetail.Caption = Language.FindKey("Buttons", "40").Value.ToString();
            }
            else
            {
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                chkMovieDetail.Checked = true;
                chkMovieDetail.Caption = Language.FindKey("Buttons", "41").Value.ToString();
            }
        }

        private void gvList_ShowFilterPopupListBox(object sender, FilterPopupListBoxEventArgs e)
        {
            if (Settings.Language == "Turkish")
            {
                for (int i = 0; i < e.ComboBox.Items.Count; i++)
                {
                    try
                    {
                        switch (((FilterItem)e.ComboBox.Items[i]).Text)
                        {
                            case "(All)":
                                ((FilterItem)e.ComboBox.Items[i]).Text = "(Tümü)";
                                break;
                            case "(Custom)":
                                ((FilterItem)e.ComboBox.Items[i]).Text = "(Geliþmiþ)";
                                break;
                            case "(Blanks)":
                                ((FilterItem)e.ComboBox.Items[i]).Text = "(Boþ Olanlar)";
                                break;
                            case "(Non blanks)":
                                ((FilterItem)e.ComboBox.Items[i]).Text = "(Boþ Olmayanlar)";
                                break;
                            case "Checked":
                                ((FilterItem)e.ComboBox.Items[i]).Text = "Ýzlendi";
                                break;
                            case "Unchecked":
                                ((FilterItem)e.ComboBox.Items[i]).Text = "Ýzlenmedi";
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void txtFilter_EditValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbFilterType_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            if (txtFilter.EditValue != null)
            {
                if (!string.IsNullOrEmpty(txtFilter.EditValue.ToString()))
                {
                    Search();
                }
            }
        }




        #endregion

        #region " Buttons Events "

        //private string NewArchivesNumber()
        //{
        //    string strArchivesNumber = Data.Execute("SELECT Max(CLng(tMovies.strArchivesNumber)) FROM tMovies HAVING (((IsNumeric([tMovies].[strArchivesNumber]))<>0));", Data.ReturnType.Scalar).ToString();

        //    if (strArchivesNumber == "")
        //    {
        //        strArchivesNumber = "1";
        //    }
        //    else
        //    {
        //        strArchivesNumber = Convert.ToString(Convert.ToInt32(strArchivesNumber) + 1);
        //    }

        //    return strArchivesNumber;
        //}

        private void btnAddWithFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMovie frm = new frmMovie();
            frm.btnDelete.Enabled = false;
            frm.btnNext.Enabled = false;
            frm.btnPrevious.Enabled = false;
            frm.MovieDetail.rType = Enums.RecordType.Insert;
            //frm.MovieDetail.txtArchivesNumber.Text = NewArchivesNumber();
            frm.Show();
            frm.MovieDetail.FileOpen();
        }

        private void btnAddManual_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmMovie frm = new frmMovie();
            frm.btnDelete.Enabled = false;
            frm.btnNext.Enabled = false;
            frm.btnPrevious.Enabled = false;
            frm.MovieDetail.rType = Enums.RecordType.Insert;
            //frm.MovieDetail.txtArchivesNumber.Text = NewArchivesNumber();
            frm.Show();
        }

        private void btnMultiFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMultiFile frm = new frmMultiFile();
            frm.FormType = frmMultiFile.ft.Multi;
            frm.ShowDialog();
            Search();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvList.RowCount == 0) return;

            if (gvList.SelectedRowsCount != 0)
            {
                frmMovie.GlobalForm.MovieDetail.rType = Enums.RecordType.Update;
                frmMovie.GlobalForm.Show();
                frmMovie.GlobalForm.MovieDetail.RecordShow(gvList.GetRowCellValue(gvList.GetSelectedRows()[0], cl_MovieID).ToString());
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            try
            {
                if (gvList.RowCount == 0 | gvList.GetSelectedRows().Length == 0)
                    return;



                if (gvList.SelectedRowsCount > 1)
                {
                    if (XtraMessageBox.Show(Language.FindKey("Messages", "10").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int i = 0;
                        for (i = 0; i <= gvList.SelectedRowsCount - 1; i++)
                        {
                            String _id = gvList.GetRowCellValue(gvList.GetSelectedRows()[i], cl_MovieID).ToString();
                            String ImdbNumber = gvList.GetRowCellValue(gvList.GetSelectedRows()[0], cl_ImdbNumber).ToString();

                            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                            {
                                using (SQLiteCommand cmd = new SQLiteCommand())
                                {
                                    cmd.Connection = conn;
                                    conn.Open();

                                    SQLiteHelper sh = new SQLiteHelper(cmd);


                                    sh.Execute("DELETE FROM Movies WHERE _id=" + gvList.GetRowCellValue(gvList.GetSelectedRows()[i], cl_MovieID));
                                    sh.Execute("DELETE FROM Casts WHERE CollectionType=1 and ObjectID=" + _id);
                                    sh.Execute("DELETE FROM Files WHERE MovieID=" + _id);

                                    conn.Close();
                                }
                            }

                            if (!String.IsNullOrEmpty(ImdbNumber))
                            {
                                if (System.IO.File.Exists(GrieeXSettings.PosterPath + ImdbNumber + ".jpg") == true)
                                {
                                    System.IO.File.SetAttributes(GrieeXSettings.PosterPath + ImdbNumber + ".jpg", System.IO.FileAttributes.Archive);
                                    System.IO.File.Delete(GrieeXSettings.PosterPath + ImdbNumber + ".jpg");
                                }
                            }
                        }

                        gvList.DeleteSelectedRows();

                    }
                }
                else
                {
                    if (XtraMessageBox.Show(Language.FindKey("Messages", "1").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String _id = gvList.GetRowCellValue(gvList.GetSelectedRows()[0], cl_MovieID).ToString();
                        String ImdbNumber = gvList.GetRowCellValue(gvList.GetSelectedRows()[0], cl_ImdbNumber).ToString();

                        using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                        {
                            using (SQLiteCommand cmd = new SQLiteCommand())
                            {
                                cmd.Connection = conn;
                                conn.Open();

                                SQLiteHelper sh = new SQLiteHelper(cmd);


                                sh.Execute("DELETE FROM Movies WHERE _id=" + gvList.GetRowCellValue(gvList.GetSelectedRows()[0], cl_MovieID));
                                sh.Execute("DELETE FROM Casts WHERE CollectionType=1 and ObjectID=" + _id);
                                sh.Execute("DELETE FROM Files WHERE MovieID=" + _id);

                                conn.Close();
                            }
                        }

                        if (!String.IsNullOrEmpty(ImdbNumber))
                        {
                            if (System.IO.File.Exists(GrieeXSettings.PosterPath + ImdbNumber + ".jpg") == true)
                            {
                                System.IO.File.SetAttributes(GrieeXSettings.PosterPath + ImdbNumber + ".jpg", System.IO.FileAttributes.Normal);
                                System.IO.File.Delete(GrieeXSettings.PosterPath + ImdbNumber + ".jpg");
                            }
                        }


                        gvList.DeleteRow(gvList.FocusedRowHandle);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnTop10_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (btnTop10.Checked == true)
            {
                using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        SQLiteHelper sh = new SQLiteHelper(cmd);
                        DataTable dt = sh.Select("SELECT * FROM Movies WHERE PersonalRating<>'' and PersonalRating <> 0 ORDER BY PersonalRating DESC");
                        dGrid.DataSource = dt;

                        conn.Close();
                    }
                }

            }
            else
            {
                Search();
            }
        }


        private void btnListOptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvList.ShowCustomization();
        }

        private void btnGridView_Images_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoUpdateViewStyle("ImageGallery");
        }

        private void btnSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            Search();
        }

        private void btnRandom_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvList.RowCount == 0)
                return;

            Random random = new Random();
            int nRowCount = gvList.RowCount;

            gvList.MoveFirst();
            gvList.MoveBy(random.Next(0, nRowCount - 1));
        }

        private void btnImdb250_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmImdb250 frm = new frmImdb250();
            frm.Show();
        }

        private void btnStatistics_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStatistics frm = new frmStatistics();
            frm.Show();
        }

        private void btnVersionControl_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Process.Start(Application.StartupPath + "\\Updater.exe");
            Util.CheckForUpdate(true);
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.frmAbout frm = new frmAbout();
            frm.Show();

        }



        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
            //frmTest frm = new frmTest();
            //frm.Show();
        }

        #endregion

        #region " Menu Events "

        private void mnuDiviks_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog FO = new OpenFileDialog();
            FO.Filter = "Access Database (*.mdb)|*.mdb";

            if (FO.ShowDialog() == DialogResult.OK)
            {
                Forms.frmImportExport frm = new frmImportExport();
                frm.FormSize(438, 310);
                frm.FormType = frmImportExport.formType.Diviks;
                frm.DiviksComboFill();
                frm.FileLocation = FO.FileName;
                frm.txtDatabase.Text = "Diviks";
                frm.ShowDialog();
                if (frm.i != 0) this.Search();
            }
        }

        private void mnuDivxTurk_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog FO = new OpenFileDialog();
            FO.Filter = "DivxTurk Database (*.dbDXT)|*.dbDXT";

            if (FO.ShowDialog() == DialogResult.OK)
            {
                frmImportExport frm = new frmImportExport();
                frm.FormSize(438, 310);
                frm.FormType = frmImportExport.formType.DivxTurk;
                frm.DivxTurkComboFill();
                frm.FileLocation = FO.FileName;
                frm.txtDatabase.Text = "DivxTurk";
                frm.ShowDialog();
                if (frm.i != 0) this.Search();
            }
        }

        private void mnuPivX_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog FO = new OpenFileDialog();
            FO.Filter = "Access Database (*.mdb)|*.mdb";

            if (FO.ShowDialog() == DialogResult.OK)
            {
                frmImportExport frm = new frmImportExport();
                frm.FormSize(438, 147);
                frm.FormType = frmImportExport.formType.PivX;
                frm.GroupBox2.Visible = false;
                frm.FileLocation = FO.FileName;
                frm.txtDatabase.Text = "PivX";
                frm.ShowDialog();
                if (frm.i != 0) this.Search();
            }
        }

        private void mnuDivxARC_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog FO = new OpenFileDialog();
            FO.Filter = "Access Database (*.mdb)|*.mdb";

            if (FO.ShowDialog() == DialogResult.OK)
            {
                frmImportExport frm = new frmImportExport();
                frm.Button1.Visible = true;
                frm.FormType = frmImportExport.formType.DivxARC;
                frm.FormSize(438, 220);
                frm.DivxARCComboFill();
                frm.FileLocation = FO.FileName;
                frm.txtDatabase.Text = "DivxARC";
                frm.ShowDialog();
                if (frm.i != 0) this.Search();
            }
        }

        private void mnuAllMyMovies_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog FO = new OpenFileDialog();
            FO.Filter = "All My Movies Database (*.amm)|*.amm";

            if (FO.ShowDialog() == DialogResult.OK)
            {
                frmImportExport frm = new frmImportExport();
                frm.FormType = frmImportExport.formType.AllMyMovies;
                frm.AllMyMoviesComboFill();
                frm.FormSize(438, 185);
                //frm.GroupBox2.Visible = false;
                frm.FileLocation = FO.FileName;
                frm.txtDatabase.Text = "All My Movies";
                frm.ShowDialog();
                if (frm.i != 0) this.Search();
            }
        }

        private void mnueXtremeMovieManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog FO = new OpenFileDialog();
            FO.Filter = "eXtreme Movie Manager Database (*.mdb)|*.mdb";

            if (FO.ShowDialog() == DialogResult.OK)
            {
                frmImportExport frm = new frmImportExport();
                frm.FormSize(438, 147);
                frm.GroupBox2.Visible = false;
                frm.FileLocation = FO.FileName;
                frm.txtDatabase.Text = "eXtreme Movie Manager";
                frm.ShowDialog();
                if (frm.i != 0) this.Search();
            }
        }

        private void mnuSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.Show();
        }

        private void mnuTotalUpdates_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMultiWebImport frm = new frmMultiWebImport();
            frm.Show();
        }

        private void mnuExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Util.ExportToExcel3(gvList);

            frmExportToExcel frm = new frmExportToExcel();
            frm.dGrid = gvList;
            frm.Show();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void mnuSeen_Click(object sender, EventArgs e)
        {
            if (gvList.RowCount == 0) return;

            if (gvList.SelectedRowsCount > 0)
            {
                int i = 0;
                for (i = 0; i <= gvList.SelectedRowsCount - 1; i++)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand())
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            SQLiteHelper sh = new SQLiteHelper(cmd);
                            var dic = new Dictionary<string, object>();
                            dic["Seen"] = 1;
                            dic["UpdateDate"] = DateTime.Now;
                            sh.Update("Movies", dic, "_id", gvList.GetRowCellValue(gvList.GetSelectedRows()[i], cl_MovieID).ToString());

                            conn.Close();
                        }
                    }
                    gvList.SetRowCellValue(gvList.GetSelectedRows()[i], gvList.Columns[1], true);
                }
            }
        }

        private void mnuNotSeen_Click(object sender, EventArgs e)
        {
            if (gvList.RowCount == 0) return;

            if (gvList.SelectedRowsCount > 0)
            {
                int i = 0;
                for (i = 0; i <= gvList.SelectedRowsCount - 1; i++)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand())
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            SQLiteHelper sh = new SQLiteHelper(cmd);
                            var dic = new Dictionary<string, object>();
                            dic["Seen"] = 0;
                            dic["UpdateDate"] = DateTime.Now;
                            sh.Update("Movies", dic, "_id", gvList.GetRowCellValue(gvList.GetSelectedRows()[i], cl_MovieID).ToString());

                            conn.Close();
                        }
                    }

                    gvList.SetRowCellValue(gvList.GetSelectedRows()[i], gvList.Columns[1], false);
                }
            }
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            if (gvList.RowCount == 0) return;

            if (gvList.SelectedRowsCount != 0)
            {
                frmMovie.GlobalForm.MovieDetail.rType = Enums.RecordType.Update;
                frmMovie.GlobalForm.Show();
                frmMovie.GlobalForm.MovieDetail.RecordShow(gvList.GetRowCellValue(gvList.GetSelectedRows()[0], cl_MovieID).ToString());
            }
        }

        private void mnuAddManualG_Click(object sender, EventArgs e)
        {
            frmMovie frm = new frmMovie();
            frm.btnDelete.Enabled = false;
            frm.btnNext.Enabled = false;
            frm.btnPrevious.Enabled = false;
            frm.MovieDetail.rType = Enums.RecordType.Insert;
            frm.Show();
        }

        private void mnuExcelImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmExcel frm = new frmExcel();
            frm.Show();
        }

        private void mnuFolder_Click(object sender, EventArgs e)
        {
            if (MovieDetail.dsFiles.Files.Rows.Count > 0)
            {
                try
                {
                    string strFile = MovieDetail.dsFiles.Files.Rows[0]["FileName"].ToString();
                    strFile = strFile.Replace("’", "'");

                    if (System.IO.File.Exists(strFile))
                    {
                        string argument = "/select, \"" + strFile + "\"";

                        System.Diagnostics.Process.Start("explorer.exe", argument);
                    }
                    else
                    {

                        if (MovieDetail.dsFiles.Files.Rows[0]["FileName"].ToString().IndexOf(":\\") > -1)
                        {
                            strFile = MovieDetail.dsFiles.Files.Rows[0]["FileName"].ToString().Remove(0, MovieDetail.dsFiles.Files.Rows[0]["FileName"].ToString().IndexOf(":\\") + 2); ;
                            strFile = strFile.Replace("’", "'");
                        }

                        string[] disks = Environment.GetLogicalDrives();
                        foreach (var item in disks)
                        {
                            if (System.IO.File.Exists(item + strFile))
                            {
                                string argument = "/select, \"" + item + strFile + "\"";

                                System.Diagnostics.Process.Start("explorer.exe", argument);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show(Language.FindKey("Messages", "21").Value);
                }
            }
            else
            {
                XtraMessageBox.Show(Language.FindKey("Messages", "21").Value);
            }

        }


        private void mnuBackupFromFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog DialogSave = new SaveFileDialog();
            DialogSave.DefaultExt = "xls";
            DialogSave.Filter = "GrieeX Backup File (*.gbf)|*.gbf";
            DialogSave.AddExtension = true;
            DialogSave.RestoreDirectory = true;
            DialogSave.Title = "Kaydetmek istediðiniz yolu seçiniz?";
            DialogSave.InitialDirectory = @"C:/";
            DialogSave.FileName = "GrieeX_" + DateTime.Now.ToString("yyyy.MM.dd") + ".gbf";

            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                frmBackup frm = new frmBackup();
                frm.startBackup(DialogSave.FileName);
                frm.ShowDialog();
            }
        }

        private void mnuRestoreFromFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog FO = new OpenFileDialog();
            FO.Filter = "GrieeX Backup File (*.gbf)|*.gbf";

            if (FO.ShowDialog() == DialogResult.OK)
            {
                frmBackup frm = new frmBackup();
                frm.startRestore(FO.FileName);
                frm.Show();
            }
        }

        private void mnuCopyPictures_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        #endregion

        private void cbLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ImageComboBoxEdit cb = (DevExpress.XtraEditors.ImageComboBoxEdit)sender;
            Settings.Language = cb.EditValue.ToString();

            Settings.Save();

            XtraMessageBox.Show(Language.FindKey("Messages", "0").Value);
        }


        private void btnDropboxUpload_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(Language.FindKey("Strings", "143").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string DropboxFolder = Util.GetDropBoxPath();
                    if (DropboxFolder != null)
                    {

                        if (!Directory.Exists(DropboxFolder))
                        {
                            XtraMessageBox.Show(Language.FindKey("Strings", "149").Value);
                            return;

                        }

                        DropboxFolder += "\\Apps\\GrieeX\\databases\\";
                        if (!Directory.Exists(DropboxFolder))
                            Directory.CreateDirectory(DropboxFolder);

                        File.Copy(Application.StartupPath + "\\Database\\GrieeX.db", DropboxFolder + "GrieeX.db", true);
                        XtraMessageBox.Show(Language.FindKey("Strings", "145").Value);
                    }
                    else
                    {
                        XtraMessageBox.Show(Language.FindKey("Strings", "150").Value);
                    }


                }
            }
            catch (Exception ex)
            {


            }
        }

        private void btnDropboxDownload_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(Language.FindKey("Strings", "144").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string DropboxFolder = Util.GetDropBoxPath();
                if (DropboxFolder != null)
                {
                    if (!Directory.Exists(DropboxFolder))
                    {
                        XtraMessageBox.Show(Language.FindKey("Strings", "149").Value);
                        return;

                    }

                    DropboxFolder += "\\Apps\\GrieeX\\databases\\";

                    if (!Directory.Exists(DropboxFolder))
                        return;
                    // Directory.CreateDirectory(DropboxFolder);

                    if (!File.Exists(DropboxFolder + "GrieeX.db"))
                    {
                        return;
                    }

                    File.Copy(DropboxFolder + "GrieeX.db", Application.StartupPath + "\\Database\\GrieeX.db", true);
                    XtraMessageBox.Show(Language.FindKey("Strings", "146").Value);
                    if (Util.NewVersionFound())
                    {
                        frmDatabaseUpdater frmU = new frmDatabaseUpdater();
                        frmU.ShowDialog();
                    }
                    Search();
                }
                else
                {
                    XtraMessageBox.Show(Language.FindKey("Strings", "150").Value);
                }
            }
        }

        private void btnDatabaseRepair_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDatabaseRepair frm = new frmDatabaseRepair();
            frm.Show();
        }



    }



}