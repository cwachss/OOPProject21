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
    public partial class MainMenu : Form
    {
        ProductForm pF = FormProvider.ProductForm;
        CustomerForm cF = FormProvider.CustomerForm;
        orderForm oF = FormProvider.OrderForm;
        EmployeeBLL employeeBLL = new EmployeeBLL();

        public MainMenu()
        {
            InitializeComponent();
        }


        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            FormProvider.CustomerForm.ShowDialog();
           
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            FormProvider.ProductForm.ShowDialog();
            
        }

        private void pictureBoxOrders_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormProvider.OrderForm.ShowDialog();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toys of All Sorts is an abstract toy company by Shira Laury and Chani Wachsstock");

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                Employee user = employeeBLL.ReadEmployee(int.Parse(textBoxID.Text));
                if (user.Password == textBoxPassword.Text)
                {
                    groupBoxSignIn.Visible = false;
                    pictureBoxProducts.Visible = true;
                    pictureBoxCustomer.Visible = true;
                    pictureBoxOrders.Visible = true;
                    labelProducts.Visible = true;
                    labelCustomers.Visible = true;
                    labelOrders.Visible = true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch 
            {
                MessageBox.Show("The login informtation is incorrect. Please enter you ID number and password","Error");
            }
 
        }

       
    }
}
