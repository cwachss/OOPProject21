﻿
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
        private new void InitializeComponent()
        {
            this.textBoxProductNumber = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelProductNumber = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.Location = new System.Drawing.Point(524, 48);
            this.buttonReadAll.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReadAll.Size = new System.Drawing.Size(262, 507);
            this.buttonReadAll.Text = "ALL PRODUCTS";
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.Location = new System.Drawing.Point(262, 48);
            this.buttonReadOne.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReadOne.Size = new System.Drawing.Size(262, 507);
            this.buttonReadOne.Text = "FIND PRODUCT";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(0, 48);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreate.Size = new System.Drawing.Size(262, 507);
            this.buttonCreate.Text = "NEW PRODUCT";
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductMenu.Size = new System.Drawing.Size(785, 48);
            this.labelProductMenu.Text = "Product Menu";
            // 
            // textBoxProductNumber2
            // 
            this.textBoxProductNumber2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterNumber.Size = new System.Drawing.Size(172, 20);
            this.labelEnterNumber.Text = "Enter Product Number:";
            // 
            // textBoxPrintProducts
            // 
            this.textBoxPrintProducts.Location = new System.Drawing.Point(23, 74);
            this.textBoxPrintProducts.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxPrintProducts.Size = new System.Drawing.Size(434, 408);
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.Controls.Add(this.textBoxProductNumber);
            this.groupBoxProductDetails.Controls.Add(this.labelStock);
            this.groupBoxProductDetails.Controls.Add(this.textBoxStock);
            this.groupBoxProductDetails.Controls.Add(this.labelPrice);
            this.groupBoxProductDetails.Controls.Add(this.textBoxPrice);
            this.groupBoxProductDetails.Controls.Add(this.labelProductNumber);
            this.groupBoxProductDetails.Controls.Add(this.labelName);
            this.groupBoxProductDetails.Controls.Add(this.textBoxName);
            this.groupBoxProductDetails.Location = new System.Drawing.Point(504, 74);
            this.groupBoxProductDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProductDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProductDetails.Size = new System.Drawing.Size(245, 406);
            this.groupBoxProductDetails.Text = "PRODUCT DETAILS";
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxName, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelName, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelProductNumber, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxPrice, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelPrice, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxStock, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelStock, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxProductNumber, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonAdd, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonDelete, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonModify, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonUpdateProduct, 0);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Location = new System.Drawing.Point(39, 332);
            this.buttonUpdateProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateProduct.Text = "Update Product Details";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(40, 332);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(138, 332);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(40, 332);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Text = "ADD PRODUCT";
            // 
            // textBoxProductNumber
            // 
            this.textBoxProductNumber.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductNumber.Location = new System.Drawing.Point(36, 47);
            this.textBoxProductNumber.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxProductNumber.Name = "textBoxProductNumber";
            this.textBoxProductNumber.Size = new System.Drawing.Size(175, 33);
            this.textBoxProductNumber.TabIndex = 43;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(31, 254);
            this.labelStock.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(126, 20);
            this.labelStock.TabIndex = 50;
            this.labelStock.Text = "Amount in Stock";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(35, 275);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(175, 33);
            this.textBoxStock.TabIndex = 46;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(32, 179);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 20);
            this.labelPrice.TabIndex = 49;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(36, 200);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(175, 33);
            this.textBoxPrice.TabIndex = 45;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(31, 101);
            this.labelName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 48;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(35, 122);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 33);
            this.textBoxName.TabIndex = 44;
            // 
            // labelProductNumber
            // 
            this.labelProductNumber.AutoSize = true;
            this.labelProductNumber.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductNumber.Location = new System.Drawing.Point(31, 26);
            this.labelProductNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelProductNumber.Name = "labelProductNumber";
            this.labelProductNumber.Size = new System.Drawing.Size(126, 20);
            this.labelProductNumber.TabIndex = 47;
            this.labelProductNumber.Text = "Product Number";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::UserInterface2._0.Properties.Resources.toysLogo3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(32, 45);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 24;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 555);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.Controls.SetChildIndex(this.labelProductMenu, 0);
            this.Controls.SetChildIndex(this.buttonCreate, 0);
            this.Controls.SetChildIndex(this.buttonReadOne, 0);
            this.Controls.SetChildIndex(this.buttonReadAll, 0);
            this.Controls.SetChildIndex(this.groupBoxProductDetails, 0);
            this.Controls.SetChildIndex(this.textBoxPrintProducts, 0);
            this.Controls.SetChildIndex(this.buttonReturnMenu, 0);
            this.Controls.SetChildIndex(this.labelEnterNumber, 0);
            this.Controls.SetChildIndex(this.buttonListDetails, 0);
            this.Controls.SetChildIndex(this.textBoxProductNumber2, 0);
            this.Controls.SetChildIndex(this.pictureBoxLogo, 0);
            this.groupBoxProductDetails.ResumeLayout(false);
            this.groupBoxProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductNumber;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelProductNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}