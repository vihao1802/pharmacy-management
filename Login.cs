using System;
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
