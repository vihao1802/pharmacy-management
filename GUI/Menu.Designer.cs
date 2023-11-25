namespace pharmacy_management.GUI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Sidebar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSell = new Krypton.Toolkit.KryptonButton();
            this.btnPill = new Krypton.Toolkit.KryptonButton();
            this.btnStorage = new Krypton.Toolkit.KryptonButton();
            this.btnCustomer = new Krypton.Toolkit.KryptonButton();
            this.btnStaff = new Krypton.Toolkit.KryptonButton();
            this.btnVoucher = new Krypton.Toolkit.KryptonButton();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPalette2 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.PnContainer = new Krypton.Toolkit.KryptonPanel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.Sidebar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnContainer)).BeginInit();
            this.PnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.Controls.Add(this.flowLayoutPanel1);
            this.Sidebar.Controls.Add(this.btnMenu);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.MaximumSize = new System.Drawing.Size(250, 655);
            this.Sidebar.MinimumSize = new System.Drawing.Size(50, 653);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(250, 653);
            this.Sidebar.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.btnSell);
            this.flowLayoutPanel1.Controls.Add(this.btnPill);
            this.flowLayoutPanel1.Controls.Add(this.btnStorage);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomer);
            this.flowLayoutPanel1.Controls.Add(this.btnStaff);
            this.flowLayoutPanel1.Controls.Add(this.btnVoucher);
            this.flowLayoutPanel1.Controls.Add(this.kryptonButton1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(247, 478);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(50, 478);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 478);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnSell
            // 
            this.btnSell.CornerRoundingRadius = 10F;
            this.btnSell.Location = new System.Drawing.Point(3, 3);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(240, 56);
            this.btnSell.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSell.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSell.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Sell;
            this.btnSell.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSell.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSell.StateCommon.Border.Rounding = 10F;
            this.btnSell.TabIndex = 7;
            this.btnSell.Values.Text = "Bán hàng";
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click_1);
            this.btnSell.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btnSell.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnPill
            // 
            this.btnPill.CornerRoundingRadius = 10F;
            this.btnPill.Location = new System.Drawing.Point(3, 65);
            this.btnPill.Name = "btnPill";
            this.btnPill.Size = new System.Drawing.Size(240, 56);
            this.btnPill.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnPill.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnPill.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Pill;
            this.btnPill.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnPill.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnPill.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPill.StateCommon.Border.Rounding = 10F;
            this.btnPill.TabIndex = 8;
            this.btnPill.Values.Text = "Thuốc";
            this.btnPill.MouseLeave += new System.EventHandler(this.btnPill_MouseLeave);
            this.btnPill.MouseHover += new System.EventHandler(this.btnPill_MouseHover);
            // 
            // btnStorage
            // 
            this.btnStorage.CornerRoundingRadius = 10F;
            this.btnStorage.Location = new System.Drawing.Point(3, 127);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(240, 56);
            this.btnStorage.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnStorage.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnStorage.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Storage;
            this.btnStorage.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnStorage.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnStorage.StateCommon.Border.Rounding = 10F;
            this.btnStorage.TabIndex = 12;
            this.btnStorage.Values.Text = "Kho";
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            this.btnStorage.MouseLeave += new System.EventHandler(this.btnStorage_MouseLeave);
            this.btnStorage.MouseHover += new System.EventHandler(this.btnStorage_MouseHover);
            // 
            // btnCustomer
            // 
            this.btnCustomer.CornerRoundingRadius = 10F;
            this.btnCustomer.Location = new System.Drawing.Point(3, 189);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(240, 56);
            this.btnCustomer.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCustomer.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCustomer.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Crowd;
            this.btnCustomer.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnCustomer.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCustomer.StateCommon.Border.Rounding = 10F;
            this.btnCustomer.TabIndex = 11;
            this.btnCustomer.Values.Text = "Khách hàng";
            this.btnCustomer.MouseLeave += new System.EventHandler(this.btnCustomer_MouseLeave);
            this.btnCustomer.MouseHover += new System.EventHandler(this.btnCustomer_MouseHover);
            // 
            // btnStaff
            // 
            this.btnStaff.CornerRoundingRadius = 10F;
            this.btnStaff.Location = new System.Drawing.Point(3, 251);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(240, 56);
            this.btnStaff.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnStaff.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnStaff.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Staff;
            this.btnStaff.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnStaff.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnStaff.StateCommon.Border.Rounding = 10F;
            this.btnStaff.TabIndex = 10;
            this.btnStaff.Values.Text = "Nhân viên";
            this.btnStaff.MouseLeave += new System.EventHandler(this.btnStaff_MouseLeave);
            this.btnStaff.MouseHover += new System.EventHandler(this.btnStaff_MouseHover);
            // 
            // btnVoucher
            // 
            this.btnVoucher.CornerRoundingRadius = 10F;
            this.btnVoucher.Location = new System.Drawing.Point(3, 313);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(240, 56);
            this.btnVoucher.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Voucher;
            this.btnVoucher.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnVoucher.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoucher.StateCommon.Border.Rounding = 10F;
            this.btnVoucher.TabIndex = 9;
            this.btnVoucher.Values.Text = "Khuyến mãi";
            this.btnVoucher.MouseLeave += new System.EventHandler(this.btnVoucher_MouseLeave);
            this.btnVoucher.MouseHover += new System.EventHandler(this.btnVoucher_MouseHover);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::pharmacy_management.Properties.Resources.Menu;
            this.btnMenu.Location = new System.Drawing.Point(5, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(29, 32);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 7;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("resource.ImagePressed")));
            this.kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("resource.ImageTracking")));
            this.kryptonPalette2.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("resource.ImagePressed1")));
            this.kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("resource.ImageTracking1")));
            this.kryptonPalette2.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("resource.ImagePressed2")));
            this.kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("resource.ImageTracking2")));
            this.kryptonPalette2.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette2.PalettePaint += new System.EventHandler<Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette2_PalettePaint);
            // 
            // PnContainer
            // 
            this.PnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContainer.Location = new System.Drawing.Point(250, 0);
            this.PnContainer.Name = "PnContainer";
            this.PnContainer.Size = new System.Drawing.Size(932, 653);
            this.PnContainer.StateCommon.Color1 = System.Drawing.Color.White;
            this.PnContainer.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = 10F;
            this.kryptonButton1.Location = new System.Drawing.Point(3, 375);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(240, 56);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Voucher;
            this.kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 10F;
            this.kryptonButton1.TabIndex = 13;
            this.kryptonButton1.Values.Text = "Đơn hàng";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PnContainer);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Palette = this.kryptonPalette2;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Sidebar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnContainer)).EndInit();
            this.PnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private Krypton.Toolkit.KryptonPanel PnContainer;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonButton btnSell;
        private Krypton.Toolkit.KryptonButton btnPill;
        private Krypton.Toolkit.KryptonButton btnStorage;
        private Krypton.Toolkit.KryptonButton btnCustomer;
        private Krypton.Toolkit.KryptonButton btnStaff;
        private Krypton.Toolkit.KryptonButton btnVoucher;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}

