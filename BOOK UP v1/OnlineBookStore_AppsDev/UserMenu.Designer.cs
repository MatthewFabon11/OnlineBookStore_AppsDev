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
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // back2
            // 
            back2.Location = new Point(12, 367);
            back2.Name = "back2";
            back2.Size = new Size(75, 23);
            back2.TabIndex = 1;
            back2.Text = "back";
            back2.UseVisualStyleBackColor = true;
            back2.Click += back2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 207);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(368, 154);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 174);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 3;
            label1.Text = "BOOKS";
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 414);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(back2);
            Name = "UserMenu";
            Text = "UserMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button back2;
        private ListBox listBox1;
        private Label label1;
    }
}