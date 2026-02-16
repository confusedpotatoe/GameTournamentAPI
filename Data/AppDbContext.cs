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
    }
}
