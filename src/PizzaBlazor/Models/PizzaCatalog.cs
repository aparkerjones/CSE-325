namespace PizzaBlazor.Models;

public static class PizzaCatalog
{
    public static IReadOnlyList<Pizza> All { get; } =
    [
        new Pizza(1, "Margherita", "Tomato, fresh mozzarella, basil, and olive oil.", 10.00m),
        new Pizza(2, "Pepperoni", "Classic tomato sauce, mozzarella, and pepperoni.", 12.50m),
        new Pizza(3, "Hawaiian", "Ham, pineapple, tomato sauce, and mozzarella.", 13.00m),
        new Pizza(4, "Veggie Garden", "Mushrooms, peppers, onions, spinach, and mozzarella.", 11.75m)
    ];
}