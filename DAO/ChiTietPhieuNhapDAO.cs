using pharmacy_management.Database;
using pharmacy_management.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.DAO
{
    public class ChiTietPhieuNhapDAO
    {
        private ArrayList list;
        public ChiTietPhieuNhapDAO()
        {
           // list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM chitietphieunhap";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    ChiTietPhieuNhap tmp = new ChiTietPhieuNhap(
                        Int32.Parse(reader["MaChiTietPN"].ToString()),
                        Int32.Parse(reader["MaPN"].ToString()),
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        Int32.Parse(reader["SoLuong"].ToString()),
                        float.Parse(reader["DonGia"].ToString()),
                        float.Parse(reader["ThanhTien"].ToString())
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at ChiTietPhieuNhapDAO: " + ex.Message);
            }

            return arrayList;

        }
        public ArrayList getListWithID(int ma)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM chitietphieunhap WHERE MaPN = '" + ma + "'";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    ChiTietPhieuNhap tmp = new ChiTietPhieuNhap(
                        Int32.Parse(reader["MaChiTietPN"].ToString()),
                        Int32.Parse(reader["MaPN"].ToString()),
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        Int32.Parse(reader["SoLuong"].ToString()),
                        float.Parse(reader["DonGia"].ToString()),
                        float.Parse(reader["ThanhTien"].ToString())
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();
                Console.WriteLine("An error at ChiTietPhieuNhapDAO getListWithID: " + ex.Message);
            }

            return arrayList;
        }
        public void addNewDetailInvoice(int maPN, int maThuoc, int soLuong, float gia, float thanhTien)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("INSERT INTO chitietphieunhap VALUES('{0}','{1}','{2}',{3},'{4}')", maPN, maThuoc, soLuong, gia, thanhTien);
            conn.ExecuteNonQuery(query);
        }
    }
}
