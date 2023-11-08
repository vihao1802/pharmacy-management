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
    public class DiemKhachHangDAO
    {
        private ArrayList list;
        public DiemKhachHangDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM diemkhachhang";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {

                    DiemKhachHang tmp = new DiemKhachHang(
                        Int32.Parse(reader["MaBangDiem"].ToString()),
                        Int32.Parse(reader["MaKH"].ToString()),
                        Int32.Parse(reader["DiemTichLuy"].ToString()),
                        Int32.Parse(reader["DiemDaSuDung"].ToString())
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error at DiemKhachHangDAO: " + ex.Message);
            }

            return arrayList;

        }
    }
}
