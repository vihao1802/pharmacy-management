﻿namespace pharmacy_management.GUI.QuyDoiDiem
{
    partial class PhieuGiamGiaFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip_rpt = new System.Windows.Forms.ToolTip(this.components);
            this.txt_searching = new Krypton.Toolkit.KryptonRichTextBox();
            this.btn_filter = new Krypton.Toolkit.KryptonButton();
            this.gv_QDD = new System.Windows.Forms.DataGridView();
            this.MaPhieuGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuyDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQuyDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btn_export_excel = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv_QDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_searching
            // 
            this.txt_searching.Location = new System.Drawing.Point(12, 12);
            this.txt_searching.Multiline = false;
            this.txt_searching.Name = "txt_searching";
            this.txt_searching.Size = new System.Drawing.Size(478, 40);
            this.txt_searching.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_searching.StateCommon.Border.Rounding = 5F;
            this.txt_searching.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 5, 10, -1);
            this.txt_searching.TabIndex = 28;
            this.txt_searching.Text = "";
            this.txt_searching.TextChanged += new System.EventHandler(this.txt_searching_TextChanged);
            this.txt_searching.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searching_KeyPress);
            // 
            // btn_filter
            // 
            this.btn_filter.CornerRoundingRadius = 50F;
            this.btn_filter.Location = new System.Drawing.Point(508, 12);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.OverrideDefault.Back.Image = global::pharmacy_management.Properties.Resources.icons8_search_24;
            this.btn_filter.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_filter.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_filter.OverrideDefault.Border.Rounding = 50F;
            this.btn_filter.OverrideDefault.Border.Width = 5;
            this.btn_filter.Size = new System.Drawing.Size(40, 40);
            this.btn_filter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_filter.StateCommon.Border.Rounding = 50F;
            this.btn_filter.StateCommon.Border.Width = 5;
            this.btn_filter.StateNormal.Back.Image = global::pharmacy_management.Properties.Resources.icons8_search_24;
            this.btn_filter.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_filter.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.btn_filter.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_filter.StateTracking.Back.Image = global::pharmacy_management.Properties.Resources.icons8_search_24;
            this.btn_filter.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_filter.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.btn_filter.StateTracking.Border.Color2 = System.Drawing.Color.Blue;
            this.btn_filter.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_filter.StateTracking.Border.Rounding = 50F;
            this.btn_filter.StateTracking.Border.Width = 5;
            this.btn_filter.TabIndex = 31;
            this.btn_filter.Values.Text = "";
            // 
            // gv_QDD
            // 
            this.gv_QDD.AllowUserToAddRows = false;
            this.gv_QDD.AllowUserToDeleteRows = false;
            this.gv_QDD.AllowUserToOrderColumns = true;
            this.gv_QDD.AllowUserToResizeRows = false;
            this.gv_QDD.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gv_QDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_QDD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_QDD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gv_QDD.ColumnHeadersHeight = 30;
            this.gv_QDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_QDD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuGiam,
            this.MaQuyDoi,
            this.MoTa,
            this.DiemQuyDoi,
            this.PhanTram});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_QDD.DefaultCellStyle = dataGridViewCellStyle14;
            this.gv_QDD.EnableHeadersVisualStyles = false;
            this.gv_QDD.GridColor = System.Drawing.Color.Black;
            this.gv_QDD.Location = new System.Drawing.Point(12, 62);
            this.gv_QDD.Name = "gv_QDD";
            this.gv_QDD.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_QDD.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gv_QDD.RowHeadersVisible = false;
            this.gv_QDD.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gv_QDD.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gv_QDD.RowTemplate.Height = 24;
            this.gv_QDD.Size = new System.Drawing.Size(926, 576);
            this.gv_QDD.TabIndex = 27;
            // 
            // MaPhieuGiam
            // 
            this.MaPhieuGiam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaPhieuGiam.HeaderText = "Mã Phiếu";
            this.MaPhieuGiam.MinimumWidth = 80;
            this.MaPhieuGiam.Name = "MaPhieuGiam";
            this.MaPhieuGiam.ReadOnly = true;
            this.MaPhieuGiam.Width = 121;
            // 
            // MaQuyDoi
            // 
            this.MaQuyDoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaQuyDoi.HeaderText = "Mã đổi";
            this.MaQuyDoi.MinimumWidth = 6;
            this.MaQuyDoi.Name = "MaQuyDoi";
            this.MaQuyDoi.ReadOnly = true;
            this.MaQuyDoi.Width = 97;
            // 
            // MoTa
            // 
            this.MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTa.HeaderText = "Mô tả ";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // DiemQuyDoi
            // 
            this.DiemQuyDoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiemQuyDoi.HeaderText = "Điểm";
            this.DiemQuyDoi.MinimumWidth = 80;
            this.DiemQuyDoi.Name = "DiemQuyDoi";
            this.DiemQuyDoi.ReadOnly = true;
            this.DiemQuyDoi.Width = 83;
            // 
            // PhanTram
            // 
            this.PhanTram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhanTram.HeaderText = "%";
            this.PhanTram.MinimumWidth = 6;
            this.PhanTram.Name = "PhanTram";
            this.PhanTram.ReadOnly = true;
            this.PhanTram.Width = 55;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_export_excel);
            this.kryptonPanel1.Controls.Add(this.txt_searching);
            this.kryptonPanel1.Controls.Add(this.btn_filter);
            this.kryptonPanel1.Controls.Add(this.gv_QDD);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(950, 650);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.ColorAngle = 60F;
            this.kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonPanel1.TabIndex = 3;
            // 
            // btn_export_excel
            // 
            this.btn_export_excel.CornerRoundingRadius = 5F;
            this.btn_export_excel.Location = new System.Drawing.Point(838, 12);
            this.btn_export_excel.Name = "btn_export_excel";
            this.btn_export_excel.OverrideDefault.Back.Color1 = System.Drawing.Color.Green;
            this.btn_export_excel.OverrideDefault.Back.Color2 = System.Drawing.Color.Green;
            this.btn_export_excel.OverrideDefault.Back.Image = global::pharmacy_management.Properties.Resources.icons8_microsoft_excel_24;
            this.btn_export_excel.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_export_excel.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.btn_export_excel.OverrideDefault.Border.Color2 = System.Drawing.Color.Green;
            this.btn_export_excel.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_export_excel.OverrideDefault.Border.Rounding = 5F;
            this.btn_export_excel.OverrideDefault.Border.Width = 5;
            this.btn_export_excel.Size = new System.Drawing.Size(100, 40);
            this.btn_export_excel.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.btn_export_excel.StateCommon.Back.Color2 = System.Drawing.Color.Green;
            this.btn_export_excel.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.btn_export_excel.StateCommon.Border.Color2 = System.Drawing.Color.Green;
            this.btn_export_excel.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_export_excel.StateCommon.Border.Rounding = 5F;
            this.btn_export_excel.StateCommon.Border.Width = 5;
            this.btn_export_excel.StateNormal.Back.Image = global::pharmacy_management.Properties.Resources.icons8_microsoft_excel_24;
            this.btn_export_excel.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_export_excel.StateTracking.Back.Color1 = System.Drawing.Color.DarkGreen;
            this.btn_export_excel.StateTracking.Back.Color2 = System.Drawing.Color.DarkGreen;
            this.btn_export_excel.StateTracking.Back.Image = global::pharmacy_management.Properties.Resources.icons8_microsoft_excel_24;
            this.btn_export_excel.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_export_excel.StateTracking.Border.Color1 = System.Drawing.Color.DarkGreen;
            this.btn_export_excel.StateTracking.Border.Color2 = System.Drawing.Color.DarkGreen;
            this.btn_export_excel.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_export_excel.StateTracking.Border.Rounding = 5F;
            this.btn_export_excel.StateTracking.Border.Width = 5;
            this.btn_export_excel.TabIndex = 32;
            this.toolTip_rpt.SetToolTip(this.btn_export_excel, "Xuất excel");
            this.btn_export_excel.Values.Text = "";
            this.btn_export_excel.Click += new System.EventHandler(this.btn_export_excel_Click);
            // 
            // PhieuGiamGiaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuGiamGiaFrm";
            this.Text = "PhieuGiamGiaFrm";
            ((System.ComponentModel.ISupportInitialize)(this.gv_QDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip_rpt;
        private Krypton.Toolkit.KryptonRichTextBox txt_searching;
        private Krypton.Toolkit.KryptonButton btn_filter;
        private System.Windows.Forms.DataGridView gv_QDD;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btn_export_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQuyDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTram;
    }
}