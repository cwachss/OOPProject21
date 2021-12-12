
namespace UserInterface2._0
{
    partial class MainMenu
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
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProducts
            // 
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonProducts.Location = new System.Drawing.Point(0, 0);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(219, 450);
            this.buttonProducts.TabIndex = 0;
            this.buttonProducts.Text = "PRODUCTS";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCustomers.Location = new System.Drawing.Point(219, 0);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(219, 450);
            this.buttonCustomers.TabIndex = 1;
            this.buttonCustomers.Text = "CUSTOMERS";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(438, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 450);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonCustomers);
            this.Controls.Add(this.buttonProducts);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button button3;
    }
}