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
    
    public partial class Your_Results_ : Form
    {
        public Your_Results_(int result)
        {
            InitializeComponent();
            this.resultBox.Text = result.ToString();
        }

        public int result { get; set; }


    }
}
