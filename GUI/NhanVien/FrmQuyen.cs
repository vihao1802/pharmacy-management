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

namespace pharmacy_management.GUI.NhanVien
{
    public partial class FrmQuyen : KryptonForm
    {

        private ArrayList list;
        QuyenBUS busquyen = new QuyenBUS();
        private QuyenBUS quyenBus;
        public FrmQuyen()
        {
            InitializeComponent();
            loads();
        }

        public void loads()
        {
            quyenDataGridView.Rows.Clear();
            foreach (DTO.Quyen item in busquyen.getList())
            {
                int ma = item.MaQuyen;
                string ten = item.TenQuyen;
                quyenDataGridView.Rows.Add(ma, ten);
            }

        }

        public void RefreshTextBox()
        {
            txtMaQuyen.Clear();
            txtTenQuyen.Clear();
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!!!");
                return;
            }
            DTO.Quyen dto = new DTO.Quyen(txtTenQuyen.Text);
            busquyen.add(dto);
            MessageBox.Show("Thêm thành công");
            int maxMaQuyen = 0;

            foreach (DTO.Quyen item in busquyen.getList())
            {
                int ma = item.MaQuyen;
                if (ma > maxMaQuyen)
                {
                    maxMaQuyen = ma;
                }
            }

            int maNew = maxMaQuyen + 1;
            string tenNew = dto.TenQuyen;
            quyenDataGridView.Rows.Add(maNew, tenNew);
            RefreshTextBox();
        }

        private void quyenDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (quyenDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                quyenDataGridView.CurrentRow.Selected = true;
                txtMaQuyen.Text = quyenDataGridView.Rows[e.RowIndex].Cells["MaQuyen"].Value.ToString();
                txtTenQuyen.Text = quyenDataGridView.Rows[e.RowIndex].Cells["TenQuyen"].Value.ToString();
                btnThem.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (quyenDataGridView.CurrentRow != null && quyenDataGridView.CurrentRow.Cells["MaQuyen"].Value != null)
            {
                int ma = int.Parse(quyenDataGridView.CurrentRow.Cells["MaQuyen"].Value.ToString());


                // Thêm điều kiện kiểm tra trước khi xóa
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy kích hoạt tài khoản khách hàng không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        busquyen.delete(ma);
                        MessageBox.Show("Xóa thành công");
                        quyenDataGridView.Rows.RemoveAt(quyenDataGridView.CurrentRow.Index);
                        RefreshTextBox();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!!!");
                return;
            }



            if (quyenDataGridView.CurrentRow != null && quyenDataGridView.CurrentRow.Cells["MaQuyen"].Value != null)
            {
                int ma = int.Parse(quyenDataGridView.CurrentRow.Cells["MaQuyen"].Value.ToString());
                DTO.Quyen quyen = new DTO.Quyen(txtTenQuyen.Text);
                busquyen.update(quyen, ma);
                MessageBox.Show("Sửa thành công");

                quyenDataGridView.CurrentRow.Cells["TenQuyen"].Value = txtTenQuyen.Text.ToString();
                RefreshTextBox();
            }
        }

        private void quyenDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshTextBox();
        }
    }
}
