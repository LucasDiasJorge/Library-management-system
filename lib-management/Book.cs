namespace lib_management
{

    public class Book
    {
        public string Title { get; }
        public string Isbn { get; }
        public string Author { get; }
        
        // Borrow situation
        public bool Situation { set; get; }
        

        public Book(string title, string isbn, string author, bool situation)
        {
            Title = title;
            Isbn = isbn;
            Author = author;
            Situation = situation;
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