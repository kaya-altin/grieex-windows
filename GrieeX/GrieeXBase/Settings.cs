using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;
using System.IO;

namespace GrieeX.GrieeXBase
{
    public static class Settings
    {
        #region Properties

        private static string m_ActiveSkinName = "Office 2010 Silver";
        private static bool m_AutoClose = true;
        private static bool m_AutoNewRecord;
        private static string m_DefaultDubbing;
        private static string m_DefaultRlsGroup;
        private static string m_DefaultRlsType;
        private static string m_DefaultSubtitle;
        private static bool m_ImageAutoPreview;
        private static bool m_ImageLeft;
        private static string m_Language = "English";
        private static string m_Player;
        private static string m_ProxyPassword;
        private static int m_ProxyPort;
        private static string m_ProxyServer;
        private static string m_ProxyUserName;
        private static bool m_StartUpVersionControl = true;
        private static bool m_UseProxy;
        private static string m_UserColumn1;
        private static string m_UserColumn2;
        private static string m_UserColumn3;
        private static string m_UserColumn4;
        private static string m_UserColumn5;
        private static string m_UserColumn6;
        private static bool m_The = true;
        private static bool m_ShowCastImage = true;
        private static bool m_BigImages = true;


        public static string ActiveSkinName
        {
            get { return m_ActiveSkinName; }
            set { m_ActiveSkinName = value; }
        }

        public static bool AutoClose
        {
            get { return m_AutoClose; }
            set { m_AutoClose = value; }
        }

        public static bool AutoNewRecord
        {
            get { return m_AutoNewRecord; }
            set { m_AutoNewRecord = value; }
        }

        public static string DefaultDubbing
        {
            get { return m_DefaultDubbing; }
            set { m_DefaultDubbing = value; }
        }

        public static string DefaultRlsGroup
        {
            get { return m_DefaultRlsGroup; }
            set { m_DefaultRlsGroup = value; }
        }

        public static string DefaultRlsType
        {
            get { return m_DefaultRlsType; }
            set { m_DefaultRlsType = value; }
        }

        public static string DefaultSubtitle
        {
            get { return m_DefaultSubtitle; }
            set { m_DefaultSubtitle = value; }
        }

        public static bool ImageAutoPreview
        {
            get { return m_ImageAutoPreview; }
            set { m_ImageAutoPreview = value; }
        }

        public static bool ImageLeft
        {
            get { return m_ImageLeft; }
            set { m_ImageLeft = value; }
        }

        public static string Language
        {
            get { return m_Language; }
            set { m_Language = value; }
        }

        public static string Player
        {
            get { return m_Player; }
            set { m_Player = value; }
        }

        public static string ProxyPassword
        {
            get { return m_ProxyPassword; }
            set { m_ProxyPassword = value; }
        }

        public static int ProxyPort
        {
            get { return m_ProxyPort; }
            set { m_ProxyPort = value; }
        }

        public static string ProxyServer
        {
            get { return m_ProxyServer; }
            set { m_ProxyServer = value; }
        }

        public static string ProxyUserName
        {
            get { return m_ProxyUserName; }
            set { m_ProxyUserName = value; }
        }

        public static bool StartUpVersionControl
        {
            get { return m_StartUpVersionControl; }
            set { m_StartUpVersionControl = value; }
        }

        public static bool UseProxy
        {
            get { return m_UseProxy; }
            set { m_UseProxy = value; }
        }

        public static string UserColumn1
        {
            get { return m_UserColumn1; }
            set { m_UserColumn1 = value; }
        }

        public static string UserColumn2
        {
            get { return m_UserColumn2; }
            set { m_UserColumn2 = value; }
        }

        public static string UserColumn3
        {
            get { return m_UserColumn3; }
            set { m_UserColumn3 = value; }
        }

        public static string UserColumn4
        {
            get { return m_UserColumn4; }
            set { m_UserColumn4 = value; }
        }

        public static string UserColumn5
        {
            get { return m_UserColumn5; }
            set { m_UserColumn5 = value; }
        }

        public static string UserColumn6
        {
            get { return m_UserColumn6; }
            set { m_UserColumn6 = value; }
        }

        public static bool The
        {
            get { return m_The; }
            set { m_The = value; }
        }


        public static bool ShowCastImage
        {
            get { return m_ShowCastImage; }
            set { m_ShowCastImage = value; }
        }

        #endregion


        #region Helper Methods


        public static void Load()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Settings.xml"))
                Save();

            XDocument settings = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Settings.xml");


            IEnumerable<XElement> itemsXML = settings.Root.Elements("Settings").Elements("Setting");

            foreach (XElement item in itemsXML)
            {
                try
                {
                    switch (item.Attribute("name").Value)
                    {
                        case "ActiveSkinName":
                            ActiveSkinName = item.Value;
                            break;
                        case "AutoClose":
                            AutoClose = Convert.ToBoolean(item.Value);
                            break;
                        case "AutoNewRecord":
                            AutoNewRecord = Convert.ToBoolean(item.Value);
                            break;
                        case "DefaultDubbing":
                            DefaultDubbing = item.Value;
                            break;
                        case "DefaultRlsGroup":
                            DefaultRlsGroup = item.Value;
                            break;
                        case "DefaultRlsType":
                            DefaultRlsType = item.Value;
                            break;
                        case "DefaultSubtitle":
                            DefaultSubtitle = item.Value;
                            break;
                        case "ImageAutoPreview":
                            ImageAutoPreview = Convert.ToBoolean(item.Value);
                            break;
                        case "ImageLeft":
                            ImageLeft = Convert.ToBoolean(item.Value);
                            break;
                        case "Language":
                            Language = item.Value;
                            break;
                        case "Player":
                            Player = item.Value;
                            break;
                        case "ProxyPassword":
                            ProxyPassword = item.Value;
                            break;
                        case "ProxyPort":
                            ProxyPort = int.Parse(item.Value);
                            break;
                        case "ProxyServer":
                            ProxyServer = item.Value;
                            break;
                        case "ProxyUserName":
                            ProxyUserName = item.Value;
                            break;
                        case "StartUpVersionControl":
                            StartUpVersionControl = Convert.ToBoolean(item.Value);
                            break;
                        case "UseProxy":
                            UseProxy = Convert.ToBoolean(item.Value);
                            break;
                        case "UserColumn1":
                            UserColumn1 = item.Value;
                            break;
                        case "UserColumn2":
                            UserColumn2 = item.Value;
                            break;
                        case "UserColumn3":
                            UserColumn3 = item.Value;
                            break;
                        case "UserColumn4":
                            UserColumn4 = item.Value;
                            break;
                        case "UserColumn5":
                            UserColumn5 = item.Value;
                            break;
                        case "UserColumn6":
                            UserColumn6 = item.Value;
                            break;
                        case "The":
                            The = Convert.ToBoolean(item.Value);
                            break;
                        case "ShowCastImage":
                            ShowCastImage = Convert.ToBoolean(item.Value);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { }
            }


            //IEnumerable<XElement> users =
            //(from el in settings.Root.Elements("Settings").Elements("Setting")
            // where (string)el.Attribute("name") == "ActiveSkinName"
            // select el);
        }

        public static void Save()
        {

            XElement root = new XElement("Root");
            XElement settings = new XElement("Settings");

            settings.Add(new XElement("Setting", new XAttribute("name", "ActiveSkinName"), new XElement("Value", ActiveSkinName)));
            settings.Add(new XElement("Setting", new XAttribute("name", "AutoClose"), new XElement("Value", AutoClose)));
            settings.Add(new XElement("Setting", new XAttribute("name", "AutoNewRecord"), new XElement("Value", AutoNewRecord)));
            settings.Add(new XElement("Setting", new XAttribute("name", "DefaultDubbing"), new XElement("Value", DefaultDubbing)));
            settings.Add(new XElement("Setting", new XAttribute("name", "DefaultRlsGroup"), new XElement("Value", DefaultRlsGroup)));
            settings.Add(new XElement("Setting", new XAttribute("name", "DefaultRlsType"), new XElement("Value", DefaultRlsType)));
            settings.Add(new XElement("Setting", new XAttribute("name", "DefaultSubtitle"), new XElement("Value", DefaultSubtitle)));
            settings.Add(new XElement("Setting", new XAttribute("name", "ImageAutoPreview"), new XElement("Value", ImageAutoPreview)));
            settings.Add(new XElement("Setting", new XAttribute("name", "ImageLeft"), new XElement("Value", ImageLeft)));
            settings.Add(new XElement("Setting", new XAttribute("name", "Language"), new XElement("Value", Language)));
            settings.Add(new XElement("Setting", new XAttribute("name", "Player"), new XElement("Value", Player)));
            settings.Add(new XElement("Setting", new XAttribute("name", "ProxyPassword"), new XElement("Value", ProxyPassword)));
            settings.Add(new XElement("Setting", new XAttribute("name", "ProxyPort"), new XElement("Value", ProxyPort)));
            settings.Add(new XElement("Setting", new XAttribute("name", "ProxyServer"), new XElement("Value", ProxyServer)));
            settings.Add(new XElement("Setting", new XAttribute("name", "ProxyUserName"), new XElement("Value", ProxyUserName)));
            settings.Add(new XElement("Setting", new XAttribute("name", "StartUpVersionControl"), new XElement("Value", StartUpVersionControl)));
            settings.Add(new XElement("Setting", new XAttribute("name", "UseProxy"), new XElement("Value", UseProxy)));
            settings.Add(new XElement("Setting", new XAttribute("name", "UserColumn1"), new XElement("Value", UserColumn1)));
            settings.Add(new XElement("Setting", new XAttribute("name", "UserColumn2"), new XElement("Value", UserColumn2)));
            settings.Add(new XElement("Setting", new XAttribute("name", "UserColumn3"), new XElement("Value", UserColumn3)));
            settings.Add(new XElement("Setting", new XAttribute("name", "UserColumn4"), new XElement("Value", UserColumn4)));
            settings.Add(new XElement("Setting", new XAttribute("name", "UserColumn5"), new XElement("Value", UserColumn5)));
            settings.Add(new XElement("Setting", new XAttribute("name", "UserColumn6"), new XElement("Value", UserColumn6)));
            settings.Add(new XElement("Setting", new XAttribute("name", "The"), new XElement("Value", The)));
            settings.Add(new XElement("Setting", new XAttribute("name", "ShowCastImage"), new XElement("Value", ShowCastImage)));

            root.Add(settings);


            root.Save(AppDomain.CurrentDomain.BaseDirectory + "Settings.xml");
        }


        #endregion

    }
}
