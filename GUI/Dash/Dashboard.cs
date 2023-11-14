<<<<<<< HEAD
﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using System.Windows.Forms.DataVisualization;


using System.Xml.Linq;
using pharmacy_management.BUS;
using pharmacy_management.DAO;
using pharmacy_management.DTO;
using pharmacy_management.Properties;
using System.Windows.Forms.DataVisualization.Charting;

namespace pharmacy_management.GUI
{

    public partial class Dashboard : UserControl
    {
        List<decimal> revenues;
        List<string> months;
        ThongKeBUS tkbus = new ThongKeBUS();
        private int currentIndex,counter;
        Image[] banners = new Image[] { Resources.banner1, Resources.banner2, Resources.banner3
    };



        public Dashboard()
        {
            InitializeComponent();
           
            currentIndex = 0;
            counter = 0;
            Numthuoc.Text = tkbus.getslthuoc().ToString();
            Numkhach.Text = tkbus.getslkh().ToString();
            Numslban.Text = tkbus.getslban().ToString();
            Numdoanhthu.Text = tkbus.getdoanhthu().ToString();
        }


        private void chartcontrols()
        {
            revenues = new List<decimal>();
            months = new List<string>();
            tkbus.dtthang(revenues, months);
            chart1.Size = new Size(600, 400); // set the chart size
            chart1.Series.Add("Revenue"); // add a series
            chart1.DataSource = revenues; // set the data source
            chart1.Series["Revenue"].YValueMembers = "revenue"; // set the y-value member
            chart1.Series["Revenue"].ChartType = SeriesChartType.Column; // set the chart type
            chart1.ChartAreas.Add("ChartArea"); // add a chart area
            chart1.ChartAreas["ChartArea"].AxisX.LabelStyle.Format = "MMM"; // set the x-axis label format
            chart1.ChartAreas["ChartArea"].AxisX.IntervalType = DateTimeIntervalType.Months; // set the x-axis interval type
            chart1.ChartAreas["ChartArea"].AxisX.Interval = 1; // set the x-axis interval
            chart1.ChartAreas["ChartArea"].AxisX.CustomLabels.Clear(); // clear the default labels
            for (int i = 0; i < months.Count; i++)
            {
                chart1.ChartAreas["ChartArea"].AxisX.CustomLabels.Add(i + 0.5, i + 1.5, months[i]); // add custom labels
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
            if(counter > banners.Length)
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
                counter = banners.Length -1;
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






=======
﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Xml.Linq;
using thuoc.Properties;
using Transitions;


namespace thuoc.GUI
{

    public partial class Dashboard : UserControl
    {
        private Transition transition;
        private int currentIndex,counter;
        Image[] banners = new Image[] { Resources.banner1, Resources.banner2, Resources.banner3
    };



        public Dashboard()
        {
            InitializeComponent();
            currentIndex = 0;
            counter = 0;
           

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
        private void T_TransitionCompletedEvent(object sender, Transition.Args e)
        {
            // Reset the picture box position to the right
            picBanner.Left = this.Width;

            // Create another transition object to move the picture box back to the center
            Transition t = new Transition(new TransitionType_Linear(1000));
            t.add(picBanner, "Left", (this.Width - picBanner.Width) / 2);
            t.run();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(counter > banners.Length)
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
                counter = banners.Length -1;
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






>>>>>>> 807995ace6f7578ec629a8f9edb0f248d0f0a5e3
