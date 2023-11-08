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
    public class PhieuNhapDAO
    {
        private ArrayList list;
        public PhieuNhapDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM phieunhap";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    PhieuNhap tmp = new PhieuNhap(
                        Int32.Parse(reader["MaPN"].ToString()),
                        Int32.Parse(reader["MaNV"].ToString()),
                        DateTime.Parse(reader["NgayLap"].ToString()),
                        float.Parse(reader["TongTien"].ToString())
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error at PhieuNhapDAO: " + ex.Message);
            }

            return arrayList;

        }
    }
}
