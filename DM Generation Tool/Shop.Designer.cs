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
            GenerateItems = new Button();
            label1 = new Label();
            ItemCount = new TextBox();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            addItemToGeneratorToolStripMenuItem = new ToolStripMenuItem();
            showAllItemsToolStripMenuItem = new ToolStripMenuItem();
            ShopList = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            vScrollBar1 = new VScrollBar();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GenerateItems
            // 
            GenerateItems.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenerateItems.Location = new Point(453, 33);
            GenerateItems.Margin = new Padding(2);
            GenerateItems.Name = "GenerateItems";
            GenerateItems.Size = new Size(99, 25);
            GenerateItems.TabIndex = 1;
            GenerateItems.Text = "Generate";
            GenerateItems.UseVisualStyleBackColor = true;
            GenerateItems.Click += GenerateItems_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(342, 18);
            label1.TabIndex = 2;
            label1.Text = "Enter the number of items to generate (Max 100)";
            // 
            // ItemCount
            // 
            ItemCount.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemCount.Location = new Point(362, 33);
            ItemCount.Margin = new Padding(2);
            ItemCount.Name = "ItemCount";
            ItemCount.Size = new Size(87, 26);
            ItemCount.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(690, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addItemToGeneratorToolStripMenuItem, showAllItemsToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 22);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // addItemToGeneratorToolStripMenuItem
            // 
            addItemToGeneratorToolStripMenuItem.Name = "addItemToGeneratorToolStripMenuItem";
            addItemToGeneratorToolStripMenuItem.Size = new Size(193, 22);
            addItemToGeneratorToolStripMenuItem.Text = "Add Item To Generator";
            addItemToGeneratorToolStripMenuItem.Click += AddItemToGeneratorToolStripMenuItem_Click;
            // 
            // showAllItemsToolStripMenuItem
            // 
            showAllItemsToolStripMenuItem.Name = "showAllItemsToolStripMenuItem";
            showAllItemsToolStripMenuItem.Size = new Size(193, 22);
            showAllItemsToolStripMenuItem.Text = "Show All Items";
            showAllItemsToolStripMenuItem.Click += ShowAllItemsToolStripMenuItem_Click;
            // 
            // ShopList
            // 
            ShopList.AutoSize = true;
            ShopList.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShopList.Location = new Point(16, 119);
            ShopList.Margin = new Padding(2, 0, 2, 0);
            ShopList.Name = "ShopList";
            ShopList.Size = new Size(50, 18);
            ShopList.TabIndex = 5;
            ShopList.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 70);
            label2.Name = "label2";
            label2.Size = new Size(23, 18);
            label2.TabIndex = 6;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 70);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 7;
            label3.Text = "Count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(100, 70);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(156, 70);
            label5.Name = "label5";
            label5.Size = new Size(88, 18);
            label5.TabIndex = 9;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(329, 70);
            label6.Name = "label6";
            label6.Size = new Size(56, 18);
            label6.TabIndex = 10;
            label6.Text = "Theme";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(447, 70);
            label7.Name = "label7";
            label7.Size = new Size(54, 18);
            label7.TabIndex = 11;
            label7.Text = "Shop2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(391, 70);
            label8.Name = "label8";
            label8.Size = new Size(54, 18);
            label8.TabIndex = 12;
            label8.Text = "Shop1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(503, 70);
            label9.Name = "label9";
            label9.Size = new Size(54, 18);
            label9.TabIndex = 13;
            label9.Text = "Shop3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(563, 70);
            label10.Name = "label10";
            label10.Size = new Size(41, 18);
            label10.TabIndex = 14;
            label10.Text = "Type";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(610, 70);
            label11.Name = "label11";
            label11.Size = new Size(45, 18);
            label11.TabIndex = 15;
            label11.Text = "Price";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(673, 24);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 246);
            vScrollBar1.TabIndex = 0;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 270);
            Controls.Add(vScrollBar1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ShopList);
            Controls.Add(ItemCount);
            Controls.Add(label1);
            Controls.Add(GenerateItems);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Shop";
            Text = "Shop";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private VScrollBar vScrollBar1;
    }
}