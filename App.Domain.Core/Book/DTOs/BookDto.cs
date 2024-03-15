using App.Domain.Core.Book.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Book.DTOs
{
    public class BookDto
    {
        public string Titel { get; set; }
        public string Author { get; set; }
        public string PressCompany { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
