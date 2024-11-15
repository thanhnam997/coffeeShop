public class Customer
{
    public int CustomerId { get; set; }      // Primary Key
    public string Name { get; set; }         // Customer Name
    public string Email { get; set; }        // Customer Email
    public string Phone { get; set; }        // Customer Phone

// Navigation Property for One-to-Many relationship with Orders
    public List<Order> Orders { get; set; } = new List<Order>();



}
