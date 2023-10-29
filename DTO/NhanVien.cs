using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class NhanVien
    {
        private int maNV;
        private string tenNV;
        private string sdt;
        private string diaChi;
        private string email;
        private int trangThai;
        private string tenDangNhap;
        private string matKhau;
        private int maQuyen;

        public NhanVien(int maNV, string tenNV, string sdt, string diaChi, string email, int trangThai, string tenDangNhap, string matKhau, int maQuyen)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.sdt = sdt;
            this.DiaChi = diaChi;
            this.Email = email;
            this.TrangThai = trangThai;
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.MaQuyen = maQuyen;
        }

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int MaQuyen { get => maQuyen; set => maQuyen = value; }
    }
}
