# GameTournamentAPI
Du ska bygga ett komplett ASP.NET Web API där följande ingår: 📌 Controllers + Services + DI + DTO + CRUD-endpoints + Entity Framework Core med databaskoppling mot SQL Server

flow chart
                CLIENT (Frontend / Postman)
                          │
                          │  HTTP Request
                          ▼
                ┌──────────────────┐
                │   Controller     │
                │ (Thin layer)     │
                └──────────────────┘
                          │
                          │ Anropar
                          ▼
                ┌──────────────────┐
                │   Service        │
                │ (Business logic) │
                └──────────────────┘
                          │
                          │ Använder
                          ▼
                ┌──────────────────┐
                │   DbContext      │
                │ (EF Core ORM)    │
                └──────────────────┘
                          │
                          │ SQL genereras automatiskt
                          ▼
                ┌──────────────────┐
                │   SQL Server     │
                │   (Database)     │
                └──────────────────┘
