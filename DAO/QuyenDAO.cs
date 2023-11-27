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
    public class QuyenDAO
    {
        private ArrayList list;
        public QuyenDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM quyen";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    Quyen tmp = new Quyen(
                        Int32.Parse(reader["MaQuyen"].ToString()),
                        reader["TenQuyen"].ToString()
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at QuyenDAO: " + ex.Message);
            }

            return arrayList;

        }

        public void add(Quyen DTO)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("INSERT INTO QUYEN (TenQuyen) VALUES (N'{0}')", DTO.TenQuyen);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public void delete(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string query = "DELETE FROM QUYEN WHERE MaQuyen = " + ma;
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public void update(Quyen DTO, int ma)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("UPDATE QUYEN SET TenQuyen = N'{0}' WHERE MaQuyen = {1}", DTO.TenQuyen, ma);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }
    }
}
