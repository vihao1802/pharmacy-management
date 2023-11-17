using pharmacy_management.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.BUS
{
    internal class XuatXuBUS
    {
        private ArrayList list;
        private XuatXuDAO dao;

        public XuatXuBUS()
        {
            dao = new XuatXuDAO();
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

        public string GetNameBUS(int ma)
        {
            return dao.GetNameDAO(ma);
        }
    }
}
