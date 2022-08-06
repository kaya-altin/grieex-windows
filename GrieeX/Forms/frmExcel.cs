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
using System.Data.SQLite;
using OfficeOpenXml;

namespace GrieeX.Forms
{
    public partial class frmExcel : DevExpress.XtraEditors.XtraForm
    {
        public frmExcel()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            EmitLanguage();
        }

        DataTable dt;

        private void frmExcel_Load(object sender, EventArgs e)
        {
            //Durmuþ
            //  Data.EmitComboList("SELECT kMovies_Type AS ID, strMovies_Type AS STR FROM tMovies_Types;", cbMovies_Type);
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            try
            {
                cbMovieName.Items.Clear();
                cbIMDBNumber.Items.Clear();
                cbArchivesNumber.Items.Clear();

                //IExcelDataReader excelReader = null;
                OpenFileDialog FO = new OpenFileDialog();
                DialogResult Svar;
                FO.Filter = "Excel Files|*.xls;*.xlsx";

                Svar = FO.ShowDialog();
                if (!(Svar == DialogResult.OK))
                    return;

                dt = GetDataTableFromExcel(FO.FileName);

                if (dt == null)
                    return;

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    cbMovieName.Items.Add(dt.Columns[i].ToString());
                    cbIMDBNumber.Items.Add(dt.Columns[i].ToString());
                    cbArchivesNumber.Items.Add(dt.Columns[i].ToString());
                }

                btnImport.Enabled = true;
                txtFolder.Text = FO.FileName;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Excel dosyasý okunamadý");
            }
        }

        private DataTable GetDataTableFromExcel(string path)
        {
            using (var pck = new OfficeOpenXml.ExcelPackage())
            {
                using (var stream = File.OpenRead(path))
                {
                    pck.Load(stream);
                }
                var ws = pck.Workbook.Worksheets[1];
                DataTable tbl = new DataTable();
                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                {
                    tbl.Columns.Add(firstRowCell.Text);
                }
                var startRow = 2;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                    DataRow row = tbl.Rows.Add();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                }
                return tbl;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
            {
                pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                slStatus.Caption = Language.FindKey("Messages", "2").Value;
                bw.RunWorkerAsync();
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand())
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            SQLiteHelper sh = new SQLiteHelper(cmd);

                            for (int i = 1; i < dt.Rows.Count; i++)
                            {
                                string strMovieName = cbMovieName.SelectedIndex == -1 ? string.Empty : dt.Rows[i][cbMovieName.SelectedIndex].ToString();
                                string strIMDBNumber = cbIMDBNumber.SelectedIndex == -1 ? string.Empty : dt.Rows[i][cbIMDBNumber.SelectedIndex].ToString();
                                string strArchivesNumber = cbArchivesNumber.SelectedIndex == -1 ? string.Empty : dt.Rows[i][cbArchivesNumber.SelectedIndex].ToString();

                                var dic = new Dictionary<string, object>();
                                dic["OrginalName"] = strMovieName;
                                dic["ImdbNumber"] = strIMDBNumber;
                                dic["ArchivesNumber"] = strArchivesNumber;

                                sh.Insert("Movies", dic);

                                slStatus.Caption = strMovieName;

                            }

                            conn.Close();
                        }
                    }
                }
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            slStatus.Caption = Language.FindKey("Messages", "18").Value;
            frmMain.GlobalForm.Search();
        }


    }
}

