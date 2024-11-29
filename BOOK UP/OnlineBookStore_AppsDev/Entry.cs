namespace OnlineBookStore
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }
        private void button_Login(object sender, EventArgs e)
        {
                string Type = TypeText.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(Type))
            {
                MessageBox.Show("put a type");
            }
            else
            {

                switch (Type)
                {
                    case "User":
                        this.Hide();
                        UserMenu userMenu = new UserMenu();
                        userMenu.Show();
                        break;

                    case "Admin":
                        string username = UserText.Text;
                        string password = PassText.Text;

                        if (string.IsNullOrEmpty(username) ||
                           string.IsNullOrEmpty(password))
                        {
                            MessageBox.Show("put something");
                            break;
                        }

                        if (username == "qqq" || password == "rrr")
                        {
                            this.Hide();
                            AdminPanel adminPanel = new AdminPanel();
                            adminPanel.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                        break;

                    default:
                        return;
                }
            }

        }

        private void SignUp_Click(object sender, EventArgs e)
        { 
            this.Hide();
            SignUpMenu signUpMenu = new SignUpMenu();   
            signUpMenu.Show();
        }
    }
}
