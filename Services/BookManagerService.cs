public class BookManagerService 
{
    private Dictionary<string, Book> bookDictionary = new Dictionary<string, Book>();

    public void AddBook() 
    {
        Book newBook = new Book();
        ValidateID(newBook);
        Console.WriteLine("Book Title: ");
        newBook.bookTitle = Console.ReadLine();
        Console.WriteLine("Book Author: ");
        newBook.authorName = Console.ReadLine();
        Console.WriteLine("Book Genre: ");
        newBook.bookGenre = Console.ReadLine();
        bookDictionary.Add(newBook.bookId, newBook);
    }
    public void ValidateID(Book newBook2)
    {
        Console.WriteLine("Book ID: ");
        string testId = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(testId))
        {
            if (!bookDictionary.ContainsKey(testId))
            {
                newBook2.bookId = testId;
            }
            else {
                Console.WriteLine("That id is already being used. Please enter a different id: ");
                ValidateID(newBook2);
            }
        }
        else {
            Console.WriteLine("Invalid id, please try again: ");
            ValidateID(newBook2);
        }
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
    public void LookUpBook()
    {
        Console.WriteLine("What is the ID of the book you'd like to look up?");
        string Id = Console.ReadLine();
        Console.WriteLine("ID: " + bookDictionary[Id].bookId);
        Console.WriteLine("Title: " + bookDictionary[Id].bookTitle);
        Console.WriteLine("Author: " + bookDictionary[Id].authorName);
        Console.WriteLine("Genre: " + bookDictionary[Id].bookGenre);
        Console.WriteLine("---------------------------");
    }
    public void RemoveBook()
    {
        Console.WriteLine("Which book would you like to delete?");
        string Id = Console.ReadLine();
        string deletedBook =bookDictionary[Id].bookTitle;
        bookDictionary.Remove($"{Id}");
        Console.WriteLine(deletedBook + " REMOVED");
    }
    public void runService()
    {
        string choice = "0";
        do 
        {
            Console.WriteLine("What would you like to do? \n" + 
            "1. Add a book\n" +
            "2. Display all books\n" +
            "3. Look up a book by Id\n" +
            "4. Remove a book\n" +
            "5. Exit\n");
            choice = Console.ReadLine();
            switch (choice) 
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    DisplayAllBooks();
                    break;
                case "3":
                    LookUpBook();
                    break;
                    case "4":
                    RemoveBook();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5: ");
                    break;
            } 
        } while (choice != "5");
            
    }
}