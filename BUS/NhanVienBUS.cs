using pharmacy_management.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.BUS
{
    public class NhanVienBUS
    {
        private ArrayList list;
        private NhanVienDAO dao;

        public NhanVienBUS()
        {
            dao = new NhanVienDAO();
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
