using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class XuatXu
    {
        private int maXuatXu;
        private string tenXuatXu;
        private int trangThai;

        public XuatXu(int maXuatXu, string tenXuatXu, int trangThai)
        {
            this.MaXuatXu = maXuatXu;
            this.TenXuatXu = tenXuatXu;
            this.TrangThai = trangThai;
        }

        public int MaXuatXu { get => maXuatXu; set => maXuatXu = value; }
        public string TenXuatXu { get => tenXuatXu; set => tenXuatXu = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
