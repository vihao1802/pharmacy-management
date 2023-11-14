using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pharmacy_management.DAO;
using pharmacy_management.DTO;
using pharmacy_management.GUI.BanHang;

namespace pharmacy_management.GUI.NhapHang
{
  
    public partial class NhapHang : UserControl
    {
        private ArrayList listthuoc;
        ThuocDAO thuocdao = new ThuocDAO();
        public NhapHang()
        {
            InitializeComponent();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            listthuoc = thuocdao.GetALl();
            foreach (Thuoc t in listthuoc)
            {
                SanPham sp = new SanPham();
                
            }

        }
    }
}
