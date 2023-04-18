using FluentValidation;

namespace Library.Domain.Commands.Validations
{
    public abstract class BookValidation<T> : AbstractValidator<T> where T : BookCommand
    {
    }
}