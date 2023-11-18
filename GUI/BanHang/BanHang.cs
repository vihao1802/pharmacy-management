using Krypton.Toolkit;
using System;
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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }


        private void txt_searching_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_searching_MouseEnter(object sender, EventArgs e)
        {
            txt_searching.Text = "";
            txt_searching.ForeColor = Color.Black;
        }

        private void txt_searching_MouseLeave(object sender, EventArgs e)
        {
            txt_searching.Text = "Tìm kiếm ...";
            txt_searching.ForeColor = Color.Gray;
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
