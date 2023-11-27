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
    public class KhachHangBUS
    {
        private ArrayList list;
        private KhachHangDAO dao;

        public KhachHangBUS()
        {
            dao = new KhachHangDAO();
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

        public KhachHang getKH(int ma)
        {
            return dao.getKH(ma);
        }

        public void add(KhachHang DTO)
        {
            dao.add(DTO);
        }

        public void delete(int ma)
        {
            dao.delete(ma);
        }

        public void update(KhachHang DTO, int ma)
        {
            dao.update(DTO, ma);
        }
    }
}
