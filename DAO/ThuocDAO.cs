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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pharmacy_management.DAO
{
    public class ThuocDAO
    {
        private ArrayList list;
        public ThuocDAO()
        {
            list = GetALl();
        }

        public ArrayList GetALl()
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM thuoc";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    Thuoc tmp = new Thuoc(
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        reader["TenThuoc"].ToString(),
                        Int32.Parse(reader["MaDoiTuong"].ToString()),
                        float.Parse(reader["GiaThuoc"].ToString()),
                        reader["AnhThuoc"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString()),
                        Int32.Parse(reader["MaXuatXu"].ToString()),
                        Int32.Parse(reader["SoLuong"].ToString())
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();
                Console.WriteLine("An error at ThuocDAO: " + ex.Message);
            }

            return arrayList;

        }

        /* public ArrayList GetAllAdvancedWithoutPaginateDAO(string text_searching, int selected_doiTuong, int selected_xuatXu)
         {
             ArrayList arrayList = new ArrayList();

             ConnectDB conn = new ConnectDB();
             string query = "";
             if (text_searching == "")
             {
                 if (selected_doiTuong <= 0)
                 {
                     if (selected_xuatXu <= 0)
                     {
                         query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND xuatxu.TrangThai = '1'");
                     }
                     else
                     {
                         query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND  thuoc.MaXuatXu = '{0}' AND xuatxu.TrangThai = '1'", selected_xuatXu);
                     }

                 }
                 else
                 {
                     if (selected_xuatXu <= 0)
                     {
                         query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND  thuoc.MaDoiTuong = '{0}' AND xuatxu.TrangThai = '1'", selected_doiTuong);
                     }
                     else
                     {
                         query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND  thuoc.MaDoiTuong = '{0}' AND  thuoc.MaXuatXu = '{1}' AND xuatxu.TrangThai = '1'", selected_doiTuong, selected_xuatXu);
                     }
                 }
             }
             else
             {
                 if (selected_doiTuong <= 0)
                 {
                     if (selected_xuatXu <= 0)
                     {
                         query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND TenThuoc LIKE N'%{0}%' AND xuatxu.TrangThai = '1'", text_searching);
                     }
                     else
                     {
                         query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND TenThuoc LIKE N'%{1}%' AND xuatxu.TrangThai = '1' AND thuoc.MaXuatXu = '{0}'", selected_xuatXu, text_searching);
                     }

                 }
                 else
                 {
                     if (selected_xuatXu <= 0)
                     {
                         query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND TenThuoc LIKE N'%{1}%' AND xuatxu.TrangThai = '1' AND thuoc.MaDoiTuong = '{0}'", selected_doiTuong, text_searching);
                     }
                     else
                     {
                         query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND TenThuoc LIKE N'%{2}%' AND xuatxu.TrangThai = '1' AND thuoc.MaDoiTuong = '{0}' AND thuoc.MaXuatXu = '{1}'", selected_doiTuong, selected_xuatXu, text_searching);
                     }
                 }
             }

             Console.WriteLine("at GetAllAdvancedWithoutPaginateDAO: " + query);
             SqlDataReader reader = conn.Execute(query);
             try
             {
                 while (reader.Read())
                 {
                     Thuoc tmp = new Thuoc(
                         Int32.Parse(reader["MaThuoc"].ToString()),
                         reader["TenThuoc"].ToString(),
                         Int32.Parse(reader["MaDoiTuong"].ToString()),
                         float.Parse(reader["GiaThuoc"].ToString()),
                         reader["AnhThuoc"].ToString(),
                         Int32.Parse(reader["TrangThai"].ToString()),
                         Int32.Parse(reader["MaXuatXu"].ToString()),
                         Int32.Parse(reader["SoLuong"].ToString())
                     );
                     arrayList.Add(tmp);

                 }
             }
             catch (Exception ex)
             {
                 reader.Close();
                 Console.WriteLine("An error at ThuocDAO: " + ex.Message);
             }

             return arrayList;

         }*/
        public ArrayList GetAllAdvancedWithoutPaginateDAO(string text_searching, int selected_doiTuong, int selected_xuatXu)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "";
            if (text_searching == "")
            {
                if (selected_doiTuong <= 0)
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TrangThai = '1'");
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TrangThai = '1' AND MaXuatXu = '{0}'", selected_xuatXu);
                    }

                }
                else
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TrangThai = '1' AND MaDoiTuong = '{0}'", selected_doiTuong);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TrangThai = '1' AND MaDoiTuong = '{0}' AND MaXuatXu = '{1}'", selected_doiTuong, selected_xuatXu);
                    }
                }
            }
            else
            {
                if (selected_doiTuong <= 0)
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TenThuoc LIKE N'%{0}%' AND TrangThai = '1'", text_searching);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TenThuoc LIKE N'%{1}%' AND TrangThai = '1' AND MaXuatXu = '{0}'", selected_xuatXu, text_searching);
                    }

                }
                else
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TenThuoc LIKE N'%{1}%' AND TrangThai = '1' AND MaDoiTuong = '{0}'", selected_doiTuong, text_searching);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TenThuoc LIKE N'%{2}%' AND TrangThai = '1' AND MaDoiTuong = '{0}' AND MaXuatXu = '{1}'", selected_doiTuong, selected_xuatXu, text_searching);
                    }
                }
            }

            Console.WriteLine("at GetAllAdvancedWithoutPaginateDAO: " + query);
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    Thuoc tmp = new Thuoc(
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        reader["TenThuoc"].ToString(),
                        Int32.Parse(reader["MaDoiTuong"].ToString()),
                        float.Parse(reader["GiaThuoc"].ToString()),
                        reader["AnhThuoc"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString()),
                        Int32.Parse(reader["MaXuatXu"].ToString()),
                        Int32.Parse(reader["SoLuong"].ToString())
                    );
                    arrayList.Add(tmp);

                }
            }
            catch (Exception ex)
            {
                reader.Close();
                Console.WriteLine("An error at ThuocDAO: " + ex.Message);
            }

            return arrayList;

        }
        public ArrayList search(string text)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM thuoc INNER JOIN xuatxu ON thuoc.MaXuatXu = xuatxu.MaXuatXu INNER JOIN doituong ON doituong.MaDT = thuoc.MaDoiTuong WHERE (xuatxu.TenXuatXu LIKE N'%{0}%' or doituong.TenDT  LIKE N'%{0}%' or thuoc.TenThuoc LIKE N'%{0}%')", text);

            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    Thuoc tmp = new Thuoc(
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        reader["TenThuoc"].ToString(),
                        Int32.Parse(reader["MaDoiTuong"].ToString()),
                        float.Parse(reader["GiaThuoc"].ToString()),
                        reader["AnhThuoc"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString()),
                        Int32.Parse(reader["MaXuatXu"].ToString()),
                        Int32.Parse(reader["SoLuong"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at ThuocDAO: " + ex.Message);
            }

            return arrayList;
        }

        /*public ArrayList searchatMa(int ma)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM Thuoc WHERE MaThuoc = " + ma;
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    Thuoc tmp = new Thuoc(
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        reader["TenThuoc"].ToString(),
                        Int32.Parse(reader["MaDoiTuong"].ToString()),
                        float.Parse(reader["GiaThuoc"].ToString()),
                        reader["AnhThuoc"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString()),
                        Int32.Parse(reader["MaXuatXu"].ToString()),
                        Int32.Parse(reader["SoLuong"].ToString())
                     );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at ThuocDAO: " + ex.Message);
            }

            return arrayList;
        }

        public ArrayList searchatTen(string ten)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "SELECT * FROM Thuoc WHERE TenThuoc LIKE N'%" + ten + "%'";
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    Thuoc tmp = new Thuoc(
                       Int32.Parse(reader["MaThuoc"].ToString()),
                       reader["TenThuoc"].ToString(),
                       Int32.Parse(reader["MaDoiTuong"].ToString()),
                       float.Parse(reader["GiaThuoc"].ToString()),
                       reader["AnhThuoc"].ToString(),
                       Int32.Parse(reader["TrangThai"].ToString()),
                       Int32.Parse(reader["MaXuatXu"].ToString()),
                       Int32.Parse(reader["SoLuong"].ToString())
                    );
                    arrayList.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                reader.Close();

                Console.WriteLine("An error at ThuocDAO: " + ex.Message);
            }

            return arrayList;
        }*/

        /*public ArrayList GetAllAdvancedDAO(string text_searching, int selected_doiTuong, int selected_xuatXu, int page_value, int perPage)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "";
            int start = (page_value - 1) * perPage;

            if (text_searching == "")
            {
                if (selected_doiTuong <= 0)
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND xuatxu.TrangThai = '1' ORDER BY MaThuoc OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", start, perPage);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND xuatxu.TrangThai = '1' AND thuoc.MaXuatXu = '{0}'  ORDER BY MaThuoc OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY", selected_xuatXu, start, perPage);
                    }

                }
                else
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND xuatxu.TrangThai = '1' AND thuoc.MaDoiTuong = '{0}' ORDER BY MaThuoc OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY", selected_doiTuong, start, perPage);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND xuatxu.TrangThai = '1' AND thuoc.MaDoiTuong = '{0}' AND thuoc.MaXuatXu = '{1}'  ORDER BY MaThuoc OFFSET {2} ROWS FETCH NEXT {3} ROWS ONLY", selected_doiTuong, selected_xuatXu, start, perPage);
                    }
                }
            }
            else
            {
                if (selected_doiTuong <= 0)
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND TenThuoc LIKE N'%{2}%' AND xuatxu.TrangThai = '1' ORDER BY MaThuoc OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", start, perPage, text_searching);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND TenThuoc LIKE N'%{3}%' AND xuatxu.TrangThai = '1' AND thuoc.MaXuatXu = '{0}'  ORDER BY MaThuoc OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY", selected_xuatXu, start, perPage, text_searching);
                    }

                }
                else
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND TenThuoc LIKE N'%{3}%' AND xuatxu.TrangThai = '1' AND thuoc.MaDoiTuong = '{0}' ORDER BY MaThuoc OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY", selected_doiTuong, start, perPage, text_searching);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc inner join doituong on thuoc.MaDoiTuong = doituong.MaDT inner join xuatxu on thuoc.MaXuatXu = xuatxu.MaXuatXu WHERE doituong.TrangThai = '1' AND thuoc.TrangThai ='1' AND TenThuoc LIKE N'%{4}%' AND xuatxu.TrangThai = '1' AND thuoc.MaDoiTuong = '{0}' AND thuoc.MaXuatXu = '{1}'  ORDER BY MaThuoc OFFSET {2} ROWS FETCH NEXT {3} ROWS ONLY", selected_doiTuong, selected_xuatXu, start, perPage, text_searching);
                    }
                }
            }


            //Console.WriteLine(query);
            //Console.WriteLine(text_searching);
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    Thuoc tmp = new Thuoc(
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        reader["TenThuoc"].ToString(),
                        Int32.Parse(reader["MaDoiTuong"].ToString()),
                        float.Parse(reader["GiaThuoc"].ToString()),
                        reader["AnhThuoc"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString()),
                        Int32.Parse(reader["MaXuatXu"].ToString()),
                        Int32.Parse(reader["SoLuong"].ToString())
                    );

                    arrayList.Add(tmp);

                }
            }
            catch (Exception ex)
            {
                reader.Close();
                Console.WriteLine("An error at ThuocDAO: " + ex.Message);
            }

            return arrayList;

        }
*/
        public ArrayList GetAllAdvancedDAO(string text_searching, int selected_doiTuong, int selected_xuatXu, int page_value, int perPage)
        {
            ArrayList arrayList = new ArrayList();

            ConnectDB conn = new ConnectDB();
            string query = "";
            int start = (page_value - 1) * perPage;

            if (text_searching == "")
            {
                if (selected_doiTuong <= 0)
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TrangThai = '1' ORDER BY MaThuoc OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", start, perPage);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TrangThai = '1' AND MaXuatXu = '{0}'  ORDER BY MaThuoc OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY", selected_xuatXu, start, perPage);
                    }

                }
                else
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TrangThai = '1' AND MaDoiTuong = '{0}' ORDER BY MaThuoc OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY", selected_doiTuong, start, perPage);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TrangThai = '1' AND MaDoiTuong = '{0}' AND MaXuatXu = '{1}'  ORDER BY MaThuoc OFFSET {2} ROWS FETCH NEXT {3} ROWS ONLY", selected_doiTuong, selected_xuatXu, start, perPage);
                    }
                }
            }
            else
            {
                if (selected_doiTuong <= 0)
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TenThuoc LIKE N'%{2}%' AND TrangThai = '1' ORDER BY MaThuoc OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", start, perPage, text_searching);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TenThuoc LIKE N'%{3}%' AND TrangThai = '1' AND MaXuatXu = '{0}'  ORDER BY MaThuoc OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY", selected_xuatXu, start, perPage, text_searching);
                    }

                }
                else
                {
                    if (selected_xuatXu <= 0)
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TenThuoc LIKE N'%{3}%' AND TrangThai = '1' AND MaDoiTuong = '{0}' ORDER BY MaThuoc OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY", selected_doiTuong, start, perPage, text_searching);
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM thuoc WHERE TenThuoc LIKE N'%{4}%' AND TrangThai = '1' AND MaDoiTuong = '{0}' AND MaXuatXu = '{1}'  ORDER BY MaThuoc OFFSET {2} ROWS FETCH NEXT {3} ROWS ONLY", selected_doiTuong, selected_xuatXu, start, perPage, text_searching);
                    }
                }
            }


            //Console.WriteLine(query);
            //Console.WriteLine(text_searching);
            SqlDataReader reader = conn.Execute(query);
            try
            {
                while (reader.Read())
                {
                    Thuoc tmp = new Thuoc(
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        reader["TenThuoc"].ToString(),
                        Int32.Parse(reader["MaDoiTuong"].ToString()),
                        float.Parse(reader["GiaThuoc"].ToString()),
                        reader["AnhThuoc"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString()),
                        Int32.Parse(reader["MaXuatXu"].ToString()),
                        Int32.Parse(reader["SoLuong"].ToString())
                    );

                    arrayList.Add(tmp);

                }
            }
            catch (Exception ex)
            {
                reader.Close();
                Console.WriteLine("An error at ThuocDAO: " + ex.Message);
            }

            return arrayList;

        }
        public DTO.Thuoc getItem(int ma)
        {
            DTO.Thuoc t = new DTO.Thuoc(0, "", 0, 0, "", 0, 0, 0);
            ConnectDB conn = new ConnectDB();
            string query = string.Format("SELECT * FROM thuoc WHERE MaThuoc = '{0}'", ma);
            SqlDataReader reader = conn.Execute(query);
            try
            {
                if (reader.Read())
                {
                    t = new Thuoc(
                        Int32.Parse(reader["MaThuoc"].ToString()),
                        reader["TenThuoc"].ToString(),
                        Int32.Parse(reader["MaDoiTuong"].ToString()),
                        float.Parse(reader["GiaThuoc"].ToString()),
                        reader["AnhThuoc"].ToString(),
                        Int32.Parse(reader["TrangThai"].ToString()),
                        Int32.Parse(reader["MaXuatXu"].ToString()),
                        Int32.Parse(reader["SoLuong"].ToString())
                    );


                }
            }
            catch (Exception ex)
            {
                reader.Close();
                Console.WriteLine("An error at ThuocDAO: " + ex.Message);
            }
            return t;
        }

        public void updateQuantity(int ma, int sl)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("UPDATE thuoc SET SoLuong = SoLuong - {0} WHERE MaThuoc = '{1}'", sl, ma);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }
        public void addQuantity(int ma, int sl)
        {
            ConnectDB conn = new ConnectDB();
            string query = string.Format("UPDATE thuoc SET SoLuong = SoLuong + {0} WHERE MaThuoc = '{1}'", sl, ma);
            Console.WriteLine(query);
            conn.ExecuteNonQuery(query);
        }
        public void add(Thuoc Drug)
        {
            ConnectDB conn = new ConnectDB();
            try
            {
                string sql = "INSERT INTO THUOC VALUES (N'" + Drug.TenThuoc + "', '" + Drug.MaDoiTuong + "', '" + Drug.GiaThuoc + "','" + Drug.AnhThuoc + "', '" + "1'" + ",'" + Drug.MaXuatXu + "','0')";
                conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void update(Thuoc Drug)
        {
            ConnectDB conn = new ConnectDB();
            string sql = "UPDATE THUOC SET TenThuoc =N'" + Drug.TenThuoc + "', MaDoiTuong='" + Drug.MaDoiTuong + "', GiaThuoc='" + Drug.GiaThuoc + "',AnhThuoc='" + Drug.AnhThuoc + "',TrangThai='" + Drug.TrangThai + "',MaXuatXu='" + Drug.MaXuatXu + "',SoLuong='" + Drug.SoLuong + "' where MaThuoc = " + Drug.MaThuoc;
            conn.ExecuteNonQuery(sql);
        }

        public void DeleteatMaXuatXu(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string sql = "UPDATE THUOC SET TrangThai = 0,SoLuong = 0  WHERE Thuoc.MaXuatXu = " + ma;
            conn.ExecuteNonQuery(sql);
        }

        public void DeleteatMaDoiTuong(int ma)
        {
            ConnectDB conn = new ConnectDB();
            string sql = "UPDATE THUOC SET TrangThai = 0,SoLuong = 0  WHERE Thuoc.MaDoiTuong = " + ma;
            conn.ExecuteNonQuery(sql);
        }
        public void createTemp()
        {
            ConnectDB conn = new ConnectDB();
            string createTempTable = "CREATE TABLE TempTable (MaThuoc int, TenThuoc nvarchar(50), MaDoiTuong int, GiaThuoc float, AnhThuoc nvarchar(50), TrangThai int, MaXuatXu int, SoLuong int)";
            conn.ExecuteNonQuery(createTempTable);
        }
        public void Merge()
        {
            ConnectDB conn = new ConnectDB();
            string mergeSql = "MERGE thuoc AS Target " +
                  "USING TempTable AS Source " +
                  "ON Target.TenThuoc = Source.TenThuoc " +
                  "WHEN MATCHED THEN " +
                  "UPDATE SET Target.SoLuong = Target.SoLuong + Source.SoLuong " +
                  "WHEN NOT MATCHED BY TARGET THEN " +
                  "INSERT (TenThuoc, MaDoiTuong, GiaThuoc, AnhThuoc, TrangThai, MaXuatXu, SoLuong) " +
                  "VALUES (Source.TenThuoc, Source.MaDoiTuong, Source.GiaThuoc, Source.AnhThuoc, Source.TrangThai, Source.MaXuatXu, Source.SoLuong);";
            conn.ExecuteNonQuery(mergeSql);
        }
        public void dropTempTable()
        {
            ConnectDB conn = new ConnectDB();
            string query = "DROP TABLE TempTable";
            conn.ExecuteNonQuery(query);
        }
    }
}
