public class Book 
{
    public string bookId {get; set;}
    public string bookTitle {get; set;}
    public string authorName {get; set;}
    public string bookGenre {get; set;}

    public Book() 
    {
        this.bookId = "";
        this.bookTitle = "";
        this.authorName = "";
        this.bookGenre = "";
    }

    public Book(string id, string title, string author, string genre) 
    {
        this.bookId = id;
        this.bookTitle = title;
        this.authorName = author;
        this.bookGenre = genre;
    }
}