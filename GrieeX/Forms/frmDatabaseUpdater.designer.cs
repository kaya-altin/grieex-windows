namespace GrieeX.Forms
{
    partial class frmDatabaseUpdater
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
            this.bwUpdate = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.pbProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.marqueeProgress = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.bwRepair = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bwUpdate
            // 
            this.bwUpdate.WorkerReportsProgress = true;
            this.bwUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdate_DoWork);
            this.bwUpdate.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwUpdate_ProgressChanged);
            this.bwUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdate_RunWorkerCompleted);
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Location = new System.Drawing.Point(13, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(240, 13);
            this.lblStatus.TabIndex = 1;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(13, 12);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.ShowProgressInTaskBar = true;
            this.pbProgress.Size = new System.Drawing.Size(240, 18);
            this.pbProgress.TabIndex = 3;
            // 
            // marqueeProgress
            // 
            this.marqueeProgress.EditValue = 0;
            this.marqueeProgress.Location = new System.Drawing.Point(13, 12);
            this.marqueeProgress.Name = "marqueeProgress";
            this.marqueeProgress.Size = new System.Drawing.Size(239, 18);
            this.marqueeProgress.TabIndex = 4;
            // 
            // bwRepair
            // 
            this.bwRepair.WorkerReportsProgress = true;
            this.bwRepair.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRepair_DoWork);
            this.bwRepair.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwRepair_ProgressChanged);
            this.bwRepair.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRepair_RunWorkerCompleted);
            // 
            // frmDatabaseUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 51);
            this.ControlBox = false;
            this.Controls.Add(this.marqueeProgress);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDatabaseUpdater";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDatabaseUpdater_FormClosing);
            this.Load += new System.EventHandler(this.frmDatabaseUpdater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bwUpdate;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.ProgressBarControl pbProgress;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgress;
        private System.ComponentModel.BackgroundWorker bwRepair;
    }
}