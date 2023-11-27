namespace pharmacy_management.GUI.BanHang
{
    partial class SanPhamGioHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_increase = new Krypton.Toolkit.KryptonButton();
            this.btn_decrease = new Krypton.Toolkit.KryptonButton();
            this.lbl_prod_price_cart = new System.Windows.Forms.Label();
            this.lbl_prod_quantity_cart = new System.Windows.Forms.Label();
            this.lbl_prod_name_cart = new System.Windows.Forms.Label();
            this.picb_image_cart = new System.Windows.Forms.PictureBox();
            this.btn_remove_item = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_image_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_remove_item)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.btn_increase);
            this.panel1.Controls.Add(this.btn_decrease);
            this.panel1.Controls.Add(this.lbl_prod_price_cart);
            this.panel1.Controls.Add(this.lbl_prod_quantity_cart);
            this.panel1.Controls.Add(this.lbl_prod_name_cart);
            this.panel1.Controls.Add(this.picb_image_cart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(500, 110);
            this.panel1.TabIndex = 0;
            // 
            // btn_increase
            // 
            this.btn_increase.CornerRoundingRadius = 5F;
            this.btn_increase.Location = new System.Drawing.Point(328, 28);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_increase.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_increase.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_increase.OverrideDefault.Border.Width = 5;
            this.btn_increase.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 2);
            this.btn_increase.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_increase.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_increase.Size = new System.Drawing.Size(38, 25);
            this.btn_increase.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_increase.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_increase.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_increase.StateCommon.Border.Rounding = 5F;
            this.btn_increase.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 2);
            this.btn_increase.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_increase.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_increase.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_increase.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_increase.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_increase.StateTracking.Border.Rounding = 5F;
            this.btn_increase.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 2);
            this.btn_increase.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_increase.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_increase.TabIndex = 6;
            this.btn_increase.Values.Text = "+";
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // btn_decrease
            // 
            this.btn_decrease.CornerRoundingRadius = 5F;
            this.btn_decrease.Location = new System.Drawing.Point(328, 59);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_decrease.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_decrease.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_decrease.OverrideDefault.Border.Width = 5;
            this.btn_decrease.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 5);
            this.btn_decrease.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_decrease.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_decrease.Size = new System.Drawing.Size(38, 25);
            this.btn_decrease.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_decrease.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(132)))), ((int)(((byte)(131)))));
            this.btn_decrease.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_decrease.StateCommon.Border.Rounding = 5F;
            this.btn_decrease.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 5);
            this.btn_decrease.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_decrease.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_decrease.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_decrease.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_decrease.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_decrease.StateTracking.Border.Rounding = 5F;
            this.btn_decrease.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 5);
            this.btn_decrease.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_decrease.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_decrease.TabIndex = 5;
            this.btn_decrease.Values.Text = "-";
            this.btn_decrease.Click += new System.EventHandler(this.btn_decrease_Click);
            // 
            // lbl_prod_price_cart
            // 
            this.lbl_prod_price_cart.AutoSize = true;
            this.lbl_prod_price_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_prod_price_cart.Location = new System.Drawing.Point(394, 44);
            this.lbl_prod_price_cart.Name = "lbl_prod_price_cart";
            this.lbl_prod_price_cart.Size = new System.Drawing.Size(90, 22);
            this.lbl_prod_price_cart.TabIndex = 3;
            this.lbl_prod_price_cart.Text = "223,300 đ";
            // 
            // lbl_prod_quantity_cart
            // 
            this.lbl_prod_quantity_cart.AutoSize = true;
            this.lbl_prod_quantity_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_prod_quantity_cart.Location = new System.Drawing.Point(284, 44);
            this.lbl_prod_quantity_cart.Name = "lbl_prod_quantity_cart";
            this.lbl_prod_quantity_cart.Size = new System.Drawing.Size(20, 22);
            this.lbl_prod_quantity_cart.TabIndex = 2;
            this.lbl_prod_quantity_cart.Text = "2";
            // 
            // lbl_prod_name_cart
            // 
            this.lbl_prod_name_cart.AutoSize = true;
            this.lbl_prod_name_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_prod_name_cart.ForeColor = System.Drawing.Color.Black;
            this.lbl_prod_name_cart.Location = new System.Drawing.Point(121, 5);
            this.lbl_prod_name_cart.MaximumSize = new System.Drawing.Size(150, 110);
            this.lbl_prod_name_cart.Name = "lbl_prod_name_cart";
            this.lbl_prod_name_cart.Size = new System.Drawing.Size(146, 72);
            this.lbl_prod_name_cart.TabIndex = 1;
            this.lbl_prod_name_cart.Text = "Viên uống S DiCanxi USV Pharma hỗ trợ bổ sung canxi (30 viên)";
            // 
            // picb_image_cart
            // 
            this.picb_image_cart.Dock = System.Windows.Forms.DockStyle.Left;
            this.picb_image_cart.Image = global::pharmacy_management.Properties.Resources._55;
            this.picb_image_cart.Location = new System.Drawing.Point(5, 5);
            this.picb_image_cart.Name = "picb_image_cart";
            this.picb_image_cart.Padding = new System.Windows.Forms.Padding(5);
            this.picb_image_cart.Size = new System.Drawing.Size(110, 100);
            this.picb_image_cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_image_cart.TabIndex = 0;
            this.picb_image_cart.TabStop = false;
            // 
            // btn_remove_item
            // 
            this.btn_remove_item.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_remove_item.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_remove_item.Image = global::pharmacy_management.Properties.Resources.icons8_close_24;
            this.btn_remove_item.Location = new System.Drawing.Point(500, 0);
            this.btn_remove_item.Name = "btn_remove_item";
            this.btn_remove_item.Size = new System.Drawing.Size(50, 110);
            this.btn_remove_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_remove_item.TabIndex = 1;
            this.btn_remove_item.TabStop = false;
            this.btn_remove_item.Click += new System.EventHandler(this.btn_remove_item_Click);
            this.btn_remove_item.MouseEnter += new System.EventHandler(this.btn_remove_item_MouseEnter);
            this.btn_remove_item.MouseLeave += new System.EventHandler(this.btn_remove_item_MouseLeave);
            // 
            // SanPhamGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_remove_item);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.Name = "SanPhamGioHang";
            this.Size = new System.Drawing.Size(550, 110);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_image_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_remove_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picb_image_cart;
        private System.Windows.Forms.PictureBox btn_remove_item;
        private System.Windows.Forms.Label lbl_prod_price_cart;
        private System.Windows.Forms.Label lbl_prod_quantity_cart;
        private System.Windows.Forms.Label lbl_prod_name_cart;
        private Krypton.Toolkit.KryptonButton btn_decrease;
        private Krypton.Toolkit.KryptonButton btn_increase;
    }
}
