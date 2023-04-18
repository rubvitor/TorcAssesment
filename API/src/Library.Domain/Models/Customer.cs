namespace Library.Domain.Models;

public class Book
{
    public Book(int id, string title, string firstName, string lastName)
    {
        BookId = id;
        FirstName = firstName;
        LastName = lastName;
        Title = title;
    }

    public Book() { }

    public int BookId { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int TotalCopies { get; set; }
    public int CopiesInUse { get; set; }
    public string Type { get; set; }
    public string ISBN { get; set; }
    public string Category { get; set; }
}