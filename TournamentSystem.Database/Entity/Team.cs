using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentSystem.Database.Entity
{
    public class Team
    {
        public int Id {get;set;}
        public string TeamName {get;set;}
        public virtual List<Person> TeamMates {get;set;}
        public virtual List<Tournament> Tournaments {get;set;}
        public virtual List<Round> Rounds {get;set;}
        public virtual List<Game>? TeamA {get;set;}
        public virtual List<Game>? TeamB {get;set;}
        public virtual List<Game>? Winner {get;set;}
    }
}