namespace OnlineBookStore
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // back2
            // 
            back2.Location = new Point(18, 404);
            back2.Name = "back2";
            back2.Size = new Size(75, 23);
            back2.TabIndex = 1;
            back2.Text = "back";
            back2.UseVisualStyleBackColor = true;
            back2.Click += back2_Click;
            // 
            // listbooksAVB
            // 
            listbooksAVB.FormattingEnabled = true;
            listbooksAVB.ItemHeight = 15;
            listbooksAVB.Location = new Point(12, 42);
            listbooksAVB.Name = "listbooksAVB";
            listbooksAVB.Size = new Size(288, 124);
            listbooksAVB.TabIndex = 2;
            listbooksAVB.SelectedIndexChanged += listbooksAVB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 3;
            label1.Text = "BOOKS AVAILABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(516, 4);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 4;
            label2.Text = "BOOK DETAIL";
            // 
            // dataGridViewBookDetail
            // 
            dataGridViewBookDetail.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewBookDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookDetail.Location = new Point(499, 28);
            dataGridViewBookDetail.Name = "dataGridViewBookDetail";
            dataGridViewBookDetail.RowHeadersWidth = 51;
            dataGridViewBookDetail.Size = new Size(239, 292);
            dataGridViewBookDetail.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(499, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 180);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(453, 162);
            dataGridView2.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 188);
            label8.Name = "label8";
            label8.Size = new Size(96, 21);
            label8.TabIndex = 15;
            label8.Text = "FIND BOOK";
            // 
            // textBoxBookTitle
            // 
            textBoxBookTitle.Location = new Point(28, 273);
            textBoxBookTitle.Margin = new Padding(3, 2, 3, 2);
            textBoxBookTitle.Name = "textBoxBookTitle";
            textBoxBookTitle.Size = new Size(134, 23);
            textBoxBookTitle.TabIndex = 16;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Location = new Point(28, 247);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(89, 15);
            bookTitle.TabIndex = 17;
            bookTitle.Text = "Enter Book Title";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(28, 309);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(50, 22);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxFoundBook
            // 
            listBoxFoundBook.FormattingEnabled = true;
            listBoxFoundBook.ItemHeight = 15;
            listBoxFoundBook.Location = new Point(169, 192);
            listBoxFoundBook.Margin = new Padding(3, 2, 3, 2);
            listBoxFoundBook.Name = "listBoxFoundBook";
            listBoxFoundBook.Size = new Size(286, 139);
            listBoxFoundBook.TabIndex = 19;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(113, 309);
            buttonClear.Margin = new Padding(3, 2, 3, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(50, 22);
            buttonClear.TabIndex = 20;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAddToWishlist
            // 
            buttonAddToWishlist.BackColor = Color.FromArgb(255, 192, 128);
            buttonAddToWishlist.FlatStyle = FlatStyle.Flat;
            buttonAddToWishlist.Location = new Point(602, 326);
            buttonAddToWishlist.Name = "buttonAddToWishlist";
            buttonAddToWishlist.Size = new Size(136, 23);
            buttonAddToWishlist.TabIndex = 21;
            buttonAddToWishlist.Text = "Add to wishlist";
            buttonAddToWishlist.UseVisualStyleBackColor = false;
            buttonAddToWishlist.Click += buttonAddToWishlist_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = OnlineBookStore_AppsDev.Properties.Resources.book;
            pictureBox1.Location = new Point(566, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Title_Label
            // 
            Title_Label.AutoSize = true;
            Title_Label.Location = new Point(613, 247);
            Title_Label.Name = "Title_Label";
            Title_Label.Size = new Size(29, 15);
            Title_Label.TabIndex = 23;
            Title_Label.Text = "Title";
            // 
            // Price_Label
            // 
            Price_Label.AutoSize = true;
            Price_Label.Location = new Point(672, 281);
            Price_Label.Name = "Price_Label";
            Price_Label.Size = new Size(33, 15);
            Price_Label.TabIndex = 25;
            Price_Label.Text = "Price";
            // 
            // Author_Label
            // 
            Author_Label.AutoSize = true;
            Author_Label.Location = new Point(532, 278);
            Author_Label.Name = "Author_Label";
            Author_Label.Size = new Size(44, 15);
            Author_Label.TabIndex = 26;
            Author_Label.Text = "Author";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(566, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(566, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 188);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(566, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 188);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 432);
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
            Name = "UserMenu";
            Text = "UserMenu";
            Load += UserMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
    }
}