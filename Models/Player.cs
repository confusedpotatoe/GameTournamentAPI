namespace GameTournamentAPI.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //foreign key to tournament
        public int TournamentId { get; set; }

        //navigation property
        public Tournament? Tournament { get; set; }
    }
}
