
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using pharmacy_management.DTO;
using pharmacy_management.Properties;
using pharmacy_management;
using static System.Net.Mime.MediaTypeNames;
using thuoc;
using pharmacy_management.GUI.BanHang;
using pharmacy_management.GUI.NhapHang;
using pharmacy_management.GUI.Dash;
using pharmacy_management.GUI.Thuoc;
using pharmacy_management.GUI.KhachHang;
using pharmacy_management.GUI.NhanVien;
using pharmacy_management.GUI.QuyDoiDiem;
using pharmacy_management.BUS;
using System.Xml.Schema;


namespace pharmacy_management.GUI
{
    public partial class Menu : KryptonForm
    {
        public static DTO.NhanVien nv = new DTO.NhanVien();
        QuyenBUS qbus = new QuyenBUS();
        bool sidebarExpand;
        BanHangFrm bhFrm;
        DashFrm dashFrm = new DashFrm();

        public Menu()
        {
            InitializeComponent();


            addFormtoPanelContainer(dashFrm);
            nv = Login.nv;
            addControls();
            lbName.Text = nv.TenNV;
            lbquyen.Text = qbus.getTenfromMa(nv.MaQuyen);


        }
        private void addControls()
        {
            if (nv.MaQuyen == 2)
            {
                btnStaff.Visible = false;
                btnPill.Visible = false;
                btnPN.Visible = false;
                btnStorage.Visible = false;
                btnVoucher.Visible = false;
            }
            else if (nv.MaQuyen == 3)
            {
                btnCustomer.Visible = false;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPalette2_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }



        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        public void setDisabled(Boolean flag)
        {
            btnSell.Enabled = flag;
            btnPill.Enabled = flag;
            btnStaff.Enabled = flag;
            btnStorage.Enabled = flag;
            btnVoucher.Enabled = flag;
            btnCustomer.Enabled = flag;
            kryptonButton1.Enabled = flag;
            btnPN.Enabled = flag;
            btnCoupon.Enabled = flag;
        }
        private void addFormtoPanelContainer(object Form)
        {
            if (this.PnContainer.Controls.Count > 0)
            {
                this.PnContainer.Controls.Clear();
                if (bhFrm != null)
                    if (bhFrm.GetGioHangFrm != null)
                        closeFrm(bhFrm.GetGioHangFrm);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PnContainer.Controls.Add(f);
            this.PnContainer.Tag = f;
            f.Show();
            setDisabled(true);
        }

        public void closeFrm(object Form)
        {
            Form f = Form as Form;
            f.Close();
        }
        private void btnSell_Click_1(object sender, EventArgs e)
        {
            bhFrm = new BanHangFrm();
            addFormtoPanelContainer(bhFrm);
            btnSell.Enabled = false;
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new NhapHang.NhapHangFrm());
            btnStorage.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new DonHangFrm());
            kryptonButton1.Enabled = false;

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnPN_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new PhieuNhapFrm());
            btnPN.Enabled = false;

        }

        private void btnPill_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new FormThuoc());
            btnPill.Enabled = false;

        }

        private void kryptonLabel2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new QuyDoiDiemFrm());
            btnVoucher.Enabled = false;

        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.Show();
        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new PhieuGiamGiaFrm());
            btnCoupon.Enabled = false;
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new KhachHangfrm());

        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new frmNhanVien());
        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(dashFrm);
        }
    }

}

