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
            GenreCmbBox = new ComboBox();
            label11 = new Label();
            DeleteTxtBox = new TextBox();
            DeleteBookLbl = new Label();
            AcadCmbBox = new ComboBox();
            AcademicsLbl = new Label();
            NonFictionCmbBox = new ComboBox();
            NonFinctionLbl = new Label();
            FictionCmbBox = new ComboBox();
            FictionLbl = new Label();
            NextBttn = new Button();
            BackBttn = new Button();
            DeleteBttn = new Button();
            UpdateBttn = new Button();
            AddBttn = new Button();
            PublishTxtBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            ISBNTxtBox = new TextBox();
            label4 = new Label();
            AuthorTxtBox = new TextBox();
            label3 = new Label();
            TitleTxtBox = new TextBox();
            label5 = new Label();
            AdminLbl = new Label();
            dataGridView1 = new DataGridView();
            bookList = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GenreCmbBox
            // 
            GenreCmbBox.FormattingEnabled = true;
            GenreCmbBox.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Academic" });
            GenreCmbBox.Location = new Point(103, 224);
            GenreCmbBox.Margin = new Padding(3, 2, 3, 2);
            GenreCmbBox.Name = "GenreCmbBox";
            GenreCmbBox.Size = new Size(274, 23);
            GenreCmbBox.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 314);
            label11.Name = "label11";
            label11.Size = new Size(86, 15);
            label11.TabIndex = 56;
            label11.Text = "BOOKS ADDED";
            // 
            // DeleteTxtBox
            // 
            DeleteTxtBox.Location = new Point(518, 299);
            DeleteTxtBox.Margin = new Padding(3, 2, 3, 2);
            DeleteTxtBox.Name = "DeleteTxtBox";
            DeleteTxtBox.Size = new Size(178, 23);
            DeleteTxtBox.TabIndex = 55;
            // 
            // DeleteBookLbl
            // 
            DeleteBookLbl.AutoSize = true;
            DeleteBookLbl.Location = new Point(423, 302);
            DeleteBookLbl.Name = "DeleteBookLbl";
            DeleteBookLbl.Size = new Size(81, 15);
            DeleteBookLbl.TabIndex = 54;
            DeleteBookLbl.Text = "Delete A book";
            // 
            // AcadCmbBox
            // 
            AcadCmbBox.FormattingEnabled = true;
            AcadCmbBox.Location = new Point(423, 256);
            AcadCmbBox.Margin = new Padding(3, 2, 3, 2);
            AcadCmbBox.Name = "AcadCmbBox";
            AcadCmbBox.Size = new Size(274, 23);
            AcadCmbBox.TabIndex = 52;
            // 
            // AcademicsLbl
            // 
            AcademicsLbl.AutoSize = true;
            AcademicsLbl.Location = new Point(423, 230);
            AcademicsLbl.Name = "AcademicsLbl";
            AcademicsLbl.Size = new Size(65, 15);
            AcademicsLbl.TabIndex = 51;
            AcademicsLbl.Text = "Academics";
            // 
            // NonFictionCmbBox
            // 
            NonFictionCmbBox.FormattingEnabled = true;
            NonFictionCmbBox.Location = new Point(423, 181);
            NonFictionCmbBox.Margin = new Padding(3, 2, 3, 2);
            NonFictionCmbBox.Name = "NonFictionCmbBox";
            NonFictionCmbBox.Size = new Size(274, 23);
            NonFictionCmbBox.TabIndex = 50;
            // 
            // NonFinctionLbl
            // 
            NonFinctionLbl.AutoSize = true;
            NonFinctionLbl.Location = new Point(423, 155);
            NonFinctionLbl.Name = "NonFinctionLbl";
            NonFinctionLbl.Size = new Size(71, 15);
            NonFinctionLbl.TabIndex = 49;
            NonFinctionLbl.Text = "Non-Fiction";
            // 
            // FictionCmbBox
            // 
            FictionCmbBox.FormattingEnabled = true;
            FictionCmbBox.Location = new Point(423, 110);
            FictionCmbBox.Margin = new Padding(3, 2, 3, 2);
            FictionCmbBox.Name = "FictionCmbBox";
            FictionCmbBox.Size = new Size(274, 23);
            FictionCmbBox.TabIndex = 48;
            // 
            // FictionLbl
            // 
            FictionLbl.AutoSize = true;
            FictionLbl.Location = new Point(423, 82);
            FictionLbl.Name = "FictionLbl";
            FictionLbl.Size = new Size(43, 15);
            FictionLbl.TabIndex = 32;
            FictionLbl.Text = "Fiction";
            // 
            // NextBttn
            // 
            NextBttn.Location = new Point(659, 454);
            NextBttn.Margin = new Padding(3, 2, 3, 2);
            NextBttn.Name = "NextBttn";
            NextBttn.Size = new Size(82, 22);
            NextBttn.TabIndex = 47;
            NextBttn.Text = "Next";
            NextBttn.UseVisualStyleBackColor = true;
            // 
            // BackBttn
            // 
            BackBttn.Location = new Point(560, 454);
            BackBttn.Margin = new Padding(3, 2, 3, 2);
            BackBttn.Name = "BackBttn";
            BackBttn.Size = new Size(82, 22);
            BackBttn.TabIndex = 46;
            BackBttn.Text = "Back";
            BackBttn.UseVisualStyleBackColor = true;
            BackBttn.Click += BackBttn_Click;
            // 
            // DeleteBttn
            // 
            DeleteBttn.Location = new Point(624, 340);
            DeleteBttn.Margin = new Padding(3, 2, 3, 2);
            DeleteBttn.Name = "DeleteBttn";
            DeleteBttn.Size = new Size(82, 22);
            DeleteBttn.TabIndex = 45;
            DeleteBttn.Text = "Delete";
            DeleteBttn.UseVisualStyleBackColor = true;
            // 
            // UpdateBttn
            // 
            UpdateBttn.Location = new Point(527, 340);
            UpdateBttn.Margin = new Padding(3, 2, 3, 2);
            UpdateBttn.Name = "UpdateBttn";
            UpdateBttn.Size = new Size(82, 22);
            UpdateBttn.TabIndex = 44;
            UpdateBttn.Text = "Update";
            UpdateBttn.UseVisualStyleBackColor = true;
            // 
            // AddBttn
            // 
            AddBttn.Location = new Point(423, 340);
            AddBttn.Margin = new Padding(3, 2, 3, 2);
            AddBttn.Name = "AddBttn";
            AddBttn.Size = new Size(82, 22);
            AddBttn.TabIndex = 43;
            AddBttn.Text = "Add";
            AddBttn.UseVisualStyleBackColor = true;
            AddBttn.Click += AddBttn_Click;
            // 
            // PublishTxtBox
            // 
            PublishTxtBox.Location = new Point(160, 270);
            PublishTxtBox.Margin = new Padding(3, 2, 3, 2);
            PublishTxtBox.Name = "PublishTxtBox";
            PublishTxtBox.Size = new Size(217, 23);
            PublishTxtBox.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 272);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 41;
            label7.Text = "Publication Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 230);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 40;
            label6.Text = "Genre";
            // 
            // ISBNTxtBox
            // 
            ISBNTxtBox.Location = new Point(103, 182);
            ISBNTxtBox.Margin = new Padding(3, 2, 3, 2);
            ISBNTxtBox.Name = "ISBNTxtBox";
            ISBNTxtBox.Size = new Size(274, 23);
            ISBNTxtBox.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 187);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 38;
            label4.Text = "ISBN";
            // 
            // AuthorTxtBox
            // 
            AuthorTxtBox.Location = new Point(103, 132);
            AuthorTxtBox.Margin = new Padding(3, 2, 3, 2);
            AuthorTxtBox.Name = "AuthorTxtBox";
            AuthorTxtBox.Size = new Size(274, 23);
            AuthorTxtBox.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 134);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 36;
            label3.Text = "Author";
            // 
            // TitleTxtBox
            // 
            TitleTxtBox.Location = new Point(103, 82);
            TitleTxtBox.Margin = new Padding(3, 2, 3, 2);
            TitleTxtBox.Name = "TitleTxtBox";
            TitleTxtBox.Size = new Size(274, 23);
            TitleTxtBox.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 82);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 34;
            label5.Text = "Title";
            // 
            // AdminLbl
            // 
            AdminLbl.AutoSize = true;
            AdminLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminLbl.Location = new Point(27, 20);
            AdminLbl.Name = "AdminLbl";
            AdminLbl.Size = new Size(67, 25);
            AdminLbl.TabIndex = 33;
            AdminLbl.Text = "Admin";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 47);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 403);
            dataGridView1.TabIndex = 31;
            // 
            // bookList
            // 
            bookList.FormattingEnabled = true;
            bookList.ItemHeight = 15;
            bookList.Location = new Point(51, 332);
            bookList.Name = "bookList";
            bookList.Size = new Size(326, 109);
            bookList.TabIndex = 58;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 487);
            Controls.Add(bookList);
            Controls.Add(GenreCmbBox);
            Controls.Add(label11);
            Controls.Add(DeleteTxtBox);
            Controls.Add(DeleteBookLbl);
            Controls.Add(AcadCmbBox);
            Controls.Add(AcademicsLbl);
            Controls.Add(NonFictionCmbBox);
            Controls.Add(NonFinctionLbl);
            Controls.Add(FictionCmbBox);
            Controls.Add(FictionLbl);
            Controls.Add(NextBttn);
            Controls.Add(BackBttn);
            Controls.Add(DeleteBttn);
            Controls.Add(UpdateBttn);
            Controls.Add(AddBttn);
            Controls.Add(PublishTxtBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ISBNTxtBox);
            Controls.Add(label4);
            Controls.Add(AuthorTxtBox);
            Controls.Add(label3);
            Controls.Add(TitleTxtBox);
            Controls.Add(label5);
            Controls.Add(AdminLbl);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminPanel";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox DeleteTxtBox;
        private Label DeleteBookLbl;
        private ComboBox AcadCmbBox;
        private Label AcademicsLbl;
        private ComboBox NonFictionCmbBox;
        private Label NonFinctionLbl;
        private ComboBox FictionCmbBox;
        private Label FictionLbl;
        private Button NextBttn;
        private Button BackBttn;
        private Button DeleteBttn;
        private Button UpdateBttn;
        private Button AddBttn;
        private TextBox PublishTxtBox;
        private Label label7;
        private Label label6;
        private TextBox ISBNTxtBox;
        private Label label4;
        private TextBox AuthorTxtBox;
        private Label label3;
        private TextBox TitleTxtBox;
        private Label label5;
        private Label AdminLbl;
        private DataGridView dataGridView1;
        private ListBox bookList;
    }
}
