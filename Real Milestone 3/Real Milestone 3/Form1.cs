using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Milestone_3
{
    public partial class Form1 : Form
    {
        InventoryManager inventoryManager = new InventoryManager();
        public Form1()
        {
            InitializeComponent();
        }

        //The GetPersonData method accepts a person object
        //As an arguement. It assigns the data entered by the
        //user to the object's properties.
        private void GetPersonData(Person person)
        {
            
            

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Get the person's weight
            int personID = 0;
            double socialSecurity = 0;
            double phoneNumber = 0;
            int prodID = 0;
            decimal price = 0;

            if (!int.TryParse(productID.Text, out prodID))
            {
                MessageBox.Show("Cannot Convert");
                return;
            }

            if(!decimal.TryParse(productPrice.Text, out price))
            {
                MessageBox.Show("Cannot Convert");
                return;
            }
            

            
            if (int.TryParse(personIDTextBox.Text, out personID))
            {

               

                //I tried to add the textbox
                Person myPerson = new Person(this.firstName.Text, this.lastName.Text, "" , phoneNumber, socialSecurity, personID);

                Product myproduct = new Product() { Name = this.productName.Text, Price = price, ProductId= prodID};
                this.inventoryManager.Add(myPerson, myproduct);
                this.personListBox.Items.Add(myPerson.Firstname + " " + myPerson.Lastname + " " + myPerson.Address + " " + myPerson.Phonenumber + " " + myPerson.Socialsecurity + " " + myPerson.Personid + myproduct.Name+ " " + myproduct.Price + " " + myproduct.ProductId);
            }
        }
    }
}
