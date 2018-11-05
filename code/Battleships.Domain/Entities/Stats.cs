using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Battleships.Domain.Entities
{
    public class Stats
    {
        [Display(Name = "Total games played: ")]
        public int TotalGames { get; }
        [Display(Name = "Games won: ")]
        public int GamesWon { get; }
        [Display(Name = "Games lost: ")]
        public int GamesLost { get; }
        [Display(Name = "Win/Loss ratio: ")]
        public int WinLossRatio
        {
            get => WinLossRatio;  set => WinLossRatio = GamesWon / GamesLost;  
        }
    }
}