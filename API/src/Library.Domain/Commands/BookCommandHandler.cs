using System.Threading;
using System.Threading.Tasks;
using Library.Domain.Interfaces;
using MediatR;
using System.Collections.Generic;
using Library.Domain.Models;

namespace Library.Domain.Commands;

public class BookCommandHandler : IRequestHandler<BookCommand, Pagination<Book>>
{
    private readonly IBookRepository _bookRepository;

    public BookCommandHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Pagination<Book>> Handle(BookCommand message, CancellationToken cancellationToken) => await _bookRepository.SearchBook(new (message));
}