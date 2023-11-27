using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using pharmacy_management.DAO;
using pharmacy_management.DTO;

namespace pharmacy_management.BUS
{
    internal class DangNhapBUS
    {
        DangNhapDAO dao = new DangNhapDAO();
        public DangNhapBUS() { }
        public NhanVien dangnhap(string username, string password)
        {
            NhanVien nv = new NhanVien();
            nv.TenDangNhap = username;
            nv.MatKhau = password;

            nv = dao.taikhoandangnhap(nv);
            if (nv != null)
            {
                //MessageBox.Show("Đăng nhập thành công");
                return nv;
            }
            else
            {
                return null;
            }
        }
        public void DoiPass(string username, string password)
        {
            dao.DoiPass(username, password);
        }
        public void sendMail(string mail)
        {
            MailAddress to = new MailAddress(mail);
            MailAddress from = new MailAddress("nhathuocsgu@gmail.com");
            MailMessage message = new MailMessage(from,to);
            message.Subject = "Reset mật khẩu";
            message.Body = "Xin chào, chúng tôi đã đặt lại mật khẩu cho tài khoản của bạn là: 123456";
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Timeout = 10000;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("nhathuocsgu@gmail.com", "thlrioimqzqdjesz");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(message);
                MessageBox.Show("Gửi mail thành công.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void resetPass(NhanVien nv)
        {
            dao.resetPass(nv);
        }
    }
}
