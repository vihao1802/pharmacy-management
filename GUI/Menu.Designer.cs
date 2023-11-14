<<<<<<< HEAD
﻿namespace pharmacy_management.GUI
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
            this.btnSell = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPill = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnStorage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCustomer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnStaff = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVoucher = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.TopBar = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.nhapHang1 = new pharmacy_management.GUI.NhapHang.NhapHang();
            this.dashboard1 = new pharmacy_management.GUI.Dashboard();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Sidebar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnSell);
            this.flowLayoutPanel1.Controls.Add(this.btnPill);
            this.flowLayoutPanel1.Controls.Add(this.btnStorage);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomer);
            this.flowLayoutPanel1.Controls.Add(this.btnStaff);
            this.flowLayoutPanel1.Controls.Add(this.btnVoucher);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(247, 478);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(50, 478);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 478);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(3, 3);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(240, 56);
            this.btnSell.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSell.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSell.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Sell;
            this.btnSell.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSell.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSell.StateCommon.Border.Rounding = 10;
            this.btnSell.TabIndex = 7;
            this.btnSell.Values.Text = "Bán hàng";
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click_1);
            this.btnSell.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btnSell.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnPill
            // 
            this.btnPill.Location = new System.Drawing.Point(3, 65);
            this.btnPill.Name = "btnPill";
            this.btnPill.Size = new System.Drawing.Size(240, 56);
            this.btnPill.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnPill.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnPill.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Pill;
            this.btnPill.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnPill.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnPill.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPill.StateCommon.Border.Rounding = 10;
            this.btnPill.TabIndex = 8;
            this.btnPill.Values.Text = "Thuốc";
            this.btnPill.MouseLeave += new System.EventHandler(this.btnPill_MouseLeave);
            this.btnPill.MouseHover += new System.EventHandler(this.btnPill_MouseHover);
            // 
            // btnStorage
            // 
            this.btnStorage.Location = new System.Drawing.Point(3, 127);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(240, 56);
            this.btnStorage.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnStorage.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnStorage.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Storage;
            this.btnStorage.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnStorage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnStorage.StateCommon.Border.Rounding = 10;
            this.btnStorage.TabIndex = 12;
            this.btnStorage.Values.Text = "Kho";
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            this.btnStorage.MouseLeave += new System.EventHandler(this.btnStorage_MouseLeave);
            this.btnStorage.MouseHover += new System.EventHandler(this.btnStorage_MouseHover);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(3, 189);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(240, 56);
            this.btnCustomer.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCustomer.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCustomer.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Crowd;
            this.btnCustomer.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnCustomer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCustomer.StateCommon.Border.Rounding = 10;
            this.btnCustomer.TabIndex = 11;
            this.btnCustomer.Values.Text = "Khách hàng";
            this.btnCustomer.MouseLeave += new System.EventHandler(this.btnCustomer_MouseLeave);
            this.btnCustomer.MouseHover += new System.EventHandler(this.btnCustomer_MouseHover);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(3, 251);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(240, 56);
            this.btnStaff.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnStaff.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnStaff.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Staff;
            this.btnStaff.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnStaff.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnStaff.StateCommon.Border.Rounding = 10;
            this.btnStaff.TabIndex = 10;
            this.btnStaff.Values.Text = "Nhân viên";
            this.btnStaff.MouseLeave += new System.EventHandler(this.btnStaff_MouseLeave);
            this.btnStaff.MouseHover += new System.EventHandler(this.btnStaff_MouseHover);
            // 
            // btnVoucher
            // 
            this.btnVoucher.Location = new System.Drawing.Point(3, 313);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(240, 56);
            this.btnVoucher.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Back.Image = global::pharmacy_management.Properties.Resources.Voucher;
            this.btnVoucher.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnVoucher.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoucher.StateCommon.Border.Rounding = 10;
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
            this.kryptonPalette2.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.kryptonPalette2.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImagePressed")));
            this.kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImageTracking")));
            this.kryptonPalette2.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImagePressed")));
            this.kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
            this.kryptonPalette2.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormRestore.Image")));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette2.PalettePaint += new System.EventHandler<ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette2_PalettePaint);
            // 
            // TopBar
            // 
            this.TopBar.Controls.Add(this.pictureBox6);
            this.TopBar.Controls.Add(this.pictureBox5);
            this.TopBar.Controls.Add(this.pictureBox4);
            this.TopBar.Controls.Add(this.btnLogout);
            this.TopBar.Controls.Add(this.lbName);
            this.TopBar.Controls.Add(this.kryptonLabel1);
            this.TopBar.Controls.Add(this.pictureBox2);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(250, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(932, 50);
            this.TopBar.StateCommon.Color1 = System.Drawing.Color.White;
            this.TopBar.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::pharmacy_management.Properties.Resources.Email;
            this.pictureBox6.Location = new System.Drawing.Point(664, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::pharmacy_management.Properties.Resources.Instagram;
            this.pictureBox5.Location = new System.Drawing.Point(597, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(61, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::pharmacy_management.Properties.Resources.Facebook;
            this.pictureBox4.Location = new System.Drawing.Point(530, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::pharmacy_management.Properties.Resources.Open_Pane;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(61, 50);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLogout.TabIndex = 3;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(731, 20);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(120, 24);
            this.lbName.TabIndex = 2;
            this.lbName.Values.Text = "Huỳnh Lâm Đức";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(731, 0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(70, 24);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Xin chào";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pharmacy_management.Properties.Resources.Person_In_Tuxedo;
            this.pictureBox2.Location = new System.Drawing.Point(857, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PnContainer
            // 
            this.PnContainer.Controls.Add(this.nhapHang1);
            this.PnContainer.Controls.Add(this.dashboard1);
            this.PnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContainer.Location = new System.Drawing.Point(250, 50);
            this.PnContainer.Name = "PnContainer";
            this.PnContainer.Size = new System.Drawing.Size(932, 603);
            this.PnContainer.StateCommon.Color1 = System.Drawing.Color.White;
            this.PnContainer.TabIndex = 4;
            // 
            // nhapHang1
            // 
            this.nhapHang1.BackColor = System.Drawing.Color.White;
            this.nhapHang1.Location = new System.Drawing.Point(0, 0);
            this.nhapHang1.Name = "nhapHang1";
            this.nhapHang1.Size = new System.Drawing.Size(932, 603);
            this.nhapHang1.TabIndex = 1;
            this.nhapHang1.Visible = false;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.White;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.MaximumSize = new System.Drawing.Size(1132, 603);
            this.dashboard1.MinimumSize = new System.Drawing.Size(932, 603);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(932, 603);
            this.dashboard1.TabIndex = 0;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PnContainer);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Palette = this.kryptonPalette2;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Sidebar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnContainer)).EndInit();
            this.PnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel TopBar;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PnContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSell;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPill;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStorage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStaff;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVoucher;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer timer1;
        private Dashboard dashboard1;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private NhapHang.NhapHang nhapHang1;
    }
}

=======
﻿namespace thuoc.GUI
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
            this.btnSell = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPill = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnStorage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCustomer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnStaff = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVoucher = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAnalyze = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.TopBar = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dashboard1 = new thuoc.GUI.Dashboard();
            this.Sidebar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnSell);
            this.flowLayoutPanel1.Controls.Add(this.btnPill);
            this.flowLayoutPanel1.Controls.Add(this.btnStorage);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomer);
            this.flowLayoutPanel1.Controls.Add(this.btnStaff);
            this.flowLayoutPanel1.Controls.Add(this.btnVoucher);
            this.flowLayoutPanel1.Controls.Add(this.btnAnalyze);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(247, 478);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(50, 478);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 478);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(3, 3);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(240, 56);
            this.btnSell.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSell.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSell.StateCommon.Back.Image = global::thuoc.Properties.Resources.Sell;
            this.btnSell.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSell.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSell.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSell.StateCommon.Border.Rounding = 10;
            this.btnSell.TabIndex = 7;
            this.btnSell.Values.Text = "Bán hàng";
            // 
            // btnPill
            // 
            this.btnPill.Location = new System.Drawing.Point(3, 65);
            this.btnPill.Name = "btnPill";
            this.btnPill.Size = new System.Drawing.Size(240, 56);
            this.btnPill.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnPill.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnPill.StateCommon.Back.Image = global::thuoc.Properties.Resources.Pill;
            this.btnPill.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnPill.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnPill.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPill.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnPill.StateCommon.Border.Rounding = 10;
            this.btnPill.TabIndex = 8;
            this.btnPill.Values.Text = "Thuốc";
            // 
            // btnStorage
            // 
            this.btnStorage.Location = new System.Drawing.Point(3, 127);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(240, 56);
            this.btnStorage.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnStorage.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnStorage.StateCommon.Back.Image = global::thuoc.Properties.Resources.Storage;
            this.btnStorage.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnStorage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnStorage.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnStorage.StateCommon.Border.Rounding = 10;
            this.btnStorage.TabIndex = 12;
            this.btnStorage.Values.Text = "Kho";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(3, 189);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(240, 56);
            this.btnCustomer.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCustomer.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCustomer.StateCommon.Back.Image = global::thuoc.Properties.Resources.Crowd;
            this.btnCustomer.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnCustomer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCustomer.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCustomer.StateCommon.Border.Rounding = 10;
            this.btnCustomer.TabIndex = 11;
            this.btnCustomer.Values.Text = "Khách hàng";
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(3, 251);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(240, 56);
            this.btnStaff.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnStaff.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnStaff.StateCommon.Back.Image = global::thuoc.Properties.Resources.Staff;
            this.btnStaff.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnStaff.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnStaff.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnStaff.StateCommon.Border.Rounding = 10;
            this.btnStaff.TabIndex = 10;
            this.btnStaff.Values.Text = "Nhân viên";
            // 
            // btnVoucher
            // 
            this.btnVoucher.Location = new System.Drawing.Point(3, 313);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(240, 56);
            this.btnVoucher.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Back.Image = global::thuoc.Properties.Resources.Voucher;
            this.btnVoucher.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnVoucher.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoucher.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnVoucher.StateCommon.Border.Rounding = 10;
            this.btnVoucher.TabIndex = 9;
            this.btnVoucher.Values.Text = "Khuyến mãi";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(3, 375);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(240, 56);
            this.btnAnalyze.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnAnalyze.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnAnalyze.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAnalyze.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAnalyze.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAnalyze.StateCommon.Border.Rounding = 10;
            this.btnAnalyze.StateNormal.Back.Image = global::thuoc.Properties.Resources.Analyze;
            this.btnAnalyze.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnAnalyze.TabIndex = 13;
            this.btnAnalyze.Values.Text = "Thống kê";
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::thuoc.Properties.Resources.Menu;
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
            this.kryptonPalette2.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPalette2.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.kryptonPalette2.ButtonSpecs.FormClose.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette2.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette2.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImagePressed")));
            this.kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImageTracking")));
            this.kryptonPalette2.ButtonSpecs.FormMax.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette2.ButtonSpecs.FormMax.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette2.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImagePressed")));
            this.kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
            this.kryptonPalette2.ButtonSpecs.FormMin.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette2.ButtonSpecs.FormMin.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette2.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette2.ButtonSpecs.FormRestore.Image")));
            this.kryptonPalette2.ButtonSpecs.FormRestore.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette2.ButtonSpecs.FormRestore.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette2.PalettePaint += new System.EventHandler<ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette2_PalettePaint);
            // 
            // TopBar
            // 
            this.TopBar.Controls.Add(this.lbName);
            this.TopBar.Controls.Add(this.kryptonLabel1);
            this.TopBar.Controls.Add(this.pictureBox2);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(250, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(932, 50);
            this.TopBar.StateCommon.Color1 = System.Drawing.Color.White;
            this.TopBar.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.TopBar.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(731, 20);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(120, 24);
            this.lbName.TabIndex = 2;
            this.lbName.Values.Text = "Huỳnh Lâm Đức";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(781, 0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(70, 24);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Xin chào";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::thuoc.Properties.Resources.Person_In_Tuxedo;
            this.pictureBox2.Location = new System.Drawing.Point(857, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PnContainer
            // 
            this.PnContainer.Controls.Add(this.dashboard1);
            this.PnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContainer.Location = new System.Drawing.Point(250, 50);
            this.PnContainer.Name = "PnContainer";
            this.PnContainer.Size = new System.Drawing.Size(932, 603);
            this.PnContainer.StateCommon.Color1 = System.Drawing.Color.White;
            this.PnContainer.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.PnContainer.TabIndex = 4;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_tick);
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(932, 603);
            this.dashboard1.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PnContainer);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Palette = this.kryptonPalette2;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Sidebar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnContainer)).EndInit();
            this.PnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel TopBar;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PnContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSell;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPill;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStorage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStaff;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVoucher;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAnalyze;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer timer1;
        private Dashboard dashboard1;
    }
}

>>>>>>> 807995ace6f7578ec629a8f9edb0f248d0f0a5e3
