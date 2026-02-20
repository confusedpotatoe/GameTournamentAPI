using System;
using System.Collections.Generic;

namespace GameTournamentAPI.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int MaxPlayers { get; set; }
        public DateTime Date { get; set; }

        // one to many relationship with players
        public List<Player>? Players { get; set; } = new List<Player>();

    }
}
