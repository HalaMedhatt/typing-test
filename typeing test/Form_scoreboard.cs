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
    public partial class Form_scoreboard : Form
    {
        public Form_scoreboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_scoreboard_Load(object sender, EventArgs e)
        {
            dataGridView_scoreboard.Rows.Add(1, "350", "Hala");
            dataGridView_scoreboard.Rows.Add(2, "300", "medhat");
            dataGridView_scoreboard.Rows.Add(3, "100", "reda");
            dataGridView_scoreboard.Rows.Add(4, "50", "abdallem");
            dataGridView_scoreboard.AllowUserToAddRows = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_username_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form_user_history().Show();

        }
    }
}
