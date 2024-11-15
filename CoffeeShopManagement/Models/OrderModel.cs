public class Order
{
    public int OrderId { get; set; }                  // Primary Key
    public DateTime OrderDate { get; set; }           // Date of Order
    public int CustomerId { get; set; }               // Foreign Key to Customer
    public Customer Customer { get; set; }            // Navigation Property
    public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();



}
