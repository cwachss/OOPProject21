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
    public partial class ProductForm : BaseForm
    {
        ProductBLL productBLL = new ProductBLL();
        public ProductForm()
        {
            InitializeComponent();

        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
