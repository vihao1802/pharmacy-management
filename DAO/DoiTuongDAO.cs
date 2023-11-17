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
    public class DoiTuongDAO
    {
        private ArrayList list;
        public DoiTuongDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM doituong";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    DoiTuong tmp = new DoiTuong(
                        Int32.Parse(reader["MaDT"].ToString()),
                        reader["TenDT"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at DoiTuongDAO: " + ex.Message);
            }

            return arrayList;

        }

        public string GetNameDAO(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string name = "";
            string query = "SELECT * FROM doituong WHERE MaDT = " + ma.ToString();
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    name = reader["TenDT"].ToString();
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at DoiTuongDAO: " + ex.Message);
            }

            return name;
        }
    }
}
