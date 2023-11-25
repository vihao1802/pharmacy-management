using pharmacy_management.DTO;
using pharmacy_management.GUI.BanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management.GUI.NhapHang
{
    public partial class PhieuNhapRow : UserControl
    {
        PhieuNhap pn;
        public PhieuNhapRow()
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

        public void AddNewContent(PhieuNhap pn_info)
        {
            pn = pn_info;

            lbl_MaDH.Text = pn_info.MaPN.ToString();
            lbl_MaNV.Text = pn_info.MaNV.ToString();
           
            lbl_NgayLap.Text = pn_info.NgayLap.ToString();

            string formattedNumber = pn_info.TongTien.ToString("#,##0") + " đ";
            lbl_ThanhTien.Text = formattedNumber;

        }

        private void btn_invoice_detail_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhapFrm f = new ChiTietPhieuNhapFrm();
            f.AddNewContent(pn);
            f.Show();
        }
    }
}

