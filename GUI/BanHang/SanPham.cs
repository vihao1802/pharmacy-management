using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuoc.GUI.BanHang
{
    public partial class SanPham : UserControl
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void btn_item_detail_Click(object sender, EventArgs e)
        {

        }

        private void pnl_item_container_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#002EBF");
        }

        private void pnl_item_container_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbl_item_name_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
