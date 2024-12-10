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


namespace OnlineBookStore
{
    public partial class UserMenu : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public UserMenu()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kuya\OneDrive\Desktop\v1\BOOK UP v1\Database.accdb;Persist Security Info=False;";

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
                string query = "";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    listbooksAVB.Items.Add(reader["Title"]);
                }
                MessageBox.Show("Book Updated");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                connection.Close();

            }
        }
    }
}
