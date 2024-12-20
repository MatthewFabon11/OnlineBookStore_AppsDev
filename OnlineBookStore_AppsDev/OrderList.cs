﻿using OnlineBookStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore_AppsDev
{

    public partial class OrderList : Form
    {
        private string loggedInUser;
        private string Title;
        private OleDbConnection connection = new OleDbConnection();

        public OrderList(string username, string title)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Antonio Fabon Jr\Desktop\AlmostFinised_OnlineBook 3.5 with design\Database.accdb;Persist Security Info=False;";
            loggedInUser = username;
            Title = title;

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenu userMenu = new UserMenu(loggedInUser);
            userMenu.Show();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            orderlists.Items.Add(Title);
        }

        private void orderlists_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from AdminTB where Title = '" + orderlists.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Title_Label.Text = reader["Title"].ToString();
                    Price_Label.Text = reader["Price"].ToString();
                    Author_Label.Text = reader["Author"].ToString();
                    qty_Label.Text = reader["Quantity"].ToString();
                    Genre_Label.Text = reader["Genre"].ToString();
                    ID_Label.Text = reader["ID"].ToString();


                    if (ID_Label.Text == "1")
                    {
                        fiction1.Visible = true;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "2")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = true;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "3")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = true;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "4")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = true;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "5")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = true;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "6")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = true;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "7")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = true;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "8")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = true;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "9")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = true;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "10")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = true;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "11")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = true;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "12")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = true;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "13")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = true;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (ID_Label.Text == "14")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = true;
                        academic5.Visible = false;
                    }

                    else if (ID_Label.Text == "15")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = true;
                    }
                    else if (ID_Label.Text == "16")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }



                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);

            }

        }


        private void Generate()
        {
            if (!string.IsNullOrEmpty(Title_Label.Text) && !string.IsNullOrEmpty(Price_Label.Text))
            {
                int quantity = 1; // Default quantity
                decimal price = decimal.Parse(Price_Label.Text); // Parse price from label
                decimal totalPrice;

                // Try to parse the quantity from the txt_qty textbox
                if (!string.IsNullOrEmpty(txt_qty.Text) && int.TryParse(txt_qty.Text, out quantity) && quantity > 0)
                {
                    totalPrice = price * quantity; // Calculate the total price
                }
                else
                {
                    // If invalid quantity is entered, show an error and set default totalPrice
                    MessageBox.Show("Invalid quantity entered. Defaulting to 1.", "Error");
                    totalPrice = price; // Default to a single item price
                }

                // Generate the receipt
                StringBuilder receipt = new StringBuilder();
                receipt.AppendLine("==================================");
                receipt.AppendLine("           BOOK RECEIPT           ");
                receipt.AppendLine("==================================");
                receipt.AppendLine($"Title: {Title_Label.Text}");
                receipt.AppendLine($"Author: {Author_Label.Text}");
                receipt.AppendLine($"Price (per item): {price:C}");
                receipt.AppendLine($"Quantity: {quantity}");
                receipt.AppendLine($"Total Price: {totalPrice:C}");
                receipt.AppendLine($"Genre: {Genre_Label.Text}");
                receipt.AppendLine($"Date: {DateTime.Now.ToShortDateString()}");
                receipt.AppendLine("==================================");
                receipt.AppendLine("Thank you for your purchase!");

                // Show the receipt in a message box.
                MessageBox.Show(receipt.ToString(), "Book Receipt");
            }
            else
            {
                // Inform the user if no book details are available.
                MessageBox.Show("No book details available to generate a receipt.", "Error");
            }
        }

        private void dataGridViewBookDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
