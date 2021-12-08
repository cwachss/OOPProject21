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
    public partial class CustomerForm : BaseForm
    {
        public CustomerForm()
        {
            InitializeComponent();
            labelProductMenu.Text = "Customer Menu";
        }

        public override void buttonModify_Click(object sender, EventArgs e)
        {
            // base.buttonModify_Click(sender, e);

            try
            {
                CustomerBLL bLL = new CustomerBLL();
                bLL.Update(textBoxCustomerName.Text,int.Parse(textBoxCustomerID.Text),
                    long.Parse(textBoxCCNumber.Text),int.Parse(textBoxCCYear.Text),
                    int.Parse(textBoxCCMonth.Text));
            }
            catch
            {
                MessageBox.Show("Incorrect input", "Error");
            }
        }


        public void Delete()
        {

        }

        public void ReadOne()
        {

        }

       
        public override void buttonReadOne_Click(object sender, EventArgs e) 
        {
            HideMainMenu();

        }
    }
}
