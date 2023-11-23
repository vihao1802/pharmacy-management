
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

namespace pharmacy_management.GUI
{
    public partial class Menu : KryptonForm
    {
        public static NhanVien nv = new NhanVien();

        bool sidebarExpand;
        BanHangFrm bhFrm;

        public Menu()
        {
            InitializeComponent();

             DashFrm dashFrm = new DashFrm();
            addFormtoPanelContainer(dashFrm );
             nv = Login.nv;
            addControls();
             lbName.Text = nv.TenNV;

        }
        private void addControls()
        {
            if(nv.MaQuyen == 2)
            {
                btnStaff.Visible = false;
                btnPill.Visible = false;
                btnPN.Visible = false;
                btnStorage.Visible = false;
                btnVoucher.Visible = false;
            }else if(nv.MaQuyen == 3)
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
        }

        public void closeFrm(object Form)
        {
            Form f = Form as Form;
            f.Close();
        }
        private void btnSell_Click_1(object sender, EventArgs e)
        {
            /*BanHangFrm f = new BanHangFrm();
            f.TopLevel = false;
            PnContainer.Controls.Add(f);
            PnContainer.Dock = DockStyle.Fill;
            dashboard1.Visible = false;
            nhapHang1.Visible = false;
            f.Show();*/
            bhFrm = new BanHangFrm();
            addFormtoPanelContainer(bhFrm);
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            /*PnContainer.Controls.Clear();
           NhapHang.NhapHang nh = new NhapHang.NhapHang();
            PnContainer.Controls.Add(nh);
            PnContainer.Dock = DockStyle.Fill;*/

            addFormtoPanelContainer(new NhapHang.NhapHangFrm());

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

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnPN_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new PhieuNhapFrm());
        }

        private void btnPill_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new FormThuoc());
        }

        private void kryptonLabel2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }

}

