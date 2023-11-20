using pharmacy_management.GUI.BanHang;
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

namespace pharmacy_management.GUI.NhapHang
{
    public partial class SPNhaphang : UserControl
    {
        DTO.Thuoc thuoc_info;
        NhapHangFrm nhapHang;
       
        public SPNhaphang(NhapHangFrm nhaphang)
        {

            InitializeComponent();
            this.nhapHang = nhaphang;

        }
        public void AddNewContent(DTO.Thuoc thuoc_item)
        {
              thuoc_item.GiaThuoc = thuoc_item.GiaThuoc * 80 / 100;

            thuoc_info = thuoc_item;
           // thuoc_info.GiaThuoc = thuoc_item.GiaThuoc * 80/100;
            lbl_item_name.Text = thuoc_item.TenThuoc;
           // float importprice = thuoc_item.GiaThuoc * 80 /100;

            string formattedNumber = thuoc_item.GiaThuoc.ToString("#,##0") + " đ";
            lbl_item_price.Text = formattedNumber;

            string imageName = thuoc_item.AnhThuoc.Replace("images/", "");
            string directoryPath = @"..\..\Resources";
            string fileName = imageName;
            string imagePath = Path.Combine(directoryPath, fileName);
            picb_item.ImageLocation = imagePath;
        }

        private void btn_item_detail_Click(object sender, EventArgs e)
        {
            ChiTietSanPhamFrm ctsp = new ChiTietSanPhamFrm(thuoc_info);
            ctsp.Show();
        }

        private void pnl_item_container_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#002EBF");
        }

        private void pnl_item_container_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btn_add_cart_Click(object sender, EventArgs e)
        {

            this.nhapHang.AddToCart(thuoc_info.MaThuoc, thuoc_info.TenThuoc, thuoc_info.GiaThuoc, thuoc_info.AnhThuoc);
        }
    }
}

