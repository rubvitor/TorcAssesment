using Library.Application.Interfaces;
using Library.Application.ViewModels;
using Library.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Services.Api.Controllers;

[AllowAnonymous]
public class BookController : ApiController
{
    private readonly IBookAppService _bookAppService;

    public BookController(IBookAppService BookAppService)
    {
        _bookAppService = BookAppService;
    }

    [HttpPost("book-search")]
    public async Task<Pagination<Book>> Search([FromBody] BookViewModel bookViewModel)
    {
        return await _bookAppService.Search(bookViewModel);
    }
}
