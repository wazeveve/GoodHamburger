using System.ComponentModel.DataAnnotations;

namespace GoodHamburguer.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        public decimal Price { get; set; }

        public DishType Type { get; set; }

        public List<OrderDish>? OrderDishes { get; set; }


    }
}
