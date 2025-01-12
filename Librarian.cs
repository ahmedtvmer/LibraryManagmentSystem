using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment
{
    internal class Librarian : User
    {
        private int _employeeID;

        public Librarian(string name, int ID)
        {
            this.Name = name;
            this._employeeID = ID;
        }
        public void AddBook(Book book, Library library)
        {
            library.AddBook(book);
        }
        public void RemoveBook(string title, Library library)
        {
            library.RemoveBook(title);
        }
    }
}
