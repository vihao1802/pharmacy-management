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
    public class NhanVienDAO
    {
        private ArrayList list;
        public NhanVienDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM nhanvien";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    NhanVien tmp = new NhanVien(
                        Int32.Parse(reader["MaNV"].ToString()),
                        reader["TenNV"].ToString(),
                        reader["SDT"].ToString(),
                        reader["DiaChi"].ToString(),
                        reader["Email"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString()),
                        reader["TenDangNhap"].ToString(),
                        reader["MatKhau"].ToString(),
                        Int32.Parse(reader["MaQuyen"].ToString())

                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error at NhanVienDAO: " + ex.Message);
            }

            return arrayList;

        }
    }
}
