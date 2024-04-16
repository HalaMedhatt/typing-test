using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typeing_test
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username_login.Text == "" || textBox_password_login.Text == "")
            {
                MessageBox.Show("Username or Password is empty", "Regisration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Your Account has been successfully created", "Regisration succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Form_test().Show();
                this.Hide();
            }
        }

        private void checkBox_show_password_login_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_password_login.Checked)
            {
                textBox_password_login.PasswordChar = '\0';
            }
            else
            {
                textBox_password_login.PasswordChar = '*';
            }
        }

        private void textBox_username_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_create_account_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void textBox_password_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
