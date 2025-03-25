namespace lib_management
{

    public class Services
    {
        public Services() { }

        public Book NewBook()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter book ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter book author: ");
            string author = Console.ReadLine();

            return new Book(title, isbn, author);
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
    }
}