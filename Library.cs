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
        public void DisplayBooks()
        {
            foreach(Book book in _books)
                Console.WriteLine(book.Title);
        }
        public void AddBook(Book book)
        {
            _books.Add(book);
            Console.WriteLine("Book added succesfully");
        }
        public void RemoveBook(string bookTitle)
        {
            Book book = SearchBookbyName(bookTitle);
            if ( book != null)
            {
                _books.Remove(book);
                Console.WriteLine("Book removed succesfully");
            }
            else
                Console.WriteLine("Error; book not found");
        }

        public void BorrowBook(string bookTitle)
        {
            Book book = SearchBookbyName(bookTitle);
            if( book != null )
            {
                _borrowedBooks.Add(book);
                Console.WriteLine("Book borrowed successfully");
            }
            else
                Console.WriteLine("Book is not found");
        }

        public Book SearchBookbyName(string name)
        {
            foreach (Book book in _books)
            {
                if (book.Title.Equals(name))
                    return book;
            }
            return null;
        }
    }
}
