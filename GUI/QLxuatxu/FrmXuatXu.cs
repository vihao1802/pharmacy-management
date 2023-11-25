using pharmacy_management.BUS;
using pharmacy_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace pharmacy_management.GUI.QLxuatxu
{
    public partial class FrmXuatXu : Form
    {
        public FrmXuatXu()
        {
            InitializeComponent();
            loadds();
            setup();
        }
        int flag = 1;
        XuatXuBUS bus = new XuatXuBUS();
        ThuocBUS thuocbus= new ThuocBUS();
        public void setup()
        {
            cbbSearch.Items.Add("Mã xuất xứ");
            cbbSearch.Items.Add("Tên xuất xứ");
            cbbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSearch.AutoCompleteMode = AutoCompleteMode.None;
            cbbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void loadds()
        {
            DGVXuatXu.Rows.Clear();
            bus = new XuatXuBUS();
            foreach (XuatXu item in bus.getList())
            {
                string temp;
                int ma = int.Parse(item.MaXuatXu.ToString());
                string ten = item.TenXuatXu.ToString();
                int state = int.Parse(item.TrangThai.ToString());
                if (state == 1)
                {
                    temp = "Active";
                }
                else
                {
                    temp = "Not Active";
                }
                DGVXuatXu.Rows.Add(ma, ten, temp);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (flag == 0)
                MessageBox.Show("Bạn phải làm mới bảng trước");
            else
            {
                if (DGVXuatXu.SelectedRows.Count >= 1)
                {
                    MessageBox.Show("Có dòng đang được chọn hãy bỏ chọn trước!");
                    return;
                }
                if (txtTenXuatXu.Text == "")
                {
                    MessageBox.Show("Chưa điền tên xuất xứ");
                    return;
                }
                if (!ckbTrangThai.Checked)
                {
                    MessageBox.Show("Thêm xuất xứ phải đang hoạt động!!!");
                    return;
                }
                try
                {
                    XuatXu DTO = new XuatXu(txtTenXuatXu.Text.ToString(), 1);
                    bus.add(DTO);

                    int maxXuatXu = 0;
                    foreach (XuatXu item in bus.getList())
                    {
                        int ma = int.Parse(item.MaXuatXu.ToString());
                        if (ma > maxXuatXu)
                        {
                            maxXuatXu = ma;
                        }
                    }
                    /*                int trangthaiNew = DTO.TrangThai;
                                    string tenNew = DTO.TenXuatXu;
                                    string tempNew = (trangthaiNew == 1) ? "Active" : "Not Active";
                                    DGVXuatXu.Rows.Add(maxXuatXu + 1, tenNew, tempNew);*/
                    loadds();
                    txtTenXuatXu.Text = "";
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
            
                if (DGVXuatXu.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Chỉ chọn 1 xuất xứ để sửa!");
                    return;
                }
                else if (DGVXuatXu.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Chưa chọn xuất xứ để sửa!");
                    return;
                }
                if (txtTenXuatXu.Text == "")
                {
                    MessageBox.Show("Chưa điền tên xuất xứ");
                    return;

                }
                if (!ckbTrangThai.Checked)
                    state = 0;
                else state = 1;
                try
                {
                    XuatXu xx = new XuatXu(int.Parse(txtMaXuatXu.Text.ToString()), txtTenXuatXu.Text.ToString(), state);
                    bus.update(xx);
                    DGVXuatXu.CurrentRow.Cells["tenXuatXu"].Value = txtTenXuatXu.Text.ToString();
                    DGVXuatXu.CurrentRow.Cells["TrangThai"].Value = state == 1 ? "Active" : "Not Active";
                    txtTenXuatXu.Text = "";
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            //DGVDoiTuong.Refresh();
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
          /*  foreach (DataGridViewRow srows in DGVXuatXu.SelectedRows)
            {*/
                int ma = int.Parse(DGVXuatXu.CurrentRow.Cells["maXuatXu"].Value.ToString());
                int trangThai = ckbTrangThai.Checked ? 1 : 0;
            if (trangThai == 0)
            {
                MessageBox.Show("Xuất xứ đã bị hủy kích hoạt từ trước!!!");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy kích hoạt xuất xứ không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bus.delete(ma);
                        txtTenXuatXu.Text = "";
                        MessageBox.Show("Hủy kích hoạt xuất xứ thành công!!!");
                        DGVXuatXu.CurrentRow.Cells["TrangThai"].Value = "Not Active";
                        ckbTrangThai.Checked = true;
                        foreach (DTO.Thuoc item in thuocbus.getList())
                        {
                            if (ma == item.MaXuatXu)
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

        private void DGVXuatXu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVXuatXu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DGVXuatXu.CurrentRow.Selected = true;
                // Lấy giá trị từ cột tương ứng và hiển thị lên TextBox
                txtMaXuatXu.Text = DGVXuatXu.Rows[e.RowIndex].Cells["maXuatXu"].Value.ToString();
                txtTenXuatXu.Text = DGVXuatXu.Rows[e.RowIndex].Cells["tenXuatXu"].Value.ToString();
                string temp = DGVXuatXu.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                ckbTrangThai.Enabled = true;
                if (temp.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    ckbTrangThai.Checked = true;
                }
                else
                {
                    ckbTrangThai.Checked = false;
                }
            }
        }

        private void DGVXuatXu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVXuatXu.ClearSelection();
            txtMaXuatXu.Text = "";
            txtTenXuatXu.Text = "";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập điều kiện cần lọc");
                return;
            }
            DGVXuatXu.Rows.Clear();
           if (cbbSearch.SelectedItem.ToString() == "Mã xuất xứ")
            {
               
                int maXuatXu = int.Parse(txtSearch.Text.ToString());
                foreach (XuatXu item in bus.searchatMa(maXuatXu))
                {
                    string temp;
                    int ma = int.Parse(item.MaXuatXu.ToString());
                    string ten = item.TenXuatXu.ToString();
                    int state = int.Parse(item.TrangThai.ToString());
                    if (state == 1)
                    {
                        temp = "Active";
                    }
                    else
                    {
                        temp = "Not Active";
                    }
                    DGVXuatXu.Rows.Add(ma, ten, temp);
                    flag = 0;
                }
                
            }
            else if (cbbSearch.SelectedItem.ToString() == "Tên xuất xứ")
            {
                string tenXuatXu = txtSearch.Text.ToString();
                foreach (XuatXu item in bus.searchatTen(tenXuatXu))
                {
                    string temp;
                    int ma = int.Parse(item.MaXuatXu.ToString());
                    string ten = item.TenXuatXu.ToString();
                    int state = int.Parse(item.TrangThai.ToString());
                    if (state == 1)
                    {
                        temp = "Active";
                    }
                    else
                    {
                        temp = "Not Active";
                    }
                    DGVXuatXu.Rows.Add(ma, ten, temp);
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
