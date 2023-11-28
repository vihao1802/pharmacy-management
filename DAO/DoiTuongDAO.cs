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
    public class DoiTuongDAO
    {
        private ArrayList list;
        private DoiTuong DTO;
        public DoiTuongDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM doituong ";
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

        public int GetStateDAO(int ma)
        {
            ConnectDB conn = new ConnectDB();
            int state = 0;
            string query = "SELECT TRANGTHAI FROM doituong WHERE MaDT = " + ma.ToString();
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    state = Convert.ToInt32(reader["TrangThai"].ToString());
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at DoiTuongDAO: " + ex.Message);
            }

            return state;
        }

        public ArrayList getActiveMadoituong()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM doituong Where TrangThai = 1";
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
            string query = "SELECT * FROM doituong WHERE MaDT = " + ma;
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

        public string GetNameatMaDAO(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string name = "";
            string query = "SELECT TenDT FROM doituong WHERE MaDT = " + ma.ToString();
            name = name += conn.Execute(query);
            return name;
        }

        public void add(DoiTuong DTO)
        {
            ConnectDB conn = new ConnectDB();
            try
            {
                string sql = "INSERT INTO DOITUONG VALUES (N'" + DTO.TenDT + "', " + "1" + ")";
                conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)           
                {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void Delete(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string sql = "UPDATE DOITUONG SET TrangThai = 0 WHERE MaDT = " + ma;
            conn.ExecuteNonQuery(sql);
        }

        public void update(DoiTuong DTO)
        {
            ConnectDB conn = new ConnectDB();
            string sql = "UPDATE DOITUONG SET TENDT =N'" + DTO.TenDT + "',TrangThai='" + DTO.TrangThai + "' where MaDT = " + DTO.MaDT;
            conn.ExecuteNonQuery(sql);
        }

        public ArrayList searchatMa(int ma)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM DoiTuong WHERE MaDT = " + ma;
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

        public ArrayList searchatTen(string ten)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM DoiTuong WHERE TenDT LIKE N'%" + ten + "%'";
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
    }
}
