﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management.Database
{
    class ConnectDB
    {
        SqlConnection sqlConn; //Doi tuong ket noi CSDL
        SqlDataAdapter da;//Bo dieu phoi du lieu
        public ConnectDB()
        {
            string strCnn = "Data Source=MSI\\LAMDUC;Initial Catalog=ql_nhathuoc;Integrated Security=True";
            sqlConn = new SqlConnection(strCnn);
        }
        //Phuong thuc de thuc hien cau lenh strSQL truy vân du lieu
        public SqlDataReader Execute(string sqlStr)
        {
            using (SqlCommand command = new SqlCommand(sqlStr, sqlConn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return reader;
                }
            }
        }
        //Phuong thuc de thuc hien cac lenh Them, Xoa, Sua
        public void ExecuteNonQuery(string strSQL)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
                sqlConn.Open(); //Mo ket noi
                sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error at ConnectDB.cs: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();//Dong ket noi

            }
        }

    }
}
