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

namespace pharmacy_management.GUI.BanHang
{
    public partial class ChiTietDonHangFrm : Form
    {
        DonHang dh;
        string formattedNumber = "";
        public ChiTietDonHangFrm()
        {
            InitializeComponent();
        }

        public void AddNewContent(DonHang dh_info)
        {
            dh = dh_info;

            lbl_MaDH.Text = "#" + dh.MaDH.ToString();
            lbl_MaKH.Text = "#" + dh.MaKH.ToString();
            lbl_MaNV.Text = "#" + dh.MaNV.ToString();
            lbl_NgayLap.Text = dh.NgayLap;

            NhanVienBUS nvBUS = new NhanVienBUS();
            NhanVien nv = nvBUS.getNhanVien(dh.MaNV);
            lbl_TenNV.Text = nv.TenNV;

            KhachHangBUS khBUS = new KhachHangBUS();
            KhachHang kh = khBUS.getKH(dh.MaKH);
            lbl_TenKH.Text = kh.TenKH;
            lbl_sdtKH.Text = kh.Sdt;

            ChiTietDonHangBUS ctdhBUS = new ChiTietDonHangBUS();
            ThuocBUS tBUS = new ThuocBUS();
            DTO.Thuoc t;
            foreach (ChiTietDonHang item in ctdhBUS.getListWithID(dh.MaDH))
            {
                string price = item.DonGia.ToString("#,##0") + " đ";
                string final = item.ThanhTien.ToString("#,##0") + " đ";

                t = tBUS.getItem(item.MaThuoc);
                gv_SanPhamDH.Rows.Add(item.MaThuoc, t.TenThuoc, item.SoLuong, price, final);
            }

            formattedNumber = dh.TongGia.ToString("#,##0") + " đ";
            lbl_TongGia.Text = formattedNumber;

            QuyDoiDiemBUS qdBUS = new QuyDoiDiemBUS();
            PhieuGiamGiaBUS pgBUS = new PhieuGiamGiaBUS();
            string percent = pgBUS.getPhanTramGiamBUS(qdBUS.getQDD(dh.MaQuyDoi).MaPhieuGiam);
            if (percent == "")
            {
                lbl_Giam.Text = "0%";
            }
            else
            {
                lbl_Giam.Text = percent + "%";
            }

            formattedNumber = dh.ThanhTien.ToString("#,##0") + " đ";
            lbl_ThanhTien.Text = formattedNumber;

        }


    }
}
