using Library.Application.Interfaces;
using Library.Application.Services;
using Library.Domain.Commands;
using Library.Domain.Interfaces;
using Library.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using Library.Domain.Models;

namespace Library.Infra.CrossCutting.IoC;

public static class NativeInjectorBootStrapper
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IBookAppService, BookAppService>();

        services.AddScoped<IRequestHandler<BookCommand, Pagination<Book>>, BookCommandHandler>();

        services.AddScoped<IBookRepository, BookRepository>();
    }
}