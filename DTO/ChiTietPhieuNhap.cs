using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class ChiTietPhieuNhap
    {
        private int maChiTietPN;
        private int maPN;
        private int maThuoc;
        private int soLuong;
        private float donGia;
        private float thanhTien;

        public ChiTietPhieuNhap(int maChiTietPN, int maPN, int maThuoc, int soLuong, float donGia, float thanhTien)
        {
            this.MaChiTietPN = maChiTietPN;
            this.MaPN = maPN;
            this.MaThuoc = maThuoc;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }

        public int MaChiTietPN { get => maChiTietPN; set => maChiTietPN = value; }
        public int MaPN { get => maPN; set => maPN = value; }
        public int MaThuoc { get => maThuoc; set => maThuoc = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
