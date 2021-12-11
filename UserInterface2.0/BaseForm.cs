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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public virtual void buttonCreate_Click(object sender, EventArgs e) 
        {
            HideMenuButtons();
            textBoxPrintProducts.Visible = true;
            buttonReadAll_Click(sender,e);
            groupBoxProductDetails.Visible = true;
            //groupBoxProductDetails.Enabled = true;//not working, so I had to set each textbox to be enabled by the child class
           
        }

        public virtual void buttonReadOne_Click(object sender, EventArgs e) { }

         public virtual void buttonReadAll_Click(object sender, EventArgs e) 
        {
            textBoxPrintProducts.Clear();//this way it resets the listbox as blank and then refills it.
            HideMenuButtons();  
            textBoxPrintProducts.Visible = true;
            //labelPrintInfo.Visible = true; //need to figure out how to make this button inherited...
            buttonReturnMenu.Visible = true;
            buttonReturnMenu.Enabled = true;

        }

        public virtual void buttonListDetails_Click(object sender, EventArgs e) { }

        public virtual void buttonUpdateProduct_Click(object sender, EventArgs e) { }

        public virtual void buttonAdd_Click(object sender, EventArgs e) { }

        public virtual void buttonModify_Click(object sender, EventArgs e)
        {
            buttonModify.Visible = false;
            buttonDelete.Visible = false;
            buttonUpdateProduct.Visible = true;
            
        }

        public virtual void buttonDelete_Click(object sender, EventArgs e) 
        { 
            
        }

        public void buttonReturnMenu_Click(object sender, EventArgs e) 
        {
            ResetMainMenu();
            ResetAndHideEverything();
        }
        

        protected virtual void ResetAndHideEverything() 
        {
           
        }
       

        protected void HideMenuButtons()
        {
            buttonReadOne.Enabled = false;
            buttonReadOne.Visible = false;
            buttonReadAll.Enabled = false;
            buttonReadAll.Visible = false;
            buttonCreate.Enabled = false;
            buttonCreate.Visible = false;
        }

        protected void ResetMainMenu()
        {
            buttonCreate.Visible = true;
            buttonReadAll.Visible = true;
            buttonReadOne.Visible = true;
            buttonCreate.Enabled=true;//added this since it wasm't worin without re-enabaling
            buttonReadAll.Enabled=true;
            buttonReadOne.Enabled=true;
        }

        //public virtual void ShowReadOne()
        //{
        //    buttonUpdateProduct.Visible = false;

        //}
    }
}
