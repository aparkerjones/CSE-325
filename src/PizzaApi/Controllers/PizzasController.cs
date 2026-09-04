using Microsoft.AspNetCore.Mvc;
using PizzaApi.Models;

namespace PizzaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PizzasController : ControllerBase
{
    private static readonly List<Pizza> Pizzas =
    [
        new Pizza { Id = 1, Name = "Margherita", Price = 10.00m },
        new Pizza { Id = 2, Name = "Pepperoni", Price = 12.50m },
        new Pizza { Id = 3, Name = "Hawaiian", Price = 13.00m }
    ];

    [HttpGet]
    public ActionResult<IEnumerable<Pizza>> GetAll()
    {
        return Ok(Pizzas);
    }

    [HttpGet("{id}")]
    public ActionResult<Pizza> GetById(int id)
    {
        var pizza = Pizzas.FirstOrDefault(pizza => pizza.Id == id);
        return pizza is null ? NotFound() : Ok(pizza);
    }

    [HttpPost]
    public ActionResult<Pizza> Create(Pizza pizza)
    {
        var nextId = Pizzas.Count == 0 ? 1 : Pizzas.Max(existingPizza => existingPizza.Id) + 1;
        pizza.Id = nextId;
        Pizzas.Add(pizza);

        return CreatedAtAction(nameof(GetById), new { id = pizza.Id }, pizza);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza updatedPizza)
    {
        var pizza = Pizzas.FirstOrDefault(pizza => pizza.Id == id);
        if (pizza is null)
        {
            return NotFound();
        }

        pizza.Name = updatedPizza.Name;
        pizza.Price = updatedPizza.Price;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = Pizzas.FirstOrDefault(pizza => pizza.Id == id);
        if (pizza is null)
        {
            return NotFound();
        }

        Pizzas.Remove(pizza);
        return NoContent();
    }
}