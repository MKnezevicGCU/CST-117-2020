using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double output = 0;
            try
            {
                int input = int.Parse(numberTermsTextBox.Text);
                int curr = 1;
                for (int i = 0; i < input; i++)
                {
                    output += 4D / curr * Math.Pow(-1, i + 1);
                    curr += 2;
                }
                output *= -1;
                valuePILabel.Text = "This has been looped " + input + " times.";
                piLabel.Text = output.ToString();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }
    }
}
