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
using DAL; 


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

            buttonAdd.Visible = true;
          
            buttonReturnMenu.Visible = true; //open up button that returns you to main menu
            groupBoxProductDetails.Visible = true; //open up group box to enter in new product info
            labelProductMenu.Text = "Add Product"; //change title of page
            //allows you to type in the new product info:
            textBoxProductNumber.Enabled = true;
            textBoxName.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxStock.Enabled = true;


            textBoxPrintProducts.Size = new System.Drawing.Size(436, 397); //resize text box to make room for add panel
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
                MessageBox.Show("Product information is invalid.", "Error"); //maybe we should have different error messages depending on what is invalid (product number in use, price is not valid, etc)
            }
            /*newBLL.Create((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text));
            textBoxPrintProducts.Clear();
            PrintAll();*/
        }

        private void buttonReadOne_Click(object sender, EventArgs e)
        {
            labelProductMenu.Text = "Find Product";

            //you cannot edit product information in the find product mode
            textBoxProductNumber.Enabled = false;
            textBoxName.Enabled = false;
            textBoxPrice.Enabled = false;
            textBoxStock.Enabled = false;

        }


        private void buttonReadAll_Click(object sender, EventArgs e)
        {
            HideMenuButtons();
            try
            {
                PrintAll();
            }
            catch
            {
                MessageBox.Show("No products found. Please add to inventory.", "Error");
            }

            //textBoxShowProduct.AppendText(product.ToString() + "\r\n");
            textBoxPrintProducts.Visible = true; //shows the textbox where the list will appear
            buttonReturnMenu.Visible = true; //shows button that allows you to return to the home page
            textBoxPrintProducts.Size = new System.Drawing.Size(732, 397); //makes product list text box take up full space
            labelProductMenu.Text = "All Products"; //change title

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
           
            //open up all text boxes except product number to be edited:
            textBoxName.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxStock.Enabled = true;
            buttonModify.Visible = false; //we have gone to the modify page and no longer need this button
            buttonDelete2.Visible = false; //we have gone to the modify page and no longer need this button
            buttonUpdateProduct.Visible = true;



        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                newBLL.Update((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text)); //update product with new details
                
                //return to find object page:
                buttonUpdateProduct.Visible = false;               
                buttonModify.Visible = true;
                buttonDelete2.Visible = true;
                textBoxName.Enabled = false;
                textBoxPrice.Enabled = false;
                textBoxStock.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Product information is invalid.", "Error");
            }
        }


        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            ResetMainMenu();

            ResetEverythingAndHideIt();
        }

        private void HideMenuButtons()
        {
            buttonCreate.Visible = false;
            buttonReadAll.Visible = false;
            buttonReadOne.Visible = false;
        }

        private void ResetMainMenu()
        {
            buttonCreate.Visible = true;
            buttonReadAll.Visible = true;
            buttonReadOne.Visible = true;              
        }

        private void ResetEverythingAndHideIt()
        {
            textBoxPrintProducts.Visible = false;
            textBoxPrintProducts.Clear();
            buttonReturnMenu.Visible = false;
            labelProductMenu.Text = "Product Menu";
            groupBoxProductDetails.Visible = false;
            buttonDelete2.Visible = false;
            buttonListDetails.Visible = false;
            textBoxProductNumber2.Visible = false;
            buttonModify.Visible = false;
            textBoxProductNumber.Clear();
            textBoxName.Clear();
            textBoxStock.Clear();
            textBoxPrice.Clear();
            labelEnterNumber.Visible = false;
            buttonUpdateProduct.Visible = false;
            buttonAdd.Visible = false;
        }

        public void PrintAll()
        {

            foreach (Product product in newBLL.ReadAll()) //appends each product in the text box
            {
                textBoxPrintProducts.AppendText(product.ToString() + "\r\n");
            }



        }

        /// <summary>
        /// Deletes a product from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// displays details of certain product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListDetails_Click_1(object sender, EventArgs e)
        {
            try
            {
                Product newProduct = (newBLL.Read(int.Parse(textBoxProductNumber2.Text)));//it was getting too unwieldy so I created a product with this product's info in it. This may have been going farther than I needed to do, but i don't know.
                textBoxProductNumber.Text = Convert.ToString(newProduct.ProductNumber);
                textBoxPrice.Text = Convert.ToString(newProduct.CostPerUnit);
                textBoxStock.Text = Convert.ToString(newProduct.AmountInStock);
                textBoxName.Text = Convert.ToString(newProduct.ProductName);
                buttonDelete2.Enabled = true;
                buttonModify.Enabled = true;
            }
            catch (ProductNumberNotFound prodNum)
            {
                MessageBox.Show(prodNum.Message);
            }
            catch
            {
                MessageBox.Show("Product not found.", "Error");
            }
        }



        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            //add exception catch maybe? or just disable the modify and delete buttons? something should be done. maybe we should reset the list details and empty all the text boxes...

            newBLL.Delete(int.Parse(textBoxProductNumber.Text));
            MessageBox.Show($"Successfully deleted product number {textBoxProductNumber.Text}", "Completed!");
            textBoxProductNumber2.Clear();
            textBoxProductNumber.Clear();
            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxStock.Clear();
            buttonDelete2.Enabled = false;
            buttonModify.Enabled = false;
        }

        /*
        some random ideas yet unrealized for the product category:
        automatically generated product numbers in the add section
        maybe we should have the product list teztbox in the find section
        the ability to click on a product in the textbox as a find method in addition to finding it through the product number

*/

    }
}
