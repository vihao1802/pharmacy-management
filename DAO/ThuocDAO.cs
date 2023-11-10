using pharmacy_management.Database;
using pharmacy_management.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                /*if (text_searching == "")
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
                else
                {
                    while (reader.Read())
                    {
                        if (reader["TenThuoc"].ToString().Contains(text_searching))
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
                }*/
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


            Console.WriteLine(query);
            Console.WriteLine(text_searching);
            SqlDataReader reader = conn.Execute(query);
            try
            {
                /*if (text_searching == "")
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
                else
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["TenThuoc"].ToString());
                        if (reader["TenThuoc"].ToString().ToLower().Contains(text_searching.ToLower()))
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
                            //Console.WriteLine("at query result: " + tmp.TenThuoc);

                            arrayList.Add(tmp);
                        }

                    }
                }*/
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
    }
}
