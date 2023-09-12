namespace MyShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public String OrderDate { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        //navigation property
        public Customer Customer { get; set; } = default!;
        //navigation property
        public List<OrderItem>? OrderItems { get; set;}
        public decimal TotalPrice { get; set; }
    }
}
