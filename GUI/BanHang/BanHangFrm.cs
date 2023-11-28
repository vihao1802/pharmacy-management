using Krypton.Toolkit;
using pharmacy_management.BUS;
using pharmacy_management.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;

namespace pharmacy_management.GUI.BanHang
{
    public partial class BanHangFrm : Form
    {
        private int current_page_value;
        private SanPham spGUI;
        ThuocBUS thuoc_list;
        List<DTO.Thuoc> thuoc_cart = new List<DTO.Thuoc>();
        Label lbl_not_found = new Label();
        GioHangFrm gh;

        public BanHangFrm()
        {
            InitializeComponent();
            setup();
            pagination();
        }

        public GioHangFrm GetGioHangFrm { get { return gh; } }
        public void setup()
        {
            if (ContainsSubform())
            {
                gh.Close();
            }

            DoiTuongBUS dt_list = new DoiTuongBUS();
            cb_DoiTuong.Items.Add("Tất cả");
            cb_DoiTuong.SelectedIndex = 0;
            foreach (DoiTuong dt in dt_list.getList())
            {
                cb_DoiTuong.Items.Add(dt.TenDT);
            }
            this.cb_DoiTuong.SelectedIndexChanged += new System.EventHandler(this.cb_DoiTuong_SelectedIndexChanged);

            XuatXuBUS xx_list = new XuatXuBUS();
            cb_XuatXu.Items.Add("Tất cả");
            cb_XuatXu.SelectedIndex = 0;
            foreach (XuatXu xx in xx_list.getList())
            {
                cb_XuatXu.Items.Add(xx.TenXuatXu);
            }
            this.cb_XuatXu.SelectedIndexChanged += new System.EventHandler(this.cb_XuatXu_SelectedIndexChanged);

            lbl_not_found.Text = "Không tìm thấy sản phẩm";
            lbl_not_found.Font = new Font(lbl_not_found.Font.FontFamily, 18);
            lbl_not_found.ForeColor = Color.DimGray;
            lbl_not_found.Anchor = AnchorStyles.None;
            lbl_not_found.AutoSize = true;
            lbl_not_found.TextAlign = ContentAlignment.MiddleCenter;
            lbl_not_found.BringToFront();
            lbl_not_found.Padding = new Padding(200, 200, 0, 0);
            flow_pnl_contain_item.Controls.Add(lbl_not_found);
        }

        public void setEmpty()
        {
            flow_pnl_contain_item.Controls.Clear();
        }

        public void pagination()
        {
            // total pages
            thuoc_list = new ThuocBUS();
            decimal perPages = 16;
            decimal count;
            decimal pages = 0;

            if (txt_searching.Text == "" && cb_DoiTuong.SelectedIndex == 0 && cb_XuatXu.SelectedIndex == 0)
            {
                count = thuoc_list.getSizeList("", 0, 0);
                Console.WriteLine("at pagination getSizeList: " + count);
                pages = Math.Ceiling(count / perPages);
            }
            else
            {
                count = thuoc_list.getSizeList(txt_searching.Text, cb_DoiTuong.SelectedIndex, cb_XuatXu.SelectedIndex);
                Console.WriteLine("at pagination getSizeList: " + count);
                pages = Math.Ceiling(count / perPages);
            }

            if (pages == 0)
            {
                pages += 1;
                flow_pnl_contain_item.Controls.Add(lbl_not_found);
                lbl_not_found.Visible = true;
            }
            else
            {
                lbl_not_found.Visible = false;
            }
            lbl_total_pages.Text = pages.ToString();

            string txt_search;
            txt_search = txt_searching.Text;

            int numDT = cb_DoiTuong.SelectedIndex;
            int numXX = cb_XuatXu.SelectedIndex;

            int current_page_value = Int32.Parse(lbl_current_page.Text);
            thuoc_list = new ThuocBUS(txt_search, numDT, numXX, current_page_value, Int32.Parse(perPages.ToString()));

            load_prodcut();
        }

        public void load_prodcut()
        {
            int count = 0;

            foreach (DTO.Thuoc t in thuoc_list.getList())
            {
                Console.WriteLine(t.MaThuoc);

                spGUI = new SanPham(this);
                spGUI.AddNewContent(t);
                this.flow_pnl_contain_item.Controls.Add(spGUI);
                spGUI.setVisible();
                count++;
            }
            Console.WriteLine("at load_prodcut: " + count);
        }

        private void txt_searching_TextChanged(object sender, EventArgs e)
        {
            setEmpty();
            lbl_current_page.Text = "1";
            pagination();
        }

        private void btn_search_page_Click(object sender, EventArgs e)
        {
            int total = Int32.Parse(lbl_total_pages.Text);
            Console.WriteLine("hello");
            if (!int.TryParse(txt_page_value.Text, out int pageNumber) || txt_page_value.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số !");
            }
            else if (Int32.Parse(txt_page_value.Text) > total || Int32.Parse(txt_page_value.Text) <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nàm trong phạm vi tổng số trang \n" +
                    "(VD: Từ 1 đến " + total + ") !");
            }
            else
            {
                //MessageBox.Show("Tim trang !");
                setEmpty();
                lbl_current_page.Text = txt_page_value.Text;
                txt_page_value.Text = "";
                pagination();
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lbl_current_page.Text) == 1)
            {
                MessageBox.Show("Bạn đang ở trang đầu tiên !");
                return;
            }
            else
            {
                setEmpty();
                lbl_current_page.Text = (Int32.Parse(lbl_current_page.Text) - 1).ToString();
                pagination();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lbl_current_page.Text) == Int32.Parse(lbl_total_pages.Text))
            {
                MessageBox.Show("Bạn đang ở trang cuối cùng !");
                return;
            }
            else
            {
                setEmpty();
                lbl_current_page.Text = (Int32.Parse(lbl_current_page.Text) + 1).ToString();
                pagination();
            }
        }

        private void cb_DoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("at cb_DoiTuong_SelectedIndexChanged: " + cb_DoiTuong.SelectedIndex);
            setEmpty();
            lbl_current_page.Text = "1";
            pagination();
        }

        private void cb_XuatXu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("at cb_XuatXu_SelectedIndexChanged: " + cb_XuatXu.SelectedIndex);
            setEmpty();
            lbl_current_page.Text = "1";
            pagination();
        }

        bool ContainsSubform()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "GioHangFrm")
                {
                    return true;
                }
            }
            return false;
        }

        public void check_cart_show()
        {
            if (ContainsSubform())
            {
                MessageBox.Show("Giỏ hàng đang được hiển thị");
                gh.BringToFront();
            }
            else
            {
                gh = new GioHangFrm(this);
                gh.setCart(thuoc_cart);
                gh.Show();
            }
        }

        private void btn_show_cart_Click(object sender, EventArgs e)
        {
            check_cart_show();
        }

        public void AddToCart(int ma, string ten, float gia, string anh)
        {

            int flag = 0;

            foreach (DTO.Thuoc item in thuoc_cart)
            {
                if (item.MaThuoc == ma)
                {
                    ThuocBUS tBUS = new ThuocBUS();
                    flag = 1;

                    if (tBUS.getItem(ma).SoLuong == item.SoLuong)
                    {
                        MessageBox.Show("Số lượng chỉ còn " + tBUS.getItem(ma).SoLuong + " cho sản phẩm này");
                        return;
                    }
                    item.SoLuong += 1;
                    break;
                }
            }

            if (flag == 0)
            {
                DTO.Thuoc tmp = new DTO.Thuoc(ma, ten, 0, gia, anh, 1, 0, 1);
                thuoc_cart.Add(tmp);
                thuoc_cart.Reverse();
            }
            Console.WriteLine(gh);
            if (gh == null || !ContainsSubform())
            {
                check_cart_show();
                //Console.WriteLine(gh);
            }
            else
            {
                //Console.WriteLine(gh);
                gh.setCart(thuoc_cart);
                gh.BringToFront();
                gh.Show();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.cb_DoiTuong.SelectedIndexChanged -= new System.EventHandler(this.cb_DoiTuong_SelectedIndexChanged);
            cb_DoiTuong.SelectedIndex = 0;
            this.cb_XuatXu.SelectedIndexChanged -= new System.EventHandler(this.cb_XuatXu_SelectedIndexChanged);
            cb_XuatXu.SelectedIndex = 0;
            this.txt_searching.TextChanged -= new System.EventHandler(this.txt_searching_TextChanged);
            txt_searching.Text = "";
            setEmpty();
            lbl_current_page.Text = "1";
            pagination();

            this.txt_searching.TextChanged += new System.EventHandler(this.txt_searching_TextChanged);
            this.cb_DoiTuong.SelectedIndexChanged += new System.EventHandler(this.cb_DoiTuong_SelectedIndexChanged);
            this.cb_XuatXu.SelectedIndexChanged += new System.EventHandler(this.cb_XuatXu_SelectedIndexChanged);



        }
    }
}
