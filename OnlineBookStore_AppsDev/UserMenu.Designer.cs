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
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // back2
            // 
            back2.Location = new Point(14, 553);
            back2.Margin = new Padding(3, 4, 3, 4);
            back2.Name = "back2";
            back2.Size = new Size(86, 31);
            back2.TabIndex = 1;
            back2.Text = "back";
            back2.UseVisualStyleBackColor = true;
            back2.Click += back2_Click;
            // 
            // listbooksAVB
            // 
            listbooksAVB.FormattingEnabled = true;
            listbooksAVB.Location = new Point(14, 56);
            listbooksAVB.Margin = new Padding(3, 4, 3, 4);
            listbooksAVB.Name = "listbooksAVB";
            listbooksAVB.Size = new Size(329, 164);
            listbooksAVB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(188, 28);
            label1.TabIndex = 3;
            label1.Text = "BOOKS AVAILABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(590, 5);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 4;
            label2.Text = "BOOK DETAIL";
            // 
            // dataGridViewBookDetail
            // 
            dataGridViewBookDetail.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewBookDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookDetail.Location = new Point(482, 37);
            dataGridViewBookDetail.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBookDetail.Name = "dataGridViewBookDetail";
            dataGridViewBookDetail.RowHeadersWidth = 51;
            dataGridViewBookDetail.Size = new Size(361, 200);
            dataGridViewBookDetail.TabIndex = 10;
            dataGridViewBookDetail.CellContentClick += dataGridViewBookDetail_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(570, 262);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 11;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(14, 301);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(855, 216);
            dataGridView2.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(73, 316);
            label8.Name = "label8";
            label8.Size = new Size(121, 28);
            label8.TabIndex = 15;
            label8.Text = "FIND BOOK";
            // 
            // textBoxBookTitle
            // 
            textBoxBookTitle.Location = new Point(73, 430);
            textBoxBookTitle.Name = "textBoxBookTitle";
            textBoxBookTitle.Size = new Size(187, 27);
            textBoxBookTitle.TabIndex = 16;
            textBoxBookTitle.TextChanged += textBoxBookTitle_TextChanged;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Location = new Point(73, 395);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(114, 20);
            bookTitle.TabIndex = 17;
            bookTitle.Text = "Enter Book Title";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(73, 477);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(91, 29);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxFoundBook
            // 
            listBoxFoundBook.FormattingEnabled = true;
            listBoxFoundBook.Location = new Point(482, 316);
            listBoxFoundBook.Name = "listBoxFoundBook";
            listBoxFoundBook.Size = new Size(361, 184);
            listBoxFoundBook.TabIndex = 19;
            listBoxFoundBook.SelectedIndexChanged += listBoxFoundBook_SelectedIndexChanged;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(170, 477);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(91, 29);
            buttonClear.TabIndex = 20;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAddToWishlist
            // 
            buttonAddToWishlist.BackColor = Color.FromArgb(255, 192, 128);
            buttonAddToWishlist.FlatStyle = FlatStyle.Flat;
            buttonAddToWishlist.Location = new Point(688, 262);
            buttonAddToWishlist.Margin = new Padding(3, 4, 3, 4);
            buttonAddToWishlist.Name = "buttonAddToWishlist";
            buttonAddToWishlist.Size = new Size(155, 31);
            buttonAddToWishlist.TabIndex = 21;
            buttonAddToWishlist.Text = "Add to wishlist";
            buttonAddToWishlist.UseVisualStyleBackColor = false;
            buttonAddToWishlist.Click += buttonAddToWishlist_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(914, 617);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserMenu";
            Text = "UserMenu";
            Load += UserMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
    }
}