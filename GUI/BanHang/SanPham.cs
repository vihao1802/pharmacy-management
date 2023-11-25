using pharmacy_management.DTO;
using pharmacy_management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using pharmacy_management.GUI.NhapHang;
namespace pharmacy_management.GUI.BanHang
{
    public partial class SanPham : UserControl
    {
        DTO.Thuoc thuoc_info;
        BanHangFrm bhFrm;
      
        public SanPham(BanHangFrm bhFrm)
        {
            InitializeComponent();
            this.bhFrm = bhFrm;
        }
     
        public void AddNewContent(DTO.Thuoc thuoc_item)
        {
            thuoc_item.GiaThuoc = thuoc_item.GiaThuoc * 120 / 100;
            thuoc_info = thuoc_item;
           

            lbl_item_name.Text = thuoc_item.TenThuoc;

            string formattedNumber = thuoc_item.GiaThuoc.ToString("#,##0") + " đ";
            lbl_item_price.Text = formattedNumber;

            string imageName = thuoc_item.AnhThuoc.Replace("images/", "");
            string directoryPath = @"..\..\Resources";
            string fileName = imageName;
            string imagePath = Path.Combine(directoryPath, fileName);
            picb_item.ImageLocation = imagePath;

            if (thuoc_item.SoLuong == 0)
            {
                btn_add_cart.Enabled = false;

                this.btn_add_cart.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
                this.btn_add_cart.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
                this.btn_add_cart.StateCommon.Back.Image = ((System.Drawing.Image)(Resources.icons8_cart_30_gray));
                this.btn_add_cart.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
                this.btn_add_cart.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            }
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
            this.bhFrm.AddToCart(thuoc_info.MaThuoc, thuoc_info.TenThuoc, thuoc_info.GiaThuoc, thuoc_info.AnhThuoc);
        }

        public string getLabelName()
        {
            return this.lbl_item_name.Text;
        }
        public void setVisible()
        {
            lbl_item_name.BringToFront();
        }
    }
}
