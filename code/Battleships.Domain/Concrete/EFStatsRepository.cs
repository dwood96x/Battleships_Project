using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleships.Domain.Abstract;
using Battleships.Domain.Entities;

namespace Battleships.Domain.Concrete
{
    public class EFStatsRepository : IStatsRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Stats> Stats
        {
            get { return context.Stats; }
        }
    }
}
