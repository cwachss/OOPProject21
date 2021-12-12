
namespace UserInterface2._0
{
    partial class ProductForm : BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private new System.ComponentModel.IContainer components = null;

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
            // buttonReadAll
            // 
            this.buttonReadAll.Location = new System.Drawing.Point(524, 50);
            this.buttonReadAll.Size = new System.Drawing.Size(262, 450);
            this.buttonReadAll.Text = "ALL PRODUCTS";
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.Location = new System.Drawing.Point(262, 50);
            this.buttonReadOne.Size = new System.Drawing.Size(262, 450);
            this.buttonReadOne.Text = "FIND PRODUCT";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Size = new System.Drawing.Size(262, 450);
            this.buttonCreate.Text = "NEW PRODUCT";
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.Size = new System.Drawing.Size(785, 50);
            this.labelProductMenu.Text = "Product Menu";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 500);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.groupBoxProductDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}