﻿namespace OnlineBookStore
{
    partial class UserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            back2 = new Button();
            listbooksAVB = new ListBox();
            label1 = new Label();
            label2 = new Label();
            dataGridViewBookDetail = new DataGridView();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            textBoxBookTitle = new TextBox();
            bookTitle = new Label();
            buttonSearch = new Button();
            listBoxFoundBook = new ListBox();
            buttonClear = new Button();
            buttonAddToWishlist = new Button();
            pictureBox1 = new PictureBox();
            Title_Label = new Label();
            Price_Label = new Label();
            Author_Label = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // back2
            // 
            back2.Image = OnlineBookStore_AppsDev.Properties.Resources.back2;
            back2.Location = new Point(36, 539);
            back2.Margin = new Padding(3, 4, 3, 4);
            back2.Name = "back2";
            back2.Size = new Size(74, 45);
            back2.TabIndex = 1;
            back2.UseVisualStyleBackColor = true;
            back2.Click += back2_Click;
            // 
            // listbooksAVB
            // 
            listbooksAVB.FormattingEnabled = true;
            listbooksAVB.Location = new Point(35, 108);
            listbooksAVB.Margin = new Padding(3, 4, 3, 4);
            listbooksAVB.Name = "listbooksAVB";
            listbooksAVB.Size = new Size(329, 164);
            listbooksAVB.TabIndex = 2;
            listbooksAVB.SelectedIndexChanged += listbooksAVB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BurlyWood;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 67);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 3;
            label1.Text = "BOOKS IN STORE";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BurlyWood;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(621, 67);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 4;
            label2.Text = "BOOK DETAIL";
            // 
            // dataGridViewBookDetail
            // 
            dataGridViewBookDetail.BackgroundColor = Color.Tan;
            dataGridViewBookDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookDetail.Location = new Point(621, 121);
            dataGridViewBookDetail.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBookDetail.Name = "dataGridViewBookDetail";
            dataGridViewBookDetail.RowHeadersWidth = 51;
            dataGridViewBookDetail.Size = new Size(260, 389);
            dataGridViewBookDetail.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = OnlineBookStore_AppsDev.Properties.Resources.addcart;
            button1.Location = new Point(623, 529);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(124, 55);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.BurlyWood;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(36, 290);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(518, 216);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.BurlyWood;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(53, 301);
            label8.Name = "label8";
            label8.Size = new Size(121, 28);
            label8.TabIndex = 15;
            label8.Text = "FIND BOOK";
            label8.Click += label8_Click;
            // 
            // textBoxBookTitle
            // 
            textBoxBookTitle.Location = new Point(53, 397);
            textBoxBookTitle.Name = "textBoxBookTitle";
            textBoxBookTitle.Size = new Size(153, 27);
            textBoxBookTitle.TabIndex = 16;
            textBoxBookTitle.TextChanged += textBoxBookTitle_TextChanged;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.BackColor = Color.BurlyWood;
            bookTitle.ForeColor = Color.Black;
            bookTitle.Location = new Point(53, 361);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(114, 20);
            bookTitle.TabIndex = 17;
            bookTitle.Text = "Enter Book Title";
            bookTitle.Click += bookTitle_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.Image = OnlineBookStore_AppsDev.Properties.Resources.search;
            buttonSearch.Location = new Point(53, 450);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(79, 41);
            buttonSearch.TabIndex = 18;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxFoundBook
            // 
            listBoxFoundBook.FormattingEnabled = true;
            listBoxFoundBook.Location = new Point(214, 306);
            listBoxFoundBook.Name = "listBoxFoundBook";
            listBoxFoundBook.Size = new Size(326, 184);
            listBoxFoundBook.TabIndex = 19;
            // 
            // buttonClear
            // 
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.ForeColor = Color.Black;
            buttonClear.Image = OnlineBookStore_AppsDev.Properties.Resources.clear;
            buttonClear.Location = new Point(138, 450);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(70, 41);
            buttonClear.TabIndex = 20;
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAddToWishlist
            // 
            buttonAddToWishlist.BackColor = Color.FromArgb(255, 192, 128);
            buttonAddToWishlist.FlatStyle = FlatStyle.Flat;
            buttonAddToWishlist.Image = OnlineBookStore_AppsDev.Properties.Resources.wishlist;
            buttonAddToWishlist.Location = new Point(753, 529);
            buttonAddToWishlist.Margin = new Padding(3, 4, 3, 4);
            buttonAddToWishlist.Name = "buttonAddToWishlist";
            buttonAddToWishlist.Size = new Size(128, 55);
            buttonAddToWishlist.TabIndex = 21;
            buttonAddToWishlist.UseVisualStyleBackColor = false;
            buttonAddToWishlist.Click += buttonAddToWishlist_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = OnlineBookStore_AppsDev.Properties.Resources.book;
            pictureBox1.Location = new Point(686, 154);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Title_Label
            // 
            Title_Label.AutoSize = true;
            Title_Label.ForeColor = Color.Black;
            Title_Label.Location = new Point(733, 423);
            Title_Label.Name = "Title_Label";
            Title_Label.Size = new Size(38, 20);
            Title_Label.TabIndex = 23;
            Title_Label.Text = "Title";
            Title_Label.Click += Title_Label_Click;
            // 
            // Price_Label
            // 
            Price_Label.AutoSize = true;
            Price_Label.ForeColor = Color.Black;
            Price_Label.Location = new Point(788, 461);
            Price_Label.Name = "Price_Label";
            Price_Label.Size = new Size(41, 20);
            Price_Label.TabIndex = 25;
            Price_Label.Text = "Price";
            // 
            // Author_Label
            // 
            Author_Label.AutoSize = true;
            Author_Label.ForeColor = Color.Black;
            Author_Label.Location = new Point(655, 461);
            Author_Label.Name = "Author_Label";
            Author_Label.Size = new Size(54, 20);
            Author_Label.TabIndex = 26;
            Author_Label.Text = "Author";
            Author_Label.Click += Author_Label_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(686, 154);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 251);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(686, 154);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 251);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(686, 154);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(133, 251);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = OnlineBookStore_AppsDev.Properties.Resources._11;
            pictureBox5.Location = new Point(-1, -2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1080, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 77;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = OnlineBookStore_AppsDev.Properties.Resources.user1;
            pictureBox6.Location = new Point(870, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 78;
            pictureBox6.TabStop = false;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = OnlineBookStore_AppsDev.Properties.Resources.background;
            ClientSize = new Size(914, 646);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Author_Label);
            Controls.Add(Price_Label);
            Controls.Add(Title_Label);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAddToWishlist);
            Controls.Add(buttonClear);
            Controls.Add(listBoxFoundBook);
            Controls.Add(buttonSearch);
            Controls.Add(bookTitle);
            Controls.Add(textBoxBookTitle);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listbooksAVB);
            Controls.Add(back2);
            Controls.Add(label2);
            Controls.Add(dataGridViewBookDetail);
            ForeColor = Color.Cornsilk;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserMenu";
            Text = "UserMenu";
            Load += UserMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button back2;
        private ListBox listbooksAVB;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewBookDetail;
        private Button button1;
        private DataGridView dataGridView2;
        private Label label8;
        private TextBox textBoxBookTitle;
        private Label bookTitle;
        private Button buttonSearch;
        private ListBox listBoxFoundBook;
        private Button buttonClear;
        private Button buttonAddToWishlist;
        private PictureBox pictureBox1;
        private Label Title_Label;
        private Label Price_Label;
        private Label Author_Label;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}