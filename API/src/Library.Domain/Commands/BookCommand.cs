using FluentValidation.Results;
using Library.Domain.Models;
using MediatR;
using System.Collections.Generic;

namespace Library.Domain.Commands;

public class BookCommand : IRequest<Pagination<Book>>
{
    public int? BookId { get; protected set; }
    public string Title { get; protected set; }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public string Type { get; protected set; }
    public string ISBN { get; protected set; }
    public string Category { get; protected set; }
    public short? Page { get; protected set; }
    public short? Length { get; protected set; }
    public ValidationResult ValidationResult { get; protected set; }
    public void AddError(string error) => ValidationResult.Errors.Add(new ValidationFailure(nameof(BookCommand), error));
    public bool IsValid() => ValidationResult is not null && ValidationResult.IsValid;
}