using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            HideMenuButtons();
        }

        private void buttonReadOne_Click(object sender, EventArgs e)
        {
            HideMenuButtons();
        }


        private void buttonReadAll_Click(object sender, EventArgs e)
        {
            HideMenuButtons();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            HideMenuButtons();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            HideMenuButtons();
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
    }
}
