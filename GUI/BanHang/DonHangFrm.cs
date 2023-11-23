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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace pharmacy_management.GUI.BanHang
{
    public partial class DonHangFrm : Form
    {
        DonHangRow dhRow;
        public DonHangFrm()
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
            var controlsToRemove = flowLayoutPanel1.Controls.OfType<DonHangRow>().ToList();

            foreach (var control in controlsToRemove)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }

        }
        public void load_invoice()
        {
            DonHangBUS dhBUS = new DonHangBUS();

            DateTime dateStart = dtp_start.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dtp_end.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");
            //Console.WriteLine(formattedDateStart + "," + formattedDateEnd);
            dhBUS.loadList(formattedDateStart, formattedDateEnd, txt_searching.Text.Trim());
            foreach (DonHang dh in dhBUS.getList())
            {
                dhRow = new DonHangRow();
                dhRow.AddNewContent(dh);
                this.flowLayoutPanel1.Controls.Add(dhRow);
            }
        }

        public void load_invoice_price_ascend()
        {
            DonHangBUS dhBUS = new DonHangBUS();

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
        }
        public void load_invoice_id_descend()
        {
            DonHangBUS dhBUS = new DonHangBUS();

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

        private void btn_descend_DonHang_Click(object sender, EventArgs e)
        {
            setEmpty();
            load_invoice_id_descend();
        }
    }
}
