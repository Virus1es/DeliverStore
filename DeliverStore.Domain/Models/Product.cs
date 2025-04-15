using DeliverStore.Domain.Models.ValueObjects;

namespace DeliverStore.Domain.Models;

public class Product
{
    public Product(Guid id, Name name, Description description, Seller seller, Category category, Price price) {
        Id = id;
        Name = name;
        Description = description;
        Seller = seller;
        Category = category;
        Price = price;
    }

    public Guid Id { get; private set; }

    public Name Name { get; private set; } = default!;

    public Description Description { get; private set; } = default!;

    public Seller Seller { get; private set; } = default!;

    public Category Category { get; private set; } = default!;

    public Price Price { get; private set; }
}
