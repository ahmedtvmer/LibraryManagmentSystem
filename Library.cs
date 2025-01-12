using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment
{
    internal class Library
    {
        private List<Book> _books = new List<Book>();

        private List<Book> _borrowedBooks = new List<Book>();
        public List<Book> DisplayBooks()
        {
            return _books;
        }
        private void AddBook(string bookTitle)
        {
            //Some Code
        }
        private void RemoveBook(string bookTitle)
        {
            //Some Code
        }
    }
}
