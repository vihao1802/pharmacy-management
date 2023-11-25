using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pharmacy_management.DTO;
using pharmacy_management.BUS;
using pharmacy_management.DAO;
using System.Net.NetworkInformation;


namespace pharmacy_management.GUI.QLDoiTuong
{
    public partial class FrmDoiTuong : Form
    {
        public FrmDoiTuong()
        {
            InitializeComponent();
            loadds();
            setup();
        }

        DoiTuongBUS bus = new DoiTuongBUS();
        ThuocBUS thuocbus = new ThuocBUS();
        int flag = 1;
        public void setup()
        {
            cbbSearch.Items.Add("Mã đối tượng");
            cbbSearch.Items.Add("Tên đối tượng");
            cbbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSearch.AutoCompleteMode = AutoCompleteMode.None;
            cbbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

       
        private void loadds()
        {
            DGVDoiTuong.Rows.Clear();
            DoiTuongBUS bus = new DoiTuongBUS();
            foreach (DoiTuong item in bus.getList())
            {
                string temp;
                int ma = int.Parse(item.MaDT.ToString());
                string ten = item.TenDT.ToString();
                int state = int.Parse(item.TrangThai.ToString());
                if (state == 1)
                {
                    temp = "Active";
                }
                else
                {
                    temp = "Not Active";
                }
                DGVDoiTuong.Rows.Add(ma, ten, temp);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (flag == 0)
                MessageBox.Show("Bạn phải làm mới bảng trước");
            else
            {
                if (DGVDoiTuong.SelectedRows.Count >= 1)
                {
                    MessageBox.Show("Có dòng đang được chọn hãy bỏ chọn trước!");
                    return;
                }
                if (txtTenDoiTuong.Text == "")
                {
                    MessageBox.Show("Chưa điền tên đối tượng");
                    return;
                }
                if (!ckbTrangThai.Checked)
                {
                    MessageBox.Show("Thêm đối tượng phải đang hoạt động!!!");
                    return;
                }
                try
                {
                    DoiTuong dt = new DoiTuong(txtTenDoiTuong.Text.ToString(), 1);
                    bus.add(dt);

                    int maxDoiTuong = 0;
                    foreach (DoiTuong item in bus.getList())
                    {
                        int ma = int.Parse(item.MaDT.ToString());
                        if (ma > maxDoiTuong)
                        {
                            maxDoiTuong = ma;
                        }
                    }

                    int trangthaiNew = dt.TrangThai;
                    string tenNew = dt.TenDT;
                    string tempNew = (trangthaiNew == 1) ? "Active" : "Not Active";
                    DGVDoiTuong.Rows.Add(maxDoiTuong + 1, tenNew, tempNew);
                    txtTenDoiTuong.Text = "";
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int state;
            if (DGVDoiTuong.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ chọn 1 đối tượng để sửa!");
                return;
            }
            else if (DGVDoiTuong.SelectedRows.Count < 1)
            {
                MessageBox.Show("Chưa chọn dòng để sửa!");
                return;
            }
            if (txtTenDoiTuong.Text == "")
            {
                MessageBox.Show("Chưa điền tên đối tượng");
                return;
            }
            if (!ckbTrangThai.Checked)
                state = 0;
            else state = 1;
            try
            {
                DoiTuong dt = new DoiTuong(int.Parse(txtMaDoiTuong.Text.ToString()), txtTenDoiTuong.Text.ToString(), state);
                bus.update(dt);
                DGVDoiTuong.CurrentRow.Cells["TenDT"].Value = txtTenDoiTuong.Text.ToString();
                DGVDoiTuong.CurrentRow.Cells["TrangThai"].Value = state == 1 ? "Active" : "Not Active";
                txtTenDoiTuong.Text = "";
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            //DGVDoiTuong.Refresh();
        }

        private void DGVDoiTuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDoiTuong.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DGVDoiTuong.CurrentRow.Selected = true;
                // Lấy giá trị từ cột tương ứng và hiển thị lên TextBox
                txtMaDoiTuong.Text = DGVDoiTuong.Rows[e.RowIndex].Cells["MaDT"].Value.ToString();
                txtTenDoiTuong.Text = DGVDoiTuong.Rows[e.RowIndex].Cells["TenDT"].Value.ToString();
                string temp = DGVDoiTuong.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                ckbTrangThai.Enabled = true;
                if (temp.Equals("Active", StringComparison.OrdinalIgnoreCase))              
                ckbTrangThai.Checked = true;                
                else          
                    ckbTrangThai.Checked = false;               
            }
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(DGVDoiTuong.CurrentRow.Cells["MaDT"].Value.ToString());
            int trangThai = ckbTrangThai.Checked ? 1 : 0;
            // Thêm điều kiện kiểm tra trước khi xóa
            if (trangThai == 0)
            {
                MessageBox.Show("Đối tượng đã bị hủy kích hoạt từ trước!!!");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy kích hoạt đối tượng không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //if (trangThai == 1)
                        bus.delete(ma);
                        txtTenDoiTuong.Text = "";
                        MessageBox.Show("Hủy kích hoạt đối tượng thành công!!!");
                        DGVDoiTuong.CurrentRow.Cells["TrangThai"].Value = "Not Active";
                        ckbTrangThai.Checked = true; 
                        foreach (DTO.Thuoc item in thuocbus.getList())
                        {
                            if (ma == item.MaDoiTuong)
                                thuocbus.delete(item.MaThuoc);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void DGVDoiTuong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVDoiTuong.ClearSelection();
            txtMaDoiTuong.Text = "";
            txtTenDoiTuong.Text = "";
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            if (txtSearch.Text.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập điều kiện cần lọc");
                return;
            }
            DGVDoiTuong.Rows.Clear();
            if (cbbSearch.SelectedItem.ToString() == "Mã đối tượng")
            {

                int maDoiTuong = int.Parse(txtSearch.Text.ToString());
                foreach (DoiTuong item in bus.searchatMa(maDoiTuong))
                {
                    string temp;
                    int ma = int.Parse(item.MaDT.ToString());
                    string ten = item.TenDT.ToString();
                    int state = int.Parse(item.TrangThai.ToString());
                    if (state == 1)
                    {
                        temp = "Active";
                    }
                    else
                    {
                        temp = "Not Active";
                    }
                    DGVDoiTuong.Rows.Add(ma, ten, temp);
                    flag = 0;
                }

            }
            else if (cbbSearch.SelectedItem.ToString() == "Tên đối tượng")
            {
                string tenXuatXu = txtSearch.Text.ToString();
                foreach (DoiTuong item in bus.searchatTen(tenXuatXu))
                {
                    string temp;
                    int ma = int.Parse(item.MaDT.ToString());
                    string ten = item.TenDT.ToString();
                    int state = int.Parse(item.TrangThai.ToString());
                    if (state == 1)
                    {
                        temp = "Active";
                    }
                    else
                    {
                        temp = "Not Active";
                    }
                    DGVDoiTuong.Rows.Add(ma, ten, temp);
                    flag = 0;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadds();
            flag = 1;
        }
    }
}
