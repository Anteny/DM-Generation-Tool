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
    }
}