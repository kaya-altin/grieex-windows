namespace GrieeX.Forms
{
    partial class frmSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Genel");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Kişisel Kolonlar");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Varsayılan Değerler");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Bağlantı");
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.grbPlayer = new System.Windows.Forms.GroupBox();
            this.btnPlayerSelect = new System.Windows.Forms.Button();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.grbRecord = new System.Windows.Forms.GroupBox();
            this.chkAutoNewRecord = new System.Windows.Forms.CheckBox();
            this.chkAutoClose = new System.Windows.Forms.CheckBox();
            this.grbLanguage = new System.Windows.Forms.GroupBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.grbGeneral = new System.Windows.Forms.GroupBox();
            this.chkThe = new System.Windows.Forms.CheckBox();
            this.chkStartUpVersionControl = new System.Windows.Forms.CheckBox();
            this.chkImageLeft = new System.Windows.Forms.CheckBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.cl_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_str = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.grbPersonalColumns = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserColumn6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserColumn5 = new System.Windows.Forms.TextBox();
            this.lblUserColumn4 = new System.Windows.Forms.Label();
            this.txtUserColumn4 = new System.Windows.Forms.TextBox();
            this.lblUserColumn3 = new System.Windows.Forms.Label();
            this.txtUserColumn3 = new System.Windows.Forms.TextBox();
            this.lblUserColumn2 = new System.Windows.Forms.Label();
            this.txtUserColumn2 = new System.Windows.Forms.TextBox();
            this.lblUserColumn1 = new System.Windows.Forms.Label();
            this.txtUserColumn1 = new System.Windows.Forms.TextBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDubbing = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cbSubTitle = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblDubbing = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.chkProxy = new DevExpress.XtraEditors.CheckEdit();
            this.panelProxy = new DevExpress.XtraEditors.PanelControl();
            this.txtProxyPort = new DevExpress.XtraEditors.SpinEdit();
            this.txtProxyServer = new DevExpress.XtraEditors.TextEdit();
            this.txtProxyPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblProxyServer = new DevExpress.XtraEditors.LabelControl();
            this.lblProxyPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblProxyPort = new DevExpress.XtraEditors.LabelControl();
            this.txtProxyUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblProxyUserName = new DevExpress.XtraEditors.LabelControl();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.chkShowCastImage = new System.Windows.Forms.CheckBox();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.grbPlayer.SuspendLayout();
            this.grbRecord.SuspendLayout();
            this.grbLanguage.SuspendLayout();
            this.grbGeneral.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.TabPage3.SuspendLayout();
            this.grbPersonalColumns.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDubbing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubTitle.Properties)).BeginInit();
            this.TabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkProxy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelProxy)).BeginInit();
            this.panelProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(174, -22);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(348, 332);
            this.TabControl1.TabIndex = 19;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.White;
            this.TabPage1.Controls.Add(this.grbPlayer);
            this.TabPage1.Controls.Add(this.grbRecord);
            this.TabPage1.Controls.Add(this.grbLanguage);
            this.TabPage1.Controls.Add(this.grbGeneral);
            this.TabPage1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(340, 303);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "TabPage1";
            // 
            // grbPlayer
            // 
            this.grbPlayer.Controls.Add(this.btnPlayerSelect);
            this.grbPlayer.Controls.Add(this.txtPlayer);
            this.grbPlayer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grbPlayer.Location = new System.Drawing.Point(25, 249);
            this.grbPlayer.Name = "grbPlayer";
            this.grbPlayer.Size = new System.Drawing.Size(298, 47);
            this.grbPlayer.TabIndex = 11;
            this.grbPlayer.TabStop = false;
            this.grbPlayer.Text = "Oynatıcı";
            // 
            // btnPlayerSelect
            // 
            this.btnPlayerSelect.Location = new System.Drawing.Point(240, 17);
            this.btnPlayerSelect.Name = "btnPlayerSelect";
            this.btnPlayerSelect.Size = new System.Drawing.Size(51, 23);
            this.btnPlayerSelect.TabIndex = 10;
            this.btnPlayerSelect.Text = "Seç";
            this.btnPlayerSelect.UseVisualStyleBackColor = true;
            this.btnPlayerSelect.Click += new System.EventHandler(this.btnPlayerSelect_Click);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(6, 19);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(232, 21);
            this.txtPlayer.TabIndex = 9;
            // 
            // grbRecord
            // 
            this.grbRecord.Controls.Add(this.chkAutoNewRecord);
            this.grbRecord.Controls.Add(this.chkAutoClose);
            this.grbRecord.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grbRecord.Location = new System.Drawing.Point(25, 125);
            this.grbRecord.Name = "grbRecord";
            this.grbRecord.Size = new System.Drawing.Size(298, 71);
            this.grbRecord.TabIndex = 8;
            this.grbRecord.TabStop = false;
            this.grbRecord.Text = "Kaydet tuşuna basıldığında";
            // 
            // chkAutoNewRecord
            // 
            this.chkAutoNewRecord.AutoSize = true;
            this.chkAutoNewRecord.Checked = true;
            this.chkAutoNewRecord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoNewRecord.Location = new System.Drawing.Point(9, 45);
            this.chkAutoNewRecord.Name = "chkAutoNewRecord";
            this.chkAutoNewRecord.Size = new System.Drawing.Size(118, 17);
            this.chkAutoNewRecord.TabIndex = 4;
            this.chkAutoNewRecord.Text = "Otomatik yeni kayıt";
            this.chkAutoNewRecord.UseVisualStyleBackColor = true;
            // 
            // chkAutoClose
            // 
            this.chkAutoClose.AutoSize = true;
            this.chkAutoClose.Checked = true;
            this.chkAutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoClose.Location = new System.Drawing.Point(9, 22);
            this.chkAutoClose.Name = "chkAutoClose";
            this.chkAutoClose.Size = new System.Drawing.Size(106, 17);
            this.chkAutoClose.TabIndex = 3;
            this.chkAutoClose.Text = "Film kartını kapat";
            this.chkAutoClose.UseVisualStyleBackColor = true;
            // 
            // grbLanguage
            // 
            this.grbLanguage.Controls.Add(this.cbLanguage);
            this.grbLanguage.Controls.Add(this.lblLanguage);
            this.grbLanguage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grbLanguage.Location = new System.Drawing.Point(25, 198);
            this.grbLanguage.Name = "grbLanguage";
            this.grbLanguage.Size = new System.Drawing.Size(298, 46);
            this.grbLanguage.TabIndex = 7;
            this.grbLanguage.TabStop = false;
            this.grbLanguage.Text = "Dil";
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(95, 16);
            this.cbLanguage.MaxDropDownItems = 15;
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(178, 21);
            this.cbLanguage.TabIndex = 146;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoEllipsis = true;
            this.lblLanguage.ForeColor = System.Drawing.Color.Black;
            this.lblLanguage.Location = new System.Drawing.Point(9, 20);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(85, 13);
            this.lblLanguage.TabIndex = 147;
            this.lblLanguage.Text = "Dil";
            // 
            // grbGeneral
            // 
            this.grbGeneral.Controls.Add(this.chkShowCastImage);
            this.grbGeneral.Controls.Add(this.chkThe);
            this.grbGeneral.Controls.Add(this.chkStartUpVersionControl);
            this.grbGeneral.Controls.Add(this.chkImageLeft);
            this.grbGeneral.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grbGeneral.Location = new System.Drawing.Point(25, 6);
            this.grbGeneral.Name = "grbGeneral";
            this.grbGeneral.Size = new System.Drawing.Size(298, 112);
            this.grbGeneral.TabIndex = 6;
            this.grbGeneral.TabStop = false;
            this.grbGeneral.Text = "Genel";
            // 
            // chkThe
            // 
            this.chkThe.AutoSize = true;
            this.chkThe.Checked = true;
            this.chkThe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkThe.Location = new System.Drawing.Point(9, 61);
            this.chkThe.Name = "chkThe";
            this.chkThe.Size = new System.Drawing.Size(117, 17);
            this.chkThe.TabIndex = 4;
            this.chkThe.Text = "\"The\" ekini sona al.";
            this.chkThe.UseVisualStyleBackColor = true;
            // 
            // chkStartUpVersionControl
            // 
            this.chkStartUpVersionControl.AutoSize = true;
            this.chkStartUpVersionControl.Checked = true;
            this.chkStartUpVersionControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStartUpVersionControl.Location = new System.Drawing.Point(9, 19);
            this.chkStartUpVersionControl.Name = "chkStartUpVersionControl";
            this.chkStartUpVersionControl.Size = new System.Drawing.Size(177, 17);
            this.chkStartUpVersionControl.TabIndex = 3;
            this.chkStartUpVersionControl.Text = "Açılışta yeni sürüm kontrolü yap";
            this.chkStartUpVersionControl.UseVisualStyleBackColor = true;
            // 
            // chkImageLeft
            // 
            this.chkImageLeft.AutoSize = true;
            this.chkImageLeft.Checked = true;
            this.chkImageLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImageLeft.Location = new System.Drawing.Point(9, 40);
            this.chkImageLeft.Name = "chkImageLeft";
            this.chkImageLeft.Size = new System.Drawing.Size(165, 17);
            this.chkImageLeft.TabIndex = 1;
            this.chkImageLeft.Text = "Resim Ön İzleme\'yi sola yasla";
            this.chkImageLeft.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.White;
            this.TabPage2.Controls.Add(this.dGrid);
            this.TabPage2.Controls.Add(this.btnAdd);
            this.TabPage2.Controls.Add(this.btnRemove);
            this.TabPage2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TabPage2.Location = new System.Drawing.Point(4, 25);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(340, 303);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "TabPage2";
            // 
            // dGrid
            // 
            this.dGrid.AllowDrop = true;
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.AllowUserToOrderColumns = true;
            this.dGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid.BackgroundColor = System.Drawing.Color.White;
            this.dGrid.ColumnHeadersHeight = 22;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_k,
            this.cl_str});
            this.dGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dGrid.Location = new System.Drawing.Point(6, 6);
            this.dGrid.Name = "dGrid";
            this.dGrid.ReadOnly = true;
            this.dGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dGrid.RowHeadersVisible = false;
            this.dGrid.RowHeadersWidth = 22;
            this.dGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGrid.RowTemplate.Height = 17;
            this.dGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid.ShowCellToolTips = false;
            this.dGrid.Size = new System.Drawing.Size(328, 211);
            this.dGrid.TabIndex = 10;
            this.dGrid.DoubleClick += new System.EventHandler(this.dGrid_DoubleClick);
            // 
            // cl_k
            // 
            this.cl_k.DataPropertyName = "k";
            this.cl_k.HeaderText = "kMovie";
            this.cl_k.Name = "cl_k";
            this.cl_k.ReadOnly = true;
            this.cl_k.Visible = false;
            // 
            // cl_str
            // 
            this.cl_str.DataPropertyName = "str";
            this.cl_str.HeaderText = "Orjinal İsim";
            this.cl_str.Name = "cl_str";
            this.cl_str.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(309, 224);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(25, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.White;
            this.TabPage3.Controls.Add(this.grbPersonalColumns);
            this.TabPage3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TabPage3.Location = new System.Drawing.Point(4, 25);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(340, 303);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "TabPage3";
            // 
            // grbPersonalColumns
            // 
            this.grbPersonalColumns.Controls.Add(this.label2);
            this.grbPersonalColumns.Controls.Add(this.txtUserColumn6);
            this.grbPersonalColumns.Controls.Add(this.label1);
            this.grbPersonalColumns.Controls.Add(this.txtUserColumn5);
            this.grbPersonalColumns.Controls.Add(this.lblUserColumn4);
            this.grbPersonalColumns.Controls.Add(this.txtUserColumn4);
            this.grbPersonalColumns.Controls.Add(this.lblUserColumn3);
            this.grbPersonalColumns.Controls.Add(this.txtUserColumn3);
            this.grbPersonalColumns.Controls.Add(this.lblUserColumn2);
            this.grbPersonalColumns.Controls.Add(this.txtUserColumn2);
            this.grbPersonalColumns.Controls.Add(this.lblUserColumn1);
            this.grbPersonalColumns.Controls.Add(this.txtUserColumn1);
            this.grbPersonalColumns.Location = new System.Drawing.Point(9, 59);
            this.grbPersonalColumns.Name = "grbPersonalColumns";
            this.grbPersonalColumns.Size = new System.Drawing.Size(316, 178);
            this.grbPersonalColumns.TabIndex = 6;
            this.grbPersonalColumns.TabStop = false;
            this.grbPersonalColumns.Text = "Kişisel Kolonlar";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 180;
            this.label2.Text = "6. Alan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserColumn6
            // 
            this.txtUserColumn6.ForeColor = System.Drawing.Color.Black;
            this.txtUserColumn6.Location = new System.Drawing.Point(129, 142);
            this.txtUserColumn6.Name = "txtUserColumn6";
            this.txtUserColumn6.Size = new System.Drawing.Size(178, 21);
            this.txtUserColumn6.TabIndex = 179;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 178;
            this.label1.Text = "5. Alan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserColumn5
            // 
            this.txtUserColumn5.ForeColor = System.Drawing.Color.Black;
            this.txtUserColumn5.Location = new System.Drawing.Point(129, 117);
            this.txtUserColumn5.Name = "txtUserColumn5";
            this.txtUserColumn5.Size = new System.Drawing.Size(178, 21);
            this.txtUserColumn5.TabIndex = 177;
            // 
            // lblUserColumn4
            // 
            this.lblUserColumn4.AutoEllipsis = true;
            this.lblUserColumn4.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn4.Location = new System.Drawing.Point(9, 95);
            this.lblUserColumn4.Name = "lblUserColumn4";
            this.lblUserColumn4.Size = new System.Drawing.Size(114, 13);
            this.lblUserColumn4.TabIndex = 176;
            this.lblUserColumn4.Text = "4. Alan";
            this.lblUserColumn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserColumn4
            // 
            this.txtUserColumn4.ForeColor = System.Drawing.Color.Black;
            this.txtUserColumn4.Location = new System.Drawing.Point(129, 92);
            this.txtUserColumn4.Name = "txtUserColumn4";
            this.txtUserColumn4.Size = new System.Drawing.Size(178, 21);
            this.txtUserColumn4.TabIndex = 175;
            // 
            // lblUserColumn3
            // 
            this.lblUserColumn3.AutoEllipsis = true;
            this.lblUserColumn3.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn3.Location = new System.Drawing.Point(9, 71);
            this.lblUserColumn3.Name = "lblUserColumn3";
            this.lblUserColumn3.Size = new System.Drawing.Size(114, 13);
            this.lblUserColumn3.TabIndex = 174;
            this.lblUserColumn3.Text = "3. Alan";
            this.lblUserColumn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserColumn3
            // 
            this.txtUserColumn3.ForeColor = System.Drawing.Color.Black;
            this.txtUserColumn3.Location = new System.Drawing.Point(129, 68);
            this.txtUserColumn3.Name = "txtUserColumn3";
            this.txtUserColumn3.Size = new System.Drawing.Size(178, 21);
            this.txtUserColumn3.TabIndex = 173;
            // 
            // lblUserColumn2
            // 
            this.lblUserColumn2.AutoEllipsis = true;
            this.lblUserColumn2.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn2.Location = new System.Drawing.Point(9, 47);
            this.lblUserColumn2.Name = "lblUserColumn2";
            this.lblUserColumn2.Size = new System.Drawing.Size(114, 13);
            this.lblUserColumn2.TabIndex = 172;
            this.lblUserColumn2.Text = "2. Alan";
            this.lblUserColumn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserColumn2
            // 
            this.txtUserColumn2.ForeColor = System.Drawing.Color.Black;
            this.txtUserColumn2.Location = new System.Drawing.Point(129, 44);
            this.txtUserColumn2.Name = "txtUserColumn2";
            this.txtUserColumn2.Size = new System.Drawing.Size(178, 21);
            this.txtUserColumn2.TabIndex = 171;
            // 
            // lblUserColumn1
            // 
            this.lblUserColumn1.AutoEllipsis = true;
            this.lblUserColumn1.ForeColor = System.Drawing.Color.Black;
            this.lblUserColumn1.Location = new System.Drawing.Point(9, 23);
            this.lblUserColumn1.Name = "lblUserColumn1";
            this.lblUserColumn1.Size = new System.Drawing.Size(114, 13);
            this.lblUserColumn1.TabIndex = 170;
            this.lblUserColumn1.Text = "1. Alan";
            this.lblUserColumn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserColumn1
            // 
            this.txtUserColumn1.ForeColor = System.Drawing.Color.Black;
            this.txtUserColumn1.Location = new System.Drawing.Point(129, 20);
            this.txtUserColumn1.Name = "txtUserColumn1";
            this.txtUserColumn1.Size = new System.Drawing.Size(178, 21);
            this.txtUserColumn1.TabIndex = 169;
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.White;
            this.TabPage4.Controls.Add(this.GroupBox1);
            this.TabPage4.Location = new System.Drawing.Point(4, 25);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(340, 303);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "TabPage4";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cbDubbing);
            this.GroupBox1.Controls.Add(this.cbSubTitle);
            this.GroupBox1.Controls.Add(this.lblSubtitle);
            this.GroupBox1.Controls.Add(this.lblDubbing);
            this.GroupBox1.Location = new System.Drawing.Point(29, 27);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(276, 88);
            this.GroupBox1.TabIndex = 192;
            this.GroupBox1.TabStop = false;
            // 
            // cbDubbing
            // 
            this.cbDubbing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDubbing.Location = new System.Drawing.Point(106, 49);
            this.cbDubbing.Name = "cbDubbing";
            this.cbDubbing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDubbing.Properties.DropDownRows = 13;
            this.cbDubbing.Size = new System.Drawing.Size(153, 20);
            this.cbDubbing.TabIndex = 203;
            // 
            // cbSubTitle
            // 
            this.cbSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubTitle.EditValue = "";
            this.cbSubTitle.Location = new System.Drawing.Point(106, 21);
            this.cbSubTitle.Name = "cbSubTitle";
            this.cbSubTitle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSubTitle.Properties.DropDownRows = 13;
            this.cbSubTitle.Size = new System.Drawing.Size(153, 20);
            this.cbSubTitle.TabIndex = 202;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.AutoEllipsis = true;
            this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
            this.lblSubtitle.Location = new System.Drawing.Point(18, 24);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(59, 13);
            this.lblSubtitle.TabIndex = 186;
            this.lblSubtitle.Text = "Altyazı";
            // 
            // lblDubbing
            // 
            this.lblDubbing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDubbing.AutoEllipsis = true;
            this.lblDubbing.ForeColor = System.Drawing.Color.Black;
            this.lblDubbing.Location = new System.Drawing.Point(18, 51);
            this.lblDubbing.Name = "lblDubbing";
            this.lblDubbing.Size = new System.Drawing.Size(59, 13);
            this.lblDubbing.TabIndex = 187;
            this.lblDubbing.Text = "Dublaj";
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.chkProxy);
            this.TabPage5.Controls.Add(this.panelProxy);
            this.TabPage5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TabPage5.Location = new System.Drawing.Point(4, 25);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(340, 303);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "tabPage5";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // chkProxy
            // 
            this.chkProxy.Location = new System.Drawing.Point(3, 42);
            this.chkProxy.Name = "chkProxy";
            this.chkProxy.Properties.Caption = "Proxy kullan";
            this.chkProxy.Size = new System.Drawing.Size(94, 19);
            this.chkProxy.TabIndex = 9;
            this.chkProxy.CheckedChanged += new System.EventHandler(this.chkProxy_CheckedChanged);
            // 
            // panelProxy
            // 
            this.panelProxy.Controls.Add(this.txtProxyPort);
            this.panelProxy.Controls.Add(this.txtProxyServer);
            this.panelProxy.Controls.Add(this.txtProxyPassword);
            this.panelProxy.Controls.Add(this.lblProxyServer);
            this.panelProxy.Controls.Add(this.lblProxyPassword);
            this.panelProxy.Controls.Add(this.lblProxyPort);
            this.panelProxy.Controls.Add(this.txtProxyUserName);
            this.panelProxy.Controls.Add(this.lblProxyUserName);
            this.panelProxy.Enabled = false;
            this.panelProxy.Location = new System.Drawing.Point(4, 66);
            this.panelProxy.Name = "panelProxy";
            this.panelProxy.Size = new System.Drawing.Size(330, 130);
            this.panelProxy.TabIndex = 8;
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtProxyPort.Location = new System.Drawing.Point(265, 27);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProxyPort.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtProxyPort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtProxyPort.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtProxyPort.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtProxyPort.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtProxyPort.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtProxyPort.Properties.IsFloatValue = false;
            this.txtProxyPort.Size = new System.Drawing.Size(57, 20);
            this.txtProxyPort.TabIndex = 19;
            // 
            // txtProxyServer
            // 
            this.txtProxyServer.Location = new System.Drawing.Point(79, 27);
            this.txtProxyServer.Name = "txtProxyServer";
            this.txtProxyServer.Size = new System.Drawing.Size(150, 20);
            this.txtProxyServer.TabIndex = 1;
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.Location = new System.Drawing.Point(79, 79);
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.Size = new System.Drawing.Size(150, 20);
            this.txtProxyPassword.TabIndex = 7;
            // 
            // lblProxyServer
            // 
            this.lblProxyServer.Location = new System.Drawing.Point(10, 29);
            this.lblProxyServer.Name = "lblProxyServer";
            this.lblProxyServer.Size = new System.Drawing.Size(63, 13);
            this.lblProxyServer.TabIndex = 0;
            this.lblProxyServer.Text = "Proxy Server";
            // 
            // lblProxyPassword
            // 
            this.lblProxyPassword.Location = new System.Drawing.Point(10, 81);
            this.lblProxyPassword.Name = "lblProxyPassword";
            this.lblProxyPassword.Size = new System.Drawing.Size(22, 13);
            this.lblProxyPassword.TabIndex = 6;
            this.lblProxyPassword.Text = "Şifre";
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.Location = new System.Drawing.Point(239, 29);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.Size = new System.Drawing.Size(20, 13);
            this.lblProxyPort.TabIndex = 2;
            this.lblProxyPort.Text = "Port";
            // 
            // txtProxyUserName
            // 
            this.txtProxyUserName.Location = new System.Drawing.Point(79, 53);
            this.txtProxyUserName.Name = "txtProxyUserName";
            this.txtProxyUserName.Size = new System.Drawing.Size(150, 20);
            this.txtProxyUserName.TabIndex = 5;
            // 
            // lblProxyUserName
            // 
            this.lblProxyUserName.Location = new System.Drawing.Point(10, 55);
            this.lblProxyUserName.Name = "lblProxyUserName";
            this.lblProxyUserName.Size = new System.Drawing.Size(55, 13);
            this.lblProxyUserName.TabIndex = 4;
            this.lblProxyUserName.Text = "Kullanıcı Adı";
            // 
            // TreeView1
            // 
            this.TreeView1.Location = new System.Drawing.Point(9, 4);
            this.TreeView1.Name = "TreeView1";
            treeNode1.Name = "ndGeneral";
            treeNode1.Text = "Genel";
            treeNode2.Name = "ndPersonalColumns";
            treeNode2.Text = "Kişisel Kolonlar";
            treeNode3.Name = "ndDefaultValues";
            treeNode3.Text = "Varsayılan Değerler";
            treeNode4.Name = "ndConnection";
            treeNode4.Text = "Bağlantı";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.TreeView1.Size = new System.Drawing.Size(165, 303);
            this.TreeView1.TabIndex = 18;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(447, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "İptal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(366, 323);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "Tamam";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkShowCastImage
            // 
            this.chkShowCastImage.AutoSize = true;
            this.chkShowCastImage.Checked = true;
            this.chkShowCastImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowCastImage.Location = new System.Drawing.Point(9, 84);
            this.chkShowCastImage.Name = "chkShowCastImage";
            this.chkShowCastImage.Size = new System.Drawing.Size(147, 17);
            this.chkShowCastImage.TabIndex = 5;
            this.chkShowCastImage.Text = "Oyuncu resimlerini göster";
            this.chkShowCastImage.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 357);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.TreeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçenekler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.grbPlayer.ResumeLayout(false);
            this.grbPlayer.PerformLayout();
            this.grbRecord.ResumeLayout(false);
            this.grbRecord.PerformLayout();
            this.grbLanguage.ResumeLayout(false);
            this.grbGeneral.ResumeLayout(false);
            this.grbGeneral.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.grbPersonalColumns.ResumeLayout(false);
            this.grbPersonalColumns.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbDubbing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubTitle.Properties)).EndInit();
            this.TabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkProxy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelProxy)).EndInit();
            this.panelProxy.ResumeLayout(false);
            this.panelProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.GroupBox grbPlayer;
        internal System.Windows.Forms.Button btnPlayerSelect;
        internal System.Windows.Forms.TextBox txtPlayer;
        internal System.Windows.Forms.GroupBox grbRecord;
        internal System.Windows.Forms.CheckBox chkAutoNewRecord;
        internal System.Windows.Forms.CheckBox chkAutoClose;
        internal System.Windows.Forms.GroupBox grbLanguage;
        internal System.Windows.Forms.ComboBox cbLanguage;
        internal System.Windows.Forms.Label lblLanguage;
        internal System.Windows.Forms.GroupBox grbGeneral;
        internal System.Windows.Forms.CheckBox chkImageLeft;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.DataGridView dGrid;
        internal System.Windows.Forms.DataGridViewTextBoxColumn cl_k;
        internal System.Windows.Forms.DataGridViewTextBoxColumn cl_str;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.GroupBox grbPersonalColumns;
        internal System.Windows.Forms.Label lblUserColumn4;
        internal System.Windows.Forms.TextBox txtUserColumn4;
        internal System.Windows.Forms.Label lblUserColumn3;
        internal System.Windows.Forms.TextBox txtUserColumn3;
        internal System.Windows.Forms.Label lblUserColumn2;
        internal System.Windows.Forms.TextBox txtUserColumn2;
        internal System.Windows.Forms.Label lblUserColumn1;
        internal System.Windows.Forms.TextBox txtUserColumn1;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblSubtitle;
        internal System.Windows.Forms.Label lblDubbing;
        internal System.Windows.Forms.TreeView TreeView1;
        internal System.Windows.Forms.CheckBox chkStartUpVersionControl;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private System.Windows.Forms.TabPage TabPage5;
        private DevExpress.XtraEditors.CheckEdit chkProxy;
        private DevExpress.XtraEditors.PanelControl panelProxy;
        private DevExpress.XtraEditors.TextEdit txtProxyServer;
        private DevExpress.XtraEditors.TextEdit txtProxyPassword;
        private DevExpress.XtraEditors.LabelControl lblProxyServer;
        private DevExpress.XtraEditors.LabelControl lblProxyPassword;
        private DevExpress.XtraEditors.LabelControl lblProxyPort;
        private DevExpress.XtraEditors.TextEdit txtProxyUserName;
        private DevExpress.XtraEditors.LabelControl lblProxyUserName;
        private DevExpress.XtraEditors.SpinEdit txtProxyPort;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbDubbing;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbSubTitle;
        internal System.Windows.Forms.CheckBox chkThe;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtUserColumn6;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtUserColumn5;
        internal System.Windows.Forms.CheckBox chkShowCastImage;
    }
}