namespace GoodHamburguer.Models
{
    public class OrderSummaryDTO
    {
        public int orderId { get; set; }
        public string customer { get; set; }
        public List<OrderItemDTO> items { get; set; }
        public double total { get; set; }
    }
}
