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
            buttonAdd.Enabled = true;
            buttonAdd.Visible = true;
            buttonUpdateCreditCard.Visible = false;
            buttonCancelNewCC.Visible = false;
            groupBoxNewCreditCard.Visible = true;
            groupBoxNewCreditCard.BringToFront();
            buttonEnter.Visible = false;
            textBoxCCNum.Visible = false;
            labelCreditCardNumber.Visible = false;
            labelProductMenu.Text = "Create new Customer";
            buttonUpdateCreditCard.Text = "New Credit Card";
           
            ClearReadOneTextBoxes();
            PrintAll();

        }

        public override void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxCustomerID.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxCreditCardNumber.Text.Length == 16 && int.Parse(textBoxMonth.Text) > 0 && int.Parse(textBoxMonth.Text) <= 12 && int.Parse(textBoxYear.Text) > 2021)
                {
                    customerBLL.Create(textBoxFirstName.Text, textBoxLastName.Text, textBoxNameOnCard.Text,
                               int.Parse(textBoxCustomerID.Text), textBoxCreditCardNumber.Text,
                               int.Parse(textBoxYear.Text), int.Parse(textBoxMonth.Text));//computer gave me a hard time until I added a DAL refence here. No idea why.
                    
                        customerBLL.ReadAll();

                    PrintAll();

                    

                    MessageBox.Show("New customer details added.", "Success!");
                }
                else
                {
                    throw new Exception();
                }

            }
            catch
            {
                MessageBox.Show("One or more boxes weren't filled in correctly.", "Error");
            }
        }
        //Opens the readOne 'page'
        public override void buttonReadOne_Click(object sender, EventArgs e)
        {
            base.buttonReadOne_Click(sender, e);
            ClearReadOneTextBoxes();//so it resets the textboxes as blank
            textBoxCustomerID.Enabled = false;
            textBoxFirstName.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxCCNum.Enabled = false;
            textBoxCCNum.Visible = true;
            labelProductMenu.Text = "Find Customer";

        }
        //lists customer's details
        public override void buttonListDetails_Click(object sender, EventArgs e)
        {
            base.buttonListDetails_Click(sender, e);
            groupBoxProductDetails.Enabled = true;

            try
            {
                Customer aCustomer = customerBLL.Read(int.Parse(textBoxProductNumber2.Text));
                textBoxFirstName.Text = aCustomer.FirstName;
                textBoxLastName.Text = aCustomer.LastName;
                textBoxCustomerID.Text = Convert.ToString(aCustomer.ID);
                textBoxCCNum.Text = "****-****-****-" + aCustomer.myCreditCard.CardNumber.Substring(12);

                //inside the hidden credit card info text boxes, for the purpose of being able to update the customer's name without updating their info

                textBoxCreditCardNumber.Text = Convert.ToString(aCustomer.myCreditCard.CardNumber);

                textBoxNameOnCard.Text = Convert.ToString(aCustomer.myCreditCard.Name);
                textBoxMonth.Text = Convert.ToString(aCustomer.myCreditCard.ExpirationDate.Month);
                textBoxYear.Text = Convert.ToString(aCustomer.myCreditCard.ExpirationDate.Year);


                textBoxFirstName.Enabled = false;
                textBoxLastName.Enabled = false;


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
            buttonUpdateCreditCard.Visible = true;
            buttonUpdateCreditCard.Enabled = true;
            buttonUpdateCreditCard.Text = "Update Credit Card";
        }

        //update credit card opens a groupbox to put in new credit card information
        private void buttonUpdateCreditCard_Click(object sender, EventArgs e)
        {

            //textBoxCreditCardNumber.Clear();
            //textBoxMonth.Clear();
            //textBoxYear.Clear();

            groupBoxNewCreditCard.Visible = true;

            buttonUpdateCreditCard.Enabled = false;
            buttonUpdateProduct.Enabled = false;
            buttonEnter.Visible = true;
            buttonCancelNewCC.Visible = true;
            groupBoxNewCreditCard.BringToFront();
            textBoxNameOnCard.Clear();
            textBoxCreditCardNumber.Clear();
            textBoxMonth.Clear();
            textBoxYear.Clear();
        }

        // enter saves the credit card info and closes the groupbox
        private void buttonEnter_Click(object sender, EventArgs e)
        {

            if (textBoxCreditCardNumber.Text.Length == 16)
            {
                if (int.Parse(textBoxMonth.Text) <= 12 && int.Parse(textBoxMonth.Text) > 0 && int.Parse(textBoxYear.Text) > 2021)
                {
                    if (textBoxNameOnCard.Text != "")
                    {
                        customerBLL.Update(textBoxFirstName.Text, textBoxLastName.Text, int.Parse(textBoxCustomerID.Text), textBoxNameOnCard.Text, textBoxCreditCardNumber.Text, int.Parse(textBoxYear.Text), int.Parse(textBoxMonth.Text));
                        buttonListDetails_Click(sender, e);
                        buttonUpdateCreditCard.Enabled = true;
                        buttonUpdateProduct.Enabled = true;
                        MessageBox.Show("Credit Card updated successfully!");
                        groupBoxNewCreditCard.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Please input the name on credit card.");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Expiration Date");
                }

            }
            else
            {
                MessageBox.Show("Invalid Credit Card Number");
            }




        }

        //Cancels the new credit card by hiding the groupbox and resetting the credit card details to the original credit card. this prevents you from partially modifying a credit card.
        private void buttonCancelNewCC_Click(object sender, EventArgs e)
        {
            groupBoxNewCreditCard.Visible = false;

            Customer aCustomer = customerBLL.Read(int.Parse(textBoxProductNumber2.Text));
            textBoxCreditCardNumber.Text = aCustomer.myCreditCard.CardNumber;
            textBoxNameOnCard.Text = "";
            textBoxMonth.Text = Convert.ToString(aCustomer.myCreditCard.ExpirationDate.Month);
            textBoxYear.Text = Convert.ToString(aCustomer.myCreditCard.ExpirationDate.Year);
            buttonUpdateCreditCard.Enabled = true;
            buttonUpdateProduct.Enabled = true;
        }



        //adds in the modifications and resets the readone page
        public override void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {

                customerBLL.Update(textBoxFirstName.Text, textBoxLastName.Text, int.Parse(textBoxCustomerID.Text), textBoxNameOnCard.Text,
                textBoxCreditCardNumber.Text, int.Parse(textBoxYear.Text),
                    int.Parse(textBoxMonth.Text));

                MessageBox.Show("Customer details updated.");
                base.buttonUpdateProduct_Click(sender, e);

                textBoxFirstName.Enabled = false;
                textBoxLastName.Enabled = false;
                buttonUpdateCreditCard.Visible = false;
            }
            catch
            {
                MessageBox.Show("Incorrect input", "Error");
            }
        }

        public override void buttonReadAll_Click(object sender, EventArgs e)
        {
            base.buttonReadAll_Click(sender, e);
            labelProductMenu.Text = "All customers";


            try
            {

                customerBLL.ReadAll();

                PrintAll();

            }
            catch
            {
                MessageBox.Show("No data yet.", "Error");

            }
            // textBoxPrintProducts.
        }

        public override void buttonDelete_Click(object sender, EventArgs e)
        {

            customerBLL.Delete(int.Parse(textBoxCustomerID.Text));
            ClearReadOneTextBoxes();
            buttonDelete.Enabled = false;
            buttonModify.Enabled = false;

        }


        protected override void ResetAndHideEverything()
        {
            base.ResetAndHideEverything();

            groupBoxNewCreditCard.Visible = false;

            buttonUpdateCreditCard.Visible = false;
            labelProductMenu.Text = "Customer Menu";

        }

        protected void ClearReadOneTextBoxes()
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

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetAndHideEverything();
            ResetMainMenu();
            FormProvider.MainMenu.Show();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toys of All Sorts is an abstract toy company by Shira Laury and Chani Wachsstock");

        }

        //Prints all products in textbox
        private void PrintAll()
        {
            textBoxPrintProducts.Clear();
            foreach (Customer ploni in customerBLL.ReadAll())
            {
                textBoxPrintProducts.AppendText(ploni + "\tCC Number: ****-****-****-" + ploni.myCreditCard.CardNumber.Substring(12) + "\r\n");
            }
        }
    }
}
