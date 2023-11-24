using Krypton.Toolkit;
using pharmacy_management.BUS;
using pharmacy_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuoc;

namespace pharmacy_management.GUI
{
    public partial class DoiMatKhau : KryptonForm
    {
        private static NhanVien nv = new NhanVien();
        DangNhapBUS bus = new DangNhapBUS();
        public DoiMatKhau()
        {
            InitializeComponent();
            nv = Login.nv;
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPalette2_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtpassold.Text.Trim().Equals("") || txtpassnew.Text.Trim().Equals("") || txtpassnew1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }else if (!txtpassnew.Text.Trim().Equals(txtpassnew1.Text))
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau");
                return;
            }else if (txtpassnew.Text.Trim().Equals(txtpassold.Text))
            {
                MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ");
                return;
            }
                if (txtpassold.Text.Equals(nv.MatKhau))
            {
                bus.DoiPass(nv.TenDangNhap,txtpassnew.Text);
                MessageBox.Show("Đổi mật khẩu thành công, mật khẩu mới là: " + txtpassnew.Text);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mật khẩu");
                return;
            }
        }
    }
}
