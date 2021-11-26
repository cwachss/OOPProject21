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
            HideMenuButtons();

            buttonReturnMenu.Visible = true;
            labelProductMenu.Text = "Create Product";
        }

        private void buttonReadOne_Click(object sender, EventArgs e)
        {
            HideMenuButtons();

            buttonReturnMenu.Visible = true;
            labelProductMenu.Text = "Find Product";
        }


        private void buttonReadAll_Click(object sender, EventArgs e)
        {
            HideMenuButtons();
            foreach (Product product in newBLL.ReadAll())
            {
                textBoxPrintProducts.AppendText(product.ToString() + "\r\n");
            }
            
            //textBoxShowProduct.AppendText(product.ToString() + "\r\n");
            textBoxPrintProducts.Visible = true;
            buttonReturnMenu.Visible = true;
            labelProductMenu.Text = "All Products";

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
            UnhideMenuButtons();
            textBoxPrintProducts.Visible = false;
            buttonReturnMenu.Visible = false;
            labelProductMenu.Text = "Product Menu";
        }

        private void HideMenuButtons()
        {
            buttonCreate.Visible = false;
            buttonReadAll.Visible = false;
            buttonReadOne.Visible = false;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
            labelProductMenu.Visible = false;
            buttonCreate.Enabled = false;
            buttonReadAll.Enabled = false;
            buttonReadOne.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            labelProductMenu.Enabled = false;
        }

        private void UnhideMenuButtons()
        {
            buttonCreate.Visible = true;
            buttonReadAll.Visible = true;
            buttonReadOne.Visible = true;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;
            labelProductMenu.Visible = true;
            buttonCreate.Enabled = true;
            buttonReadAll.Enabled = true;
            buttonReadOne.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            labelProductMenu.Enabled = true;
        }


        //we need a return to home page button


        private void CreateGUI()
        {
            HideMenuButtons();

            labelID.Visible = true;
            textBoxID.Visible = true;
            labelTypeName.Visible = true;
            textBoxName.Visible = true;
            labelPrice.Visible = true;
            textBoxPrice.Visible = true;
            labelStock.Visible = true;
            textBoxStock.Visible = true;
            buttonCreates.Visible = true;

            buttonReturnMenu.Visible = true;

            textBoxID.Text= "109";//generated ID.
        }

        private void labelStock_Click(object sender, EventArgs e)
        {

        }

        private void Modify()
        {
            labelID.Visible = true;
            textBoxID.Visible = true;
            labelTypeName.Visible = true;
            textBoxName.Visible = true;
            labelPrice.Visible = true;
            textBoxPrice.Visible = true;
            labelStock.Visible = true;
            textBoxStock.Visible = true;
            buttonCreates.Visible = true;

            buttonReturnMenu.Visible = true;
        }
    }
}
