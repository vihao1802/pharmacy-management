using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    public class Quyen
    {
        private int maQuyen;
        private string tenQuyen;

        public Quyen() { }

        public Quyen(string tenQuyen)
        {
            this.TenQuyen = tenQuyen;
        }


        public Quyen(int maQuyen, string tenQuyen)
        {
            this.MaQuyen = maQuyen;
            this.TenQuyen = tenQuyen;
        }

        public int MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string TenQuyen { get => tenQuyen; set => tenQuyen = value; }
    }
}
