using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GrieeX.GrieeXBase;
using System.IO;

namespace GrieeX.Forms
{
    public partial class frmImage : DevExpress.XtraEditors.XtraForm
    {
        public frmImage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void ImageShow()
        {
            if (File.Exists(GrieeXSettings.PosterPath + frmMain.GlobalForm.MovieDetail.CurrentMovie.ImdbNumber + @".jpg"))
            {
                pbImage.StartAnimation();
                pbImage.LoadAsync(GrieeXSettings.PosterPath + frmMain.GlobalForm.MovieDetail.CurrentMovie.ImdbNumber + @".jpg");
            }
            else
            {
                pbImage.Properties.SizeMode = PictureSizeMode.Squeeze;
                pbImage.Image = GrieeX.Properties.Resources.GrieeXLogo;
            }

        }

        public void ImageShow(String ImageLocation)
        {
            pbImage.StartAnimation();
            pbImage.LoadAsync(ImageLocation);
        }

        private void pbImage_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void HideButtons()
        {
            btnNext.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnPrevious.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }


        private void KeyEvent(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            int fWidth = this.Width;
            int fHeight = this.Height;


            if (e.KeyCode == Keys.Add & frmMain.GlobalForm.Height > this.Height)
            {
                this.Width = Convert.ToInt32(fWidth * 1.25);
                this.Height = Convert.ToInt32(fHeight * 1.25);
            }

            if (e.KeyCode == Keys.Subtract)
            {
                this.Width = Convert.ToInt32(fWidth / 1.25);
                this.Height = Convert.ToInt32(fHeight / 1.25);
            }
            this.Refresh();


            if (e.KeyCode == Keys.Left)
            {
                frmMain.GlobalForm.gvList.MovePrev();
                ImageShow();
            }

            if (e.KeyCode == Keys.Right)
            {
                frmMain.GlobalForm.gvList.MoveNext();
                ImageShow();
            }
        }


        private void btnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMain.GlobalForm.gvList.MoveNext();
                ImageShow();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMain.GlobalForm.gvList.MovePrev();
                ImageShow();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void pbImage_LoadCompleted(object sender, EventArgs e)
        {
            pbImage.Properties.SizeMode = PictureSizeMode.Stretch;

            int deskHeight = Screen.PrimaryScreen.Bounds.Height;
            int deskWidth = Screen.PrimaryScreen.Bounds.Width;

            int imgHeight = pbImage.Image.Height;
            int imgWidth = pbImage.Image.Width;

            if (deskHeight < imgHeight)
            {
                this.Height = (imgHeight / 2);
                this.Width = (imgWidth / 2);
            }
            else
            {
                this.Height = imgHeight;
                this.Width = imgWidth;
            }

            this.Refresh();
        }

        private void pbImage_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {

        }
    }
}