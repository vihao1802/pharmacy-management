using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class DiemKhachHang
    {
        private int maBangDiem;
        private int maKH;
        private int diemTichLuy;
        private int diemDaSuDung;

        public DiemKhachHang(int maBangDiem, int maKH, int diemTichLuy, int diemDaSuDung)
        {
            this.MaBangDiem = maBangDiem;
            this.MaKH = maKH;
            this.DiemTichLuy = diemTichLuy;
            this.DiemDaSuDung = diemDaSuDung;
        }

        public int MaBangDiem { get => maBangDiem; set => maBangDiem = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
        public int DiemDaSuDung { get => diemDaSuDung; set => diemDaSuDung = value; }
    }
}
