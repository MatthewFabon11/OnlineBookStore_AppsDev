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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpMenu));
            back3 = new Button();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            txt_Password2 = new TextBox();
            Submit = new Button();
            txt_Number = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // back3
            // 
            back3.Font = new Font("Kristen ITC", 8F);
            back3.Location = new Point(101, 302);
            back3.Name = "back3";
            back3.Size = new Size(75, 23);
            back3.TabIndex = 0;
            back3.Text = "back";
            back3.UseVisualStyleBackColor = true;
            back3.Click += back3_Click;
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Kristen ITC", 8F);
            txt_Username.Location = new Point(335, 87);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "Username";
            txt_Username.Size = new Size(181, 22);
            txt_Username.TabIndex = 3;
            txt_Username.Tag = "";
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Kristen ITC", 8F);
            txt_Password.Location = new Point(335, 116);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "Password";
            txt_Password.Size = new Size(181, 22);
            txt_Password.TabIndex = 4;
            txt_Password.Tag = "";
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Password2
            // 
            txt_Password2.Font = new Font("Kristen ITC", 8F);
            txt_Password2.Location = new Point(335, 145);
            txt_Password2.Name = "txt_Password2";
            txt_Password2.PlaceholderText = "Repeat Password";
            txt_Password2.Size = new Size(181, 22);
            txt_Password2.TabIndex = 5;
            txt_Password2.Tag = "";
            txt_Password2.UseSystemPasswordChar = true;
            // 
            // Submit
            // 
            Submit.FlatStyle = FlatStyle.Flat;
            Submit.Font = new Font("Impact", 12F);
            Submit.Location = new Point(375, 212);
            Submit.Name = "Submit";
            Submit.Size = new Size(97, 33);
            Submit.TabIndex = 7;
            Submit.Text = "submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // txt_Number
            // 
            txt_Number.Font = new Font("Kristen ITC", 8F);
            txt_Number.Location = new Point(335, 174);
            txt_Number.Name = "txt_Number";
            txt_Number.PlaceholderText = "phone number";
            txt_Number.Size = new Size(181, 22);
            txt_Number.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 39);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 232);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 61);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(236, 200);
            dataGridView1.TabIndex = 16;
            // 
            // SignUpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(570, 345);
            Controls.Add(txt_Number);
            Controls.Add(Submit);
            Controls.Add(txt_Password2);
            Controls.Add(txt_Username);
            Controls.Add(txt_Password);
            Controls.Add(back3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "SignUpMenu";
            Text = "SignUpMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}