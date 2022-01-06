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

namespace UserInterface2._0
{
    public partial class ProductForm : BaseForm
    {
        ProductBLL productBLL = new ProductBLL();
        public ProductForm()
        {
            InitializeComponent();

        }

        public override void buttonReadOne_Click(object sender, EventArgs e)
        {
            base.buttonReadOne_Click(sender, e);
            labelProductMenu.Text = "Find Product";

            //you cannot edit product information in the find product mode
            textBoxProductNumber.Enabled = false;
            textBoxName.Enabled = false;
            textBoxPrice.Enabled = false;
            textBoxStock.Enabled = false;
            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;

        }

        public override void buttonListDetails_Click(object sender, EventArgs e)
        {
            try
            {
               
                Product newProduct = (productBLL.Read(int.Parse(textBoxProductNumber2.Text)));
                textBoxProductNumber.Text = Convert.ToString(newProduct.ProductNumber);
                textBoxPrice.Text = Convert.ToString(newProduct.CostPerUnit);
                textBoxStock.Text = Convert.ToString(newProduct.AmountInStock);
                textBoxName.Text = Convert.ToString(newProduct.ProductName);
                buttonDelete.Enabled = true;
                buttonModify.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Product not found.", "Error");
            }
        }


        public override void buttonModify_Click(object sender, EventArgs e)
        {
            base.buttonModify_Click(sender, e);
            //open up all text boxes except product number to be edited:
            textBoxName.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxStock.Enabled = true;
        }

        //updates product and disenables buttons from modification
        public override void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                productBLL.Update((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, 
                    decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text)); //update product with new details

                
                textBoxName.Enabled = false;
                textBoxPrice.Enabled = false;
                textBoxStock.Enabled = false;

                base.buttonUpdateProduct_Click(sender, e);

                MessageBox.Show("Product Information Updated.");
            }
            catch
            {
                MessageBox.Show("Product information is invalid.", "Error");
            }
        }

        //deletes product
        public override void buttonDelete_Click(object sender, EventArgs e)
        {
            productBLL.Delete(int.Parse(textBoxProductNumber.Text));
            MessageBox.Show($"Successfully deleted product number {textBoxProductNumber.Text}", "Completed!");
            textBoxProductNumber2.Clear();
            textBoxProductNumber.Clear();
            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxStock.Clear();
            buttonDelete.Enabled = false;
            buttonModify.Enabled = false;
        }

        //Hides product form nad re-shows the mainMenu
        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetMainMenu();
            ResetAndHideEverything();
            FormProvider.MainMenu.Show();

        }

        //information about the app's company
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toys of All Sorts is an abstract toy company by Shira Laury and Chani Wachsstock");
        }


        //opens to adding a new product page
        public override void buttonCreate_Click(object sender, EventArgs e)
        {
            base.buttonCreate_Click(sender, e);
            buttonAdd.Visible = true;
            buttonReturnMenu.Visible = true; //open up button that returns you to main menu
            labelProductMenu.Text = "Add Product"; //change title of page
            //allows you to type in the new product info:
            textBoxProductNumber.Enabled = true;
            textBoxName.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxStock.Enabled = true;
            PrintAll();
            textBoxPrintProducts.Size = new System.Drawing.Size(436, 397); //resize text box to make room for add panel

        }

        //adds inputted product to list of products
        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            //base.buttonAdd_Click(sender, e);
            try
            {
                productBLL.Create((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text)); //adds a product to the list
                textBoxPrintProducts.Clear(); //empty list box to reprint with new product added
                PrintAll(); //reprint list with new product added
                ClearGroupBoxTexboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Product information is invalid.", "Error"); //maybe we should have different error messages depending on what is invalid (product number in use, price is not valid, etc)
            }
        }

        public override void buttonReadAll_Click(object sender, EventArgs e)
        {
            base.buttonReadAll_Click(sender, e);
            labelProductMenu.Text = "All Products";
           
            try
            {
                PrintAll();
            }
            catch
            {
                MessageBox.Show("No products found. Please add to inventory.", "Error");
            }
        }
        public void PrintAll()
        {

            foreach (Product product in productBLL.ReadAll()) //appends each product in the text box
            {
                textBoxPrintProducts.AppendText(product.ToString() + "\r\n");
            }
        }

        private void ClearGroupBoxTexboxes()
        {
            buttonDelete.Visible=false;
            buttonModify.Visible=false;
            textBoxProductNumber.Clear();
            textBoxProductNumber2.Clear();
            textBoxProductNumber2.Visible = false;
            textBoxName.Clear();
            textBoxStock.Clear();
            textBoxPrice.Clear();
           
        }

        public override void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            base.buttonReturnMenu_Click(sender,e);
            labelProductMenu.Text = "Product Menu";
            groupBoxProductDetails.Visible = false;
            labelEnterNumber.Visible = false;
            buttonListDetails.Visible = false;
            textBoxPrintProducts.Visible = false;
        }

        protected override void ResetAndHideEverything()
        {
            buttonDelete.Visible=false;
            buttonModify.Visible=false;
            ClearGroupBoxTexboxes();
            base.ResetAndHideEverything();
        }
    }
}
