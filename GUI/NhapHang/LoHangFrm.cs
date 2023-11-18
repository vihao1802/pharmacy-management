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

namespace pharmacy_management.GUI.NhapHang
{
    public partial class LoHangFrm : Form
    {
        QuyDoiDiemBUS qdBUS = new QuyDoiDiemBUS();
        PhieuGiamGiaBUS pggBUS = new PhieuGiamGiaBUS();
        List<DTO.Thuoc> list_cart;
        private float total_price = 0;
        public LoHangFrm()
        {
            InitializeComponent();
            setup();
        }
      
        public void setup()
        {
            
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (list_cart.Count == 0)
            {
                MessageBox.Show("Bạn chưa có sản phẩm nào");
                return;
            }
           

            string selectedText;
            string[] arr;

         // //  selectedText = dropBtn_KH.Text;
         ////   arr = selectedText.Split('_');
         ////   string maKH = arr[0];

         //  // selectedText = dropBtn_PG.Text;
         //   string maQD;
         //   if (selectedText == "Chọn phiếu giảm")
         //   {
         //       maQD = "null";
         //   }
         //   else
         //   {
         //       arr = selectedText.Split('_');
         //       maQD = arr[0];
         //   }

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");

            Console.WriteLine("MaNV: " + "2" +
              //  "\nMaKH: " + maKH +
                "\nNgayLap: " + formattedDate +
              //  "\nMaQDD: " + maQD +
                "\nTongGia: " + lbl_total_price.Text.Replace(" đ", "").Replace(",", "") +
                "\nThanhTien" + lbl_final_total_price.Text.Replace(" đ", "").Replace(",", ""));
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

            Console.WriteLine(lbl_discount.Text);
            float final_price = total_price - total_price * (float.Parse(lbl_discount.Text.Replace("%", "")) / 100.0f);
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

        private void dropBtn_PG_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string selectedText = dropBtn_PG.Text;
            string arr[] = selectedText.Split('_');
            string maQD = arr[0];*/

            string selectedText = dropBtn_PG.Text;
            string[] arr = selectedText.Split('_');
            int maQD;

            if (selectedText == "Chọn phiếu giảm" || dropBtn_PG.SelectedIndex == -1)
            {
                //dropBtn_PG.SelectedIndex = -1;
                dropBtn_PG.Text = "Chọn phiếu giảm";
                lbl_discount.Text = "0%";
                AddCart();
                return;
            }
            else
            {
                arr = selectedText.Split('_');
                maQD = Int32.Parse(arr[0]);
            }

            foreach (QuyDoiDiem qd in qdBUS.getList())
            {
                if (maQD == qd.MaQuyDoi)
                {
                    // Combobox Quy Doi Diem
                    string percent = pggBUS.getPhanTramGiamBUS(qd.MaPhieuGiam);
                    lbl_discount.Text = percent + "%";
                    break;
                }
            }
            Console.WriteLine("PG change");

            AddCart();
        }

      

    }
}
