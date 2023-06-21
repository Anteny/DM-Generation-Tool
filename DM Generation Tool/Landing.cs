namespace DM_Generation_Tool
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void Shop_Click(object sender, EventArgs e)
        {
            Shop shopform = new();
            shopform.ShowDialog();
        }

        private void InitializationOneTimeOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Databases.CreateShopTables();
        }

        private void DeleteDatabasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Databases.DropShopTables();
        }
    }
}