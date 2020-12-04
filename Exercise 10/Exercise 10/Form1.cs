using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchText_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains("t"))
            {
                int countT = this.textBox1.Text.Split('t').Length - 1;
                MessageBox.Show("Contains T=" + countT);
            }
                
            if (this.textBox1.Text.Contains("e"))
            {
                int countE = this.textBox1.Text.Split('e').Length - 1;
                MessageBox.Show("Contains E=" + countE);
            }
        }
    }
}
