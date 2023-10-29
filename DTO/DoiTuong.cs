using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class DoiTuong
    {
        private int maDT;
        private string tenDT;
        private int trangThai;

        public DoiTuong(int maDT, string tenDT, int trangThai)
        {
            this.MaDT = maDT;
            this.TenDT = tenDT;
            this.TrangThai = trangThai;
        }

        public int MaDT { get => maDT; set => maDT = value; }
        public string TenDT { get => tenDT; set => tenDT = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
