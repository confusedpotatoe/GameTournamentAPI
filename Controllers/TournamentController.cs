using Microsoft.AspNetCore.Mvc;
using GameTournamentAPI.Services;
using GameTournamentAPI.Models;

namespace GameTournamentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TournamentController : Controller
    {
        private readonly ITournamentService _tournamentService;

        public TournamentController(ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? search)
        {
            var tournaments = await _tournamentService.GetAllAsync(search);
            return Ok(tournaments.Select(t => new { t.Id }));
        }

    }
}
