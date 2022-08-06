namespace GrieeX.UserControls
{
    partial class LayoutImage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainGallery = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.beZoom = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGallery)).BeginInit();
            this.mainGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beZoom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGallery
            // 
            this.mainGallery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGallery.Controls.Add(this.galleryControlClient1);
            this.mainGallery.DesignGalleryGroupIndex = 0;
            this.mainGallery.DesignGalleryItemIndex = 0;
            // 
            // galleryControlGallery1
            // 
            this.mainGallery.Gallery.Appearance.ItemCaption.Options.UseTextOptions = true;
            this.mainGallery.Gallery.Appearance.ItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.mainGallery.Gallery.Appearance.ItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mainGallery.Gallery.Appearance.ItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.mainGallery.Gallery.ImageSize = new System.Drawing.Size(200, 200);
            this.mainGallery.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.mainGallery.Gallery.ScrollMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryScrollMode.Smooth;
            this.mainGallery.Gallery.ShowGroupCaption = false;
            this.mainGallery.Gallery.ShowItemText = true;
            this.mainGallery.Location = new System.Drawing.Point(3, 29);
            this.mainGallery.Name = "mainGallery";
            this.mainGallery.Size = new System.Drawing.Size(464, 363);
            this.mainGallery.TabIndex = 1;
            this.mainGallery.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.mainGallery;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(443, 359);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridControl1.Location = new System.Drawing.Point(473, 31);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.SelectedObject = this.mainGallery;
            this.propertyGridControl1.Size = new System.Drawing.Size(370, 359);
            this.propertyGridControl1.TabIndex = 3;
            // 
            // beZoom
            // 
            this.beZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.beZoom.EditValue = 200;
            this.beZoom.Location = new System.Drawing.Point(577, 3);
            this.beZoom.Name = "beZoom";
            this.beZoom.Properties.Maximum = 300;
            this.beZoom.Properties.Minimum = 100;
            this.beZoom.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.beZoom.Size = new System.Drawing.Size(247, 20);
            this.beZoom.TabIndex = 2;
            this.beZoom.Value = 200;
            this.beZoom.EditValueChanged += new System.EventHandler(this.beZoom_EditValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LayoutImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.propertyGridControl1);
            this.Controls.Add(this.beZoom);
            this.Controls.Add(this.mainGallery);
            this.Name = "LayoutImage";
            this.Size = new System.Drawing.Size(846, 395);
            ((System.ComponentModel.ISupportInitialize)(this.mainGallery)).EndInit();
            this.mainGallery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beZoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryControl mainGallery;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.ComponentModel.BackgroundWorker bw;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraEditors.ZoomTrackBarControl beZoom;
        private System.Windows.Forms.Button button1;
    }
}
