namespace DeliverStore.Domain.Models;

public class Product
{
    private Product() { }

    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public string Seller { get; private set; }

    public string Category { get; private set; }

    public double Price { get; private set; }

    public static Product CreateNewProduct(Guid id, string name, string description, string seller, string category, double price)
    {
        return new Product() { 
            Id = id, 
            Name = name, 
            Description = description, 
            Seller = seller, 
            Category = category, 
            Price = price 
        };
    }
}
