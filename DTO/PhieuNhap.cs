using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class PhieuNhap
    {
        private int maPN;
        private int maNV;
        private string ngayLap;
        private float tongTien;

        public PhieuNhap(int maPN, int maNV, string ngayLap, float tongTien)
        {
            this.MaPN = maPN;
            this.MaNV = maNV;
            this.NgayLap = ngayLap;
            this.TongTien = tongTien;
        }

        public int MaPN { get => maPN; set => maPN = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
