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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            Username = new Label();
            Password = new Label();
            UserText = new TextBox();
            PassText = new TextBox();
            Login = new Button();
            SignUp = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Tan;
            Username.Font = new Font("Impact", 12F);
            Username.Location = new Point(288, 116);
            Username.Name = "Username";
            Username.Size = new Size(76, 20);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Tan;
            Password.Font = new Font("Impact", 12F);
            Password.Location = new Point(288, 156);
            Password.Name = "Password";
            Password.Size = new Size(73, 20);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // UserText
            // 
            UserText.Location = new Point(370, 118);
            UserText.Name = "UserText";
            UserText.Size = new Size(157, 23);
            UserText.TabIndex = 5;
            // 
            // PassText
            // 
            PassText.Location = new Point(370, 158);
            PassText.Name = "PassText";
            PassText.Size = new Size(157, 23);
            PassText.TabIndex = 6;
            PassText.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            Login.BackColor = SystemColors.ButtonFace;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Impact", 12F);
            Login.Location = new Point(324, 194);
            Login.Name = "Login";
            Login.Size = new Size(182, 30);
            Login.TabIndex = 7;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += button_Login;
            // 
            // SignUp
            // 
            SignUp.FlatStyle = FlatStyle.Flat;
            SignUp.Font = new Font("Impact", 12F);
            SignUp.Location = new Point(324, 243);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(182, 31);
            SignUp.TabIndex = 8;
            SignUp.Text = "Sign up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 75);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(265, 212);
            dataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Kristen ITC", 8F);
            label1.Location = new Point(404, 225);
            label1.Name = "label1";
            label1.Size = new Size(19, 16);
            label1.TabIndex = 13;
            label1.Text = "or";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 60);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 232);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-60, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1080, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // Entry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(569, 345);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(SignUp);
            Controls.Add(Login);
            Controls.Add(PassText);
            Controls.Add(UserText);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Entry";
            Text = "Entry";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
