
namespace UserInterfaceLayer
{
    partial class FormProducts
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
            this.buttonReadAll = new System.Windows.Forms.Button();
            this.buttonReadOne = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonReturnMenu = new System.Windows.Forms.Button();
            this.labelProductMenu = new System.Windows.Forms.Label();
            this.textBoxPrintProducts = new System.Windows.Forms.TextBox();
            this.groupBoxProductDetails = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxProductNumber = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelProductNumber = new System.Windows.Forms.Label();
            this.groupBoxProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReadAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadAll.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.buttonReadAll.Location = new System.Drawing.Point(504, 41);
            this.buttonReadAll.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonReadAll.Name = "buttonReadAll";
            this.buttonReadAll.Size = new System.Drawing.Size(252, 440);
            this.buttonReadAll.TabIndex = 9;
            this.buttonReadAll.Text = "ALL PRODUCTS";
            this.buttonReadAll.UseVisualStyleBackColor = false;
            this.buttonReadAll.Click += new System.EventHandler(this.buttonReadAll_Click);
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReadOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReadOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadOne.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.buttonReadOne.Location = new System.Drawing.Point(252, 41);
            this.buttonReadOne.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonReadOne.Name = "buttonReadOne";
            this.buttonReadOne.Size = new System.Drawing.Size(252, 440);
            this.buttonReadOne.TabIndex = 8;
            this.buttonReadOne.Text = "FIND PRODUCT";
            this.buttonReadOne.UseVisualStyleBackColor = false;
            this.buttonReadOne.Click += new System.EventHandler(this.buttonReadOne_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Palatino Linotype", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(0, 41);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(252, 440);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "NEW PRODUCT";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnMenu.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnMenu.Location = new System.Drawing.Point(-1, 440);
            this.buttonReturnMenu.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonReturnMenu.Name = "buttonReturnMenu";
            this.buttonReturnMenu.Size = new System.Drawing.Size(751, 41);
            this.buttonReturnMenu.TabIndex = 13;
            this.buttonReturnMenu.Text = "Main Menu";
            this.buttonReturnMenu.UseVisualStyleBackColor = false;
            this.buttonReturnMenu.Visible = false;
            this.buttonReturnMenu.Click += new System.EventHandler(this.buttonReturnMenu_Click);
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProductMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProductMenu.Font = new System.Drawing.Font("Agency FB", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductMenu.Location = new System.Drawing.Point(0, 0);
            this.labelProductMenu.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelProductMenu.Name = "labelProductMenu";
            this.labelProductMenu.Size = new System.Drawing.Size(751, 41);
            this.labelProductMenu.TabIndex = 6;
            this.labelProductMenu.Text = "Product Menu";
            this.labelProductMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPrintProducts
            // 
            this.textBoxPrintProducts.Location = new System.Drawing.Point(33, 57);
            this.textBoxPrintProducts.Multiline = true;
            this.textBoxPrintProducts.Name = "textBoxPrintProducts";
            this.textBoxPrintProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPrintProducts.Size = new System.Drawing.Size(413, 365);
            this.textBoxPrintProducts.TabIndex = 14;
            this.textBoxPrintProducts.Visible = false;
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.AutoSize = true;
            this.groupBoxProductDetails.Controls.Add(this.buttonAdd);
            this.groupBoxProductDetails.Controls.Add(this.textBoxProductNumber);
            this.groupBoxProductDetails.Controls.Add(this.labelStock);
            this.groupBoxProductDetails.Controls.Add(this.textBoxStock);
            this.groupBoxProductDetails.Controls.Add(this.labelPrice);
            this.groupBoxProductDetails.Controls.Add(this.textBoxPrice);
            this.groupBoxProductDetails.Controls.Add(this.labelName);
            this.groupBoxProductDetails.Controls.Add(this.textBoxName);
            this.groupBoxProductDetails.Controls.Add(this.labelProductNumber);
            this.groupBoxProductDetails.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductDetails.Location = new System.Drawing.Point(476, 57);
            this.groupBoxProductDetails.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBoxProductDetails.Name = "groupBoxProductDetails";
            this.groupBoxProductDetails.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBoxProductDetails.Size = new System.Drawing.Size(234, 363);
            this.groupBoxProductDetails.TabIndex = 15;
            this.groupBoxProductDetails.TabStop = false;
            this.groupBoxProductDetails.Text = "PRODUCT DETAILS";
            this.groupBoxProductDetails.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(30, 307);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(173, 33);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "ADD PRODUCT";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxProductNumber
            // 
            this.textBoxProductNumber.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductNumber.Location = new System.Drawing.Point(30, 52);
            this.textBoxProductNumber.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxProductNumber.Name = "textBoxProductNumber";
            this.textBoxProductNumber.Size = new System.Drawing.Size(175, 33);
            this.textBoxProductNumber.TabIndex = 0;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(27, 228);
            this.labelStock.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(126, 20);
            this.labelStock.TabIndex = 8;
            this.labelStock.Text = "Amount in Stock";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(30, 251);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(175, 33);
            this.textBoxStock.TabIndex = 3;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(27, 158);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 20);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(30, 180);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(175, 33);
            this.textBoxPrice.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(27, 91);
            this.labelName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(30, 114);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 33);
            this.textBoxName.TabIndex = 1;
            // 
            // labelProductNumber
            // 
            this.labelProductNumber.AutoSize = true;
            this.labelProductNumber.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductNumber.Location = new System.Drawing.Point(27, 29);
            this.labelProductNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelProductNumber.Name = "labelProductNumber";
            this.labelProductNumber.Size = new System.Drawing.Size(126, 20);
            this.labelProductNumber.TabIndex = 5;
            this.labelProductNumber.Text = "Product Number";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 481);
            this.Controls.Add(this.textBoxPrintProducts);
            this.Controls.Add(this.groupBoxProductDetails);
            this.Controls.Add(this.buttonReturnMenu);
            this.Controls.Add(this.buttonReadAll);
            this.Controls.Add(this.buttonReadOne);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelProductMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormProducts";
            this.Text = "Product Window";
            this.groupBoxProductDetails.ResumeLayout(false);
            this.groupBoxProductDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReadAll;
        private System.Windows.Forms.Button buttonReadOne;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonReturnMenu;
        private System.Windows.Forms.Label labelProductMenu;
        private System.Windows.Forms.TextBox textBoxPrintProducts;
        private System.Windows.Forms.GroupBox groupBoxProductDetails;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxProductNumber;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelProductNumber;
    }
}

