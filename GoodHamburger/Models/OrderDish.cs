using System.ComponentModel.DataAnnotations;

namespace GoodHamburguer.Models
{
    public class OrderDish
    {
        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int DishId { get; set; }
        public Dish? Dish { get; set; }

        // Cada associação representa um item selecionado: exatamente 1 unidade por tipo permitido.
        [Range(1, 1)]
        public int Quantity { get; set; } = 1;
    }
}