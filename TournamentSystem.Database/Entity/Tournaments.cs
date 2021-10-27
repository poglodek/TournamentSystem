using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentSystem.Database.Entity
{
    public class Tournament
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public double EntryFee {get;set;}
        public double MoneyPrize {get;set;}
        public virtual List<Team> Teams {get;set;}
        public virtual List<Round> Rounds {get;set;}
    }
}