using App.Domain.Core.Book.DTOs;
using App.Domain.Core.Book.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Book.Contract.Repositori
{
    public interface IBookRepositoris
    {
        public List<BookDto> GetAllBook();
        public void AddBook(Book.Entity.Book book, BookDto bookDto);
        public void Delete(int id);
        public void UpDate(Book.Entity.Book book, BookDto bookDto);
    }
}
