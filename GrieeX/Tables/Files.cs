using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace GrieeX.GrieeXBase
{
    public class Files
    {
        #region Properties

        private long m_FileID;
        private long m_MovieID;
        private string m_FileName;
        private string m_Resolution;
        private string m_VideoCodec;
        private string m_VideoBitrate;
        private string m_Fps;
        private string m_VideoAspectRatio;
        private string m_AudioCodec1;
        private string m_AudioChannels1;
        private string m_AudioBitrate1;
        private string m_AudioSampleRate1;
        private string m_AudioSize1;
        private string m_AudioCodec2;
        private string m_AudioChannels2;
        private string m_AudioBitrate2;
        private string m_AudioSampleRate2;
        private string m_AudioSize2;
        private string m_TotalFrames;
        private string m_Lenght;
        private string m_VideoSize;
        private string m_FileSize;
        private string m_Chapter;




        public long FileID
        {
            get { return m_FileID; }
            set { m_FileID = value; }
        }

        public long MovieID
        {
            get { return m_MovieID; }
            set { m_MovieID = value; }
        }

        public string FileName
        {
            get { return m_FileName; }
            set { m_FileName = value; }
        }

        public string Resolution
        {
            get { return m_Resolution; }
            set { m_Resolution = value; }
        }

        public string VideoCodec
        {
            get { return m_VideoCodec; }
            set { m_VideoCodec = value; }
        }

        public string VideoBitrate
        {
            get { return m_VideoBitrate; }
            set { m_VideoBitrate = value; }
        }

        public string Fps
        {
            get { return m_Fps; }
            set { m_Fps = value; }
        }

        public string VideoAspectRatio
        {
            get { return m_VideoAspectRatio; }
            set { m_VideoAspectRatio = value; }
        }

        public string AudioCodec1
        {
            get { return m_AudioCodec1; }
            set { m_AudioCodec1 = value; }
        }

        public string AudioChannels1
        {
            get { return m_AudioChannels1; }
            set { m_AudioChannels1 = value; }
        }

        public string AudioBitrate1
        {
            get { return m_AudioBitrate1; }
            set { m_AudioBitrate1 = value; }
        }

        public string AudioSampleRate1
        {
            get { return m_AudioSampleRate1; }
            set { m_AudioSampleRate1 = value; }
        }

        public string AudioSize1
        {
            get { return m_AudioSize1; }
            set { m_AudioSize1 = value; }
        }

        public string AudioCodec2
        {
            get { return m_AudioCodec2; }
            set { m_AudioCodec2 = value; }
        }

        public string AudioChannels2
        {
            get { return m_AudioChannels2; }
            set { m_AudioChannels2 = value; }
        }

        public string AudioBitrate2
        {
            get { return m_AudioBitrate2; }
            set { m_AudioBitrate2 = value; }
        }

        public string AudioSampleRate2
        {
            get { return m_AudioSampleRate2; }
            set { m_AudioSampleRate2 = value; }
        }

        public string AudioSize2
        {
            get { return m_AudioSize2; }
            set { m_AudioSize2 = value; }
        }

        public string TotalFrames
        {
            get { return m_TotalFrames; }
            set { m_TotalFrames = value; }
        }

        public string Lenght
        {
            get { return m_Lenght; }
            set { m_Lenght = value; }
        }

        public string VideoSize
        {
            get { return m_VideoSize; }
            set { m_VideoSize = value; }
        }

        public string FileSize
        {
            get { return m_FileSize; }
            set { m_FileSize = value; }
        }

        public string Chapter
        {
            get { return m_Chapter; }
            set { m_Chapter = value; }
        }

        #endregion

        public Files() { }

        public Files(string _id)
        {
            Get(_id);
        }

        public void Get(string kFile)
        {
            if (String.IsNullOrEmpty(kFile))
                return;

            using (SQLiteConnection con = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    con.Open();
                    cmd.Connection = con;

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    DataTable dt = sh.Select("SELECT * FROM Files WHERE _id=" + kFile);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        DeserializeFromDataRow(dr);
                    }

                    con.Close();
                }
            }
        }

        private void DeserializeFromDataRow(DataRow dr)
        {
            this.FileID = Util.convertToInt(dr["_id"]);
            this.MovieID = Util.convertToInt(dr["MovieID"]);
            this.FileName = dr.Field<string>("FileName");
            this.Resolution = dr.Field<string>("Resolution");
            this.VideoCodec = dr.Field<string>("VideoCodec");
            this.VideoBitrate = dr.Field<string>("VideoBitrate");
            this.Fps = dr.Field<string>("Fps");
            this.VideoAspectRatio = dr.Field<string>("VideoAspectRatio");
            this.AudioCodec1 = dr.Field<string>("AudioCodec1");
            this.AudioChannels1 = dr.Field<string>("AudioChannels1");
            this.AudioBitrate1 = dr.Field<string>("AudioBitrate1");
            this.AudioSampleRate1 = dr.Field<string>("AudioSampleRate1");
            this.AudioSize1 = dr.Field<string>("AudioSize1");
            this.AudioCodec2 = dr.Field<string>("AudioCodec2");
            this.AudioChannels2 = dr.Field<string>("AudioChannels2");
            this.AudioBitrate2 = dr.Field<string>("AudioBitrate2");
            this.AudioSampleRate2 = dr.Field<string>("AudioSampleRate2");
            this.AudioSize2 = dr.Field<string>("AudioSize2");
            this.TotalFrames = dr.Field<string>("TotalFrames");
            this.Lenght = dr.Field<string>("Lenght");
            this.VideoSize = dr.Field<string>("VideoSize");
            this.Chapter = dr.Field<string>("Chapter"); 
        }

        public void Save()
        {
            if (FileID == 0)
            {
                Insert();
            }
            else
            {
                Update();
            }
        }

        private void Insert()
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    var dic = new Dictionary<string, object>();
                    dic["MovieID"] = MovieID;
                    dic["FileName"] = FileName;
                    dic["Resolution"] = Resolution;
                    dic["VideoCodec"] = VideoCodec;
                    dic["VideoBitrate"] = VideoBitrate;
                    dic["Fps"] = Fps;
                    dic["VideoAspectRatio"] = VideoAspectRatio;
                    dic["AudioCodec1"] = AudioCodec1;
                    dic["AudioChannels1"] = AudioChannels1;
                    dic["AudioBitrate1"] = AudioBitrate1;
                    dic["AudioSampleRate1"] = AudioSampleRate1;
                    dic["AudioSize1"] = AudioSize1;
                    dic["AudioCodec2"] = AudioCodec2;
                    dic["AudioChannels2"] = AudioChannels2;
                    dic["AudioBitrate2"] = AudioBitrate2;
                    dic["AudioSampleRate2"] = AudioSampleRate2;
                    dic["AudioSize2"] = AudioSize2;
                    dic["TotalFrames"] = TotalFrames;
                    dic["Lenght"] = Lenght;
                    dic["VideoSize"] = VideoSize;
                    dic["FileSize"] = FileSize;
                    dic["Chapter"] = Chapter;

                    sh.Insert("Files", dic);

                    FileID = sh.LastInsertRowId();

                    conn.Close();
                }
            }
        }

        private void Update()
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    var dic = new Dictionary<string, object>();
                    dic["MovieID"] = MovieID;
                    dic["FileName"] = FileName;
                    dic["Resolution"] = Resolution;
                    dic["VideoCodec"] = VideoCodec;
                    dic["VideoBitrate"] = VideoBitrate;
                    dic["Fps"] = Fps;
                    dic["VideoAspectRatio"] = VideoAspectRatio;
                    dic["AudioCodec1"] = AudioCodec1;
                    dic["AudioChannels1"] = AudioChannels1;
                    dic["AudioBitrate1"] = AudioBitrate1;
                    dic["AudioSampleRate1"] = AudioSampleRate1;
                    dic["AudioSize1"] = AudioSize1;
                    dic["AudioCodec2"] = AudioCodec2;
                    dic["AudioChannels2"] = AudioChannels2;
                    dic["AudioBitrate2"] = AudioBitrate2;
                    dic["AudioSampleRate2"] = AudioSampleRate2;
                    dic["AudioSize2"] = AudioSize2;
                    dic["TotalFrames"] = TotalFrames;
                    dic["Lenght"] = Lenght;
                    dic["VideoSize"] = VideoSize;
                    dic["FileSize"] = FileSize;
                    dic["Chapter"] = Chapter;

                    sh.Update("Files", dic, "_id", FileID);

                    conn.Close();
                }
            }
        }

        public void Delete()
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.Execute("DELETE FROM Files WHERE _id=" + FileID);

                    conn.Close();
                }
            }
        }
    }

}
