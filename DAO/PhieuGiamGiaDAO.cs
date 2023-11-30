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
    public class PhieuGiamGiaDAO
    {
        private ArrayList list;
        public PhieuGiamGiaDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM phieugiamgia";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    PhieuGiamGia tmp = new PhieuGiamGia(
                        Int32.Parse(reader["MaPhieuGiam"].ToString()),
                        reader["MoTaPG"].ToString(),
                        Int32.Parse(reader["SoDiemQuyDoi"].ToString()),
                        Int32.Parse(reader["PhanTramGiam"].ToString()),
                        Int32.Parse(reader["MaQuyDoi"].ToString())
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at PhieuGiamGiaDAO: " + ex.Message);
            }

            return arrayList;

        }

        public PhieuGiamGia getItem(int ma)
        {
            PhieuGiamGia tmp = new PhieuGiamGia();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM phieugiamgia WHERE MaQuyDoi = '" + ma + "'";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    tmp = new PhieuGiamGia(
                        Int32.Parse(reader["MaPhieuGiam"].ToString()),
                        reader["MoTaPG"].ToString(),
                        Int32.Parse(reader["SoDiemQuyDoi"].ToString()),
                        Int32.Parse(reader["PhanTramGiam"].ToString()),
                        Int32.Parse(reader["MaQuyDoi"].ToString())
                    );
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at PhieuGiamGiaDAO getItem: " + ex.Message);
            }

            return tmp;

        }
        public ArrayList GetALlCondition(string search)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM phieugiamgia WHERE MoTaPG LIKE N'%{0}%'", search);
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    PhieuGiamGia tmp = new PhieuGiamGia(
                        Int32.Parse(reader["MaPhieuGiam"].ToString()),
                        reader["MoTaPG"].ToString(),
                        Int32.Parse(reader["SoDiemQuyDoi"].ToString()),
                        Int32.Parse(reader["PhanTramGiam"].ToString()),
                        Int32.Parse(reader["MaQuyDoi"].ToString())

                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at PhieuGiamGiaDAO get all condition: " + ex.Message);
            }

            return arrayList;

        }
        public string GetNameDAO(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string name = "";
            string query = "SELECT MoTaPG FROM phieugiamgia WHERE MaQuyDoi = " + ma.ToString();
            //Console.WriteLine(query);
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    name = reader["MoTaPG"].ToString();
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at PhieuGiamGiaDAO: " + ex.Message);
            }

            return name;
        }

        public string GetPhanTramGiamDAO(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string percent = "";
            string query = "SELECT PhanTramGiam FROM phieugiamgia WHERE MaQuyDoi = " + ma.ToString();
            //Console.WriteLine(query);
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    percent = reader["PhanTramGiam"].ToString();
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at PhieuGiamGiaDAO: " + ex.Message);
            }

            return percent;
        }

        public void insertItem(string mota, string diem, string phanTram, string maqd)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("INSERT INTO phieugiamgia VALUES(N'{0}','{1}','{2}','{3}')", mota, diem, phanTram, maqd);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }
    }
}
