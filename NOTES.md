# CSE 325 Week 01 Notes

## Pizza API

I started with the pizza records from the Microsoft Learn example and added Hawaiian as the extra record required by the assignment. The API is backed by an in-memory list, so it resets to these records whenever it starts.

I smoke-tested the API on September 4, 2026. I ran it at `http://localhost:5079` and checked each CRUD operation below.

The smoke test was run against the built solution on September 4, 2026. The API was started with `http://localhost:5079`.

### GET

Request: `GET /api/pizzas`

Status: `200 OK`

Response from the initial request:

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

The API returned `201 Created` and assigned the new pizza ID `4`.

### PUT

Request: `PUT /api/pizzas/4`

```json
{ "name": "Veggie Deluxe", "price": 13.25 }
```

The API returned `204 No Content`.

### DELETE

Request: `DELETE /api/pizzas/4`

The API returned `204 No Content`.

## Sales summary

The sales-summary code is in `SalesReport.Create` in `src/SalesSummary/Program.cs`. It reads each text file in the sales-data directory, adds the values in each file, and builds a report with the total for each file and the combined total. The console application writes the report to `sales-summary.txt` in the build output directory.

I ran the console project after building the solution. It generated the report successfully, and the total from the included files was `$561.24`.