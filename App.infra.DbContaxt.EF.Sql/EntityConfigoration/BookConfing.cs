using App.Domain.Core.Book.Entity;
using App.Domain.Core.User.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.infra.DbContaxt.EF.Sql.EntityConfigoration
{
    public class BookConfing : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(p => p.Category)
               .WithMany(p => p.Books);
            builder.HasOne(p => p.Admin)
              .WithMany(p => p.Books);
        }
    }
}
