using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GrieeX.GrieeXBase;
using System.Data.SQLite;


namespace GrieeX.Forms
{
    public partial class frmStatistics : DevExpress.XtraEditors.XtraForm
    {
        public frmStatistics()
        {
            InitializeComponent();
            EmitLanguage();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            //Try
            Double iCount = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("cl_Value");
            dt.Columns.Add("cl_Total");
            DataRow row;

            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    

                    //ListView1.Items.Add("Dosya Sayýsý")
                    row = dt.NewRow();
                    iCount = sh.ExecuteScalar<int>("SELECT COUNT(*) FROM Files");
                    row["cl_Value"] = Language.FindKey("Strings", "47").Value;
                    row["cl_Total"] = iCount.ToString();
                    dt.Rows.Add(row);

                    //ListView1.Items.Add("Ýzlenen Film Sayýsý")
                    row = dt.NewRow();
                    iCount = sh.ExecuteScalar<int>("SELECT Count(*) FROM Movies WHERE Seen=1");
                    row["cl_Value"] = Language.FindKey("Strings", "73").Value;
                    row["cl_Total"] = iCount.ToString();
                    dt.Rows.Add(row);

                    //ListView1.Items.Add("Ýzlenmeyen Film Sayýsý")
                    row = dt.NewRow();
                    iCount = sh.ExecuteScalar<int>("SELECT Count(*) FROM Movies WHERE Seen=0");
                    row["cl_Value"] = Language.FindKey("Strings", "74").Value;
                    row["cl_Total"] = iCount.ToString();
                    dt.Rows.Add(row);

                    //ListView1.Items.Add("Dosya Boyutu")
                    //Durmuþ
                    //try
                    //{
                    //    iCount = Convert.ToInt64(Data.Execute("SELECT Sum(strFileSize) FROM tFiles WHERE (((tFiles.[strFileSize])<>\"\"));", Data.ReturnType.Scalar));
                    //}
                    //catch (Exception)
                    //{
                    //    iCount = 0;
                    //}
                    //if (iCount != 0)
                    //{
                    //    row = dt.NewRow();
                    //    row["cl_Value"] = Language.FindKey("Strings", "33").Value;
                    //    row["cl_Total"] = String.Format("{0:n}", iCount / Convert.ToInt32(Enums.ByteTypes.MegaByte)) + " MB & " + String.Format("{0:n}", iCount / Convert.ToInt32(Enums.ByteTypes.GigaByte)) + " GB";
                    //    dt.Rows.Add(row);
                    //}
                    //else
                    //{
                    //    row = dt.NewRow();
                    //    row["cl_Value"] = Language.FindKey("Strings", "33").Value;
                    //    row["cl_Total"] = "Yok";
                    //    dt.Rows.Add(row);
                    //}

                    //ListView1.Items.Add("Süre")
                    //Durmuþ
                    //try
                    //{
                    //    iCount = Convert.ToInt64(Data.Execute("SELECT Sum(strLenght) FROM tFiles WHERE (((tFiles.[strLenght])<>\"\"));", Data.ReturnType.Scalar));
                    //}
                    //catch (Exception)
                    //{
                    //    iCount = 0;
                    //}
                    //if (iCount != 0)
                    //{
                    //    row = dt.NewRow();
                    //    row["cl_Value"] = Language.FindKey("Strings", "8").Value;
                    //    row["cl_Total"] = Util.FormatTime(Convert.ToDouble(iCount)).ToString();
                    //    dt.Rows.Add(row);
                    //}
                    //else
                    //{
                    //    row = dt.NewRow();
                    //    row["cl_Value"] = Language.FindKey("Strings", "8").Value;
                    //    row["cl_Total"] = "Yok";
                    //    dt.Rows.Add(row);
                    //}

                    dgGeneral.DataSource = dt;


                    conn.Close();
                }
            }


            //Catch ex As Exception
            //    MsgBox(ex.Message.ToString)
            //End Try
        }

        private void lvStatistics_Click(object sender, EventArgs e)
        {
            string strSQL = string.Empty;

            switch (lvStatistics.FocusedItem.Index)
            {
                case 0:
                    strSQL = "SELECT Movies.Director AS str, Count(Movies.Director) AS [Count] FROM Movies GROUP BY Movies.Director HAVING Movies.Director<>\"\" ORDER BY Movies.Director";
                    break;
                case 1:
                    strSQL = "SELECT Movies.Year AS str, Count(Movies.Year) AS [Count] FROM Movies GROUP BY Movies.Year HAVING Movies.Year<>\"\" ORDER BY Movies.Year";
                    break;
                case 2:
                    strSQL = "SELECT Movies.Genre AS str, Count(Movies.Genre) AS [Count] FROM Movies GROUP BY Movies.Genre HAVING Movies.Genre<>\"\" ORDER BY Movies.Genre";
                    break;
                case 3:
                    strSQL = "SELECT Files.VideoCodec AS str, Count(Files.VideoCodec) AS [Count] FROM Files GROUP BY Files.VideoCodec HAVING Files.VideoCodec<>\"\" ORDER BY Files.VideoCodec";
                    break;
                case 4:
                    strSQL = "SELECT Files.AudioCodec1 AS str, Count(Files.AudioCodec1) AS [Count] FROM Files GROUP BY Files.AudioCodec1 HAVING Files.AudioCodec1<>\"\" ORDER BY Files.AudioCodec1";
                    break;
                case 5:
                    strSQL = "SELECT Files.AudioCodec2 AS str, Count(Files.AudioCodec2) AS [Count] FROM Files GROUP BY Files.AudioCodec2 HAVING Files.AudioCodec2<>\"\" ORDER BY Files.AudioCodec2";
                    break;
                case 6:
                    strSQL = "SELECT Subtitle AS str, Count(Subtitle) AS [Count] FROM Movies GROUP BY Subtitle HAVING Subtitle<>\"\" ORDER BY Subtitle";
                    break;
                case 7:
                    strSQL = "SELECT Dubbing AS str, Count(Dubbing) AS [Count] FROM Movies GROUP BY Dubbing HAVING Dubbing<>\"\" ORDER BY Dubbing";
                    break;
            }

            if (strSQL != string.Empty)
            {
                using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        DataTable dt = sh.Select(strSQL);
                        dGrid.DataSource = dt;

                        conn.Close();
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}