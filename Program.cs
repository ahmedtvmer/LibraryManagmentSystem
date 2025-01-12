namespace Library_Managment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to library managment system");
            
            Library library = new Library();

            Console.WriteLine("Are you a librarian or a regular user? (L/R)");

            while (true)
            {
                char userChoice = Console.ReadLine().ToUpper()[0];

                if (userChoice == 'L')
                {
                    Console.WriteLine("Enter your name:");
                    Librarian l1 = new Librarian(Console.ReadLine(), 1);
                    Console.WriteLine($"Welcome {l1.Name}");
                    Console.ReadKey();

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Please choose: Add Book(A) / Remove Book(R) / Display Books(D) / Exit(E)");
                        char choice = Console.ReadLine().ToUpper()[0];

                        switch (choice)
                        {
                            case 'A':
                                Console.WriteLine("Please enter book details");
                                Book book = new Book(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));

                                l1.AddBook(book, library);
                                Console.ReadKey();
                                break;
                            case 'R':
                                Console.WriteLine("Please enter book title");
                                string booktitle = Console.ReadLine();

                                l1.RemoveBook(booktitle, library);
                                Console.ReadKey();

                                break;
                            case 'D':
                                Console.WriteLine("Book List:");
                                l1.Display(library);
                                Console.ReadKey();

                                break;
                            case 'E':
                                Environment.Exit(0);
                                continue;
                            default:
                                Console.WriteLine("Not valid");
                                Console.ReadKey();
                                continue;
                        }
                    }
                }
                else if (userChoice == 'R')
                {
                    Console.WriteLine("Enter your name:");
                    LibraryUser u1 = new LibraryUser(Console.ReadLine());
                    Console.WriteLine($"Welcome {u1.Name}");
                    Console.ReadKey();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Please choose: Borrow Book(B) / Display Books(D) / Exit(E)");
                        char choice = Console.ReadLine().ToUpper()[0];

                        switch(choice)
                        {
                            case 'B':
                                Console.WriteLine("Please enter the book title:");
                                string bookTitle = Console.ReadLine();
                                u1.BorrowBook(bookTitle, library);
                                Console.ReadKey();

                                break;
                            case 'D':
                                Console.WriteLine("Display Books:");
                                u1.Display(library);
                                Console.ReadKey();


                                break;
                            case 'E':
                                Environment.Exit(0);
                                continue;
                            default:
                                Console.WriteLine("Not valid");
                                Console.ReadKey();

                                continue;
                        }
                    }
                }
                else
                    Console.WriteLine("Not valid, Please try again!");
            }
        }
    }
}
