﻿
namespace UserInterface2._0
{
    partial class orderForm
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
            this.labelEnterID = new System.Windows.Forms.Label();
            this.IDChooser = new System.Windows.Forms.DomainUpDown();
            this.textBoxIDInput = new System.Windows.Forms.TextBox();
            this.panelIDInput = new System.Windows.Forms.Panel();
            this.buttonFindOrders = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxPrintOrders = new System.Windows.Forms.ListBox();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.textBoxProductNumber = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonModify = new System.Windows.Forms.Button();
            this.listBoxOrdersFound = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelAmountModify = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxPlaceOrder = new System.Windows.Forms.GroupBox();
            this.labelAllProducts = new System.Windows.Forms.Label();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonReturnMenu = new System.Windows.Forms.Button();
            this.buttonReadAll = new System.Windows.Forms.Button();
            this.buttonReadOne = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelOrderTitle = new System.Windows.Forms.Label();
            this.panelIDInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxPlaceOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEnterID
            // 
            this.labelEnterID.AutoSize = true;
            this.labelEnterID.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.labelEnterID.Location = new System.Drawing.Point(32, 27);
            this.labelEnterID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEnterID.Name = "labelEnterID";
            this.labelEnterID.Size = new System.Drawing.Size(174, 54);
            this.labelEnterID.TabIndex = 28;
            this.labelEnterID.Text = "Enter ID:";
            // 
            // IDChooser
            // 
            this.IDChooser.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.IDChooser.Items.Add("Customer");
            this.IDChooser.Items.Add("Product");
            this.IDChooser.Items.Add("Order");
            this.IDChooser.Location = new System.Drawing.Point(40, 89);
            this.IDChooser.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.IDChooser.Name = "IDChooser";
            this.IDChooser.ReadOnly = true;
            this.IDChooser.Size = new System.Drawing.Size(214, 52);
            this.IDChooser.TabIndex = 30;
            this.IDChooser.Text = "By";
            this.IDChooser.SelectedItemChanged += new System.EventHandler(this.IDChooser_SelectedItemChanged);
            // 
            // textBoxIDInput
            // 
            this.textBoxIDInput.Location = new System.Drawing.Point(338, 95);
            this.textBoxIDInput.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBoxIDInput.Name = "textBoxIDInput";
            this.textBoxIDInput.Size = new System.Drawing.Size(436, 38);
            this.textBoxIDInput.TabIndex = 29;
            // 
            // panelIDInput
            // 
            this.panelIDInput.Controls.Add(this.buttonFindOrders);
            this.panelIDInput.Controls.Add(this.labelEnterID);
            this.panelIDInput.Controls.Add(this.IDChooser);
            this.panelIDInput.Controls.Add(this.textBoxIDInput);
            this.panelIDInput.Location = new System.Drawing.Point(644, 186);
            this.panelIDInput.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panelIDInput.Name = "panelIDInput";
            this.panelIDInput.Size = new System.Drawing.Size(834, 312);
            this.panelIDInput.TabIndex = 48;
            this.panelIDInput.Visible = false;
            // 
            // buttonFindOrders
            // 
            this.buttonFindOrders.Font = new System.Drawing.Font("Agency FB", 12F);
            this.buttonFindOrders.Location = new System.Drawing.Point(278, 186);
            this.buttonFindOrders.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonFindOrders.Name = "buttonFindOrders";
            this.buttonFindOrders.Size = new System.Drawing.Size(314, 89);
            this.buttonFindOrders.TabIndex = 31;
            this.buttonFindOrders.Text = "Find Order(s)";
            this.buttonFindOrders.UseVisualStyleBackColor = true;
            this.buttonFindOrders.Click += new System.EventHandler(this.buttonFindOrders_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(78, 643);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(132, 41);
            this.labelAmount.TabIndex = 7;
            this.labelAmount.Text = "Quantity";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(252, 1077);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(682, 111);
            this.buttonDelete.TabIndex = 51;
            this.buttonDelete.Text = "Delete Order";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxPrintOrders
            // 
            this.listBoxPrintOrders.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrintOrders.FormattingEnabled = true;
            this.listBoxPrintOrders.ItemHeight = 54;
            this.listBoxPrintOrders.Location = new System.Drawing.Point(132, 214);
            this.listBoxPrintOrders.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPrintOrders.Name = "listBoxPrintOrders";
            this.listBoxPrintOrders.Size = new System.Drawing.Size(53, 922);
            this.listBoxPrintOrders.TabIndex = 50;
            this.listBoxPrintOrders.Visible = false;
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Font = new System.Drawing.Font("Agency FB", 20.1F);
            this.labelOrderDetails.Location = new System.Drawing.Point(861, 583);
            this.labelOrderDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(323, 81);
            this.labelOrderDetails.TabIndex = 49;
            this.labelOrderDetails.Text = "Order Details";
            this.labelOrderDetails.Visible = false;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(86, 686);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(8);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(122, 38);
            this.numericUpDownAmount.TabIndex = 6;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaceOrder.Location = new System.Drawing.Point(74, 777);
            this.buttonPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(530, 85);
            this.buttonPlaceOrder.TabIndex = 5;
            this.buttonPlaceOrder.Text = "PLACE ORDER";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // textBoxProductNumber
            // 
            this.textBoxProductNumber.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductNumber.Location = new System.Drawing.Point(74, 504);
            this.textBoxProductNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProductNumber.Name = "textBoxProductNumber";
            this.textBoxProductNumber.Size = new System.Drawing.Size(532, 87);
            this.textBoxProductNumber.TabIndex = 4;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(72, 298);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(538, 87);
            this.textBoxCustomerID.TabIndex = 3;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(74, 240);
            this.labelCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(253, 54);
            this.labelCustomerID.TabIndex = 2;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1212, 1136);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(218, 38);
            this.numericUpDown1.TabIndex = 53;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // buttonModify
            // 
            this.buttonModify.Enabled = false;
            this.buttonModify.Location = new System.Drawing.Point(1453, 1077);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(405, 111);
            this.buttonModify.TabIndex = 52;
            this.buttonModify.Text = "Modify Order";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Visible = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // listBoxOrdersFound
            // 
            this.listBoxOrdersFound.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.listBoxOrdersFound.FormattingEnabled = true;
            this.listBoxOrdersFound.ItemHeight = 54;
            this.listBoxOrdersFound.Location = new System.Drawing.Point(252, 668);
            this.listBoxOrdersFound.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.listBoxOrdersFound.Name = "listBoxOrdersFound";
            this.listBoxOrdersFound.Size = new System.Drawing.Size(1606, 274);
            this.listBoxOrdersFound.TabIndex = 37;
            this.listBoxOrdersFound.Visible = false;
            this.listBoxOrdersFound.SelectedValueChanged += new System.EventHandler(this.listBoxOrdersFound_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 446);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Number:";
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOrderNumber.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNumber.Location = new System.Drawing.Point(66, 83);
            this.labelOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(538, 91);
            this.labelOrderNumber.TabIndex = 0;
            this.labelOrderNumber.Text = "Order Number:";
            this.labelOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAmountModify
            // 
            this.labelAmountModify.AutoSize = true;
            this.labelAmountModify.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAmountModify.Location = new System.Drawing.Point(1206, 1089);
            this.labelAmountModify.Name = "labelAmountModify";
            this.labelAmountModify.Size = new System.Drawing.Size(220, 32);
            this.labelAmountModify.TabIndex = 38;
            this.labelAmountModify.Text = "Update Amount:";
            this.labelAmountModify.Visible = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::UserInterface2._0.Properties.Resources.toysLogo3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, 12);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(86, 107);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 47;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // groupBoxPlaceOrder
            // 
            this.groupBoxPlaceOrder.Controls.Add(this.labelAmount);
            this.groupBoxPlaceOrder.Controls.Add(this.numericUpDownAmount);
            this.groupBoxPlaceOrder.Controls.Add(this.buttonPlaceOrder);
            this.groupBoxPlaceOrder.Controls.Add(this.textBoxProductNumber);
            this.groupBoxPlaceOrder.Controls.Add(this.textBoxCustomerID);
            this.groupBoxPlaceOrder.Controls.Add(this.labelCustomerID);
            this.groupBoxPlaceOrder.Controls.Add(this.label1);
            this.groupBoxPlaceOrder.Controls.Add(this.labelOrderNumber);
            this.groupBoxPlaceOrder.Location = new System.Drawing.Point(1300, 225);
            this.groupBoxPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPlaceOrder.Name = "groupBoxPlaceOrder";
            this.groupBoxPlaceOrder.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPlaceOrder.Size = new System.Drawing.Size(666, 922);
            this.groupBoxPlaceOrder.TabIndex = 46;
            this.groupBoxPlaceOrder.TabStop = false;
            this.groupBoxPlaceOrder.Text = "PLACE ORDER";
            this.groupBoxPlaceOrder.Visible = false;
            // 
            // labelAllProducts
            // 
            this.labelAllProducts.AutoSize = true;
            this.labelAllProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAllProducts.Font = new System.Drawing.Font("Agency FB", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllProducts.Location = new System.Drawing.Point(458, 141);
            this.labelAllProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllProducts.Name = "labelAllProducts";
            this.labelAllProducts.Size = new System.Drawing.Size(354, 81);
            this.labelAllProducts.TabIndex = 45;
            this.labelAllProducts.Text = "ALL PRODUCTS";
            this.labelAllProducts.Visible = false;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 54;
            this.listBoxProducts.Location = new System.Drawing.Point(132, 229);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(1022, 814);
            this.listBoxProducts.TabIndex = 44;
            this.listBoxProducts.Visible = false;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnMenu.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnMenu.Location = new System.Drawing.Point(-4, 1236);
            this.buttonReturnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReturnMenu.Name = "buttonReturnMenu";
            this.buttonReturnMenu.Size = new System.Drawing.Size(2096, 116);
            this.buttonReturnMenu.TabIndex = 43;
            this.buttonReturnMenu.Text = "Main Menu";
            this.buttonReturnMenu.UseVisualStyleBackColor = false;
            this.buttonReturnMenu.Visible = false;
            this.buttonReturnMenu.Click += new System.EventHandler(this.buttonReturnMenu_Click);
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReadAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadAll.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.buttonReadAll.Location = new System.Drawing.Point(1396, 120);
            this.buttonReadAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReadAll.Name = "buttonReadAll";
            this.buttonReadAll.Size = new System.Drawing.Size(698, 1236);
            this.buttonReadAll.TabIndex = 42;
            this.buttonReadAll.Text = "ALL ORDERS";
            this.buttonReadAll.UseVisualStyleBackColor = false;
            this.buttonReadAll.Click += new System.EventHandler(this.buttonReadAll_Click);
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReadOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReadOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadOne.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.buttonReadOne.Location = new System.Drawing.Point(698, 120);
            this.buttonReadOne.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReadOne.Name = "buttonReadOne";
            this.buttonReadOne.Size = new System.Drawing.Size(698, 1236);
            this.buttonReadOne.TabIndex = 41;
            this.buttonReadOne.Text = "FIND ORDER";
            this.buttonReadOne.UseVisualStyleBackColor = false;
            this.buttonReadOne.Click += new System.EventHandler(this.buttonReadOne_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Palatino Linotype", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(0, 120);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(698, 1236);
            this.buttonCreate.TabIndex = 40;
            this.buttonCreate.Text = "PLACE ORDER";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelOrderTitle
            // 
            this.labelOrderTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelOrderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOrderTitle.Font = new System.Drawing.Font("Agency FB", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderTitle.Location = new System.Drawing.Point(0, 0);
            this.labelOrderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderTitle.Name = "labelOrderTitle";
            this.labelOrderTitle.Size = new System.Drawing.Size(2088, 120);
            this.labelOrderTitle.TabIndex = 39;
            this.labelOrderTitle.Text = "Order Menu";
            this.labelOrderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2088, 1356);
            this.Controls.Add(this.panelIDInput);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxPrintOrders);
            this.Controls.Add(this.labelOrderDetails);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.listBoxOrdersFound);
            this.Controls.Add(this.labelAmountModify);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBoxPlaceOrder);
            this.Controls.Add(this.labelAllProducts);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.buttonReturnMenu);
            this.Controls.Add(this.buttonReadAll);
            this.Controls.Add(this.buttonReadOne);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelOrderTitle);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "orderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.orderForm_FormClosing);
            this.panelIDInput.ResumeLayout(false);
            this.panelIDInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxPlaceOrder.ResumeLayout(false);
            this.groupBoxPlaceOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterID;
        private System.Windows.Forms.DomainUpDown IDChooser;
        private System.Windows.Forms.TextBox textBoxIDInput;
        private System.Windows.Forms.Panel panelIDInput;
        private System.Windows.Forms.Button buttonFindOrders;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxPrintOrders;
        private System.Windows.Forms.Label labelOrderDetails;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.TextBox textBoxProductNumber;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.ListBox listBoxOrdersFound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Label labelAmountModify;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBoxPlaceOrder;
        private System.Windows.Forms.Label labelAllProducts;
        private System.Windows.Forms.ListBox listBoxProducts;
        protected System.Windows.Forms.Button buttonReturnMenu;
        protected System.Windows.Forms.Button buttonReadAll;
        protected System.Windows.Forms.Button buttonReadOne;
        protected System.Windows.Forms.Button buttonCreate;
        protected System.Windows.Forms.Label labelOrderTitle;
    }
}