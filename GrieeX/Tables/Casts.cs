using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Drawing;

namespace GrieeX.GrieeXBase
{
    public class Casts
    {
        #region Properties

        private long m_ID;
        private string m_Name;
        private string m_Character;
        private string m_Url;
        private string m_ImageUrl;
        private string m_CastID;
        private long m_ObjectID;
        private int m_CollectionType=1;


        public long ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public string Character
        {
            get { return m_Character; }
            set { m_Character = value; }
        }

        public string Url
        {
            get { return m_Url; }
            set { m_Url = value; }
        }

        public string ImageUrl
        {
            get { return m_ImageUrl; }
            set { m_ImageUrl = value; }
        }

        public string CastID
        {
            get { return m_CastID; }
            set { m_CastID = value; }
        }

        public long ObjectID
        {
            get { return m_ObjectID; }
            set { m_ObjectID = value; }
        }

        public int CollectionType
        {
            get { return m_CollectionType; }
            set { m_CollectionType = value; }
        }

        #endregion

        public Casts() { }

        public Casts(string Name, string Character, string Url, string ImageUrl, string CastID, long ObjectID, int CollectionType)
        {
            this.Name = Name;
            this.Character = Character;
            this.Url = Url;
            this.ImageUrl = ImageUrl;
            this.CastID = CastID;
            this.ObjectID = ObjectID;
            this.CollectionType = CollectionType;
        }

        public Casts(string _id)
        {
            Get(_id);
        }

        public void Get(string _id)
        {
            if (String.IsNullOrEmpty(_id))
                return;

            using (SQLiteConnection con = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    con.Open();
                    cmd.Connection = con;

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    DataTable dt = sh.Select("SELECT * FROM Casts WHERE CollectionType=1 and _id=" + _id);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        DeserializeFromDataRow(dr);
                    } 

                    con.Close();
                }
            }
        }

        public void DeserializeFromDataRow(DataRow dr)
        {
            this.ID = Util.convertToInt(dr["_id"]);
            this.Name = Util.convertToString(dr["Name"]);
            this.Character = Util.convertToString(dr["Character"]);
            this.Url = Util.convertToString(dr["Url"]);
            this.ImageUrl = Util.convertToString(dr["ImageUrl"]);
            this.CastID = Util.convertToString(dr["CastID"]); 
            this.ObjectID = Util.convertToInt(dr["ObjectID"]);
            this.CollectionType = Util.convertToInt(dr["CollectionType"]);

        }

        public void Save()
        {
            if (ID == 0)
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

                    dic["Name"] = Name;
                    dic["Character"] = Character;
                    dic["Url"] = Url;
                    dic["ImageUrl"] = ImageUrl;
                    dic["CastID"] = CastID;
                    dic["ObjectID"] = ObjectID;
                    dic["CollectionType"] = CollectionType;


                    sh.Insert("Casts", dic);

                    ID = sh.LastInsertRowId();

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
                    dic["Name"] = Name;
                    dic["Character"] = Character;
                    dic["Url"] = Url;
                    dic["ImageUrl"] = ImageUrl;
                    dic["CastID"] = CastID;
                    dic["ObjectID"] = ObjectID;
                    dic["CollectionType"] = CollectionType;

                    sh.Update("Casts", dic, "_id", ID);

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

                    sh.Execute("DELETE FROM Casts WHERE CollectionType=1 and _id=" + ID);

                    conn.Close();
                }
            }
        }
    }

}
