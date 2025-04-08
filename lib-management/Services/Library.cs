using lib_management.Models;

namespace lib_management.Services
{

    public class Library
    {
        public Library() { }

        public Book NewBook()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter book ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter book author: ");
            string author = Console.ReadLine();

            return new Book(title, isbn, author, false);
        }

        public void DeleteBook(string title, HashSet<Book> list)
        {
            Book bookToRemove = null;
            foreach (var book in list)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    bookToRemove = book;
                    break;
                }
            }

            if (bookToRemove != null)
            {
                list.Remove(bookToRemove);
                Console.WriteLine($"Book '{title}' removed.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found.");
            }
        }

        public void DisplayLib(HashSet<Book> lib)
        {
            if (lib.Count == 0)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            foreach (Book b in lib)
            {
                Console.WriteLine($"Title: {b.Title}, ISBN: {b.Isbn}, Author: {b.Author}");
            }
        }
        
        public Book FindBook(HashSet<Book> lib, string title)
        {

            foreach (Book b in lib)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Title: {b.Title}, ISBN: {b.Isbn}, Author: {b.Author}");
                    return b;
                }
            }
            
            Console.WriteLine($"Book of title: {title} was not found.");
            return null;
        }

        public void FindBook(HashSet<Book> lib)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
                
            FindBook(lib, title);
        }

        public bool BorrowBook(HashSet<Book> lib)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Book book = FindBook(lib, title);
            
            if (book != null)
            {
                if (book.Situation)
                {
                    Console.WriteLine("Book is already borrowed.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Borrowing book...");
                    book.Situation = true;
                    lib.Add(book);
                    return true;
                }
            }
            return false;
        }
        
        public bool CheckoutBook(HashSet<Book> lib)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Book book = FindBook(lib, title);
            
            if (book != null)
            {
                if (!book.Situation)
                {
                    Console.WriteLine("Book is free.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Checking out book...");
                    book.Situation = false;
                    lib.Add(book);
                    return true;
                }
            }
            return false;
        }
    }
}