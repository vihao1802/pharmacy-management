using pharmacy_management.GUI.QLxuatxu;
using pharmacy_management.GUI.QLDoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuoc;
using pharmacy_management.GUI.Thuoc;

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
            LoginForm = new Login();
            LoginForm.Show();
            //  FrmXuatXu frmXuatXu = new FrmXuatXu();
            //frmXuatXu.Show();
            // FrmDoiTuong frmdoituong = new FrmDoiTuong();
            // frmdoituong.Show();
            // FormThuoc frmthuoc = new FormThuoc();
            // frmthuoc.Show();
            Application.Run();
            //Application.Run(new GUI.QuyDoiDiem.QuyDoiDiemFrm());
            //Application.Run(new GUI.Menu());
            //Application.Run(new GUI.NhanVien.frmNhanVien());
            // Application.Run(new GUI.KhachHang.KhachHangfrm());

        }
    }
}
