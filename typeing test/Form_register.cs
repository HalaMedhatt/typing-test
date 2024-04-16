namespace typeing_test
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "" || textBox_confirm_password.Text == "")
            {
                MessageBox.Show("Username or Password is empty", "Regisration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_password.Text != textBox_confirm_password.Text)
            {
                MessageBox.Show("Passwords does not match", "Regisration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_password.Text = "";
                textBox_confirm_password.Text = "";
            }
            else
            {
                MessageBox.Show("Your Account has been successfully created", "Regisration succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Form_test().Show();
                this.Hide();
            }
        }

        private void textBox_passward_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_password.Checked)
            {
                textBox_password.PasswordChar = '\0';
                textBox_confirm_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '*';
                textBox_confirm_password.PasswordChar = '*';

            }
        }

        private void label_back_to_login_Click(object sender, EventArgs e)
        {
            new Form_login().Show();
            this.Hide();
        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }
    }
}
