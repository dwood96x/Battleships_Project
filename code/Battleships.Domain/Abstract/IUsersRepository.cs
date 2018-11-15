using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleships.Domain.Concrete;
using Battleships.Domain.Entities;

namespace Battleships.Domain.Abstract
{
    public interface IUsersRepository
    {
        IEnumerable<Users> Users { get; }
    }
}
