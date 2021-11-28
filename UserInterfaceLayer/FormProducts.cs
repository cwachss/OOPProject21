using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;


namespace UserInterfaceLayer
{
    public partial class FormProducts : Form
    {
        ProductBLL newBLL;

        public FormProducts()
        {
            InitializeComponent();
            newBLL = new ProductBLL();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            HideMenuButtons(); //leave main menu page

            buttonReturnMenu.Visible = true; //open up button that returns you to main menu
            groupBoxProductDetails.Visible = true; //open up group box to enter in new product info
            labelProductMenu.Text = "Add Product"; //change title of page

            textBoxPrintProducts.Size = new System.Drawing.Size(413, 365); //resize text box to make room for add panel
            textBoxPrintProducts.Visible = true; //allow you to see what products already exist
            PrintAll(); //prints all the products already in the system
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                newBLL.Create((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text)); //adds a product to the list
                textBoxPrintProducts.Clear(); //empty list box to reprint with new product added
                PrintAll(); //reprint list with new product added
            }
            catch (Exception)
            {
                MessageBox.Show($"Product information is invalid."); //maybe we should have different error messages depending on what is invalid (product number in use, price is not valid, etc)
            }
            /*newBLL.Create((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text));
            textBoxPrintProducts.Clear();
            PrintAll();*/
        }

        private void buttonReadOne_Click(object sender, EventArgs e)
        {
            HideMenuButtons();

            buttonReturnMenu.Visible = true;
            labelProductMenu.Text = "Find Product";
                        
           // newBLL.ReadOne();
        }


        private void buttonReadAll_Click(object sender, EventArgs e)
        {
            HideMenuButtons();
            PrintAll();
            
            //textBoxShowProduct.AppendText(product.ToString() + "\r\n");
            textBoxPrintProducts.Visible = true; //shows the textbox where the list will appear
            buttonReturnMenu.Visible = true; //shows button that allows you to return to the home page
           textBoxPrintProducts.Size = new System.Drawing.Size(680, 365); //makes product list text box take up full space
            labelProductMenu.Text = "All Products"; //change title

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            labelProductMenu.Text = "Modify Product"; //change title

            //open up all text boxes except product number to be edited
            textBoxName.ReadOnly = false; 
            textBoxPrice.ReadOnly = false;
            textBoxStock.ReadOnly = false;
            buttonModify.Visible = false; //we have gone to the modify page and no longer need this button
            //buttonDelete.Visible = false; //we have gone to the modify page and no longer need this button
            buttonUpdateProduct.Visible = true;

            newBLL.Update((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text));

        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            newBLL.Update((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text)); //update product with new details
            //return to find object page, this code is not done:
            buttonUpdateProduct.Visible = false;
            //buttonDelete.Visible = true;
            buttonModify.Visible = true;
        }


        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            ResetMainMenu();
            textBoxPrintProducts.Visible = false;
            buttonReturnMenu.Visible = false;
            labelProductMenu.Text = "Product Menu";
            groupBoxProductDetails.Visible = false;
        }

        private void HideMenuButtons()
        {
            buttonCreate.Visible = false;
            buttonReadAll.Visible = false;
            buttonReadOne.Visible = false;
           
            buttonCreate.Enabled = false;
            buttonReadAll.Enabled = false;
            buttonReadOne.Enabled = false;
          
            //labelProductMenu.Enabled = false;
        }

        private void ResetMainMenu()
        {
            buttonCreate.Visible = true;
            buttonReadAll.Visible = true;
            buttonReadOne.Visible = true;
         
            labelProductMenu.Visible = true;
            textBoxPrintProducts.Visible = false;
            textBoxPrintProducts.Clear();
            buttonCreate.Enabled = true;
            buttonReadAll.Enabled = true;
            buttonReadOne.Enabled = true;
        
            //labelProductMenu.Enabled = true;
        }

        /*private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }*/

       public void PrintAll()
        {
            foreach (Product product in newBLL.ReadAll()) //appends each product in the text box
            {
                textBoxPrintProducts.AppendText(product.ToString() + "\r\n");
            }
        }

        
    }
}
