using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace GrieeX.Forms
{
    public partial class frmHistory : DevExpress.XtraEditors.XtraForm
    {
        public frmHistory()
        {
            InitializeComponent();
            EmitLanguage();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            try
            {
                rtxtHistory.Text = File.ReadAllText(Application.StartupPath + "\\History.ggd", System.Text.Encoding.Default);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
    }
}