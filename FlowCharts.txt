POST

POST /api/tournaments
Body:
{
  "title": "Winter Cup",
  "description": "Snow tournament",
  "maxPlayers": 16,
  "date": "2026-12-10"
}

Client
  │
  ▼
Controller
  │
  │ 1️⃣ Tar emot TournamentCreateDTO
  │ 2️⃣ Validering sker (DataAnnotations)
  │ 3️⃣ Mappar DTO → Tournament (Model)
  ▼
Service
  │
  │ 4️⃣ _context.Tournaments.AddAsync()
  │ 5️⃣ await _context.SaveChangesAsync()
  ▼
DbContext (EF Core)
  │
  │ 6️⃣ Skapar SQL INSERT
  ▼
SQL Server
  │
  │ 7️⃣ Sparar i tabellen
  ▼
Controller
  │
  │ 8️⃣ Mappar Tournament → TournamentResponseDTO
  ▼
Client får tillbaka:
{
  "id": 1
}

--------------------------------------------------------

GET

GET /api/tournaments?search=Winter

Client
  │
  ▼
Controller
  │
  │ Tar emot query parameter: search
  ▼
Service
  │
  │ if(search != null)
  │    filtrera:
  │    .Where(t => t.Title.Contains(search))
  ▼
DbContext
  │
  │ Skapar SQL SELECT med WHERE
  ▼
SQL Server
  │
  │ Returnerar filtrerad lista
  ▼
Service
  │
  │ Returnerar lista
  ▼
Controller
  │
  │ Mappar till List<TournamentResponseDTO>
  ▼
Client får lista

--------------------------------------------------------

DTO

IN (POST/PUT)
Client → CreateDTO / UpdateDTO
              ↓
          Controller
              ↓
          Model (Tournament)
              ↓
          Service → Database

OUT (GET)
Database → Model (Tournament)
                ↓
           Controller
                ↓
        ResponseDTO → Client
