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
    public class QuyenBUS
    {
        private ArrayList list;
        private QuyenDAO dao;

        public QuyenBUS()
        {
            dao = new QuyenDAO();
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

        public void add(Quyen DTO)
        {
            dao.add(DTO);
        }

        public void delete(int ma)
        {
            dao.delete(ma);
        }

        public void update(Quyen DTO, int ma)
        {
            dao.update(DTO, ma);
        }
    }
}
