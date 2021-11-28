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
            HideMenuButtons();

            buttonReturnMenu.Visible = true;
            groupBoxProductDetails.Visible = true;
            labelProductMenu.Text = "Add Product";

            textBoxPrintProducts.Size = new System.Drawing.Size(413, 365);
            textBoxPrintProducts.Visible = true;
            PrintAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            newBLL.Create((int.Parse(textBoxProductNumber.Text)), textBoxName.Text, decimal.Parse(textBoxPrice.Text), int.Parse(textBoxStock.Text));
            textBoxPrintProducts.Clear();
            PrintAll();
        }
        /// <summary>
        /// method that brings user to find product interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReadOne_Click(object sender, EventArgs e)
        {
            HideMenuButtons();

            buttonReturnMenu.Visible = true;
            labelProductMenu.Text = "Find Product";
            labelEnterNumber.Visible = true;
            textBoxProductNumber2.Visible= true;
            textBoxProductNumber2.Enabled = true;
            buttonListDetails.Visible = true;
            buttonListDetails.Enabled = true;
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            HideMenuButtons();

            buttonReturnMenu.Visible = true;
            labelProductMenu.Text = "Update Product";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            HideMenuButtons();

            buttonReturnMenu.Visible = true;
            labelProductMenu.Text = "Delete Product";
        }


        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            ResetMainMenu();
           
            textBoxPrintProducts.Visible = false;
            buttonReturnMenu.Visible = false;
            labelProductMenu.Text = "Product Menu";
            groupBoxProductDetails.Visible = false;
            buttonDelete2.Visible = false;
            buttonDelete2.Enabled = false;
            buttonListDetails.Enabled = false;
            buttonListDetails.Visible = false;
            textBoxProductNumber2.Enabled = false;
            textBoxProductNumber2.Visible = false;
            
        }

        private void HideMenuButtons()
        {
            buttonCreate.Visible = false;
            buttonReadAll.Visible = false;
            buttonReadOne.Visible = false;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
           
            buttonCreate.Enabled = false;
            buttonReadAll.Enabled = false;
            buttonReadOne.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            labelProductMenu.Enabled = false;
            buttonReturnMenu.Visible = true;
        }

        private void ResetMainMenu()
        {
            labelEnterNumber.Visible = false;
            buttonCreate.Visible = true;
            buttonReadAll.Visible = true;
            buttonReadOne.Visible = true;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;
            labelProductMenu.Visible = true;
            textBoxPrintProducts.Visible = false;
            //buttonReturnMenu.Visible = true;
            textBoxPrintProducts.Clear();
            buttonCreate.Enabled = true;
            buttonReadAll.Enabled = true;
            buttonReadOne.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            labelProductMenu.Enabled = true;
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
            try
            {
                groupBoxProductDetails.Visible = true;
                buttonAdd.Visible = false;
                labelEnterNumber.Visible = false;
                textBoxProductNumber2.Visible = false;
                buttonListDetails.Visible = false;
                groupBoxProductDetails.Enabled = false;

                buttonDelete2.Visible = true;
                buttonDelete2.Enabled = true;

                textBoxProductNumber.Text = textBoxProductNumber2.Text;
                Product newProduct = (newBLL.Read(int.Parse(textBoxProductNumber2.Text)));//it was getting too unwieldy so I created a product with this product's info in it. This may have been going farther than I needed to do, but i don't know.
                textBoxPrice.Text = Convert.ToString(newProduct.CostPerUnit);
                textBoxStock.Text = Convert.ToString(newProduct.AmountInStock);
                textBoxName.Text = Convert.ToString(newProduct.ProductName);
            }
            catch(ProductNumberNotFound prodNum)
            {
                MessageBox.Show(prodNum.Message);
            }
        }

       

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            //buttonModify.Visible = false;
            //buttonModify.Enabled = false;
            try
            {
                newBLL.Delete(int.Parse(textBoxProductNumber.Text));
            }
            catch(ProductNumberNotFound prodNum)
            {
                MessageBox.Show(prodNum.Message);
            }

           // textBoxProductNumber2.Visible = true;
            //textBoxName.Text = null;
            //textBoxPrice.Text = null;
            //textBoxProductNumber.Text = null;
            //textBoxStock.Text = null;
            buttonListDetails.Visible = true;

        }


    }
}
