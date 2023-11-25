using pharmacy_management.BUS;
using pharmacy_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management.GUI.QuyDoiDiem
{
    public partial class PhieuGiamGiaFrm : Form
    {
        PhieuGiamGiaBUS pggBUS = new PhieuGiamGiaBUS();

        public PhieuGiamGiaFrm()
        {
            InitializeComponent();
            setup();
        }

        public void setup()
        {
            load_data();
        }

        public void load_data()
        {
            gv_QDD.Rows.Clear();

            foreach (PhieuGiamGia pgg in pggBUS.getList())
            {
                gv_QDD.Rows.Add(pgg.MaPhieuGiam, pgg.MoTaPG, pgg.SoDiemQuyDoi, pgg.PhanTramGiam);
            }
        }
    }
}
