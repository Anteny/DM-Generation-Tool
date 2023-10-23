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
    public partial class AddItemDeets : Form
    {
        public AddItemDeets()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (NameText.Text == string.Empty)
            {
                MessageBox.Show("Name needs to be entered");
                return;
            }
            if (DesText.Text != string.Empty)
            {
                MessageBox.Show("Description needs to be entered");
                return;
            }
            if (PriceText.Text != string.Empty)
            {
                MessageBox.Show("Price needs to be entered");
                return;
            }
            if (ThemeText.Text != string.Empty)
            {
                MessageBox.Show("Theme needs to be entered");
                return;
            }
            if (Type1Text.Text != string.Empty)
            {
                MessageBox.Show("shop type 1 needs to be entered. None is acceptable");
                return;
            }
            if (Type2Text.Text == string.Empty)
            {
                MessageBox.Show("shop type 2 needs to be entered. None is acceptable");
                return;
            }
            if (Type3Text.Text == string.Empty)
            {
                MessageBox.Show("shop type 3 needs to be entered. None is acceptable");
                return;
            }
            if (Type4Text.Text == string.Empty)
            {
                MessageBox.Show("Item type needs to be entered. None is acceptable");
                return;
            }
            int id = Databases.GetAmount("Shop") + 1;
            Databases.AddShopItem(id, NameText.Text, DesText.Text, PriceText.Text,
                ThemeText.Text, Type1Text.Text, Type2Text.Text, Type3Text.Text, Type4Text.Text);
            Close();
        }
    }
}
