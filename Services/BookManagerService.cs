public class BookManagerService 
{
    private Dictionary<string, Book> bookDictionary = new Dictionary<string, Book>();

    public void AddBook() 
    {
        Book newBook = new Book();
        Console.WriteLine("Book ID: ");
        newBook.bookId = Console.ReadLine();
        Console.WriteLine("Book Title: ");
        newBook.bookTitle = Console.ReadLine();
        Console.WriteLine("Book Author: ");
        newBook.authorName = Console.ReadLine();
        Console.WriteLine("Book Genre: ");
        newBook.bookGenre = Console.ReadLine();
        bookDictionary.Add(newBook.bookId, newBook);
    }
    /// <summary>
    /// A method that displays all books in bookDictionary using a foreach loop
    /// </summary>
    public void DisplayAllBooks() 
    {
        Console.WriteLine("BOOKS AVAILABLE: ");
        foreach (var book in bookDictionary) {
            Console.WriteLine("ID: " + book.Value.bookId);
            Console.WriteLine("Title: " + book.Value.bookTitle);
            Console.WriteLine("Author: " + book.Value.authorName);
            Console.WriteLine("Genre: " + book.Value.bookGenre);
            Console.WriteLine("---------------------------");
        }
    }
    public void runService()
    {
        AddBook();
        DisplayAllBooks();
    }
}