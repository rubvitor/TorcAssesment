using AutoMapper;
using Library.Application.ViewModels;
using Library.Domain.Commands;

namespace Library.Application.AutoMapper;

public class DomainToViewModelMappingProfile : Profile
{
    public DomainToViewModelMappingProfile()
    {
        CreateMap<BookViewModel, BookCommand>();
    }
}
