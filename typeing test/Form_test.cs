using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace typeing_test
{
    public partial class Form_test : Form
    {
        long score = 0;
        public Form_test()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // enable timer
            timer_test.Start();
            // randomly choose char
            label_char_test.Text = GetRandomCharater().ToString();
            // randomly choose char location
            label_char_test.Location = getNewPoint();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            timer_test.Stop();
            score = 0;
            label_score.Text = "Score " + score;
            label_char_test.Location = new Point(200,100);
            label_char_test.Text ="";

        }
        private void button_pause_Click(object sender, EventArgs e)
        {
            timer_test.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer_test_Tick(object sender, EventArgs e)
        {
            // increas top pixsels by 5
            label_char_test.Top += 5;
            // when char reach bottom
            if (label_char_test.Top >= panel_test.Height)
            {

                score -= 5;
                label_score.Text = "Score " + score;
                // randomly choose char location
                label_char_test.Location = getNewPoint();
                // randomly choose char
                label_char_test.Text = GetRandomCharater().ToString();
            }
        }
        Random randomRharacter = new Random();
        private char GetRandomCharater()
        {
            // rendomly choose char 
            return (char)randomRharacter.Next(97, 123);
        }
        Random xLocation = new Random();
        private Point getNewPoint()
        {
            // randomly choose x from zero to the panal width - label width
            // and y = 0 
            int x = xLocation.Next(0, panel_test.Width - label_char_test.Width);
            return new Point(x, 0);
        }
        private void label_chat_test_Click(object sender, EventArgs e)
        {

        }

        private void Form_test_KeyPress(object sender, KeyPressEventArgs e)
        {
            char userPressKey = e.KeyChar;
            if (label_char_test.Text == userPressKey.ToString())
            {
                score += 5;
                label_score.Text = "Score " + score;
                label_char_test.Location = getNewPoint();
                label_char_test.Text = GetRandomCharater().ToString();
            }
            else
            {
                score -= 5;
                label_score.Text = "Score " + score;
            }
        }

        private void button_show_scoreboard_Click(object sender, EventArgs e)
        {
            new Form_scoreboard().Show();
        }

        private void panel_test_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
