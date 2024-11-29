namespace OnlineBookStore
{
    partial class SignUpMenu
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
            back3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Submit = new Button();
            SuspendLayout();
            // 
            // back3
            // 
            back3.Location = new Point(101, 302);
            back3.Name = "back3";
            back3.Size = new Size(75, 23);
            back3.TabIndex = 0;
            back3.Text = "back";
            back3.UseVisualStyleBackColor = true;
            back3.Click += back3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(335, 87);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 3;
            textBox1.Tag = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(335, 116);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 4;
            textBox2.Tag = "";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(335, 145);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Password";
            textBox3.Size = new Size(181, 23);
            textBox3.TabIndex = 5;
            textBox3.Tag = "";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(335, 174);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Mobile Number";
            textBox4.Size = new Size(181, 23);
            textBox4.TabIndex = 6;
            textBox4.Tag = "";
            // 
            // Submit
            // 
            Submit.Location = new Point(387, 211);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 7;
            Submit.Text = "submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // SignUpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Submit);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(back3);
            Name = "SignUpMenu";
            Text = "SignUpMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Submit;
    }
}