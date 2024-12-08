using OnlineBookStore_AppsDev;

namespace OnlineBookStore
{
    public partial class AdminPanel : Form
    {
        private string InputTitle = "";
        private int InputISBN;
        private string InputAuthor = "";
        private string InputGenre = "";
        public AdminPanel()
        {
            InitializeComponent();
        }


        private void AddBttn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(QuantityTxtBox.Text, out InputISBN))
            {
                MessageBox.Show("Please enter a valid ISBN.");
                return;
            }

            InputTitle = TitleTxtBox.Text;
            InputAuthor = AuthorTxtBox.Text;
            InputGenre = GenreCmbBox.Text;

            books book = new books(InputTitle, InputISBN , InputAuthor, InputGenre);
            string info = book.GetDetails();
            bookList.Items.Add(info);
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entry entry = new Entry();
            entry.Show();
        }
    }
}
