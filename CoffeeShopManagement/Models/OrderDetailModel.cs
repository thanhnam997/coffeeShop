public class OrderDetail
{
    public int OrderDetailId { get; set; }       // Primary Key
    public int OrderId { get; set; }             // Foreign Key to Order
    public Order Order { get; set; }             // Navigation Property to Order
    public int ProductId { get; set; }           // Foreign Key to Product
    public Product Product { get; set; }         // Navigation Property to Product
    public int Quantity { get; set; }            // Quantity Ordered
}
