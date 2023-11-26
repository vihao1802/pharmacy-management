using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class KhachHang
    {
        private int maKH;
        private string tenKH;
        private string sdt;
        private DateTime ngaySinh;
        private int trangThai;

        public KhachHang() { }

        public KhachHang(string tenKH, string sdt, DateTime ngaySinh, int trangThai)
        {
            
            this.TenKH = tenKH;
            this.Sdt = sdt;
            this.NgaySinh = ngaySinh;
            this.TrangThai = trangThai;
        }
        public KhachHang(int maKH, string tenKH, string sdt, DateTime ngaySinh, int trangThai)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.Sdt = sdt;
            this.NgaySinh = ngaySinh;
            this.TrangThai = trangThai;
        }

        public int MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
