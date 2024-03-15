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
    public class AdminConfing: IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder) 
        { 
        }
    }
}
