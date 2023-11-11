using pharmacy_management.BUS;
using pharmacy_management.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pharmacy_management.GUI.BanHang
{
    public partial class GioHangFrm : Form
    {
        QuyDoiDiemBUS qdBUS = new QuyDoiDiemBUS();
        PhieuGiamGiaBUS pggBUS = new PhieuGiamGiaBUS();
        List<DTO.Thuoc> list_cart;
        private float total_price = 0;
        public GioHangFrm()
        {
            InitializeComponent();
            setup();
        }
        public void load_QuyDoiDiem()
        {
            dropBtn_PG.Items.Clear();
            if (dropBtn_KH.SelectedIndex > 0)
            {
                string selectedText = dropBtn_KH.SelectedItem.ToString();
                string[] arr = selectedText.Split('_');
                int maKH = Int32.Parse(arr[0]);

                dropBtn_PG.Items.Add("Chọn phiếu giảm");

                foreach (QuyDoiDiem qd in qdBUS.getList())
                {
                    Console.WriteLine(qd.MaKH);
                    if (maKH == qd.MaKH)
                    {
                        // Combobox Quy Doi Diem
                        string item_name = qd.MaQuyDoi.ToString() + "_" + pggBUS.GetNameBUS(qd.MaPhieuGiam);
                        dropBtn_PG.Items.Add(item_name);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng hợp lệ khi dùng phiếu giảm");
            }
        }
        public void setup()
        {
            KhachHangBUS khBUS = new KhachHangBUS();
            Console.WriteLine(dropBtn_KH.SelectedIndex);
            foreach (KhachHang kh in khBUS.getList())
            {
                string item_name = kh.MaKH.ToString() + "_" + kh.TenKH;
                dropBtn_KH.Items.Add(item_name);
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (list_cart.Count == 0)
            {
                MessageBox.Show("Bạn chưa có sản phẩm nào");
                return;
            }
            if (dropBtn_KH.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn khách hàng trước khi thanh toán");
                return;
            }

            string selectedText;
            string[] arr;

            selectedText = dropBtn_KH.Text;
            arr = selectedText.Split('_');
            string maKH = arr[0];

            selectedText = dropBtn_PG.Text;
            string maQD;
            if (selectedText == "Chọn phiếu giảm")
            {
                maQD = "null";
            }
            else
            {
                arr = selectedText.Split('_');
                maQD = arr[0];
            }

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");

            Console.WriteLine("MaNV: " + "2" +
                "\nMaKH: " + maKH +
                "\nNgayLap: " + formattedDate +
                "\nMaQDD: " + maQD +
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
            SanPhamGioHang sp;
            total_price = 0;
            //Console.WriteLine("in cart list");
            foreach (DTO.Thuoc item in list_cart)
            {
                sp = new SanPhamGioHang(this);
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

        private void dropBtn_KH_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropBtn_PG.SelectedIndex = -1;
            dropBtn_PG.Text = "Chọn phiếu giảm";
            lbl_discount.Text = "0%";
        }

        private void dropBtn_PG_DropDown(object sender, EventArgs e)
        {
            //Console.WriteLine("hello");
            load_QuyDoiDiem();
        }


    }
}
