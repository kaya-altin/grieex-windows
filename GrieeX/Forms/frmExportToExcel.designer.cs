namespace GrieeX.Forms
{
    partial class frmExportToExcel
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
            this.bwExport = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.pbProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.saveFileDialog_SaveExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bwExport
            // 
            this.bwExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwExport_DoWork);
            this.bwExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwExport_RunWorkerCompleted);
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Location = new System.Drawing.Point(82, 94);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(580, 33);
            this.lblStatus.TabIndex = 1;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(80, 30);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(8);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Properties.Step = 1;
            this.pbProgress.Size = new System.Drawing.Size(582, 46);
            this.pbProgress.TabIndex = 3;
            // 
            // frmExportToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 152);
            this.ControlBox = false;
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmExportToExcel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackup_FormClosing);
            this.Load += new System.EventHandler(this.frmBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bwExport;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.ProgressBarControl pbProgress;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SaveExcel;
    }
}