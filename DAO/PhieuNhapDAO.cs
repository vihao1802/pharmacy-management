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
                reader.Close();

                Console.WriteLine("An error at PhieuNhapDAO: " + ex.Message);
            }

            return arrayList;

        }
        public ArrayList GetALl(string dateStart, string dateEnd, string search)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM PhieuNhap WHERE (MaDH LIKE '%{2}%' OR MaNV LIKE '%{2}%' OR MaQuyDoi LIKE '%{2}%') AND NgayLap BETWEEN '{0}' AND '{1}'", dateStart, dateEnd, search);
            SqlDataReader reader = conn.Execute(query);
            Console.WriteLine(query);
            try
            {
                while (reader.Read())
                {
                  

                    DateTime dateTime = DateTime.ParseExact(reader["NgayLap"].ToString(), "MM/dd/yyyy hh:mm:ss tt", null);
                    string outputString = dateTime.ToString("yyyy-MM-dd");
                    Console.WriteLine(outputString);


                    PhieuNhap tmp = new PhieuNhap(
                        Int32.Parse(reader["MaDH"].ToString()),
                        Int32.Parse(reader["MaNV"].ToString()),
                        DateTime.Parse(reader["NgayLap"].ToString()),
                        float.Parse(reader["ThanhTien"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at PhieuNhapDAO getAll: " + ex.Message);
            }

            return arrayList;

        }


        public ArrayList GetALlPriceAscend(string dateStart, string dateEnd, string search)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM PhieuNhap WHERE (MaPN LIKE '%{2}%' OR MaNV LIKE '%{2}%' OR MaQuyDoi LIKE '%{2}%') AND NgayLap BETWEEN '{0}' AND '{1}' ORDER BY ThanhTien", dateStart, dateEnd, search);
            SqlDataReader reader = conn.Execute(query);
            Console.WriteLine(query);

            try
            {
                while (reader.Read())
                {
                

                    DateTime dateTime = DateTime.ParseExact(reader["NgayLap"].ToString(), "MM/dd/yyyy hh:mm:ss tt", null);
                    string outputString = dateTime.ToString("yyyy-MM-dd");
                    Console.WriteLine(outputString);


                    PhieuNhap tmp = new PhieuNhap(
                        Int32.Parse(reader["MaPN"].ToString()),
                        Int32.Parse(reader["MaNV"].ToString()),

                       DateTime.Parse(reader["NgayLap"].ToString()),
                        float.Parse(reader["ThanhTien"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at PhieuNhapDAO getAll: " + ex.Message);
            }

            return arrayList;

        }

        public ArrayList GetALlIdDescend(string dateStart, string dateEnd, string search)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM PhieuNhap WHERE (MaPN LIKE '%{2}%' OR MaNV LIKE '%{2}%' OR MaQuyDoi LIKE '%{2}%') AND NgayLap BETWEEN '{0}' AND '{1}' ORDER BY MaDH DESC", dateStart, dateEnd, search);
            SqlDataReader reader = conn.Execute(query);
            Console.WriteLine(query);

            try
            {
                while (reader.Read())
                {
                 

                    DateTime dateTime = DateTime.ParseExact(reader["NgayLap"].ToString(), "MM/dd/yyyy hh:mm:ss tt", null);
                    string outputString = dateTime.ToString("yyyy-MM-dd");
                    Console.WriteLine(outputString);


                    PhieuNhap tmp = new PhieuNhap(
                        Int32.Parse(reader["MaPN"].ToString()),
                        Int32.Parse(reader["MaNV"].ToString()),
                        float.Parse(reader["TongGia"].ToString()),
                        float.Parse(reader["ThanhTien"].ToString())
                     ); 
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at PhieuNhapDAO getAll: " + ex.Message);
            }

            return arrayList;

        }

        public void addNewInvoice(string maNV, string maKH, string ngayLap, string maQD, string tongGia, string thanhTien)
        {
            ConnectDB conn = new ConnectDB();
            Console.WriteLine(maQD);
            string query = string.Format("INSERT INTO PhieuNhap VALUES('{0}','{1}','{2}',{3})", maNV, ngayLap,  tongGia, thanhTien);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public PhieuNhap getItem()
        {
            PhieuNhap dh = new PhieuNhap(0, 0, "2020-02-2", 0);
            ConnectDB conn = new ConnectDB();
            string query = "SELECT TOP 1 MaPN FROM PhieuNhap ORDER BY MaPN DESC";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                if (reader.Read())
                {
                    dh = new PhieuNhap(
                        Int32.Parse(reader["MaPN"].ToString()),
                        0,
                       "2020-02-02",
                        0
                       
                     );

                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at PhieuNhapDAO getItem: " + ex.Message);
            }

            return dh;
        }
    }
}
