namespace GrieeX.Forms
{
    partial class frmBackup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bwBackup = new System.ComponentModel.BackgroundWorker();
            this.bwRestore = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.pbProgress = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bwBackup
            // 
            this.bwBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwBackup_DoWork);
            this.bwBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwBackup_RunWorkerCompleted);
            // 
            // bwRestore
            // 
            this.bwRestore.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRestore_DoWork);
            this.bwRestore.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRestore_RunWorkerCompleted);
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.Options.UseTextOptions = true;
            this.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Location = new System.Drawing.Point(13, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(240, 13);
            this.lblStatus.TabIndex = 1;
            // 
            // pbProgress
            // 
            this.pbProgress.EditValue = 0;
            this.pbProgress.Location = new System.Drawing.Point(12, 12);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(241, 18);
            this.pbProgress.TabIndex = 2;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 67);
            this.ControlBox = false;
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBackup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackup_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bwBackup;
        private System.ComponentModel.BackgroundWorker bwRestore;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.MarqueeProgressBarControl pbProgress;
    }
}