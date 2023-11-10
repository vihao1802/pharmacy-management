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
                        Int32.Parse(reader["ThoiHan"].ToString())
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
    }
}
