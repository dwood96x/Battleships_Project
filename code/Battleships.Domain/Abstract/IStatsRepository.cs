using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleships.Domain.Entities;

namespace Battleships.Domain.Abstract
{
    public interface IStatsRepository
    {
        IEnumerable<Stats> Stats { get; }
    }
}
