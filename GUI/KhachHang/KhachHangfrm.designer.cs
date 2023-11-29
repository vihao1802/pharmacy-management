namespace pharmacy_management.GUI.KhachHang
{
    partial class KhachHangfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btn_refresh = new Krypton.Toolkit.KryptonButton();
            this.txt_searching = new Krypton.Toolkit.KryptonRichTextBox();
            this.khachhangDataGridView = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuat = new Krypton.Toolkit.KryptonButton();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.lbl_DiemKH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbTrangThai = new Krypton.Toolkit.KryptonCheckBox();
            this.txtNgaySinh = new Krypton.Toolkit.KryptonDateTimePicker();
            this.txtSDT = new Krypton.Toolkit.KryptonTextBox();
            this.txtTenKH = new Krypton.Toolkit.KryptonTextBox();
            this.txtMaKH = new Krypton.Toolkit.KryptonTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_refresh);
            this.kryptonPanel1.Controls.Add(this.txt_searching);
            this.kryptonPanel1.Controls.Add(this.khachhangDataGridView);
            this.kryptonPanel1.Controls.Add(this.btnXuat);
            this.kryptonPanel1.Controls.Add(this.btnSua);
            this.kryptonPanel1.Controls.Add(this.btnThem);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(949, 650);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.ColorAngle = 60F;
            this.kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonPanel1.TabIndex = 0;
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // btn_refresh
            // 
            this.btn_refresh.CornerRoundingRadius = 50F;
            this.btn_refresh.Location = new System.Drawing.Point(340, 202);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_refresh.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_refresh.OverrideDefault.Back.Image = global::pharmacy_management.Properties.Resources.icons8_refresh_24;
            this.btn_refresh.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_refresh.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_refresh.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_refresh.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_refresh.OverrideDefault.Border.Rounding = 50F;
            this.btn_refresh.OverrideDefault.Border.Width = 5;
            this.btn_refresh.Size = new System.Drawing.Size(53, 49);
            this.btn_refresh.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_refresh.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_refresh.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_refresh.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_refresh.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_refresh.StateCommon.Border.Rounding = 50F;
            this.btn_refresh.StateCommon.Border.Width = 5;
            this.btn_refresh.StateNormal.Back.Image = global::pharmacy_management.Properties.Resources.icons8_refresh_24;
            this.btn_refresh.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_refresh.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.btn_refresh.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_refresh.StateTracking.Back.Image = global::pharmacy_management.Properties.Resources.icons8_refresh_24;
            this.btn_refresh.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_refresh.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.btn_refresh.StateTracking.Border.Color2 = System.Drawing.Color.Blue;
            this.btn_refresh.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_refresh.StateTracking.Border.Rounding = 50F;
            this.btn_refresh.StateTracking.Border.Width = 5;
            this.btn_refresh.TabIndex = 61;
            this.btn_refresh.Values.Text = "";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_searching
            // 
            this.txt_searching.Location = new System.Drawing.Point(12, 202);
            this.txt_searching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_searching.Multiline = false;
            this.txt_searching.Name = "txt_searching";
            this.txt_searching.Size = new System.Drawing.Size(309, 39);
            this.txt_searching.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_searching.StateCommon.Border.Rounding = 5F;
            this.txt_searching.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 5, 10, -1);
            this.txt_searching.TabIndex = 44;
            this.txt_searching.Text = "";
            this.txt_searching.TextChanged += new System.EventHandler(this.txt_searching_TextChanged);
            // 
            // khachhangDataGridView
            // 
            this.khachhangDataGridView.AllowUserToAddRows = false;
            this.khachhangDataGridView.AllowUserToDeleteRows = false;
            this.khachhangDataGridView.AllowUserToOrderColumns = true;
            this.khachhangDataGridView.AllowUserToResizeRows = false;
            this.khachhangDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.khachhangDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.khachhangDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.khachhangDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.khachhangDataGridView.ColumnHeadersHeight = 30;
            this.khachhangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.khachhangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SDT,
            this.NgaySinh,
            this.TrangThai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.khachhangDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.khachhangDataGridView.EnableHeadersVisualStyles = false;
            this.khachhangDataGridView.GridColor = System.Drawing.Color.Black;
            this.khachhangDataGridView.Location = new System.Drawing.Point(3, 257);
            this.khachhangDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khachhangDataGridView.Name = "khachhangDataGridView";
            this.khachhangDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.khachhangDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.khachhangDataGridView.RowHeadersVisible = false;
            this.khachhangDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.khachhangDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.khachhangDataGridView.RowTemplate.Height = 24;
            this.khachhangDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.khachhangDataGridView.Size = new System.Drawing.Size(947, 390);
            this.khachhangDataGridView.TabIndex = 43;
            this.khachhangDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.khachhangDataGridView_CellMouseClick);
            this.khachhangDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.khachhangDataGridView_CellMouseDoubleClick);
            this.khachhangDataGridView.SelectionChanged += new System.EventHandler(this.khachhangDataGridView_SelectionChanged);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 97;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 130;
            // 
            // btnXuat
            // 
            this.btnXuat.CornerRoundingRadius = 5F;
            this.btnXuat.Location = new System.Drawing.Point(545, 202);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnXuat.Size = new System.Drawing.Size(100, 39);
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
            this.btnXuat.TabIndex = 41;
            this.toolTip1.SetToolTip(this.btnXuat, "Xuất excel");
            this.btnXuat.Values.Text = "";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnSua
            // 
            this.btnSua.CornerRoundingRadius = 5F;
            this.btnSua.Location = new System.Drawing.Point(691, 202);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnSua.Size = new System.Drawing.Size(100, 39);
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
            this.btnSua.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa khách hàng");
            this.btnSua.Values.Text = "";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.CornerRoundingRadius = 5F;
            this.btnThem.Location = new System.Drawing.Point(837, 202);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnThem.Size = new System.Drawing.Size(100, 39);
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
            this.btnThem.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm khách hàng");
            this.btnThem.Values.Text = "";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 0);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbl_DiemKH);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ckbTrangThai);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtNgaySinh);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtSDT);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtTenKH);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtMaKH);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(925, 194);
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Thông tin khách hàng";
            // 
            // lbl_DiemKH
            // 
            this.lbl_DiemKH.AutoSize = true;
            this.lbl_DiemKH.BackColor = System.Drawing.Color.White;
            this.lbl_DiemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiemKH.Location = new System.Drawing.Point(879, 160);
            this.lbl_DiemKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiemKH.Name = "lbl_DiemKH";
            this.lbl_DiemKH.Size = new System.Drawing.Size(61, 25);
            this.lbl_DiemKH.TabIndex = 51;
            this.lbl_DiemKH.Text = "3,000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(779, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(507, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(537, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tên khách hàng";
            // 
            // ckbTrangThai
            // 
            this.ckbTrangThai.Checked = true;
            this.ckbTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbTrangThai.Enabled = false;
            this.ckbTrangThai.Location = new System.Drawing.Point(207, 128);
            this.ckbTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbTrangThai.Name = "ckbTrangThai";
            this.ckbTrangThai.Size = new System.Drawing.Size(118, 27);
            this.ckbTrangThai.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTrangThai.TabIndex = 10;
            this.ckbTrangThai.Values.Text = "Hoạt động";
            this.ckbTrangThai.Visible = false;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.CalendarTodayDate = new System.DateTime(2023, 11, 19, 0, 0, 0, 0);
            this.txtNgaySinh.CornerRoundingRadius = 10F;
            this.txtNgaySinh.CustomFormat = "yyyy-MM-dd";
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaySinh.Location = new System.Drawing.Point(664, 74);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgaySinh.MaxDate = new System.DateTime(2023, 11, 23, 0, 0, 0, 0);
            this.txtNgaySinh.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(185, 31);
            this.txtNgaySinh.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNgaySinh.StateCommon.Border.Rounding = 10F;
            this.txtNgaySinh.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(664, 18);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(185, 33);
            this.txtSDT.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSDT.StateCommon.Border.Rounding = 10F;
            this.txtSDT.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(207, 73);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(185, 33);
            this.txtTenKH.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenKH.StateCommon.Border.Rounding = 10F;
            this.txtTenKH.TabIndex = 5;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(207, 18);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(185, 33);
            this.txtMaKH.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaKH.StateCommon.Border.Rounding = 10F;
            this.txtMaKH.TabIndex = 4;
            // 
            // KhachHangfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 650);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KhachHangfrm";
            this.Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachhangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonDateTimePicker txtNgaySinh;
        private Krypton.Toolkit.KryptonTextBox txtSDT;
        private Krypton.Toolkit.KryptonTextBox txtTenKH;
        private Krypton.Toolkit.KryptonTextBox txtMaKH;
        private Krypton.Toolkit.KryptonCheckBox ckbTrangThai;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView khachhangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label lbl_DiemKH;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonRichTextBox txt_searching;
        private System.Windows.Forms.ToolTip toolTip1;
        private Krypton.Toolkit.KryptonButton btn_refresh;
    }
}