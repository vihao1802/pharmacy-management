using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class DonHang
    {
        private int maDH;
        private int maNV;
        private int maKH;
        private DateTime ngayLap;
        private int maQuyDoi;
        private float tongGia;
        private float thanhTien;

        public DonHang(int maDH, int maNV, int maKH, DateTime ngayLap, int maQuyDoi, float tongGia, float thanhTien)
        {
            this.MaDH = maDH;
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.NgayLap = ngayLap;
            this.MaQuyDoi = maQuyDoi;
            this.TongGia = tongGia;
            this.ThanhTien = thanhTien;
        }

        public int MaDH { get => maDH; set => maDH = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int MaQuyDoi { get => maQuyDoi; set => maQuyDoi = value; }
        public float TongGia { get => tongGia; set => tongGia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
