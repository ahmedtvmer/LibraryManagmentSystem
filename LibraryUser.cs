using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment
{
    internal class LibraryUser : User
    {
        public LibraryCard Card { get; set; }
    }
}
