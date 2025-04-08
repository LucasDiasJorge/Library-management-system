using System;
using System.Collections.Generic;

namespace lib_management
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Book> lib = new HashSet<Book>();
            Services LibService = new Services();

            while (true)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Remove a Book");
                Console.WriteLine("3. Display Library");
                Console.WriteLine("4. Find a book");
                Console.WriteLine("5. Borrow a book");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Adding a book...");
                        lib.Add(LibService.NewBook());
                        break;
                    case "2":
                        Console.WriteLine("Removing a book...");
                        Console.Write("Enter book title to remove: ");
                        string title = Console.ReadLine();
                        LibService.DeleteBook(title, lib);
                        break;
                    case "3":
                        Console.WriteLine("Displaying library...");
                        LibService.DisplayLib(lib);
                        break;
                    case "4":
                        Console.WriteLine("Finding books...");
                        LibService.FindBook(lib);
                        break;
                    case "5":
                        Console.WriteLine("Borrowing books...");
                        LibService.BorrowBook(lib);
                        break;
                    case "6":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}