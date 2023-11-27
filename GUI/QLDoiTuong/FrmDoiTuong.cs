using System;
using pharmacy_management.GUI.Thuoc;
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
            ckbTrangThai.Visible = false;
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
            if (DGVDoiTuong.SelectedRows.Count < 1)
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
                        ckbTrangThai.Checked = false; 
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

     

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new instance of Excel application
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlApp.Visible = true;

                // Create a new workbook
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(Type.Missing);

                // Get the active sheet
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.ActiveSheet;

                // Column headers
                string[] headers = { "MaDT", "TenDT", "TrangThai" };

                // Add column headers
                for (int j = 0; j < headers.Length; j++)
                {
                    xlWorksheet.Cells[1, j + 1] = headers[j];
                    xlWorksheet.Columns[j + 1].ColumnWidth = DGVDoiTuong.Columns[headers[j]].Width / 7; // Adjust column width based on DataGridView column width
                    xlWorksheet.Columns[j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Center align the column
                }

                // Loop through each row in the DataGridView
                for (int i = 0; i < DGVDoiTuong.Rows.Count; i++)
                {
                    // Loop through each column in the DataGridView
                    for (int j = 0; j < headers.Length; j++)
                    {
                        // Populate Excel cells with data from the DataGridView
                        object value = DGVDoiTuong.Rows[i].Cells[headers[j]].Value;

                        // Format cells based on data types
                        if (value != null)
                        {
                            if (headers[j] == "TenDT") // Assuming SDT is the column name for phone number
                                xlWorksheet.Cells[i + 2, j + 1] = "'" + value.ToString(); // Prepend with a single quote to treat it as text                        
                            else if (headers[j] == "MaDT") // Assuming MaKH is the column name for customer ID
                                xlWorksheet.Cells[i + 2, j + 1] = Convert.ToInt32(value);
                            else
                                xlWorksheet.Cells[i + 2, j + 1] = value;

                            xlWorksheet.Cells[i + 2, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Center align the cell
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DGVDoiTuong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ckbTrangThai.Visible = true;
            DGVDoiTuong.CurrentRow.Selected = true;
            // Lấy giá trị từ cột tương ứng và hiển thị lên TextBox
            txtMaDoiTuong.Text = DGVDoiTuong.CurrentRow.Cells["MaDT"].Value.ToString();
            txtTenDoiTuong.Text = DGVDoiTuong.CurrentRow.Cells["TenDT"].Value.ToString();
            string temp = DGVDoiTuong.CurrentRow.Cells["TrangThai"].Value.ToString();
            ckbTrangThai.Enabled = true;
            if (temp.Equals("Active", StringComparison.OrdinalIgnoreCase))
                ckbTrangThai.Checked = true;
            else
                ckbTrangThai.Checked = false;
        }

        private void addFormtoPanelContainer(object Form)
        {
            if (this.kryptonPanel1.Controls.Count > 0)
            {
                this.kryptonPanel1.Controls.Clear();

                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.kryptonPanel1.Controls.Add(f);
                this.kryptonPanel1.Tag = f;
                f.Show();
            }
        }

        private void DGVDoiTuong_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ckbTrangThai.Visible = false;
            DGVDoiTuong.ClearSelection();
            txtMaDoiTuong.Text = "";
            txtTenDoiTuong.Text = "";
        }

        private void backlbl_MouseClick(object sender, MouseEventArgs e)
        {
            FormThuoc formthuoc = new FormThuoc();
            addFormtoPanelContainer(formthuoc);
        }
    }
}
