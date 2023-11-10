namespace pharmacy_management.GUI.BanHang
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.pnl_item_container = new System.Windows.Forms.Panel();
            this.btn_item_detail = new Krypton.Toolkit.KryptonButton();
            this.btn_add_cart = new Krypton.Toolkit.KryptonButton();
            this.lbl_item_price = new Krypton.Toolkit.KryptonLabel();
            this.lbl_item_name = new Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.picb_item = new System.Windows.Forms.PictureBox();
            this.pnl_item_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_item)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_item_container
            // 
            this.pnl_item_container.BackColor = System.Drawing.Color.White;
            this.pnl_item_container.Controls.Add(this.btn_item_detail);
            this.pnl_item_container.Controls.Add(this.btn_add_cart);
            this.pnl_item_container.Controls.Add(this.lbl_item_price);
            this.pnl_item_container.Controls.Add(this.lbl_item_name);
            this.pnl_item_container.Controls.Add(this.label1);
            this.pnl_item_container.Controls.Add(this.picb_item);
            this.pnl_item_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_item_container.Location = new System.Drawing.Point(0, 7);
            this.pnl_item_container.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_item_container.Name = "pnl_item_container";
            this.pnl_item_container.Padding = new System.Windows.Forms.Padding(12, 5, 12, 12);
            this.pnl_item_container.Size = new System.Drawing.Size(225, 323);
            this.pnl_item_container.TabIndex = 0;
            this.pnl_item_container.MouseEnter += new System.EventHandler(this.pnl_item_container_MouseEnter);
            this.pnl_item_container.MouseLeave += new System.EventHandler(this.pnl_item_container_MouseLeave);
            // 
            // btn_item_detail
            // 
            this.btn_item_detail.CornerRoundingRadius = 3F;
            this.btn_item_detail.Location = new System.Drawing.Point(173, 278);
            this.btn_item_detail.Name = "btn_item_detail";
            this.btn_item_detail.OverrideDefault.Back.Color1 = System.Drawing.Color.Gray;
            this.btn_item_detail.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.btn_item_detail.OverrideFocus.Back.Color1 = System.Drawing.Color.Gray;
            this.btn_item_detail.OverrideFocus.Back.Color2 = System.Drawing.Color.Gray;
            this.btn_item_detail.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_item_detail.OverrideFocus.Border.Rounding = 3F;
            this.btn_item_detail.Size = new System.Drawing.Size(40, 40);
            this.btn_item_detail.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.btn_item_detail.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.btn_item_detail.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_item_detail.StateCommon.Back.Image")));
            this.btn_item_detail.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_item_detail.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btn_item_detail.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.btn_item_detail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_item_detail.StateCommon.Border.Rounding = 3F;
            this.btn_item_detail.StateTracking.Back.Color1 = System.Drawing.Color.DarkGray;
            this.btn_item_detail.StateTracking.Back.Color2 = System.Drawing.Color.DarkGray;
            this.btn_item_detail.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.btn_item_detail.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_item_detail.StateTracking.Border.Rounding = 3F;
            this.btn_item_detail.TabIndex = 9;
            this.btn_item_detail.Values.Text = "";
            this.btn_item_detail.Click += new System.EventHandler(this.btn_item_detail_Click);
            this.btn_item_detail.MouseEnter += new System.EventHandler(this.pnl_item_container_MouseEnter);
            this.btn_item_detail.MouseLeave += new System.EventHandler(this.pnl_item_container_MouseLeave);
            // 
            // btn_add_cart
            // 
            this.btn_add_cart.CornerRoundingRadius = 3F;
            this.btn_add_cart.Location = new System.Drawing.Point(12, 278);
            this.btn_add_cart.Name = "btn_add_cart";
            this.btn_add_cart.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_add_cart.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_add_cart.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_add_cart.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_add_cart.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_add_cart.OverrideFocus.Border.Rounding = 3F;
            this.btn_add_cart.Size = new System.Drawing.Size(150, 40);
            this.btn_add_cart.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_add_cart.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_add_cart.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_cart.StateCommon.Back.Image")));
            this.btn_add_cart.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_add_cart.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_add_cart.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.btn_add_cart.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_add_cart.StateCommon.Border.Rounding = 3F;
            this.btn_add_cart.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_add_cart.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(191)))));
            this.btn_add_cart.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(191)))));
            this.btn_add_cart.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_add_cart.StateTracking.Border.Rounding = 3F;
            this.btn_add_cart.TabIndex = 7;
            this.btn_add_cart.Values.Text = "";
            this.btn_add_cart.MouseEnter += new System.EventHandler(this.pnl_item_container_MouseEnter);
            this.btn_add_cart.MouseLeave += new System.EventHandler(this.pnl_item_container_MouseLeave);
            // 
            // lbl_item_price
            // 
            this.lbl_item_price.AutoSize = false;
            this.lbl_item_price.Location = new System.Drawing.Point(12, 240);
            this.lbl_item_price.Name = "lbl_item_price";
            this.lbl_item_price.Size = new System.Drawing.Size(201, 32);
            this.lbl_item_price.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(191)))));
            this.lbl_item_price.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_item_price.TabIndex = 3;
            this.lbl_item_price.Values.Text = "366.000 đ";
            this.lbl_item_price.MouseEnter += new System.EventHandler(this.pnl_item_container_MouseEnter);
            this.lbl_item_price.MouseLeave += new System.EventHandler(this.pnl_item_container_MouseLeave);
            // 
            // lbl_item_name
            // 
            this.lbl_item_name.Location = new System.Drawing.Point(12, 213);
            this.lbl_item_name.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_item_name.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_item_name.Name = "lbl_item_name";
            this.lbl_item_name.Size = new System.Drawing.Size(200, 24);
            this.lbl_item_name.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lbl_item_name.TabIndex = 2;
            this.lbl_item_name.Values.Text = "Viên uống Thanh Phế Kim Thiên Bình giúp bổ phế, hỗ trợ giảm ho, tiêu đờm (30 viên" +
    ")";
            this.lbl_item_name.MouseEnter += new System.EventHandler(this.pnl_item_container_MouseEnter);
            this.lbl_item_name.MouseLeave += new System.EventHandler(this.pnl_item_container_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // picb_item
            // 
            this.picb_item.Dock = System.Windows.Forms.DockStyle.Top;
            this.picb_item.ErrorImage = null;
            this.picb_item.Image = ((System.Drawing.Image)(resources.GetObject("picb_item.Image")));
            this.picb_item.Location = new System.Drawing.Point(12, 5);
            this.picb_item.Name = "picb_item";
            this.picb_item.Size = new System.Drawing.Size(201, 205);
            this.picb_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_item.TabIndex = 0;
            this.picb_item.TabStop = false;
            this.picb_item.MouseEnter += new System.EventHandler(this.pnl_item_container_MouseEnter);
            this.picb_item.MouseLeave += new System.EventHandler(this.pnl_item_container_MouseLeave);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_item_container);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Name = "SanPham";
            this.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.Size = new System.Drawing.Size(225, 330);
            this.pnl_item_container.ResumeLayout(false);
            this.pnl_item_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_item_container;
        private System.Windows.Forms.PictureBox picb_item;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonLabel lbl_item_name;
        private Krypton.Toolkit.KryptonLabel lbl_item_price;
        private Krypton.Toolkit.KryptonButton btn_add_cart;
        private Krypton.Toolkit.KryptonButton btn_item_detail;
    }
}
