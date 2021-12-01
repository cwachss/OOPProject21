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
            buttonAdd.Enabled = true;
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
                MessageBox.Show($"Product information is invalid.","Error"); //maybe we should have different error messages depending on what is invalid (product number in use, price is not valid, etc)
            }
            /*newBLL.Create((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text));
            textBoxPrintProducts.Clear();
            PrintAll();*/
        }

        private void buttonReadOne_Click(object sender, EventArgs e)
        {
            HideMenuButtons();

            buttonReturnMenu.Visible = true; //allows you to return to main menu
            buttonReturnMenu.Enabled = true;
            labelProductMenu.Text = "Find Product"; //changes title
            labelEnterNumber.Visible = true; //instructions
            textBoxProductNumber2.Visible= true; //textbox to enter product number you want to find
            textBoxProductNumber2.Enabled = true; //allows you to use it
            buttonListDetails.Visible = true; //button prints product details into the textboxes
            buttonListDetails.Enabled = true; //button is now usable (we need to check if things are not enabled when invisible, because this might be quite redundant

            groupBoxProductDetails.Visible = true; //groupbox where details are printed
            buttonAdd.Visible = false; //this button is for the create method
            /*labelEnterNumber.Visible = false;
            textBoxProductNumber2.Visible = false;
            buttonListDetails.Visible = false;*/

            //you cannot edit product information in the find product mode
            textBoxProductNumber.Enabled = false; 
            textBoxName.Enabled = false;
            textBoxPrice.Enabled = false;
            textBoxStock.Enabled = false;
            
            //your two options for modify a product is to update the information or to delete it completely:
            buttonDelete2.Visible = true;
            buttonDelete2.Enabled = true;
            buttonModify.Visible = true;
            buttonModify.Enabled = true;

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
            textBoxName.Enabled = true; 
            textBoxPrice.Enabled = true;
            textBoxStock.Enabled = true;
            buttonModify.Visible = false; //we have gone to the modify page and no longer need this button
            buttonDelete2.Visible = false; //we have gone to the modify page and no longer need this button
            buttonUpdateProduct.Visible = true;
            


        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            newBLL.Update((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text)); //update product with new details
            //return to find object page, this code is not done:
            buttonUpdateProduct1.Visible = false;
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

        private void HideMenuButtons()
        {
            buttonCreate.Visible = false;
            buttonReadAll.Visible = false;
            buttonReadOne.Visible = false;
        //    buttonUpdate.Visible = false;
           
           
          //  buttonUpdate.Enabled = false;
          
            //labelProductMenu.Enabled = false;
        }

        private void ResetMainMenu()
        {
            buttonCreate.Visible = true;
            buttonReadAll.Visible = true;
            buttonReadOne.Visible = true;
         //   buttonUpdate.Visible = true;
           
            labelProductMenu.Visible = true;
            textBoxPrintProducts.Visible = false;
            textBoxPrintProducts.Clear();
            buttonCreate.Enabled = true;
            buttonReadAll.Enabled = true;
            buttonReadOne.Enabled = true;
        //    buttonUpdate.Enabled = true;
          
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
           // try
           // {
                

                Product newProduct = (newBLL.Read(int.Parse(textBoxProductNumber2.Text)));//it was getting too unwieldy so I created a product with this product's info in it. This may have been going farther than I needed to do, but i don't know.
                textBoxProductNumber.Text = Convert.ToString(newProduct.ProductNumber);
                textBoxPrice.Text = Convert.ToString(newProduct.CostPerUnit);
                textBoxStock.Text = Convert.ToString(newProduct.AmountInStock);
                textBoxName.Text = Convert.ToString(newProduct.ProductName);
           /* }
            catch(ProductNumberNotFound prodNum)
            {
                MessageBox.Show(prodNum.Message);
            }*/
        }

       

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            //buttonModify.Visible = false;
            //buttonModify.Enabled = false;
            
                newBLL.Delete(int.Parse(textBoxProductNumber.Text));
                MessageBox.Show($"Successfully deleted product number {textBoxProductNumber.Text}","Completed!");
                ResetMainMenu();
             
                buttonDelete2.Visible = false;
                groupBoxProductDetails.Visible = false;
                
                buttonReturnMenu.Visible = false;

            }
            /*catch(ProductNumberNotFound prodNum)
            {
                MessageBox.Show(prodNum.Message);
                buttonListDetails.Visible = true;
                textBoxProductNumber2.Enabled = true;
                textBoxProductNumber2.Visible = true;
                labelEnterNumber.Visible = true;
                buttonDelete2.Enabled = false;
                buttonDelete2.Visible = false;
                groupBoxProductDetails.Visible = false;
            }*/

           // textBoxProductNumber2.Visible = true;
            //textBoxName.Text = null;
            //textBoxPrice.Text = null;
            //textBoxProductNumber.Text = null;
            //textBoxStock.Text = null;
           

        


    }
}
