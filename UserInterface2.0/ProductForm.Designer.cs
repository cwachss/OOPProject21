
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
            this.buttonReadAll.Location = new System.Drawing.Point(1398, 114);
            this.buttonReadAll.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReadAll.Size = new System.Drawing.Size(699, 1217);
            this.buttonReadAll.Text = "ALL PRODUCTS";
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.Location = new System.Drawing.Point(699, 114);
            this.buttonReadOne.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReadOne.Size = new System.Drawing.Size(699, 1217);
            this.buttonReadOne.Text = "FIND PRODUCT";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(0, 114);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreate.Size = new System.Drawing.Size(699, 1217);
            this.buttonCreate.Text = "NEW PRODUCT";
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProductMenu.Size = new System.Drawing.Size(2104, 114);
            this.labelProductMenu.Text = "Product Menu";
            // 
            // textBoxProductNumber2
            // 
            this.textBoxProductNumber2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEnterNumber.Size = new System.Drawing.Size(436, 51);
            this.labelEnterNumber.Text = "Enter Product Number:";
            // 
            // textBoxPrintProducts
            // 
            this.textBoxPrintProducts.Location = new System.Drawing.Point(61, 176);
            this.textBoxPrintProducts.Margin = new System.Windows.Forms.Padding(16, 17, 16, 17);
            this.textBoxPrintProducts.Size = new System.Drawing.Size(1151, 967);
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
            this.groupBoxProductDetails.Location = new System.Drawing.Point(1307, 176);
            this.groupBoxProductDetails.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBoxProductDetails.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBoxProductDetails.Size = new System.Drawing.Size(653, 967);
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
            this.buttonUpdateProduct.Location = new System.Drawing.Point(104, 792);
            this.buttonUpdateProduct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonUpdateProduct.Text = "Update Product Details";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(107, 792);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(16, 19, 16, 19);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(368, 792);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(16, 19, 16, 19);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(107, 792);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonAdd.Text = "ADD PRODUCT";
            // 
            // textBoxProductNumber
            // 
            this.textBoxProductNumber.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductNumber.Location = new System.Drawing.Point(96, 112);
            this.textBoxProductNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProductNumber.Name = "textBoxProductNumber";
            this.textBoxProductNumber.Size = new System.Drawing.Size(460, 70);
            this.textBoxProductNumber.TabIndex = 43;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(83, 606);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(319, 51);
            this.labelStock.TabIndex = 50;
            this.labelStock.Text = "Amount in Stock";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(93, 656);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(460, 70);
            this.textBoxStock.TabIndex = 46;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(85, 427);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(110, 51);
            this.labelPrice.TabIndex = 49;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(96, 477);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(460, 70);
            this.textBoxPrice.TabIndex = 45;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(83, 241);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(128, 51);
            this.labelName.TabIndex = 48;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(93, 291);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(460, 70);
            this.textBoxName.TabIndex = 44;
            // 
            // labelProductNumber
            // 
            this.labelProductNumber.AutoSize = true;
            this.labelProductNumber.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductNumber.Location = new System.Drawing.Point(83, 62);
            this.labelProductNumber.Name = "labelProductNumber";
            this.labelProductNumber.Size = new System.Drawing.Size(320, 51);
            this.labelProductNumber.TabIndex = 47;
            this.labelProductNumber.Text = "Product Number";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::UserInterface2._0.Properties.Resources.toysLogo3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(11, 7);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(85, 107);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 24;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2104, 1331);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(16, 17, 16, 17);
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