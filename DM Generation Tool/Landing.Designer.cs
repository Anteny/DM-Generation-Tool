namespace DM_Generation_Tool
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializationOneTimeOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDatabasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializationOneTimeOnlyToolStripMenuItem,
            this.deleteDatabasesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // initializationOneTimeOnlyToolStripMenuItem
            // 
            this.initializationOneTimeOnlyToolStripMenuItem.Name = "initializationOneTimeOnlyToolStripMenuItem";
            this.initializationOneTimeOnlyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.initializationOneTimeOnlyToolStripMenuItem.Text = "Initialization";
            this.initializationOneTimeOnlyToolStripMenuItem.Click += new System.EventHandler(this.InitializationOneTimeOnlyToolStripMenuItem_Click);
            // 
            // deleteDatabasesToolStripMenuItem
            // 
            this.deleteDatabasesToolStripMenuItem.Name = "deleteDatabasesToolStripMenuItem";
            this.deleteDatabasesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteDatabasesToolStripMenuItem.Text = "Delete Databases";
            this.deleteDatabasesToolStripMenuItem.Click += new System.EventHandler(this.DeleteDatabasesToolStripMenuItem_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Shop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Landing";
            this.Text = "Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Shop;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem initializationOneTimeOnlyToolStripMenuItem;
        private ToolStripMenuItem deleteDatabasesToolStripMenuItem;
    }
}