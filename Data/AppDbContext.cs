using Microsoft.EntityFrameworkCore;
using GameTournamentAPI.Models;

namespace GameTournamentAPI.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Tournament> Tournaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>() 
                .HasOne(p => p.Tournament) 
                .WithMany(t => t.Players) 
                .HasForeignKey(p => p.TournamentId)
                .OnDelete(DeleteBehavior.Cascade); 

            // seed data
            modelBuilder.Entity<Tournament>().HasData(
                new Tournament
                {
                    Id = 1,
                    Title = "Summer Showdown",
                    Description = "Open tournament for competitive players.",
                    MaxPlayers = 16,
                    Date = new DateTime(2026, 6, 15)
                },
                new Tournament
                {
                    Id = 2,
                    Title = "Winter Clash",
                    Description = "Indoor championship event.",
                    MaxPlayers = 8,
                    Date = new DateTime(2026, 12, 5)
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
