
namespace UserInterface2._0
{
    partial class CustomerForm : BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.Location = new System.Drawing.Point(0, 470);
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.Size = new System.Drawing.Size(260, 469);
            this.buttonReadAll.Text = "ALL CUSTOMERS";
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.Size = new System.Drawing.Size(262, 469);
            this.buttonReadOne.Text = "FIND CUSTOMER";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Size = new System.Drawing.Size(262, 469);
            this.buttonCreate.Text = "NEW CUSTOMER";
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.Size = new System.Drawing.Size(784, 50);
            this.labelProductMenu.Text = "Customer Menu";
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.Size = new System.Drawing.Size(205, 20);
            this.labelEnterNumber.Text = "Enter Customer ID Number:";
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.Location = new System.Drawing.Point(502, 52);
            this.groupBoxProductDetails.Text = "CUSTOMER DETAILS";
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Text = "Update Customer Details";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Text = "ADD CUSTOMER";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 519);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.groupBoxProductDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}