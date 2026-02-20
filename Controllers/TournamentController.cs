using Microsoft.AspNetCore.Mvc;
using GameTournamentAPI.Services;
using GameTournamentAPI.Models;

namespace GameTournamentAPI.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]

    public class TournamentController : ControllerBase
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
            return Ok(tournaments.Select(t => new {
            t.Id,
            t.Title,
            t.Description,
            t.Date,
            Players =t.Players.Select(p => new { p.Id, p.Name })
            }));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tournament = await _tournamentService.GetByIdAsync(id);
            if (tournament == null) return NotFound();
            return Ok(new {
                tournament.Id,
                tournament.Title,
                tournament.Description,
                tournament.Date,
                Players = tournament.Players.Select(p => new { p.Id, p.Name })
            });
        }

    }
}
