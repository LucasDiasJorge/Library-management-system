namespace lib_management
{

    public class Book
    {
        public string Title { get; }
        public string Isbn { get; }
        public string Author { get; }

        public Book(string title, string isbn, string author)
        {
            Title = title;
            Isbn = isbn;
            Author = author;
        }

        public override bool Equals(object obj)
        {
            if (obj is Book other)
            {
                return Title.Equals(other.Title, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Title.ToLower().GetHashCode();
        }
    }
}