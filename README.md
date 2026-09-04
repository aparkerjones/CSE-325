# CSE 325 Week 01

This repository contains the Week 01 .NET assignment:

- `src/PizzaApi`: ASP.NET Core controller API with in-memory CRUD operations for pizzas.
- `src/SalesSummary`: console app that creates a formatted sales summary from text files.
- `NOTES.md`: API request and response evidence and the sales-summary function notes.

Both projects target .NET 8. Install the .NET 8 SDK before running them.

The repository includes `global.json` to select the .NET 8 SDK used for this assignment.

```powershell
dotnet run --project src/PizzaApi
dotnet run --project src/SalesSummary
```

The API is an in-memory example, so data resets whenever the application restarts.