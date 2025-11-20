using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GoodHamburguer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderDish>? OrderDishes { get; set; }

        // Keep for compatibility if needed, but it's computed from items below.
        public double discount { get => Discount; }

        // Computed discount (fractional): 0.20, 0.15, 0.10 or 0.0
        public double Discount
        {
            get
            {
                if (OrderDishes == null || OrderDishes.Count == 0)
                    return 0.0;

                bool hasSandwich = OrderDishes.Any(od => od.Dish != null && od.Dish.Type == DishType.Sandwich);
                bool hasFries = OrderDishes.Any(od => od.Dish != null && od.Dish.Type == DishType.Fries);
                bool hasDrink = OrderDishes.Any(od => od.Dish != null && od.Dish.Type == DishType.Drink);

                if (hasSandwich && hasFries && hasDrink)
                    return 0.20;
                if (hasSandwich && hasDrink)
                    return 0.15;
                if (hasSandwich && hasFries)
                    return 0.10;

                return 0.0;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                if (OrderDishes == null || OrderDishes.Count == 0)
                    return 0m;

                decimal total = OrderDishes.Sum(od => (decimal)od.Dish!.Price * od.Quantity);
                total -= total * (decimal)Discount;
                return total;
            }
        }

        // Method which limits one type of dish per order and no duplicate dishes, with clear exception messages.
        public void AddDish(Dish dish)
        {
            if (dish is null)
                throw new ArgumentNullException(nameof(dish));

            if (OrderDishes == null) OrderDishes = new List<OrderDish>();

            // Duplicate DishId
            if (OrderDishes.Any(od => od.DishId == dish.Id))
                throw new InvalidOperationException($"The item '{dish.Name ?? $"Id {dish.Id}"}' is already added to the order.");

            // Only one item of the same DishType allowed
            if (OrderDishes.Any(od => od.Dish != null && od.Dish.Type == dish.Type))
                throw new InvalidOperationException($"Only one {dish.Type} is allowed per order. Remove the existing {dish.Type} before adding a new one.");

            OrderDishes.Add(new OrderDish
            {
                Dish = dish,
                DishId = dish.Id,
                Order = this,
                OrderId = this.Id,
                Quantity = 1
            });
        }
    }
}
