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
    public class DonHangDAO
    {
        private ArrayList list;
        public DonHangDAO()
        {
            //list = GetALl();
        }

        public ArrayList GetALl(string dateStart, string dateEnd, string search)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM donhang WHERE (MaDH LIKE '%{2}%' OR MaKH LIKE '%{2}%' OR MaNV LIKE '%{2}%' OR MaQuyDoi LIKE '%{2}%') AND NgayLap BETWEEN '{0}' AND '{1}'", dateStart, dateEnd, search);
            SqlDataReader reader = conn.Execute(query);
            Console.WriteLine(query);
            try
            {
                while (reader.Read())
                {
                    string maTmp = reader["MaQuyDoi"].ToString();
                    if (maTmp == "" || maTmp == null)
                    {
                        maTmp = "0";
                    }

                    DateTime dateTime = DateTime.ParseExact(reader["NgayLap"].ToString(), "MM/dd/yyyy hh:mm:ss tt", null);
                    string outputString = dateTime.ToString("yyyy-MM-dd");
                    Console.WriteLine(outputString);


                    Console.WriteLine(maTmp);
                    DonHang tmp = new DonHang(
                        Int32.Parse(reader["MaDH"].ToString()),
                        Int32.Parse(reader["MaNV"].ToString()),
                        Int32.Parse(reader["MaKH"].ToString()),
                        outputString,
                        Int32.Parse(maTmp),
                        float.Parse(reader["TongGia"].ToString()),
                        float.Parse(reader["ThanhTien"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at DonHangDAO getAll: " + ex.Message);
            }

            return arrayList;

        }


        public ArrayList GetALlPriceAscend(string dateStart, string dateEnd, string search)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM donhang WHERE (MaDH LIKE '%{2}%' OR MaKH LIKE '%{2}%' OR MaNV LIKE '%{2}%' OR MaQuyDoi LIKE '%{2}%') AND NgayLap BETWEEN '{0}' AND '{1}' ORDER BY ThanhTien", dateStart, dateEnd, search);
            SqlDataReader reader = conn.Execute(query);
            Console.WriteLine(query);

            try
            {
                while (reader.Read())
                {
                    string maTmp = reader["MaQuyDoi"].ToString();
                    if (maTmp == "" || maTmp == null)
                    {
                        maTmp = "0";
                    }

                    DateTime dateTime = DateTime.ParseExact(reader["NgayLap"].ToString(), "MM/dd/yyyy hh:mm:ss tt", null);
                    string outputString = dateTime.ToString("yyyy-MM-dd");
                    Console.WriteLine(outputString);


                    Console.WriteLine(maTmp);
                    DonHang tmp = new DonHang(
                        Int32.Parse(reader["MaDH"].ToString()),
                        Int32.Parse(reader["MaNV"].ToString()),
                        Int32.Parse(reader["MaKH"].ToString()),
                        outputString,
                        Int32.Parse(maTmp),
                        float.Parse(reader["TongGia"].ToString()),
                        float.Parse(reader["ThanhTien"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at DonHangDAO getAll: " + ex.Message);
            }

            return arrayList;

        }

        public ArrayList GetALlIdDescend(string dateStart, string dateEnd, string search)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM donhang WHERE (MaDH LIKE '%{2}%' OR MaKH LIKE '%{2}%' OR MaNV LIKE '%{2}%' OR MaQuyDoi LIKE '%{2}%') AND NgayLap BETWEEN '{0}' AND '{1}' ORDER BY MaDH DESC", dateStart, dateEnd, search);
            SqlDataReader reader = conn.Execute(query);
            Console.WriteLine(query);

            try
            {
                while (reader.Read())
                {
                    string maTmp = reader["MaQuyDoi"].ToString();
                    if (maTmp == "" || maTmp == null)
                    {
                        maTmp = "0";
                    }

                    DateTime dateTime = DateTime.ParseExact(reader["NgayLap"].ToString(), "MM/dd/yyyy hh:mm:ss tt", null);
                    string outputString = dateTime.ToString("yyyy-MM-dd");
                    Console.WriteLine(outputString);


                    Console.WriteLine(maTmp);
                    DonHang tmp = new DonHang(
                        Int32.Parse(reader["MaDH"].ToString()),
                        Int32.Parse(reader["MaNV"].ToString()),
                        Int32.Parse(reader["MaKH"].ToString()),
                        outputString,
                        Int32.Parse(maTmp),
                        float.Parse(reader["TongGia"].ToString()),
                        float.Parse(reader["ThanhTien"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at DonHangDAO getAll: " + ex.Message);
            }

            return arrayList;

        }

        public void addNewInvoice(string maNV, string maKH, string ngayLap, string maQD, string tongGia, string thanhTien)
        {
            ConnectDB conn = new ConnectDB();
            Console.WriteLine(maQD);
            string query = string.Format("INSERT INTO donhang VALUES('{0}','{1}','{2}',{3},'{4}','{5}')", maNV, maKH, ngayLap, maQD, tongGia, thanhTien);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public DonHang getItem()
        {
            DonHang dh = new DonHang(0, 0, 0, "2020-02-2", 0, 0, 0);
            ConnectDB conn = new ConnectDB();
            string query = "SELECT TOP 1 MaDH FROM donhang ORDER BY MaDH DESC";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                if (reader.Read())
                {
                    dh = new DonHang(
                        Int32.Parse(reader["MaDH"].ToString()),
                        0,
                        0,
                        "2020-02-02",
                        0,
                        0,
                        0
                     );

                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at DonHangDAO getItem: " + ex.Message);
            }

            return dh;
        }
    }
}
