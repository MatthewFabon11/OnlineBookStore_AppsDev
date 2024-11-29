namespace OnlineBookStore_AppsDev
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            AuthorLabel = new Label();
            AuthorTextBox = new TextBox();
            ISBNLabel = new Label();
            ISBNTextBox = new TextBox();
            BackButton = new Button();
            NextButton = new Button();
            AddBttn = new Button();
            UpdateBttn = new Button();
            DeleteBttn = new Button();
            GenreLabel = new Label();
            GenreCmbBox = new ComboBox();
            label7 = new Label();
            PublishLbl = new TextBox();
            label11 = new Label();
            ResultCmbBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(813, 402);
            dataGridView1.TabIndex = 1;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(83, 122);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(38, 20);
            TitleLabel.TabIndex = 7;
            TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(151, 122);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(312, 27);
            TitleTextBox.TabIndex = 8;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(83, 180);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(54, 20);
            AuthorLabel.TabIndex = 9;
            AuthorLabel.Text = "Author";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(151, 173);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(312, 27);
            AuthorTextBox.TabIndex = 10;
            // 
            // ISBNLabel
            // 
            ISBNLabel.AutoSize = true;
            ISBNLabel.Location = new Point(80, 238);
            ISBNLabel.Name = "ISBNLabel";
            ISBNLabel.Size = new Size(41, 20);
            ISBNLabel.TabIndex = 11;
            ISBNLabel.Text = "ISBN";
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Location = new Point(151, 231);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(312, 27);
            ISBNTextBox.TabIndex = 12;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(622, 500);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 20;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(743, 500);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(94, 29);
            NextButton.TabIndex = 21;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            // 
            // AddBttn
            // 
            AddBttn.Location = new Point(503, 444);
            AddBttn.Name = "AddBttn";
            AddBttn.Size = new Size(94, 29);
            AddBttn.TabIndex = 22;
            AddBttn.Text = "Add";
            AddBttn.UseVisualStyleBackColor = true;
            // 
            // UpdateBttn
            // 
            UpdateBttn.Location = new Point(622, 444);
            UpdateBttn.Name = "UpdateBttn";
            UpdateBttn.Size = new Size(94, 29);
            UpdateBttn.TabIndex = 23;
            UpdateBttn.Text = "Update";
            UpdateBttn.UseVisualStyleBackColor = true;
            // 
            // DeleteBttn
            // 
            DeleteBttn.Location = new Point(743, 444);
            DeleteBttn.Name = "DeleteBttn";
            DeleteBttn.Size = new Size(94, 29);
            DeleteBttn.TabIndex = 24;
            DeleteBttn.Text = "Delete";
            DeleteBttn.UseVisualStyleBackColor = true;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(83, 308);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(48, 20);
            GenreLabel.TabIndex = 25;
            GenreLabel.Text = "Genre";
            // 
            // GenreCmbBox
            // 
            GenreCmbBox.FormattingEnabled = true;
            GenreCmbBox.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Academic" });
            GenreCmbBox.Location = new Point(151, 300);
            GenreCmbBox.Name = "GenreCmbBox";
            GenreCmbBox.Size = new Size(312, 28);
            GenreCmbBox.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 364);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 32;
            label7.Text = "Publication Date";
            // 
            // PublishLbl
            // 
            PublishLbl.Location = new Point(216, 361);
            PublishLbl.Name = "PublishLbl";
            PublishLbl.Size = new Size(247, 27);
            PublishLbl.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(80, 444);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 34;
            label11.Text = "Results";
            // 
            // ResultCmbBox
            // 
            ResultCmbBox.Location = new Point(151, 441);
            ResultCmbBox.Name = "ResultCmbBox";
            ResultCmbBox.Size = new Size(312, 27);
            ResultCmbBox.TabIndex = 35;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 575);
            Controls.Add(ResultCmbBox);
            Controls.Add(label11);
            Controls.Add(PublishLbl);
            Controls.Add(label7);
            Controls.Add(GenreCmbBox);
            Controls.Add(GenreLabel);
            Controls.Add(DeleteBttn);
            Controls.Add(UpdateBttn);
            Controls.Add(AddBttn);
            Controls.Add(NextButton);
            Controls.Add(BackButton);
            Controls.Add(ISBNTextBox);
            Controls.Add(ISBNLabel);
            Controls.Add(AuthorTextBox);
            Controls.Add(AuthorLabel);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "AdminPanel";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label TitleLabel;
        private TextBox TitleTextBox;
        private Label AuthorLabel;
        private TextBox AuthorTextBox;
        private Label ISBNLabel;
        private TextBox ISBNTextBox;
        private Button BackButton;
        private Button NextButton;
        private Button AddBttn;
        private Button UpdateBttn;
        private Button DeleteBttn;
        private Label GenreLabel;
        private ComboBox GenreCmbBox;
        private Label label7;
        private TextBox PublishLbl;
        private Label label11;
        private TextBox ResultCmbBox;
    }
}
