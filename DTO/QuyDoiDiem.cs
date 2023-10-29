using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class QuyDoiDiem
    {
        private int maQuyDoi;
        private int maKH;
        private string ngayQuyDoi;
        private int maPhieuGiam;
        private int daSuDung;

        public QuyDoiDiem(int maQuyDoi, int maKH, string ngayQuyDoi, int maPhieuGiam, int daSuDung)
        {
            this.MaQuyDoi = maQuyDoi;
            this.MaKH = maKH;
            this.NgayQuyDoi = ngayQuyDoi;
            this.MaPhieuGiam = maPhieuGiam;
            this.DaSuDung = daSuDung;
        }

        public int MaQuyDoi { get => maQuyDoi; set => maQuyDoi = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public string NgayQuyDoi { get => ngayQuyDoi; set => ngayQuyDoi = value; }
        public int MaPhieuGiam { get => maPhieuGiam; set => maPhieuGiam = value; }
        public int DaSuDung { get => daSuDung; set => daSuDung = value; }
    }
}
