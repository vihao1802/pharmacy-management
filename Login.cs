
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
using Krypton.Toolkit;
using pharmacy_management.BUS;
using pharmacy_management.DAO;
using pharmacy_management.DTO;
using pharmacy_management.GUI;

namespace thuoc
{
    public partial class Login : KryptonForm
    {
        public static NhanVien nv;
        DangNhapBUS bus = new DangNhapBUS();
        public Login()
        {
            InitializeComponent();
            txtuser.Text = pharmacy_management.Properties.Settings.Default.Username;
            txtpass.Text = pharmacy_management.Properties.Settings.Default.Password;
            ckbRemember.Checked = pharmacy_management.Properties.Settings.Default.Check;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (ckbRemember.Checked)
            {
                pharmacy_management.Properties.Settings.Default.Username = txtuser.Text;
                pharmacy_management.Properties.Settings.Default.Password = txtpass.Text;
                pharmacy_management.Properties.Settings.Default.Check = true;
                pharmacy_management.Properties.Settings.Default.Save();
            }
            XulyDangNhap();
        }
        private void XulyDangNhap()
        {
            nv = bus.dangnhap(txtuser.Text, txtpass.Text);
            if (txtuser.Text.Trim().Equals("") || txtpass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (nv != null)
            {
                pharmacy_management.GUI.Menu menu = new pharmacy_management.GUI.Menu();
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
                XulyDangNhap();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtpass.UseSystemPasswordChar)
            {
                txtpass.UseSystemPasswordChar = false;
            }else txtpass.UseSystemPasswordChar=true;
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
           // txtpass.UseSystemPasswordChar = false;
            
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            //txtpass.UseSystemPasswordChar = true;
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}

