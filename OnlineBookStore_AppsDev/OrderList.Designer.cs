namespace OnlineBookStore_AppsDev
{
    partial class OrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            order_btn = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            orderlists = new ListBox();
            bookTitle = new Label();
            txt_name = new TextBox();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Genre_Label = new Label();
            label3 = new Label();
            qty_Label = new Label();
            Author_Label = new Label();
            Price_Label = new Label();
            Title_Label = new Label();
            academic5 = new PictureBox();
            academic4 = new PictureBox();
            academic3 = new PictureBox();
            academic2 = new PictureBox();
            academic = new PictureBox();
            nonfiction5 = new PictureBox();
            nonfiction4 = new PictureBox();
            nonfiction3 = new PictureBox();
            nonfiction2 = new PictureBox();
            nonfiction = new PictureBox();
            fiction5 = new PictureBox();
            fiction4 = new PictureBox();
            fiction3 = new PictureBox();
            fiction2 = new PictureBox();
            fiction1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ID_Label = new Label();
            back_btn = new Button();
            txt_qty = new TextBox();
            Bank = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)academic5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)academic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)academic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)academic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)academic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiction5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiction4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiction3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiction2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiction1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(62, 340);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Description of Address";
            textBox4.Size = new Size(169, 109);
            textBox4.TabIndex = 108;
            textBox4.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(62, 247);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "City, Barangay";
            textBox3.Size = new Size(169, 27);
            textBox3.TabIndex = 107;
            textBox3.Visible = false;
            // 
            // order_btn
            // 
            order_btn.FlatStyle = FlatStyle.Popup;
            order_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_btn.Location = new Point(302, 797);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(111, 35);
            order_btn.TabIndex = 106;
            order_btn.Text = "Order Now";
            order_btn.UseVisualStyleBackColor = true;
            order_btn.Click += order_btn_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 295);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Postal Code";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 105;
            textBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 200);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Phone Number";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 104;
            textBox1.Visible = false;
            // 
            // orderlists
            // 
            orderlists.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderlists.FormattingEnabled = true;
            orderlists.ItemHeight = 25;
            orderlists.Location = new Point(246, 103);
            orderlists.Name = "orderlists";
            orderlists.Size = new Size(241, 404);
            orderlists.TabIndex = 103;
            orderlists.SelectedIndexChanged += orderlists_SelectedIndexChanged;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.BackColor = Color.BurlyWood;
            bookTitle.ForeColor = Color.Black;
            bookTitle.Location = new Point(75, 157);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(0, 20);
            bookTitle.TabIndex = 102;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(62, 155);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "First Name";
            txt_name.Size = new Size(169, 27);
            txt_name.TabIndex = 101;
            txt_name.Tag = "";
            txt_name.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.BurlyWood;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(62, 101);
            label8.Name = "label8";
            label8.Size = new Size(134, 25);
            label8.TabIndex = 100;
            label8.Text = "ORDER Booklist";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.BurlyWood;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(41, 71);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(462, 785);
            dataGridView2.TabIndex = 99;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-1, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1080, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 109;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Tan;
            label7.Font = new Font("Kristen ITC", 8.25F);
            label7.Location = new Point(231, 659);
            label7.Name = "label7";
            label7.Size = new Size(55, 19);
            label7.TabIndex = 120;
            label7.Text = "Genre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Tan;
            label6.Font = new Font("Kristen ITC", 8.25F);
            label6.Location = new Point(231, 719);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 119;
            label6.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Tan;
            label5.Font = new Font("Kristen ITC", 8.25F);
            label5.Location = new Point(231, 631);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 118;
            label5.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Tan;
            label4.Font = new Font("Kristen ITC", 8.25F);
            label4.Location = new Point(231, 603);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 117;
            label4.Text = "Title:";
            // 
            // Genre_Label
            // 
            Genre_Label.AutoSize = true;
            Genre_Label.BackColor = Color.Tan;
            Genre_Label.Font = new Font("Kristen ITC", 8.25F);
            Genre_Label.Location = new Point(287, 659);
            Genre_Label.Name = "Genre_Label";
            Genre_Label.Size = new Size(0, 19);
            Genre_Label.TabIndex = 116;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Tan;
            label3.Font = new Font("Kristen ITC", 8.25F);
            label3.Location = new Point(231, 688);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 115;
            label3.Text = "Qty:";
            // 
            // qty_Label
            // 
            qty_Label.AutoSize = true;
            qty_Label.BackColor = Color.Tan;
            qty_Label.Font = new Font("Kristen ITC", 8.25F);
            qty_Label.Location = new Point(272, 688);
            qty_Label.Name = "qty_Label";
            qty_Label.Size = new Size(0, 19);
            qty_Label.TabIndex = 114;
            // 
            // Author_Label
            // 
            Author_Label.AutoSize = true;
            Author_Label.BackColor = Color.Tan;
            Author_Label.Font = new Font("Kristen ITC", 8.25F);
            Author_Label.Location = new Point(296, 631);
            Author_Label.Name = "Author_Label";
            Author_Label.Size = new Size(0, 19);
            Author_Label.TabIndex = 113;
            // 
            // Price_Label
            // 
            Price_Label.AutoSize = true;
            Price_Label.BackColor = Color.Tan;
            Price_Label.Font = new Font("Kristen ITC", 8.25F);
            Price_Label.Location = new Point(282, 719);
            Price_Label.Name = "Price_Label";
            Price_Label.Size = new Size(0, 19);
            Price_Label.TabIndex = 112;
            // 
            // Title_Label
            // 
            Title_Label.AutoSize = true;
            Title_Label.BackColor = Color.Tan;
            Title_Label.Font = new Font("Kristen ITC", 8.25F);
            Title_Label.Location = new Point(278, 603);
            Title_Label.Name = "Title_Label";
            Title_Label.Size = new Size(0, 19);
            Title_Label.TabIndex = 111;
            // 
            // academic5
            // 
            academic5.Image = (Image)resources.GetObject("academic5.Image");
            academic5.Location = new Point(75, 560);
            academic5.Margin = new Padding(3, 4, 3, 4);
            academic5.Name = "academic5";
            academic5.Size = new Size(133, 251);
            academic5.SizeMode = PictureBoxSizeMode.StretchImage;
            academic5.TabIndex = 139;
            academic5.TabStop = false;
            academic5.Visible = false;
            // 
            // academic4
            // 
            academic4.Image = (Image)resources.GetObject("academic4.Image");
            academic4.Location = new Point(75, 560);
            academic4.Margin = new Padding(3, 4, 3, 4);
            academic4.Name = "academic4";
            academic4.Size = new Size(133, 251);
            academic4.SizeMode = PictureBoxSizeMode.StretchImage;
            academic4.TabIndex = 138;
            academic4.TabStop = false;
            academic4.Visible = false;
            // 
            // academic3
            // 
            academic3.Image = (Image)resources.GetObject("academic3.Image");
            academic3.Location = new Point(75, 560);
            academic3.Margin = new Padding(3, 4, 3, 4);
            academic3.Name = "academic3";
            academic3.Size = new Size(133, 251);
            academic3.SizeMode = PictureBoxSizeMode.StretchImage;
            academic3.TabIndex = 137;
            academic3.TabStop = false;
            academic3.Visible = false;
            // 
            // academic2
            // 
            academic2.Image = (Image)resources.GetObject("academic2.Image");
            academic2.Location = new Point(75, 560);
            academic2.Margin = new Padding(3, 4, 3, 4);
            academic2.Name = "academic2";
            academic2.Size = new Size(133, 251);
            academic2.SizeMode = PictureBoxSizeMode.StretchImage;
            academic2.TabIndex = 136;
            academic2.TabStop = false;
            academic2.Visible = false;
            // 
            // academic
            // 
            academic.Image = (Image)resources.GetObject("academic.Image");
            academic.Location = new Point(75, 560);
            academic.Margin = new Padding(3, 4, 3, 4);
            academic.Name = "academic";
            academic.Size = new Size(133, 251);
            academic.SizeMode = PictureBoxSizeMode.StretchImage;
            academic.TabIndex = 135;
            academic.TabStop = false;
            academic.Visible = false;
            // 
            // nonfiction5
            // 
            nonfiction5.Image = (Image)resources.GetObject("nonfiction5.Image");
            nonfiction5.Location = new Point(75, 560);
            nonfiction5.Margin = new Padding(3, 4, 3, 4);
            nonfiction5.Name = "nonfiction5";
            nonfiction5.Size = new Size(133, 251);
            nonfiction5.SizeMode = PictureBoxSizeMode.StretchImage;
            nonfiction5.TabIndex = 134;
            nonfiction5.TabStop = false;
            nonfiction5.Visible = false;
            // 
            // nonfiction4
            // 
            nonfiction4.Image = (Image)resources.GetObject("nonfiction4.Image");
            nonfiction4.Location = new Point(75, 560);
            nonfiction4.Margin = new Padding(3, 4, 3, 4);
            nonfiction4.Name = "nonfiction4";
            nonfiction4.Size = new Size(133, 251);
            nonfiction4.SizeMode = PictureBoxSizeMode.StretchImage;
            nonfiction4.TabIndex = 133;
            nonfiction4.TabStop = false;
            nonfiction4.Visible = false;
            // 
            // nonfiction3
            // 
            nonfiction3.Image = (Image)resources.GetObject("nonfiction3.Image");
            nonfiction3.Location = new Point(75, 560);
            nonfiction3.Margin = new Padding(3, 4, 3, 4);
            nonfiction3.Name = "nonfiction3";
            nonfiction3.Size = new Size(133, 251);
            nonfiction3.SizeMode = PictureBoxSizeMode.StretchImage;
            nonfiction3.TabIndex = 132;
            nonfiction3.TabStop = false;
            nonfiction3.Visible = false;
            // 
            // nonfiction2
            // 
            nonfiction2.Image = (Image)resources.GetObject("nonfiction2.Image");
            nonfiction2.Location = new Point(75, 560);
            nonfiction2.Margin = new Padding(3, 4, 3, 4);
            nonfiction2.Name = "nonfiction2";
            nonfiction2.Size = new Size(133, 251);
            nonfiction2.SizeMode = PictureBoxSizeMode.StretchImage;
            nonfiction2.TabIndex = 131;
            nonfiction2.TabStop = false;
            nonfiction2.Visible = false;
            // 
            // nonfiction
            // 
            nonfiction.Image = (Image)resources.GetObject("nonfiction.Image");
            nonfiction.Location = new Point(75, 560);
            nonfiction.Margin = new Padding(3, 4, 3, 4);
            nonfiction.Name = "nonfiction";
            nonfiction.Size = new Size(133, 251);
            nonfiction.SizeMode = PictureBoxSizeMode.StretchImage;
            nonfiction.TabIndex = 130;
            nonfiction.TabStop = false;
            nonfiction.Visible = false;
            // 
            // fiction5
            // 
            fiction5.Image = (Image)resources.GetObject("fiction5.Image");
            fiction5.Location = new Point(75, 560);
            fiction5.Margin = new Padding(3, 4, 3, 4);
            fiction5.Name = "fiction5";
            fiction5.Size = new Size(133, 251);
            fiction5.SizeMode = PictureBoxSizeMode.StretchImage;
            fiction5.TabIndex = 129;
            fiction5.TabStop = false;
            fiction5.Visible = false;
            // 
            // fiction4
            // 
            fiction4.Image = (Image)resources.GetObject("fiction4.Image");
            fiction4.Location = new Point(75, 560);
            fiction4.Margin = new Padding(3, 4, 3, 4);
            fiction4.Name = "fiction4";
            fiction4.Size = new Size(133, 251);
            fiction4.SizeMode = PictureBoxSizeMode.StretchImage;
            fiction4.TabIndex = 128;
            fiction4.TabStop = false;
            fiction4.Visible = false;
            // 
            // fiction3
            // 
            fiction3.Image = (Image)resources.GetObject("fiction3.Image");
            fiction3.Location = new Point(75, 560);
            fiction3.Margin = new Padding(3, 4, 3, 4);
            fiction3.Name = "fiction3";
            fiction3.Size = new Size(133, 251);
            fiction3.SizeMode = PictureBoxSizeMode.StretchImage;
            fiction3.TabIndex = 127;
            fiction3.TabStop = false;
            fiction3.Visible = false;
            // 
            // fiction2
            // 
            fiction2.Image = (Image)resources.GetObject("fiction2.Image");
            fiction2.Location = new Point(75, 560);
            fiction2.Margin = new Padding(3, 4, 3, 4);
            fiction2.Name = "fiction2";
            fiction2.Size = new Size(133, 251);
            fiction2.SizeMode = PictureBoxSizeMode.StretchImage;
            fiction2.TabIndex = 126;
            fiction2.TabStop = false;
            fiction2.Visible = false;
            // 
            // fiction1
            // 
            fiction1.Image = (Image)resources.GetObject("fiction1.Image");
            fiction1.Location = new Point(75, 560);
            fiction1.Margin = new Padding(3, 4, 3, 4);
            fiction1.Name = "fiction1";
            fiction1.Size = new Size(133, 251);
            fiction1.SizeMode = PictureBoxSizeMode.StretchImage;
            fiction1.TabIndex = 125;
            fiction1.TabStop = false;
            fiction1.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(75, 560);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(133, 251);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 124;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(75, 560);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 251);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 123;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(75, 560);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 251);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 122;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(75, 560);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 121;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Gray;
            pictureBox7.Location = new Point(75, 560);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(133, 251);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 140;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(75, 560);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(133, 251);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 141;
            pictureBox8.TabStop = false;
            pictureBox8.Visible = false;
            // 
            // ID_Label
            // 
            ID_Label.AutoSize = true;
            ID_Label.BackColor = Color.Tan;
            ID_Label.Font = new Font("Kristen ITC", 8.25F);
            ID_Label.Location = new Point(231, 560);
            ID_Label.Name = "ID_Label";
            ID_Label.Size = new Size(0, 19);
            ID_Label.TabIndex = 142;
            ID_Label.Visible = false;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(569, 801);
            back_btn.Margin = new Padding(3, 4, 3, 4);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(86, 31);
            back_btn.TabIndex = 143;
            back_btn.Text = "back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // txt_qty
            // 
            txt_qty.Location = new Point(419, 801);
            txt_qty.Margin = new Padding(3, 4, 3, 4);
            txt_qty.Name = "txt_qty";
            txt_qty.PlaceholderText = "Qty:";
            txt_qty.Size = new Size(53, 27);
            txt_qty.TabIndex = 144;
            txt_qty.TextChanged += txt_qty_TextChanged;
            // 
            // Bank
            // 
            Bank.AutoSize = true;
            Bank.Location = new Point(257, 805);
            Bank.Name = "Bank";
            Bank.Size = new Size(41, 20);
            Bank.TabIndex = 145;
            Bank.Text = "bank";
            Bank.Visible = false;
            // 
            // OrderList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 872);
            Controls.Add(Bank);
            Controls.Add(txt_qty);
            Controls.Add(back_btn);
            Controls.Add(ID_Label);
            Controls.Add(academic5);
            Controls.Add(academic4);
            Controls.Add(academic3);
            Controls.Add(academic2);
            Controls.Add(academic);
            Controls.Add(nonfiction5);
            Controls.Add(nonfiction4);
            Controls.Add(nonfiction3);
            Controls.Add(nonfiction2);
            Controls.Add(nonfiction);
            Controls.Add(fiction5);
            Controls.Add(fiction4);
            Controls.Add(fiction3);
            Controls.Add(fiction2);
            Controls.Add(fiction1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Genre_Label);
            Controls.Add(label3);
            Controls.Add(qty_Label);
            Controls.Add(Author_Label);
            Controls.Add(Price_Label);
            Controls.Add(Title_Label);
            Controls.Add(pictureBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(order_btn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(orderlists);
            Controls.Add(bookTitle);
            Controls.Add(txt_name);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderList";
            Text = "OrderList";
            Load += OrderList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)academic5).EndInit();
            ((System.ComponentModel.ISupportInitialize)academic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)academic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)academic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)academic).EndInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction5).EndInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nonfiction).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiction5).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiction4).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiction3).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiction2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiction1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private Button order_btn;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox orderlists;
        private Label bookTitle;
        private TextBox txt_name;
        private Label label8;
        private DataGridView dataGridView2;
        private PictureBox pictureBox5;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label Genre_Label;
        private Label label3;
        private Label qty_Label;
        private Label Author_Label;
        private Label Price_Label;
        private Label Title_Label;
        private PictureBox academic5;
        private PictureBox academic4;
        private PictureBox academic3;
        private PictureBox academic2;
        private PictureBox academic;
        private PictureBox nonfiction5;
        private PictureBox nonfiction4;
        private PictureBox nonfiction3;
        private PictureBox nonfiction2;
        private PictureBox nonfiction;
        private PictureBox fiction5;
        private PictureBox fiction4;
        private PictureBox fiction3;
        private PictureBox fiction2;
        private PictureBox fiction1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label ID_Label;
        private Button back_btn;
        private TextBox txt_qty;
        private Label Bank;
    }
}