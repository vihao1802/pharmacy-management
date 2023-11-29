using pharmacy_management.DAO;
using pharmacy_management.DTO;
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

        public ArrayList getActiveMaxuatxu()
        {
            list = dao.getActiveMaxuatxu();
            return list;
        }

        public void add(XuatXu DTO)
        {
            dao.add(DTO);
        }


        public void delete(int ma)
        {
            dao.Delete(ma);
        }

        public void update(XuatXu DTO)
        {
            dao.update(DTO);
        }

        public ArrayList searchatMa(string ma)
        {
            list = dao.searchatMa(ma);
            return list;
        }

        public ArrayList searchatTen(string ten)
        {
            list = dao.searchatTen(ten);
            return list;
        }

        public string GetNameBUS(int ma)
        {
            return dao.GetNameDAO(ma);
        }

        public int GetStateBUS(int ma)
        {
            return dao.GetStateDAO(ma);
        }
        public string GetNameatMaBUS(int ma)
        {
            return dao.GetNameatMaDAO(ma);
        }

        
    }
}
