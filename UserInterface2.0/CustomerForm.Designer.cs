
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
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCCNumber = new System.Windows.Forms.TextBox();
            this.textBoxCCMonth = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCCYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.Location = new System.Drawing.Point(0, 578);
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.Size = new System.Drawing.Size(347, 577);
            this.buttonReadAll.Text = "ALL CUSTOMERS";
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.Size = new System.Drawing.Size(349, 577);
            this.buttonReadOne.Text = "FIND CUSTOMER";
           // this.buttonReadOne.Click += new System.EventHandler(this.buttonReadOne_Click_1);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Size = new System.Drawing.Size(349, 577);
            this.buttonCreate.Text = "NEW CUSTOMER";
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.Size = new System.Drawing.Size(1045, 62);
            this.labelProductMenu.Text = "Customer Menu";
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.Size = new System.Drawing.Size(260, 25);
            this.labelEnterNumber.Text = "Enter Customer ID Number:";
            // 
            // textBoxPrintProducts
            // 
            this.textBoxPrintProducts.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPrintProducts.Size = new System.Drawing.Size(580, 600);
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.Controls.Add(this.label5);
            this.groupBoxProductDetails.Controls.Add(this.label4);
            this.groupBoxProductDetails.Controls.Add(this.textBoxCCYear);
            this.groupBoxProductDetails.Controls.Add(this.label3);
            this.groupBoxProductDetails.Controls.Add(this.label2);
            this.groupBoxProductDetails.Controls.Add(this.label1);
            this.groupBoxProductDetails.Controls.Add(this.textBoxCustomerID);
            this.groupBoxProductDetails.Controls.Add(this.textBoxCCMonth);
            this.groupBoxProductDetails.Controls.Add(this.textBoxCCNumber);
            this.groupBoxProductDetails.Controls.Add(this.textBoxCustomerName);
            this.groupBoxProductDetails.Location = new System.Drawing.Point(669, 64);
            this.groupBoxProductDetails.Text = "CUSTOMER DETAILS";
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonAdd, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonDelete, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonModify, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxCustomerName, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxCCNumber, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxCCMonth, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxCustomerID, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.label1, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.label2, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.label3, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.textBoxCCYear, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.label4, 0);
            this.groupBoxProductDetails.Controls.SetChildIndex(this.label5, 0);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdate.Text = "Update Customer Details";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Text = "ADD CUSTOMER";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(64, 75);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(243, 25);
            this.textBoxCustomerName.TabIndex = 19;
            // 
            // textBoxCCNumber
            // 
            this.textBoxCCNumber.Location = new System.Drawing.Point(64, 258);
            this.textBoxCCNumber.Name = "textBoxCCNumber";
            this.textBoxCCNumber.Size = new System.Drawing.Size(243, 25);
            this.textBoxCCNumber.TabIndex = 20;
            // 
            // textBoxCCMonth
            // 
            this.textBoxCCMonth.Location = new System.Drawing.Point(84, 341);
            this.textBoxCCMonth.Name = "textBoxCCMonth";
            this.textBoxCCMonth.Size = new System.Drawing.Size(82, 25);
            this.textBoxCCMonth.TabIndex = 21;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(64, 170);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(243, 25);
            this.textBoxCustomerID.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Credit Card Number:";
            // 
            // textBoxCCYear
            // 
            this.textBoxCCYear.Location = new System.Drawing.Point(225, 341);
            this.textBoxCCYear.Name = "textBoxCCYear";
            this.textBoxCCYear.Size = new System.Drawing.Size(82, 25);
            this.textBoxCCYear.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Year";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 639);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.groupBoxProductDetails.ResumeLayout(false);
            this.groupBoxProductDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxCCMonth;
        private System.Windows.Forms.TextBox textBoxCCNumber;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCCYear;
    }
}