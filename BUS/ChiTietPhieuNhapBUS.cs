using pharmacy_management.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.BUS
{
    public class ChiTietPhieuNhapBUS
    {
        private ArrayList list;
        private ChiTietPhieuNhapDAO dao;

        public ChiTietPhieuNhapBUS()
        {
            dao = new ChiTietPhieuNhapDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = dao.GetALl();
        }
    }
}
