namespace GrieeX.Forms
{
    partial class frmImportExport
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
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.cbUserColumn4 = new System.Windows.Forms.ComboBox();
            this.lblUserColumn4 = new System.Windows.Forms.Label();
            this.cbUserColumn3 = new System.Windows.Forms.ComboBox();
            this.lblUserColumn3 = new System.Windows.Forms.Label();
            this.cbUserColumn2 = new System.Windows.Forms.ComboBox();
            this.lblUserColumn2 = new System.Windows.Forms.Label();
            this.cbUserColumn1 = new System.Windows.Forms.ComboBox();
            this.lblUserColumn1 = new System.Windows.Forms.Label();
            this.cbArchivesNumber = new System.Windows.Forms.ComboBox();
            this.cbSeen = new System.Windows.Forms.ComboBox();
            this.lblArchivesNumber = new System.Windows.Forms.Label();
            this.lblSeen = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.dsFilesImportExport = new GrieeX.DataSets.dsFilesImportExport();
            this.StatusStrip.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFilesImportExport)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripProgressBar});
            this.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip.Location = new System.Drawing.Point(0, 256);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(432, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 21;
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.AutoSize = false;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(310, 16);
            this.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.cbUserColumn4);
            this.GroupBox2.Controls.Add(this.lblUserColumn4);
            this.GroupBox2.Controls.Add(this.cbUserColumn3);
            this.GroupBox2.Controls.Add(this.lblUserColumn3);
            this.GroupBox2.Controls.Add(this.cbUserColumn2);
            this.GroupBox2.Controls.Add(this.lblUserColumn2);
            this.GroupBox2.Controls.Add(this.cbUserColumn1);
            this.GroupBox2.Controls.Add(this.lblUserColumn1);
            this.GroupBox2.Controls.Add(this.cbArchivesNumber);
            this.GroupBox2.Controls.Add(this.cbSeen);
            this.GroupBox2.Controls.Add(this.lblArchivesNumber);
            this.GroupBox2.Controls.Add(this.lblSeen);
            this.GroupBox2.Location = new System.Drawing.Point(11, 94);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(411, 156);
            this.GroupBox2.TabIndex = 161;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Alan Seçimi";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(245, 14);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(145, 21);
            this.Button1.TabIndex = 167;
            this.Button1.Text = "Resim Klasörü Seç";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Visible = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbUserColumn4
            // 
            this.cbUserColumn4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserColumn4.FormattingEnabled = true;
            this.cbUserColumn4.Location = new System.Drawing.Point(104, 128);
            this.cbUserColumn4.MaxDropDownItems = 11;
            this.cbUserColumn4.Name = "cbUserColumn4";
            this.cbUserColumn4.Size = new System.Drawing.Size(121, 21);
            this.cbUserColumn4.TabIndex = 166;
            // 
            // lblUserColumn4
            // 
            this.lblUserColumn4.AutoSize = true;
            this.lblUserColumn4.Location = new System.Drawing.Point(8, 131);
            this.lblUserColumn4.Name = "lblUserColumn4";
            this.lblUserColumn4.Size = new System.Drawing.Size(49, 13);
            this.lblUserColumn4.TabIndex = 165;
            this.lblUserColumn4.Text = "4. Alan =";
            // 
            // cbUserColumn3
            // 
            this.cbUserColumn3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserColumn3.FormattingEnabled = true;
            this.cbUserColumn3.Location = new System.Drawing.Point(104, 106);
            this.cbUserColumn3.MaxDropDownItems = 11;
            this.cbUserColumn3.Name = "cbUserColumn3";
            this.cbUserColumn3.Size = new System.Drawing.Size(121, 21);
            this.cbUserColumn3.TabIndex = 164;
            // 
            // lblUserColumn3
            // 
            this.lblUserColumn3.AutoSize = true;
            this.lblUserColumn3.Location = new System.Drawing.Point(8, 109);
            this.lblUserColumn3.Name = "lblUserColumn3";
            this.lblUserColumn3.Size = new System.Drawing.Size(49, 13);
            this.lblUserColumn3.TabIndex = 163;
            this.lblUserColumn3.Text = "3. Alan =";
            // 
            // cbUserColumn2
            // 
            this.cbUserColumn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserColumn2.FormattingEnabled = true;
            this.cbUserColumn2.Location = new System.Drawing.Point(104, 83);
            this.cbUserColumn2.MaxDropDownItems = 11;
            this.cbUserColumn2.Name = "cbUserColumn2";
            this.cbUserColumn2.Size = new System.Drawing.Size(121, 21);
            this.cbUserColumn2.TabIndex = 162;
            // 
            // lblUserColumn2
            // 
            this.lblUserColumn2.AutoSize = true;
            this.lblUserColumn2.Location = new System.Drawing.Point(8, 86);
            this.lblUserColumn2.Name = "lblUserColumn2";
            this.lblUserColumn2.Size = new System.Drawing.Size(49, 13);
            this.lblUserColumn2.TabIndex = 161;
            this.lblUserColumn2.Text = "2. Alan =";
            // 
            // cbUserColumn1
            // 
            this.cbUserColumn1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserColumn1.FormattingEnabled = true;
            this.cbUserColumn1.Location = new System.Drawing.Point(104, 60);
            this.cbUserColumn1.MaxDropDownItems = 11;
            this.cbUserColumn1.Name = "cbUserColumn1";
            this.cbUserColumn1.Size = new System.Drawing.Size(121, 21);
            this.cbUserColumn1.TabIndex = 160;
            // 
            // lblUserColumn1
            // 
            this.lblUserColumn1.AutoSize = true;
            this.lblUserColumn1.Location = new System.Drawing.Point(8, 63);
            this.lblUserColumn1.Name = "lblUserColumn1";
            this.lblUserColumn1.Size = new System.Drawing.Size(49, 13);
            this.lblUserColumn1.TabIndex = 159;
            this.lblUserColumn1.Text = "1. Alan =";
            // 
            // cbArchivesNumber
            // 
            this.cbArchivesNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArchivesNumber.FormattingEnabled = true;
            this.cbArchivesNumber.Location = new System.Drawing.Point(104, 14);
            this.cbArchivesNumber.MaxDropDownItems = 11;
            this.cbArchivesNumber.Name = "cbArchivesNumber";
            this.cbArchivesNumber.Size = new System.Drawing.Size(121, 21);
            this.cbArchivesNumber.TabIndex = 156;
            // 
            // cbSeen
            // 
            this.cbSeen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeen.FormattingEnabled = true;
            this.cbSeen.Location = new System.Drawing.Point(104, 37);
            this.cbSeen.MaxDropDownItems = 11;
            this.cbSeen.Name = "cbSeen";
            this.cbSeen.Size = new System.Drawing.Size(121, 21);
            this.cbSeen.TabIndex = 158;
            // 
            // lblArchivesNumber
            // 
            this.lblArchivesNumber.AutoSize = true;
            this.lblArchivesNumber.Location = new System.Drawing.Point(8, 17);
            this.lblArchivesNumber.Name = "lblArchivesNumber";
            this.lblArchivesNumber.Size = new System.Drawing.Size(59, 13);
            this.lblArchivesNumber.TabIndex = 22;
            this.lblArchivesNumber.Text = "Arşiv No = ";
            // 
            // lblSeen
            // 
            this.lblSeen.AutoSize = true;
            this.lblSeen.Location = new System.Drawing.Point(8, 40);
            this.lblSeen.Name = "lblSeen";
            this.lblSeen.Size = new System.Drawing.Size(95, 13);
            this.lblSeen.TabIndex = 157;
            this.lblSeen.Text = "İzlenme Durumu = ";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnCancel);
            this.GroupBox1.Controls.Add(this.lblDatabase);
            this.GroupBox1.Controls.Add(this.txtDatabase);
            this.GroupBox1.Controls.Add(this.btnImport);
            this.GroupBox1.Controls.Add(this.lblCount);
            this.GroupBox1.Controls.Add(this.txtNo);
            this.GroupBox1.Controls.Add(this.txtCount);
            this.GroupBox1.Controls.Add(this.lblNo);
            this.GroupBox1.Location = new System.Drawing.Point(11, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(411, 87);
            this.GroupBox1.TabIndex = 160;
            this.GroupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(331, 47);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 31);
            this.btnCancel.TabIndex = 159;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(8, 17);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(54, 13);
            this.lblDatabase.TabIndex = 20;
            this.lblDatabase.Text = "Veritabanı";
            // 
            // txtDatabase
            // 
            this.txtDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabase.Location = new System.Drawing.Point(182, 14);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.ReadOnly = true;
            this.txtDatabase.Size = new System.Drawing.Size(142, 20);
            this.txtDatabase.TabIndex = 21;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(331, 13);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(72, 31);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Başlat";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(8, 39);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(128, 13);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "Alınacak toplam film sayısı";
            // 
            // txtNo
            // 
            this.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNo.Location = new System.Drawing.Point(182, 58);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(142, 20);
            this.txtNo.TabIndex = 19;
            this.txtNo.Text = "0";
            // 
            // txtCount
            // 
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCount.Location = new System.Drawing.Point(182, 36);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(142, 20);
            this.txtCount.TabIndex = 17;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(8, 60);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(116, 13);
            this.lblNo.TabIndex = 18;
            this.lblNo.Text = "Alınan toplam film sayısı";
            // 
            // dsFilesImportExport
            // 
            this.dsFilesImportExport.DataSetName = "dsFilesImportExport";
            this.dsFilesImportExport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 278);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.StatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrieeX Import Modülü";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmImportExport_FormClosed);
            this.Load += new System.EventHandler(this.frmImportExport_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFilesImportExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip StatusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ComboBox cbUserColumn4;
        internal System.Windows.Forms.Label lblUserColumn4;
        internal System.Windows.Forms.ComboBox cbUserColumn3;
        internal System.Windows.Forms.Label lblUserColumn3;
        internal System.Windows.Forms.ComboBox cbUserColumn2;
        internal System.Windows.Forms.Label lblUserColumn2;
        internal System.Windows.Forms.ComboBox cbUserColumn1;
        internal System.Windows.Forms.Label lblUserColumn1;
        internal System.Windows.Forms.ComboBox cbArchivesNumber;
        internal System.Windows.Forms.ComboBox cbSeen;
        internal System.Windows.Forms.Label lblArchivesNumber;
        internal System.Windows.Forms.Label lblSeen;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label lblDatabase;
        internal System.Windows.Forms.TextBox txtDatabase;
        internal System.Windows.Forms.Button btnImport;
        internal System.Windows.Forms.Label lblCount;
        internal System.Windows.Forms.TextBox txtNo;
        internal System.Windows.Forms.TextBox txtCount;
        internal System.Windows.Forms.Label lblNo;
        private DataSets.dsFilesImportExport dsFilesImportExport;
    }
}