namespace OnlineBookStore
{
    partial class SignUpMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            back3 = new Button();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            txt_Password2 = new TextBox();
            Submit = new Button();
            txt_Number = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // back3
            // 
            back3.BackColor = Color.Transparent;
            back3.Image = OnlineBookStore_AppsDev.Properties.Resources.back2;
            back3.Location = new Point(543, 354);
            back3.Margin = new Padding(3, 4, 3, 4);
            back3.Name = "back3";
            back3.Size = new Size(52, 38);
            back3.TabIndex = 0;
            back3.TextAlign = ContentAlignment.BottomLeft;
            back3.UseVisualStyleBackColor = false;
            back3.Click += back3_Click;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(341, 111);
            txt_Username.Margin = new Padding(3, 4, 3, 4);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "Username";
            txt_Username.Size = new Size(206, 27);
            txt_Username.TabIndex = 3;
            txt_Username.Tag = "";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(341, 150);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "Password";
            txt_Password.Size = new Size(206, 27);
            txt_Password.TabIndex = 4;
            txt_Password.Tag = "";
            // 
            // txt_Password2
            // 
            txt_Password2.Location = new Point(341, 188);
            txt_Password2.Margin = new Padding(3, 4, 3, 4);
            txt_Password2.Name = "txt_Password2";
            txt_Password2.PlaceholderText = "Repeat Password";
            txt_Password2.Size = new Size(206, 27);
            txt_Password2.TabIndex = 5;
            txt_Password2.Tag = "";
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ButtonHighlight;
            Submit.FlatStyle = FlatStyle.Popup;
            Submit.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Submit.Location = new Point(372, 274);
            Submit.Margin = new Padding(3, 4, 3, 4);
            Submit.Name = "Submit";
            Submit.Size = new Size(147, 53);
            Submit.TabIndex = 7;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // txt_Number
            // 
            txt_Number.Location = new Point(341, 227);
            txt_Number.Margin = new Padding(3, 4, 3, 4);
            txt_Number.Name = "txt_Number";
            txt_Number.PlaceholderText = "Phone Number";
            txt_Number.Size = new Size(206, 27);
            txt_Number.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = OnlineBookStore_AppsDev.Properties.Resources.books_entry5;
            pictureBox1.Location = new Point(12, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 298);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(305, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(290, 273);
            dataGridView1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = OnlineBookStore_AppsDev.Properties.Resources._21;
            pictureBox2.Location = new Point(-222, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1080, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // SignUpMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = OnlineBookStore_AppsDev.Properties.Resources.background;
            ClientSize = new Size(627, 416);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txt_Number);
            Controls.Add(Submit);
            Controls.Add(txt_Password2);
            Controls.Add(txt_Username);
            Controls.Add(txt_Password);
            Controls.Add(back3);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpMenu";
            Text = "SignUpMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back3;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private TextBox txt_Password2;
        private Button Submit;
        private TextBox txt_Number;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
    }
}