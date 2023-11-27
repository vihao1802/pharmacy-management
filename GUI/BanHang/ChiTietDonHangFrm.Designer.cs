namespace pharmacy_management.GUI.BanHang
{
    partial class ChiTietDonHangFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MaDH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_export_PDF = new Krypton.Toolkit.KryptonButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_Giam = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_TongGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gv_SanPhamDH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_NgayLap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_TenNV = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_sdtKH = new System.Windows.Forms.Label();
            this.lbl_TenKH = new System.Windows.Forms.Label();
            this.lbl_MaKH = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SanPhamDH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ ĐƠN HÀNG:";
            // 
            // lbl_MaDH
            // 
            this.lbl_MaDH.AutoSize = true;
            this.lbl_MaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaDH.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_MaDH.Location = new System.Drawing.Point(255, 10);
            this.lbl_MaDH.Name = "lbl_MaDH";
            this.lbl_MaDH.Size = new System.Drawing.Size(26, 29);
            this.lbl_MaDH.TabIndex = 1;
            this.lbl_MaDH.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_export_PDF);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_ThanhTien);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbl_Giam);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_TongGia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_NgayLap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_MaNV);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lbl_TenNV);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lbl_sdtKH);
            this.panel1.Controls.Add(this.lbl_TenKH);
            this.panel1.Controls.Add(this.lbl_MaKH);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_MaDH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1082, 611);
            this.panel1.TabIndex = 6;
            // 
            // btn_export_PDF
            // 
            this.btn_export_PDF.CornerRoundingRadius = 5F;
            this.btn_export_PDF.Location = new System.Drawing.Point(18, 558);
            this.btn_export_PDF.Name = "btn_export_PDF";
            this.btn_export_PDF.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(50)))), ((int)(((byte)(91)))));
            this.btn_export_PDF.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(50)))), ((int)(((byte)(91)))));
            this.btn_export_PDF.OverrideDefault.Back.Image = global::pharmacy_management.Properties.Resources.icons8_pdf_30;
            this.btn_export_PDF.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_export_PDF.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(50)))), ((int)(((byte)(91)))));
            this.btn_export_PDF.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(50)))), ((int)(((byte)(91)))));
            this.btn_export_PDF.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_export_PDF.OverrideDefault.Border.Rounding = 5F;
            this.btn_export_PDF.OverrideDefault.Border.Width = 5;
            this.btn_export_PDF.Size = new System.Drawing.Size(100, 40);
            this.btn_export_PDF.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(50)))), ((int)(((byte)(91)))));
            this.btn_export_PDF.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(50)))), ((int)(((byte)(91)))));
            this.btn_export_PDF.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.icons8_pdf_30;
            this.btn_export_PDF.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_export_PDF.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(50)))), ((int)(((byte)(91)))));
            this.btn_export_PDF.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(50)))), ((int)(((byte)(91)))));
            this.btn_export_PDF.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_export_PDF.StateCommon.Border.Rounding = 5F;
            this.btn_export_PDF.StateCommon.Border.Width = 5;
            this.btn_export_PDF.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.btn_export_PDF.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.btn_export_PDF.StateDisabled.Border.Color1 = System.Drawing.Color.Gray;
            this.btn_export_PDF.StateDisabled.Border.Color2 = System.Drawing.Color.Gray;
            this.btn_export_PDF.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_export_PDF.StateTracking.Back.Color1 = System.Drawing.Color.Crimson;
            this.btn_export_PDF.StateTracking.Back.Color2 = System.Drawing.Color.Crimson;
            this.btn_export_PDF.StateTracking.Back.Image = global::pharmacy_management.Properties.Resources.icons8_pdf_30;
            this.btn_export_PDF.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_export_PDF.StateTracking.Border.Color1 = System.Drawing.Color.Crimson;
            this.btn_export_PDF.StateTracking.Border.Color2 = System.Drawing.Color.Crimson;
            this.btn_export_PDF.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_export_PDF.StateTracking.Border.Rounding = 5F;
            this.btn_export_PDF.StateTracking.Border.Width = 5;
            this.btn_export_PDF.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btn_export_PDF, "Xuất PDF");
            this.btn_export_PDF.Values.Text = "";
            this.btn_export_PDF.Click += new System.EventHandler(this.btn_export_PDF_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(640, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 1);
            this.label6.TabIndex = 34;
            this.label6.Text = "label6";
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_ThanhTien.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ThanhTien.Location = new System.Drawing.Point(910, 564);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(99, 25);
            this.lbl_ThanhTien.TabIndex = 33;
            this.lbl_ThanhTien.Text = "300,000 đ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(782, 564);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Thành tiền:";
            // 
            // lbl_Giam
            // 
            this.lbl_Giam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Giam.AutoSize = true;
            this.lbl_Giam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Giam.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Giam.Location = new System.Drawing.Point(916, 506);
            this.lbl_Giam.Name = "lbl_Giam";
            this.lbl_Giam.Size = new System.Drawing.Size(52, 25);
            this.lbl_Giam.TabIndex = 31;
            this.lbl_Giam.Text = "15%";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(806, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Đã giảm:";
            // 
            // lbl_TongGia
            // 
            this.lbl_TongGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TongGia.AutoSize = true;
            this.lbl_TongGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TongGia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_TongGia.Location = new System.Drawing.Point(910, 459);
            this.lbl_TongGia.Name = "lbl_TongGia";
            this.lbl_TongGia.Size = new System.Drawing.Size(99, 25);
            this.lbl_TongGia.TabIndex = 29;
            this.lbl_TongGia.Text = "300,000 đ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(800, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tổng giá:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gv_SanPhamDH);
            this.panel2.Location = new System.Drawing.Point(12, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 227);
            this.panel2.TabIndex = 27;
            // 
            // gv_SanPhamDH
            // 
            this.gv_SanPhamDH.AllowUserToAddRows = false;
            this.gv_SanPhamDH.AllowUserToDeleteRows = false;
            this.gv_SanPhamDH.AllowUserToOrderColumns = true;
            this.gv_SanPhamDH.AllowUserToResizeRows = false;
            this.gv_SanPhamDH.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gv_SanPhamDH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_SanPhamDH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_SanPhamDH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_SanPhamDH.ColumnHeadersHeight = 30;
            this.gv_SanPhamDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_SanPhamDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_SanPhamDH.DefaultCellStyle = dataGridViewCellStyle6;
            this.gv_SanPhamDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_SanPhamDH.EnableHeadersVisualStyles = false;
            this.gv_SanPhamDH.GridColor = System.Drawing.Color.Black;
            this.gv_SanPhamDH.Location = new System.Drawing.Point(0, 0);
            this.gv_SanPhamDH.Name = "gv_SanPhamDH";
            this.gv_SanPhamDH.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_SanPhamDH.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gv_SanPhamDH.RowHeadersVisible = false;
            this.gv_SanPhamDH.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gv_SanPhamDH.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gv_SanPhamDH.RowTemplate.Height = 24;
            this.gv_SanPhamDH.Size = new System.Drawing.Size(1068, 227);
            this.gv_SanPhamDH.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Mã thuốc";
            this.Column1.MinimumWidth = 80;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Tên thuốc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Số lượng";
            this.Column2.MinimumWidth = 80;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lbl_NgayLap
            // 
            this.lbl_NgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NgayLap.AutoSize = true;
            this.lbl_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NgayLap.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_NgayLap.Location = new System.Drawing.Point(881, 14);
            this.lbl_NgayLap.Name = "lbl_NgayLap";
            this.lbl_NgayLap.Size = new System.Drawing.Size(114, 25);
            this.lbl_NgayLap.TabIndex = 20;
            this.lbl_NgayLap.Text = "2023-08-12";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(692, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày lập:";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaNV.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_MaNV.Location = new System.Drawing.Point(881, 66);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(23, 25);
            this.lbl_MaNV.TabIndex = 18;
            this.lbl_MaNV.Text = "1";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(692, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 25);
            this.label18.TabIndex = 17;
            this.label18.Text = "Mã nhân viên:";
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TenNV.AutoSize = true;
            this.lbl_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenNV.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_TenNV.Location = new System.Drawing.Point(881, 114);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.Size = new System.Drawing.Size(113, 25);
            this.lbl_TenNV.TabIndex = 15;
            this.lbl_TenNV.Text = "Trần Văn A";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(692, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 25);
            this.label16.TabIndex = 13;
            this.label16.Text = "Họ tên:";
            // 
            // lbl_sdtKH
            // 
            this.lbl_sdtKH.AutoSize = true;
            this.lbl_sdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sdtKH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_sdtKH.Location = new System.Drawing.Point(255, 165);
            this.lbl_sdtKH.Name = "lbl_sdtKH";
            this.lbl_sdtKH.Size = new System.Drawing.Size(122, 25);
            this.lbl_sdtKH.TabIndex = 12;
            this.lbl_sdtKH.Text = "0912345678";
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.AutoSize = true;
            this.lbl_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenKH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_TenKH.Location = new System.Drawing.Point(255, 114);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(113, 25);
            this.lbl_TenKH.TabIndex = 11;
            this.lbl_TenKH.Text = "Trần Văn A";
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.BackColor = System.Drawing.Color.White;
            this.lbl_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaKH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_MaKH.Location = new System.Drawing.Point(255, 66);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(0, 25);
            this.lbl_MaKH.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(13, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(13, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã khách hàng:";
            // 
            // ChiTietDonHangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 611);
            this.Controls.Add(this.panel1);
            this.Name = "ChiTietDonHangFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đơn hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_SanPhamDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MaDH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_TenNV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_sdtKH;
        private System.Windows.Forms.Label lbl_TenKH;
        private System.Windows.Forms.Label lbl_MaKH;
        private System.Windows.Forms.Label lbl_NgayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gv_SanPhamDH;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_Giam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_TongGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label6;
        private Krypton.Toolkit.KryptonButton btn_export_PDF;
        private System.Windows.Forms.ToolTip toolTip1;
        //private Krypton.Toolkit.KryptonPalette kryptonPalette2;
    }
}