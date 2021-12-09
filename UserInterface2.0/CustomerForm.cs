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
using Entities;

namespace UserInterface2._0
{
    public partial class CustomerForm : BaseForm
    {
        /*
         * some important notes:
         * the UI has sections for first and last name. right now, the DAL only receives a full name. We need to decide which option we like better
         * the credit card section right now only allows for the customer name to be on the credit card. this needs to be changed.
         * we need to set up the code so you cannot add a customer unless the credit card is filled out. Maybe that means having the groupbox set up differently for add, right now I set it up only for the read/delete/modify. there are ways to make things move around depending on what button you press.
         * changes to make:
         * string credit card, 
         */
        CustomerBLL customerBLL;
        public CustomerForm()
        {
            InitializeComponent();
            labelProductMenu.Text = "Customer Menu";
            customerBLL = new CustomerBLL();
        }

        public override void buttonReadOne_Click(object sender, EventArgs e) 
        {
            HideMenuButtons();
            groupBoxProductDetails.Visible = true;
            buttonReturnMenu.Visible = true;
            labelEnterNumber.Visible = true;
            textBoxProductNumber2.Visible = true;
            buttonListDetails.Visible = true;
            buttonModify.Visible = true;
            buttonDelete.Visible = true;
            buttonAdd.Visible = false;

        }

        public override void buttonListDetails_Click(object sender, EventArgs e) 
        {
            try
            {
                Customer aCustomer = customerBLL.Read(int.Parse(textBoxProductNumber2.Text));
                textBoxFirstName.Text = aCustomer.Name;
                textBoxCustomerID.Text = Convert.ToString(aCustomer.ID);
                textBoxCCNum.Text = "****-****-****-" + Convert.ToString(aCustomer.myCreditCard.CardNumber % 10000);
                buttonDelete.Enabled = true;
                buttonModify.Enabled = true;
                buttonUpdateCreditCard.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Customer not found.");
            }
        }

        protected override void ResetAndHideEverything()
        {
            groupBoxProductDetails.Visible = false;
            buttonReturnMenu.Visible = false;

            labelEnterNumber.Visible = false;
            textBoxProductNumber2.Visible = false;
            buttonListDetails.Visible = false;
            
        }

        private void ClearReadOneTextBoxes()
        {
            textBoxCustomerID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();

        }

        private void buttonUpdateCreditCard_Click(object sender, EventArgs e)
        {
            groupBoxNewCreditCard.Visible = true; 
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            groupBoxNewCreditCard.Visible = false;
        }

    }
}
