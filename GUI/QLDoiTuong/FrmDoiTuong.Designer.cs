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
            this.btnXuat = new Krypton.Toolkit.KryptonButton();
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.searchbtn = new Krypton.Toolkit.KryptonButton();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.cbbSearch = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.xoabtn = new Krypton.Toolkit.KryptonButton();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.DGVDoiTuong = new Krypton.Toolkit.KryptonDataGridView();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.ckbTrangThai = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtTenDoiTuong = new Krypton.Toolkit.KryptonTextBox();
            this.txtMaDoiTuong = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoiTuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuat
            // 
            this.btnXuat.CornerRoundingRadius = 20F;
            this.btnXuat.Location = new System.Drawing.Point(854, 387);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(90, 60);
            this.btnXuat.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuat.StateCommon.Border.Rounding = 20F;
            this.btnXuat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.StatePressed.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnXuat.StatePressed.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnXuat.StatePressed.Back.ColorAngle = 60F;
            this.btnXuat.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnXuat.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnXuat.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnXuat.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuat.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnXuat, "Xuất");
            this.btnXuat.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Values.Image")));
            this.btnXuat.Values.Text = "";
            // 
            // btnThem
            // 
            this.btnThem.CornerRoundingRadius = 20F;
            this.btnThem.Location = new System.Drawing.Point(426, 387);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 60);
            this.btnThem.StateCommon.Back.Color1 = System.Drawing.Color.Honeydew;
            this.btnThem.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.StateCommon.Border.Color1 = System.Drawing.Color.OldLace;
            this.btnThem.StateCommon.Border.Color2 = System.Drawing.Color.Honeydew;
            this.btnThem.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateCommon.Border.Rounding = 20F;
            this.btnThem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.StatePressed.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnThem.StatePressed.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnThem.StatePressed.Back.ColorAngle = 60F;
            this.btnThem.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnThem.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnThem.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnThem.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Values.Image")));
            this.btnThem.Values.Text = "";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.CornerRoundingRadius = 20F;
            this.searchbtn.Location = new System.Drawing.Point(15, 76);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(360, 35);
            this.searchbtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchbtn.StateCommon.Border.Rounding = 20F;
            this.searchbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.TabIndex = 7;
            this.searchbtn.Values.Text = "Tìm kiếm";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(191, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 33);
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10F;
            this.txtSearch.TabIndex = 4;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionOverlap = 0D;
            this.kryptonGroupBox2.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
            this.kryptonGroupBox2.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.InputControlRibbon;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(4, 207);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.cbbSearch);
            this.kryptonGroupBox2.Panel.Controls.Add(this.searchbtn);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtSearch);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(392, 172);
            this.kryptonGroupBox2.TabIndex = 14;
            this.kryptonGroupBox2.Values.Heading = "Tìm kiếm";
            // 
            // cbbSearch
            // 
            this.cbbSearch.CornerRoundingRadius = 20F;
            this.cbbSearch.DropDownWidth = 136;
            this.cbbSearch.IntegralHeight = false;
            this.cbbSearch.Location = new System.Drawing.Point(20, 22);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(148, 37);
            this.cbbSearch.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbSearch.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbbSearch.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbSearch.TabIndex = 8;
            this.cbbSearch.SelectedIndexChanged += new System.EventHandler(this.cbbSearch_SelectedIndexChanged);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnRefresh);
            this.kryptonPanel1.Controls.Add(this.xoabtn);
            this.kryptonPanel1.Controls.Add(this.btnSua);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.btnXuat);
            this.kryptonPanel1.Controls.Add(this.DGVDoiTuong);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.btnThem);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(950, 650);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Navy;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Teal;
            this.kryptonPanel1.StateCommon.ColorAngle = 60F;
            this.kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonPanel1.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.CornerRoundingRadius = 20F;
            this.btnRefresh.Location = new System.Drawing.Point(747, 387);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 60);
            this.btnRefresh.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRefresh.StateCommon.Border.Rounding = 20F;
            this.btnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.StatePressed.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.StatePressed.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.StatePressed.Back.ColorAngle = 60F;
            this.btnRefresh.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnRefresh.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnRefresh.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnRefresh.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRefresh.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Values.Image")));
            this.btnRefresh.Values.Text = "";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // xoabtn
            // 
            this.xoabtn.CornerRoundingRadius = 20F;
            this.xoabtn.Location = new System.Drawing.Point(640, 387);
            this.xoabtn.Margin = new System.Windows.Forms.Padding(4);
            this.xoabtn.Name = "xoabtn";
            this.xoabtn.Size = new System.Drawing.Size(90, 60);
            this.xoabtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.xoabtn.StateCommon.Border.Rounding = 20F;
            this.xoabtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoabtn.StatePressed.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.xoabtn.StatePressed.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.xoabtn.StatePressed.Back.ColorAngle = 60F;
            this.xoabtn.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.xoabtn.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.xoabtn.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.xoabtn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.xoabtn.TabIndex = 16;
            this.toolTip1.SetToolTip(this.xoabtn, "Xóa");
            this.xoabtn.Values.Image = ((System.Drawing.Image)(resources.GetObject("xoabtn.Values.Image")));
            this.xoabtn.Values.Text = "";
            this.xoabtn.Click += new System.EventHandler(this.xoabtn_Click);
            // 
            // btnSua
            // 
            this.btnSua.CornerRoundingRadius = 20F;
            this.btnSua.Location = new System.Drawing.Point(533, 387);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 60);
            this.btnSua.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateCommon.Border.Rounding = 20F;
            this.btnSua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.StatePressed.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnSua.StatePressed.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnSua.StatePressed.Back.ColorAngle = 60F;
            this.btnSua.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnSua.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnSua.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnSua.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa");
            this.btnSua.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Values.Image")));
            this.btnSua.Values.Text = "";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // DGVDoiTuong
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DGVDoiTuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDoiTuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDoiTuong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVDoiTuong.ColumnHeadersHeight = 36;
            this.DGVDoiTuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDT,
            this.TenDT,
            this.TrangThai});
            this.DGVDoiTuong.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DGVDoiTuong.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DGVDoiTuong.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.DGVDoiTuong.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.DGVDoiTuong.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.DGVDoiTuong.Location = new System.Drawing.Point(404, 4);
            this.DGVDoiTuong.Margin = new System.Windows.Forms.Padding(4);
            this.DGVDoiTuong.Name = "DGVDoiTuong";
            this.DGVDoiTuong.ReadOnly = true;
            this.DGVDoiTuong.RowHeadersVisible = false;
            this.DGVDoiTuong.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DGVDoiTuong.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDoiTuong.Size = new System.Drawing.Size(546, 375);
            this.DGVDoiTuong.TabIndex = 10;
            this.DGVDoiTuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDoiTuong_CellClick);
            this.DGVDoiTuong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDoiTuong_CellDoubleClick);
            // 
            // MaDT
            // 
            this.MaDT.DataPropertyName = "MaDT";
            this.MaDT.FillWeight = 93.04813F;
            this.MaDT.HeaderText = "Mã đối tượng";
            this.MaDT.MinimumWidth = 6;
            this.MaDT.Name = "MaDT";
            this.MaDT.ReadOnly = true;
            // 
            // TenDT
            // 
            this.TenDT.DataPropertyName = "TenDT";
            this.TenDT.FillWeight = 106.9519F;
            this.TenDT.HeaderText = "Tên đối tượng";
            this.TenDT.MinimumWidth = 6;
            this.TenDT.Name = "TenDT";
            this.TenDT.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionOverlap = 0D;
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.InputControlRibbon;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.ckbTrangThai);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtTenDoiTuong);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtMaDoiTuong);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(392, 195);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Thông tin đối tượng";
            // 
            // ckbTrangThai
            // 
            this.ckbTrangThai.Location = new System.Drawing.Point(15, 129);
            this.ckbTrangThai.Name = "ckbTrangThai";
            this.ckbTrangThai.Size = new System.Drawing.Size(78, 25);
            this.ckbTrangThai.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTrangThai.TabIndex = 9;
            this.ckbTrangThai.Values.Text = "Active";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(4, 79);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(164, 31);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.kryptonLabel1.Size = new System.Drawing.Size(155, 31);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Mã đối tượng";
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
            ((System.ComponentModel.ISupportInitialize)(this.cbbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoiTuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnXuat;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton searchbtn;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonDataGridView DGVDoiTuong;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonCheckBox ckbTrangThai;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtTenDoiTuong;
        private Krypton.Toolkit.KryptonTextBox txtMaDoiTuong;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private Krypton.Toolkit.KryptonButton xoabtn;
        private Krypton.Toolkit.KryptonComboBox cbbSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private Krypton.Toolkit.KryptonButton btnRefresh;
    }
}