using pharmacy_management.DAO;
using pharmacy_management.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace pharmacy_management.BUS
{
    public class DoiTuongBUS
    {
        private DoiTuong DTO;
        private ArrayList list;
        private DoiTuongDAO dao;

        public DoiTuongBUS()
        {
            dao = new DoiTuongDAO();
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

        public ArrayList getActiveMadoituong()
        {
            list = dao.getActiveMadoituong();
            return list;
        }

        public void add(DoiTuong DTO)
        {
            dao.add(DTO);
        }
      
        
        public void delete(int ma)
        {
            dao.Delete(ma);
        }

        public void update(DoiTuong DTO)
        {
            dao.update(DTO);
        }

        public ArrayList search(string text)
        {
            list = dao.search(text);
            return list;
        }

        public int GetStateBUS(int ma)
        {
            return dao.GetStateDAO(ma);
        }
      
        public string GetNameBUS(int ma)
        {
            return dao.GetNameDAO(ma);
        }


        public string GetNameatMaBUS(int ma)
        {
            return dao.GetNameatMaDAO(ma);
        }
    }
}
