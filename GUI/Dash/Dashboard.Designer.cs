namespace pharmacy_management.GUI
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Banners = new Krypton.Toolkit.KryptonPanel();
            this.btnRight = new Krypton.Toolkit.KryptonButton();
            this.btnLeft = new Krypton.Toolkit.KryptonButton();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TKthuoc = new Krypton.Toolkit.KryptonPanel();
            this.Numthuoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TKkhach = new Krypton.Toolkit.KryptonPanel();
            this.Numkhach = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TKslban = new Krypton.Toolkit.KryptonPanel();
            this.Numslban = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TKdoanhthu = new Krypton.Toolkit.KryptonPanel();
            this.Numdoanhthu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Banners)).BeginInit();
            this.Banners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKthuoc)).BeginInit();
            this.TKthuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKkhach)).BeginInit();
            this.TKkhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKslban)).BeginInit();
            this.TKslban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKdoanhthu)).BeginInit();
            this.TKdoanhthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Banners
            // 
            this.Banners.Controls.Add(this.btnRight);
            this.Banners.Controls.Add(this.btnLeft);
            this.Banners.Controls.Add(this.picBanner);
            this.Banners.Dock = System.Windows.Forms.DockStyle.Top;
            this.Banners.Location = new System.Drawing.Point(0, 0);
            this.Banners.Name = "Banners";
            this.Banners.Size = new System.Drawing.Size(932, 100);
            this.Banners.StateCommon.Color1 = System.Drawing.Color.White;
            this.Banners.StateCommon.Color2 = System.Drawing.Color.White;
            this.Banners.TabIndex = 8;
            // 
            // btnRight
            // 
            this.btnRight.ButtonStyle = Krypton.Toolkit.ButtonStyle.InputControl;
            this.btnRight.CornerRoundingRadius = -1F;
            this.btnRight.Location = new System.Drawing.Point(845, 10);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(79, 70);
            this.btnRight.TabIndex = 9;
            this.btnRight.Values.Image = global::pharmacy_management.Properties.Resources.Double_Right;
            this.btnRight.Values.Text = "";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.ButtonStyle = Krypton.Toolkit.ButtonStyle.InputControl;
            this.btnLeft.CornerRoundingRadius = -1F;
            this.btnLeft.Location = new System.Drawing.Point(5, 15);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(79, 65);
            this.btnLeft.TabIndex = 10;
            this.btnLeft.Values.Image = global::pharmacy_management.Properties.Resources.Double_Left;
            this.btnLeft.Values.Text = "";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // picBanner
            // 
            this.picBanner.Image = global::pharmacy_management.Properties.Resources.banner1;
            this.picBanner.Location = new System.Drawing.Point(90, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(749, 97);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // TKthuoc
            // 
            this.TKthuoc.Controls.Add(this.Numthuoc);
            this.TKthuoc.Controls.Add(this.label1);
            this.TKthuoc.Controls.Add(this.pictureBox1);
            this.TKthuoc.Location = new System.Drawing.Point(21, 133);
            this.TKthuoc.Name = "TKthuoc";
            this.TKthuoc.Size = new System.Drawing.Size(200, 75);
            this.TKthuoc.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.TKthuoc.TabIndex = 9;
            // 
            // Numthuoc
            // 
            this.Numthuoc.AutoSize = true;
            this.Numthuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.Numthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numthuoc.ForeColor = System.Drawing.Color.White;
            this.Numthuoc.Location = new System.Drawing.Point(66, 37);
            this.Numthuoc.Name = "Numthuoc";
            this.Numthuoc.Size = new System.Drawing.Size(44, 20);
            this.Numthuoc.TabIndex = 12;
            this.Numthuoc.Text = "num";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thuốc";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::pharmacy_management.Properties.Resources.Pill_Contrast;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TKkhach
            // 
            this.TKkhach.Controls.Add(this.Numkhach);
            this.TKkhach.Controls.Add(this.label2);
            this.TKkhach.Controls.Add(this.pictureBox2);
            this.TKkhach.Location = new System.Drawing.Point(246, 133);
            this.TKkhach.Name = "TKkhach";
            this.TKkhach.Size = new System.Drawing.Size(200, 75);
            this.TKkhach.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.TKkhach.TabIndex = 10;
            // 
            // Numkhach
            // 
            this.Numkhach.AutoSize = true;
            this.Numkhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.Numkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numkhach.ForeColor = System.Drawing.Color.White;
            this.Numkhach.Location = new System.Drawing.Point(65, 37);
            this.Numkhach.Name = "Numkhach";
            this.Numkhach.Size = new System.Drawing.Size(44, 20);
            this.Numkhach.TabIndex = 13;
            this.Numkhach.Text = "num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách hàng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::pharmacy_management.Properties.Resources.Crowd_Contrast;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // TKslban
            // 
            this.TKslban.Controls.Add(this.Numslban);
            this.TKslban.Controls.Add(this.label3);
            this.TKslban.Controls.Add(this.pictureBox3);
            this.TKslban.Location = new System.Drawing.Point(471, 133);
            this.TKslban.Name = "TKslban";
            this.TKslban.Size = new System.Drawing.Size(200, 75);
            this.TKslban.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.TKslban.TabIndex = 10;
            // 
            // Numslban
            // 
            this.Numslban.AutoSize = true;
            this.Numslban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.Numslban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numslban.ForeColor = System.Drawing.Color.White;
            this.Numslban.Location = new System.Drawing.Point(65, 37);
            this.Numslban.Name = "Numslban";
            this.Numslban.Size = new System.Drawing.Size(44, 20);
            this.Numslban.TabIndex = 14;
            this.Numslban.Text = "num";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đã bán";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::pharmacy_management.Properties.Resources.Sell_Stock;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // TKdoanhthu
            // 
            this.TKdoanhthu.Controls.Add(this.Numdoanhthu);
            this.TKdoanhthu.Controls.Add(this.label4);
            this.TKdoanhthu.Controls.Add(this.pictureBox4);
            this.TKdoanhthu.Location = new System.Drawing.Point(699, 133);
            this.TKdoanhthu.Name = "TKdoanhthu";
            this.TKdoanhthu.Size = new System.Drawing.Size(200, 75);
            this.TKdoanhthu.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.TKdoanhthu.TabIndex = 10;
            // 
            // Numdoanhthu
            // 
            this.Numdoanhthu.AutoSize = true;
            this.Numdoanhthu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.Numdoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numdoanhthu.ForeColor = System.Drawing.Color.White;
            this.Numdoanhthu.Location = new System.Drawing.Point(60, 37);
            this.Numdoanhthu.Name = "Numdoanhthu";
            this.Numdoanhthu.Size = new System.Drawing.Size(44, 20);
            this.Numdoanhthu.TabIndex = 15;
            this.Numdoanhthu.Text = "num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doanh thu";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = global::pharmacy_management.Properties.Resources.Get_Revenue;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 254);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            series1.ShadowColor = System.Drawing.Color.White;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(878, 295);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "Doanh thu theo tháng";
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.TKdoanhthu);
            this.Controls.Add(this.TKslban);
            this.Controls.Add(this.TKkhach);
            this.Controls.Add(this.TKthuoc);
            this.Controls.Add(this.Banners);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(932, 603);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Banners)).EndInit();
            this.Banners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKthuoc)).EndInit();
            this.TKthuoc.ResumeLayout(false);
            this.TKthuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKkhach)).EndInit();
            this.TKkhach.ResumeLayout(false);
            this.TKkhach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKslban)).EndInit();
            this.TKslban.ResumeLayout(false);
            this.TKslban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKdoanhthu)).EndInit();
            this.TKdoanhthu.ResumeLayout(false);
            this.TKdoanhthu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel Banners;
        private Krypton.Toolkit.KryptonButton btnRight;
        private Krypton.Toolkit.KryptonButton btnLeft;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonPanel TKthuoc;
        private Krypton.Toolkit.KryptonPanel TKkhach;
        private Krypton.Toolkit.KryptonPanel TKslban;
        private Krypton.Toolkit.KryptonPanel TKdoanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Numthuoc;
        private System.Windows.Forms.Label Numkhach;
        private System.Windows.Forms.Label Numslban;
        private System.Windows.Forms.Label Numdoanhthu;
    }
}
