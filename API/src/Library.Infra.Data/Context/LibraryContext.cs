using System.Linq;
using System.Threading.Tasks;
using Library.Domain.Models;
using Library.Infra.Data.Mappings;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Library.Domain.Interfaces;

namespace Library.Infra.Data.Context;

public sealed class LibraryContext : DbContext, IUnitOfWork
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        ChangeTracker.AutoDetectChangesEnabled = false;
    }

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<ValidationResult>();

        modelBuilder.ApplyConfiguration(new BookMap());

        base.OnModelCreating(modelBuilder);
    }

    public async Task<bool> Commit()
    {
        var success = await SaveChangesAsync() > 0;

        return success;
    }
}
