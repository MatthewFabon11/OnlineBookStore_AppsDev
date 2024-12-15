namespace OnlineBookStore_AppsDev
{
    partial class Order
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
            buttonPurchase = new Button();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            buttonBack = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPurchase
            // 
            buttonPurchase.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPurchase.Location = new Point(550, 464);
            buttonPurchase.Name = "buttonPurchase";
            buttonPurchase.Size = new Size(94, 29);
            buttonPurchase.TabIndex = 0;
            buttonPurchase.Text = "Purchase";
            buttonPurchase.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(387, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(257, 345);
            dataGridView1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(32, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 337);
            listBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(buttonPurchase);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(96, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 530);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(698, 600);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(387, 464);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(154, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel Order";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 665);
            Controls.Add(buttonBack);
            Controls.Add(groupBox1);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPurchase;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Button buttonCancel;
        private Button buttonBack;
    }
}