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
    public class ThuocBUS
    {
        private ArrayList list;
        private ThuocDAO dao;


        public ThuocBUS()
        {
            dao = new ThuocDAO();
            //them vao
            loadList();
        }
        public ThuocBUS(string text_searching, int selected_doiTuong, int selected_xuatXu, int page_value, int perPage)
        {
            dao = new ThuocDAO();
            loadListAdVanced(text_searching, selected_doiTuong, selected_xuatXu, page_value, perPage);
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = dao.GetALl();
        }

        public void add(Thuoc Drug)
        {
            dao.add(Drug);
        }

        /* public ArrayList searchatMa(int ma)
         {
             list = dao.searchatMa(ma);
             return list;
         }

         public ArrayList searchatTen(string ten)
         {
             list = dao.searchatTen(ten);
             return list;
         }*/
        public void deleteatMaXuatXu(int ma)
        {
            dao.DeleteatMaXuatXu(ma);
        }

        public void deleteatMaDoiTuong(int ma)
        {
            dao.DeleteatMaDoiTuong(ma);
        }

        public ArrayList search(string text)
        {
            list = dao.search(text);
            return list;
        }



        public void update(Thuoc Drug)
        {
            dao.update(Drug);
        }

        public int getSizeList(string text_searching, int selected_doiTuong, int selected_xuatXu)
        {
            list = dao.GetAllAdvancedWithoutPaginateDAO(text_searching, selected_doiTuong, selected_xuatXu);
            return list.Count;
        }

        public void emptyList()
        {
            list.Clear();
        }

        public void loadListAdVanced(string text_searching, int selected_doiTuong, int selected_xuatXu, int page_value, int perPage)
        {
            list = dao.GetAllAdvancedDAO(text_searching, selected_doiTuong, selected_xuatXu, page_value, perPage);
        }


        public DTO.Thuoc getItem(int ma)
        {
            return dao.getItem(ma);
        }

        public DTO.Thuoc getLastItem()
        {
            return dao.getLastItem();
        }

        public void updateQuantity(int ma, int sl)
        {
            dao.updateQuantity(ma, sl);
        }

        public void addQuantity(int ma, int sl)
        {
            dao.addQuantity(ma, sl);
        }
        public void createTemp()
        {
            dao.createTemp();
        }
        public void Merge()
        {
            dao.Merge();
        }
        public void dropTempTable()
        {
            dao.dropTempTable();
        }
    }
}
