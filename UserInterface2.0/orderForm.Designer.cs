
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
            this.SuspendLayout();
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnMenu.Font = new System.Drawing.Font("Nirmala UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnMenu.Location = new System.Drawing.Point(1, 1235);
            this.buttonReturnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReturnMenu.Name = "buttonReturnMenu";
            this.buttonReturnMenu.Size = new System.Drawing.Size(2096, 116);
            this.buttonReturnMenu.TabIndex = 23;
            this.buttonReturnMenu.Text = "Main Menu";
            this.buttonReturnMenu.UseVisualStyleBackColor = false;
            this.buttonReturnMenu.Visible = false;
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReadAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadAll.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.buttonReadAll.Location = new System.Drawing.Point(1398, 120);
            this.buttonReadAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReadAll.Name = "buttonReadAll";
            this.buttonReadAll.Size = new System.Drawing.Size(699, 1231);
            this.buttonReadAll.TabIndex = 22;
            this.buttonReadAll.Text = "ALL ORDERS";
            this.buttonReadAll.UseVisualStyleBackColor = false;
            // 
            // buttonReadOne
            // 
            this.buttonReadOne.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReadOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReadOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadOne.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.buttonReadOne.Location = new System.Drawing.Point(699, 120);
            this.buttonReadOne.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReadOne.Name = "buttonReadOne";
            this.buttonReadOne.Size = new System.Drawing.Size(699, 1231);
            this.buttonReadOne.TabIndex = 21;
            this.buttonReadOne.Text = "FIND ORDER";
            this.buttonReadOne.UseVisualStyleBackColor = false;
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
            this.buttonCreate.Size = new System.Drawing.Size(699, 1231);
            this.buttonCreate.TabIndex = 20;
            this.buttonCreate.Text = "PLACE ORDER";
            this.buttonCreate.UseVisualStyleBackColor = false;
            // 
            // labelOrderTitle
            // 
            this.labelOrderTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelOrderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOrderTitle.Font = new System.Drawing.Font("Agency FB", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderTitle.Location = new System.Drawing.Point(0, 0);
            this.labelOrderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderTitle.Name = "labelOrderTitle";
            this.labelOrderTitle.Size = new System.Drawing.Size(2100, 120);
            this.labelOrderTitle.TabIndex = 19;
            this.labelOrderTitle.Text = "Order Menu";
            this.labelOrderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2100, 1351);
            this.Controls.Add(this.buttonReturnMenu);
            this.Controls.Add(this.buttonReadAll);
            this.Controls.Add(this.buttonReadOne);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelOrderTitle);
            this.Name = "orderForm";
            this.Text = "Orders";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button buttonReturnMenu;
        protected System.Windows.Forms.Button buttonReadAll;
        protected System.Windows.Forms.Button buttonReadOne;
        protected System.Windows.Forms.Button buttonCreate;
        protected System.Windows.Forms.Label labelOrderTitle;
    }
}