using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GrieeX.Forms
{
    public partial class frmChangeCast : DevExpress.XtraEditors.XtraForm
    {
        public frmChangeCast()
        {
            InitializeComponent();
            EmitLanguage();
        }

        public bool bOk = false;
        private void btnOk_Click(System.Object sender, System.EventArgs e)
        {
            bOk = true;
            this.Close();
        }

        private void btnCancel_Click(System.Object sender, System.EventArgs e)
        {
            bOk = false;
            this.Close();
        }
    }
}