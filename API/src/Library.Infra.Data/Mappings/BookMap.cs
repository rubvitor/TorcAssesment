using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Library.Domain.Models;

namespace Library.Infra.Data.Mappings
{    
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(c => c.BookId)
                .HasColumnName("book_id");

            builder.Property(c => c.Title)
                .HasColumnName("title")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.FirstName)
                .HasColumnName("first_name")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.LastName)
               .HasColumnName("last_name")
               .HasColumnType("varchar(50)")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(c => c.TotalCopies)
                .HasColumnName("total_copies")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(c => c.CopiesInUse)
                .HasColumnName("copies_in_use")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(c => c.Type)
               .HasColumnName("type")
               .HasColumnType("varchar(50)")
               .HasMaxLength(50);

            builder.Property(c => c.ISBN)
              .HasColumnName("isbn")
              .HasColumnType("varchar(80)")
              .HasMaxLength(80);

            builder.Property(c => c.Category)
              .HasColumnName("category")
              .HasColumnType("varchar(50)")
              .HasMaxLength(50);
        }
    }
}
