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

namespace GrieeX.Forms
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        string strImagePath = Application.StartupPath + "\\Images\\";
        string strPosterPath = Application.StartupPath + "\\Images\\Posters\\";
        string strCastPath = Application.StartupPath + "\\Images\\Casts\\";

        public frmBackup()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            EmitLanguage();
        }

        private struct Arguments
        {
            public String File;
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
        }

        public void startBackup(string FileName)
        {
            bwBackup.RunWorkerAsync(new Arguments { File = FileName });
        }

        public void startRestore(string FileName)
        {
            bwRestore.RunWorkerAsync(new Arguments { File = FileName });
        }


        private void bwBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            Arguments Args = (Arguments)e.Argument;

            Backup(Args.File);
        }

        private void bwBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frmMain.GlobalForm.Search();
            this.Close();

        }

        private void frmBackup_FormClosing(object sender, FormClosingEventArgs e)
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

            if (bwRestore.IsBusy)
            {
                if (XtraMessageBox.Show(Language.FindKey("Messages", "19").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bwRestore.CancelAsync();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }


        }

        private void bwRestore_DoWork(object sender, DoWorkEventArgs e)
        {
            Arguments Args = (Arguments)e.Argument;

            Restore(Args.File);
        }

        private void bwRestore_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                //if (File.Exists(Application.StartupPath + "\\UpdateSQL.exe"))
                //    Process.Start(Application.StartupPath + "\\UpdateSQL.exe");

                //while (System.Diagnostics.Process.GetProcessesByName("UpdateSQL").Length >= 1)
                //{
                //    Thread.Sleep(500);
                //}
                if (Util.NewVersionFound())
                {
                    frmDatabaseUpdater frmU = new frmDatabaseUpdater();
                    frmU.ShowDialog();
                }

                frmMain.GlobalForm.Search();
                this.Close();
            }
            catch (Exception ex)
            {

            }

        }



        private void Backup(string BackupLocation)
        {
            try
            {

                string strDatabase = Application.StartupPath + "\\Database\\GrieeX.db";


                List<string> fileNames = new List<string>();

                //fileNames.AddRange(Directory.GetFiles(strPosterPath));
                //fileNames.AddRange(Directory.GetFiles(strCastPath));
                foreach (var item in Directory.GetDirectories(strImagePath))
                {
                    fileNames.AddRange(Directory.GetFiles(item));
                }

                fileNames.Add(strDatabase);


                Zip.Compress(fileNames, BackupLocation);
            }
            catch (Exception e)
            {
            }
        }

        private void Restore(string from)
        {
            try
            {
                foreach (string s in System.IO.Directory.GetFiles(strPosterPath))
                {
                    File.SetAttributes(s, FileAttributes.Archive);

                    System.IO.File.Delete(s);
                }

                foreach (string s in System.IO.Directory.GetFiles(strCastPath))
                {
                    File.SetAttributes(s, FileAttributes.Archive);

                    System.IO.File.Delete(s);
                }

                string to = Application.StartupPath;


                Zip.Extract(from, to);



                //Application.Restart();
            }
            catch (Exception e)
            {
            }

        }

    }
}