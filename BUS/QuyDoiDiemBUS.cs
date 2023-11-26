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
    public class QuyDoiDiemBUS
    {
        private ArrayList list;
        private QuyDoiDIemDAO dao;

        public QuyDoiDiemBUS()
        {
            dao = new QuyDoiDIemDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = dao.GetALlNotUse();
        }

        public void loadAll(string dateStart, string dateEnd, string search)
        {
            list = dao.GetALl(dateStart, dateEnd, search);
        }

        //public void loadWithCondition()
        //{
        //    list = dao.GetWithCondition();
        //}

        public void updateStatus(string ma)
        {
            dao.updateStatus(ma);
        }

        public QuyDoiDiem getQDD(int ma)
        {
            return dao.getQDD(ma);
        }

        public void insertItem(string maKH, string date)
        {
            dao.insertItem(maKH, date);
        }

        public QuyDoiDiem getItem()
        {
            return dao.getItem();
        }
    }
}
