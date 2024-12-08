using OnlineBookStore_AppsDev;
using System.Data.OleDb;
using System.Diagnostics.Tracing;

namespace OnlineBookStore
{
    public partial class AdminPanel : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        private string InputTitle = "";
        private int Inputqty;
        private string InputAuthor = "";
        private string InputGenre = "";
        public AdminPanel()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kuya\OneDrive\Desktop\v1\BOOK UP v1\Database.accdb;Persist Security Info=False;";

        }


        private void AddBttn_Click(object sender, EventArgs e)
        {          
           
            if (!int.TryParse(QuantityTxtBox.Text, out Inputqty))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            InputTitle = TitleTxtBox.Text;
            InputAuthor = AuthorTxtBox.Text;
            InputGenre = GenreCmbBox.Text;

            books book = new books(InputTitle, Inputqty , InputAuthor, InputGenre);
            string info = book.GetDetails();
            bookList.Items.Add(info);


            
            if (InputGenre == "Fiction")
            {
                connection.Open();

                string query = "INSERT INTO [AdminTB] ([Quantity], [Title], [Author], [Fiction]) VALUES (@Quantity, @Title , @Author, @Fiction)";

                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@Quantity", QuantityTxtBox.Text);
                command.Parameters.AddWithValue("@Title", TitleTxtBox.Text);
                command.Parameters.AddWithValue("@Author", AuthorTxtBox.Text);
                command.Parameters.AddWithValue("@Fiction", GenreCmbBox.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("BOOK ADDED");
                connection.Close();
            }
            else if (InputGenre == "Non-Fiction")
            {
                connection.Open();

                string query = "INSERT INTO [AdminTB] ([Quantity], [Title], [Author], [Nonfiction]) VALUES (@Quantity, @Title , @Author, @Nonfiction)";

                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@Quantity", QuantityTxtBox.Text);
                command.Parameters.AddWithValue("@Title", TitleTxtBox.Text);
                command.Parameters.AddWithValue("@Author", AuthorTxtBox.Text);
                command.Parameters.AddWithValue("@Nonfiction", GenreCmbBox.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("BOOK ADDED");
                connection.Close();
            }
            else if (InputGenre == "Academic") 
            {
                connection.Open();

                string query = "INSERT INTO [AdminTB] ([Quantity], [Title], [Author], [Academic]) VALUES (@Quantity, @Title , @Author, @Academic)";

                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@Quantity", QuantityTxtBox.Text);
                command.Parameters.AddWithValue("@Title", TitleTxtBox.Text);
                command.Parameters.AddWithValue("@Author", AuthorTxtBox.Text);
                command.Parameters.AddWithValue("@Academic", GenreCmbBox.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("BOOK ADDED");
                connection.Close();
            }
           
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entry entry = new Entry();
            entry.Show();
        }
    }
}
