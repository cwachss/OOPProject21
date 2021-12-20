﻿
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProducts = new System.Windows.Forms.PictureBox();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Agency FB", 27.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(99, 70);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(379, 45);
            this.labelWelcome.TabIndex = 7;
            this.labelWelcome.Text = "Welcome to Toys of All Sorts";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.BackColor = System.Drawing.Color.Transparent;
            this.labelProducts.Font = new System.Drawing.Font("Agency FB", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(106, 394);
            this.labelProducts.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(120, 46);
            this.labelProducts.TabIndex = 8;
            this.labelProducts.Text = "Products";
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.BackColor = System.Drawing.Color.White;
            this.labelCustomers.Font = new System.Drawing.Font("Agency FB", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomers.Location = new System.Drawing.Point(417, 394);
            this.labelCustomers.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(140, 46);
            this.labelCustomers.TabIndex = 9;
            this.labelCustomers.Text = "Customers";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::UserInterface2._0.Properties.Resources.toysLogo3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(90, 113);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProducts
            // 
            this.pictureBoxProducts.Image = global::UserInterface2._0.Properties.Resources.shoppingcart1;
            this.pictureBoxProducts.Location = new System.Drawing.Point(-2, 136);
            this.pictureBoxProducts.Name = "pictureBoxProducts";
            this.pictureBoxProducts.Size = new System.Drawing.Size(328, 276);
            this.pictureBoxProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProducts.TabIndex = 3;
            this.pictureBoxProducts.TabStop = false;
            this.pictureBoxProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Image = global::UserInterface2._0.Properties.Resources.toystorepeoples;
            this.pictureBoxCustomer.Location = new System.Drawing.Point(332, 136);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(328, 276);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCustomer.TabIndex = 2;
            this.pictureBoxCustomer.TabStop = false;
            this.pictureBoxCustomer.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(661, 445);
            this.Controls.Add(this.labelCustomers);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxProducts);
            this.Controls.Add(this.pictureBoxCustomer);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.PictureBox pictureBoxProducts;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelCustomers;
    }
}