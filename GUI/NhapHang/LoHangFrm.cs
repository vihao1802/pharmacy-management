using pharmacy_management.BUS;
using pharmacy_management.DTO;
using pharmacy_management.GUI.BanHang;
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

namespace pharmacy_management.GUI.NhapHang
{
    public partial class LoHangFrm : Krypton.Toolkit.KryptonForm
    {
        public static NhanVien nv = new NhanVien();
        List<DTO.Thuoc> list_cart;
        private float total_price = 0;
        public LoHangFrm()
        {
            InitializeComponent();
            nv = Login.nv;
            lbName.Text = nv.TenNV.ToString();
            setup();
        }

        public void setup()
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (list_cart.Count == 0)
                if (list_cart.Count == 0)
                {
                    MessageBox.Show("Bạn chưa có sản phẩm nào");
                    return;
                }
         
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thanh toán?", "Thanh toán", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK)
            {
                return;
            }

            string selectedText;
            string[] arr;

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");

            PhieuNhapBUS pnBUS = new PhieuNhapBUS();

            string tongTien = lbl_total_price.Text.Replace(" đ", "").Replace(",", "");
            string thanhTien = lbl_final_total_price.Text.Replace(" đ", "").Replace(",", "");

            pnBUS.addNewInvoice(nv.MaNV, formattedDate, tongTien);

         

            PhieuNhap tmp = pnBUS.getItem();


         
            ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
            ThuocBUS tUpdate = new ThuocBUS();

            foreach (DTO.Thuoc t in list_cart)
            {
                float thanhTienThuoc = t.SoLuong * t.GiaThuoc;
                ctpnBUS.addNewDetailInvoice(tmp.MaPN, t.MaThuoc, t.SoLuong, t.GiaThuoc, thanhTienThuoc);
                tUpdate.addQuantity(t.MaThuoc, t.SoLuong);
                Console.WriteLine("Chi tiet PN:\n" + tmp.MaPN + "," + t.MaThuoc + "," + t.SoLuong + "," + t.GiaThuoc + "," + thanhTienThuoc);
            }
            //setEmpty();
            list_cart.Clear();
            AddCart();
            MessageBox.Show("Thanh toán thành công!");
        }

        public void setEmpty()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        public void AddCart()
        {
            setEmpty();
            SPLohang sp;
            total_price = 0;
            //Console.WriteLine("in cart list");
            foreach (DTO.Thuoc item in list_cart)
            {
                sp = new SPLohang(this);
                sp.AddNewContent(item);
                flowLayoutPanel1.Controls.Add(sp);
                total_price += (item.GiaThuoc * item.SoLuong);
                Console.WriteLine(item.MaThuoc + " " + item.SoLuong);

            }

            string formattedNumber = total_price.ToString("#,##0") + " đ";
            lbl_total_price.Text = formattedNumber;
            float final_price = total_price ;
            formattedNumber = final_price.ToString("#,##0") + " đ";
            lbl_final_total_price.Text = formattedNumber;
        }
        public void setCart(List<DTO.Thuoc> list)
        {
            list_cart = list;
            AddCart();
        }

        public void removeFromCart(int ma)
        {
            DTO.Thuoc t = list_cart.Find(thuoc => thuoc.MaThuoc == ma);
            //Console.WriteLine(t.GiaThuoc + " " + t.SoLuong);
            total_price -= (t.GiaThuoc * t.SoLuong);
            list_cart.RemoveAll(thuoc => thuoc.MaThuoc == ma);
            AddCart();
        }

        public void increase_quantity(int ma)
        {
            DTO.Thuoc t_modify = list_cart.Find(thuoc => thuoc.MaThuoc == ma);
            t_modify.SoLuong += 1;
            total_price += t_modify.GiaThuoc;
            AddCart();
        }

        public void decrease_quantity(int ma)
        {
            DTO.Thuoc t_modify = list_cart.Find(thuoc => thuoc.MaThuoc == ma);
            t_modify.SoLuong -= 1;
            if (t_modify.SoLuong == 0)
            {
                removeFromCart(ma);
            }
            else
            {
                total_price -= t_modify.GiaThuoc;
                AddCart();
            }
        }

       
      

    }
}
