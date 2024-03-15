using App.Domain.Core.User.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Book.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Author { get; set; }
        public string PressCompany { get; set; }
        public Admin Admin { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
