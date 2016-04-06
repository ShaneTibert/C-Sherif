using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectICarus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            difficultyCombo.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerBox.Location != new Point(329, 181))
            {
                playerBox.Location = new Point(playerBox.Location.X + 45, playerBox.Location.Y);
            }
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 45);
            if (pictureBox2.Location.Y > playerBox.Location.Y)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, 26);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (playerBox.Location != new Point(239, 181))
            {
                playerBox.Location = new Point(playerBox.Location.X - 45, playerBox.Location.Y);
            }
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 45);
            if(pictureBox2.Location.Y > playerBox.Location.Y)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, 26);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            High_Scores scorePage = new High_Scores();
            scorePage.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startLabel.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startLabel.Show();
            startLabel.Text = "3";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            startLabel.Text = "2";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            startLabel.Text = "1";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            startLabel.Text = "Start!";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            startLabel.Hide();
            button4.Hide();
        }
    }
}
