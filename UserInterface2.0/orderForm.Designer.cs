
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
            this.buttonReturnMenu = new System.Windows.Forms.Button();
            this.buttonReadAll = new System.Windows.Forms.Button();
            this.buttonReadOne = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelOrderTitle = new System.Windows.Forms.Label();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.labelAllProducts = new System.Windows.Forms.Label();
            this.groupBoxPlaceOrder = new System.Windows.Forms.GroupBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.textBoxProductNumber = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelEnterID = new System.Windows.Forms.Label();
            this.textBoxIDInput = new System.Windows.Forms.TextBox();
            this.IDChooser = new System.Windows.Forms.DomainUpDown();
            this.panelIDInput = new System.Windows.Forms.Panel();
            this.buttonFindOrders = new System.Windows.Forms.Button();
            this.listBoxOrdersFound = new System.Windows.Forms.ListBox();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.groupBoxPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelIDInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnMenu.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnMenu.Location = new System.Drawing.Point(-4, 638);
            this.buttonReturnMenu.Margin = new System.Windows.Forms.Padding(1);
            this.buttonReturnMenu.Name = "buttonReturnMenu";
            this.buttonReturnMenu.Size = new System.Drawing.Size(1048, 60);
            this.buttonReturnMenu.TabIndex = 23;
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
            this.buttonReadAll.Location = new System.Drawing.Point(698, 62);
            this.buttonReadAll.Margin = new System.Windows.Forms.Padding(1);
            this.buttonReadAll.Name = "buttonReadAll";
            this.buttonReadAll.Size = new System.Drawing.Size(349, 638);
            this.buttonReadAll.TabIndex = 22;
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
            this.buttonReadOne.Location = new System.Drawing.Point(349, 62);
            this.buttonReadOne.Margin = new System.Windows.Forms.Padding(1);
            this.buttonReadOne.Name = "buttonReadOne";
            this.buttonReadOne.Size = new System.Drawing.Size(349, 638);
            this.buttonReadOne.TabIndex = 21;
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
            this.buttonCreate.Location = new System.Drawing.Point(0, 62);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(349, 638);
            this.buttonCreate.TabIndex = 20;
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
            this.labelOrderTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelOrderTitle.Name = "labelOrderTitle";
            this.labelOrderTitle.Size = new System.Drawing.Size(1041, 62);
            this.labelOrderTitle.TabIndex = 19;
            this.labelOrderTitle.Text = "Order Menu";
            this.labelOrderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 28;
            this.listBoxProducts.Location = new System.Drawing.Point(64, 118);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(513, 424);
            this.listBoxProducts.TabIndex = 24;
            this.listBoxProducts.Visible = false;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // labelAllProducts
            // 
            this.labelAllProducts.AutoSize = true;
            this.labelAllProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAllProducts.Font = new System.Drawing.Font("Agency FB", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllProducts.Location = new System.Drawing.Point(227, 73);
            this.labelAllProducts.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAllProducts.Name = "labelAllProducts";
            this.labelAllProducts.Size = new System.Drawing.Size(165, 42);
            this.labelAllProducts.TabIndex = 25;
            this.labelAllProducts.Text = "ALL PRODUCTS";
            this.labelAllProducts.Visible = false;
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
            this.groupBoxPlaceOrder.Location = new System.Drawing.Point(648, 116);
            this.groupBoxPlaceOrder.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxPlaceOrder.Name = "groupBoxPlaceOrder";
            this.groupBoxPlaceOrder.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxPlaceOrder.Size = new System.Drawing.Size(333, 476);
            this.groupBoxPlaceOrder.TabIndex = 26;
            this.groupBoxPlaceOrder.TabStop = false;
            this.groupBoxPlaceOrder.Text = "PLACE ORDER";
            this.groupBoxPlaceOrder.Visible = false;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(39, 332);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(65, 20);
            this.labelAmount.TabIndex = 7;
            this.labelAmount.Text = "Quantity";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(43, 354);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(61, 22);
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
            this.buttonPlaceOrder.Location = new System.Drawing.Point(37, 401);
            this.buttonPlaceOrder.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(265, 44);
            this.buttonPlaceOrder.TabIndex = 5;
            this.buttonPlaceOrder.Text = "PLACE ORDER";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // textBoxProductNumber
            // 
            this.textBoxProductNumber.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductNumber.Location = new System.Drawing.Point(37, 260);
            this.textBoxProductNumber.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxProductNumber.Name = "textBoxProductNumber";
            this.textBoxProductNumber.Size = new System.Drawing.Size(268, 47);
            this.textBoxProductNumber.TabIndex = 4;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(36, 154);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(271, 47);
            this.textBoxCustomerID.TabIndex = 3;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(37, 124);
            this.labelCustomerID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(124, 28);
            this.labelCustomerID.TabIndex = 2;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Number:";
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOrderNumber.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNumber.Location = new System.Drawing.Point(33, 43);
            this.labelOrderNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(269, 47);
            this.labelOrderNumber.TabIndex = 0;
            this.labelOrderNumber.Text = "Order Number:";
            this.labelOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::UserInterface2._0.Properties.Resources.toysLogo3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(8, 6);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(43, 55);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 27;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // labelEnterID
            // 
            this.labelEnterID.AutoSize = true;
            this.labelEnterID.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.labelEnterID.Location = new System.Drawing.Point(16, 14);
            this.labelEnterID.Name = "labelEnterID";
            this.labelEnterID.Size = new System.Drawing.Size(85, 28);
            this.labelEnterID.TabIndex = 28;
            this.labelEnterID.Text = "Enter ID:";
            // 
            // textBoxIDInput
            // 
            this.textBoxIDInput.Location = new System.Drawing.Point(169, 49);
            this.textBoxIDInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIDInput.Name = "textBoxIDInput";
            this.textBoxIDInput.Size = new System.Drawing.Size(220, 22);
            this.textBoxIDInput.TabIndex = 29;
            // 
            // IDChooser
            // 
            this.IDChooser.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.IDChooser.Items.Add("Customer");
            this.IDChooser.Items.Add("Product");
            this.IDChooser.Items.Add("Order");
            this.IDChooser.Location = new System.Drawing.Point(20, 46);
            this.IDChooser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDChooser.Name = "IDChooser";
            this.IDChooser.ReadOnly = true;
            this.IDChooser.Size = new System.Drawing.Size(107, 30);
            this.IDChooser.TabIndex = 30;
            this.IDChooser.Text = "By";
           // this.IDChooser.SelectedItemChanged += new System.EventHandler(this.IDChooser_SelectedItemChanged);
            // 
            // panelIDInput
            // 
            this.panelIDInput.Controls.Add(this.buttonFindOrders);
            this.panelIDInput.Controls.Add(this.labelEnterID);
            this.panelIDInput.Controls.Add(this.IDChooser);
            this.panelIDInput.Controls.Add(this.textBoxIDInput);
            this.panelIDInput.Location = new System.Drawing.Point(320, 96);
            this.panelIDInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIDInput.Name = "panelIDInput";
            this.panelIDInput.Size = new System.Drawing.Size(417, 161);
            this.panelIDInput.TabIndex = 31;
            this.panelIDInput.Visible = false;
            // 
            // buttonFindOrders
            // 
            this.buttonFindOrders.Font = new System.Drawing.Font("Agency FB", 12F);
            this.buttonFindOrders.Location = new System.Drawing.Point(139, 96);
            this.buttonFindOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindOrders.Name = "buttonFindOrders";
            this.buttonFindOrders.Size = new System.Drawing.Size(157, 46);
            this.buttonFindOrders.TabIndex = 31;
            this.buttonFindOrders.Text = "Find Order(s)";
            this.buttonFindOrders.UseVisualStyleBackColor = true;
            this.buttonFindOrders.Click += new System.EventHandler(this.buttonFindOrders_Click);
            // 
            // listBoxOrdersFound
            // 
            this.listBoxOrdersFound.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.listBoxOrdersFound.FormattingEnabled = true;
            this.listBoxOrdersFound.ItemHeight = 28;
            this.listBoxOrdersFound.Location = new System.Drawing.Point(124, 377);
            this.listBoxOrdersFound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxOrdersFound.Name = "listBoxOrdersFound";
            this.listBoxOrdersFound.Size = new System.Drawing.Size(805, 144);
            this.listBoxOrdersFound.TabIndex = 8;
            this.listBoxOrdersFound.Visible = false;
            this.listBoxOrdersFound.SelectedValueChanged += new System.EventHandler(this.listBoxOrdersFound_SelectedValueChanged);
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Font = new System.Drawing.Font("Agency FB", 20.1F);
            this.labelOrderDetails.Location = new System.Drawing.Point(483, 322);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(152, 42);
            this.labelOrderDetails.TabIndex = 32;
            this.labelOrderDetails.Text = "Order Details";
            this.labelOrderDetails.Visible = false;
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 700);
            this.Controls.Add(this.listBoxOrdersFound);
            this.Controls.Add(this.labelOrderDetails);
            this.Controls.Add(this.panelIDInput);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBoxPlaceOrder);
            this.Controls.Add(this.labelAllProducts);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.buttonReturnMenu);
            this.Controls.Add(this.buttonReadAll);
            this.Controls.Add(this.buttonReadOne);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelOrderTitle);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "orderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.orderForm_FormClosing);
            this.groupBoxPlaceOrder.ResumeLayout(false);
            this.groupBoxPlaceOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelIDInput.ResumeLayout(false);
            this.panelIDInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonReturnMenu;
        protected System.Windows.Forms.Button buttonReadAll;
        protected System.Windows.Forms.Button buttonReadOne;
        protected System.Windows.Forms.Button buttonCreate;
        protected System.Windows.Forms.Label labelOrderTitle;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Label labelAllProducts;
        private System.Windows.Forms.GroupBox groupBoxPlaceOrder;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.TextBox textBoxProductNumber;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelEnterID;
        private System.Windows.Forms.TextBox textBoxIDInput;
        private System.Windows.Forms.DomainUpDown IDChooser;
        private System.Windows.Forms.Panel panelIDInput;
        private System.Windows.Forms.Button buttonFindOrders;
        private System.Windows.Forms.ListBox listBoxOrdersFound;
        private System.Windows.Forms.Label labelOrderDetails;
    }
}