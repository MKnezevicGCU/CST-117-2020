using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1_MK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for clicking the button!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the first button!");
        }

        private void secondButton_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the second button!");
        }

        private void thirdButton_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the third button!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Theodore Roosevelt";
        }

        private void starPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sparkle!");
        }
    }
}
