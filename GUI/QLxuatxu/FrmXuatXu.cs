using pharmacy_management.BUS;
using pharmacy_management.DTO;
using pharmacy_management.GUI.Thuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
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

            ckbTrangThai.Visible = false;
        }
        int flag = 1;
        XuatXuBUS bus = new XuatXuBUS();
        ThuocBUS thuocbus = new ThuocBUS();

        public void setEnable(bool flag)
        {
            btnThem.Enabled = flag;
            btnSua.Enabled = !flag;
        }
        public void setup()
        {
            /*  cbbSearch.Items.Add("Mã xuất xứ");
              cbbSearch.Items.Add("Tên xuất xứ");
              cbbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
              cbbSearch.AutoCompleteMode = AutoCompleteMode.None;
              cbbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;*/
            setEnable(true);
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
          
                if (txtTenXuatXu.Text == "")
                {
                    MessageBox.Show("Chưa điền tên xuất xứ");
                    return;
                }

                try
                {
                    XuatXu DTO = new XuatXu(txtTenXuatXu.Text.ToString(), 1);
                    bus.add(DTO);                 
                    loadds();
                    txtTenXuatXu.Text = "";
                    MessageBox.Show("Thêm thành công");
               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int state;
            int ma = int.Parse(txtMaXuatXu.Text.ToString());
            XuatXuBUS bus = new XuatXuBUS();
            ThuocBUS thuocbus = new ThuocBUS();
            if (txtTenXuatXu.Text == "")
            {
                MessageBox.Show("Chưa điền tên xuất xứ");
                return;

            }
            if (!ckbTrangThai.Checked)
            {
                state = 0;
                thuocbus.deleteatMaXuatXu(ma);
            }
            else state = 1;
            try
            {
                XuatXu xx = new XuatXu(int.Parse(txtMaXuatXu.Text.ToString()), txtTenXuatXu.Text.ToString(), state);
                bus.update(xx);
                DGVXuatXu.CurrentRow.Cells["tenXuatXu"].Value = txtTenXuatXu.Text.ToString();
                DGVXuatXu.CurrentRow.Cells["TrangThai"].Value = state == 1 ? "Active" : "Not Active";
                txtTenXuatXu.Text = "";
                txtMaXuatXu.Text = "";
                DGVXuatXu.ClearSelection();
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //DGVDoiTuong.Refresh();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadds();
            flag = 1;
            txtTenXuatXu.Text = "";
            txtMaXuatXu.Text = "";
            txtSearch.Text = "";
            DGVXuatXu.ClearSelection();
            ckbTrangThai.Visible = false;
            setEnable(true);
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
                string[] headers = { "maXuatXu", "tenXuatXu", "TrangThai" };

                // Add column headers
                for (int j = 0; j < headers.Length; j++)
                {
                    xlWorksheet.Cells[1, j + 1] = headers[j];
                    xlWorksheet.Columns[j + 1].ColumnWidth = DGVXuatXu.Columns[headers[j]].Width / 7; // Adjust column width based on DataGridView column width
                    xlWorksheet.Columns[j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Center align the column
                }

                // Loop through each row in the DataGridView
                for (int i = 0; i < DGVXuatXu.Rows.Count; i++)
                {
                    // Loop through each column in the DataGridView
                    for (int j = 0; j < headers.Length; j++)
                    {
                        // Populate Excel cells with data from the DataGridView
                        object value = DGVXuatXu.Rows[i].Cells[headers[j]].Value;

                        // Format cells based on data types
                        if (value != null)
                        {
                            if (headers[j] == "tenXuatXu") // Assuming SDT is the column name for phone number
                                xlWorksheet.Cells[i + 2, j + 1] = "'" + value.ToString(); // Prepend with a single quote to treat it as text                        
                            else if (headers[j] == "maXuatXu") // Assuming MaKH is the column name for customer ID
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

        private void DGVXuatXu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ckbTrangThai.Visible = true;
            DGVXuatXu.CurrentRow.Selected = true;
            // Lấy giá trị từ cột tương ứng và hiển thị lên TextBox
            txtMaXuatXu.Text = DGVXuatXu.CurrentRow.Cells["maXuatXu"].Value.ToString();
            txtTenXuatXu.Text = DGVXuatXu.CurrentRow.Cells["tenXuatXu"].Value.ToString();
            string temp = DGVXuatXu.CurrentRow.Cells["TrangThai"].Value.ToString();
            ckbTrangThai.Enabled = true;
            if (temp.Equals("Active", StringComparison.OrdinalIgnoreCase))
            {
                ckbTrangThai.Checked = true;
            }
            else
            {
                ckbTrangThai.Checked = false;
            }
            setEnable(false);
        }

        private void DGVXuatXu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ckbTrangThai.Visible = false;
            DGVXuatXu.ClearSelection();
            txtMaXuatXu.Text = "";
            txtTenXuatXu.Text = "";
            setEnable(true);
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

        private void backlbl_MouseClick(object sender, EventArgs e)
        {
            FormThuoc formthuoc = new FormThuoc();
            addFormtoPanelContainer(formthuoc);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DGVXuatXu.Rows.Clear();
            string text = txtSearch.Text.Trim().ToString();
            foreach (XuatXu item in bus.search(text))
            {
                string temp;
                int ma = int.Parse(item.MaXuatXu.ToString());
                string tenxuatxu = item.TenXuatXu.ToString();
                int state = int.Parse(item.TrangThai.ToString());
                if (state == 1)
                    temp = "Active";
                else
                    temp = "Not Active";
                DGVXuatXu.Rows.Add(ma, tenxuatxu, temp);
            }
        }

      
    }            
    
}
