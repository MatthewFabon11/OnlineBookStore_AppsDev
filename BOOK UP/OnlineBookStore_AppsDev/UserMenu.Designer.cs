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
            label1 = new Label();
            back2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 83);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 0;
            label1.Text = "USER MENU";
            // 
            // back2
            // 
            back2.Location = new Point(84, 297);
            back2.Name = "back2";
            back2.Size = new Size(75, 23);
            back2.TabIndex = 1;
            back2.Text = "back";
            back2.UseVisualStyleBackColor = true;
            back2.Click += back2_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back2);
            Controls.Add(label1);
            Name = "UserMenu";
            Text = "UserMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button back2;
    }
}