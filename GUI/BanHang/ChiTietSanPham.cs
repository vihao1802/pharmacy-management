using pharmacy_management.BUS;
using pharmacy_management.DTO;
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
    public partial class ChiTietSanPham : Form
    {
        public ChiTietSanPham(Thuoc item)
        {
            InitializeComponent();
            load_product_detail(item);
        }

        public void load_product_detail(Thuoc t)
        {
            lbl_product_name.Text = t.TenThuoc;
            string formattedNumber = t.GiaThuoc.ToString("#,##0") + " đ";
            lbl_product_price.Text = formattedNumber;

            string imageName = t.AnhThuoc.Replace("images/", "");
            string directoryPath = @"..\..\Resources";
            string fileName = imageName;
            string imagePath = Path.Combine(directoryPath, fileName);
            picb_product_image.ImageLocation = imagePath;

            DoiTuongBUS dtBUS = new DoiTuongBUS();
            lbl_TenDoiTuong.Text = dtBUS.GetNameBUS(t.MaDoiTuong);

            XuatXuBUS xxBUS = new XuatXuBUS();
            lbl_TenXuatXu.Text = xxBUS.GetNameBUS(t.MaXuatXu);

            if (t.SoLuong > 0)
            {
                lbl_TrangThai.Text = "Còn hàng";
            }
            else
            {
                lbl_TrangThai.Text = "Hết hàng";
                lbl_TrangThai.ForeColor = Color.Red;
            }
        }

    }
}
