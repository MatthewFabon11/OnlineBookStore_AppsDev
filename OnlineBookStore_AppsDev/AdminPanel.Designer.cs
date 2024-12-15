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
            txt_deleteID = new TextBox();
            DeleteBookLbl = new Label();
            BackBttn = new Button();
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
            label1 = new Label();
            LoadTB = new Button();
            label2 = new Label();
            label7 = new Label();
            txt_Price = new TextBox();
            txt_updateID = new TextBox();
            ID_label = new Label();
            btn_Edit = new Button();
            btn_UPDATE = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            bookview = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // GenreCmbBox
            // 
            GenreCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenreCmbBox.FormattingEnabled = true;
            GenreCmbBox.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Academic" });
            GenreCmbBox.Location = new Point(268, 671);
            GenreCmbBox.Name = "GenreCmbBox";
            GenreCmbBox.Size = new Size(138, 28);
            GenreCmbBox.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Tan;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(62, 97);
            label11.Name = "label11";
            label11.Size = new Size(121, 25);
            label11.TabIndex = 56;
            label11.Text = "BOOKS ADDED";
            label11.Click += label11_Click;
            // 
            // txt_deleteID
            // 
            txt_deleteID.Location = new Point(602, 573);
            txt_deleteID.Name = "txt_deleteID";
            txt_deleteID.Size = new Size(144, 27);
            txt_deleteID.TabIndex = 55;
            // 
            // DeleteBookLbl
            // 
            DeleteBookLbl.AutoSize = true;
            DeleteBookLbl.BackColor = Color.FromArgb(255, 128, 128);
            DeleteBookLbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBookLbl.Location = new Point(621, 509);
            DeleteBookLbl.Name = "DeleteBookLbl";
            DeleteBookLbl.Size = new Size(109, 25);
            DeleteBookLbl.TabIndex = 54;
            DeleteBookLbl.Text = "DELETE Book";
            // 
            // BackBttn
            // 
            BackBttn.BackColor = Color.WhiteSmoke;
            BackBttn.FlatStyle = FlatStyle.Popup;
            BackBttn.Image = OnlineBookStore_AppsDev.Properties.Resources.back2;
            BackBttn.Location = new Point(798, 402);
            BackBttn.Name = "BackBttn";
            BackBttn.Size = new Size(57, 37);
            BackBttn.TabIndex = 46;
            BackBttn.UseVisualStyleBackColor = false;
            BackBttn.Click += BackBttn_Click;
            // 
            // DeleteBttn
            // 
            DeleteBttn.BackColor = Color.Red;
            DeleteBttn.FlatStyle = FlatStyle.Flat;
            DeleteBttn.Image = OnlineBookStore_AppsDev.Properties.Resources.delete;
            DeleteBttn.Location = new Point(621, 616);
            DeleteBttn.Name = "DeleteBttn";
            DeleteBttn.Size = new Size(70, 56);
            DeleteBttn.TabIndex = 45;
            DeleteBttn.UseVisualStyleBackColor = false;
            DeleteBttn.Click += DeleteBttn_Click;
            // 
            // AddBttn
            // 
            AddBttn.BackColor = Color.Lime;
            AddBttn.FlatStyle = FlatStyle.Flat;
            AddBttn.Image = OnlineBookStore_AppsDev.Properties.Resources.add;
            AddBttn.Location = new Point(285, 752);
            AddBttn.Name = "AddBttn";
            AddBttn.Size = new Size(67, 54);
            AddBttn.TabIndex = 43;
            AddBttn.UseVisualStyleBackColor = false;
            AddBttn.Click += AddBttn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.Location = new Point(201, 671);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 40;
            label6.Text = "Genre";
            // 
            // QuantityTxtBox
            // 
            QuantityTxtBox.Location = new Point(268, 630);
            QuantityTxtBox.Name = "QuantityTxtBox";
            QuantityTxtBox.Size = new Size(138, 27);
            QuantityTxtBox.TabIndex = 39;
            // 
            // AuthorTxtBox
            // 
            AuthorTxtBox.Location = new Point(268, 591);
            AuthorTxtBox.Name = "AuthorTxtBox";
            AuthorTxtBox.Size = new Size(138, 27);
            AuthorTxtBox.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.Location = new Point(200, 591);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 36;
            label3.Text = "Author";
            // 
            // TitleTxtBox
            // 
            TitleTxtBox.Location = new Point(268, 550);
            TitleTxtBox.Name = "TitleTxtBox";
            TitleTxtBox.Size = new Size(138, 27);
            TitleTxtBox.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 255, 192);
            label5.Location = new Point(200, 550);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 34;
            label5.Text = "Title";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.OrangeRed;
            dataGridView1.Location = new Point(33, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(822, 309);
            dataGridView1.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Location = new Point(200, 634);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 38;
            label4.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 454);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 59;
            label1.Text = "ADD Book";
            label1.Click += label1_Click;
            // 
            // LoadTB
            // 
            LoadTB.BackColor = SystemColors.Control;
            LoadTB.Cursor = Cursors.Hand;
            LoadTB.FlatStyle = FlatStyle.Popup;
            LoadTB.ForeColor = Color.LightGray;
            LoadTB.Image = OnlineBookStore_AppsDev.Properties.Resources.refresher;
            LoadTB.Location = new Point(189, 90);
            LoadTB.Margin = new Padding(3, 4, 3, 4);
            LoadTB.Name = "LoadTB";
            LoadTB.Size = new Size(50, 45);
            LoadTB.TabIndex = 60;
            LoadTB.UseVisualStyleBackColor = false;
            LoadTB.Click += LoadTB_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(572, 580);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 61;
            label2.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 255, 192);
            label7.Location = new Point(201, 717);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 62;
            label7.Text = "Price";
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(268, 713);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(73, 27);
            txt_Price.TabIndex = 63;
            // 
            // txt_updateID
            // 
            txt_updateID.Location = new Point(268, 511);
            txt_updateID.Name = "txt_updateID";
            txt_updateID.Size = new Size(138, 27);
            txt_updateID.TabIndex = 64;
            txt_updateID.Visible = false;
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.BackColor = Color.FromArgb(192, 255, 192);
            ID_label.Location = new Point(201, 515);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(24, 20);
            ID_label.TabIndex = 65;
            ID_label.Text = "ID";
            ID_label.Visible = false;
            // 
            // btn_Edit
            // 
            btn_Edit.FlatStyle = FlatStyle.Popup;
            btn_Edit.Image = OnlineBookStore_AppsDev.Properties.Resources.edit;
            btn_Edit.Location = new Point(215, 752);
            btn_Edit.Margin = new Padding(3, 4, 3, 4);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(64, 53);
            btn_Edit.TabIndex = 66;
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_UPDATE
            // 
            btn_UPDATE.BackColor = Color.FromArgb(255, 192, 128);
            btn_UPDATE.FlatStyle = FlatStyle.Flat;
            btn_UPDATE.Image = OnlineBookStore_AppsDev.Properties.Resources.update;
            btn_UPDATE.Location = new Point(358, 752);
            btn_UPDATE.Margin = new Padding(3, 4, 3, 4);
            btn_UPDATE.Name = "btn_UPDATE";
            btn_UPDATE.Size = new Size(67, 54);
            btn_UPDATE.TabIndex = 67;
            btn_UPDATE.UseVisualStyleBackColor = false;
            btn_UPDATE.Visible = false;
            btn_UPDATE.Click += btn_UPDATE_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(255, 128, 128);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(543, 476);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(219, 229);
            dataGridView2.TabIndex = 68;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(192, 255, 192);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(170, 426);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(288, 393);
            dataGridView3.TabIndex = 69;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // bookview
            // 
            bookview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            bookview.BackgroundColor = Color.FromArgb(255, 224, 192);
            bookview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookview.GridColor = SystemColors.ControlDark;
            bookview.Location = new Point(85, 143);
            bookview.Margin = new Padding(3, 4, 3, 4);
            bookview.Name = "bookview";
            bookview.RowHeadersWidth = 51;
            bookview.Size = new Size(729, 194);
            bookview.TabIndex = 58;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PaleGreen;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = OnlineBookStore_AppsDev.Properties.Resources.addbook;
            pictureBox1.Location = new Point(232, 443);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 53);
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(255, 128, 128);
            pictureBox3.Image = OnlineBookStore_AppsDev.Properties.Resources.deletebook;
            pictureBox3.Location = new Point(562, 494);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 53);
            pictureBox3.TabIndex = 75;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = OnlineBookStore_AppsDev.Properties.Resources._11;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1080, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 76;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = OnlineBookStore_AppsDev.Properties.Resources.admin1;
            pictureBox4.Location = new Point(847, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 77;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = OnlineBookStore_AppsDev.Properties.Resources.background;
            ClientSize = new Size(891, 875);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
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
            Controls.Add(LoadTB);
            Controls.Add(bookview);
            Controls.Add(label11);
            Controls.Add(BackBttn);
            Controls.Add(dataGridView1);
            Name = "AdminPanel";
            Text = "Admin Panel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button BackBttn;
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
        private Label label1;
        private Button LoadTB;
        private Label label2;
        private Label label7;
        private TextBox txt_Price;
        private TextBox txt_updateID;
        private Label ID_label;
        private Button btn_Edit;
        private Button btn_UPDATE;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView bookview;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}
