using pharmacy_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management.GUI.BanHang
{
    public partial class DonHangRow : UserControl
    {
        DonHang dh;
        public DonHangRow()
        {
            InitializeComponent();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.AliceBlue;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
        }

        public void AddNewContent(DonHang dh_info)
        {
            dh = dh_info;

            lbl_MaDH.Text = dh_info.MaDH.ToString();
            lbl_MaNV.Text = dh_info.MaNV.ToString();
            lbl_MaKH.Text = dh_info.MaKH.ToString();
            lbl_MaQD.Text = dh_info.MaQuyDoi.ToString();
            lbl_NgayLap.Text = dh_info.NgayLap.ToString();

            string formattedNumber = dh_info.ThanhTien.ToString("#,##0") + " đ";
            lbl_ThanhTien.Text = formattedNumber;

        }

        private void btn_invoice_detail_Click(object sender, EventArgs e)
        {

        }
    }
}
