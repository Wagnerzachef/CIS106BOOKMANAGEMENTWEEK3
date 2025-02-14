public class BookManagerService 
{
    //thiss code uses a dictionary with a string key and a book value
    private Dictionary<string, Book> bookDictionary = new Dictionary<string, Book>();

/// <summary>
/// A method that adds books directly from the code
/// </summary>
/// <param name="id">a string for book id</param>
/// <param name="title">a string for a book title</param>
/// <param name="author">a string for a author's name</param>
/// <param name="genre">a string for a books genre</param>
    public void AddBook(string id, string title, string author, string genre)
    {
        Book presetBook = new Book{
            bookId = id,
            bookTitle = title,
            authorName = author,
            bookGenre = genre
        };
        bookDictionary.Add(presetBook.bookId, presetBook);
    }
/// <summary>
/// Method that adds books to the dictionary using user input
/// </summary>
    public void AddBook() 
    {
        Book newBook = new Book();
        ValidateID(newBook);
        ValidateTitle(newBook);
        ValidateAuthor(newBook);
        ValidateGenre(newBook);
        bookDictionary.Add(newBook.bookId, newBook);
    }
    /// <summary>
    /// Method to validate the authors name
    /// </summary>
    /// <param name="newBook3">parameter to control where the id is going</param>
    private void ValidateAuthor(Book newBook3)
    {
        Console.WriteLine("Book Author: ");
        string newBookName = Console.ReadLine();
        if (string.IsNullOrEmpty(newBookName)) {
            Console.WriteLine("A book needs an Author. Please put in a valid name: ");
            ValidateAuthor(newBook3);
        }
        else {
            newBook3.authorName = newBookName;
        }
    }
    /// <summary>
    /// method to validate user input for book title
    /// </summary>
    /// <param name="newBook4">parameter to control where the id is going</param>
    private void ValidateTitle(Book newBook4)
    {
        Console.WriteLine("Book Title: ");
        string newBookTitle = Console.ReadLine();
        if (string.IsNullOrEmpty(newBookTitle)) {
            Console.WriteLine("A book needs an Title. Please put in a valid title: ");
            ValidateTitle(newBook4);
        }
        else {
            newBook4.bookTitle = newBookTitle;
        }
    }
    /// <summary>
    /// method to validate user input for book genre
    /// </summary>
    /// <param name="newBook5">parameter to control where the id is going</param>
    private void ValidateGenre(Book newBook5)
    {
        Console.WriteLine("Book Genre: ");
        string newBookGenre = Console.ReadLine();
        if (string.IsNullOrEmpty(newBookGenre)) {
            Console.WriteLine("A book needs an Genre. Please put in a valid genre: ");
            ValidateGenre(newBook5);
        }
        else {
            newBook5.bookGenre = newBookGenre;
        }
    }
    /// <summary>
    /// method that validates a enterd id by finding if that id already exists or if the user entered white space
    /// </summary>
    /// <param name="newBook2">parameter to control where the id is going</param>
    private void ValidateID(Book newBook2)
    {
        Console.WriteLine("Book ID: ");
        string testId = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(testId))
        {
            if (!bookDictionary.ContainsKey(testId)) //test if id is already in dictionary
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
    /// <summary>
    /// A method that looks up individual books using an entered id 
    /// and prevents the user from looking up invalid id's
    /// </summary>
    public void LookUpBook()
    {
        Console.WriteLine("What is the ID of the book you'd like to look up?");
        string Id = Console.ReadLine();
        if (bookDictionary.ContainsKey(Id)) {
            Console.WriteLine("ID: " + bookDictionary[Id].bookId);
            Console.WriteLine("Title: " + bookDictionary[Id].bookTitle);
            Console.WriteLine("Author: " + bookDictionary[Id].authorName);
            Console.WriteLine("Genre: " + bookDictionary[Id].bookGenre);
            Console.WriteLine("---------------------------");
        }
        else{
            Console.WriteLine("We are sorry. The book you are trying to look up doesn't exist yet. Please add it to our records.\n");
        }
    }
    /// <summary>
    /// A method that removes books using an entered id
    /// and prevents the user from deleting id's that don't exist
    /// </summary>
    public void RemoveBook()
    {
        Console.WriteLine("Which book would you like to delete?");
        string Id = Console.ReadLine();
        if (bookDictionary.ContainsKey(Id)) {
            string deletedBook =bookDictionary[Id].bookTitle;
            bookDictionary.Remove($"{Id}");
            Console.WriteLine(deletedBook + " REMOVED");
        } else {
            Console.WriteLine("This book doesn't exist.\n");
        }
    }
    /// <summary>
    /// The method that runs the book manager service
    /// </summary>
    public void runService()
    {
        string choice = "0";
        do 
        {
            Console.WriteLine("Welcome to the book management system. You currently have " + bookDictionary.Count + " books in your system.");
            Console.WriteLine("What would you like to do? \n" + 
            "1. Add a book\n" +
            "2. Display all books\n" +
            "3. Look up a book by Id\n" +
            "4. Remove a book\n" +
            "5. Exit\n");
            choice = Console.ReadLine();
            //Swich controls where the user goes
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