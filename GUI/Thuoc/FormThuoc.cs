using pharmacy_management.GUI.QLDoiTuong;
using pharmacy_management.GUI.QLxuatxu;
using Krypton.Toolkit;
using pharmacy_management.BUS;
using pharmacy_management.DTO;
using pharmacy_management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using System.Data.SqlClient;
using pharmacy_management.Database;

namespace pharmacy_management.GUI.Thuoc
{
    public partial class FormThuoc : Form
    {
        public FormThuoc()
        {
            InitializeComponent();
            loadds();
            setup();

            ckbTrangThai.Visible = false;

        }
        int flag = 1;
        ThuocBUS thuocbus = new ThuocBUS();
        DoiTuongBUS dtbus = new DoiTuongBUS();
        XuatXuBUS xxbus = new XuatXuBUS();

        public string globalFilename;

        private bool checkInput()
        {
            Boolean result = true;
            string giathuoc = txtGiaThuoc.Text;
            if (txtGiaThuoc.Equals("") || txtTenThuoc.Equals("") || cbbMaDoiTuong.Text == "" || cbbMaXuatXu.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                result = false;
            }
            else if (giathuoc.Any(char.IsLetter) || (float.TryParse(giathuoc, out float gia) && gia <= 0))
            {
                MessageBox.Show("Giá thuốc không hợp lệ");
                result = false;
            }
            /*foreach (char c in txtTenThuoc.Text)
                    if (char.IsDigit(c))
                        return true;*/
            return result;
        }
        public void setEnable(bool flag)
        {
            btnThem.Enabled = flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;
        }

        public void setup()
        {
            DoiTuongBUS dt_list = new DoiTuongBUS();
            //cbbMaDoiTuong.SelectedIndex = 0;
            foreach (DoiTuong dt in dt_list.getActiveMadoituong())
            {
                string temp = dt.MaDT + " - " + dt.TenDT;
                cbbMaDoiTuong.Items.Add(temp);
            }
            XuatXuBUS xx_list = new XuatXuBUS();
            //cbbMaXuatXu.SelectedIndex = 0;
            foreach (XuatXu xx in xx_list.getActiveMaxuatxu())
            {
                string temp = xx.MaXuatXu + " - " + xx.TenXuatXu;
                cbbMaXuatXu.Items.Add(temp);
            }
            cbbSearch.Items.Add("Mã Thuốc");
            cbbSearch.Items.Add("Tên Thuốc");
            cbbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSearch.AutoCompleteMode = AutoCompleteMode.None;
            cbbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
            setEnable(true);
        }
        private void loadds()
        {
            DGVThuoc.Rows.Clear();
            ThuocBUS thuocbus = new ThuocBUS();
            foreach (DTO.Thuoc item in thuocbus.getList())
            {
                string temp;
                int ma = int.Parse(item.MaThuoc.ToString());
                string tenthuoc = item.TenThuoc.ToString();
                int maxuatxu = int.Parse(item.MaXuatXu.ToString());
                int madoituong = int.Parse(item.MaDoiTuong.ToString());
                int soluong = int.Parse(item.SoLuong.ToString());
                float price = float.Parse(item.GiaThuoc.ToString());
                string anh = item.AnhThuoc.ToString();
                int state = int.Parse(item.TrangThai.ToString());
                string tenxuatxu = xxbus.GetNameBUS(maxuatxu);
                string tendoituong = dtbus.GetNameBUS(madoituong);
                if (state == 1)
                    temp = "Còn bán";
                else
                    temp = "Ngừng bán";
                DGVThuoc.Rows.Add(ma, tenthuoc, tenxuatxu, tendoituong, soluong, price, anh, temp);
            }
        }

        private void anhbtn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            globalFilename = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File (*.jpe;*.jpeg;*.bmp) | *.jpg;*jpeg;*.bmp";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string FileName = openFileDialog.FileName;
                        // gan ten File vao bien globalFilename
                        globalFilename += "images/" + Path.GetFileName(FileName);
                        MessageBox.Show(globalFilename);
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("File size limit exceeded");
                        }
                        else
                        {
                            pictureBox1.Load(FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (checkInput() == false) return;
            if (DGVThuoc.SelectedRows.Count >= 1)
            {
                MessageBox.Show("Có dòng đang được chọn hãy bỏ chọn trước!");
                return;
            }
            if (flag == 0)
                MessageBox.Show("Bạn phải làm mới bảng trước");
            else
            {
                try
                {
                    string maxx = cbbMaXuatXu.Text.Trim();
                    string madt = cbbMaDoiTuong.Text.Trim();
                    DTO.Thuoc drug = new DTO.Thuoc(txtTenThuoc.Text.ToString(), int.Parse(madt[0].ToString()), float.Parse(txtGiaThuoc.Text.ToString()), globalFilename, 1, int.Parse(maxx[0].ToString()), 0);
                    thuocbus.add(drug);

                    int maxThuoc = 0;
                    foreach (DTO.Thuoc item in thuocbus.getList())
                    {
                        int ma = int.Parse(item.MaThuoc.ToString());
                        if (ma > maxThuoc)
                        {
                            maxThuoc = ma;
                        }
                    }

                    int trangthaiNew = drug.TrangThai;
                    string tenNew = drug.TenThuoc;
                    string tenxuatxu = xxbus.GetNameBUS(drug.MaXuatXu);
                    string tendoituong = dtbus.GetNameBUS(drug.MaDoiTuong);
                    int soluong = drug.SoLuong;
                    float giathuoc = drug.GiaThuoc;
                    string anhthuoc = globalFilename;
                    string tempNew = (trangthaiNew == 1) ? "Còn bán" : "Ngừng bán";
                    DGVThuoc.Rows.Add(maxThuoc + 1, tenNew, tenxuatxu, tendoituong, soluong, giathuoc, anhthuoc, tempNew);

                    Refreshtxt();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void Refreshtxt()
        {
            txtTenThuoc.Text = "";
            txtGiaThuoc.Text = "";
            cbbMaDoiTuong.Text = "";
            cbbMaXuatXu.Text = "";
            txtMaThuoc.Text = "";
            txtGiaThuoc.Text = "";
            txtSoLuong.Text = "";
            pictureBox1.Image = null;
            DGVThuoc.ClearSelection();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            int ma = int.Parse(DGVThuoc.CurrentRow.Cells["MaThuoc"].Value.ToString());
            int trangThai = ckbTrangThai.Checked ? 1 : 0;
            if (trangThai == 0)
            {
                MessageBox.Show("Thuốc này đã hủy kích hoạt từ trước!!!");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy kích hoạt thông tin thuốc không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        thuocbus.delete(ma);
                        Refresh();
                        MessageBox.Show("Hủy kích hoạt thông tin thuốc thành công!!!");
                        DGVThuoc.CurrentRow.Cells["TrangThai"].Value = "Ngừng bán";
                        DGVThuoc.CurrentRow.Cells["SoLuong"].Value = "0";
                        ckbTrangThai.Checked = false;
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
            int state;
            checkInput();


            if (DGVThuoc.SelectedRows.Count < 1)
            {
                MessageBox.Show("Chưa chọn dòng để sửa!");
                return;
            }

            if (!ckbTrangThai.Checked)
                state = 0;
            else state = 1;
            XuatXuBUS xxbus = new XuatXuBUS();
            DoiTuongBUS dtbus = new DoiTuongBUS();
            int maxx = int.Parse(cbbMaXuatXu.Text.Trim().Substring(0, cbbMaXuatXu.Text.Trim().IndexOf('-')));
            int madt = int.Parse(cbbMaDoiTuong.Text.Trim().Substring(0, cbbMaDoiTuong.Text.Trim().IndexOf('-')));
            if ((xxbus.GetStateBUS(maxx) == 0 || dtbus.GetStateBUS(madt) == 0) && state == 1)
            {
                MessageBox.Show("Mã đối tượng hoặc mã xuất xứ đang trong trạng thái không hoạt động, không thể kích hoạt lại thuốc.Vui lòng kiểm tra lại");
                ckbTrangThai.Checked = false;
                return;
            }
            try
            {

                int mt = int.Parse(DGVThuoc.CurrentRow.Cells["MaThuoc"].Value.ToString());
                DTO.Thuoc drug = new DTO.Thuoc(mt, txtTenThuoc.Text.ToString(), madt, float.Parse(txtGiaThuoc.Text.ToString()), globalFilename, 1, maxx, 0);
                thuocbus.update(drug);
                int trangthaiNew = drug.TrangThai;
                string tenNew = drug.TenThuoc;
                string tenxuatxu = xxbus.GetNameBUS(drug.MaXuatXu);
                string tendoituong = dtbus.GetNameBUS(drug.MaDoiTuong);
                int soluong = drug.SoLuong;
                float giathuoc = drug.GiaThuoc;
                string anhthuoc = globalFilename;
                DGVThuoc.CurrentRow.Cells["TenThuoc"].Value = tenNew;
                DGVThuoc.CurrentRow.Cells["MaXuatXu"].Value = tenxuatxu;
                DGVThuoc.CurrentRow.Cells["MaDoiTuong"].Value = tendoituong;
                DGVThuoc.CurrentRow.Cells["SoLuong"].Value = soluong;
                DGVThuoc.CurrentRow.Cells["GiaThuoc"].Value = giathuoc;
                DGVThuoc.CurrentRow.Cells["AnhThuoc"].Value = anhthuoc;
                DGVThuoc.CurrentRow.Cells["TrangThai"].Value = state == 1 ? "Còn bán" : "Ngừng bán";
                Refreshtxt();
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string[] headers = { "MaThuoc", "TenThuoc", "MaXuatXu", "MaDoiTuong", "SoLuong", "GiaThuoc", "TrangThai" };

                // Add column headers
                for (int j = 0; j < headers.Length; j++)
                {
                    xlWorksheet.Cells[1, j + 1] = headers[j];
                    xlWorksheet.Columns[j + 1].ColumnWidth = DGVThuoc.Columns[headers[j]].Width / 7; // Adjust column width based on DataGridView column width
                    xlWorksheet.Columns[j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Center align the column
                }

                // Loop through each row in the DataGridView
                for (int i = 0; i < DGVThuoc.Rows.Count; i++)
                {
                    // Loop through each column in the DataGridView
                    for (int j = 0; j < headers.Length; j++)
                    {
                        // Populate Excel cells with data from the DataGridView
                        object value = DGVThuoc.Rows[i].Cells[headers[j]].Value;

                        // Format cells based on data types
                        if (value != null)
                        {
                            if (headers[j] == "TenThuoc")
                                xlWorksheet.Cells[i + 2, j + 1] = "'" + value.ToString();
                            else if (headers[j] == "MaXuatXu")
                                xlWorksheet.Cells[i + 2, j + 1] = "'" + value.ToString();
                            else if (headers[j] == "MaDoiTuong")
                                xlWorksheet.Cells[i + 2, j + 1] = "'" + value.ToString();
                            else if (headers[j] == "SoLuong") // Assuming MaKH is the column name for customer ID
                                xlWorksheet.Cells[i + 2, j + 1] = Convert.ToInt32(value);
                            else if (headers[j] == "GiaThuoc") // Assuming MaKH is the column name for customer ID
                                xlWorksheet.Cells[i + 2, j + 1] = Convert.ToSingle(value);
                            else if (headers[j] == "MaThuoc") // Assuming MaKH is the column name for customer ID
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



        private void DGVThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ThuocBUS thuocbus = new ThuocBUS();
            ckbTrangThai.Visible = true;
            string xuatxu = "", doituong = "";
            if (DGVThuoc.CurrentRow.Cells != null)
            {
                DGVThuoc.CurrentRow.Selected = true;
                // Lấy giá trị từ cột tương ứng và hiển thị lên TextBox
                String mt = DGVThuoc.CurrentRow.Cells["MaThuoc"].Value.ToString();
                string temp = DGVThuoc.CurrentRow.Cells["TrangThai"].Value.ToString();

                foreach (DTO.Thuoc drug in thuocbus.getList())
                {
                    if (mt == drug.MaThuoc.ToString())
                    {
                        doituong = drug.MaDoiTuong + " - " + DGVThuoc.CurrentRow.Cells["MaDoiTuong"].Value.ToString();
                        xuatxu = drug.MaXuatXu + " - " + DGVThuoc.CurrentRow.Cells["MaXuatXu"].Value.ToString();
                        break;
                    }
                }
                txtMaThuoc.Text = DGVThuoc.CurrentRow.Cells["MaThuoc"].Value.ToString();
                txtSoLuong.Text = DGVThuoc.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtTenThuoc.Text = DGVThuoc.CurrentRow.Cells["TenThuoc"].Value.ToString();
                txtGiaThuoc.Text = DGVThuoc.CurrentRow.Cells["GiaThuoc"].Value.ToString();
                cbbMaDoiTuong.Text = doituong;
                cbbMaXuatXu.Text = xuatxu;
                //string filePath = "C:\\DrugStore\\pharmacy-management\\Resources\\";
                string imageName = Path.GetFileName(DGVThuoc.CurrentRow.Cells["AnhThuoc"].Value.ToString()).Replace("images/", "");
                string directoryPath = @"..\..\Resources";
                string fileName = imageName;
                globalFilename = fileName;
                string imagePath = Path.Combine(directoryPath, fileName);
                pictureBox1.ImageLocation = imagePath;

                // filePath += fileName;
                //pictureBox1.Image = new Bitmap(filePath);
                ckbTrangThai.Enabled = true;
                if (temp.Equals("Còn bán", StringComparison.OrdinalIgnoreCase))
                {
                    ckbTrangThai.Checked = true;
                }
                else
                {
                    ckbTrangThai.Checked = false;
                }
                setEnable(false);
            }
        }

        private void DGVThuoc_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Refreshtxt();
            ckbTrangThai.Visible = false;
            setEnable(true);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            flag = 1;
            loadds();
        }

        private void cbbMaDoiTuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbMaDoiTuong_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbbMaXuatXu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbMaXuatXu_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập điều kiện cần lọc");
                return;
            }

            DGVThuoc.Rows.Clear();
            if (cbbSearch.SelectedItem.ToString() == "Mã Thuốc")
            {
                int maXuatXu = int.Parse(txtSearch.Text.ToString());
                foreach (DTO.Thuoc item in thuocbus.searchatMa(maXuatXu))
                {
                    string temp;
                    int ma = int.Parse(item.MaThuoc.ToString());
                    string tenthuoc = item.TenThuoc.ToString();
                    int maxuatxu = int.Parse(item.MaXuatXu.ToString());
                    int madoituong = int.Parse(item.MaDoiTuong.ToString());
                    int soluong = int.Parse(item.SoLuong.ToString());
                    float price = float.Parse(item.GiaThuoc.ToString());
                    string anh = item.AnhThuoc.ToString();
                    int state = int.Parse(item.TrangThai.ToString());
                    string tenxuatxu = xxbus.GetNameBUS(maxuatxu);
                    string tendoituong = dtbus.GetNameBUS(madoituong);
                    if (state == 1)
                        temp = "Còn bán";
                    else
                        temp = "Ngừng bán";
                    DGVThuoc.Rows.Add(ma, tenthuoc, tenxuatxu, tendoituong, soluong, price, anh, temp);
                    flag = 0;
                }

            }
            else if (cbbSearch.SelectedItem.ToString() == "Tên Thuốc")
            {
                string tenThuoc = txtSearch.Text.Trim().ToString();
                foreach (DTO.Thuoc item in thuocbus.searchatTen(tenThuoc))
                {
                    string temp;
                    int ma = int.Parse(item.MaThuoc.ToString());
                    string tenthuoc = item.TenThuoc.ToString();
                    int maxuatxu = int.Parse(item.MaXuatXu.ToString());
                    int madoituong = int.Parse(item.MaDoiTuong.ToString());
                    int soluong = int.Parse(item.SoLuong.ToString());
                    float price = float.Parse(item.GiaThuoc.ToString());
                    string anh = item.AnhThuoc.ToString();
                    int state = int.Parse(item.TrangThai.ToString());
                    string tenxuatxu = xxbus.GetNameBUS(maxuatxu);
                    string tendoituong = dtbus.GetNameBUS(madoituong);
                    if (state == 1)
                        temp = "Còn bán";
                    else
                        temp = "Ngừng bán";
                    DGVThuoc.Rows.Add(ma, tenthuoc, tenxuatxu, tendoituong, soluong, price, anh, temp);
                    flag = 0;
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FrmDoiTuong frmdoituong = new FrmDoiTuong();
            addFormtoPanelContainer(frmdoituong);

        }


        private void kryptonButton2_Click(object sender, EventArgs e)
        {

            FrmXuatXu frmXuatXu = new FrmXuatXu();
            addFormtoPanelContainer((frmXuatXu));

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
        private void btnNhap_Click(object sender, EventArgs e)
        {
        
        }
    }
}