using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrieeX.GrieeXBase
{
    public class GrieeXSettings
    {
        public static int DB_VERSION = 11;
        public static string TmdbApiKey = "75f2c8a31f8bd0cb124db40dea539346";
        public static string DataSource = string.Format("Data Source={0}\\Database\\GrieeX.db;Version=3;", Application.StartupPath);
        public static string DataSourceRepair = string.Format("Data Source={0}\\Database\\GrieeX.db.repair;Version=3;", Application.StartupPath);
        public static string ImagePath = String.Format(@"{0}\Images\", Application.StartupPath);
        public static string TempPath = Application.StartupPath + "\\Temp\\";
        public static string PosterPath = String.Format(@"{0}\Images\Posters\", Application.StartupPath);
        public static string CastPath = String.Format(@"{0}\Images\Casts\", Application.StartupPath);
        
    }
}
