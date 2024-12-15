using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using OnlineBookStore_AppsDev;


namespace OnlineBookStore
{
    public partial class UserMenu : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public UserMenu()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kuya\OneDrive\Desktop\v1.1\Database.accdb;Persist Security Info=False;";

        }

        private void back2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entry entry = new Entry();
            entry.Show();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Title  From AdminTB";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listbooksAVB.Items.Add(reader["Title"].ToString());
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                connection.Close();

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBookTitle.Text))
            {
                MessageBox.Show("Please enter Valid Information");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM AdminTB WHERE Title = @BookTitle";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("Title", textBoxBookTitle.Text);


                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable bookDetails = new DataTable();
                    adapter.Fill(bookDetails);

                    if (bookDetails.Rows.Count > 0)
                    {
                        listBoxFoundBook.Items.Clear(); // Clear any existing items
                        DataRow row = bookDetails.Rows[0];


                        foreach (DataColumn column in bookDetails.Columns)
                        {
                            listBoxFoundBook.Items.Add($"{column.ColumnName}: {row[column.ColumnName]}");
                        }

                        dataGridViewBookDetail.DataSource = bookDetails;
                        MessageBox.Show("Book found and added to the list.");

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Book found with the given title");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);

                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxBookTitle.Clear();
            listBoxFoundBook.Items.Clear();
            dataGridViewBookDetail.DataSource = null;
        }

        private void buttonAddToWishlist_Click(object sender, EventArgs e)
        {
            this.Hide();

            WishList wishList = new WishList();

            wishList.Show();


        }

        private void listbooksAVB_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from AdminTB where Title = '" + listbooksAVB.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Title_Label.Text = reader["Title"].ToString();
                    Price_Label.Text = reader["Price"].ToString();
                    Author_Label.Text = reader["Author"].ToString();

                    if (Title_Label.Text == "red")
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                    }
                    else if (Title_Label.Text == "yello")
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                    }
                    else if (Title_Label.Text == "pink")
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = false;
                    }
                    else if (Title_Label.Text == "blue")
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = true;
                    }



                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);

            }

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bookTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Title_Label_Click(object sender, EventArgs e)
        {

        }

        private void Author_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
