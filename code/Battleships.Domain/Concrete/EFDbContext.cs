using Battleships.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Battleships.Domain.Concrete
{
    public class EFDbContext : System.Data.Entity.DbContext
    {
        public EFDbContext()
            : base("name=EFDbContext")
        {
        }
        public DbSet<Login> Login { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Register> Register { get; set; }

    }
}