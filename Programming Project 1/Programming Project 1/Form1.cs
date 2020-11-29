using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
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
                kilogramsOutputLabel.Text = answer.ToString("n3");
            }
            catch (Exception ex)
            {
                //Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
