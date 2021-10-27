namespace TournamentSystem.Database.Entity
{
    public class Round
    {
        public int Id {get;set;}
        public virtual List<Team> Teams {get;set;}
        public virtual List<Game> Games {get;set;}
        public virtual Tournament Tournament {get;set;}
    }
}