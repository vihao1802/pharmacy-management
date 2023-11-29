using pharmacy_management.BUS;
using pharmacy_management.DTO;
using pharmacy_management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pharmacy_management.GUI.Dash
{
    public partial class DashFrm : Form
    {
        List<decimal> revenues;
        List<string> months;
        ThongKeBUS tkbus = new ThongKeBUS();
        private int currentIndex, counter;
        DonHangBUS dhBUS = new DonHangBUS();
        PhieuNhapBUS pnBUS = new PhieuNhapBUS();

        Image[] banners = new Image[] { Resources.banner1, Resources.banner2, Resources.banner3
    };



        public DashFrm()
        {
            InitializeComponent();

            currentIndex = 0;
            counter = 0;
            Numthuoc.Text = tkbus.getslthuoc().ToString();
            Numkhach.Text = tkbus.getslkh().ToString();
            Numslban.Text = tkbus.getslban().ToString();
            string formattedNumber = tkbus.getdoanhthu().ToString("#,##0") + " đ";
            Numdoanhthu.Text = formattedNumber;


            setupDoanhThu();
        }

        public void setupDoanhThu()
        {
            dtp_start.MaxDate = DateTime.Now.AddYears(0);
            dtp_start.Value = DateTime.Parse("2023-01-01");
            dtp_end.MinDate = dtp_start.Value;
            dtp_end.MaxDate = DateTime.Now.AddYears(0);
            numeric_top.Value = 0;

            load_data();
        }

        public void setupKho()
        {
            dateTimePicker2.MaxDate = DateTime.Now.AddYears(0);
            dateTimePicker2.Value = DateTime.Parse("2023-01-01");
            dateTimePicker1.MinDate = dateTimePicker2.Value;
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(0);
            numericUpDown1.Value = 0;

            load_data1();
        }

        public void setupDoiTuong()
        {
            dateTimePicker4.MaxDate = DateTime.Now.AddYears(0);
            dateTimePicker4.Value = DateTime.Parse("2023-01-01");
            dateTimePicker3.MinDate = dateTimePicker4.Value;
            dateTimePicker3.MaxDate = DateTime.Now.AddYears(0);
            numericUpDown2.Value = 0;

            load_data2();
        }

        public void load_data()
        {
            gv_QDD.Rows.Clear();
            DateTime dateStart = dtp_start.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dtp_end.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");
            string numeric = numeric_top.Value.ToString();
            dhBUS.loadListStatis(formattedDateStart, formattedDateEnd, numeric);
            foreach (DTO.Thuoc item in dhBUS.getList())
            {
                string formattedNumber = item.GiaThuoc.ToString("#,##0") + " đ";
                this.gv_QDD.Rows.Add(item.MaThuoc, item.TenThuoc, formattedNumber, item.SoLuong);
            }
        }
        public void load_data1()
        {
            dataGridView1.Rows.Clear();
            DateTime dateStart = dateTimePicker2.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dateTimePicker1.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");
            string numeric = numericUpDown1.Value.ToString();
            pnBUS.loadListStatis(formattedDateStart, formattedDateEnd, numeric);
            foreach (DTO.Thuoc item in pnBUS.getList())
            {
                string formattedNumber = item.GiaThuoc.ToString("#,##0") + " đ";
                this.dataGridView1.Rows.Add(item.MaThuoc, item.TenThuoc, formattedNumber, item.SoLuong);
            }
        }

        public void load_data2()
        {
            dataGridView2.Rows.Clear();
            DateTime dateStart = dateTimePicker4.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dateTimePicker3.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");
            string numeric = numericUpDown2.Value.ToString();
            dhBUS.loadListStatisDT(formattedDateStart, formattedDateEnd, numeric);
            foreach (DTO.Thuoc item in dhBUS.getList())
            {
                string formattedNumber = item.GiaThuoc.ToString("#,##0") + " đ";
                this.dataGridView2.Rows.Add(item.MaThuoc, item.TenThuoc, formattedNumber, item.SoLuong);
            }
        }
        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            dtp_end.MinDate = dtp_start.Value;
            load_data();
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void numeric_top_ValueChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            setupDoanhThu();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = dateTimePicker2.Value;
            load_data1();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            load_data1();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            load_data1();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            setupKho();
        }


        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.MinDate = dateTimePicker4.Value;
            load_data2();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            load_data2();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            load_data2();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            setupDoiTuong();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabControl1.SelectedIndex;

            if (selectedIndex == 0)
            {
                setupDoanhThu();
            }
            else if (selectedIndex == 1)
            {
                setupKho();
            }
            else if (selectedIndex == 2)
            {
                setupDoiTuong();
            }
            else if (selectedIndex == 3)
            {
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {
            counter++;
            switch (counter)
            {
                case 1:
                    picBanner.Image = banners[0];
                    break;
                case 2:
                    picBanner.Image = banners[1];
                    break;
                case 3:
                    picBanner.Image = banners[2];
                    counter = 0;
                    break;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (counter > banners.Length)
            {
                counter = 0;
            }
            counter++;
            switch (counter)
            {
                case 1:
                    picBanner.Image = banners[0];
                    break;
                case 2:
                    picBanner.Image = banners[1];
                    break;
                case 3:
                    picBanner.Image = banners[2];
                    counter = 0;
                    break;
            }

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (counter < 0)
            {
                counter = banners.Length - 1;
            }
            counter--;
            switch (counter)
            {
                case 1:
                    picBanner.Image = banners[0];
                    break;
                case 2:
                    picBanner.Image = banners[1];
                    break;
                case 3:
                    picBanner.Image = banners[2];
                    counter = 0;
                    break;
            }

        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            picBanner.Image = banners[0];


        }

    }
}

