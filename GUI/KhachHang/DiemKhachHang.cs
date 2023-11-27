using Krypton.Toolkit;
using pharmacy_management.BUS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management.GUI.KhachHang
{
    public partial class DiemKhachHang : KryptonForm
    {
        private ArrayList list;
        DiemKhachHangBUS bus = new DiemKhachHangBUS();
        private DiemKhachHangBUS diemkhachHangBus;
        public DiemKhachHang()
        {
            InitializeComponent();
            load();
            
        }

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bangdiemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bangdiemDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bangdiemDataGridView.CurrentRow.Selected = true;
                txtMaBangDiem.Text = bangdiemDataGridView.Rows[e.RowIndex].Cells["MaBangDiem"].Value.ToString();
                txtMaKH.Text = bangdiemDataGridView.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                txtDiemTichLuy.Text = bangdiemDataGridView.Rows[e.RowIndex].Cells["DiemTichLuy"].Value.ToString();
                txtDiemDaSuDung.Text = bangdiemDataGridView.Rows[e.RowIndex].Cells["DiemDaSuDung"].Value.ToString();


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           /* if (bangdiemDataGridView.CurrentRow != null && bangdiemDataGridView.CurrentRow.Cells["MaBangDiem"].Value != null)
            {
                int diem = int.Parse(txtDiemThem.Text);
                int ma = int.Parse(bangdiemDataGridView.CurrentRow.Cells["MaKhachHang"].Value.ToString());
                DTO.DiemKhachHang dto = new DTO.DiemKhachHang(int.Parse(txtMaKH.Text), int.Parse(txtDiemTichLuy.Text), int.Parse(txtDiemDaSuDung.Text));
                bus.updateDiemKH(diem, ma);
                MessageBox.Show("Thêm thành công!!!");

                // Update the values in the DataGridView

                bangdiemDataGridView.CurrentRow.Cells["MaKhachHang"].Value = int.Parse(txtMaKH.Text);
                bangdiemDataGridView.CurrentRow.Cells["DiemTichLuy"].Value = int.Parse(txtDiemTichLuy.Text) + diem;
                bangdiemDataGridView.CurrentRow.Cells["DiemDaSuDung"].Value = int.Parse(txtDiemDaSuDung.Text);

                RefreshTextBox();

            }
            else
            {
                MessageBox.Show("Lỗi khi lấy giá trị MaKH từ dòng được chọn!");
            }*/
        }

        private void load()
        {
            bangdiemDataGridView.Rows.Clear();



            foreach (DTO.DiemKhachHang item in bus.getList())
            {
                int madiem = item.MaBangDiem;
                int ma = item.MaKH;
                int diemtichluy = item.DiemTichLuy;
                int diemdasudung = item.DiemDaSuDung;


                bangdiemDataGridView.Rows.Add(madiem, ma, diemtichluy, diemdasudung);
            }
        }

        private void RefreshTextBox()
        {
            txtMaKH.Clear();
            txtMaBangDiem.Clear();
            txtDiemDaSuDung.Clear();
            txtDiemTichLuy.Clear();
            //txtDiemThem.Clear();
        }
    }
}
