using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Domain.Interfaces;
using Library.Domain.Models;
using Library.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Infra.Data.Repository;

public class BookRepository : IBookRepository
{
    protected readonly LibraryContext Db;
    protected readonly DbSet<Book> DbSet;

    public BookRepository(LibraryContext context)
    {
        Db = context;
        DbSet = Db.Set<Book>();
    }

    public IUnitOfWork UnitOfWork => Db;

    public async Task<Book> GetById(int id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task<IEnumerable<Book>> GetAll()
    {
        return await DbSet.ToListAsync();
    }

    public async Task<Pagination<Book>> SearchBook(BookSearch bookSearch)
    {
        var resultPaginated = new Pagination<Book>();

        var query = DbSet.AsNoTracking().AsQueryable();

        if (bookSearch.BookId.HasValue && bookSearch.BookId.Value > 0)
            query = query.Where(q => q.BookId == bookSearch.BookId);

        if (!string.IsNullOrEmpty(bookSearch.FirstName))
            query = query.Where(q => q.FirstName.Equals(bookSearch.FirstName));

        if (!string.IsNullOrEmpty(bookSearch.LastName))
            query = query.Where(q => q.LastName.Equals(bookSearch.LastName));

        if (!string.IsNullOrEmpty(bookSearch.Title))
            query = query.Where(q => q.Title.Equals(bookSearch.Title));

        if (!string.IsNullOrEmpty(bookSearch.ISBN))
            query = query.Where(q => q.ISBN.Equals(bookSearch.ISBN));

        if (!string.IsNullOrEmpty(bookSearch.Category))
            query = query.Where(q => q.Category.Equals(bookSearch.Category));

        if (!string.IsNullOrEmpty(bookSearch.Type))
            query = query.Where(q => q.Type.Equals(bookSearch.Type));

        if (bookSearch.Page.HasValue)
        {
            var skip = bookSearch.Page.Value * (bookSearch.Length.HasValue ? bookSearch.Length.Value : 1);

            query = query.Skip((int)skip);
        }

        if (bookSearch.Length.HasValue)
            query = query.Take((int)bookSearch.Length);

        resultPaginated.Result = await query.ToListAsync();
        resultPaginated.Total = DbSet.AsNoTracking().Count();

        return resultPaginated;
    }

    public void Add(Book Book)
    {
        DbSet.Add(Book);
    }

    public void Update(Book Book)
    {
        DbSet.Update(Book);
    }

    public void Remove(Book Book)
    {
        DbSet.Remove(Book);
    }

    public void Dispose()
    {
        Db.Dispose();
    }
}
