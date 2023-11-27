using iTextSharp.text;
using iTextSharp.text.pdf;
using Krypton.Toolkit;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
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
using System.Xml.Linq;

namespace pharmacy_management.GUI.BanHang
{
    public partial class ChiTietDonHangFrm : KryptonForm
    {
        DonHang dh;
        string formattedNumber = "";
        public ChiTietDonHangFrm()
        {
            InitializeComponent();
        }

        public void AddNewContent(DonHang dh_info)
        {
            dh = dh_info;

            lbl_MaDH.Text = "#" + dh.MaDH.ToString();
            lbl_MaKH.Text = "#" + dh.MaKH.ToString();
            lbl_MaNV.Text = "#" + dh.MaNV.ToString();
            lbl_NgayLap.Text = dh.NgayLap;

            NhanVienBUS nvBUS = new NhanVienBUS();
            DTO.NhanVien nv = nvBUS.getNhanVien(dh.MaNV);
            lbl_TenNV.Text = nv.TenNV;

            KhachHangBUS khBUS = new KhachHangBUS();
            DTO.KhachHang kh = khBUS.getKH(dh.MaKH);
            lbl_TenKH.Text = kh.TenKH;
            lbl_sdtKH.Text = kh.Sdt;

            ChiTietDonHangBUS ctdhBUS = new ChiTietDonHangBUS();
            ThuocBUS tBUS = new ThuocBUS();
            DTO.Thuoc t;
            foreach (ChiTietDonHang item in ctdhBUS.getListWithID(dh.MaDH))
            {
                string price = item.DonGia.ToString("#,##0") + " đ";
                string final = item.ThanhTien.ToString("#,##0") + " đ";

                t = tBUS.getItem(item.MaThuoc);
                gv_SanPhamDH.Rows.Add(item.MaThuoc, t.TenThuoc, item.SoLuong, price, final);
            }

            formattedNumber = dh.TongGia.ToString("#,##0") + " đ";
            lbl_TongGia.Text = formattedNumber;

            QuyDoiDiemBUS qdBUS = new QuyDoiDiemBUS();
            PhieuGiamGiaBUS pgBUS = new PhieuGiamGiaBUS();
            string percent = pgBUS.getPhanTramGiamBUS(dh.MaQuyDoi);
            if (percent == "")
            {
                lbl_Giam.Text = "0%";
            }
            else
            {
                lbl_Giam.Text = percent + "%";
            }

            formattedNumber = dh.ThanhTien.ToString("#,##0") + " đ";
            lbl_ThanhTien.Text = formattedNumber;

        }

        /*private void btn_export_PDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Save PDF File",
                FileName = "ExportedData.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToPdf(gv_SanPhamDH, saveFileDialog.FileName);
            }
        }*/

        /*private void ExportDataGridViewToPdf(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (PdfWriter pdfWriter = GetPdfWriter(filePath))
                {
                    using (PdfDocument pdfDocument = GetPdfDocument(pdfWriter))
                    {
                        Document document = new Document(pdfDocument);

                        // Add a title to the PDF document
                        document.Add(new iTextSharp.Paragraph("Exported Data from DataGridView"));

                        // Create a table with columns based on the DataGridView
                        Table table = new Table(dataGridView.ColumnCount);

                        // Add header row
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(column.HeaderText)));
                        }

                        // Add data rows
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                            }
                        }

                        // Add the table to the document
                        document.Add(table);
                    }
                }

                MessageBox.Show("Data exported to PDF successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data to PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static PdfDocument GetPdfDocument(PdfWriter pdfWriter)
        {
            return new PdfDocument(pdfWriter);
        }

        private static PdfWriter GetPdfWriter(string filePath)
        {
            return new PdfWriter(filePath);
        }*/
    }
}
