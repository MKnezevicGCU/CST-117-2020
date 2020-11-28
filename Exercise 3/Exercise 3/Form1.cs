using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double pounds;    //Declaring pounds as a variable
            double kilograms; //Declaring kilograms as a variable
            double answer;    //Declaring the answer as a variable

            //Get the pounds from the text box.
            pounds = double.Parse(poundsTextBox.Text);

            //Set the kilograms
            kilograms = 0.45359237;

            //Calculate the pounds to kilograms
            answer = pounds * kilograms;

            //Display the answer in the label for answers.
            kilogramLabel.Text = answer.ToString("n4");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
