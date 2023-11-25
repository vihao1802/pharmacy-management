using pharmacy_management.BUS;
using pharmacy_management.DTO;
using pharmacy_management.GUI.BanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management.GUI.NhapHang
{
    public partial class PhieuNhapFrm : Form
    {
        PhieuNhapRow pnRow;
        public PhieuNhapFrm()
        {
            InitializeComponent();
            setup();
        }

        public void setup()
        {
            dtp_start.MaxDate = DateTime.Now.AddYears(0);
            dtp_start.Value = DateTime.Now.AddDays(-100);
            dtp_end.MinDate = dtp_start.Value;
            dtp_end.MaxDate = DateTime.Now.AddYears(0);


            load_invoice();

        }
        public void setEmpty()
        {
            //flowLayoutPanel1.Controls.Clear();
            var controlsToRemove = flowLayoutPanel1.Controls.OfType<PhieuNhapRow>().ToList();

            foreach (var control in controlsToRemove)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }

        }
        public void load_invoice()
        {
            PhieuNhapBUS pnBUS = new PhieuNhapBUS();

            DateTime dateStart = dtp_start.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dtp_end.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");
            //Console.WriteLine(formattedDateStart + "," + formattedDateEnd);
            pnBUS.loadList(formattedDateStart, formattedDateEnd, txt_searching.Text.Trim());
            foreach (PhieuNhap pn in pnBUS.getList())
            {
                pnRow = new PhieuNhapRow();
                pnRow.AddNewContent(pn);
                this.flowLayoutPanel1.Controls.Add(pnRow);
            }
        }

        public void load_invoice_price_ascend()
        {
            PhieuNhapBUS pnBUS = new PhieuNhapBUS();

            DateTime dateStart = dtp_start.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dtp_end.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");

            pnBUS.loadList_price_ascend(formattedDateStart, formattedDateEnd, txt_searching.Text.Trim());
            //Console.WriteLine(formattedDateStart + "," + formattedDateEnd);

            foreach (PhieuNhap pn in pnBUS.getList())
            {
                pnRow = new PhieuNhapRow();
                pnRow.AddNewContent(pn);
                this.flowLayoutPanel1.Controls.Add(pnRow);
            }
        }
        public void load_invoice_id_descend()
        {
            PhieuNhapBUS pnBUS = new PhieuNhapBUS();

            DateTime dateStart = dtp_start.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dtp_end.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");

            pnBUS.load_invoice_id_descend(formattedDateStart, formattedDateEnd, txt_searching.Text.Trim());
            //Console.WriteLine(formattedDateStart + "," + formattedDateEnd);

            foreach (PhieuNhap pn in pnBUS.getList())
            {
                pnRow = new PhieuNhapRow();
                pnRow.AddNewContent(pn);
                this.flowLayoutPanel1.Controls.Add(pnRow);
            }
        }
        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            dtp_end.MinDate = dtp_start.Value;
        }

        private void btn_increase_price_Click(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice_price_ascend();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice();
        }

        private void btn_descend_PhieuNhap_Click(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice_id_descend();
        }
    }
}

