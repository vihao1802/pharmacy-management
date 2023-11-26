using pharmacy_management.BUS;
using pharmacy_management.DTO;
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

namespace pharmacy_management.GUI.QuyDoiDiem
{
    public partial class QuyDoiDiemFrm : Form
    {
        QuyDoiDiemBUS qdBUS = new QuyDoiDiemBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        PhieuGiamGiaBUS pggBUS = new PhieuGiamGiaBUS();
        DiemKhachHangBUS dkhBUS = new DiemKhachHangBUS();

        public QuyDoiDiemFrm()
        {
            InitializeComponent();
            setup();
        }

        public void setVisible(Boolean flag)
        {
            dropDown_PG.Visible = flag;
            label3.Visible = flag;
            lbl_DiemHienCo.Visible = flag;
            lbl_DiemYeuCau.Visible = flag;
            label6.Visible = flag;
        }
        public void setup()
        {
            dtp_start.MaxDate = DateTime.Now.AddYears(0);
            dtp_start.Value = DateTime.Parse("1990-01-01");
            dtp_end.MinDate = dtp_start.Value;
            dtp_end.MaxDate = DateTime.Now.AddYears(0);

            //Console.WriteLine(dropBtn_KH.SelectedIndex);
            khBUS.loadList();
            foreach (DTO.KhachHang kh in khBUS.getList())
            {
                if (kh.MaKH == 1) { continue; }
                string item_name = kh.MaKH.ToString() + "_" + kh.TenKH;
                dropBtn_KH.Items.Add(item_name);
            }

            load_data();
            load_PhieuGiam();
            setVisible(false);
        }

        public void load_data()
        {
            gv_QDD.Rows.Clear();

            DateTime dateStart = dtp_start.Value;
            string formattedDateStart = dateStart.ToString("yyyy-MM-dd");
            DateTime dateEnd = dtp_end.Value;
            string formattedDateEnd = dateEnd.ToString("yyyy-MM-dd");

            qdBUS.loadAll(formattedDateStart, formattedDateEnd, txt_searching.Text.Trim());
            foreach (DTO.QuyDoiDiem qd in qdBUS.getList())
            {
                string status = "";
                if (qd.DaSuDung == 0)
                {
                    status = "Chưa dùng";
                }
                else
                {
                    status = "Đã dùng";
                }
                gv_QDD.Rows.Add(qd.MaQuyDoi, qd.MaKH, qd.NgayQuyDoi, qd.MaPhieuGiam, status);
            }
        }

        public void load_PhieuGiam()
        {
            dropDown_PG.Items.Clear();

            foreach (PhieuGiamGia gg in pggBUS.getList())
            {
                string item_name = gg.MaPhieuGiam.ToString() + "_" + gg.MoTaPG;
                dropDown_PG.Items.Add(item_name);
            }
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            dtp_end.MinDate = dtp_start.Value;

        }

        private void dropBtn_KH_SelectedIndexChanged(object sender, EventArgs e)
        {
            setVisible(true);
            string selectedText = dropBtn_KH.SelectedItem.ToString();
            string[] arr = selectedText.Split('_');
            string maKH = arr[0];

            DiemKhachHang tmp = dkhBUS.GetItem(maKH);

            string formattedNumber = tmp.DiemTichLuy.ToString("#,##0");
            lbl_DiemHienCo.Text = formattedNumber;


        }

        private void dropDown_PG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = dropDown_PG.SelectedItem.ToString();
            string[] arr = selectedText.Split('_');
            string maPG = arr[0];
            foreach (PhieuGiamGia gg in pggBUS.getList())
            {
                if (gg.MaPhieuGiam.ToString().Equals(maPG))
                {
                    string formattedNumber = gg.SoDiemQuyDoi.ToString("#,##0");
                    lbl_DiemYeuCau.Text = formattedNumber;
                    break;
                }
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_ThemQDD_Click(object sender, EventArgs e)
        {
            if (dropBtn_KH.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn khách hàng trước khi quy đổi điểm");
                return;
            }
            if (dropDown_PG.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn phiếu giảm trước khi quy đổi điểm");
                return;
            }


            string selectedText = dropDown_PG.SelectedItem.ToString();
            string[] arr = selectedText.Split('_');
            string maPG = arr[0];

            selectedText = dropBtn_KH.SelectedItem.ToString();
            arr = selectedText.Split('_');
            string maKH = arr[0];

            int diemKH = Int32.Parse(lbl_DiemHienCo.Text.Replace(",", ""));
            int diemYeuCau = Int32.Parse(lbl_DiemYeuCau.Text.Replace(",", ""));


            if (diemKH < diemYeuCau || diemKH == 0)
            {
                MessageBox.Show("Không đủ điểm để quy đổi");
                return;
            }

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            DialogResult result = MessageBox.Show("Bạn có chắc muốn quy đổi?", "Quy đổi điểm", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK)
            {
                return;
            }

            qdBUS.insertItem(maKH, currentDate, maPG);

            diemKH -= diemYeuCau;
            string formattedNumber = diemKH.ToString("#,##0");
            lbl_DiemHienCo.Text = formattedNumber;

            dkhBUS.updateDiemKHSauQD(diemKH.ToString(), maKH);
            load_data();
            MessageBox.Show("Quy đổi thành công");

        }

        private void txt_searching_TextChanged(object sender, EventArgs e)
        {
            load_data();
        }

    }
}
