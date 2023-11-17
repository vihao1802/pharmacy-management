using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacy_management.DAO;
using pharmacy_management.DTO;

namespace pharmacy_management.BUS
{
    internal class ThongKeBUS
    {
        ThongKeDAO dao = new ThongKeDAO();
        public ThongKeBUS() { }

        public int getslthuoc()
        {
            return dao.getslthuoc();
        }
        public int getslkh()
        {
            return dao.getslkh();
        }
        public int getslban()
        {
            return dao.getslban();  
        }
        public int getdoanhthu()
        {
            return dao.getdoanhthu();
        }
        public void dtthang(List<decimal> revenues, List<string> months)
        {
            dao.dtthang(revenues,months);
        }
    }
}
