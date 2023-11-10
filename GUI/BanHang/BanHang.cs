using Krypton.Toolkit;
using pharmacy_management.BUS;
using pharmacy_management.DTO;
using System;
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
    public partial class BanHang : Form
    {
        private int current_page_value;
        private SanPham spGUI;
        ThuocBUS thuoc_list;
        Label lbl_not_found = new Label();
        public BanHang()
        {
            InitializeComponent();
            setup();
            pagination();
        }
        public void setup()
        {
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

            foreach (Thuoc t in thuoc_list.getList())
            {
                Console.WriteLine(t.MaThuoc);

                spGUI = new SanPham();
                spGUI.AddNewContent(t);
                this.flow_pnl_contain_item.Controls.Add(spGUI);
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







        /*private void txt_searching_Enter(object sender, EventArgs e)
        {
            txt_searching.Text = "";
            txt_searching.ForeColor = Color.Black;
        }

        private void txt_searching_Leave(object sender, EventArgs e)
        {
            txt_searching.Text = "Tìm kiếm ...";
            txt_searching.ForeColor = Color.Gray;
        }*/
    }
}
