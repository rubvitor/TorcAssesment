namespace Library.Application.ViewModels;

public class BookViewModel
{
    public int? BookId { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Type { get; set; }
    public string ISBN { get; set; }
    public string Category { get; set; }
    public short? Page { get; set; } = 0;
    public short? Length { get; set; } = 10;
}
