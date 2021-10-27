namespace TournamentSystem.Database.Entity
{
    public class Game
    {
        public int Id {get;set;}
        public virtual Team? TeamA {get;set;}
        public virtual Team? TeamB {get;set;}
        public virtual Team? Winner {get;set;}
        public string Score {get;set;}
    }
}