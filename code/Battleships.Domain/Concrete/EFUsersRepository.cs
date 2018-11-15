using Battleships.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Domain.Concrete
{
    public class EFUsersRepository : IUsersRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Users> Users
        {
            get { return context.Users; }
        }
    }
}
