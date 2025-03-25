using System;

namespace lib_management;

class Program
{
    static void Main(string[] args)
    {
        HashSet<Book> lib = new HashSet<Book>();

        while (true)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Remove a Book");
            Console.WriteLine("3. Display Library");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Adding a book...");
                    break;
                case "2":
                    Console.WriteLine("Removing a book...");
                    break;
                case "3":
                    Console.WriteLine("Displaying library...");
                    break;
                case "4":
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
