using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UserInterface2._0
{
    public partial class orderForm : Form
    {
        OrderBLL orderBLL = new OrderBLL();
        public orderForm()
        {
            InitializeComponent();
        }

        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            ResetMainMenu();
            HideEverything();
        }

        public void ResetMainMenu()
        {
            labelOrderTitle.Text = "Order Menu";
            buttonCreate.Visible = true;
            buttonReadOne.Visible = true;
            buttonReadAll.Visible = true;
            buttonReturnMenu.Visible = false;
        }

        public void HideEverything() 
        {
            //things to disappear for add
            groupBoxPlaceOrder.Visible = false;
            listBoxProducts.Visible = false;
            buttonReturnMenu.Visible = false;
            labelAllProducts.Visible = false;

            //things to disappear for readone

        }

        public void HideMainMenu()
        {
            buttonCreate.Visible = false;
            buttonReadOne.Visible = false;
            buttonReadAll.Visible = false;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            labelOrderTitle.Text = "Place Order";
            listBoxProducts.Visible = true;
            listBoxProducts.Size = new System.Drawing.Size(386, 382); //resize text box to make room for place order groupbox
            listBoxProducts.Text = ""; //need readall function to work first
            labelAllProducts.Visible = true;
            groupBoxPlaceOrder.Visible = true;
            buttonReturnMenu.Visible = true;
            labelOrderNumber.Text = "Order Number " + Convert.ToString(orderBLL.GetOrderNumber());
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                orderBLL.Create(int.Parse(textBoxCustomerID.Text), int.Parse(textBoxProductNumber.Text), Convert.ToInt32(numericUpDownAmount.Value));
                MessageBox.Show("Thank you for shopping at Toys of All Sorts!");
                labelOrderNumber.Text = "Order Number " + Convert.ToString(orderBLL.GetOrderNumber());
                //update listbox to show new stock numbers (waiting on ReadAll)
            }
            catch
            {
                MessageBox.Show("Incorrect input");
            }

        }

        private void buttonReadOne_Click(object sender, EventArgs e)
        {

        }

        private void buttonReadAll_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            labelOrderTitle.Text = "All Orders";
            buttonReturnMenu.Visible = true;
            listBoxProducts.Visible = true;
            listBoxProducts.Size = new System.Drawing.Size(688, 382); //resize text box to take up all the space
            listBoxProducts.Text = ""; //need readall function to work first

            
        }

    }
}
