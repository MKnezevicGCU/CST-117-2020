using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaring constants
                const double MINUTES = 60;
                const double HOURS = 3600;
                const double DAYS = 86400;

                //Declaring variables
                double seconds;
                double minutesAnswer;
                double hoursAnswer;
                double daysAnswer;

                //Get the seconds from the TextBox.
                seconds = double.Parse(secondsInputTextBox.Text);

                //Determine if there are more than 60 seconds
                if (seconds >= MINUTES)
                {
                    //Calculate if there are more seconds then minutes then display the number.
                    minutesAnswer = seconds / MINUTES;
                    
                    //Display the answer in minutes
                    minutesOutputLabel.Text = minutesAnswer.ToString("n");
          
                }
                if (seconds >= HOURS)
                {
                    //Calculate the number of hours there are in the seconds entered.
                    hoursAnswer = seconds / HOURS;

                    //Display the number of hours.
                    hoursOutputLabel.Text = hoursAnswer.ToString("n");
                }
                if (seconds >= DAYS)
                {
                    //Calculate the number of days there are in the seconds entered.
                    daysAnswer = seconds / DAYS;

                    //Display the number of days.
                    daysOutputLabel.Text = daysAnswer.ToString("n");
                }
                else
                {
                    //The number of seconds aren't sufficient
                    daysOutputLabel.Text = "The number of seconds entered is not sufficient.";
                }
            }
            catch (Exception ex)
            {
                //Display the error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
