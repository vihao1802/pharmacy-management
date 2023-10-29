using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class HangThuoc
    {
        private int maHang;
        private string tenHang;
        private int trangThai;

        public HangThuoc(int maHang, string tenHang, int trangThai)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.TrangThai = trangThai;
        }

        public int MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
