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
                    
                    DateTime dateTime = DateTime.ParseExact(reader["NgayLap"].ToString(), "MM/dd/yyyy hh:mm:ss tt", null);
                    string outputString = dateTime.ToString("yyyy-MM-dd");
                    PhieuNhap tmp = new PhieuNhap(
                        Int32.Parse(reader["MaPN"].ToString()),
                        Int32.Parse(reader["MaNV"].ToString()),
                        outputString,
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
            string query = string.Format("SELECT * FROM PhieuNhap WHERE (MaPN LIKE '%{2}%' OR MaNV LIKE '%{2}%') AND NgayLap BETWEEN '{0}' AND '{1}'", dateStart, dateEnd, search);
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
                        outputString,
                        float.Parse(reader["tongTien"].ToString())
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
            string query = string.Format("SELECT * FROM PhieuNhap WHERE (MaPN LIKE '%{2}%' OR MaNV LIKE '%{2}%' ) AND NgayLap BETWEEN '{0}' AND '{1}' ORDER BY ThanhTien", dateStart, dateEnd, search);
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

                        outputString,
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
            string query = string.Format("SELECT * FROM PhieuNhap WHERE (MaPN LIKE '%{2}%' OR MaNV LIKE '%{2}%') AND NgayLap BETWEEN '{0}' AND '{1}' ORDER BY MaPN DESC", dateStart, dateEnd, search);
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
                       outputString,
                        float.Parse(reader["TongTien"].ToString())
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

        public void addNewInvoice(int maNV, string ngayLap, string tongTien)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("INSERT INTO PhieuNhap VALUES('{0}','{1}','{2}')", maNV, ngayLap, tongTien);
            conn.ExecuteNonQuery(query);
        }

        public PhieuNhap getItem()
        {
          //  DateTime date = DateTime.UtcNow();
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
