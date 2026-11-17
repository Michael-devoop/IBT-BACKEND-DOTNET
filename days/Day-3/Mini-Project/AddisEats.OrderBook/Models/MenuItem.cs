namespace AddisEats.OrderBook.Models;

public record MenuItem
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Category { get; init; }
    public decimal Price { get; init; }

    public MenuItem(int id, string name, string category, decimal price)
    {
        if (price <= 0)
        {
            throw new ArgumentException("Price must be greater than zero.");
        }

        Id = id;
        Name = name;
        Category = category;
        Price = price;
    }
}