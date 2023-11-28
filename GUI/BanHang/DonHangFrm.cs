using pharmacy_management.BUS;
using pharmacy_management.DTO;
using pharmacy_management.GUI.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace pharmacy_management.GUI.BanHang
{
    public partial class DonHangFrm : Form
    {
        DonHangRow dhRow;
        DonHangBUS dhBUS = new DonHangBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        QuyDoiDiemBUS qdBUS = new QuyDoiDiemBUS();
        PhieuGiamGiaBUS pggBUS = new PhieuGiamGiaBUS();
        public DonHangFrm()
        {
            InitializeComponent();
            setup();
        }

        public void setup()
        {
            dtp_start.MaxDate = DateTime.Now.AddYears(0);
            dtp_start.Value = DateTime.Parse("1990-01-01");
            dtp_end.MinDate = dtp_start.Value;
            dtp_end.MaxDate = DateTime.Now.AddYears(0);


            load_invoice();

        }
        public void setEmpty()
        {
            //flowLayoutPanel1.Controls.Clear();
            //var controlsToRemove = flowLayoutPanel1.Controls.OfType<DonHangRow>().ToList();

            //foreach (var control in controlsToRemove)
            //{
            //    flowLayoutPanel1.Controls.Remove(control);
            //    control.Dispose();
            //}

            this.gd_DonHang.Rows.Clear();

        }
        public void load_invoice()
        {

            DateTime dateStart = dtp_start.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dtp_end.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");
            //Console.WriteLine(formattedDateStart + "," + formattedDateEnd);
            dhBUS.loadList(formattedDateStart, formattedDateEnd, txt_searching.Text.Trim());
            foreach (DonHang dh in dhBUS.getList())
            {
                //dhRow = new DonHangRow();
                //dhRow.AddNewContent(dh);
                //this.flowLayoutPanel1.Controls.Add(dhRow);
                string quyDoi;
                if (dh.MaQuyDoi == 0)
                {
                    quyDoi = "Không dùng";
                }
                else
                {
                    quyDoi = dh.MaQuyDoi + "_" + pggBUS.GetNameBUS(dh.MaQuyDoi);
                }
                string tenNV = nvBUS.getNhanVien(dh.MaNV).TenNV;
                string tenKH = khBUS.getKH(dh.MaKH).TenKH;

                string formattedNumber = dh.ThanhTien.ToString("#,##0") + " đ";
                this.gd_DonHang.Rows.Add(dh.MaDH, tenNV, tenKH, quyDoi, dh.NgayLap, formattedNumber);

            }
        }

        /*public void load_invoice_price_ascend()
        {

            DateTime dateStart = dtp_start.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dtp_end.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");

            dhBUS.loadList_price_ascend(formattedDateStart, formattedDateEnd, txt_searching.Text.Trim());
            //Console.WriteLine(formattedDateStart + "," + formattedDateEnd);

            foreach (DonHang dh in dhBUS.getList())
            {
                dhRow = new DonHangRow();
                dhRow.AddNewContent(dh);
                this.flowLayoutPanel1.Controls.Add(dhRow);
            }
        }*/
        /*public void load_invoice_id_descend()
        {

            DateTime dateStart = dtp_start.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dtp_end.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");

            dhBUS.load_invoice_id_descend(formattedDateStart, formattedDateEnd, txt_searching.Text.Trim());
            //Console.WriteLine(formattedDateStart + "," + formattedDateEnd);

            foreach (DonHang dh in dhBUS.getList())
            {
                dhRow = new DonHangRow();
                dhRow.AddNewContent(dh);
                this.flowLayoutPanel1.Controls.Add(dhRow);
            }
        }*/
        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            dtp_end.MinDate = dtp_start.Value;
            setEmpty();
            load_invoice();
        }

        /*private void btn_increase_price_Click(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice_price_ascend();
        }*/

        /*private void btn_refresh_Click(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice();
        }*/

        /*private void btn_filter_Click(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice();
        }*/

        /*private void btn_descend_DonHang_Click(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice_id_descend();
        }*/

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ReportDonHangFrm rpt = new ReportDonHangFrm();
            rpt.Show();
        }

        private void txt_searching_TextChanged(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice();
        }

        private void gd_DonHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DonHang dh in dhBUS.getList())
            {
                if (dh.MaDH.ToString() == gd_DonHang.CurrentRow.Cells["MaDH"].Value.ToString())
                {
                    ChiTietDonHangFrm f = new ChiTietDonHangFrm();
                    f.AddNewContent(dh);
                    f.Show();
                    break;
                }
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
                string[] headers = { "MaDH", "MaNV", "MaKH", "MaQD", "Ngay", "ThanhTien" };

                // Add column headers
                for (int j = 0; j < headers.Length; j++)
                {
                    xlWorksheet.Cells[1, j + 1] = headers[j];
                    xlWorksheet.Columns[j + 1].ColumnWidth = gd_DonHang.Columns[headers[j]].Width / 7; // Adjust column width based on DataGridView column width
                    xlWorksheet.Columns[j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Center align the column
                }

                // Loop through each row in the DataGridView
                for (int i = 0; i < gd_DonHang.Rows.Count; i++)
                {
                    // Loop through each column in the DataGridView
                    for (int j = 0; j < headers.Length; j++)
                    {
                        // Populate Excel cells with data from the DataGridView
                        object value = gd_DonHang.Rows[i].Cells[headers[j]].Value;

                        // Format cells based on data types
                        if (value != null)
                        {
                            if (headers[j] == "MaDH")
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

        private void gd_DonHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            setEmpty();
            txt_searching.Text = "";
            setup();
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice();
        }
    }
}
