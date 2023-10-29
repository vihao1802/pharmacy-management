using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class Thuoc
    {
        private int maThuoc;
        private string tenThuoc;
        private int maDoiTuong;
        private int maHangThuoc;
        private float giaThuoc;
        private string anhThuoc;
        private int trangThai;

        public Thuoc(int maThuoc, string tenThuoc, int maDoiTuong, int maHangThuoc, float giaThuoc, string anhThuoc, int trangThai)
        {
            this.maThuoc = maThuoc;
            this.tenThuoc = tenThuoc;
            this.maDoiTuong = maDoiTuong;
            this.maHangThuoc = maHangThuoc;
            this.giaThuoc = giaThuoc;
            this.anhThuoc = anhThuoc;
            this.trangThai = trangThai;
        }

        public int MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public int MaDoiTuong { get => maDoiTuong; set => maDoiTuong = value; }
        public int MaHangThuoc { get => maHangThuoc; set => maHangThuoc = value; }
        public float GiaThuoc { get => giaThuoc; set => giaThuoc = value; }
        public string AnhThuoc { get => anhThuoc; set => anhThuoc = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
