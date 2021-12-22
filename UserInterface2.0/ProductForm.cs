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
                buttonDelete.Enabled = true;
                buttonModify.Enabled = true;
                Product newProduct = (productBLL.Read(int.Parse(textBoxProductNumber2.Text)));//it was getting too unwieldy so I created a product with this product's info in it. This may have been going farther than I needed to do, but i don't know.
                textBoxProductNumber.Text = Convert.ToString(newProduct.ProductNumber);
                textBoxPrice.Text = Convert.ToString(newProduct.CostPerUnit);
                textBoxStock.Text = Convert.ToString(newProduct.AmountInStock);
                textBoxName.Text = Convert.ToString(newProduct.ProductName);
                
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


        public override void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                productBLL.Update((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text)); //update product with new details


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

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }



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


            textBoxPrintProducts.Size = new System.Drawing.Size(436, 397); //resize text box to make room for add panel

        }

    }
}
