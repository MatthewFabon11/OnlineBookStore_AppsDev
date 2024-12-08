using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore_AppsDev
{
    internal class books
    {
        private static int nextId = 1;

        // Private fields
        private int id;
        private string title;
        private int qty;
        private string author;
        private string genre;
        private string fiction;
        private string nonfiction;

        //  encapsulation
        public int Id
        {
            get { return id; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int QTY
        {
            get { return qty; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative.");
                qty = value;
            }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

       

        // Constructor
        public books(string title, int qty, string author, string genre)
        {
            id = nextId; // Assign the current ID
            nextId++;    // Increment the static ID for the next book

            Title = title;
            QTY = qty;
            Author = author;
            Genre = genre;
        }

        // Method to return person details
        public string GetDetails()
        {         

            return $"ID: { Id } | QTY: {QTY} | Title: {Title} | Author: {Author} | Genre: {Genre}" ;
        }
    }
}
