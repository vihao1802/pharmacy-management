using pharmacy_management.BUS;
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

