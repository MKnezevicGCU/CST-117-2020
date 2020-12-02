using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The GetPersonData method accepts a person object
        //As an arguement. It assigns the data entered by the
        //user to the object's properties.
        private void GetPersonData(Person person)
        {
            //Temporary variable to hold phone number
            double phonenumber;
            double socialsecurity;
            decimal weight;

            //Get the person's eye color
            person.Eyecolor = eyeColorTextBox.Text;

            //Get the person's hair color
            person.Haircolor = hairColorTextBox.Text;

            //Get the person's skin color
            person.Skincolor = skinColorTextBox.Text;

            //Get the person's phone number.
            if (double.TryParse(phoneNumberTextBox.Text, out phonenumber))
            {
                person.Phonenumber = phonenumber;
            }
            else
            {
                //Display an error message.
                MessageBox.Show("Invalid phone number");
            }
            //Get the person's social security number
            if (double.TryParse(socialSecurityNumberTextBox.Text, out socialsecurity))
            {
                person.Socialsecurity = socialsecurity;
            }
            else
            {
                //Display an error message.
                MessageBox.Show("Invalid social security number");
            }
            //Get the person's weight.
            if (decimal.TryParse(weightTextBox.Text, out weight))
            {
                person.Weight = weight;
            }
            else
            {
                //Display an error message
                MessageBox.Show("Invalid weight");
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //Create a person object
            Person myPerson = new Person("","","",0,0,0m);

            //Get the person data
            GetPersonData(myPerson);

            //Display the person data
            eyeColorLabel.Text = myPerson.Eyecolor;
            hairColorLabel.Text = myPerson.Haircolor;
            skinColorLabel.Text = myPerson.Skincolor;
            phoneNumberLabel.Text = myPerson.Phonenumber.ToString("n");
            socialSecurityLabel.Text = myPerson.Socialsecurity.ToString("n");
            weightLabel.Text = myPerson.Weight.ToString("n2");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }
    }
}
