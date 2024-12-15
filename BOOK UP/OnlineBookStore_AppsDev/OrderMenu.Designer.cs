namespace OnlineBookStore_AppsDev
{
    partial class OrderMenu
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
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            back2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(187, 405);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 19;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(69, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 27);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 27);
            textBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 254);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 15;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 189);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 14;
            label3.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 119);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 13;
            label2.Text = "Payment";
            // 
            // listView1
            // 
            listView1.Location = new Point(310, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(523, 340);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // back2
            // 
            back2.Location = new Point(56, 405);
            back2.Margin = new Padding(3, 4, 3, 4);
            back2.Name = "back2";
            back2.Size = new Size(86, 31);
            back2.TabIndex = 11;
            back2.Text = "Back";
            back2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 48);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 10;
            label1.Text = "ORDER MENU";
            label1.Click += label1_Click;
            // 
            // OrderMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 527);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(back2);
            Controls.Add(label1);
            Name = "OrderMenu";
            Text = "OrderMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListView listView1;
        private Button back2;
        private Label label1;
    }
}