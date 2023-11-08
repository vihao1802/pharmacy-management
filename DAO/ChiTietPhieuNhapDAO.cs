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
            list = GetALl();
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
                Console.WriteLine("An error at ChiTietPhieuNhapDAO: " + ex.Message);
            }

            return arrayList;

        }
    }
}
