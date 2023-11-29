using pharmacy_management.Database;
using pharmacy_management.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
        public int GetStateDAO(int ma)
        {
            ConnectDB conn = new ConnectDB();
            int state = 0;
            string query = "SELECT TRANGTHAI FROM xuatxu WHERE MaXuatXu = " + ma.ToString();
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    if (reader["TrangThai"] != DBNull.Value)
                        state = Convert.ToInt32(reader["TrangThai"].ToString());
                    else MessageBox.Show("Ma xuat xu khong ton tai");
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at XuatXuDAO: " + ex.Message);
            }

            return state;
        }

       

        public ArrayList search(string text)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM xuatxu WHERE TenXuatXu LIKE N'%{0}%' OR MaXuatXu LIKE '{0}'",text);
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


        public string GetNameatMaDAO(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string name = "";
            string query = "SELECT TenXuatXu FROM xuatxu WHERE MaXuatXu = " + ma.ToString();
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

        public void add(XuatXu DTO)
        {
            ConnectDB conn = new ConnectDB();
            string sql = "INSERT INTO XUATXU VALUES (N'" + DTO.TenXuatXu + "', " + "1" + ")";
            conn.ExecuteNonQuery(sql);
        }

        public void Delete(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string sql = "UPDATE XUATXU SET TrangThai = 0 WHERE MaXuatXu = " + ma;
            conn.ExecuteNonQuery(sql);
        }

        public void update(XuatXu DTO)
        {
            ConnectDB conn = new ConnectDB();
            string sql = "UPDATE XUATXU SET TenXuatXu =N'" + DTO.TenXuatXu + "',TrangThai='" + DTO.TrangThai + "' where MaXuatXu = " + DTO.MaXuatXu;
            conn.ExecuteNonQuery(sql);
        }

        public ArrayList getActiveMaxuatxu()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM xuatxu Where TrangThai = 1";
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

                Console.WriteLine("An error at XuatXuDAO: " + ex.Message);
            }

            return name;
        }
    }
}
