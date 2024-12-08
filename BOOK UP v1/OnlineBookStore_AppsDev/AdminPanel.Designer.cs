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
            QuantityTxtBox = new TextBox();
            AuthorTxtBox = new TextBox();
            label3 = new Label();
            TitleTxtBox = new TextBox();
            label5 = new Label();
            AdminLbl = new Label();
            dataGridView1 = new DataGridView();
            bookList = new ListBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GenreCmbBox
            // 
            GenreCmbBox.FormattingEnabled = true;
            GenreCmbBox.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Academic" });
            GenreCmbBox.Location = new Point(118, 299);
            GenreCmbBox.Name = "GenreCmbBox";
            GenreCmbBox.Size = new Size(313, 28);
            GenreCmbBox.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(58, 419);
            label11.Name = "label11";
            label11.Size = new Size(112, 20);
            label11.TabIndex = 56;
            label11.Text = "BOOKS ADDED";
            // 
            // DeleteTxtBox
            // 
            DeleteTxtBox.Location = new Point(592, 399);
            DeleteTxtBox.Name = "DeleteTxtBox";
            DeleteTxtBox.Size = new Size(203, 27);
            DeleteTxtBox.TabIndex = 55;
            // 
            // DeleteBookLbl
            // 
            DeleteBookLbl.AutoSize = true;
            DeleteBookLbl.Location = new Point(483, 403);
            DeleteBookLbl.Name = "DeleteBookLbl";
            DeleteBookLbl.Size = new Size(105, 20);
            DeleteBookLbl.TabIndex = 54;
            DeleteBookLbl.Text = "Delete A book";
            // 
            // AcadCmbBox
            // 
            AcadCmbBox.FormattingEnabled = true;
            AcadCmbBox.Location = new Point(483, 341);
            AcadCmbBox.Name = "AcadCmbBox";
            AcadCmbBox.Size = new Size(313, 28);
            AcadCmbBox.TabIndex = 52;
            // 
            // AcademicsLbl
            // 
            AcademicsLbl.AutoSize = true;
            AcademicsLbl.Location = new Point(483, 307);
            AcademicsLbl.Name = "AcademicsLbl";
            AcademicsLbl.Size = new Size(81, 20);
            AcademicsLbl.TabIndex = 51;
            AcademicsLbl.Text = "Academics";
            // 
            // NonFictionCmbBox
            // 
            NonFictionCmbBox.FormattingEnabled = true;
            NonFictionCmbBox.Location = new Point(483, 241);
            NonFictionCmbBox.Name = "NonFictionCmbBox";
            NonFictionCmbBox.Size = new Size(313, 28);
            NonFictionCmbBox.TabIndex = 50;
            // 
            // NonFinctionLbl
            // 
            NonFinctionLbl.AutoSize = true;
            NonFinctionLbl.Location = new Point(483, 207);
            NonFinctionLbl.Name = "NonFinctionLbl";
            NonFinctionLbl.Size = new Size(87, 20);
            NonFinctionLbl.TabIndex = 49;
            NonFinctionLbl.Text = "Non-Fiction";
            // 
            // FictionCmbBox
            // 
            FictionCmbBox.FormattingEnabled = true;
            FictionCmbBox.Location = new Point(483, 147);
            FictionCmbBox.Name = "FictionCmbBox";
            FictionCmbBox.Size = new Size(313, 28);
            FictionCmbBox.TabIndex = 48;
            // 
            // FictionLbl
            // 
            FictionLbl.AutoSize = true;
            FictionLbl.Location = new Point(483, 109);
            FictionLbl.Name = "FictionLbl";
            FictionLbl.Size = new Size(53, 20);
            FictionLbl.TabIndex = 32;
            FictionLbl.Text = "Fiction";
            // 
            // NextBttn
            // 
            NextBttn.Location = new Point(753, 605);
            NextBttn.Name = "NextBttn";
            NextBttn.Size = new Size(94, 29);
            NextBttn.TabIndex = 47;
            NextBttn.Text = "Next";
            NextBttn.UseVisualStyleBackColor = true;
            // 
            // BackBttn
            // 
            BackBttn.Location = new Point(640, 605);
            BackBttn.Name = "BackBttn";
            BackBttn.Size = new Size(94, 29);
            BackBttn.TabIndex = 46;
            BackBttn.Text = "Back";
            BackBttn.UseVisualStyleBackColor = true;
            BackBttn.Click += BackBttn_Click;
            // 
            // DeleteBttn
            // 
            DeleteBttn.Location = new Point(713, 453);
            DeleteBttn.Name = "DeleteBttn";
            DeleteBttn.Size = new Size(94, 29);
            DeleteBttn.TabIndex = 45;
            DeleteBttn.Text = "Delete";
            DeleteBttn.UseVisualStyleBackColor = true;
            // 
            // UpdateBttn
            // 
            UpdateBttn.Location = new Point(602, 453);
            UpdateBttn.Name = "UpdateBttn";
            UpdateBttn.Size = new Size(94, 29);
            UpdateBttn.TabIndex = 44;
            UpdateBttn.Text = "Update";
            UpdateBttn.UseVisualStyleBackColor = true;
            // 
            // AddBttn
            // 
            AddBttn.Location = new Point(483, 453);
            AddBttn.Name = "AddBttn";
            AddBttn.Size = new Size(94, 29);
            AddBttn.TabIndex = 43;
            AddBttn.Text = "Add";
            AddBttn.UseVisualStyleBackColor = true;
            AddBttn.Click += AddBttn_Click;
            // 
            // PublishTxtBox
            // 
            PublishTxtBox.Location = new Point(183, 360);
            PublishTxtBox.Name = "PublishTxtBox";
            PublishTxtBox.Size = new Size(247, 27);
            PublishTxtBox.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 363);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 41;
            label7.Text = "Publication Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 307);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 40;
            label6.Text = "Genre";
            // 
            // QuantityTxtBox
            // 
            QuantityTxtBox.Location = new Point(143, 241);
            QuantityTxtBox.Name = "QuantityTxtBox";
            QuantityTxtBox.Size = new Size(288, 27);
            QuantityTxtBox.TabIndex = 39;
            // 
            // AuthorTxtBox
            // 
            AuthorTxtBox.Location = new Point(118, 176);
            AuthorTxtBox.Name = "AuthorTxtBox";
            AuthorTxtBox.Size = new Size(313, 27);
            AuthorTxtBox.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 179);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 36;
            label3.Text = "Author";
            // 
            // TitleTxtBox
            // 
            TitleTxtBox.Location = new Point(118, 109);
            TitleTxtBox.Name = "TitleTxtBox";
            TitleTxtBox.Size = new Size(313, 27);
            TitleTxtBox.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 109);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 34;
            label5.Text = "Title";
            // 
            // AdminLbl
            // 
            AdminLbl.AutoSize = true;
            AdminLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminLbl.Location = new Point(31, 27);
            AdminLbl.Name = "AdminLbl";
            AdminLbl.Size = new Size(82, 31);
            AdminLbl.TabIndex = 33;
            AdminLbl.Text = "Admin";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(829, 537);
            dataGridView1.TabIndex = 31;
            // 
            // bookList
            // 
            bookList.FormattingEnabled = true;
            bookList.Location = new Point(58, 443);
            bookList.Margin = new Padding(3, 4, 3, 4);
            bookList.Name = "bookList";
            bookList.Size = new Size(372, 144);
            bookList.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 244);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 38;
            label4.Text = "Quantity";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 649);
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
            Controls.Add(QuantityTxtBox);
            Controls.Add(label4);
            Controls.Add(AuthorTxtBox);
            Controls.Add(label3);
            Controls.Add(TitleTxtBox);
            Controls.Add(label5);
            Controls.Add(AdminLbl);
            Controls.Add(dataGridView1);
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
        private TextBox QuantityTxtBox;
        private TextBox AuthorTxtBox;
        private Label label3;
        private TextBox TitleTxtBox;
        private Label label5;
        private Label AdminLbl;
        private DataGridView dataGridView1;
        private ListBox bookList;
        private Label label4;
    }
}
