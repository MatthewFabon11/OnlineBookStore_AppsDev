namespace OnlineBookStore
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entry entry = new Entry();
            entry.Show();
        }
    }
}
