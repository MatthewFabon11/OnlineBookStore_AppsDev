namespace OnlineBookStore
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            GenreCmbBox = new ComboBox();
            label11 = new Label();
            txt_deleteID = new TextBox();
            DeleteBookLbl = new Label();
            Logout = new Button();
            DeleteBttn = new Button();
            AddBttn = new Button();
            label6 = new Label();
            QuantityTxtBox = new TextBox();
            AuthorTxtBox = new TextBox();
            label3 = new Label();
            TitleTxtBox = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            bookview = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            txt_Price = new TextBox();
            txt_updateID = new TextBox();
            ID_label = new Label();
            btn_Edit = new Button();
            btn_UPDATE = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            User_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // GenreCmbBox
            // 
            GenreCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenreCmbBox.FormattingEnabled = true;
            GenreCmbBox.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Academic" });
            GenreCmbBox.Location = new Point(138, 488);
            GenreCmbBox.Margin = new Padding(3, 2, 3, 2);
            GenreCmbBox.Name = "GenreCmbBox";
            GenreCmbBox.Size = new Size(121, 23);
            GenreCmbBox.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Tan;
            label11.Font = new Font("Impact", 12F);
            label11.Location = new Point(77, 81);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 56;
            label11.Text = "BOOKS ADDED";
            // 
            // txt_deleteID
            // 
            txt_deleteID.Location = new Point(507, 394);
            txt_deleteID.Margin = new Padding(3, 2, 3, 2);
            txt_deleteID.Name = "txt_deleteID";
            txt_deleteID.Size = new Size(71, 23);
            txt_deleteID.TabIndex = 55;
            // 
            // DeleteBookLbl
            // 
            DeleteBookLbl.AutoSize = true;
            DeleteBookLbl.BackColor = Color.FromArgb(255, 128, 128);
            DeleteBookLbl.Font = new Font("Impact", 12F);
            DeleteBookLbl.Location = new Point(507, 366);
            DeleteBookLbl.Name = "DeleteBookLbl";
            DeleteBookLbl.Size = new Size(96, 20);
            DeleteBookLbl.TabIndex = 54;
            DeleteBookLbl.Text = "Delete A book";
            // 
            // Logout
            // 
            Logout.Font = new Font("Kristen ITC", 8F);
            Logout.Location = new Point(686, 587);
            Logout.Margin = new Padding(3, 2, 3, 2);
            Logout.Name = "Logout";
            Logout.Size = new Size(82, 25);
            Logout.TabIndex = 46;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += BackBttn_Click;
            // 
            // DeleteBttn
            // 
            DeleteBttn.BackColor = Color.Red;
            DeleteBttn.FlatStyle = FlatStyle.Flat;
            DeleteBttn.Location = new Point(502, 435);
            DeleteBttn.Margin = new Padding(3, 2, 3, 2);
            DeleteBttn.Name = "DeleteBttn";
            DeleteBttn.Size = new Size(82, 22);
            DeleteBttn.TabIndex = 45;
            DeleteBttn.Text = "Delete";
            DeleteBttn.UseVisualStyleBackColor = false;
            DeleteBttn.Click += DeleteBttn_Click;
            // 
            // AddBttn
            // 
            AddBttn.BackColor = Color.Lime;
            AddBttn.FlatStyle = FlatStyle.Flat;
            AddBttn.Location = new Point(131, 557);
            AddBttn.Margin = new Padding(3, 2, 3, 2);
            AddBttn.Name = "AddBttn";
            AddBttn.Size = new Size(82, 22);
            AddBttn.TabIndex = 43;
            AddBttn.Text = "Add";
            AddBttn.UseVisualStyleBackColor = false;
            AddBttn.Click += AddBttn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.Font = new Font("Kristen ITC", 8F);
            label6.Location = new Point(80, 488);
            label6.Name = "label6";
            label6.Size = new Size(40, 16);
            label6.TabIndex = 40;
            label6.Text = "Genre";
            // 
            // QuantityTxtBox
            // 
            QuantityTxtBox.Location = new Point(138, 457);
            QuantityTxtBox.Margin = new Padding(3, 2, 3, 2);
            QuantityTxtBox.Name = "QuantityTxtBox";
            QuantityTxtBox.Size = new Size(121, 23);
            QuantityTxtBox.TabIndex = 39;
            // 
            // AuthorTxtBox
            // 
            AuthorTxtBox.Location = new Point(138, 428);
            AuthorTxtBox.Margin = new Padding(3, 2, 3, 2);
            AuthorTxtBox.Name = "AuthorTxtBox";
            AuthorTxtBox.Size = new Size(121, 23);
            AuthorTxtBox.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.Font = new Font("Kristen ITC", 8F);
            label3.Location = new Point(78, 433);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 36;
            label3.Text = "Author";
            // 
            // TitleTxtBox
            // 
            TitleTxtBox.Location = new Point(138, 397);
            TitleTxtBox.Margin = new Padding(3, 2, 3, 2);
            TitleTxtBox.Name = "TitleTxtBox";
            TitleTxtBox.Size = new Size(121, 23);
            TitleTxtBox.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 255, 192);
            label5.Font = new Font("Kristen ITC", 8F);
            label5.Location = new Point(79, 404);
            label5.Name = "label5";
            label5.Size = new Size(32, 16);
            label5.TabIndex = 34;
            label5.Text = "Title";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 72);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 250);
            dataGridView1.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Font = new Font("Kristen ITC", 8F);
            label4.Location = new Point(79, 460);
            label4.Name = "label4";
            label4.Size = new Size(55, 16);
            label4.TabIndex = 38;
            label4.Text = "Quantity";
            // 
            // bookview
            // 
            bookview.BackgroundColor = Color.FromArgb(255, 224, 192);
            bookview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookview.Location = new Point(70, 106);
            bookview.Name = "bookview";
            bookview.Size = new Size(638, 193);
            bookview.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Impact", 12F);
            label1.Location = new Point(155, 338);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 59;
            label1.Text = "Add A book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Kristen ITC", 8F);
            label2.Location = new Point(483, 397);
            label2.Name = "label2";
            label2.Size = new Size(21, 16);
            label2.TabIndex = 61;
            label2.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 255, 192);
            label7.Font = new Font("Kristen ITC", 8F);
            label7.Location = new Point(80, 522);
            label7.Name = "label7";
            label7.Size = new Size(36, 16);
            label7.TabIndex = 62;
            label7.Text = "Price";
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(138, 519);
            txt_Price.Margin = new Padding(3, 2, 3, 2);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(64, 23);
            txt_Price.TabIndex = 63;
            // 
            // txt_updateID
            // 
            txt_updateID.Location = new Point(138, 368);
            txt_updateID.Margin = new Padding(3, 2, 3, 2);
            txt_updateID.Name = "txt_updateID";
            txt_updateID.Size = new Size(121, 23);
            txt_updateID.TabIndex = 64;
            txt_updateID.Visible = false;
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.BackColor = Color.FromArgb(192, 255, 192);
            ID_label.Font = new Font("Kristen ITC", 8F);
            ID_label.Location = new Point(80, 371);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(21, 16);
            ID_label.TabIndex = 65;
            ID_label.Text = "ID";
            ID_label.Visible = false;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(63, 557);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(57, 23);
            btn_Edit.TabIndex = 66;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_UPDATE
            // 
            btn_UPDATE.BackColor = Color.FromArgb(255, 192, 128);
            btn_UPDATE.FlatStyle = FlatStyle.Flat;
            btn_UPDATE.Location = new Point(219, 557);
            btn_UPDATE.Name = "btn_UPDATE";
            btn_UPDATE.Size = new Size(75, 23);
            btn_UPDATE.TabIndex = 67;
            btn_UPDATE.Text = "Update";
            btn_UPDATE.UseVisualStyleBackColor = false;
            btn_UPDATE.Visible = false;
            btn_UPDATE.Click += btn_UPDATE_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(255, 128, 128);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(470, 352);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(144, 150);
            dataGridView2.TabIndex = 68;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(192, 255, 192);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(54, 327);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(252, 267);
            dataGridView3.TabIndex = 69;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(483, 363);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 26);
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(130, 335);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 26);
            pictureBox2.TabIndex = 71;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1080, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 77;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(594, 7);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 78;
            pictureBox4.TabStop = false;
            // 
            // User_Label
            // 
            User_Label.AutoSize = true;
            User_Label.BackColor = Color.Tan;
            User_Label.Font = new Font("Kristen ITC", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User_Label.Location = new Point(632, 16);
            User_Label.Name = "User_Label";
            User_Label.Size = new Size(58, 16);
            User_Label.TabIndex = 84;
            User_Label.Text = "ADMIN";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(780, 623);
            Controls.Add(User_Label);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_UPDATE);
            Controls.Add(btn_Edit);
            Controls.Add(ID_label);
            Controls.Add(txt_updateID);
            Controls.Add(txt_Price);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(GenreCmbBox);
            Controls.Add(AddBttn);
            Controls.Add(label6);
            Controls.Add(QuantityTxtBox);
            Controls.Add(label4);
            Controls.Add(AuthorTxtBox);
            Controls.Add(label3);
            Controls.Add(TitleTxtBox);
            Controls.Add(label5);
            Controls.Add(dataGridView3);
            Controls.Add(DeleteBookLbl);
            Controls.Add(label2);
            Controls.Add(txt_deleteID);
            Controls.Add(DeleteBttn);
            Controls.Add(dataGridView2);
            Controls.Add(bookview);
            Controls.Add(label11);
            Controls.Add(Logout);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminPanel";
            Text = "Form1";
            Load += AdminPanel_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BackBttn_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox GenreCmbBox;
        private Label label11;
        private TextBox txt_deleteID;
        private Label DeleteBookLbl;
        private Button Logout;
        private Button DeleteBttn;
        private Button AddBttn;
        private Label label6;
        private TextBox QuantityTxtBox;
        private TextBox AuthorTxtBox;
        private Label label3;
        private TextBox TitleTxtBox;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label4;
        private DataGridView bookview;
        private Label label1;
        private Label label2;
        private Label label7;
        private TextBox txt_Price;
        private TextBox txt_updateID;
        private Label ID_label;
        private Button btn_Edit;
        private Button btn_UPDATE;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label User_Label;
    }
}
