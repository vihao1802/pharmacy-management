using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacy_management.Database;
using pharmacy_management.DTO;
using pharmacy_management.GUI.BanHang;

namespace pharmacy_management.DAO
{

    internal class ThongKeDAO
    {
        ThongKe tk = new ThongKe();
        SqlConnection sqlcon;
        public ThongKeDAO()
        {
            KetNoiCSDL();
        }
        void KetNoiCSDL()
        {
            string conn ="Data Source=LAPTOP-LOJNVCRF\\SQLEXPRESS; Database=ql_nhathuoc;Integrated Security = True";           
            sqlcon = new SqlConnection(conn);
=======
            ConnectDB conn = new ConnectDB();
            sqlcon = conn.KetNoiCSDL();
>>>>>>> 45b538d1fd72b3699a6445c044f8246d7147cb5d
        }
        //        void KetNoiCSDL()
        //        {
        //            string conn =
        //"Data Source=MSI\\LAMDUC;Initial Catalog=ql_nhathuoc;Integrated Security=True";            sqlcon = new SqlConnection(conn);
        //        }
        public int getslthuoc()
        {
            string query = "Select Count(*) from thuoc";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                sqlcon.Open();
                tk.setSothuoc((int)cmd.ExecuteScalar());
                sqlcon.Close();
            }
            return tk.getSothuoc();

        }
        public int getslkh()
        {
            string query = "Select Count(*) from KhachHang";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                sqlcon.Open();
                tk.setSokh((int)cmd.ExecuteScalar());
                sqlcon.Close();
            }
            return tk.getSokh();
        }
        public int getslban()
        {
            string query = "Select Count(Soluong) from chitietdonhang";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                sqlcon.Open();
                tk.setSlban((int)cmd.ExecuteScalar());
                sqlcon.Close();
            }
            return tk.getSlban();
        }
        public float getdoanhthu()
        {
            string query = "Select Sum(Thanhtien) from donhang";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                sqlcon.Open();
                tk.setDoanhthu((float)Convert.ToDouble(cmd.ExecuteScalar()));
                sqlcon.Close();
            }
            return tk.getDoanhthu();
        }

        public void dtthang(List<decimal> revenues, List<string> months)
        {
            string query = "  Select sum(thanhtien) as revenue,month(NgayLap) as thang from donhang group by month(NgayLap)";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                sqlcon.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                revenues = new List<decimal>();
                months = new List<string>();
                while (reader.Read())
                {
                    revenues.Add(reader.GetDecimal(0)); // get the revenue value
                    months.Add(reader.GetString(1)); // get the month value
                }
                sqlcon.Close();
            }
        }
    }
}