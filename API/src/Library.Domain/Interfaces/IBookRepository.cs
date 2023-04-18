using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Domain.Models;

namespace Library.Domain.Interfaces;

public interface IBookRepository
{
    Task<Book> GetById(int id);
    Task<Pagination<Book>> SearchBook(BookSearch bookSearch);
    Task<IEnumerable<Book>> GetAll();

    void Add(Book Book);
    void Update(Book Book);
    void Remove(Book Book);
    IUnitOfWork UnitOfWork { get; }
}