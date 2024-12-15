namespace OnlineBookStore
{
    partial class Entry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            Password = new Label();
            UserText = new TextBox();
            PassText = new TextBox();
            Login = new Button();
            SignUp = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(84, 88);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(83, 148);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // UserText
            // 
            UserText.Location = new Point(164, 91);
            UserText.Margin = new Padding(3, 4, 3, 4);
            UserText.Name = "UserText";
            UserText.Size = new Size(219, 27);
            UserText.TabIndex = 5;
            UserText.TextChanged += UserText_TextChanged;
            // 
            // PassText
            // 
            PassText.Location = new Point(164, 142);
            PassText.Margin = new Padding(3, 4, 3, 4);
            PassText.Name = "PassText";
            PassText.Size = new Size(219, 27);
            PassText.TabIndex = 6;
            PassText.TextChanged += PassText_TextChanged;
            // 
            // Login
            // 
            Login.Location = new Point(214, 198);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(86, 31);
            Login.TabIndex = 7;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += button_Login;
            // 
            // SignUp
            // 
            SignUp.Location = new Point(214, 253);
            SignUp.Margin = new Padding(3, 4, 3, 4);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(86, 31);
            SignUp.TabIndex = 8;
            SignUp.Text = "Sign up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // Entry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 403);
            Controls.Add(SignUp);
            Controls.Add(Login);
            Controls.Add(PassText);
            Controls.Add(UserText);
            Controls.Add(Password);
            Controls.Add(Username);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Entry";
            Text = "Entry";
            Load += Entry_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Username;
        private Label Password;
        private TextBox UserText;
        private TextBox PassText;
        private Button Login;
        private Button SignUp;
    }
}
