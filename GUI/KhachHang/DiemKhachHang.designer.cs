﻿namespace pharmacy_management.GUI.KhachHang
{
    partial class DiemKhachHang
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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.bangdiemDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.MaBangDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDaSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.txtMaKH = new Krypton.Toolkit.KryptonTextBox();
            this.txtDiemDaSuDung = new Krypton.Toolkit.KryptonTextBox();
            this.txtDiemTichLuy = new Krypton.Toolkit.KryptonTextBox();
            this.txtMaBangDiem = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangdiemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.bangdiemDataGridView);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(702, 435);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Navy;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Teal;
            this.kryptonPanel1.StateCommon.ColorAngle = 60F;
            this.kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // bangdiemDataGridView
            // 
            this.bangdiemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bangdiemDataGridView.ColumnHeadersHeight = 36;
            this.bangdiemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBangDiem,
            this.MaKhachHang,
            this.DiemTichLuy,
            this.DiemDaSuDung});
            this.bangdiemDataGridView.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.bangdiemDataGridView.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.bangdiemDataGridView.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.bangdiemDataGridView.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.bangdiemDataGridView.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.bangdiemDataGridView.Location = new System.Drawing.Point(254, 4);
            this.bangdiemDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bangdiemDataGridView.Name = "bangdiemDataGridView";
            this.bangdiemDataGridView.RowHeadersVisible = false;
            this.bangdiemDataGridView.RowHeadersWidth = 51;
            this.bangdiemDataGridView.Size = new System.Drawing.Size(442, 423);
            this.bangdiemDataGridView.TabIndex = 2;
            this.bangdiemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangdiemDataGridView_CellContentClick);
            // 
            // MaBangDiem
            // 
            this.MaBangDiem.HeaderText = "Mã bảng điểm";
            this.MaBangDiem.MinimumWidth = 6;
            this.MaBangDiem.Name = "MaBangDiem";
            this.MaBangDiem.ReadOnly = true;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            // 
            // DiemTichLuy
            // 
            this.DiemTichLuy.HeaderText = "Điểm tích lũy";
            this.DiemTichLuy.MinimumWidth = 6;
            this.DiemTichLuy.Name = "DiemTichLuy";
            // 
            // DiemDaSuDung
            // 
            this.DiemDaSuDung.HeaderText = "Điểm đã tích lũy";
            this.DiemDaSuDung.MinimumWidth = 6;
            this.DiemDaSuDung.Name = "DiemDaSuDung";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionOverlap = 0D;
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.InputControlRibbon;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtMaKH);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtDiemDaSuDung);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtDiemTichLuy);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtMaBangDiem);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(242, 423);
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Thông tin điểm khách hàng";
            this.kryptonGroupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox1_Paint);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(15, 156);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(185, 33);
            this.txtMaKH.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaKH.StateCommon.Border.Rounding = 10F;
            this.txtMaKH.TabIndex = 8;
            // 
            // txtDiemDaSuDung
            // 
            this.txtDiemDaSuDung.Location = new System.Drawing.Point(15, 340);
            this.txtDiemDaSuDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiemDaSuDung.Name = "txtDiemDaSuDung";
            this.txtDiemDaSuDung.Size = new System.Drawing.Size(185, 33);
            this.txtDiemDaSuDung.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDiemDaSuDung.StateCommon.Border.Rounding = 10F;
            this.txtDiemDaSuDung.TabIndex = 7;
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.Location = new System.Drawing.Point(15, 242);
            this.txtDiemTichLuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.Size = new System.Drawing.Size(185, 33);
            this.txtDiemTichLuy.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDiemTichLuy.StateCommon.Border.Rounding = 10F;
            this.txtDiemTichLuy.TabIndex = 6;
            // 
            // txtMaBangDiem
            // 
            this.txtMaBangDiem.Location = new System.Drawing.Point(15, 58);
            this.txtMaBangDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaBangDiem.Name = "txtMaBangDiem";
            this.txtMaBangDiem.Size = new System.Drawing.Size(185, 33);
            this.txtMaBangDiem.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaBangDiem.StateCommon.Border.Rounding = 10F;
            this.txtMaBangDiem.TabIndex = 4;
            this.txtMaBangDiem.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(15, 308);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(115, 19);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Điểm đã sử dụng";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(15, 210);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(90, 19);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Điểm tích lũy";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 117);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(105, 19);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Mã khách hàng";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 26);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 19);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Mã bảng điểm";
            // 
            // DiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 435);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DiemKhachHang";
            this.Text = "DiemKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bangdiemDataGridView)).EndInit();
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
        private Krypton.Toolkit.KryptonDataGridView bangdiemDataGridView;
        private Krypton.Toolkit.KryptonTextBox txtDiemDaSuDung;
        private Krypton.Toolkit.KryptonTextBox txtDiemTichLuy;
        private Krypton.Toolkit.KryptonTextBox txtMaBangDiem;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBangDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTichLuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDaSuDung;
    }
}