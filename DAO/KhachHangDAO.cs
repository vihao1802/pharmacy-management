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

        public ArrayList GetALlActive()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM khachhang WHERE TrangThai = '1'";
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

        public KhachHang getKH(int ma)
        {
            KhachHang kh = new KhachHang();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM khachhang WHERE MaKH = '" + ma + "'";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                if (reader.Read())
                {
                    kh = new KhachHang(
                        Int32.Parse(reader["MaKH"].ToString()),
                        reader["TenKH"].ToString(),
                        reader["SDT"].ToString(),
                        DateTime.Parse(reader["NgaySinh"].ToString()),
                        Int32.Parse(reader["TrangThai"].ToString())
                     );
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at KhachHangDAO: " + ex.Message);
            }

            return kh;

        }

        public void add(KhachHang DTO)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("INSERT INTO KHACHHANG (TenKH, SDT, NgaySinh, TrangThai) VALUES (N'{0}', '{1}', '{2}', {3})", DTO.TenKH, DTO.Sdt, DTO.NgaySinh, 1);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public void delete(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string query = "UPDATE KHACHHANG SET TrangThai = 0 WHERE MaKH = " + ma;
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public void update(KhachHang DTO, int ma)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("UPDATE KHACHHANG SET TenKH = N'{0}', SDT = '{1}', NgaySinh = '{2}', TrangThai = {3} WHERE MaKH = {4}", DTO.TenKH, DTO.Sdt, DTO.NgaySinh, DTO.TrangThai, ma);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public ArrayList search(string search)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM KHACHHANG WHERE (MaKH  LIKE '%{0}%' OR TenKH LIKE N'%{0}%' OR SDT LIKE '%{0}%' OR NgaySinh LIKE '%{0}%')",  search);
            SqlDataReader reader = conn.Execute(query);
            Console.WriteLine(query);
            try
            {
                while (reader.Read())
                {
                    DTO.KhachHang kh = new KhachHang(
                        Int32.Parse(reader["MaKH"].ToString()),
                        reader["TenKH"].ToString(),
                        reader["SDT"].ToString(),
                        DateTime.Parse(reader["NgaySinh"].ToString()),
                        Int32.Parse(reader["TrangThai"].ToString())
                     );
                    arrayList.Add(kh);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at KhachHang: " + ex.Message);
            }

            return arrayList;

        }
    }
}
