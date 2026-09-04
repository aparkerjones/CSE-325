# CSE 325 Week 01 Assignment

## Part 1: Pizza API evidence

The API starts with the module records Margherita and Pepperoni and includes the additional record Hawaiian.

Run the API from `src/PizzaApi` with `dotnet run`. The controller uses an in-memory list, so each run starts with the three records above.

The smoke test was run against the built solution on September 4, 2026. The API was started with `http://localhost:5079`.

### GET

Request: `GET /api/pizzas`

Status: `200 OK`

Response:

```json
[
  { "id": 1, "name": "Margherita", "price": 10.00 },
  { "id": 2, "name": "Pepperoni", "price": 12.50 },
  { "id": 3, "name": "Hawaiian", "price": 13.00 }
]
```

### POST

Request: `POST /api/pizzas`

```json
{ "name": "Veggie", "price": 11.75 }
```

Status: `201 Created` (the API assigned ID `4`)

### PUT

Request: `PUT /api/pizzas/4`

```json
{ "name": "Veggie Deluxe", "price": 13.25 }
```

Status: `204 No Content`

### DELETE

Request: `DELETE /api/pizzas/4`

Status: `204 No Content`

## Part 2: Sales summary function

The working function is `SalesReport.Create` in `src/SalesSummary/Program.cs`. It reads every text file in the sales directory, calculates each file's total, calculates the grand total, and returns the formatted report text. The console application writes that text to `sales-summary.txt`.

With the included sample files, the report total is `$561.24`. The smoke test confirmed that `SalesSummary` generated the report successfully.