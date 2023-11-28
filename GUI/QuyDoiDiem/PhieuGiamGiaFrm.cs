using pharmacy_management.BUS;
using pharmacy_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pharmacy_management.GUI.QuyDoiDiem
{
    public partial class PhieuGiamGiaFrm : Form
    {
        PhieuGiamGiaBUS pggBUS = new PhieuGiamGiaBUS();

        public PhieuGiamGiaFrm()
        {
            InitializeComponent();
            setup();
        }

        public void setup()
        {
            load_data();
        }

        public void load_data()
        {
            gv_QDD.Rows.Clear();
            pggBUS = new PhieuGiamGiaBUS();
            pggBUS.loadListCondition(txt_searching.Text);
            foreach (PhieuGiamGia pgg in pggBUS.getList())
            {
                gv_QDD.Rows.Add(pgg.MaPhieuGiam, pgg.MaQuyDoi, pgg.MoTaPG, pgg.SoDiemQuyDoi, pgg.PhanTramGiam);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_DiemYC.Text) || string.IsNullOrEmpty(txt_MoTa.Text) || string.IsNullOrEmpty(txt_Giam.Text))
            //{
            //    MessageBox.Show("Thông tin không để trống");
            //    return;
            //}

            //if (!int.TryParse(txt_DiemYC.Text, out int _))
            //{
            //    MessageBox.Show(txt_DiemYC.Text + " không hợp lệ. Xin hãy nhập số");
            //    return;
            //}

            //if (!int.TryParse(txt_Giam.Text, out int _))
            //{
            //    MessageBox.Show(txt_Giam.Text + " không hợp lệ. Xin hãy nhập số");
            //    return;
            //}

            //DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm mới?", "Thêm mới", MessageBoxButtons.OKCancel);

            //if (result != DialogResult.OK)
            //{
            //    return;
            //}

            //string mota = txt_MoTa.Text;
            //string diem = txt_DiemYC.Text;
            //string phanTram = txt_Giam.Text;

            //pggBUS.insertItem(mota, diem, phanTram);
            //load_data();
        }

        private void txt_searching_TextChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void txt_searching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RichTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_export_excel_Click(object sender, EventArgs e)
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
                string[] headers = { "MaPhieuGiam", "MaQuyDoi", "MoTa", "DiemQuyDoi", "PhanTram" };

                // Add column headers
                for (int j = 0; j < headers.Length; j++)
                {
                    xlWorksheet.Cells[1, j + 1] = headers[j];
                    xlWorksheet.Columns[j + 1].ColumnWidth = gv_QDD.Columns[headers[j]].Width / 5; // Adjust column width based on DataGridView column width
                    xlWorksheet.Columns[j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Center align the column
                }

                // Loop through each row in the DataGridView
                for (int i = 0; i < gv_QDD.Rows.Count; i++)
                {
                    // Loop through each column in the DataGridView
                    for (int j = 0; j < headers.Length; j++)
                    {
                        // Populate Excel cells with data from the DataGridView
                        object value = gv_QDD.Rows[i].Cells[headers[j]].Value;

                        // Format cells based on data types
                        if (value != null)
                        {
                            //if (headers[j] == "SDT") // Assuming SDT is the column name for phone number
                            //xlWorksheet.Cells[i + 2, j + 1] = "'" + value.ToString(); // Prepend with a single quote to treat it as text
                            if (headers[j] == "MaPhieuGiam" || headers[j] == "MaQuyDoi" || headers[j] == "DiemQuyDoi" || headers[j] == "PhanTram") // Assuming MaNV and MaQuyen are columns with integer values
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
    }
}
