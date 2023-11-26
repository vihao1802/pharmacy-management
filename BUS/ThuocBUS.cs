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


        public void delete(int ma)
        {
            dao.Delete(ma);
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

        public void updateQuantity(int ma, int sl)
        {
            dao.updateQuantity(ma, sl);
        }

        public void addQuantity(int ma, int sl)
        {
            dao.addQuantity(ma, sl);
        }
    }
}
