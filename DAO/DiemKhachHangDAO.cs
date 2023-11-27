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
    public class DiemKhachHangDAO
    {
        private ArrayList list;
        public DiemKhachHangDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM diemkhachhang";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {

                    DiemKhachHang tmp = new DiemKhachHang(
                        Int32.Parse(reader["MaBangDiem"].ToString()),
                        Int32.Parse(reader["MaKH"].ToString()),
                        Int32.Parse(reader["DiemTichLuy"].ToString()),
                        Int32.Parse(reader["DiemDaSuDung"].ToString())
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at DiemKhachHangDAO: " + ex.Message);
            }

            return arrayList;

        }

        public DiemKhachHang GetItem(string ma)
        {
            DiemKhachHang diemKH = new DiemKhachHang();
            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM diemkhachhang WHERE MaKH = '" + ma + "'";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                if (reader.Read())
                {
                    diemKH = new DiemKhachHang(
                        Int32.Parse(reader["MaBangDiem"].ToString()),
                        Int32.Parse(reader["MaKH"].ToString()),
                        Int32.Parse(reader["DiemTichLuy"].ToString()),
                        Int32.Parse(reader["DiemDaSuDung"].ToString())
                    );
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at DiemKhachHangDAO GetItem: " + ex.Message);
            }

            return diemKH;

        }

        public void updateDiemKH(string diem, string ma)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("UPDATE diemkhachhang SET DiemTichLuy = DiemTichLuy + {0} WHERE MaKH = '{1}'", diem, ma);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public void updateDiemKHSauQD(string diem, string ma)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("UPDATE diemkhachhang SET DiemTichLuy = {0} WHERE MaKH = '{1}'", diem, ma);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }

        public void add()
        {
            ConnectDB conn = new ConnectDB();

            // Step 1: Retrieve the latest ID from khachhang table
            string queryGetLatestID = "SELECT MAX(MaKH) AS LatestID FROM khachhang";
            object result = conn.ExecuteScalar(queryGetLatestID);

            int latestID;

            if (result != DBNull.Value)
            {
                latestID = Convert.ToInt32(result);
            }
            else
            {
                // Handle the case where the result is null or no records exist in khachhang table
                Console.WriteLine("No records found in khachhang table.");
                return;
            }


            // Thêm dòng vào bảng DIEMKHACHHANG
            string queryDiemKhachHang = string.Format("INSERT INTO DIEMKHACHHANG (MaKH, DiemTichLuy, DiemDaSuDung) VALUES ('{0}', {1}, {2})", latestID, 0, 0);
            Console.WriteLine(queryDiemKhachHang);
            conn.ExecuteNonQuery(queryDiemKhachHang);

        }
    }
}
