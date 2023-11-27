using Krypton.Toolkit;
using pharmacy_management.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pharmacy_management.GUI
{

    public partial class QuenMKfrm : KryptonForm
    {
        DangNhapBUS dnbus = new DangNhapBUS();
        NhanVienBUS nvbus = new NhanVienBUS();
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();

        public QuenMKfrm()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DTO.NhanVien nv = nvbus.checkMail(txtmail.Text); 
            if (validate_emailaddress.IsMatch(txtmail.Text) != true)
            {
                MessageBox.Show("Email không hợp lệ!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmail.Focus();
                return;
            }
            if(nv == null)
            {
                MessageBox.Show("Không tìm thấy email!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                dnbus.sendMail(nv.Email);
                dnbus.resetPass(nv);

            }
        }
    }
}
