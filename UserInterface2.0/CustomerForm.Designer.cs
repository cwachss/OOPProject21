
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
            this.textBoxCCNum = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.buttonUpdateCreditCard = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.groupBoxNewCreditCard = new System.Windows.Forms.GroupBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.labelSlash = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.textBoxNameOnCard = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelCCNum = new System.Windows.Forms.Label();
            this.groupBoxProductDetails.SuspendLayout();
            this.groupBoxNewCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.Location = new System.Drawing.Point(1, 451);
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.Location = new System.Drawing.Point(262, 41);
            this.buttonReadAll.Size = new System.Drawing.Size(262, 459);
            this.buttonReadAll.Text = "ALL CUSTOMERS";
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.Location = new System.Drawing.Point(524, 41);
            this.buttonReadOne.Size = new System.Drawing.Size(262, 459);
            this.buttonReadOne.Text = "FIND CUSTOMER";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(0, 41);
            this.buttonCreate.Size = new System.Drawing.Size(262, 459);
            this.buttonCreate.Text = "NEW CUSTOMER";
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.Size = new System.Drawing.Size(787, 41);
            this.labelProductMenu.Text = "Customer Menu";
            // 
            // textBoxProductNumber2
            // 
            this.textBoxProductNumber2.Location = new System.Drawing.Point(44, 107);
            // 
            // buttonListDetails
            // 
            this.buttonListDetails.Location = new System.Drawing.Point(44, 145);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.Location = new System.Drawing.Point(40, 84);
            this.labelEnterNumber.Size = new System.Drawing.Size(205, 20);
            this.labelEnterNumber.Text = "Enter Customer ID Number:";
            // 
            // textBoxPrintProducts
            // 
            this.textBoxPrintProducts.Location = new System.Drawing.Point(27, 46);
            this.textBoxPrintProducts.Margin = new System.Windows.Forms.Padding(2);
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.Controls.Add(this.labelLastName);
            this.groupBoxProductDetails.Controls.Add(this.textBoxLastName);
            this.groupBoxProductDetails.Controls.Add(this.buttonUpdateCreditCard);
            this.groupBoxProductDetails.Controls.Add(this.textBoxCustomerID);
            this.groupBoxProductDetails.Controls.Add(this.labelCreditCardNumber);
            this.groupBoxProductDetails.Controls.Add(this.textBoxCCNum);
            this.groupBoxProductDetails.Controls.Add(this.labelFirstName);
            this.groupBoxProductDetails.Controls.Add(this.textBoxFirstName);
            this.groupBoxProductDetails.Controls.Add(this.labelCustomerID);
            this.groupBoxProductDetails.Location = new System.Drawing.Point(506, 46);
            this.groupBoxProductDetails.Text = "CUSTOMER DETAILS";
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelCustomerID, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxFirstName, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelFirstName, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxCCNum, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.labelCreditCardNumber, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxCustomerID, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonUpdateCreditCard, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonAdd, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonDelete, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonModify, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonUpdateProduct, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxLastName, 0);
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
            this.textBoxCustomerID.Enabled = false;
            this.textBoxCustomerID.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomerID.Location = new System.Drawing.Point(40, 59);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(175, 31);
            this.textBoxCustomerID.TabIndex = 19;
            // 
            // labelCreditCardNumber
            // 
            this.labelCreditCardNumber.AutoSize = true;
            this.labelCreditCardNumber.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditCardNumber.Location = new System.Drawing.Point(36, 236);
            this.labelCreditCardNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCreditCardNumber.Name = "labelCreditCardNumber";
            this.labelCreditCardNumber.Size = new System.Drawing.Size(91, 20);
            this.labelCreditCardNumber.TabIndex = 25;
            this.labelCreditCardNumber.Text = "Credit Card ";
            // 
            // textBoxCCNum
            // 
            this.textBoxCCNum.Enabled = false;
            this.textBoxCCNum.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxCCNum.Location = new System.Drawing.Point(40, 257);
            this.textBoxCCNum.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCCNum.Name = "textBoxCCNum";
            this.textBoxCCNum.Size = new System.Drawing.Size(172, 31);
            this.textBoxCCNum.TabIndex = 21;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(36, 105);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 24;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxFirstName.Location = new System.Drawing.Point(40, 126);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(175, 31);
            this.textBoxFirstName.TabIndex = 20;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(36, 38);
            this.labelCustomerID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(97, 20);
            this.labelCustomerID.TabIndex = 23;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // buttonUpdateCreditCard
            // 
            this.buttonUpdateCreditCard.Enabled = false;
            this.buttonUpdateCreditCard.Location = new System.Drawing.Point(40, 291);
            this.buttonUpdateCreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateCreditCard.Name = "buttonUpdateCreditCard";
            this.buttonUpdateCreditCard.Size = new System.Drawing.Size(80, 19);
            this.buttonUpdateCreditCard.TabIndex = 26;
            this.buttonUpdateCreditCard.Text = "New Credit Card";
            this.buttonUpdateCreditCard.UseVisualStyleBackColor = true;
            this.buttonUpdateCreditCard.Click += new System.EventHandler(this.buttonUpdateCreditCard_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(36, 169);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 20);
            this.labelLastName.TabIndex = 28;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxLastName.Location = new System.Drawing.Point(40, 190);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(175, 31);
            this.textBoxLastName.TabIndex = 27;
            // 
            // groupBoxNewCreditCard
            // 
            this.groupBoxNewCreditCard.AutoSize = true;
            this.groupBoxNewCreditCard.Controls.Add(this.textBoxYear);
            this.groupBoxNewCreditCard.Controls.Add(this.labelYear);
            this.groupBoxNewCreditCard.Controls.Add(this.labelMonth);
            this.groupBoxNewCreditCard.Controls.Add(this.textBoxMonth);
            this.groupBoxNewCreditCard.Controls.Add(this.labelSlash);
            this.groupBoxNewCreditCard.Controls.Add(this.buttonEnter);
            this.groupBoxNewCreditCard.Controls.Add(this.textBoxCreditCardNumber);
            this.groupBoxNewCreditCard.Controls.Add(this.textBoxNameOnCard);
            this.groupBoxNewCreditCard.Controls.Add(this.labelName);
            this.groupBoxNewCreditCard.Controls.Add(this.labelExpirationDate);
            this.groupBoxNewCreditCard.Controls.Add(this.labelCCNum);
            this.groupBoxNewCreditCard.Font = new System.Drawing.Font("Nirmala UI", 8.1F);
            this.groupBoxNewCreditCard.Location = new System.Drawing.Point(44, 265);
            this.groupBoxNewCreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNewCreditCard.Name = "groupBoxNewCreditCard";
            this.groupBoxNewCreditCard.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNewCreditCard.Size = new System.Drawing.Size(339, 165);
            this.groupBoxNewCreditCard.TabIndex = 29;
            this.groupBoxNewCreditCard.TabStop = false;
            this.groupBoxNewCreditCard.Text = "NEW CREDIT CARD";
            this.groupBoxNewCreditCard.Visible = false;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(47, 92);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(42, 22);
            this.textBoxYear.TabIndex = 12;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Nirmala UI", 8F);
            this.labelYear.Location = new System.Drawing.Point(47, 113);
            this.labelYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(27, 13);
            this.labelYear.TabIndex = 15;
            this.labelYear.Text = "Year";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Nirmala UI", 8F);
            this.labelMonth.Location = new System.Drawing.Point(5, 114);
            this.labelMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(42, 13);
            this.labelMonth.TabIndex = 14;
            this.labelMonth.Text = "Month";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(6, 92);
            this.textBoxMonth.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(28, 22);
            this.textBoxMonth.TabIndex = 11;
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlash.Location = new System.Drawing.Point(33, 87);
            this.labelSlash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(21, 30);
            this.labelSlash.TabIndex = 13;
            this.labelSlash.Text = "/";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(218, 126);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(103, 20);
            this.buttonEnter.TabIndex = 10;
            this.buttonEnter.Text = "Save Credit Card";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxCreditCardNumber
            // 
            this.textBoxCreditCardNumber.Location = new System.Drawing.Point(166, 42);
            this.textBoxCreditCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCreditCardNumber.Name = "textBoxCreditCardNumber";
            this.textBoxCreditCardNumber.Size = new System.Drawing.Size(159, 22);
            this.textBoxCreditCardNumber.TabIndex = 5;
            // 
            // textBoxNameOnCard
            // 
            this.textBoxNameOnCard.Location = new System.Drawing.Point(4, 42);
            this.textBoxNameOnCard.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(146, 22);
            this.textBoxNameOnCard.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(4, 24);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name on Card";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelExpirationDate.Location = new System.Drawing.Point(3, 71);
            this.labelExpirationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(117, 20);
            this.labelExpirationDate.TabIndex = 2;
            this.labelExpirationDate.Text = "Expiration Date";
            // 
            // labelCCNum
            // 
            this.labelCCNum.AutoSize = true;
            this.labelCCNum.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelCCNum.Location = new System.Drawing.Point(166, 24);
            this.labelCCNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCCNum.Name = "labelCCNum";
            this.labelCCNum.Size = new System.Drawing.Size(149, 20);
            this.labelCCNum.TabIndex = 0;
            this.labelCCNum.Text = "Credit Card Number";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 500);
            this.Controls.Add(this.groupBoxNewCreditCard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Controls.SetChildIndex(this.labelProductMenu, 0);
            this.Controls.SetChildIndex(this.buttonCreate, 0);
            this.Controls.SetChildIndex(this.buttonReadAll, 0);
            this.Controls.SetChildIndex(this.buttonReadOne, 0);
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
        private System.Windows.Forms.TextBox textBoxCCNum;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Button buttonUpdateCreditCard;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.GroupBox groupBoxNewCreditCard;
        private System.Windows.Forms.Label labelCCNum;
        private System.Windows.Forms.TextBox textBoxCreditCardNumber;
        private System.Windows.Forms.TextBox textBoxNameOnCard;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label labelSlash;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonth;
    }
}