namespace DM_Generation_Tool
{
    partial class Shop
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
            this.GenerateItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemCount = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShopList = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateItems
            // 
            this.GenerateItems.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateItems.Location = new System.Drawing.Point(646, 56);
            this.GenerateItems.Name = "GenerateItems";
            this.GenerateItems.Size = new System.Drawing.Size(142, 34);
            this.GenerateItems.TabIndex = 1;
            this.GenerateItems.Text = "Generate";
            this.GenerateItems.UseVisualStyleBackColor = true;
            this.GenerateItems.Click += new System.EventHandler(this.GenerateItems_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the number of items to generate (Max 100)";
            // 
            // ItemCount
            // 
            this.ItemCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemCount.Location = new System.Drawing.Point(562, 55);
            this.ItemCount.Name = "ItemCount";
            this.ItemCount.Size = new System.Drawing.Size(78, 35);
            this.ItemCount.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToGeneratorToolStripMenuItem,
            this.showAllItemsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addItemToGeneratorToolStripMenuItem
            // 
            this.addItemToGeneratorToolStripMenuItem.Name = "addItemToGeneratorToolStripMenuItem";
            this.addItemToGeneratorToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.addItemToGeneratorToolStripMenuItem.Text = "Add Item To Generator";
            this.addItemToGeneratorToolStripMenuItem.Click += new System.EventHandler(this.AddItemToGeneratorToolStripMenuItem_Click);
            // 
            // showAllItemsToolStripMenuItem
            // 
            this.showAllItemsToolStripMenuItem.Name = "showAllItemsToolStripMenuItem";
            this.showAllItemsToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.showAllItemsToolStripMenuItem.Text = "Show All Items";
            this.showAllItemsToolStripMenuItem.Click += new System.EventHandler(this.ShowAllItemsToolStripMenuItem_Click);
            // 
            // ShopList
            // 
            this.ShopList.AutoSize = true;
            this.ShopList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShopList.Location = new System.Drawing.Point(23, 102);
            this.ShopList.Name = "ShopList";
            this.ShopList.Size = new System.Drawing.Size(77, 27);
            this.ShopList.TabIndex = 5;
            this.ShopList.Text = "label2";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShopList);
            this.Controls.Add(this.ItemCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateItems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Shop";
            this.Text = "Shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button GenerateItems;
        private Label label1;
        private TextBox ItemCount;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem addItemToGeneratorToolStripMenuItem;
        private ToolStripMenuItem showAllItemsToolStripMenuItem;
        private Label ShopList;
    }
}