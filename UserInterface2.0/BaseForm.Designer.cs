
namespace UserInterface2._0
{
    public partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.buttonReturnMenu = new System.Windows.Forms.Button();
            this.buttonReadAll = new System.Windows.Forms.Button();
            this.buttonReadOne = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelProductMenu = new System.Windows.Forms.Label();
            this.textBoxProductNumber2 = new System.Windows.Forms.TextBox();
            this.buttonListDetails = new System.Windows.Forms.Button();
            this.labelEnterNumber = new System.Windows.Forms.Label();
            this.textBoxPrintProducts = new System.Windows.Forms.TextBox();
            this.groupBoxProductDetails = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnMenu.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnMenu.Location = new System.Drawing.Point(0, 554);
            this.buttonReturnMenu.Margin = new System.Windows.Forms.Padding(1);
            this.buttonReturnMenu.Name = "buttonReturnMenu";
            this.buttonReturnMenu.Size = new System.Drawing.Size(1048, 60);
            this.buttonReturnMenu.TabIndex = 18;
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
            this.buttonReadAll.Size = new System.Drawing.Size(349, 553);
            this.buttonReadAll.TabIndex = 17;
            this.buttonReadAll.Text = "ALL ____________";
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
            this.buttonReadOne.Size = new System.Drawing.Size(349, 553);
            this.buttonReadOne.TabIndex = 16;
            this.buttonReadOne.Text = "FIND ___________";
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
            this.buttonCreate.Size = new System.Drawing.Size(349, 553);
            this.buttonCreate.TabIndex = 15;
            this.buttonCreate.Text = "NEW ___________";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelProductMenu
            // 
            this.labelProductMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProductMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProductMenu.Font = new System.Drawing.Font("Agency FB", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductMenu.Location = new System.Drawing.Point(0, 0);
            this.labelProductMenu.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelProductMenu.Name = "labelProductMenu";
            this.labelProductMenu.Size = new System.Drawing.Size(1049, 62);
            this.labelProductMenu.TabIndex = 14;
            this.labelProductMenu.Text = "________ Menu";
            this.labelProductMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProductNumber2
            // 
            this.textBoxProductNumber2.Font = new System.Drawing.Font("Nirmala UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductNumber2.Location = new System.Drawing.Point(67, 198);
            this.textBoxProductNumber2.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxProductNumber2.Name = "textBoxProductNumber2";
            this.textBoxProductNumber2.Size = new System.Drawing.Size(308, 39);
            this.textBoxProductNumber2.TabIndex = 19;
            this.textBoxProductNumber2.Visible = false;
            // 
            // buttonListDetails
            // 
            this.buttonListDetails.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListDetails.Location = new System.Drawing.Point(67, 256);
            this.buttonListDetails.Margin = new System.Windows.Forms.Padding(1);
            this.buttonListDetails.Name = "buttonListDetails";
            this.buttonListDetails.Size = new System.Drawing.Size(212, 50);
            this.buttonListDetails.TabIndex = 20;
            this.buttonListDetails.Text = "List Details";
            this.buttonListDetails.UseVisualStyleBackColor = true;
            this.buttonListDetails.Visible = false;
            this.buttonListDetails.Click += new System.EventHandler(this.buttonListDetails_Click);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.AutoSize = true;
            this.labelEnterNumber.BackColor = System.Drawing.SystemColors.Window;
            this.labelEnterNumber.Font = new System.Drawing.Font("Nirmala UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNumber.Location = new System.Drawing.Point(60, 164);
            this.labelEnterNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEnterNumber.Name = "labelEnterNumber";
            this.labelEnterNumber.Size = new System.Drawing.Size(213, 25);
            this.labelEnterNumber.TabIndex = 21;
            this.labelEnterNumber.Text = "Enter ________ Number:";
            this.labelEnterNumber.Visible = false;
            // 
            // textBoxPrintProducts
            // 
            this.textBoxPrintProducts.Location = new System.Drawing.Point(37, 64);
            this.textBoxPrintProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrintProducts.Multiline = true;
            this.textBoxPrintProducts.Name = "textBoxPrintProducts";
            this.textBoxPrintProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPrintProducts.Size = new System.Drawing.Size(580, 488);
            this.textBoxPrintProducts.TabIndex = 22;
            this.textBoxPrintProducts.Visible = false;
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.AutoSize = true;
            this.groupBoxProductDetails.Controls.Add(this.buttonUpdate);
            this.groupBoxProductDetails.Controls.Add(this.buttonModify);
            this.groupBoxProductDetails.Controls.Add(this.buttonDelete);
            this.groupBoxProductDetails.Controls.Add(this.buttonAdd);
            this.groupBoxProductDetails.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductDetails.Location = new System.Drawing.Point(664, 64);
            this.groupBoxProductDetails.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxProductDetails.Name = "groupBoxProductDetails";
            this.groupBoxProductDetails.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxProductDetails.Size = new System.Drawing.Size(332, 489);
            this.groupBoxProductDetails.TabIndex = 23;
            this.groupBoxProductDetails.TabStop = false;
            this.groupBoxProductDetails.Text = "________ DETAILS";
            this.groupBoxProductDetails.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(53, 412);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(229, 50);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update __________ Details";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Enabled = false;
            this.buttonModify.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Bold);
            this.buttonModify.Location = new System.Drawing.Point(53, 412);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(109, 50);
            this.buttonModify.TabIndex = 16;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Visible = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(184, 412);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 50);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(53, 412);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(229, 50);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "ADD __________";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 615);
            this.Controls.Add(this.groupBoxProductDetails);
            this.Controls.Add(this.textBoxProductNumber2);
            this.Controls.Add(this.buttonListDetails);
            this.Controls.Add(this.labelEnterNumber);
            this.Controls.Add(this.textBoxPrintProducts);
            this.Controls.Add(this.buttonReturnMenu);
            this.Controls.Add(this.buttonReadAll);
            this.Controls.Add(this.buttonReadOne);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelProductMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.groupBoxProductDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonReturnMenu;
        protected System.Windows.Forms.Button buttonReadAll;
        protected System.Windows.Forms.Button buttonReadOne;
        protected System.Windows.Forms.Button buttonCreate;
        protected System.Windows.Forms.Label labelProductMenu;
        protected System.Windows.Forms.TextBox textBoxProductNumber2;
        protected System.Windows.Forms.Button buttonListDetails;
        protected System.Windows.Forms.Label labelEnterNumber;
        protected System.Windows.Forms.TextBox textBoxPrintProducts;
        protected System.Windows.Forms.GroupBox groupBoxProductDetails;
        protected System.Windows.Forms.Button buttonUpdate;
        protected System.Windows.Forms.Button buttonModify;
        protected System.Windows.Forms.Button buttonDelete;
        protected System.Windows.Forms.Button buttonAdd;
    }
}

