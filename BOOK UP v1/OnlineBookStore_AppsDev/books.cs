using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore_AppsDev
{
    internal class books
    {
        // Private fields
        private string title;
        private int isbn;
        private string author;
        private string genre;
        private string fiction;
        private string nonfiction;

        //  encapsulation
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
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
        public books(string title, int isbn, string author, string genre)
        {
            Title = title;
            ISBN = isbn;
            Author = author;
            Genre = genre;
        }

        // Method to return person details
        public string GetDetails()
        {
            return $"Title: {Title} | ISBN: {ISBN} | Author: {Author} | Genre: {Genre}" ;
        }
    }
}
