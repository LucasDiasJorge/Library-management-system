using lib_management.models;

namespace lib_management.Services;

public class SessionManagement
{

    public Session CreateSession(){
        
        Console.WriteLine("Creating session...");
        Console.Write("Type your name: ");
        string usarname = Console.ReadLine();
        
        return new Session(usarname, 0, null);
    }

    public Session UpdateSession(Session s, int bookArithmetic)
    {
        return s.BookArithmetic(bookArithmetic);
    }
    
}