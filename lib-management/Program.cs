using System;
using System.Collections.Generic;
using lib_management.models;
using lib_management.Models;
using lib_management.Services;

namespace lib_management
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Book> lib = new HashSet<Book>();
            Library LibService = new Library();
            SessionManagement SessionManager = new SessionManagement();
            
            Session s = SessionManager.CreateSession();

            while (true)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Remove a Book");
                Console.WriteLine("3. Display Library");
                Console.WriteLine("4. Find a book");
                Console.WriteLine("5. Borrow a book");
                Console.WriteLine("6. Checkout a book");
                Console.WriteLine("7. Exit");
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
                        if (s.BooksBorrowedQnt <= 3)
                        {
                            Console.WriteLine("Limit of borrowing books reached...");
                            break;
                        }
                        if (LibService.BorrowBook(lib))
                        {
                            s.BookArithmetic(+1);
                        }
                        break;
                    case "6":
                        Console.WriteLine("Checkout books...");
                        if (LibService.CheckoutBook(lib))
                        {
                            s.BookArithmetic(-1);
                        }
                        break;
                    case "7":
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