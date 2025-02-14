public class Book 
{
    public string bookId {get; set;}
    public string bookTitle {get; set;}
    public string authorName {get; set;}
    public string bookGenre {get; set;}

/// <summary>
/// costructor for a book object
/// </summary>
    public Book() 
    {
        this.bookId = "";
        this.bookTitle = "";
        this.authorName = "";
        this.bookGenre = "";
    }

    
}