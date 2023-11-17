using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DTO
{
    internal class ThongKe
    {
        private int sothuoc, sokh, slban, doanhthu;

        public ThongKe(int sothuoc, int sokh, int slban, int doanhthu)
        {
            this.sothuoc = sothuoc;
            this.sokh = sokh;
            this.slban = slban;
            this.doanhthu = doanhthu;
        }

        public ThongKe()
        {
        }
        public int getSothuoc() {
            return this.sothuoc;
        }
        public int getSokh() {
            return this.sokh;
        }
        public int getSlban() {
            return this.slban;
        }
        public int getDoanhthu()
        {
            return this.doanhthu;
        }
        public void setSothuoc(int sothuoc)
        {
            this.sothuoc= sothuoc;
        }
        public void setSokh(int sokh)
        {
            this.sokh= sokh;
        }
        public void setSlban(int slban)
        {
            this.slban = slban;
        }
        public void setDoanhthu(int doanhthu)
        {
            this.doanhthu = doanhthu;
        }
    }
}
