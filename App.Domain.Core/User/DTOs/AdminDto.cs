using App.Domain.Core.User.Entity;
using App.Domain.Core.User.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.User.DTOs
{
    public class AdminDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int AdminsId { get; set; }
        public Role Role { get; set; }
        public List<Admin> Admins { get; set; }
    }
}
