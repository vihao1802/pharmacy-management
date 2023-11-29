using pharmacy_management.BUS;
using pharmacy_management.DAO;
using pharmacy_management.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management.GUI.NhanVien
{
    public partial class frmNhanVien : Form
    {

        private ArrayList list;
        NhanVienBUS bus = new NhanVienBUS();
        private NhanVienBUS nhanVienBus;

        QuyenBUS busquyen = new QuyenBUS();
        private QuyenBUS quyenBus;

        public frmNhanVien()
        {
            InitializeComponent();
            loads();

            cbxMaQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMaQuyen.AutoCompleteMode = AutoCompleteMode.None;
            cbxMaQuyen.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMaQuyen.Items.Clear();
            foreach (Quyen dt in busquyen.getList())
            {

                string temp = dt.TenQuyen;
                cbxMaQuyen.Items.Add(temp);
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void RefreshTextBox()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();
            cbxMaQuyen.Items.Clear();
            txt_searching.Clear();
            foreach (Quyen dt in busquyen.getList())
            {
                if (!cbxMaQuyen.Items.Contains(dt.TenQuyen))
                {
                    cbxMaQuyen.Items.Add(dt.TenQuyen);
                }
            }
            ckbTrangThai.Enabled = false;
            ckbTrangThai.Checked = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTenDangNhap.Enabled = true;
            ckbTrangThai.Visible = false;
            label8.Visible = true;
            txtMatKhau.Visible = true;
            nhanvienDataGridView.ClearSelection();
        }


        private void loads()
        {
            nhanvienDataGridView.Rows.Clear();

            foreach (DTO.NhanVien item in bus.getList())
            {

                int ma = item.MaNV;
                string ten = item.TenNV;
                string sdt = item.SDT;
                string diachi = item.DiaChi;
                string email = item.Email;
                int trangthai = item.TrangThai;
                string temp = (trangthai == 1) ? "Đang hoạt động" : "Dừng hoạt động";
                string tendangnhap = item.TenDangNhap;
                int maquyen = item.MaQuyen;
                string tenquyen = "";

                foreach (Quyen dt in busquyen.getList())
                {

                    if (maquyen == dt.MaQuyen)
                    {
                        tenquyen = dt.TenQuyen;
                    };



                }



                nhanvienDataGridView.Rows.Add(ma, ten, sdt, diachi, email, tendangnhap, temp, tenquyen);
            }
        }


        private void nhanvienDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool IsPhoneNumberExists(string phoneNumber)
        {
            foreach (DataGridViewRow row in nhanvienDataGridView.Rows)
            {
                if (row.Cells["SDT"].Value != null)
                {
                    string existingPhoneNumber = row.Cells["SDT"].Value.ToString().Trim();

                    // So sánh số điện thoại
                    if (existingPhoneNumber.Equals(phoneNumber, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Số điện thoại đã tồn tại trong DataGridView
                    }
                }
            }

            return false; // Số điện thoại không tồn tại trong DataGridView
        }

        private bool IsEmailExists(string email)
        {
            foreach (DataGridViewRow row in nhanvienDataGridView.Rows)
            {
                if (row.Cells["Email"].Value != null)
                {
                    string existingEmail = row.Cells["Email"].Value.ToString().Trim();

                    // So sánh email
                    if (existingEmail.Equals(email, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Email đã tồn tại trong DataGridView
                    }
                }
            }

            return false; // Email không tồn tại trong DataGridView
        }

        private bool IsTenDangNhapExists(string tenDangNhap)
        {
            foreach (DataGridViewRow row in nhanvienDataGridView.Rows)
            {
                if (row.Cells["TenDangNhap"].Value != null)
                {
                    string existingTenDangNhap = row.Cells["TenDangNhap"].Value.ToString().Trim();

                    // So sánh tên đăng nhập
                    if (existingTenDangNhap.Equals(tenDangNhap, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Tên đăng nhập đã tồn tại trong DataGridView
                    }
                }
            }

            return false; // Tên đăng nhập không tồn tại trong DataGridView
        }

        private bool IsMatKhauValid(string matKhau)
        {
            // Kiểm tra mật khẩu có ít nhất 8 ký tự và nhiều nhất 20 ký tự
            string pattern = @"^.{6,20}$"; // ^: Bắt đầu, .: Bất kỳ ký tự nào, {8,20}: Từ 8 đến 20 ký tự, $: Kết thúc
            return Regex.IsMatch(matKhau, pattern);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra tên 
                if (txtTenNV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin!!!");
                    return;

                }
                else
                {

                    if (txtTenNV.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("Có lỗi, vui lòng nhập lại!!!");
                        return;
                    }
                }


                // Kiểm tra số điện thoại
                if (txtSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!!!");
                    return;

                }
                else
                {
                    // Sử dụng biểu thức chính quy để kiểm tra số điện thoại
                    string pattern = @"^0[0-9]{9}$"; // Bắt đầu bằng 0
                    if (!Regex.IsMatch(txtSDT.Text.Trim(), pattern))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!!!");
                        return;
                    }
                    if (IsPhoneNumberExists(txtSDT.Text.Trim()))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại!!!");
                        return;
                    }

                }

                foreach (DTO.NhanVien item in bus.getList())
                {

                    int ma = int.Parse(item.MaNV.ToString());
                    if (txtMaNV.Text == ma.ToString())
                    {
                        MessageBox.Show("Trùng mã !!! Vui lòng thử lại");
                        return;
                    }

                }


                if (!ckbTrangThai.Checked)
                {
                    MessageBox.Show("Thêm mới khách hàng phải đang hoạt động!!!");
                    return;
                }

                // Kiểm tra địa chỉ
                if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!!!");
                    return;
                }

                // Kiểm tra email
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Email!!!");
                    return;

                }
                else
                {
                    // Sử dụng biểu thức chính quy để kiểm tra số điện thoại
                    string pattern1 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                    if (!Regex.IsMatch(txtEmail.Text.ToString(), pattern1))
                    {
                        MessageBox.Show("Email không hợp lệ!!!");
                        return;
                    }


                    // Kiểm tra email đã tồn tại trong DataGridView chưa
                    if (IsEmailExists(txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Địa chỉ email đã tồn tại !!!");
                        return;
                    }
                }

                // Kiểm tra tên đăng nhập
                if (txtTenDangNhap.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!!!");
                    return;
                }
                else
                {
                    // Kiểm tra tên đăng nhập đã tồn tại trong DataGridView chưa
                    if (IsTenDangNhapExists(txtTenDangNhap.Text.Trim()))
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!!!");
                        return;
                    }
                }

                // Kiểm tra mật khẩu
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!!!");
                    return;
                }
                else
                {
                    string matKhau = txtMatKhau.Text;

                    // Kiểm tra mật khẩu có đủ độ dài không
                    if (!IsMatKhauValid(matKhau))
                    {
                        MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự và nhiều nhất 20 ký tự!!!");
                        return;
                    }
                }



                //Kiểm tra mã quyền
                if (cbxMaQuyen.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn quyền!!!");
                    return;
                }


                int maquyen = 0;
                foreach (DTO.Quyen item in busquyen.getList())
                {
                    if (cbxMaQuyen.Text == item.TenQuyen)
                    {
                        maquyen = item.MaQuyen;
                    }

                }

                DTO.NhanVien dto = new DTO.NhanVien(txtTenNV.Text.ToString(), txtSDT.Text.ToString(), txtDiaChi.Text.ToString(), txtEmail.Text.ToString(), 1, txtTenDangNhap.Text.ToString(), txtMatKhau.Text.ToString(), maquyen);
                bus.add(dto);


                //Thêm cột mới
                int maxMaNV = 0;

                foreach (DTO.NhanVien item in bus.getList())
                {
                    int ma = item.MaNV;
                    if (ma > maxMaNV)
                    {
                        maxMaNV = ma;
                    }
                }

                // Increment the maximum MaKH to get the new MaKH
                int maNew = maxMaNV + 1;
                string tenNew = dto.TenNV;
                string sdtNew = dto.SDT;
                string diachiNew = dto.DiaChi;
                string emailNew = dto.Email;
                int trangthaiNew = dto.TrangThai;
                string tempNew = (trangthaiNew == 1) ? "Đang hoạt động" : "Dừng hoạt động";
                string tendangnhapNew = dto.TenDangNhap;
                string matkhauNew = dto.MatKhau;
                string tenquyenNew = "";

                foreach (Quyen dt in busquyen.getList())
                {
                    if (maquyen == dt.MaQuyen)
                    {
                        tenquyenNew = dt.TenQuyen;

                    }


                }

                nhanvienDataGridView.Rows.Add(maNew, tenNew, sdtNew, diachiNew, emailNew, tempNew, tendangnhapNew, matkhauNew, tenquyenNew);

                MessageBox.Show("Thêm thành công");
                RefreshTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nhanvienDataGridView.CurrentRow != null && nhanvienDataGridView.CurrentRow.Cells["MaNV"].Value != null)
            {
                int ma = int.Parse(nhanvienDataGridView.CurrentRow.Cells["MaNV"].Value.ToString());
                int trangThai = ckbTrangThai.Checked ? 1 : 0;

                // Thêm điều kiện kiểm tra trước khi xóa
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy kích hoạt tài khoản khách hàng không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (trangThai == 1)
                        {
                            bus.delete(ma);
                            MessageBox.Show("Hủy kích hoạt nhân viên thành công!!!");
                            nhanvienDataGridView.CurrentRow.Cells["TrangThai"].Value = "Dừng hoạt động";
                            RefreshTextBox();

                        }
                        else
                        {
                            MessageBox.Show("Tài khoản đã bị hủy kích hoạt từ trước!!!");
                            return;
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Không có dòng được chọn.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra tên 
                if (txtTenNV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin!!!");
                    return;

                }
                else
                {

                    if (txtTenNV.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("Có lỗi, vui lòng nhập lại!!!");
                        return;
                    }
                }


                // Kiểm tra số điện thoại
                if (txtSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!!!");
                    return;

                }
                else
                {
                    // Sử dụng biểu thức chính quy để kiểm tra số điện thoại
                    string pattern = @"^0[0-9]{9}$"; // Bắt đầu bằng 0
                    if (!Regex.IsMatch(txtSDT.Text.Trim(), pattern))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!!!");
                        return;
                    }


                }

                // Kiểm tra email
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Email!!!");
                    return;

                }
                else
                {
                    // Sử dụng biểu thức chính quy để kiểm tra số điện thoại
                    string pattern1 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                    if (!Regex.IsMatch(txtEmail.Text.ToString(), pattern1))
                    {
                        MessageBox.Show("Email không hợp lệ!!!");
                        return;
                    }


                }

                // Kiểm tra tên đăng nhập
                if (txtTenDangNhap.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!!!");
                    return;
                }


                // Kiểm tra mật khẩu
                /*if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!!!");
                    return;
                }
                else
                {
                    string matKhau = txtMatKhau.Text;

                    // Kiểm tra mật khẩu có đủ độ dài không
                    if (!IsMatKhauValid(matKhau))
                    {
                        MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự và nhiều nhất 20 ký tự!!!");
                        return;
                    }
                }*/

                // Kiểm tra địa chỉ
                if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!!!");
                    return;
                }

                //Kiểm tra mã quyền
                if (cbxMaQuyen.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn quyền!!!");
                    return;
                }


                int maquyen = 0;
                foreach (DTO.Quyen item in busquyen.getList())
                {
                    if (cbxMaQuyen.Text == item.TenQuyen)
                    {
                        maquyen = item.MaQuyen;
                    }

                }


                if (nhanvienDataGridView.CurrentRow != null && nhanvienDataGridView.CurrentRow.Cells["MaNV"].Value != null)
                {
                    int trangThai = ckbTrangThai.Checked ? 1 : 0;
                    int ma = int.Parse(nhanvienDataGridView.CurrentRow.Cells["MaNV"].Value.ToString());
                    DTO.NhanVien dto = new DTO.NhanVien(txtTenNV.Text.ToString(), txtSDT.Text.ToString(), txtDiaChi.Text.ToString(), txtEmail.Text.ToString(), trangThai, txtTenDangNhap.Text.ToString(), txtMatKhau.Text.ToString(), maquyen);
                    bus.update(dto, ma);
                    MessageBox.Show("Sửa thành công!!!");

                    //update
                    nhanvienDataGridView.CurrentRow.Cells["TenNV"].Value = txtTenNV.Text.ToString();
                    nhanvienDataGridView.CurrentRow.Cells["SDT"].Value = txtSDT.Text.ToString();
                    nhanvienDataGridView.CurrentRow.Cells["DiaChi"].Value = txtDiaChi.Text.ToString();
                    nhanvienDataGridView.CurrentRow.Cells["Email"].Value = txtEmail.Text.ToString();
                    nhanvienDataGridView.CurrentRow.Cells["TrangThai"].Value = trangThai == 1 ? "Đang hoạt động" : "Dừng hoạt động";
                    nhanvienDataGridView.CurrentRow.Cells["TenDangNhap"].Value = txtTenDangNhap.Text.ToString();
                    //nhanvienDataGridView.CurrentRow.Cells["MatKhau"].Value = txtMatKhau.Text.ToString();
                    nhanvienDataGridView.CurrentRow.Cells["MaQuyen"].Value = cbxMaQuyen.Text.ToString();

                    RefreshTextBox();
                }
                else
                {
                    MessageBox.Show("Lỗi khi lấy giá trị MaNV từ dòng được chọn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
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
                string[] headers = { "MaNV", "TenNV", "SDT", "DiaChi", "Email", "TenDangNhap", "TrangThai", "MaQuyen" };

                // Add column headers
                for (int j = 0; j < headers.Length; j++)
                {
                    xlWorksheet.Cells[1, j + 1] = headers[j];
                    xlWorksheet.Columns[j + 1].ColumnWidth = nhanvienDataGridView.Columns[headers[j]].Width / 7; // Adjust column width based on DataGridView column width
                    xlWorksheet.Columns[j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Center align the column
                }

                // Loop through each row in the DataGridView
                for (int i = 0; i < nhanvienDataGridView.Rows.Count; i++)
                {
                    // Loop through each column in the DataGridView
                    for (int j = 0; j < headers.Length; j++)
                    {
                        // Populate Excel cells with data from the DataGridView
                        object value = nhanvienDataGridView.Rows[i].Cells[headers[j]].Value;

                        // Format cells based on data types
                        if (value != null)
                        {
                            if (headers[j] == "SDT") // Assuming SDT is the column name for phone number
                                xlWorksheet.Cells[i + 2, j + 1] = "'" + value.ToString(); // Prepend with a single quote to treat it as text
                            else if (headers[j] == "MaNV" || headers[j] == "MaQuyen") // Assuming MaNV and MaQuyen are columns with integer values
                                xlWorksheet.Cells[i + 2, j + 1] = value.ToString();
                            else
                                xlWorksheet.Cells[i + 2, j + 1] = value;

                            xlWorksheet.Cells[i + 2, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Center align the cell
                        }
                    }
                }

                // Auto-fit all columns to the content
                xlWorksheet.Columns.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void nhanvienDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FrmQuyen f = new FrmQuyen();
            f.Show();

        }

        private void nhanvienDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void nhanvienDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            nhanvienDataGridView.CurrentRow.Selected = true;
        }

        private void nhanvienDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (nhanvienDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    nhanvienDataGridView.CurrentRow.Selected = true;
                    txtMaNV.Text = nhanvienDataGridView.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                    txtTenNV.Text = nhanvienDataGridView.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
                    txtSDT.Text = nhanvienDataGridView.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                    txtDiaChi.Text = nhanvienDataGridView.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                    txtEmail.Text = nhanvienDataGridView.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    txtTenDangNhap.Text = nhanvienDataGridView.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                    cbxMaQuyen.Text = nhanvienDataGridView.Rows[e.RowIndex].Cells["MaQuyen"].Value.ToString();
                    string temp = nhanvienDataGridView.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                    ckbTrangThai.Enabled = true;
                    txtTenDangNhap.Enabled = false;
                    btnThem.Enabled = false;
                    if (temp.Equals("Đang hoạt động", StringComparison.OrdinalIgnoreCase))
                    {
                        ckbTrangThai.Checked = true;
                    }
                    else
                    {
                        ckbTrangThai.Checked = false;
                    }
                    if (cbxMaQuyen.Text == "Admin")
                    {
                        ckbTrangThai.Visible = false;
                    }
                    else
                    {
                        ckbTrangThai.Visible = true;
                    }
                    label8.Visible = false;
                    txtMatKhau.Visible = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void nhanvienDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshTextBox();
        }

        private void txt_searching_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_searching_TextChanged_1(object sender, EventArgs e)
        {
            nhanvienDataGridView.Rows.Clear();
            string tim = txt_searching.Text.Trim().ToString();
            foreach (DTO.NhanVien item in bus.search(tim))
            {

                int ma = item.MaNV;
                string ten = item.TenNV;
                string sdt = item.SDT;
                string diachi = item.DiaChi;
                string email = item.Email;
                int trangthai = item.TrangThai;
                string temp = (trangthai == 1) ? "Đang hoạt động" : "Dừng hoạt động";
                string tendangnhap = item.TenDangNhap;
                int maquyen = item.MaQuyen;
                string tenquyen = "";

                foreach (Quyen dt in busquyen.getList())
                {

                    if (maquyen == dt.MaQuyen)
                    {
                        tenquyen = dt.TenQuyen;
                    };

                }
                nhanvienDataGridView.Rows.Add(ma, ten, sdt, diachi, email, tendangnhap, temp, tenquyen);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loads();
            RefreshTextBox();
        }
    }
}
