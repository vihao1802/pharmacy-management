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
    public class XuatXuDAO
    {
        private ArrayList list;
        public XuatXuDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM xuatxu";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    XuatXu tmp = new XuatXu(
                        Int32.Parse(reader["MaXuatXu"].ToString()),
                        reader["TenXuatXu"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at XuatXuDAO: " + ex.Message);
            }

            return arrayList;

        }

        public string GetNameDAO(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string name = "";
            string query = "SELECT * FROM xuatxu WHERE MaXuatXu = " + ma.ToString();
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    name = reader["TenXuatXu"].ToString();
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
