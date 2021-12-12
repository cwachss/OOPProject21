
namespace UserInterface2._0
{
    partial class CustomerForm : BaseForm
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
            this.buttonCancelNewCC = new System.Windows.Forms.Button();
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
            this.labelPrintInfo = new System.Windows.Forms.Label();
            this.groupBoxProductDetails.SuspendLayout();
            this.groupBoxNewCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.Location = new System.Drawing.Point(1, 555);
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.Location = new System.Drawing.Point(349, 50);
            this.buttonReadAll.Size = new System.Drawing.Size(349, 565);
            this.buttonReadAll.Text = "ALL CUSTOMERS";
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.Location = new System.Drawing.Point(698, 50);
            this.buttonReadOne.Size = new System.Drawing.Size(349, 565);
            this.buttonReadOne.Text = "FIND CUSTOMER";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(0, 50);
            this.buttonCreate.Size = new System.Drawing.Size(349, 565);
            this.buttonCreate.Text = "NEW CUSTOMER";
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.Size = new System.Drawing.Size(1049, 50);
            this.labelProductMenu.Text = "Customer Menu";
            // 
            // textBoxProductNumber2
            // 
            this.textBoxProductNumber2.Location = new System.Drawing.Point(59, 132);
            // 
            // buttonListDetails
            // 
            this.buttonListDetails.Location = new System.Drawing.Point(59, 178);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.Location = new System.Drawing.Point(53, 103);
            this.labelEnterNumber.Size = new System.Drawing.Size(260, 25);
            this.labelEnterNumber.Text = "Enter Customer ID Number:";
            // 
            // textBoxPrintProducts
            // 
            this.textBoxPrintProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.groupBoxProductDetails.Location = new System.Drawing.Point(675, 57);
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
            // buttonAdd
            // 
            this.buttonAdd.Text = "ADD CUSTOMER";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Enabled = false;
            this.textBoxCustomerID.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomerID.Location = new System.Drawing.Point(53, 73);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(232, 36);
            this.textBoxCustomerID.TabIndex = 19;
            // 
            // labelCreditCardNumber
            // 
            this.labelCreditCardNumber.AutoSize = true;
            this.labelCreditCardNumber.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditCardNumber.Location = new System.Drawing.Point(48, 290);
            this.labelCreditCardNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCreditCardNumber.Name = "labelCreditCardNumber";
            this.labelCreditCardNumber.Size = new System.Drawing.Size(118, 25);
            this.labelCreditCardNumber.TabIndex = 25;
            this.labelCreditCardNumber.Text = "Credit Card ";
            // 
            // textBoxCCNum
            // 
            this.textBoxCCNum.Enabled = false;
            this.textBoxCCNum.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxCCNum.Location = new System.Drawing.Point(53, 316);
            this.textBoxCCNum.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCCNum.Name = "textBoxCCNum";
            this.textBoxCCNum.Size = new System.Drawing.Size(228, 36);
            this.textBoxCCNum.TabIndex = 21;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(48, 129);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(107, 25);
            this.labelFirstName.TabIndex = 24;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxFirstName.Location = new System.Drawing.Point(53, 155);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(232, 36);
            this.textBoxFirstName.TabIndex = 20;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(48, 47);
            this.labelCustomerID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(123, 25);
            this.labelCustomerID.TabIndex = 23;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // buttonUpdateCreditCard
            // 
            this.buttonUpdateCreditCard.Enabled = false;
            this.buttonUpdateCreditCard.Location = new System.Drawing.Point(53, 358);
            this.buttonUpdateCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateCreditCard.Name = "buttonUpdateCreditCard";
            this.buttonUpdateCreditCard.Size = new System.Drawing.Size(153, 23);
            this.buttonUpdateCreditCard.TabIndex = 26;
            this.buttonUpdateCreditCard.Text = "New Credit Card";
            this.buttonUpdateCreditCard.UseVisualStyleBackColor = true;
            this.buttonUpdateCreditCard.Click += new System.EventHandler(this.buttonUpdateCreditCard_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(48, 208);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(104, 25);
            this.labelLastName.TabIndex = 28;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxLastName.Location = new System.Drawing.Point(53, 234);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(232, 36);
            this.textBoxLastName.TabIndex = 27;
            // 
            // groupBoxNewCreditCard
            // 
            this.groupBoxNewCreditCard.AutoSize = true;
            this.groupBoxNewCreditCard.Controls.Add(this.buttonCancelNewCC);
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
            this.groupBoxNewCreditCard.Enabled = false;
            this.groupBoxNewCreditCard.Font = new System.Drawing.Font("Nirmala UI", 8.1F);
            this.groupBoxNewCreditCard.Location = new System.Drawing.Point(59, 326);
            this.groupBoxNewCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxNewCreditCard.Name = "groupBoxNewCreditCard";
            this.groupBoxNewCreditCard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxNewCreditCard.Size = new System.Drawing.Size(452, 203);
            this.groupBoxNewCreditCard.TabIndex = 29;
            this.groupBoxNewCreditCard.TabStop = false;
            this.groupBoxNewCreditCard.Text = "NEW CREDIT CARD";
            this.groupBoxNewCreditCard.Visible = false;
            // 
            // buttonCancelNewCC
            // 
            this.buttonCancelNewCC.Location = new System.Drawing.Point(339, 118);
            this.buttonCancelNewCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelNewCC.Name = "buttonCancelNewCC";
            this.buttonCancelNewCC.Size = new System.Drawing.Size(89, 25);
            this.buttonCancelNewCC.TabIndex = 16;
            this.buttonCancelNewCC.Text = "Cancel";
            this.buttonCancelNewCC.UseVisualStyleBackColor = true;
            this.buttonCancelNewCC.Click += new System.EventHandler(this.buttonCancelNewCC_Click);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(63, 113);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(55, 25);
            this.textBoxYear.TabIndex = 12;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Nirmala UI", 8F);
            this.labelYear.Location = new System.Drawing.Point(63, 139);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(35, 19);
            this.labelYear.TabIndex = 15;
            this.labelYear.Text = "Year";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Nirmala UI", 8F);
            this.labelMonth.Location = new System.Drawing.Point(7, 140);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(51, 19);
            this.labelMonth.TabIndex = 14;
            this.labelMonth.Text = "Month";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(8, 113);
            this.textBoxMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(36, 25);
            this.textBoxMonth.TabIndex = 11;
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlash.Location = new System.Drawing.Point(44, 107);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(28, 37);
            this.labelSlash.TabIndex = 13;
            this.labelSlash.Text = "/";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(291, 155);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(137, 25);
            this.buttonEnter.TabIndex = 10;
            this.buttonEnter.Text = "Save Credit Card";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxCreditCardNumber
            // 
            this.textBoxCreditCardNumber.Location = new System.Drawing.Point(221, 52);
            this.textBoxCreditCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreditCardNumber.Name = "textBoxCreditCardNumber";
            this.textBoxCreditCardNumber.Size = new System.Drawing.Size(211, 25);
            this.textBoxCreditCardNumber.TabIndex = 5;
            // 
            // textBoxNameOnCard
            // 
            this.textBoxNameOnCard.Location = new System.Drawing.Point(5, 52);
            this.textBoxNameOnCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(193, 25);
            this.textBoxNameOnCard.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(5, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(140, 25);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name on Card";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelExpirationDate.Location = new System.Drawing.Point(4, 87);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(150, 25);
            this.labelExpirationDate.TabIndex = 2;
            this.labelExpirationDate.Text = "Expiration Date";
            // 
            // labelCCNum
            // 
            this.labelCCNum.AutoSize = true;
            this.labelCCNum.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelCCNum.Location = new System.Drawing.Point(221, 30);
            this.labelCCNum.Name = "labelCCNum";
            this.labelCCNum.Size = new System.Drawing.Size(192, 25);
            this.labelCCNum.TabIndex = 0;
            this.labelCCNum.Text = "Credit Card Number";
            // 
            // labelPrintInfo
            // 
            this.labelPrintInfo.AutoSize = true;
            this.labelPrintInfo.Location = new System.Drawing.Point(12, 58);
            this.labelPrintInfo.Name = "labelPrintInfo";
            this.labelPrintInfo.Size = new System.Drawing.Size(347, 16);
            this.labelPrintInfo.TabIndex = 30;
            this.labelPrintInfo.Text = "Name:      CreditCardNumber:      Expiration- Year      Month";
            this.labelPrintInfo.Visible = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 615);
            this.Controls.Add(this.groupBoxNewCreditCard);
            this.Controls.Add(this.labelPrintInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Controls.SetChildIndex(this.labelPrintInfo, 0);
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
        private System.Windows.Forms.Button buttonCancelNewCC;
        private System.Windows.Forms.Label labelPrintInfo;
    }
}