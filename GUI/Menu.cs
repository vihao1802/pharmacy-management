using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using pharmacy_management.DTO;
using pharmacy_management.Properties;
using Transitions;
using static System.Net.Mime.MediaTypeNames;

namespace pharmacy_management.GUI
{
    public partial class Menu : KryptonForm
    {
        public static NhanVien nv = new NhanVien();
        
        bool sidebarExpand;
      
        public Menu()
        {
            InitializeComponent();
           
            nv = Login.nv;
            lbName.Text = nv.TenNV;
           
        }

       
        private void sidebarTimer_tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                    if(Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                    dashboard1.Size = dashboard1.MinimumSize;
                }
            }
            else
            {
                Sidebar.Width += 10;
                if(Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    dashboard1.Size = dashboard1.MaximumSize;
                }
            }
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnClose_DragLeave(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            KryptonButton button1 = (KryptonButton)sender;
            changeHovercolor(button1);
            button1.StateCommon.Back.Image = Properties.Resources.Sell_Contrast;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            KryptonButton button1 = (KryptonButton)sender;
            button1.BackColor = Color.FromArgb(255, 255, 255);
            button1.ForeColor = Color.Black;
            button1.StateCommon.Back.Image = Properties.Resources.Sell;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void changeHovercolor(KryptonButton b)
        {
            b.StateCommon.Back.Color1 = Color.FromArgb(0, 46, 191);
            b.StateCommon.Back.Color2 = Color.FromArgb(0, 46, 191);
        }
        private void changeExitcolor(KryptonButton b)
        {
            b.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 255);
            b.StateCommon.Back.Color2 = Color.White;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPill_MouseHover(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeHovercolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Pill_Contrast;
        }

        private void btnPill_MouseLeave(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeExitcolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Pill;
        }

        private void btnVoucher_MouseHover(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeHovercolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Voucher_Contrast;
        }

        private void btnVoucher_MouseLeave(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeExitcolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Voucher;
        }

        private void btnStaff_MouseHover(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeHovercolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Staff_Contrast;
        }

        private void btnStaff_MouseLeave(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeExitcolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Staff;
        }

        private void btnCustomer_MouseHover(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeHovercolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Crowd_Contrast;
        }

        private void btnCustomer_MouseLeave(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeExitcolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Crowd;
        }

        private void btnStorage_MouseHover(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeHovercolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Storage_Contrast;
        }

        private void btnStorage_MouseLeave(object sender, EventArgs e)
        {
            KryptonButton b = (KryptonButton)sender;
            changeExitcolor(b);
            b.StateCommon.Back.Image = Properties.Resources.Storage;
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

        private void btnSell_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            nhapHang1.Visible = true;
            dashboard1.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
    
}
