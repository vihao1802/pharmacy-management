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
    public class ThuocDAO
    {
        private ArrayList list;
        public ThuocDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM thuoc";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    Thuoc tmp = new Thuoc(
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        reader["TenThuoc"].ToString(),
                        Int32.Parse(reader["MaDoiTuong"].ToString()),
                        float.Parse(reader["GiaThuoc"].ToString()),
                        reader["AnhThuoc"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString()),
                        Int32.Parse(reader["MaXuatXu"].ToString())
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error at QuyenDAO: " + ex.Message);
            }

            return arrayList;

        }
    }
}
