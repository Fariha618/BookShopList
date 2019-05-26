using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopListApp
{
    public partial class BookShopList : Form
    {
        public BookShopList()
        {
            InitializeComponent();
        }
        int index = 0;            
        private void SaveButton_Click(object sender, EventArgs e)
        {

            index++;

            List<string> names = new List<string>();
            List<string> contacts = new List<string>();
            List<string> addresses = new List<string>();
            List<string> orders = new List<string>();
            List<string> quantities = new List<string>();

            names.Add("Customer Name: " + nameTextBox.Text);
            contacts.Add("\nContact No. : "+ contactTextBox.Text);
            addresses.Add("\nAddress: " + addressTextBox.Text);
            orders.Add("\nOrder: " + orderComboBox.Text);
            quantities.Add("\nQuantity: " + quantityTextBox.Text);

            string message = "";
           
            for(int index = 0; index < names.Count; index++)
            {
                message = message + names[index] + contacts[index] + addresses[index] + orders[index] + quantities[index];
            }
                                    
            string price = "";
            int quantity;
            int cal;

            if (orderComboBox.Text == "Math - 120")
            {
                quantity = Convert.ToInt32(quantityTextBox.Text);
                cal = 120 * quantity;
                price = price + "\nTotal Price: " + cal + " BDT. \n";

            }

            else if (orderComboBox.Text == "English - 100")
            {

                quantity = Convert.ToInt32(quantityTextBox.Text);
                cal = 100 * quantity;
                price = price + "\nTotal Price: " + cal + " BDT. \n";

            }

            else if (orderComboBox.Text == "Bangla - 90")
            {

                quantity = Convert.ToInt32(quantityTextBox.Text);
                cal = 90 * quantity;
                price = price + "\nTotal Price: " + cal + " BDT. \n";

            }

            else
            {

                quantity = Convert.ToInt32(quantityTextBox.Text);
                cal = 80 * quantity;
                price = price + "\nTotal Price: " + cal + " BDT. \n";

            }
            
            showRichTextBox.Font = new Font("Times New Roman", 14);
            showRichTextBox.AppendText("\t\t Customer Information " + index + "\n\n" + message + price + "\n\n");
            
        }
    }
}
