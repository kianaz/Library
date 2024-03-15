using App.Domain.Core.Book.Entity;
using App.Domain.Core.User.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.infra.DbContaxt.EF.Sql.DBcontaxt
{
    public class LibrariContaxt : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LMIEPJ0;Initial Catalog=Library;Integrated Security=True;Trust Server Certificate=True");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ApplyConfiguration(new EntityConfigoration.AdminConfing());
        //    modelBuilder.ApplyConfiguration(new EntityConfigoration.BookConfing());
        //    modelBuilder.ApplyConfiguration(new EntityConfigoration.UserConfing());

        //}
    }
}
