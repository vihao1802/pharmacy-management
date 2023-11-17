using Microsoft.SqlServer.Server;
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
    public class DonHangBUS
    {
        private ArrayList list;
        private DonHangDAO dao;

        public DonHangBUS()
        {
            dao = new DonHangDAO();
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

        public void addNewInvoice(string maNV, string maKH, string ngayLap, string maQD, string tongGia, string thanhTien)
        {
            dao.addNewInvoice(maNV, maKH, ngayLap, maQD, tongGia, thanhTien);
        }

        public DonHang getItem()
        {
            return dao.getItem();
        }
    }
}
