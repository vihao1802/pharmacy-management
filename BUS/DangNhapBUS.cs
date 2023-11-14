using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pharmacy_management.DAO;
using pharmacy_management.DTO;

namespace pharmacy_management.BUS
{
    internal class DangNhapBUS
    {
        DangNhapDAO dao = new DangNhapDAO();
        public DangNhapBUS() { }
        public NhanVien dangnhap(string username,string password)
        {
            NhanVien nv = new NhanVien();
            nv.TenDangNhap = username;
            nv.MatKhau = password;
          
                nv = dao.taikhoandangnhap(nv);
                if(nv!=null) { 
                MessageBox.Show("Đăng nhập thành công");
                return nv;
            }else { 
                return null; }
        }
    }
}
