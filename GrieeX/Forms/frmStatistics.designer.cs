namespace GrieeX.Forms
{
    partial class frmStatistics
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Yönetmen");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Yýl");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Tür");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Video Codec");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Audio Codec 1");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Audio Codec 2");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Altyazý");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Dublaj");
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.dgGeneral = new DevExpress.XtraGrid.GridControl();
            this.gvGeneral = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabDetails = new DevExpress.XtraTab.XtraTabPage();
            this.dGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_Str = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_Count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lvStatistics = new System.Windows.Forms.ListView();
            this.clSelect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGeneral)).BeginInit();
            this.tabDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(564, 372);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabGeneral,
            this.tabDetails});
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.dgGeneral);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(558, 344);
            this.tabGeneral.Text = "Genel";
            // 
            // dgGeneral
            // 
            this.dgGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGeneral.Location = new System.Drawing.Point(0, 0);
            this.dgGeneral.MainView = this.gvGeneral;
            this.dgGeneral.Name = "dgGeneral";
            this.dgGeneral.Size = new System.Drawing.Size(558, 344);
            this.dgGeneral.TabIndex = 198;
            this.dgGeneral.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGeneral});
            // 
            // gvGeneral
            // 
            this.gvGeneral.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_Value,
            this.cl_Total});
            this.gvGeneral.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvGeneral.GridControl = this.dgGeneral;
            this.gvGeneral.Name = "gvGeneral";
            this.gvGeneral.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGeneral.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGeneral.OptionsBehavior.Editable = false;
            this.gvGeneral.OptionsCustomization.AllowFilter = false;
            this.gvGeneral.OptionsCustomization.AllowGroup = false;
            this.gvGeneral.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvGeneral.OptionsView.ShowGroupPanel = false;
            this.gvGeneral.OptionsView.ShowIndicator = false;
            // 
            // cl_Value
            // 
            this.cl_Value.Caption = "Deðer";
            this.cl_Value.FieldName = "cl_Value";
            this.cl_Value.Name = "cl_Value";
            this.cl_Value.OptionsFilter.AllowAutoFilter = false;
            this.cl_Value.OptionsFilter.AllowFilter = false;
            this.cl_Value.Visible = true;
            this.cl_Value.VisibleIndex = 0;
            this.cl_Value.Width = 150;
            // 
            // cl_Total
            // 
            this.cl_Total.Caption = "Karakter";
            this.cl_Total.FieldName = "cl_Total";
            this.cl_Total.Name = "cl_Total";
            this.cl_Total.OptionsFilter.AllowAutoFilter = false;
            this.cl_Total.OptionsFilter.AllowFilter = false;
            this.cl_Total.Visible = true;
            this.cl_Total.VisibleIndex = 1;
            this.cl_Total.Width = 132;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.dGrid);
            this.tabDetails.Controls.Add(this.lvStatistics);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Size = new System.Drawing.Size(558, 344);
            this.tabDetails.Text = "Detaylar";
            // 
            // dGrid
            // 
            this.dGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGrid.Location = new System.Drawing.Point(177, 6);
            this.dGrid.MainView = this.gridView1;
            this.dGrid.Name = "dGrid";
            this.dGrid.Size = new System.Drawing.Size(374, 329);
            this.dGrid.TabIndex = 13;
            this.dGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_Str,
            this.cl_Count});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.dGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // cl_Str
            // 
            this.cl_Str.Caption = "Deðer";
            this.cl_Str.FieldName = "str";
            this.cl_Str.Name = "cl_Str";
            this.cl_Str.Visible = true;
            this.cl_Str.VisibleIndex = 0;
            this.cl_Str.Width = 250;
            // 
            // cl_Count
            // 
            this.cl_Count.Caption = "Toplam";
            this.cl_Count.FieldName = "Count";
            this.cl_Count.Name = "cl_Count";
            this.cl_Count.Visible = true;
            this.cl_Count.VisibleIndex = 1;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dGrid;
            this.gridView2.Name = "gridView2";
            // 
            // lvStatistics
            // 
            this.lvStatistics.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSelect});
            this.lvStatistics.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvStatistics.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lvStatistics.Location = new System.Drawing.Point(5, 6);
            this.lvStatistics.MultiSelect = false;
            this.lvStatistics.Name = "lvStatistics";
            this.lvStatistics.Size = new System.Drawing.Size(166, 329);
            this.lvStatistics.TabIndex = 11;
            this.lvStatistics.UseCompatibleStateImageBehavior = false;
            this.lvStatistics.View = System.Windows.Forms.View.Details;
            this.lvStatistics.Click += new System.EventHandler(this.lvStatistics_Click);
            // 
            // clSelect
            // 
            this.clSelect.Text = "Seç";
            this.clSelect.Width = 162;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(493, 378);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Tamam";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 408);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmStatistics";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ýstatistikler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGeneral)).EndInit();
            this.tabDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabGeneral;
        private DevExpress.XtraTab.XtraTabPage tabDetails;
        internal System.Windows.Forms.ListView lvStatistics;
        internal System.Windows.Forms.ColumnHeader clSelect;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraGrid.GridControl dGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Str;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Count;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl dgGeneral;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGeneral;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Value;
        private DevExpress.XtraGrid.Columns.GridColumn cl_Total;
    }
}