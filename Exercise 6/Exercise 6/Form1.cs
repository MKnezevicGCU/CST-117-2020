using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            Dice dice1 = new Dice(6); //Constructor calling 6
            Dice dice2 = new Dice(6); //Constructor calling 6

            int x = 0;
            int y = 0;
            int count = 0;

            while(x != 1 && y != 1)
            {
                x = dice1.Roll();
                y = dice2.Roll();
                count++;
            }

            triesLabel.Text = count.ToString();
            dice2Label.Text = y.ToString();
            dice1Label.Text = x.ToString();
        }
    }
}
