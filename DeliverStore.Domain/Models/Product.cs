namespace DeliverStore.Domain.Models;

public class Product
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public string Seller { get; private set; }

    public string Category { get; private set; }

    public double Price { get; private set; }
}
