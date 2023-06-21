using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Generation_Tool
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void AddItemToGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemDeets AddItemForm = new();
            AddItemForm.ShowDialog();
        }

        private void ShowAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Databases.ShowAllItems());
        }

        private void GenerateItems_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(ItemCount.Text);
            if (temp != 0)
            {
                ShopList.Text = Databases.ShowItems(temp);
            }
        }
    }
}
