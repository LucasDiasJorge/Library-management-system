using lib_management.Models;

namespace lib_management.models;

public class Session
{
    public string Usarname { get; set; }
    public int BooksBorrowedQnt { get; set; }
    public List<Book> BooksBorrowed { get; set; }

    public Session(string usarname, int booksBorrowedQnt, List<Book> booksBorrowed)
    {
        Usarname = usarname;
        BooksBorrowedQnt = booksBorrowedQnt;
        BooksBorrowed = booksBorrowed;
    }

    public Session BookArithmetic(int booksBorrowedQnt)
    {
        BooksBorrowedQnt = this.BooksBorrowedQnt + booksBorrowedQnt;
        return this;
    }
    
    
}