namespace pharmacy_management.GUI.QLDoiTuong
{
    partial class FrmDoiTuong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiTuong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.lblback = new Krypton.Toolkit.KryptonLabel();
            this.DGVDoiTuong = new System.Windows.Forms.DataGridView();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.btnXuat = new Krypton.Toolkit.KryptonButton();
            this.backlbl = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtTenDoiTuong = new Krypton.Toolkit.KryptonTextBox();
            this.txtMaDoiTuong = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoiTuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(304, 33);
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10F;
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.kryptonGroupBox2.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(3, 256);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnRefresh);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtSearch);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(392, 103);
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroupBox2.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 14;
            this.kryptonGroupBox2.Values.Heading = "Tìm kiếm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.CornerRoundingRadius = 50F;
            this.btnRefresh.Location = new System.Drawing.Point(335, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnRefresh.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnRefresh.OverrideDefault.Back.Image = global::pharmacy_management.Properties.Resources.icons8_refresh_24;
            this.btnRefresh.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnRefresh.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnRefresh.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnRefresh.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRefresh.OverrideDefault.Border.Rounding = 50F;
            this.btnRefresh.OverrideDefault.Border.Width = 5;
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnRefresh.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnRefresh.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnRefresh.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnRefresh.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRefresh.StateCommon.Border.Rounding = 50F;
            this.btnRefresh.StateCommon.Border.Width = 5;
            this.btnRefresh.StateNormal.Back.Image = global::pharmacy_management.Properties.Resources.icons8_refresh_24;
            this.btnRefresh.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnRefresh.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.btnRefresh.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.btnRefresh.StateTracking.Back.Image = global::pharmacy_management.Properties.Resources.icons8_refresh_24;
            this.btnRefresh.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnRefresh.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.btnRefresh.StateTracking.Border.Color2 = System.Drawing.Color.Blue;
            this.btnRefresh.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRefresh.StateTracking.Border.Rounding = 50F;
            this.btnRefresh.StateTracking.Border.Width = 5;
            this.btnRefresh.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnRefresh, "Làm mới");
            this.btnRefresh.Values.Text = "";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lblback);
            this.kryptonPanel1.Controls.Add(this.DGVDoiTuong);
            this.kryptonPanel1.Controls.Add(this.btnSua);
            this.kryptonPanel1.Controls.Add(this.btnThem);
            this.kryptonPanel1.Controls.Add(this.btnXuat);
            this.kryptonPanel1.Controls.Add(this.backlbl);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(950, 650);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.ColorAngle = 60F;
            this.kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonPanel1.TabIndex = 12;
            // 
            // lblback
            // 
            this.lblback.Location = new System.Drawing.Point(3, 0);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(46, 42);
            this.lblback.TabIndex = 66;
            this.lblback.Values.Image = ((System.Drawing.Image)(resources.GetObject("lblback.Values.Image")));
            this.lblback.Values.Text = "";
            this.lblback.Click += new System.EventHandler(this.backlbl_MouseClick);
            // 
            // DGVDoiTuong
            // 
            this.DGVDoiTuong.AllowUserToAddRows = false;
            this.DGVDoiTuong.AllowUserToDeleteRows = false;
            this.DGVDoiTuong.AllowUserToOrderColumns = true;
            this.DGVDoiTuong.AllowUserToResizeRows = false;
            this.DGVDoiTuong.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGVDoiTuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDoiTuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDoiTuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDoiTuong.ColumnHeadersHeight = 30;
            this.DGVDoiTuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVDoiTuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDT,
            this.TenDT,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDoiTuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDoiTuong.EnableHeadersVisualStyles = false;
            this.DGVDoiTuong.GridColor = System.Drawing.Color.Black;
            this.DGVDoiTuong.Location = new System.Drawing.Point(401, 61);
            this.DGVDoiTuong.Name = "DGVDoiTuong";
            this.DGVDoiTuong.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDoiTuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDoiTuong.RowHeadersVisible = false;
            this.DGVDoiTuong.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVDoiTuong.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDoiTuong.RowTemplate.Height = 24;
            this.DGVDoiTuong.Size = new System.Drawing.Size(546, 267);
            this.DGVDoiTuong.TabIndex = 65;
            this.DGVDoiTuong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVDoiTuong_CellMouseClick);
            this.DGVDoiTuong.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVDoiTuong_CellMouseDoubleClick);
            // 
            // btnSua
            // 
            this.btnSua.CornerRoundingRadius = 5F;
            this.btnSua.Location = new System.Drawing.Point(635, 354);
            this.btnSua.Name = "btnSua";
            this.btnSua.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkGray;
            this.btnSua.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkGray;
            this.btnSua.OverrideDefault.Back.Image = global::pharmacy_management.Properties.Resources.icons8_setting_24;
            this.btnSua.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSua.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnSua.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkGray;
            this.btnSua.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.OverrideDefault.Border.Rounding = 5F;
            this.btnSua.OverrideDefault.Border.Width = 5;
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.StateCommon.Back.Color1 = System.Drawing.Color.DarkGray;
            this.btnSua.StateCommon.Back.Color2 = System.Drawing.Color.DarkGray;
            this.btnSua.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.icons8_setting_24;
            this.btnSua.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSua.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnSua.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.btnSua.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateCommon.Border.Rounding = 5F;
            this.btnSua.StateCommon.Border.Width = 5;
            this.btnSua.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.btnSua.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.btnSua.StateDisabled.Border.Color1 = System.Drawing.Color.Gray;
            this.btnSua.StateDisabled.Border.Color2 = System.Drawing.Color.Gray;
            this.btnSua.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.btnSua.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnSua.StateTracking.Back.Image = global::pharmacy_management.Properties.Resources.icons8_setting_24;
            this.btnSua.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSua.StateTracking.Border.Color1 = System.Drawing.Color.DimGray;
            this.btnSua.StateTracking.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnSua.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateTracking.Border.Rounding = 5F;
            this.btnSua.StateTracking.Border.Width = 5;
            this.btnSua.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa");
            this.btnSua.Values.Text = "";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.CornerRoundingRadius = 5F;
            this.btnThem.Location = new System.Drawing.Point(804, 354);
            this.btnThem.Name = "btnThem";
            this.btnThem.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.OverrideDefault.Back.Image = global::pharmacy_management.Properties.Resources.icons8_plus_24;
            this.btnThem.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnThem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.OverrideDefault.Border.Rounding = 5F;
            this.btnThem.OverrideDefault.Border.Width = 5;
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.icons8_plus_24;
            this.btnThem.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnThem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateCommon.Border.Rounding = 5F;
            this.btnThem.StateCommon.Border.Width = 5;
            this.btnThem.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.btnThem.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.btnThem.StateDisabled.Border.Color1 = System.Drawing.Color.Gray;
            this.btnThem.StateDisabled.Border.Color2 = System.Drawing.Color.Gray;
            this.btnThem.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.btnThem.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.btnThem.StateTracking.Back.Image = global::pharmacy_management.Properties.Resources.icons8_plus_24;
            this.btnThem.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnThem.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.btnThem.StateTracking.Border.Color2 = System.Drawing.Color.Blue;
            this.btnThem.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateTracking.Border.Rounding = 5F;
            this.btnThem.StateTracking.Border.Width = 5;
            this.btnThem.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.Values.Text = "";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.CornerRoundingRadius = 5F;
            this.btnXuat.Location = new System.Drawing.Point(466, 354);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.OverrideDefault.Back.Color1 = System.Drawing.Color.Green;
            this.btnXuat.OverrideDefault.Back.Color2 = System.Drawing.Color.Green;
            this.btnXuat.OverrideDefault.Back.Image = global::pharmacy_management.Properties.Resources.icons8_microsoft_excel_24;
            this.btnXuat.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnXuat.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.btnXuat.OverrideDefault.Border.Color2 = System.Drawing.Color.Green;
            this.btnXuat.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuat.OverrideDefault.Border.Rounding = 5F;
            this.btnXuat.OverrideDefault.Border.Width = 5;
            this.btnXuat.Size = new System.Drawing.Size(100, 40);
            this.btnXuat.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.btnXuat.StateCommon.Back.Color2 = System.Drawing.Color.Green;
            this.btnXuat.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.btnXuat.StateCommon.Border.Color2 = System.Drawing.Color.Green;
            this.btnXuat.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuat.StateCommon.Border.Rounding = 5F;
            this.btnXuat.StateCommon.Border.Width = 5;
            this.btnXuat.StateNormal.Back.Image = global::pharmacy_management.Properties.Resources.icons8_microsoft_excel_24;
            this.btnXuat.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnXuat.StateTracking.Back.Color1 = System.Drawing.Color.DarkGreen;
            this.btnXuat.StateTracking.Back.Color2 = System.Drawing.Color.DarkGreen;
            this.btnXuat.StateTracking.Back.Image = global::pharmacy_management.Properties.Resources.icons8_microsoft_excel_24;
            this.btnXuat.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnXuat.StateTracking.Border.Color1 = System.Drawing.Color.DarkGreen;
            this.btnXuat.StateTracking.Border.Color2 = System.Drawing.Color.DarkGreen;
            this.btnXuat.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuat.StateTracking.Border.Rounding = 5F;
            this.btnXuat.StateTracking.Border.Width = 5;
            this.btnXuat.TabIndex = 62;
            this.toolTip1.SetToolTip(this.btnXuat, "Xuất Excel");
            this.btnXuat.Values.Text = "";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // backlbl
            // 
            this.backlbl.Location = new System.Drawing.Point(3, 0);
            this.backlbl.Name = "backlbl";
            this.backlbl.Size = new System.Drawing.Size(6, 2);
            this.backlbl.TabIndex = 34;
            this.backlbl.Values.Text = "";
            this.backlbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backlbl_MouseClick);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 49);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtTenDoiTuong);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtMaDoiTuong);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(392, 199);
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Thông tin đối tượng";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(4, 79);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(157, 31);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Tên đối tượng";
            // 
            // txtTenDoiTuong
            // 
            this.txtTenDoiTuong.Location = new System.Drawing.Point(191, 77);
            this.txtTenDoiTuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDoiTuong.Name = "txtTenDoiTuong";
            this.txtTenDoiTuong.Size = new System.Drawing.Size(184, 33);
            this.txtTenDoiTuong.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenDoiTuong.StateCommon.Border.Rounding = 10F;
            this.txtTenDoiTuong.TabIndex = 5;
            // 
            // txtMaDoiTuong
            // 
            this.txtMaDoiTuong.Enabled = false;
            this.txtMaDoiTuong.Location = new System.Drawing.Point(191, 22);
            this.txtMaDoiTuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDoiTuong.Name = "txtMaDoiTuong";
            this.txtMaDoiTuong.Size = new System.Drawing.Size(184, 33);
            this.txtMaDoiTuong.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaDoiTuong.StateCommon.Border.Rounding = 10F;
            this.txtMaDoiTuong.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 22);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(152, 31);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Mã đối tượng";
            // 
            // MaDT
            // 
            this.MaDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.MaDT.DataPropertyName = "MaDT";
            this.MaDT.HeaderText = "Mã";
            this.MaDT.MinimumWidth = 40;
            this.MaDT.Name = "MaDT";
            this.MaDT.ReadOnly = true;
            this.MaDT.Width = 40;
            // 
            // TenDT
            // 
            this.TenDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDT.DataPropertyName = "TenDT";
            this.TenDT.HeaderText = "Tên đối tượng";
            this.TenDT.MinimumWidth = 6;
            this.TenDT.Name = "TenDT";
            this.TenDT.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            this.TrangThai.Width = 130;
            // 
            // FrmDoiTuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoiTuong";
            this.Text = "QLDoiTuong";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoiTuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtTenDoiTuong;
        private Krypton.Toolkit.KryptonTextBox txtMaDoiTuong;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Krypton.Toolkit.KryptonButton btnRefresh;
        private Krypton.Toolkit.KryptonLabel backlbl;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton btnXuat;
        private System.Windows.Forms.DataGridView DGVDoiTuong;
        private Krypton.Toolkit.KryptonLabel lblback;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}