using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class ChiTietDonHang
    {
        private int maChiTietDH;
        private int maDH;
        private int maThuoc;
        private int soLuong;
        private float donGia;
        private float thanhTien;

        public ChiTietDonHang(int maChiTietDH, int maDH, int maThuoc, int soLuong, float donGia, float thanhTien)
        {
            this.MaChiTietDH = maChiTietDH;
            this.MaDH = maDH;
            this.MaThuoc = maThuoc;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }

        public int MaChiTietDH { get => maChiTietDH; set => maChiTietDH = value; }
        public int MaDH { get => maDH; set => maDH = value; }
        public int MaThuoc { get => maThuoc; set => maThuoc = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
