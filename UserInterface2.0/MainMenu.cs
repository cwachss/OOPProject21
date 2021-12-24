using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface2._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cF = new CustomerForm();
            cF.ShowDialog();
           
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm pF = new ProductForm();
            pF.ShowDialog();
            
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderForm oF = new orderForm();
            oF.ShowDialog();
        }
    }
}
