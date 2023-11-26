namespace pharmacy_management.GUI.NhanVien
{
    partial class FrmQuyen
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
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.btnXoa = new Krypton.Toolkit.KryptonButton();
            this.quyenDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.MaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.txtTenQuyen = new Krypton.Toolkit.KryptonTextBox();
            this.txtMaQuyen = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quyenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnThem);
            this.kryptonPanel1.Controls.Add(this.btnSua);
            this.kryptonPanel1.Controls.Add(this.btnXoa);
            this.kryptonPanel1.Controls.Add(this.quyenDataGridView);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(740, 354);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Navy;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Teal;
            this.kryptonPanel1.StateCommon.ColorAngle = 60F;
            this.kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.CornerRoundingRadius = 20F;
            this.btnThem.Location = new System.Drawing.Point(78, 267);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 62);
            this.btnThem.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateCommon.Border.Rounding = 20F;
            this.btnThem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.TabIndex = 4;
            this.btnThem.Values.Image = global::pharmacy_management.Properties.Resources.icons8_add_30;
            this.btnThem.Values.Text = "";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.CornerRoundingRadius = 20F;
            this.btnSua.Location = new System.Drawing.Point(524, 267);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 62);
            this.btnSua.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateCommon.Border.Rounding = 20F;
            this.btnSua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.TabIndex = 3;
            this.btnSua.Values.Image = global::pharmacy_management.Properties.Resources.icons8_fix_30;
            this.btnSua.Values.Text = "";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.CornerRoundingRadius = 20F;
            this.btnXoa.Location = new System.Drawing.Point(290, 267);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 62);
            this.btnXoa.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateCommon.Border.Rounding = 20F;
            this.btnXoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Values.Image = global::pharmacy_management.Properties.Resources.icons8_remove_30;
            this.btnXoa.Values.Text = "";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // quyenDataGridView
            // 
            this.quyenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.quyenDataGridView.ColumnHeadersHeight = 36;
            this.quyenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuyen,
            this.TenQuyen});
            this.quyenDataGridView.Location = new System.Drawing.Point(254, 15);
            this.quyenDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.quyenDataGridView.Name = "quyenDataGridView";
            this.quyenDataGridView.RowHeadersVisible = false;
            this.quyenDataGridView.RowHeadersWidth = 51;
            this.quyenDataGridView.Size = new System.Drawing.Size(480, 230);
            this.quyenDataGridView.TabIndex = 1;
            this.quyenDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.quyenDataGridView_CellContentClick);
            this.quyenDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.quyenDataGridView_CellDoubleClick);
            // 
            // MaQuyen
            // 
            this.MaQuyen.HeaderText = "MaQuyen";
            this.MaQuyen.MinimumWidth = 6;
            this.MaQuyen.Name = "MaQuyen";
            this.MaQuyen.ReadOnly = true;
            // 
            // TenQuyen
            // 
            this.TenQuyen.HeaderText = "Tên quyền";
            this.TenQuyen.MinimumWidth = 6;
            this.TenQuyen.Name = "TenQuyen";
            this.TenQuyen.ReadOnly = true;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionOverlap = 0D;
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.InputControlRibbon;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 15);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtTenQuyen);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtMaQuyen);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(246, 230);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Thông tin ";
            // 
            // txtTenQuyen
            // 
            this.txtTenQuyen.Location = new System.Drawing.Point(12, 148);
            this.txtTenQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenQuyen.Name = "txtTenQuyen";
            this.txtTenQuyen.Size = new System.Drawing.Size(185, 33);
            this.txtTenQuyen.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenQuyen.StateCommon.Border.Rounding = 10F;
            this.txtTenQuyen.TabIndex = 3;
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Enabled = false;
            this.txtMaQuyen.Location = new System.Drawing.Point(12, 58);
            this.txtMaQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(185, 33);
            this.txtMaQuyen.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaQuyen.StateCommon.Border.Rounding = 10F;
            this.txtMaQuyen.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 121);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(76, 19);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Tên quyền";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 31);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(71, 19);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Mã quyền";
            // 
            // FrmQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 354);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuyen";
            this.Text = "FrmQuyen";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quyenDataGridView)).EndInit();
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
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtTenQuyen;
        private Krypton.Toolkit.KryptonTextBox txtMaQuyen;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnXoa;
        private Krypton.Toolkit.KryptonDataGridView quyenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuyen;
    }
}