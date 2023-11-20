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
    public class QuyDoiDIemDAO
    {
        private ArrayList list;
        public QuyDoiDIemDAO()
        {
            //list = GetALl();
        }
        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM quydoidiem";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    QuyDoiDiem tmp = new QuyDoiDiem(
                        Int32.Parse(reader["MaQuyDoi"].ToString()),
                        Int32.Parse(reader["MaKH"].ToString()),
                        DateTime.Parse(reader["NgayQuyDoi"].ToString()),
                        Int32.Parse(reader["MaPhieuGiam"].ToString()),
                        Int32.Parse(reader["DaSuDung"].ToString())

                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at QuyDoiDiemDAO GetALl: " + ex.Message);
            }

            return arrayList;

        }
        public ArrayList GetALlNotUse()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM quydoidiem WHERE DaSuDung = 0";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    QuyDoiDiem tmp = new QuyDoiDiem(
                        Int32.Parse(reader["MaQuyDoi"].ToString()),
                        Int32.Parse(reader["MaKH"].ToString()),
                        DateTime.Parse(reader["NgayQuyDoi"].ToString()),
                        Int32.Parse(reader["MaPhieuGiam"].ToString()),
                        Int32.Parse(reader["DaSuDung"].ToString())

                    );
                    //Console.WriteLine(reader["NgayQuyDoi"].ToString());
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at QuyDoiDiemDAO GetALlNotUse: " + ex.Message);
            }

            return arrayList;

        }

        public void updateStatus(string ma)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("UPDATE quydoidiem SET DaSuDung = '1' WHERE MaQuyDoi = '{0}'", ma);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public QuyDoiDiem getQDD(int ma)
        {
            QuyDoiDiem qdd = new QuyDoiDiem();
            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM quydoidiem WHERE MaQuyDoi = '" + ma + "'";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                if (reader.Read())
                {
                    qdd = new QuyDoiDiem(
                        Int32.Parse(reader["MaQuyDoi"].ToString()),
                        Int32.Parse(reader["MaKH"].ToString()),
                        DateTime.Parse(reader["NgayQuyDoi"].ToString()),
                        Int32.Parse(reader["MaPhieuGiam"].ToString()),
                        Int32.Parse(reader["DaSuDung"].ToString())

                    );
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at QuyDoiDiemDAO getQDD: " + ex.Message);
            }

            return qdd;
        }
    }
}
