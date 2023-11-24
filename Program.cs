using pharmacy_management.GUI.KhachHang;
using pharmacy_management.GUI.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuoc;

namespace pharmacy_management
{
    static class Program
    {
        public static Form LoginForm { get; set; }
        public static Form MenuForm { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           /* LoginForm = new Login();
            LoginForm.Show();*/

            // Run the application
            //Application.Run();

            Application.Run(new KhachHangfrm());
        }
    }
}
