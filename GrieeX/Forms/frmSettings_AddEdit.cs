using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrieeX.GrieeXBase;
using System.Data.SQLite;

namespace GrieeX.Forms
{
    public partial class frmSettings_AddEdit : DevExpress.XtraEditors.XtraForm
    {
        public frmSettings_AddEdit()
        {
            InitializeComponent();
        }

        public int k;
        public Enums.RecordType RecordType;
        public string strKey, strColumn, strTable;

        private void btnOk_Click(object sender, EventArgs e)
        {
            RecordSave();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RecordSave()
        {
            using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    var dic = new Dictionary<string, object>();
                    dic[strColumn] = txtS1.Text;
                    if (RecordType == Enums.RecordType.Insert)
                    {
                        sh.Insert(strTable, dic);
                    }
                    if (RecordType == Enums.RecordType.Update)
                    {
                        sh.Update("Movies", dic, strKey, k.ToString());
                    }


                    conn.Close();
                }
            }
        }
    }
}
