using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Application.ViewModels;
using Library.Domain.Models;

namespace Library.Application.Interfaces;

public interface IBookAppService
{
    Task<Pagination<Book>> Search(BookViewModel bookViewModel);
}
