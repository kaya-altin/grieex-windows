using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrieeX.GrieeXBase;
using DevExpress.XtraEditors.Controls;
using System.Data.SQLite;

namespace GrieeX.Forms
{
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        public frmSettings()
        {
            InitializeComponent();
            EmitLanguage();
        }

        private string strSQL, strKey, strColumn, strTable;

        private void frmSettings_Load(object sender, EventArgs e)
        {
            foreach (Key item in Language.FindSection("Languages").Keys)
            {
                CheckedListBoxItem itemSubTitle = new CheckedListBoxItem();
                itemSubTitle.CheckState = CheckState.Unchecked;
                itemSubTitle.Value = item.Name;
                itemSubTitle.Description = item.Value;
                cbSubTitle.Properties.Items.Add(itemSubTitle);

                CheckedListBoxItem itemDubbing = new CheckedListBoxItem();
                itemDubbing.CheckState = CheckState.Unchecked;
                itemDubbing.Value = item.Name;
                itemDubbing.Description = item.Value;
                cbDubbing.Properties.Items.Add(itemDubbing);
            }
          
            txtUserColumn1.Text = Settings.UserColumn1;
            txtUserColumn2.Text = Settings.UserColumn2;
            txtUserColumn3.Text = Settings.UserColumn3;
            txtUserColumn4.Text = Settings.UserColumn4;
            txtUserColumn5.Text = Settings.UserColumn5;
            txtUserColumn6.Text = Settings.UserColumn6;
            chkStartUpVersionControl.Checked = Settings.StartUpVersionControl;
            chkImageLeft.Checked = Settings.ImageLeft;
            chkAutoClose.Checked = Settings.AutoClose;
            chkAutoNewRecord.Checked = Settings.AutoNewRecord;
            chkThe.Checked = Settings.The;
            chkShowCastImage.Checked = Settings.ShowCastImage;
            txtPlayer.Text = Settings.Player;
            if (!string.IsNullOrEmpty(Settings.DefaultDubbing)) cbDubbing.SetEditValue(Settings.DefaultDubbing);
            if (!string.IsNullOrEmpty(Settings.DefaultSubtitle)) cbSubTitle.SetEditValue(Settings.DefaultSubtitle);

            chkProxy.Checked = Settings.UseProxy;
            txtProxyServer.Text = Settings.ProxyServer;
            txtProxyPort.Value = Settings.ProxyPort;
            txtProxyUserName.Text = Settings.ProxyUserName;
            txtProxyPassword.Text = Settings.ProxyPassword;

            //Me.cbLanguage.Items.Add("Turkish (Default)")

            string[] splitter = null;
            string s = null;
            string shortName = null;
            foreach (string s_loopVariable in System.IO.Directory.GetFiles(Application.StartupPath + "\\Languages\\"))
            {
                s = s_loopVariable;
                splitter = s.Split('.');
                if (splitter[splitter.GetUpperBound(0)] == "ini")
                {
                    splitter = s.Split('\\');
                    shortName = splitter[splitter.GetUpperBound(0)];
                    shortName = shortName.Replace(".ini", "");
                    this.cbLanguage.Items.Add(shortName);
                }
            }

            cbLanguage.SelectedItem = Settings.Language;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.UserColumn1 = txtUserColumn1.Text;
            Settings.UserColumn2 = txtUserColumn2.Text;
            Settings.UserColumn3 = txtUserColumn3.Text;
            Settings.UserColumn4 = txtUserColumn4.Text;
            Settings.UserColumn5 = txtUserColumn5.Text;
            Settings.UserColumn6 = txtUserColumn6.Text;
            Settings.StartUpVersionControl = chkStartUpVersionControl.Checked;
            Settings.ImageLeft = chkImageLeft.Checked;
            Settings.Language = cbLanguage.Text;
            Settings.AutoClose = chkAutoClose.Checked;
            Settings.AutoNewRecord = chkAutoNewRecord.Checked;
            Settings.Player = txtPlayer.Text;
            Settings.DefaultDubbing = cbDubbing.EditValue.ToString();
            Settings.DefaultSubtitle = cbSubTitle.EditValue.ToString();
            Settings.UseProxy = chkProxy.Checked;
            Settings.ProxyServer = txtProxyServer.Text;
            Settings.ProxyPort = (int)txtProxyPort.Value;
            Settings.ProxyUserName = txtProxyUserName.Text;
            Settings.ProxyPassword = txtProxyPassword.Text;
            Settings.The = chkThe.Checked;
            Settings.ShowCastImage = chkShowCastImage.Checked;

            Settings.Save();

            if (Settings.ShowCastImage)
            {
                frmMain.GlobalForm.MovieDetail.imageColumn.Visible = true;
                frmMovie.GlobalForm.MovieDetail.imageColumn.Visible = true;
            }
            else
            {
                frmMain.GlobalForm.MovieDetail.imageColumn.Visible = false;
                frmMovie.GlobalForm.MovieDetail.imageColumn.Visible = false;
            }


            this.Close();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(Language.FindKey("Messages", "1").Value, "GrieeX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(GrieeXSettings.DataSource))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand())
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            SQLiteHelper sh = new SQLiteHelper(cmd);

                            sh.Execute("DELETE FROM " + strTable + " WHERE " + strKey + "=" + dGrid.CurrentRow.Cells["cl_k"].Value);

                            conn.Close();
                        }
                    }
                    Search();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }

        private void dGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmSettings_AddEdit frm = new frmSettings_AddEdit();
                //k = dGrid.CurrentRow.Cells("cl_k").Value
                frm.RecordType = Enums.RecordType.Update;
                frm.k = Convert.ToInt32(dGrid.CurrentRow.Cells["cl_k"].Value);
                frm.lblS1.Text = dGrid.Columns["cl_str"].HeaderText;
                frm.txtS1.Text = dGrid.CurrentRow.Cells["cl_str"].Value.ToString();
                frm.strColumn = strColumn;
                frm.strKey = strKey;
                frm.strTable = strTable;
                frm.ShowDialog();
                Search();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSettings_AddEdit frm = new frmSettings_AddEdit();
            frm.RecordType = Enums.RecordType.Insert;
            frm.lblS1.Text = dGrid.Columns["cl_str"].HeaderText;
            frm.strColumn = strColumn;
            frm.strKey = strKey;
            frm.strTable = strTable;
            frm.ShowDialog();
            Search();
        }

        public void Search()
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

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TreeView1.Nodes["ndGeneral"].IsSelected == true)
            {
                TabControl1.SelectTab(TabPage1);
            }
                       else if (TreeView1.Nodes["ndPersonalColumns"].IsSelected == true)
            {
                TabControl1.SelectTab(TabPage3);
            }
            else if (TreeView1.Nodes["ndDefaultValues"].IsSelected == true)
            {
                TabControl1.SelectTab(TabPage4);
            }
            else if (TreeView1.Nodes["ndConnection"].IsSelected == true)
            {
                TabControl1.SelectTab(TabPage5);
            }
        }

        private void btnPlayerSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog FO = new OpenFileDialog();
            DialogResult Svar = default(DialogResult);
            FO.Filter = "(*.exe)|*.exe";

            Svar = FO.ShowDialog();
            if (!(Svar == DialogResult.OK)) return;


            txtPlayer.Text = FO.FileName;
        }

        private void chkProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProxy.Checked == true)
            {
                panelProxy.Enabled = true;
            }
            else
            {
                panelProxy.Enabled = false;
            }
        }
    }
}
