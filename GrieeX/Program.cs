using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrieeX.GrieeXBase;
using System.IO;

namespace GrieeX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //if (System.Diagnostics.Process.GetProcessesByName("GrieeX").Length >= 1)
            //{
            //    MessageBox.Show("GrieeX şu anda kullanılıyor. Tekrar açılamaz!", "GrieeX", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    Application.Exit();
            //    return;
            //}

            try
            {
                string[] tmpFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.tmp");
                foreach (var item in tmpFiles)
                {
                    File.Copy(item, item.Replace(".tmp", ""), true);
                    File.Delete(item);
                }
            }
            catch (Exception) { }  


            Settings.Load();

          //  DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);   
          

            if (File.Exists(Application.StartupPath + @"\Languages\" + Settings.Language + ".ini") == true)
            {
                Language.LoadFile(Application.StartupPath + "\\Languages\\" + Settings.Language + ".ini");

                //if (args.Length > 0)
                //{
                //    for (int i = 0; i < args.Length; i++)
                //    {
                //        string argument = args[i];

                //        //Durmuş
                //        //switch (argument)
                //        //{
                //        //    case "frmMovie":
                //        //        Application.Run(new Forms.frmMovie());
                //        //        break;
                //        //    case "frmStatistics":
                //        //        Application.Run(new Forms.frmStatistics());
                //        //        break;
                //        //    case "frmImdb250":
                //        //        Application.Run(new Forms.frmImdb250());
                //        //        break;
                //        //    case "frmAbout":
                //        //        Application.Run(new Forms.frmAbout());
                //        //        break;
                //        //    case "Settings":
                //        //        Application.Run(new Forms.frmSettings());
                //        //        break;
                //        //    default:
                //        //        break;
                //        //}
                //    }
                //}
                //else
                //{
                Application.Run(new Forms.frmMain());
                //}
            }
            else
            {
                MessageBox.Show("Lanuage file not found.");
                System.Environment.Exit(0);
            }

        }
    }
}
