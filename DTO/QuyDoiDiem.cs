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
        private int daSuDung;

        public QuyDoiDiem()
        {

        }
        public QuyDoiDiem(int maQuyDoi, int maKH, string ngayQuyDoi, int daSuDung)
        {
            this.MaQuyDoi = maQuyDoi;
            this.MaKH = maKH;
            this.NgayQuyDoi = ngayQuyDoi;
            this.DaSuDung = daSuDung;
        }

        public int MaQuyDoi { get => maQuyDoi; set => maQuyDoi = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public string NgayQuyDoi { get => ngayQuyDoi; set => ngayQuyDoi = value; }
        public int DaSuDung { get => daSuDung; set => daSuDung = value; }
    }
}
