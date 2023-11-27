using pharmacy_management.BUS;
using pharmacy_management.DTO;
using pharmacy_management.DAO;
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
using System.Text.RegularExpressions;

namespace pharmacy_management.GUI.KhachHang
{
    public partial class KhachHangfrm : Form
    {
        private ArrayList list;
        KhachHangBUS bus = new KhachHangBUS();
        private KhachHangBUS khachHangBus;
        DiemKhachHangBUS diembus = new DiemKhachHangBUS();
        private DiemKhachHangBUS diemKhachHangBUS;

        public KhachHangfrm()
        {
            InitializeComponent();
            loads();


        }
       

        private void loads()
        {
            khachhangDataGridView.Rows.Clear();
            foreach (DTO.KhachHang item in bus.getList())
            {
                int ma = item.MaKH;
                string ten = item.TenKH;
                string sdt = item.Sdt;
                DateTime ngaysinh = item.NgaySinh;
                int trangthai = item.TrangThai;
                string temp = (trangthai == 1) ? "Đang hoạt động" : "Dừng hoạt động";
                khachhangDataGridView.Rows.Add(ma, ten, sdt, ngaysinh.ToString("yyyy-MM-dd"), temp);
            }
        }

        private void RefreshTextBox()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtNgaySinh.MaxDate = DateTime.Now;
            txtNgaySinh.MinDate = new DateTime(1900, 01, 01);
            ckbTrangThai.Checked = true;
            btnThem.Enabled = true;
            ckbTrangThai.Visible = false;
            kryptonButton1.Visible = false;
            kryptonButton2.Visible = false;
        }

        private bool IsPhoneNumberExists(string phoneNumber)
        {
            foreach (DataGridViewRow row in khachhangDataGridView.Rows)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra tên 
                if (txtTenKH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin!!!");
                    return;

                }
                else
                {

                    if (txtTenKH.Text.Any(char.IsDigit))
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

                // Kiểm tra ngày sinh
                if (txtNgaySinh.Value.Year < 1900 || txtNgaySinh.Value > DateTime.Today)
                {
                    MessageBox.Show("Ngày tháng năm sinh không hợp lệ!!!");
                    return;
                }

                foreach (DTO.KhachHang item in bus.getList())
                {

                    int ma = int.Parse(item.MaKH.ToString());
                    if (txtMaKH.Text == ma.ToString())
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

                DTO.KhachHang dto = new DTO.KhachHang(txtTenKH.Text.ToString(), txtSDT.Text.ToString(), txtNgaySinh.Value, 1);
                bus.add(dto);
                diembus.add();

                //Thêm cột mới
                int maxMaKH = 0;

                foreach (DTO.KhachHang item in bus.getList())
                {
                    int ma = item.MaKH;
                    if (ma > maxMaKH)
                    {
                        maxMaKH = ma;
                    }
                }

                // Increment the maximum MaKH to get the new MaKH
                int maNew = maxMaKH + 1;
                string tenNew = dto.TenKH;
                string sdtNew = dto.Sdt;
                DateTime ngaysinhNew = dto.NgaySinh;
                int trangthaiNew = dto.TrangThai;
                string tempNew = (trangthaiNew == 1) ? "Đang hoạt động" : "Dừng hoạt động";
                khachhangDataGridView.Rows.Add(maNew, tenNew, sdtNew, ngaysinhNew.ToString("yyyy-MM-dd"), tempNew);

                MessageBox.Show("Thêm thành công");
                RefreshTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void khachhangDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (khachhangDataGridView.CurrentRow != null && khachhangDataGridView.CurrentRow.Cells["MaKH"].Value != null)
            {
                int ma = int.Parse(khachhangDataGridView.CurrentRow.Cells["MaKH"].Value.ToString());
                int trangThai = ckbTrangThai.Checked ? 1 : 0;

                // Thêm điều kiện kiểm tra trước khi xóa
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy kích hoạt tài khoản khách hàng không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (txtMaKH.Text.Trim() == "1")
                        {
                            MessageBox.Show("Khách vãng lai không được xóa!!!");
                            return;
                        }

                        if (trangThai == 1)
                        {
                            bus.delete(ma);
                            MessageBox.Show("Hủy kích hoạt tài khoản khách hàng thành công!!!");
                            khachhangDataGridView.CurrentRow.Cells["TrangThai"].Value = "Dừng hoạt động";
                            RefreshTextBox();

                        }
                        else
                        {
                            MessageBox.Show("Tài khoản đã bị hủy kích hoạt từ trước!!!");
                            return;
                        }

                        //loads();
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
                if (txtTenKH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin!!!");
                    return;

                }
                else
                {

                    if (txtTenKH.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("Có lỗi, vui lòng nhập lại!!!");
                        return;
                    }
                }

                if (txtMaKH.Text.Trim() == "1")
                {
                    MessageBox.Show("Khách vãng lai không được sửa!!!");
                    return;
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
                    if (!Regex.IsMatch(txtSDT.Text.ToString(), pattern))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!!!");
                        return;
                    }
                }

                // Kiểm tra ngày sinh
                if (txtNgaySinh.Value.Year < 1900 || txtNgaySinh.Value > DateTime.Today)
                {
                    MessageBox.Show("Ngày tháng năm sinh không hợp lệ!!!");
                    return;
                }

                if (khachhangDataGridView.CurrentRow != null && khachhangDataGridView.CurrentRow.Cells["MaKH"].Value != null)
                {
                    int trangThai = ckbTrangThai.Checked ? 1 : 0;
                    int ma = int.Parse(khachhangDataGridView.CurrentRow.Cells["MaKH"].Value.ToString());
                    DTO.KhachHang dto = new DTO.KhachHang(txtTenKH.Text.ToString(), txtSDT.Text.ToString(), txtNgaySinh.Value, trangThai);
                    bus.update(dto, ma);
                    MessageBox.Show("Sửa thành công!!!");

                    // Update the values in the DataGridView
                    khachhangDataGridView.CurrentRow.Cells["TenKH"].Value = txtTenKH.Text.ToString();
                    khachhangDataGridView.CurrentRow.Cells["SDT"].Value = txtSDT.Text.ToString();
                    khachhangDataGridView.CurrentRow.Cells["NgaySinh"].Value = txtNgaySinh.Value.ToString("yyyy-MM-dd");
                    khachhangDataGridView.CurrentRow.Cells["TrangThai"].Value = trangThai == 1 ? "Đang hoạt động" : "Dừng hoạt động";

                    RefreshTextBox();

                }
                else
                {
                    MessageBox.Show("Lỗi khi lấy giá trị MaKH từ dòng được chọn!");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void khachhangDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                string[] headers = { "MaKH", "TenKH", "SDT", "NgaySinh", "TrangThai" };

                // Add column headers
                for (int j = 0; j < headers.Length; j++)
                {
                    xlWorksheet.Cells[1, j + 1] = headers[j];
                    xlWorksheet.Columns[j + 1].ColumnWidth = khachhangDataGridView.Columns[headers[j]].Width / 7; // Adjust column width based on DataGridView column width
                    xlWorksheet.Columns[j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Center align the column
                }

                // Loop through each row in the DataGridView
                for (int i = 0; i < khachhangDataGridView.Rows.Count; i++)
                {
                    // Loop through each column in the DataGridView
                    for (int j = 0; j < headers.Length; j++)
                    {
                        // Populate Excel cells with data from the DataGridView
                        object value = khachhangDataGridView.Rows[i].Cells[headers[j]].Value;

                        // Format cells based on data types
                        if (value != null)
                        {
                            if (headers[j] == "SDT") // Assuming SDT is the column name for phone number
                                xlWorksheet.Cells[i + 2, j + 1] = "'" + value.ToString(); // Prepend with a single quote to treat it as text
                            else if (headers[j] == "NgaySinh") // Assuming NgaySinh is the column name for date of birth
                            {
                                DateTime ngaySinhValue = DateTime.Parse(value.ToString());
                                xlWorksheet.Cells[i + 2, j + 1] = ngaySinhValue;
                                // Set the number format for the "NgaySinh" column to "yyyy-MM-dd"
                                xlWorksheet.Cells[i + 2, j + 1].NumberFormat = "yyyy-mm-dd";
                            }
                            else if (headers[j] == "MaKH") // Assuming MaKH is the column name for customer ID
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

        private void btnDiemKH_Click(object sender, EventArgs e)
        {
            DiemKhachHang f = new DiemKhachHang();
            f.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (khachhangDataGridView.CurrentRow != null && khachhangDataGridView.CurrentRow.Cells["MaKH"].Value != null)
            {
                int ma = int.Parse(khachhangDataGridView.CurrentRow.Cells["MaKH"].Value.ToString());
                foreach (DTO.DiemKhachHang diem in diembus.getList())
                {
                    if (ma == diem.MaKH)
                    {
                        int madiem = diem.MaBangDiem;
                        int makh = diem.MaKH;
                        int diemtichtuy = diem.DiemTichLuy;
                        //int diemdasd = diem.DiemDaSuDung;
                        string message = "Mã bảng điểm: " + madiem + "\nMã khách hàng: " + makh + "\nĐiểm tích lũy: " + diemtichtuy;
                        MessageBox.Show(message, "Điểm khách hàng");
                        
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng cần xem điểm!!!");
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DiemKhachHang diem = new DiemKhachHang();
            diem.Show();
        }

        private void khachhangDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            khachhangDataGridView.CurrentRow.Selected = true;
        }

        private void khachhangDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (khachhangDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    khachhangDataGridView.CurrentRow.Selected = true;
                    txtMaKH.Text = khachhangDataGridView.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                    txtTenKH.Text = khachhangDataGridView.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
                    txtSDT.Text = khachhangDataGridView.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                    if (DateTime.TryParse(khachhangDataGridView.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString(), out DateTime ngaySinh))
                    {
                        txtNgaySinh.Value = ngaySinh;
                    }
                    string temp = khachhangDataGridView.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                    ckbTrangThai.Enabled = true;
                    if (temp.Equals("Đang hoạt động", StringComparison.OrdinalIgnoreCase))
                    {
                        ckbTrangThai.Checked = true;
                    }
                    else
                    {
                        ckbTrangThai.Checked = false;
                    }
                    btnThem.Enabled = false;
                    ckbTrangThai.Visible = true;
                    kryptonButton1.Visible = true;
                    kryptonButton2.Visible = true;

                }
            }
        }

        private void khachhangDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshTextBox();
        }
    }
}
