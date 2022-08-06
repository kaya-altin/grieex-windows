using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using DevExpress.Utils.Drawing;
using System.IO;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GrieeX.GrieeXBase
{
    public class ThumbnailHelper
    {
        static ThumbnailHelper defaultHelper;
        public static ThumbnailHelper Default
        {
            get
            {
                if (defaultHelper == null)
                    defaultHelper = new ThumbnailHelper();
                return defaultHelper;
            }
        }

        Dictionary<string, Image> thumbnails;
        protected Dictionary<string, Image> Thumbnails
        {
            get
            {
                if (thumbnails == null)
                    thumbnails = new Dictionary<string, Image>();
                return thumbnails;
            }
        }

        public Image CreateThumbnail(Image image, int length)
        {
            Rectangle rect = ImageLayoutHelper.GetImageBounds(new Rectangle(0, 0, length, length), image.Size, ImageLayoutMode.ZoomInside);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                rect.X = 0;
                rect.Y = 0;
                g.DrawImage(image, rect);
            }
            return bmp;
        }
        public Image CreateThumbnail(Image image, string fileName, int length, string thumbPath)
        {
            Image bmp = CreateThumbnail(image, length);
            string thumbFileName = length.ToString() + "_" + fileName;
            string md5hash = CalculateMD5Hash(thumbFileName);
            try
            {
                if (!Directory.Exists(thumbPath))
                {
                    Directory.CreateDirectory(thumbPath);
                }
                string finalFileName = thumbPath + md5hash;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error creating thumnail for image '" + fileName + "'. " + e.Message, "Thumbnail creator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bmp;
        }
        public string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public Image GetThumbnail(string fileName, int length, string thumbPath)
        {
            string thumbFileName = length.ToString() + "_" + fileName;
            thumbFileName = CalculateMD5Hash(thumbFileName);
            thumbFileName = thumbPath + thumbFileName;
            if (Thumbnails.ContainsKey(thumbFileName))
                return Thumbnails[thumbFileName];
            try
            {
                if (File.Exists(thumbFileName))
                    return Image.FromFile(thumbFileName);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error creating thumnail for image '" + fileName + "'. " + e.Message, "Thumbnail creator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (Image img = Image.FromFile(fileName))
            {
                return CreateThumbnail(img, fileName, length, thumbPath);
            }
        }
    }
}
