using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management.GUI.BanHang
{
    public partial class SanPhamGioHang : UserControl
    {
        DTO.Thuoc thuoc_info;
        GioHangFrm gh;
        public SanPhamGioHang(GioHangFrm gh)
        {
            InitializeComponent();
            this.gh = gh;
        }

        public void AddNewContent(DTO.Thuoc thuoc_item)
        {
            thuoc_info = thuoc_item;

            lbl_prod_name_cart.Text = thuoc_item.TenThuoc;

            string formattedNumber = thuoc_item.GiaThuoc.ToString("#,##0") + " đ";
            lbl_prod_price_cart.Text = formattedNumber;
            lbl_prod_quantity_cart.Text = thuoc_item.SoLuong.ToString();
            string imageName = thuoc_item.AnhThuoc.Replace("images/", "");
            string directoryPath = @"..\..\Resources";
            string fileName = imageName;
            string imagePath = Path.Combine(directoryPath, fileName);
            picb_image_cart.ImageLocation = imagePath;
        }

        private void btn_decrease_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("-");
            gh.decrease_quantity(thuoc_info.MaThuoc);
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("+");
            gh.increase_quantity(thuoc_info.MaThuoc);
        }

        private void btn_remove_item_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Remove");
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khỏi giỏ hàng?", "Xóa sản phẩm khỏi giỏ hàng", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Console.WriteLine("Remove " + thuoc_info.MaThuoc);
                gh.removeFromCart(thuoc_info.MaThuoc);
            }
            else if (result == DialogResult.Cancel)
            {
                Console.WriteLine("User clicked Cancel");
            }
        }

        private void btn_remove_item_MouseEnter(object sender, EventArgs e)
        {
            btn_remove_item.BackColor = Color.Red;
            btn_remove_item.Image = Properties.Resources.icons8_close_24_white;
        }

        private void btn_remove_item_MouseLeave(object sender, EventArgs e)
        {
            btn_remove_item.BackColor = Color.White;
            btn_remove_item.Image = Properties.Resources.icons8_close_24;
        }
    }
}
