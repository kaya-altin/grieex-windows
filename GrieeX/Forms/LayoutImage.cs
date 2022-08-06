using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrieeX.GrieeXBase;
using DevExpress.XtraBars.Ribbon;
using System.IO;

namespace GrieeX.UserControls
{
    public partial class LayoutImage : UserControl
    {
        public LayoutImage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void DataBind()
        {
            if (!bw.IsBusy)
            bw.RunWorkerAsync();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            string strSQL, strSQL_ = string.Empty;
            int n = 0;
            strSQL_ = " WHERE ";
            string strFileName = string.Empty;

            strSQL = "SELECT * From tMovies";


            DataTable dt = Data.Execute(strSQL, Data.ReturnType.Datatable) as DataTable;

            GalleryItemGroup group = new GalleryItemGroup();
            //   group.CaptionControl.Visible = false;
            mainGallery.Gallery.Groups.Add(group);


            mainGallery.Gallery.BeginUpdate();

            foreach (DataRow dr in dt.Rows)
            {

                strFileName = String.Format(@"{0}\Images\{1}.jpg", Application.StartupPath, dr["kMovie"]);
                if (File.Exists(strFileName))
                {
                    GalleryItem item = new GalleryItem();
                    //item.Tag = "Test";
                    item.Image = ThumbnailHelper.Default.GetThumbnail(strFileName, 200, Application.StartupPath + @"\Thumbs\");
                    item.Caption = dr["strOrginalName"].ToString();
           
                    //item.Description = dr["strYear"].ToString();
                  
                    group.Items.Add(item);
                }


            }

            mainGallery.Gallery.EndUpdate();
        }

        private void beZoom_EditValueChanged(object sender, EventArgs e)
        {
            mainGallery.Gallery.ImageSize = new Size(beZoom.Value, beZoom.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBind();
        }

    }
}
