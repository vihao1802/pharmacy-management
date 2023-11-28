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
            this.searchbtn = new Krypton.Toolkit.KryptonButton();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.cbbSearch = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
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
            this.btnXuat = new Krypton.Toolkit.KryptonButton();
            this.btnXoa = new Krypton.Toolkit.KryptonButton();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.backlbl = new Krypton.Toolkit.KryptonLabel();
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
            // searchbtn
            // 
            this.searchbtn.CornerRoundingRadius = 20F;
            this.searchbtn.Location = new System.Drawing.Point(15, 76);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(353, 35);
            this.searchbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.searchbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.searchbtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchbtn.StateCommon.Border.Rounding = 20F;
            this.searchbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.searchbtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.searchbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.TabIndex = 7;
            this.toolTip1.SetToolTip(this.searchbtn, "Tìm Kiếm");
            this.searchbtn.Values.Text = "Tìm Kiếm";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(160, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 33);
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10F;
            this.txtSearch.TabIndex = 4;
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
            this.kryptonGroupBox2.Panel.Controls.Add(this.cbbSearch);
            this.kryptonGroupBox2.Panel.Controls.Add(this.searchbtn);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtSearch);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(392, 172);
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroupBox2.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 14;
            this.kryptonGroupBox2.Values.Heading = "Tìm kiếm";
            // 
            // cbbSearch
            // 
            this.cbbSearch.CornerRoundingRadius = 20F;
            this.cbbSearch.DropDownWidth = 136;
            this.cbbSearch.IntegralHeight = false;
            this.cbbSearch.Location = new System.Drawing.Point(8, 23);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(145, 37);
            this.cbbSearch.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbSearch.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbbSearch.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbSearch.TabIndex = 8;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.backlbl);
            this.kryptonPanel1.Controls.Add(this.btnXuat);
            this.kryptonPanel1.Controls.Add(this.btnXoa);
            this.kryptonPanel1.Controls.Add(this.btnSua);
            this.kryptonPanel1.Controls.Add(this.btnThem);
            this.kryptonPanel1.Controls.Add(this.DGVDoiTuong);
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
            // DGVDoiTuong
            // 
            this.DGVDoiTuong.AllowUserToResizeRows = false;
            this.DGVDoiTuong.ColumnHeadersHeight = 36;
            this.DGVDoiTuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDT,
            this.TenDT,
            this.TrangThai});
            this.DGVDoiTuong.Location = new System.Drawing.Point(400, 57);
            this.DGVDoiTuong.MultiSelect = false;
            this.DGVDoiTuong.Name = "DGVDoiTuong";
            this.DGVDoiTuong.ReadOnly = true;
            this.DGVDoiTuong.RowHeadersVisible = false;
            this.DGVDoiTuong.RowHeadersWidth = 51;
            this.DGVDoiTuong.RowTemplate.Height = 24;
            this.DGVDoiTuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDoiTuong.Size = new System.Drawing.Size(546, 294);
            this.DGVDoiTuong.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DGVDoiTuong.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.DGVDoiTuong.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.DGVDoiTuong.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.DGVDoiTuong.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.DGVDoiTuong.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.DGVDoiTuong.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.DGVDoiTuong.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDoiTuong.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.DGVDoiTuong.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.DGVDoiTuong.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DGVDoiTuong.StateSelected.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.DGVDoiTuong.TabIndex = 24;
            this.DGVDoiTuong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVDoiTuong_CellMouseClick);
            this.DGVDoiTuong.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVDoiTuong_CellMouseDoubleClick);
            // 
            // MaDT
            // 
            this.MaDT.HeaderText = "Mã đối tượng";
            this.MaDT.MinimumWidth = 6;
            this.MaDT.Name = "MaDT";
            this.MaDT.ReadOnly = true;
            this.MaDT.Width = 125;
            // 
            // TenDT
            // 
            this.TenDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDT.HeaderText = "Tên đối tượng";
            this.TenDT.MinimumWidth = 6;
            this.TenDT.Name = "TenDT";
            this.TenDT.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 125;
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
            this.kryptonGroupBox1.Panel.Controls.Add(this.ckbTrangThai);
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
            // ckbTrangThai
            // 
            this.ckbTrangThai.Location = new System.Drawing.Point(15, 129);
            this.ckbTrangThai.Name = "ckbTrangThai";
            this.ckbTrangThai.Size = new System.Drawing.Size(92, 31);
            this.ckbTrangThai.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTrangThai.TabIndex = 9;
            this.ckbTrangThai.Values.Text = "Active";
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
            // btnXuat
            // 
            this.btnXuat.CornerRoundingRadius = 20F;
            this.btnXuat.Location = new System.Drawing.Point(820, 371);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(97, 57);
            this.btnXuat.StateCommon.Back.Color1 = System.Drawing.Color.ForestGreen;
            this.btnXuat.StateCommon.Back.Color2 = System.Drawing.Color.DarkGreen;
            this.btnXuat.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuat.StateCommon.Border.Rounding = 20F;
            this.btnXuat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.StateDisabled.Back.Color1 = System.Drawing.Color.ForestGreen;
            this.btnXuat.StateDisabled.Back.Color2 = System.Drawing.Color.DarkGreen;
            this.btnXuat.StatePressed.Back.Color1 = System.Drawing.Color.ForestGreen;
            this.btnXuat.StatePressed.Back.Color2 = System.Drawing.Color.DarkGreen;
            this.btnXuat.StatePressed.Border.ColorAngle = 60F;
            this.btnXuat.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnXuat.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuat.StateTracking.Back.Color1 = System.Drawing.Color.ForestGreen;
            this.btnXuat.StateTracking.Back.Color2 = System.Drawing.Color.DarkGreen;
            this.btnXuat.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuat.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnXuat, "Xuất Excel");
            this.btnXuat.Values.Image = global::pharmacy_management.Properties.Resources.icons8_microsoft_excel_24;
            this.btnXuat.Values.Text = "";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.CornerRoundingRadius = 20F;
            this.btnXoa.Location = new System.Drawing.Point(686, 371);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 57);
            this.btnXoa.StateCommon.Back.Color1 = System.Drawing.Color.Brown;
            this.btnXoa.StateCommon.Back.Color2 = System.Drawing.Color.DarkRed;
            this.btnXoa.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateCommon.Border.Rounding = 20F;
            this.btnXoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.StateDisabled.Back.Color1 = System.Drawing.Color.Brown;
            this.btnXoa.StateDisabled.Back.Color2 = System.Drawing.Color.DarkRed;
            this.btnXoa.StatePressed.Back.Color1 = System.Drawing.Color.Brown;
            this.btnXoa.StatePressed.Back.Color2 = System.Drawing.Color.DarkRed;
            this.btnXoa.StatePressed.Border.ColorAngle = 60F;
            this.btnXoa.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnXoa.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateTracking.Back.Color1 = System.Drawing.Color.Brown;
            this.btnXoa.StateTracking.Back.Color2 = System.Drawing.Color.DarkRed;
            this.btnXoa.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.Values.Image = global::pharmacy_management.Properties.Resources.icons8_delete_24;
            this.btnXoa.Values.Text = "";
            this.btnXoa.Click += new System.EventHandler(this.xoabtn_Click);
            // 
            // btnSua
            // 
            this.btnSua.CornerRoundingRadius = 20F;
            this.btnSua.Location = new System.Drawing.Point(552, 371);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 57);
            this.btnSua.StateCommon.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.btnSua.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnSua.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateCommon.Border.Rounding = 20F;
            this.btnSua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.StateDisabled.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.btnSua.StateDisabled.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnSua.StatePressed.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.btnSua.StatePressed.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnSua.StatePressed.Border.ColorAngle = 60F;
            this.btnSua.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.btnSua.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateTracking.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.btnSua.StateTracking.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnSua.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa");
            this.btnSua.Values.Image = global::pharmacy_management.Properties.Resources.icons8_setting_24;
            this.btnSua.Values.Text = "";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.CornerRoundingRadius = 20F;
            this.btnThem.Location = new System.Drawing.Point(418, 371);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 57);
            this.btnThem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnThem.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateCommon.Border.Rounding = 20F;
            this.btnThem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.StateDisabled.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnThem.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnThem.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btnThem.StateTracking.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnThem.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.Values.Image = global::pharmacy_management.Properties.Resources.icons8_plus_24;
            this.btnThem.Values.Text = "";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.CornerRoundingRadius = 50F;
            this.btnRefresh.Location = new System.Drawing.Point(341, 20);
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
            // backlbl
            // 
            this.backlbl.Location = new System.Drawing.Point(3, 0);
            this.backlbl.Name = "backlbl";
            this.backlbl.Size = new System.Drawing.Size(46, 42);
            this.backlbl.TabIndex = 34;
            this.backlbl.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonLabel3.Values.Image")));
            this.backlbl.Values.Text = "";
            this.backlbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backlbl_MouseClick);
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
        private Krypton.Toolkit.KryptonButton searchbtn;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonCheckBox ckbTrangThai;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtTenDoiTuong;
        private Krypton.Toolkit.KryptonTextBox txtMaDoiTuong;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbbSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private Krypton.Toolkit.KryptonDataGridView DGVDoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private Krypton.Toolkit.KryptonButton btnXuat;
        private Krypton.Toolkit.KryptonButton btnXoa;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton btnRefresh;
        private Krypton.Toolkit.KryptonLabel backlbl;
    }
}