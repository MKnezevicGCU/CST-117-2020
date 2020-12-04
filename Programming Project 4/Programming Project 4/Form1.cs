using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_4
{
    public partial class Form1 : Form
    {
        bool isMyTurn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text.Contains("X") || this.button1.Text.Contains("O"))
            {
                return;
            }
            this.button1.Text = isMyTurn ? "X" : "O";
            isMyTurn = !isMyTurn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text.Contains("X") || this.button2.Text.Contains("O"))
            {
                return;
            }
            this.button2.Text = isMyTurn ? "X" : "O";
            isMyTurn = !isMyTurn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button3.Text.Contains("X") || this.button3.Text.Contains("O"))
            {
                return;
            }
            this.button3.Text = isMyTurn ? "X" : "O";
            isMyTurn = !isMyTurn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.Text.Contains("X") || this.button4.Text.Contains("O"))
            {
                return;
            }
            this.button4.Text = isMyTurn ? "X" : "O";
            isMyTurn = !isMyTurn;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button5.Text.Contains("X") || this.button5.Text.Contains("O"))
            {
                return;
            }
            this.button5.Text = isMyTurn ? "X" : "O";
            isMyTurn = !isMyTurn;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.button6.Text.Contains("X") || this.button6.Text.Contains("O"))
            {
                return;
            }
            this.button6.Text = isMyTurn ? "X" : "O";
            isMyTurn = !isMyTurn;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.button7.Text.Contains("X") || this.button7.Text.Contains("O"))
            {
                return;
            }
            this.button7.Text = isMyTurn ? "X" : "O";
            isMyTurn = !isMyTurn;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.button8.Text.Contains("X") || this.button8.Text.Contains("O"))
            {
                return;
            }
            this.button8.Text = isMyTurn ? "X" : "O";
            isMyTurn = !isMyTurn;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.button9.Text.Contains("X") || this.button9.Text.Contains("O"))
            {
                return;
            }
            this.button9.Text = isMyTurn ? "X" : "O";
            isMyTurn = !isMyTurn;
        }
    }
}
