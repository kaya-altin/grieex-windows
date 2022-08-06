using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Data.SQLite;


namespace GrieeX.GrieeXBase
{
    public class Util
    {

        private static string m_GrieeXVersion;
        public static string GrieeXVersion
        {
            get
            {
                if (m_GrieeXVersion == null)
                {
                    System.Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                    m_GrieeXVersion = String.Format("{0}.{1}", version.Major, version.Minor);
                }
                return m_GrieeXVersion;

            }
        }

        public static string GetDropBoxPath()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "Dropbox\\host.db");

            if (!File.Exists(dbPath))
            {
                appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                dbPath = Path.Combine(appDataPath, "Dropbox\\host.db");

                if (!File.Exists(dbPath))
                return null;
            }
            var lines = File.ReadAllLines(dbPath);
            var dbBase64Text = Convert.FromBase64String(lines[1]);
            var folderPath = Encoding.UTF8.GetString(dbBase64Text);

            return folderPath;
        }

           

        public static void ClearControls(Control c)
        {
            foreach (Control cControl in c.Controls)
            {
                if (cControl is TextBox)
                {
                    cControl.Text = "";
                }
                else if (cControl is System.Windows.Forms.ComboBox)
                {
                    if (cControl.DataBindings.Count == 0)
                    {
                        ((System.Windows.Forms.ComboBox)cControl).SelectedIndex = -1;
                    }
                    else
                    {
                        ((System.Windows.Forms.ComboBox)cControl).SelectedValue = -1;
                    }
                }
                else if (cControl is CheckBox)
                {
                    ((CheckBox)cControl).Checked = false;
                }
                else if (cControl is RichTextBox)
                {
                    cControl.Text = "";
                }
                else if (cControl is LookUpEdit)
                {
                    ((LookUpEdit)cControl).ItemIndex = -1;
                }
                else if (cControl is PictureBox)
                {
                    ((PictureBox)cControl).ImageLocation = "";
                }
                else if (cControl is MaskedTextBox)
                {
                    cControl.Text = "";
                }
                else if (cControl is ListView)
                {
                    ((ListView)cControl).Items.Clear();
                }
                else if (cControl is DataGridView)
                {
                    ((DataGridView)cControl).Rows.Clear();
                }
                else if (cControl is DateTimePicker)
                {
                    ((DateTimePicker)cControl).Value = DateTime.Now.Date;
                }
                else if (cControl is DevExpress.XtraGrid.GridControl)
                {
                    //Durmuş
                    //((DevExpress.XtraGrid.GridControl)cControl).DataSource = null;
                }


                ClearControls(cControl);
            }
        }

        public static void EmptyTemp()
        {
            try
            {
                foreach (string s in System.IO.Directory.GetFiles(Application.StartupPath + "\\Temp"))
                {
                    File.SetAttributes(s, FileAttributes.Archive);

                    System.IO.File.Delete(s);
                }
            }
            catch (Exception)
            {
            }

        }

        public static bool DeleteDirectory(string target_dir)
        {
            bool result = false;

            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);

            return result;
        }

        public static bool ValidCommand(string cmd)
        {
            if (string.IsNullOrEmpty(cmd))
                return false;

            return (IsNumeric(cmd));
        }

        public static bool IsNumeric(char c)
        {
            if (c > 57 || c < 48)
                return false;
            return true;
        }

        public static bool IsNumeric(string s)
        {
            if (s == "") { return false; }
            char nns = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NegativeSign[0];
            char dcs = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            int nnsi = s.IndexOf(nns);
            if (nnsi > 0)
                return false;
            if (nnsi == 0)
                s = s.Remove(nnsi, 1);
            char[] c = s.ToCharArray();
            if (c[0] == dcs || c[c.Length - 1] == dcs)
                return false;

            int dcsc = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] > 57 || c[i] < 48)
                {
                    if (c[i] != dcs)
                        return false;
                    else
                        dcsc++;
                }
                if (dcsc > 1)
                    return false;
            }
            return true;
        }

        public static string FormatTime(double inTime)
        {
            string ReturnValue = null;
            if (ValidCommand(inTime.ToString()) == true)
            {
                long TimeLeft;
                long ThisTime;

                ReturnValue = null;

                long OneMinute = 60;
                long OneHour = Convert.ToUInt32(Math.Pow(OneMinute, 2));
                long OneDay = OneHour * 24;

                TimeLeft = (long)inTime;
                TimeLeft = (long)inTime / 1000;
                //Milisaniye hesabı medieinfo.dll dosyasından dolayı

                if ((TimeLeft >= OneDay))
                {
                    ThisTime = (long)(inTime / OneDay) / 1000;
                    ReturnValue = ThisTime.ToString() + ":";
                    TimeLeft = (long)inTime % OneDay;
                }

                if ((TimeLeft >= OneHour))
                {
                    ThisTime = TimeLeft / OneHour;
                    ReturnValue = ReturnValue + (!string.IsNullOrEmpty(ReturnValue) ? ThisTime.ToString("00") + ":" : ThisTime + ":");
                    TimeLeft = TimeLeft % OneHour;
                }
                ReturnValue = ReturnValue + (TimeLeft / OneMinute).ToString("00") + ":" + (TimeLeft % OneMinute).ToString("00");

            }
            return ReturnValue;
        }

        public static bool IsConnected()
        {
            System.Uri Url = new System.Uri("http://www.google.com");

            System.Net.WebRequest WebReq;
            System.Net.WebResponse Resp;
            WebReq = System.Net.WebRequest.Create(Url);

            try
            {
                Resp = WebReq.GetResponse();
                Resp.Close();
                WebReq = null;
                return true;
            }

            catch
            {
                WebReq = null;
                return false;
            }
        }

        public static void VersionControl(bool bCurrentVersion)
        {
            string strVersion = null;
            try
            {
                string xmlURL = "http://www.griee.com/app_version.xml";
                XmlTextReader reader = new XmlTextReader(xmlURL);

                reader.MoveToContent();

                string elementName = "";

                if ((reader.NodeType == XmlNodeType.Element) &&
                     (reader.Name == "GrieeX"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                            elementName = reader.Name;
                        else
                        {
                            if ((reader.NodeType == XmlNodeType.Text) &&
                                (reader.HasValue))
                            {
                                switch (elementName)
                                {
                                    case "version":
                                        strVersion = reader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
                reader.Close();

                if (Util.GrieeXVersion != strVersion)
                {
                    XtraMessageBox.Show(Language.FindKey("Messages", "23").Value, "GrieeX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bCurrentVersion == true)
                    {
                        XtraMessageBox.Show(Language.FindKey("Messages", "24").Value + "(v " + strVersion + ")", "GrieeX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static bool NewVersionFound()
        {
           
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    int version = sh.ExecuteScalar<int>("Select version From android_database_version");

                   // int version = GetDatabaseVersion(ctx);

                    if (version < GrieeXSettings.DB_VERSION)
                    {
                        return true;
                    }
                    conn.Close();
                }
            }

            return false;        
        }

        public static void PlayVideo(string strFile)
        {
            if (string.IsNullOrEmpty(Settings.Player))
            {
                XtraMessageBox.Show(Language.FindKey("Messages", "20").Value);
                return;
            }

            bool bStart = false;

            if (System.IO.File.Exists(strFile))
            {
                String args = "\"" + strFile + "\"";
                ProcessStartInfo player = new ProcessStartInfo(Settings.Player, args);
                Process.Start(player);
                bStart = true;
            }
            else
            {
                if (strFile.IndexOf(":\\") > -1)
                {
                    strFile = strFile.Remove(0, strFile.IndexOf(":\\") + 2);
                }

                string[] disks = Environment.GetLogicalDrives();
                foreach (var item in disks)
                {
                    if (System.IO.File.Exists(item + strFile))
                    {
                        String args = "\"" + item + strFile + "\"";
                        ProcessStartInfo player = new ProcessStartInfo(Settings.Player, args);
                        Process.Start(player);
                        bStart = true;
                    }
                }
            }

            if (bStart == false)
            {
                XtraMessageBox.Show(Language.FindKey("Messages", "21").Value.ToString());
            }

        }

        public static string RemoveSpecialChars(string input)
        {
            return Regex.Replace(input, @"[^a-zA-Z0-9]+", string.Empty);
        }

        public static string RemoveSpecialCharacters(string str)
        {
            char[] buffer = new char[str.Length];
            int idx = 0;

            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9'))
                {
                    buffer[idx] = c;
                    idx++;
                }
            }

            return new string(buffer, 0, idx);
        }


        public static decimal convertToDecimal(object o)
        {
            try
            {
                return Convert.ToDecimal(o);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int convertToInt(object o)
        {
            try
            {
                return Convert.ToInt32(o);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static long? convertToLong(object o)
        {
            try
            {
                return Convert.ToInt64(o);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool convertToBoolean(object o)
        {
            try
            {
                return Convert.ToBoolean(o);
            }
            catch (Exception)
            {
                return false;
            }
        }



        public static string convertToString(object o)
        {
            try
            {
                return Convert.ToString(o);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string convertToMoney(string s)
        {
            try
            {
                if (!String.IsNullOrEmpty(s) && s.Equals("0"))
                {
                    return "$0";
                }

                return string.Format("${0:0,0}", decimal.Parse(s)); ;
            }
            catch (Exception)
            {
                return s;
            }
        }
        public static string convertToDecimalString(int s)
        {
            String strS = convertToString(s);
            try
            {
                return string.Format("{0:0,0}", decimal.Parse(strS)); ;
            }
            catch (Exception)
            {
                return strS;
            }
        }
        public static string convertToDecimalString(String s)
        {
            try
            {
                return string.Format("{0:0,0}", decimal.Parse(s)); ;
            }
            catch (Exception)
            {
                return s;
            }
        }

        public static void CopyStream(Stream input, Stream output)
        {
            // Insert null checking here for production
            byte[] buffer = new byte[8192];

            int bytesRead;
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }

        public static void WriteResourceToFile(string resourceName, string fileName)
        {
            using (var resource = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (var file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
        }

        public static void CheckForUpdate(bool showOnlyUpdateMessage)
        {
            try
            {
                if (IsConnected() == false)
                    return;

                XElement root = XElement.Load("http://www.griee.com/app_version.xml");
                string RemoteVersion = root.Element("version").Value;
                string CurrentVersion = Util.GrieeXVersion;

                if (RemoteVersion != CurrentVersion)
                {
                    XtraMessageBox.Show(Language.FindKey("Strings", "133").Value, "GrieeX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    if (showOnlyUpdateMessage)
                    XtraMessageBox.Show(Language.FindKey("Strings", "134").Value, "GrieeX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception) { }
        }

    }
}
