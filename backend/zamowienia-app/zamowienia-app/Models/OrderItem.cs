namespace zamowienia_app.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order order { get; set; }
        public int ProductId { get; set; }
        public Products products { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
