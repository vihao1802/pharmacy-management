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
    public class PhieuGiamGiaBUS
    {
        private ArrayList list;
        private PhieuGiamGiaDAO dao;

        public PhieuGiamGiaBUS()
        {
            dao = new PhieuGiamGiaDAO();
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

        public void loadListCondition(string search)
        {
            list = dao.GetALlCondition(search);
        }

        public string GetNameBUS(int ma)
        {
            return dao.GetNameDAO(ma);
        }

        public string getPhanTramGiamBUS(int ma)
        {
            return dao.GetPhanTramGiamDAO(ma);
        }

        public PhieuGiamGia getItem(int ma)
        {
            return dao.getItem(ma);
        }

        public void insertItem(string mota, string diem, string phanTram, string maqd)
        {
            dao.insertItem(mota, diem, phanTram, maqd);
        }
    }
}
