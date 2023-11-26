using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class PhieuGiamGia
    {
        private int maPhieuGiam;
        private string moTaPG;
        private int soDiemQuyDoi;
        private int phanTramGiam;
        private int maQuyDoi;

        public PhieuGiamGia(int maPhieuGiam, string moTaPG, int soDiemQuyDoi, int phanTramGiam, int maQuyDoi)
        {
            this.MaPhieuGiam = maPhieuGiam;
            this.MoTaPG = moTaPG;
            this.SoDiemQuyDoi = soDiemQuyDoi;
            this.PhanTramGiam = phanTramGiam;
            this.MaQuyDoi = maQuyDoi;
        }

        public int MaPhieuGiam { get => maPhieuGiam; set => maPhieuGiam = value; }
        public string MoTaPG { get => moTaPG; set => moTaPG = value; }
        public int SoDiemQuyDoi { get => soDiemQuyDoi; set => soDiemQuyDoi = value; }
        public int PhanTramGiam { get => phanTramGiam; set => phanTramGiam = value; }
        public int MaQuyDoi { get => maQuyDoi; set => maQuyDoi = value; }

    }
}
