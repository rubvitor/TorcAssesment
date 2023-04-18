using Library.Domain.Commands;

namespace Library.Domain.Models;

public class BookSearch
{
    public BookSearch(BookCommand bookCommand)
    {
        BookId = bookCommand.BookId;
        Title = bookCommand.Title;
        FirstName = bookCommand.FirstName;
        LastName = bookCommand.LastName;
        Type = bookCommand.Type;
        ISBN = bookCommand.ISBN;
        Category = bookCommand.Category;
        Page = bookCommand.Page;
        Length = bookCommand.Length;
    }

    public int? BookId { get; protected set; }
    public string Title { get; protected set; }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public string Type { get; protected set; }
    public string ISBN { get; protected set; }
    public string Category { get; protected set; }
    public short? Page { get; protected set; }
    public short? Length { get; protected set; }
}
