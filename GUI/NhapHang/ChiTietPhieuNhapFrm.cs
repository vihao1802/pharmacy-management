using Krypton.Toolkit;
using pharmacy_management.BUS;
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
using thuoc;

namespace pharmacy_management.GUI.NhapHang
{
    public partial class ChiTietPhieuNhapFrm : KryptonForm
    {
        public static DTO.NhanVien nv = new DTO.NhanVien();
        PhieuNhap pn;
        string formattedNumber = "";
        public ChiTietPhieuNhapFrm()
        {
            InitializeComponent();
            nv = Login.nv;
        }

        public void AddNewContent(PhieuNhap pn_info)
        {
            pn = pn_info;

            lbl_MaDH.Text = pn.MaPN.ToString();
            lbl_MaNV.Text = pn.MaNV.ToString();
            lbl_NgayLap.Text = pn.NgayLap.ToString();

            NhanVienBUS nvBUS = new NhanVienBUS();
            DTO.NhanVien nv = nvBUS.getNhanVien(pn.MaNV);
            lbl_TenNV.Text = nv.TenNV;


            ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
            ThuocBUS tBUS = new ThuocBUS();
            DTO.Thuoc t;
            foreach (ChiTietPhieuNhap item in ctpnBUS.getListWithID(pn.MaPN))
            {
                string price = item.DonGia.ToString("#,##0") + " đ";
                string final = item.ThanhTien.ToString("#,##0") + " đ";

                t = tBUS.getItem(item.MaThuoc);
                gv_SanPhamPN.Rows.Add(item.MaThuoc, t.TenThuoc, item.SoLuong, price, final);
            }

            formattedNumber = pn.TongTien.ToString("#,##0") + " đ";
            lbl_TongGia.Text = formattedNumber;

        

            formattedNumber = pn.TongTien.ToString("#,##0") + " đ";
            lbl_ThanhTien.Text = formattedNumber;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

