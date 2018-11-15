using Battleships.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Battleships.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("name=EFDbContext")
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserStats> UserStats { get; set; }

    }
}