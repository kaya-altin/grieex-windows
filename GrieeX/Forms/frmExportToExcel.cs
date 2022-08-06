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
using DevExpress.XtraGrid.Views.Grid;
using OfficeOpenXml;

namespace GrieeX.Forms
{
    public partial class frmExportToExcel : DevExpress.XtraEditors.XtraForm
    {
        public frmExportToExcel()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //EmitLanguage();
        }

        public GridView dGrid;
        private ExcelPackage _package;


        private void frmBackup_Load(object sender, EventArgs e)
        {
            bwExport.RunWorkerAsync();
        }

        private void frmBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bwExport.IsBusy)
            {
                if (XtraMessageBox.Show(Language.FindKey("Messages", "19").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bwExport.CancelAsync();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void bwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (dGrid == null || dGrid.RowCount == 0) return;


                _package = new ExcelPackage(new MemoryStream());
                var worksheet = _package.Workbook.Worksheets.Add("GrieeX");

                long totalCount = dGrid.RowCount;
                long rowRead = 0;
                float percent = 0;


                for (int i = 0; i < dGrid.VisibleColumns.Count; i++)
                {

                    worksheet.Cells[1, i + 1].Value = dGrid.VisibleColumns[i].Caption;
                    worksheet.Cells[1, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightYellow);
                }

                for (int r = 0; r < dGrid.RowCount; r++)
                {

                    for (int i = 0; i < dGrid.VisibleColumns.Count; i++)
                    {
                        try
                        {
                            worksheet.Cells[r + 2, i + 1].Value = Movie.Parse.StripHTML(dGrid.GetRowCellValue(r, dGrid.VisibleColumns[i]).ToString());
                        }
                        catch
                        {
                            worksheet.Cells[r + 2, i + 1].Value = Movie.Parse.StripHTML(dGrid.GetRowCellValue(r, dGrid.VisibleColumns[i]).ToString().Replace("=", ""));
                        }
                    }

                    rowRead++;
                    percent = ((float)(100 * rowRead)) / totalCount;

                    lblStatus.Text = dGrid.GetRowCellValue(r, dGrid.Columns[3]).ToString();
                    pbProgress.EditValue = percent;
                }
            }
            catch (Exception ex)
            {
                bwExport.CancelAsync();
               // xlApp = null;

                this.Close();
            }
        }

        private void bwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            saveFileDialog_SaveExcel.Filter = "Excel files (*.xlsx)|*.xlsx";
            var dialogResult = saveFileDialog_SaveExcel.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _package.SaveAs(new FileInfo(saveFileDialog_SaveExcel.FileName));
            }

            this.Close();

        }

    }
}