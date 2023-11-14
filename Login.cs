<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using pharmacy_management.BUS;
using pharmacy_management.DAO;
using pharmacy_management.DTO;
using pharmacy_management.GUI;

namespace thuoc
{
    public partial class Login : KryptonForm
    {
        public static NhanVien nv;
        DangNhapDAO dao = new DangNhapDAO();
        DangNhapBUS bus = new DangNhapBUS();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            XulyDangNhap();
        }
        private void XulyDangNhap()
        {
            nv = bus.dangnhap(txtuser.Text, txtpass.Text);
            if (nv != null)
            {
                GUI.Menu menu = new GUI.Menu();
                menu.Show();

                this.Close();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, kiểm tra lại thông tin");
                return;

            }
        }
        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kryptonButton1_Click((object)sender, e);
            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                XulyDangNhap();
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                XulyDangNhap();
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using thuoc.GUI;

namespace thuoc
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if(txtuser.Text.Equals("duc") && txtpass.Text.Equals("123"))
            {
                Program.MenuForm = new GUI.Menu();
                Program.MenuForm.Show();
                
                Program.LoginForm.Close();

            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kryptonButton1_Click((object)sender, e);
            }
        }
    }
}
>>>>>>> 807995ace6f7578ec629a8f9edb0f248d0f0a5e3
