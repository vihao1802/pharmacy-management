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
    public class KhachHangDAO
    {
        private ArrayList list;
        public KhachHangDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM khachhang";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    KhachHang tmp = new KhachHang(
                        Int32.Parse(reader["MaKH"].ToString()),
                        reader["TenKH"].ToString(),
                        reader["SDT"].ToString(),
                        DateTime.Parse(reader["NgaySinh"].ToString()),
                        Int32.Parse(reader["TrangThai"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at KhachHangDAO: " + ex.Message);
            }

            return arrayList;

        }
    }
}
