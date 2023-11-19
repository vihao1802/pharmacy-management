namespace pharmacy_management.GUI.BanHang
{
    partial class DonHangFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Label();
            this.btn_increase_price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_descend_DonHang = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.btn_filter = new Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_searching = new Krypton.Toolkit.KryptonRichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtp_end);
            this.panel1.Controls.Add(this.dtp_start);
            this.panel1.Controls.Add(this.btn_filter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_searching);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 159);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.btn_increase_price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_descend_DonHang);
            this.panel2.Location = new System.Drawing.Point(22, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 60);
            this.panel2.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.AutoSize = true;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = global::pharmacy_management.Properties.Resources.icons8_refresh_24;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(835, 19);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(28, 22);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "   ";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_increase_price
            // 
            this.btn_increase_price.AutoSize = true;
            this.btn_increase_price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_increase_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_increase_price.ForeColor = System.Drawing.Color.White;
            this.btn_increase_price.Image = global::pharmacy_management.Properties.Resources.icons8_down_24_white;
            this.btn_increase_price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_increase_price.Location = new System.Drawing.Point(652, 19);
            this.btn_increase_price.Name = "btn_increase_price";
            this.btn_increase_price.Size = new System.Drawing.Size(130, 22);
            this.btn_increase_price.TabIndex = 5;
            this.btn_increase_price.Text = "    Thành tiền";
            this.btn_increase_price.Click += new System.EventHandler(this.btn_increase_price_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(380, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "# Quy đổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(528, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(230, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "# Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "# Nhân viên";
            // 
            // btn_descend_DonHang
            // 
            this.btn_descend_DonHang.AutoSize = true;
            this.btn_descend_DonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_descend_DonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_descend_DonHang.ForeColor = System.Drawing.Color.White;
            this.btn_descend_DonHang.Image = global::pharmacy_management.Properties.Resources.icons8_down_24_white;
            this.btn_descend_DonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_descend_DonHang.Location = new System.Drawing.Point(12, 19);
            this.btn_descend_DonHang.Name = "btn_descend_DonHang";
            this.btn_descend_DonHang.Size = new System.Drawing.Size(76, 22);
            this.btn_descend_DonHang.TabIndex = 0;
            this.btn_descend_DonHang.Text = "    Đơn ";
            this.btn_descend_DonHang.Click += new System.EventHandler(this.btn_descend_DonHang_Click);
            // 
            // dtp_end
            // 
            this.dtp_end.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_end.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtp_end.CalendarTrailingForeColor = System.Drawing.Color.Blue;
            this.dtp_end.CustomFormat = "yyyy-MM-dd";
            this.dtp_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(716, 30);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(140, 27);
            this.dtp_end.TabIndex = 13;
            // 
            // dtp_start
            // 
            this.dtp_start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_start.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtp_start.CustomFormat = "yyyy-MM-dd";
            this.dtp_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(519, 30);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(140, 27);
            this.dtp_start.TabIndex = 12;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // btn_filter
            // 
            this.btn_filter.CornerRoundingRadius = 50F;
            this.btn_filter.Location = new System.Drawing.Point(877, 20);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.OverrideDefault.Back.Image = global::pharmacy_management.Properties.Resources.icons8_search_30;
            this.btn_filter.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_filter.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_filter.OverrideDefault.Border.Rounding = 50F;
            this.btn_filter.OverrideDefault.Border.Width = 5;
            this.btn_filter.Size = new System.Drawing.Size(45, 45);
            this.btn_filter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_filter.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_filter.StateCommon.Border.Rounding = 50F;
            this.btn_filter.StateCommon.Border.Width = 5;
            this.btn_filter.StateNormal.Back.Image = global::pharmacy_management.Properties.Resources.icons8_search_30;
            this.btn_filter.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_filter.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.btn_filter.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.btn_filter.StateTracking.Back.Image = global::pharmacy_management.Properties.Resources.icons8_search_30;
            this.btn_filter.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_filter.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.btn_filter.StateTracking.Border.Color2 = System.Drawing.Color.Blue;
            this.btn_filter.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_filter.StateTracking.Border.Rounding = 50F;
            this.btn_filter.StateTracking.Border.Width = 5;
            this.btn_filter.TabIndex = 11;
            this.btn_filter.Values.Text = "";
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(665, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(472, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ ";
            // 
            // txt_searching
            // 
            this.txt_searching.Location = new System.Drawing.Point(22, 25);
            this.txt_searching.Multiline = false;
            this.txt_searching.Name = "txt_searching";
            this.txt_searching.Size = new System.Drawing.Size(412, 40);
            this.txt_searching.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_searching.StateCommon.Border.Rounding = 5F;
            this.txt_searching.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 5, 10, -1);
            this.txt_searching.TabIndex = 6;
            this.txt_searching.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 159);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 10, 25, 30);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 491);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // DonHangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonHangFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonRichTextBox txt_searching;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonButton btn_filter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btn_descend_DonHang;
        private System.Windows.Forms.Label btn_increase_price;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label btn_refresh;
    }
}