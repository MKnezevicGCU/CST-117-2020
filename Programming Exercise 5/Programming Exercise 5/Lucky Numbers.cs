using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Exercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getLuckyNumbersButton_Click(object sender, EventArgs e)
        {
            //Create an instance of the MessageForm class.
            int luckyNumber = 0;
            int dayNumber = 0;
            int favoriteNNumber = 0;

            if (!int.TryParse(favoriteNumber.Text, out favoriteNNumber))
            {
                MessageBox.Show("Can't covert this is not an integer");
                return;
            }

            if (!int.TryParse(DayBorn.Text, out dayNumber))
            {
                MessageBox.Show("Can't convert this. It is not an integer");
                return;
            }

            luckyNumber = dayNumber + favoriteNNumber;



            Your_Results_ resultsForm = new Your_Results_(luckyNumber);

            //Display the form
            resultsForm.ShowDialog();
        }
    }
}
