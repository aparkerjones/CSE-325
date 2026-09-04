# CSE 325 Week 01 Assignment

This is my Week 01 assignment for CSE 325. It includes the two applications from the assignment:

- `src/PizzaApi` is a small ASP.NET Core API for managing pizzas.
- `src/SalesSummary` reads sales files and creates a summary report.

The API uses an in-memory list, so changes made through POST, PUT, and DELETE only last while the app is running. The starting pizza list includes the additional Hawaiian record required by the assignment.

Both projects target .NET 8. The `global.json` file selects the .NET 8 SDK used for this project.

```powershell
dotnet run --project src/PizzaApi
dotnet run --project src/SalesSummary
```

The sales program uses the files in `src/SalesSummary/sales-data` and writes `sales-summary.txt` to its build output directory. With the included data, the total is `$561.24`.

The API request examples and the sales-summary function are documented in [NOTES.md](NOTES.md).