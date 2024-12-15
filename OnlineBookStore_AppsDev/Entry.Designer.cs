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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Tan;
            Username.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(310, 98);
            Username.Name = "Username";
            Username.Size = new Size(94, 25);
            Username.TabIndex = 3;
            Username.Text = "Username";
            Username.Click += Username_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Tan;
            Password.Font = new Font("Impact", 12F);
            Password.Location = new Point(309, 158);
            Password.Name = "Password";
            Password.Size = new Size(90, 25);
            Password.TabIndex = 4;
            Password.Text = "Password";
            Password.Click += Password_Click;
            // 
            // UserText
            // 
            UserText.Cursor = Cursors.IBeam;
            UserText.Location = new Point(410, 96);
            UserText.Margin = new Padding(3, 4, 3, 4);
            UserText.Name = "UserText";
            UserText.Size = new Size(181, 27);
            UserText.TabIndex = 5;
            UserText.TextChanged += UserText_TextChanged;
            // 
            // PassText
            // 
            PassText.Cursor = Cursors.IBeam;
            PassText.Location = new Point(410, 155);
            PassText.Margin = new Padding(3, 4, 3, 4);
            PassText.Name = "PassText";
            PassText.Size = new Size(181, 27);
            PassText.TabIndex = 6;
            PassText.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            Login.FlatStyle = FlatStyle.Popup;
            Login.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(356, 221);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(198, 43);
            Login.TabIndex = 7;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += button_Login;
            // 
            // SignUp
            // 
            SignUp.FlatStyle = FlatStyle.Popup;
            SignUp.Font = new Font("Impact", 10F);
            SignUp.Location = new Point(356, 292);
            SignUp.Margin = new Padding(3, 4, 3, 4);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(198, 44);
            SignUp.TabIndex = 8;
            SignUp.Text = "Sign up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Location = new Point(443, 268);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 10;
            label1.Text = "or";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(321, 282);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(628, 380);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(8, 64);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = OnlineBookStore_AppsDev.Properties.Resources._21;
            pictureBox2.Location = new Point(-221, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1080, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = OnlineBookStore_AppsDev.Properties.Resources.books_entry4;
            pictureBox1.Location = new Point(12, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 309);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Entry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = OnlineBookStore_AppsDev.Properties.Resources.background;
            ClientSize = new Size(626, 412);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(Login);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(SignUp);
            Controls.Add(PassText);
            Controls.Add(UserText);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Entry";
            StartPosition = FormStartPosition.Manual;
            Text = "Login";
            Load += Entry_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
