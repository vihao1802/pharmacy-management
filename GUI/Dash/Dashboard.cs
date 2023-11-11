
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






