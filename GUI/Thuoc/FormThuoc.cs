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

namespace pharmacy_management.GUI.Thuoc
{
    public partial class FormThuoc : Form
    {
        public FormThuoc()
        {
            InitializeComponent();
            loadds();
            setup();
        }
        ThuocBUS thuocbus = new ThuocBUS();
        DoiTuongBUS dtbus = new DoiTuongBUS();
        XuatXuBUS xxbus = new XuatXuBUS();
        public string globalFilename;
       
        private bool checkInput()
        {
            Boolean result = true;
            string giathuoc = txtGiaThuoc.Text;
            if (txtGiaThuoc.Equals("") || txtTenThuoc.Equals("") || cbbMaDoiTuong.SelectedItem == null || cbbMaXuatXu.SelectedItem == null || pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                result = false;
            }           
            else if (giathuoc.Any(char.IsLetter) || (float.TryParse(giathuoc, out float gia) && gia <= 0))
            {
                MessageBox.Show("Giá thuốc không hợp lệ");
                result = false;
            }
            
            return result;
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
            cbbMaXuatXu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaXuatXu.AutoCompleteMode = AutoCompleteMode.None;
            cbbMaXuatXu.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbbMaDoiTuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaDoiTuong.AutoCompleteMode = AutoCompleteMode.None;
            cbbMaDoiTuong.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void loadds()
        {
            foreach (DTO.Thuoc item in thuocbus.getList())
            {
                string temp;
                int ma = int.Parse(item.MaThuoc.ToString());
                string tenthuoc = item.TenThuoc.ToString();
                int maxuatxu = int.Parse(item.MaXuatXu.ToString());
                int madoituong = int.Parse(item.MaDoiTuong.ToString());
                int soluong = int.Parse(item.SoLuong.ToString());
                int price = int.Parse(item.GiaThuoc.ToString());
                string anh = item.AnhThuoc.ToString();
                int state = int.Parse(item.TrangThai.ToString());
                string tenxuatxu = xxbus.GetNameBUS(maxuatxu);
                string tendoituong = dtbus.GetNameBUS(madoituong);
                if (state == 1)               
                    temp = "Active";
                else             
                    temp = "Not Active";               
                DGVThuoc.Rows.Add(ma, tenthuoc, tenxuatxu, tendoituong, soluong, price, anh, temp);
            }
        }

        private void DGVThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string xuatxu = "", doituong = "";
            if (DGVThuoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DGVThuoc.CurrentRow.Selected = true;
                // Lấy giá trị từ cột tương ứng và hiển thị lên TextBox
                txtMaThuoc.Text = DGVThuoc.Rows[e.RowIndex].Cells["MaThuoc"].Value.ToString();
                txtTenThuoc.Text = DGVThuoc.Rows[e.RowIndex].Cells["TenThuoc"].Value.ToString();
                txtSoLuong.Text = DGVThuoc.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                txtGiaThuoc.Text = DGVThuoc.Rows[e.RowIndex].Cells["GiaThuoc"].Value.ToString();
                foreach (DTO.Thuoc drug in thuocbus.getList())
                {
                    if (txtMaThuoc.Text == drug.MaThuoc.ToString())
                    {
                        doituong = drug.MaDoiTuong + " - " + DGVThuoc.Rows[e.RowIndex].Cells["MaDoiTuong"].Value.ToString(); ;
                        xuatxu = drug.MaXuatXu + " - " + DGVThuoc.Rows[e.RowIndex].Cells["MaXuatXu"].Value.ToString();
                    }
                }
                cbbMaDoiTuong.Text = doituong;
                cbbMaXuatXu.Text = xuatxu;
                string temp = DGVThuoc.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                //string filePath = "C:\\DrugStore\\pharmacy-management\\Resources\\";
                string imageName = Path.GetFileName(DGVThuoc.Rows[e.RowIndex].Cells["AnhThuoc"].Value.ToString()).Replace("images/","");
                string directoryPath = @"..\..\Resources";
                string fileName = imageName;
                globalFilename = fileName;
                string imagePath = Path.Combine(directoryPath, fileName);
                pictureBox1.ImageLocation = imagePath;
               
               // filePath += fileName;*/
                /*pictureBox1.Image = new Bitmap(filePath);*/
                ckbTrangThai.Enabled = true;
                if (temp.Equals("Còn bán", StringComparison.OrdinalIgnoreCase))
                {
                    ckbTrangThai.Checked = true;
                }
                else
                {
                    ckbTrangThai.Checked = false;
                }
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
                        globalFilename += "images/"+Path.GetFileName(FileName);
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
                catch (Exception ex) { 
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
            if (!ckbTrangThai.Checked)
            {
                MessageBox.Show("Thêm thuốc phải đang hoạt động!!!");
                return;
            }
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
                string tempNew = (trangthaiNew == 1) ? "Active" : "Not Active";
                DGVThuoc.Rows.Add(maxThuoc+1, tenNew,tenxuatxu,tendoituong,soluong,giathuoc,anhthuoc,tempNew);
                Refreshtxt();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVThuoc.ClearSelection();
            Refreshtxt();
            
        }
         private void Refreshtxt()
        {
            txtMaThuoc.Text = "";
            txtSoLuong.Text = "";
            txtTenThuoc.Text = "";
            txtGiaThuoc.Text = "";
            cbbMaDoiTuong.Text = string.Empty;
            cbbMaXuatXu.Text = string.Empty;
            pictureBox1.Image = null;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            int ma = int.Parse(DGVThuoc.CurrentRow.Cells["MaThuoc"].Value.ToString());
            try
            {
                thuocbus.delete(ma);
                txtTenThuoc.Text = "";
                MessageBox.Show("Hủy kích hoạt thông tin thuốc thành công!!!");
                ckbTrangThai.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int state;
            checkInput();
            if (DGVThuoc.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ chọn 1 đối tượng để sửa!");
                return;
            }
            else if (DGVThuoc.SelectedRows.Count < 1)
            {
                MessageBox.Show("Chưa chọn dòng để sửa!");
                return;
            }
           
            if (!ckbTrangThai.Checked)
                state = 0;
            else state = 1;
            try
            {
                string maxx = cbbMaXuatXu.Text.Trim();
                string madt = cbbMaDoiTuong.Text.Trim();
                DTO.Thuoc drug = new DTO.Thuoc(int.Parse(txtMaThuoc.Text.ToString()), txtTenThuoc.Text.ToString(), int.Parse(madt[0].ToString()), float.Parse(txtGiaThuoc.Text.ToString()), globalFilename, 1, int.Parse(maxx[0].ToString()), 0);
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
                DGVThuoc.CurrentRow.Cells["TrangThai"].Value = state == 1 ? "Active" : "Not Active";
                Refreshtxt();
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}