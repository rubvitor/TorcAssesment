using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Library.Application.Interfaces;
using Library.Application.ViewModels;
using Library.Domain.Commands;
using Library.Domain.Models;
using MediatR;

namespace Library.Application.Services;

public class BookAppService : IBookAppService
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public BookAppService(IMapper mapper,
                          IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<Pagination<Book>> Search(BookViewModel bookViewModel)
    {
        var registerCommand = _mapper.Map<BookCommand>(bookViewModel);
        return await _mediator.Send(registerCommand);
    }
}
