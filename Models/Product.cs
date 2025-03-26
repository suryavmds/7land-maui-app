namespace SevenLand.Models;

/// <summary>
/// Represents a product in the e-commerce store.
/// Includes details like name, price, and stock availability.
/// </summary>
public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal MaximumPrice { get; set; }
    public int StockQuantity { get; set; }
    public string ImageUrl { get; set; }
}