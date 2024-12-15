using OnlineBookStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore_AppsDev
{
    public partial class WishList : Form
    {
        private string loggedInUser;

        private OleDbConnection connection = new OleDbConnection();

        public WishList(string username)
        {
            InitializeComponent();
            loggedInUser = username;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            UserMenu userMenu = new UserMenu(loggedInUser);
            userMenu.Show();
        }
    }
}
