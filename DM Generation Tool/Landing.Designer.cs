﻿namespace DM_Generation_Tool
{
    partial class Landing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Shop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Shop
            // 
            this.Shop.Location = new System.Drawing.Point(46, 47);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(193, 54);
            this.Shop.TabIndex = 0;
            this.Shop.Text = "Shop Inventory";
            this.Shop.UseVisualStyleBackColor = true;
            this.Shop.Click += new System.EventHandler(this.Shop_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Shop);
            this.Name = "Landing";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Shop;
    }
}