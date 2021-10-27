using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TournamentSystem.Database.Entity;

namespace TournamentSystem.Database
{
    public class TournamentSystemDbContext : DbContext
    {
        public TournamentSystemDbContext()
        {
            
        }
     
        public TournamentSystemDbContext(DbContextOptions<TournamentSystemDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TournamentSystem;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
              modelBuilder.Entity<Game>()
                  .HasOne(x => x.TeamA)
                  .WithMany(x => x.TeamA);
            modelBuilder.Entity<Game>()
                .HasOne(x => x.TeamB)
                .WithMany(x => x.TeamB);
            modelBuilder.Entity<Game>()
                .HasOne(x => x.Winner)
                .WithMany(x => x.Winner);

        }

        private DbSet<Game> Games { get; set; }
        private DbSet<Round> Rounds { get; set; }
        private DbSet<Person> Persons { get; set; }
        private DbSet<Team> Teams { get; set; }
        private DbSet<Tournament> Tournaments { get; set; }
    }
}
