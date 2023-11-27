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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            pggBUS = new PhieuGiamGiaBUS();
            pggBUS.loadListCondition(txt_searching.Text);
            foreach (PhieuGiamGia pgg in pggBUS.getList())
            {
                gv_QDD.Rows.Add(pgg.MaPhieuGiam, pgg.MaQuyDoi, pgg.MoTaPG, pgg.SoDiemQuyDoi, pgg.PhanTramGiam);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_DiemYC.Text) || string.IsNullOrEmpty(txt_MoTa.Text) || string.IsNullOrEmpty(txt_Giam.Text))
            //{
            //    MessageBox.Show("Thông tin không để trống");
            //    return;
            //}

            //if (!int.TryParse(txt_DiemYC.Text, out int _))
            //{
            //    MessageBox.Show(txt_DiemYC.Text + " không hợp lệ. Xin hãy nhập số");
            //    return;
            //}

            //if (!int.TryParse(txt_Giam.Text, out int _))
            //{
            //    MessageBox.Show(txt_Giam.Text + " không hợp lệ. Xin hãy nhập số");
            //    return;
            //}

            //DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm mới?", "Thêm mới", MessageBoxButtons.OKCancel);

            //if (result != DialogResult.OK)
            //{
            //    return;
            //}

            //string mota = txt_MoTa.Text;
            //string diem = txt_DiemYC.Text;
            //string phanTram = txt_Giam.Text;

            //pggBUS.insertItem(mota, diem, phanTram);
            //load_data();
        }

        private void txt_searching_TextChanged(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
