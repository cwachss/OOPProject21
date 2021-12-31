
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
        private new void InitializeComponent()
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
            this.labelExpirationDate = new System.Windows.Forms.Label();
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
            this.labelCCNum = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxProductDetails.SuspendLayout();
            this.groupBoxNewCreditCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.Location = new System.Drawing.Point(0, 507);
            this.buttonReturnMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.Location = new System.Drawing.Point(262, 59);
            this.buttonReadAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonReadAll.Size = new System.Drawing.Size(262, 494);
            this.buttonReadAll.Text = "ALL CUSTOMERS";
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.Location = new System.Drawing.Point(524, 59);
            this.buttonReadOne.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonReadOne.Size = new System.Drawing.Size(262, 494);
            this.buttonReadOne.Text = "FIND CUSTOMER";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(0, 59);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCreate.Size = new System.Drawing.Size(262, 494);
            this.buttonCreate.Text = "NEW CUSTOMER";
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductMenu.Size = new System.Drawing.Size(785, 59);
            this.labelProductMenu.Text = "Customer Menu";
            // 
            // textBoxProductNumber2
            // 
            this.textBoxProductNumber2.Location = new System.Drawing.Point(66, 143);
            this.textBoxProductNumber2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            // 
            // buttonListDetails
            // 
            this.buttonListDetails.Location = new System.Drawing.Point(66, 190);
            this.buttonListDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.Location = new System.Drawing.Point(62, 107);
            this.labelEnterNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterNumber.Size = new System.Drawing.Size(205, 20);
            this.labelEnterNumber.Text = "Enter Customer ID Number:";
            // 
            // textBoxPrintProducts
            // 
            this.textBoxPrintProducts.Location = new System.Drawing.Point(30, 70);
            this.textBoxPrintProducts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrintProducts.Size = new System.Drawing.Size(436, 415);
           // this.textBoxPrintProducts.TextChanged += new System.EventHandler(this.textBoxPrintProducts_TextChanged);
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
            this.groupBoxProductDetails.Location = new System.Drawing.Point(513, 70);
            this.groupBoxProductDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxProductDetails.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxProductDetails.Size = new System.Drawing.Size(246, 413);
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
            this.buttonUpdateProduct.Location = new System.Drawing.Point(38, 338);
            this.buttonUpdateProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonUpdateProduct.Text = "Update Customer Details";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(38, 338);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(135, 338);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(38, 338);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAdd.Text = "ADD CUSTOMER";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Enabled = false;
            this.textBoxCustomerID.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomerID.Location = new System.Drawing.Point(30, 59);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(175, 31);
            this.textBoxCustomerID.TabIndex = 19;
            // 
            // labelCreditCardNumber
            // 
            this.labelCreditCardNumber.AutoSize = true;
            this.labelCreditCardNumber.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditCardNumber.Location = new System.Drawing.Point(36, 237);
            this.labelCreditCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreditCardNumber.Name = "labelCreditCardNumber";
            this.labelCreditCardNumber.Size = new System.Drawing.Size(91, 20);
            this.labelCreditCardNumber.TabIndex = 25;
            this.labelCreditCardNumber.Text = "Credit Card ";
            // 
            // textBoxCCNum
            // 
            this.textBoxCCNum.Enabled = false;
            this.textBoxCCNum.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxCCNum.Location = new System.Drawing.Point(33, 257);
            this.textBoxCCNum.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxCCNum.Name = "textBoxCCNum";
            this.textBoxCCNum.Size = new System.Drawing.Size(172, 31);
            this.textBoxCCNum.TabIndex = 21;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(36, 105);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 24;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxFirstName.Location = new System.Drawing.Point(30, 126);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(175, 31);
            this.textBoxFirstName.TabIndex = 20;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(36, 38);
            this.labelCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(97, 20);
            this.labelCustomerID.TabIndex = 23;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // buttonUpdateCreditCard
            // 
            this.buttonUpdateCreditCard.Enabled = false;
            this.buttonUpdateCreditCard.Location = new System.Drawing.Point(38, 308);
            this.buttonUpdateCreditCard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonUpdateCreditCard.Name = "buttonUpdateCreditCard";
            this.buttonUpdateCreditCard.Size = new System.Drawing.Size(116, 20);
            this.buttonUpdateCreditCard.TabIndex = 26;
            this.buttonUpdateCreditCard.Text = "Update Credit Card";
            this.buttonUpdateCreditCard.UseVisualStyleBackColor = true;
            this.buttonUpdateCreditCard.Visible = false;
            this.buttonUpdateCreditCard.Click += new System.EventHandler(this.buttonUpdateCreditCard_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(36, 169);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 20);
            this.labelLastName.TabIndex = 28;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxLastName.Location = new System.Drawing.Point(30, 190);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(175, 31);
            this.textBoxLastName.TabIndex = 27;
            // 
            // groupBoxNewCreditCard
            // 
            this.groupBoxNewCreditCard.AutoSize = true;
            this.groupBoxNewCreditCard.Controls.Add(this.labelExpirationDate);
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
            this.groupBoxNewCreditCard.Controls.Add(this.labelCCNum);
            this.groupBoxNewCreditCard.Font = new System.Drawing.Font("Nirmala UI", 8.1F);
            this.groupBoxNewCreditCard.Location = new System.Drawing.Point(57, 315);
            this.groupBoxNewCreditCard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxNewCreditCard.Name = "groupBoxNewCreditCard";
            this.groupBoxNewCreditCard.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxNewCreditCard.Size = new System.Drawing.Size(340, 154);
            this.groupBoxNewCreditCard.TabIndex = 29;
            this.groupBoxNewCreditCard.TabStop = false;
            this.groupBoxNewCreditCard.Text = "NEW CREDIT CARD";
            this.groupBoxNewCreditCard.Visible = false;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelExpirationDate.Location = new System.Drawing.Point(3, 74);
            this.labelExpirationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(117, 20);
            this.labelExpirationDate.TabIndex = 2;
            this.labelExpirationDate.Text = "Expiration Date";
            // 
            // buttonCancelNewCC
            // 
            this.buttonCancelNewCC.Location = new System.Drawing.Point(262, 88);
            this.buttonCancelNewCC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancelNewCC.Name = "buttonCancelNewCC";
            this.buttonCancelNewCC.Size = new System.Drawing.Size(68, 20);
            this.buttonCancelNewCC.TabIndex = 16;
            this.buttonCancelNewCC.Text = "Cancel";
            this.buttonCancelNewCC.UseVisualStyleBackColor = true;
            this.buttonCancelNewCC.Click += new System.EventHandler(this.buttonCancelNewCC_Click);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(50, 96);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(42, 22);
            this.textBoxYear.TabIndex = 12;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Nirmala UI", 8F);
            this.labelYear.Location = new System.Drawing.Point(46, 120);
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
            this.labelMonth.Location = new System.Drawing.Point(4, 120);
            this.labelMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(42, 13);
            this.labelMonth.TabIndex = 14;
            this.labelMonth.Text = "Month";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(8, 96);
            this.textBoxMonth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.buttonEnter.Location = new System.Drawing.Point(226, 113);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(104, 20);
            this.buttonEnter.TabIndex = 10;
            this.buttonEnter.Text = "Save Credit Card";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxCreditCardNumber
            // 
            this.textBoxCreditCardNumber.Location = new System.Drawing.Point(170, 46);
            this.textBoxCreditCardNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxCreditCardNumber.Name = "textBoxCreditCardNumber";
            this.textBoxCreditCardNumber.Size = new System.Drawing.Size(158, 22);
            this.textBoxCreditCardNumber.TabIndex = 5;
            // 
            // textBoxNameOnCard
            // 
            this.textBoxNameOnCard.Location = new System.Drawing.Point(8, 46);
            this.textBoxNameOnCard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(146, 22);
            this.textBoxNameOnCard.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(4, 23);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name on Card";
            // 
            // labelCCNum
            // 
            this.labelCCNum.AutoSize = true;
            this.labelCCNum.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelCCNum.Location = new System.Drawing.Point(166, 23);
            this.labelCCNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCCNum.Name = "labelCCNum";
            this.labelCCNum.Size = new System.Drawing.Size(149, 20);
            this.labelCCNum.TabIndex = 0;
            this.labelCCNum.Text = "Credit Card Number";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::UserInterface2._0.Properties.Resources.toysLogo3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(44, 56);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 30;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 553);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBoxNewCreditCard);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
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
            this.Controls.SetChildIndex(this.pictureBoxLogo, 0);
            this.groupBoxProductDetails.ResumeLayout(false);
            this.groupBoxProductDetails.PerformLayout();
            this.groupBoxNewCreditCard.ResumeLayout(false);
            this.groupBoxNewCreditCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}