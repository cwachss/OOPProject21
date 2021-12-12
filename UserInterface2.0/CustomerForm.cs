//Chani Wachsstock and Shira Laury
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
using DAL;
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
        //ctor
        public CustomerForm()
        {
            InitializeComponent();
            labelProductMenu.Text = "Customer Menu";
            customerBLL = new CustomerBLL();
        }

        //creates new customer
        public override void buttonCreate_Click(object sender, EventArgs e)
        {
            base.buttonCreate_Click(sender, e);
            textBoxCustomerID.Enabled = true;
            textBoxFirstName.Enabled = true;
            textBoxLastName.Enabled = true;
            buttonUpdateCreditCard.Enabled = true;//this is not working-not sure why           
        }

        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                customerBLL.Create(textBoxFirstName.Text, textBoxLastName.Text,
                                int.Parse(textBoxCustomerID.Text), int.Parse(textBoxCreditCardNumber.Text),
                                int.Parse(textBoxYear.Text), int.Parse(textBoxMonth.Text));//computer gave me a hard time until I added a DAL refence here. No idea why.
                buttonReadAll_Click(sender, e);

                MessageBox.Show("New customer details added.", "Success!");

            }
            catch
            {
                MessageBox.Show("One of the boxes weren't filled in correctly.", "Error");
            }
            }
        //Opens the readOne 'page'
        public override void buttonReadOne_Click(object sender, EventArgs e)
        {
            ClearReadOneTextBoxes();//so it resets the textboxes as blank
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
        //lists customer's details
        public override void buttonListDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Customer aCustomer = customerBLL.Read(int.Parse(textBoxProductNumber2.Text));
                textBoxFirstName.Text = aCustomer.FirstName;
                textBoxLastName.Text = aCustomer.LastName;
                textBoxCustomerID.Text = Convert.ToString(aCustomer.ID);
                textBoxCCNum.Text = "****-****-****-" + Convert.ToString(aCustomer.myCreditCard.CardNumber % 10000);

                //inside the hidden credit card info text boxes, for the purpose of being able to update the customer's name without updating their info
                textBoxCreditCardNumber.Text = Convert.ToString(aCustomer.myCreditCard.CardNumber);
                //textBoxNameOnCard.Text = right now there is no option for a dif name on credit card. i will wait... dun dun dun
                textBoxMonth.Text = Convert.ToString(aCustomer.myCreditCard.ExpirationDate.Month);
                textBoxYear.Text = Convert.ToString(aCustomer.myCreditCard.ExpirationDate.Year);

                buttonDelete.Enabled = true;
                buttonModify.Enabled = true;
                buttonUpdateCreditCard.Enabled = true;


            }
            catch
            {
                MessageBox.Show("Customer not found.");
            }
        }




        //Modify opens up the groupbox for modification and hides the buttons that i don't want available
        public override void buttonModify_Click(object sender, EventArgs e)
        {
            base.buttonModify_Click(sender, e);
            textBoxFirstName.Enabled = true;
            textBoxLastName.Enabled = true;


        }

        //update credit card opens a groupbox to put in new credit card information
        private void buttonUpdateCreditCard_Click(object sender, EventArgs e)
        {           
            groupBoxNewCreditCard.Visible = true;
            groupBoxNewCreditCard.Enabled=true;
        }

        // enter saves the credit card info and closes the groupbox
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            groupBoxNewCreditCard.Visible = false;
            groupBoxNewCreditCard.Enabled = false;
            customerBLL.Update(textBoxFirstName.Text, textBoxLastName.Text, int.Parse(textBoxCustomerID.Text), long.Parse(textBoxCreditCardNumber.Text), int.Parse(textBoxYear.Text), int.Parse(textBoxMonth.Text));


            buttonListDetails_Click(sender, e);

        }

        //Cancels the new credit card by hiding the groupbox and resetting the credit card details to the original credit card. this prevents you from partially modifying a credit card.
        private void buttonCancelNewCC_Click(object sender, EventArgs e)
        {
            groupBoxNewCreditCard.Visible = false;
            groupBoxNewCreditCard.Enabled=false;
            Customer aCustomer = customerBLL.Read(int.Parse(textBoxProductNumber2.Text));
            textBoxCreditCardNumber.Text = Convert.ToString(aCustomer.myCreditCard.CardNumber);
            //textBoxNameOnCard.Text = right now there is no option for a dif name on credit card. i will wait... dun dun dun
            textBoxMonth.Text = Convert.ToString(aCustomer.myCreditCard.ExpirationDate.Month);
            textBoxYear.Text = Convert.ToString(aCustomer.myCreditCard.ExpirationDate.Year);

        }

        //adds in the modifications and resets the readone page
        public override void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {

                customerBLL.Update(textBoxFirstName.Text, textBoxLastName.Text, int.Parse(textBoxCustomerID.Text),
                    long.Parse(textBoxCreditCardNumber.Text), int.Parse(textBoxYear.Text),
                    int.Parse(textBoxMonth.Text));

                MessageBox.Show("Customer details updated.");
                buttonModify.Visible = true;
                buttonModify.Enabled=true;
                buttonDelete.Visible=true;
                buttonDelete.Enabled=true;
                buttonUpdateProduct.Visible=false;
            }
            catch
            {
                MessageBox.Show("Incorrect input", "Error");
            }
        }

        public override void buttonReadAll_Click(object sender, EventArgs e)
        {
            base.buttonReadAll_Click(sender, e);
            labelPrintInfo.Visible = true;//will delete after base works

            try
            {

                customerBLL.ReadAll();

                foreach (Customer ploni in customerBLL.ReadAll())
                {
                    textBoxPrintProducts.AppendText(ploni.ToString() + "\r\n");
                }

            }
            catch
            {
                MessageBox.Show("No data yet.", "Error");

            }

        }

        public override void buttonDelete_Click(object sender, EventArgs e)
        {
            customerBLL.Delete(int.Parse(textBoxCustomerID.Text));
        }


        protected override void ResetAndHideEverything()//I think some of this should be in the base form, since products will use it. Since you wrote this, I'll let you decide where to put it.
        {
            textBoxPrintProducts.Visible = false;
            labelPrintInfo.Visible = false;
            groupBoxProductDetails.Visible = false;
            buttonReturnMenu.Visible = false;

            labelEnterNumber.Visible = false;
            textBoxProductNumber2.Visible = false;
            buttonListDetails.Visible = false;

            //this will remain in child class
            groupBoxNewCreditCard.Visible = false;
            groupBoxNewCreditCard.Enabled = false;

        }

        private void ClearReadOneTextBoxes()
        {
            textBoxCustomerID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxCCNum.Clear();
            textBoxProductNumber2.Clear();

            //clear the creditcard boxes as well
            textBoxYear.Clear();
            textBoxMonth.Clear();
            textBoxNameOnCard.Clear();
            textBoxCreditCardNumber.Clear();
        }

        
    }
}
