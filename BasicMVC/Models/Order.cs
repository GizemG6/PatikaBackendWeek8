namespace BasicMVC.Models
{
    public class Order
    {
        // order properties
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
