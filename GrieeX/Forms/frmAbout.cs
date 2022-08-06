using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors;
using GrieeX.GrieeXBase;

namespace GrieeX.Forms
{
    public partial class frmAbout : DevExpress.XtraEditors.XtraForm
    {
        public frmAbout()
        {
            InitializeComponent();
            EmitLanguage();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblV.Text = Util.GrieeXVersion;
        }

        private void btnPayPal_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=4154983");
        }

        private void imgFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.facebook.com/grieex");
        }

        private void imgTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.twitter.com/grieex");
        } 
 
    }
}
