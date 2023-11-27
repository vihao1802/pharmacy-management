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

        public NhanVien getNhanVien(int ma)
        {
            return dao.getNhanVien(ma);
        }

        public void add(NhanVien DTO)
        {
            dao.add(DTO);
        }

        public void delete(int ma)
        {
            dao.delete(ma);
        }

        public void update(NhanVien DTO, int ma)
        {
            dao.update(DTO, ma);
        }
        public NhanVien checkMail(string mail)
        {
            return dao.checkMail(mail);
        }
    }
}
