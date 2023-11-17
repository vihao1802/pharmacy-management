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
    public class ChiTietDonHangDAO
    {
        private ArrayList list;
        public ChiTietDonHangDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM chitietdonhang";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    ChiTietDonHang tmp = new ChiTietDonHang(
                        Int32.Parse(reader["MaChiTietDH"].ToString()),
                        Int32.Parse(reader["MaDH"].ToString()),
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
                Console.WriteLine("An error at ChiTietDonHangDAO: " + ex.Message);
            }

            return arrayList;

        }

        public void addNewDetailInvoice(int maDH, int maThuoc, int soLuong, float gia, float thanhTien)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("INSERT INTO chitietdonhang VALUES('{0}','{1}','{2}',{3},'{4}')", maDH, maThuoc, soLuong, gia, thanhTien);
            conn.ExecuteNonQuery(query);
        }
    }
}
