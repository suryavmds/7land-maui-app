namespace SevenLand.Models;

/// <summary>
/// Represents a customer order with product details, shipping info, and payment status.
/// </summary>
public class Order
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public List<Product> Products { get; set; } = new();
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public bool IsPaid { get; set; }
}