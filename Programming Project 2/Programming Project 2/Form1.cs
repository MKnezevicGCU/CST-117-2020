using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            //Creating variables.
            string name;

            //checking to see what variable is gotten from the ListBox.
            if (shapeListBox.SelectedIndex != -1)
            {
                //Get the selected item.
                name = shapeListBox.SelectedItem.ToString();

                //determine which shape it is
                switch (name)
                {
                    case "Circle":
                        MessageBox.Show("This is a Circle.");
                        break;
                    case "Triangle":
                        MessageBox.Show("This is a Triangle.");
                        break;
                    case "Rectangle":
                        MessageBox.Show("This is a Rectangle");
                        break;
                    case "Pentagon":
                        MessageBox.Show("This is a Pentagon.");
                        break;
                    case "Hexagon":
                        MessageBox.Show("This is a Hexagon.");
                        break;
                }
            }
            else
            {
                //No shape was select.
                MessageBox.Show("Select a shape.");
            }
        }

        private void fillRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fillRadioButton.Checked)
            {
                MessageBox.Show("You selected Filled.");
            }
            else if (outlineRadioButton.Checked)
            {
                MessageBox.Show("You selected outlined.");
            }
        }

        private void nameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            

            if (nameCheckBox.Checked)
            {
                nameOutputLabel.Text = "Circle.";
            }
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dateCheckBox.Checked)
            {
                dateOutputLabel.Text = "11/30/2020";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the selected indice.
            shapeListBox.SelectedIndices.Clear();
            fillRadioButton.Focus();
            nameCheckBox.Checked = false;
            dateCheckBox.Checked = false;
        }
    }
}
