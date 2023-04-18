using Library.Domain.Interfaces;
using Library.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Services.Api.Configurations;

public static class DatabaseConfig
{
    public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        services.AddEntityFrameworkInMemoryDatabase();
        services.AddDbContext<LibraryContext>((sp, options) =>
        {
            options.UseInMemoryDatabase("Library").UseInternalServiceProvider(sp);
        });
    }

    public static void PopulateDatabase(this WebApplication webApplication)
    {
        using var scope = webApplication.Services.CreateScope();

        var bookRepository = scope.ServiceProvider.GetRequiredService<IBookRepository>();

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "To Kill a Mockingbird",
            FirstName = "Harper",
            LastName = "Lee",
            TotalCopies = 75,
            CopiesInUse = 65,
            Type = "Paperback",
            ISBN = "1234567892",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "The Catcher in the Rye",
            FirstName = "J.D.",
            LastName = "Salinger",
            TotalCopies = 50,
            CopiesInUse = 45,
            Type = "Hardcover",
            ISBN = "1234567893",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "The Great Gatsby",
            FirstName = "F. Scott",
            LastName = "Fitzgerald",
            TotalCopies = 50,
            CopiesInUse = 22,
            Type = "Hardcover",
            ISBN = "1234567894",
            Category = "Non-Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "The Alchemist",
            FirstName = "Paulo",
            LastName = "Coelho",
            TotalCopies = 50,
            CopiesInUse = 35,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.Add(new Domain.Models.Book
        {
            Title = "Pride and Prejudice",
            FirstName = "Jane",
            LastName = "Austen",
            TotalCopies = 100,
            CopiesInUse = 80,
            Type = "Hardcover",
            ISBN = "1234567891",
            Category = "Fiction"
        });

        bookRepository.UnitOfWork.Commit();
    }
}