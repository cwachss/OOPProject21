
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
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.labelCreditCardNumber = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.buttonUpdateCreditCard = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxNewCreditCard = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCharges = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNameOnCard = new System.Windows.Forms.TextBox();
            this.textBoxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.groupBoxProductDetails.SuspendLayout();
            this.groupBoxNewCreditCard.SuspendLayout();
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
            // textBoxPrintProducts
            // 
            this.textBoxPrintProducts.Location = new System.Drawing.Point(31, 61);
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.Controls.Add(this.labelLastName);
            this.groupBoxProductDetails.Controls.Add(this.textBox1);
            this.groupBoxProductDetails.Controls.Add(this.buttonUpdateCreditCard);
            this.groupBoxProductDetails.Controls.Add(this.textBoxCustomerID);
            this.groupBoxProductDetails.Controls.Add(this.labelCreditCardNumber);
            this.groupBoxProductDetails.Controls.Add(this.textBoxPrice);
            this.groupBoxProductDetails.Controls.Add(this.labelFirstName);
            this.groupBoxProductDetails.Controls.Add(this.textBoxName);
            this.groupBoxProductDetails.Controls.Add(this.labelCustomerID);
            this.groupBoxProductDetails.Location = new System.Drawing.Point(502, 61);
            this.groupBoxProductDetails.Text = "CUSTOMER DETAILS";
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelCustomerID, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxName, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelFirstName, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxPrice, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelCreditCardNumber, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxCustomerID, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonUpdateCreditCard, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonAdd, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonDelete, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonModify, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonUpdateProduct, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelLastName, 0);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Text = "Update Customer Details";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Text = "ADD CUSTOMER";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomerID.Location = new System.Drawing.Point(36, 49);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(175, 31);
            this.textBoxCustomerID.TabIndex = 19;
            // 
            // labelCreditCardNumber
            // 
            this.labelCreditCardNumber.AutoSize = true;
            this.labelCreditCardNumber.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditCardNumber.Location = new System.Drawing.Point(36, 232);
            this.labelCreditCardNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCreditCardNumber.Name = "labelCreditCardNumber";
            this.labelCreditCardNumber.Size = new System.Drawing.Size(91, 20);
            this.labelCreditCardNumber.TabIndex = 25;
            this.labelCreditCardNumber.Text = "Credit Card ";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxPrice.Location = new System.Drawing.Point(40, 253);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(174, 31);
            this.textBoxPrice.TabIndex = 21;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(35, 98);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 24;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxName.Location = new System.Drawing.Point(36, 120);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 31);
            this.textBoxName.TabIndex = 20;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(34, 29);
            this.labelCustomerID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(97, 20);
            this.labelCustomerID.TabIndex = 23;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // buttonUpdateCreditCard
            // 
            this.buttonUpdateCreditCard.Location = new System.Drawing.Point(40, 289);
            this.buttonUpdateCreditCard.Name = "buttonUpdateCreditCard";
            this.buttonUpdateCreditCard.Size = new System.Drawing.Size(107, 23);
            this.buttonUpdateCreditCard.TabIndex = 26;
            this.buttonUpdateCreditCard.Text = "New Credit Card";
            this.buttonUpdateCreditCard.UseVisualStyleBackColor = true;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(35, 165);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 20);
            this.labelLastName.TabIndex = 28;
            this.labelLastName.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(36, 186);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 31);
            this.textBox1.TabIndex = 27;
            // 
            // groupBoxNewCreditCard
            // 
            this.groupBoxNewCreditCard.AutoSize = true;
            this.groupBoxNewCreditCard.Controls.Add(this.buttonEnter);
            this.groupBoxNewCreditCard.Controls.Add(this.buttonReturn);
            this.groupBoxNewCreditCard.Controls.Add(this.dateTimePicker1);
            this.groupBoxNewCreditCard.Controls.Add(this.textBox2);
            this.groupBoxNewCreditCard.Controls.Add(this.label2);
            this.groupBoxNewCreditCard.Controls.Add(this.textBoxCreditCardNumber);
            this.groupBoxNewCreditCard.Controls.Add(this.textBoxNameOnCard);
            this.groupBoxNewCreditCard.Controls.Add(this.labelName);
            this.groupBoxNewCreditCard.Controls.Add(this.labelExpirationDate);
            this.groupBoxNewCreditCard.Controls.Add(this.labelCharges);
            this.groupBoxNewCreditCard.Controls.Add(this.label1);
            this.groupBoxNewCreditCard.Font = new System.Drawing.Font("Nirmala UI", 8.1F);
            this.groupBoxNewCreditCard.Location = new System.Drawing.Point(122, 133);
            this.groupBoxNewCreditCard.Name = "groupBoxNewCreditCard";
            this.groupBoxNewCreditCard.Size = new System.Drawing.Size(541, 231);
            this.groupBoxNewCreditCard.TabIndex = 29;
            this.groupBoxNewCreditCard.TabStop = false;
            this.groupBoxNewCreditCard.Text = "NEW CREDIT CARD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(306, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit Card Number";
            // 
            // labelCharges
            // 
            this.labelCharges.AutoSize = true;
            this.labelCharges.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelCharges.Location = new System.Drawing.Point(306, 119);
            this.labelCharges.Name = "labelCharges";
            this.labelCharges.Size = new System.Drawing.Size(65, 20);
            this.labelCharges.TabIndex = 1;
            this.labelCharges.Text = "Charges";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelExpirationDate.Location = new System.Drawing.Point(16, 117);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(117, 20);
            this.labelExpirationDate.TabIndex = 2;
            this.labelExpirationDate.Text = "Expiration Date";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(16, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name on Card";
            // 
            // textBoxNameOnCard
            // 
            this.textBoxNameOnCard.Location = new System.Drawing.Point(20, 62);
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(211, 22);
            this.textBoxNameOnCard.TabIndex = 4;
            // 
            // textBoxCreditCardNumber
            // 
            this.textBoxCreditCardNumber.Location = new System.Drawing.Point(310, 62);
            this.textBoxCreditCardNumber.Name = "textBoxCreditCardNumber";
            this.textBoxCreditCardNumber.Size = new System.Drawing.Size(211, 22);
            this.textBoxCreditCardNumber.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(310, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(296, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "$";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(20, 186);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(70, 24);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Back";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(398, 186);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(123, 24);
            this.buttonEnter.TabIndex = 10;
            this.buttonEnter.Text = "Save Credit Card";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 519);
            this.Controls.Add(this.groupBoxNewCreditCard);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Controls.SetChildIndex(this.labelProductMenu, 0);
            this.Controls.SetChildIndex(this.buttonCreate, 0);
            this.Controls.SetChildIndex(this.buttonReadOne, 0);
            this.Controls.SetChildIndex(this.buttonReadAll, 0);
            this.Controls.SetChildIndex(this.buttonReturnMenu, 0);
            this.Controls.SetChildIndex(this.textBoxPrintProducts, 0);
            this.Controls.SetChildIndex(this.labelEnterNumber, 0);
            this.Controls.SetChildIndex(this.buttonListDetails, 0);
            this.Controls.SetChildIndex(this.textBoxProductNumber2, 0);
            this.Controls.SetChildIndex(this.groupBoxProductDetails, 0);
            this.Controls.SetChildIndex(this.groupBoxNewCreditCard, 0);
            this.groupBoxProductDetails.ResumeLayout(false);
            this.groupBoxProductDetails.PerformLayout();
            this.groupBoxNewCreditCard.ResumeLayout(false);
            this.groupBoxNewCreditCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label labelCreditCardNumber;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Button buttonUpdateCreditCard;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxNewCreditCard;
        private System.Windows.Forms.Label labelCharges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCreditCardNumber;
        private System.Windows.Forms.TextBox textBoxNameOnCard;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReturn;
    }
}