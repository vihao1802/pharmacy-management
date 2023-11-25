namespace pharmacy_management.GUI.BanHang
{
    partial class GioHangFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_pay = new System.Windows.Forms.Button();
            this.lbl_final_total_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total_price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropBtn_KH = new Krypton.Toolkit.KryptonComboBox();
            this.dropBtn_PG = new Krypton.Toolkit.KryptonComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_bonus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_DiemHienCo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropBtn_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropBtn_PG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lbl_bonus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_discount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_pay);
            this.panel2.Controls.Add(this.lbl_final_total_price);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_total_price);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 80);
            this.panel2.TabIndex = 1;
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_discount.Location = new System.Drawing.Point(426, 16);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(41, 25);
            this.lbl_discount.TabIndex = 6;
            this.lbl_discount.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(352, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giảm :";
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_pay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.Location = new System.Drawing.Point(499, 0);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(103, 80);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // lbl_final_total_price
            // 
            this.lbl_final_total_price.AutoSize = true;
            this.lbl_final_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_final_total_price.Location = new System.Drawing.Point(139, 47);
            this.lbl_final_total_price.Name = "lbl_final_total_price";
            this.lbl_final_total_price.Size = new System.Drawing.Size(39, 25);
            this.lbl_final_total_price.TabIndex = 3;
            this.lbl_final_total_price.Text = "0 đ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành tiền :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền :";
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.AutoSize = true;
            this.lbl_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_total_price.Location = new System.Drawing.Point(139, 13);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(39, 25);
            this.lbl_total_price.TabIndex = 0;
            this.lbl_total_price.Text = "0 đ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_DiemHienCo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dropBtn_KH);
            this.panel1.Controls.Add(this.dropBtn_PG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 83);
            this.panel1.TabIndex = 0;
            // 
            // dropBtn_KH
            // 
            this.dropBtn_KH.CornerRoundingRadius = 5F;
            this.dropBtn_KH.DropDownWidth = 121;
            this.dropBtn_KH.IntegralHeight = false;
            this.dropBtn_KH.Location = new System.Drawing.Point(19, 12);
            this.dropBtn_KH.Name = "dropBtn_KH";
            this.dropBtn_KH.Size = new System.Drawing.Size(222, 29);
            this.dropBtn_KH.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dropBtn_KH.StateCommon.ComboBox.Border.Rounding = 5F;
            this.dropBtn_KH.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropBtn_KH.TabIndex = 10;
            this.dropBtn_KH.Text = "Chọn khách hàng";
            this.dropBtn_KH.SelectedIndexChanged += new System.EventHandler(this.dropBtn_KH_SelectedIndexChanged);
            // 
            // dropBtn_PG
            // 
            this.dropBtn_PG.CornerRoundingRadius = 5F;
            this.dropBtn_PG.DropDownWidth = 121;
            this.dropBtn_PG.IntegralHeight = false;
            this.dropBtn_PG.Location = new System.Drawing.Point(339, 12);
            this.dropBtn_PG.Name = "dropBtn_PG";
            this.dropBtn_PG.Size = new System.Drawing.Size(215, 29);
            this.dropBtn_PG.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dropBtn_PG.StateCommon.ComboBox.Border.Rounding = 5F;
            this.dropBtn_PG.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dropBtn_PG.TabIndex = 9;
            this.dropBtn_PG.Text = "Chọn phiếu quy đổi";
            this.dropBtn_PG.DropDown += new System.EventHandler(this.dropBtn_PG_DropDown);
            this.dropBtn_PG.SelectedIndexChanged += new System.EventHandler(this.dropBtn_PG_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 390);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(352, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Điểm :";
            // 
            // lbl_bonus
            // 
            this.lbl_bonus.AutoSize = true;
            this.lbl_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_bonus.Location = new System.Drawing.Point(426, 45);
            this.lbl_bonus.Name = "lbl_bonus";
            this.lbl_bonus.Size = new System.Drawing.Size(35, 25);
            this.lbl_bonus.TabIndex = 8;
            this.lbl_bonus.Text = "+0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(15, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Điểm hiện có:";
            // 
            // lbl_DiemHienCo
            // 
            this.lbl_DiemHienCo.AutoSize = true;
            this.lbl_DiemHienCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiemHienCo.Location = new System.Drawing.Point(165, 56);
            this.lbl_DiemHienCo.Name = "lbl_DiemHienCo";
            this.lbl_DiemHienCo.Size = new System.Drawing.Size(23, 25);
            this.lbl_DiemHienCo.TabIndex = 9;
            this.lbl_DiemHienCo.Text = "0";
            // 
            // GioHangFrm
            // 
            this.AcceptButton = this.btn_pay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 553);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GioHangFrm";
            this.Text = "Giỏ hàng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropBtn_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropBtn_PG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total_price;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Label lbl_final_total_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonComboBox dropBtn_KH;
        private Krypton.Toolkit.KryptonComboBox dropBtn_PG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_bonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_DiemHienCo;
    }
}