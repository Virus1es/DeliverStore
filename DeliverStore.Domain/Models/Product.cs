using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models;

public class Product
{
    private Product(Guid id, string name, string description, string seller, string category, double price) {
        Id = id;
        Name = name;
        Description = description;
        Seller = seller;
        Category = category;
        Price = price;
    }

    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public string Seller { get; private set; }

    public string Category { get; private set; }

    public double Price { get; private set; }

    public static Result<Result<Product>, Error> Create(Guid id, string name, string description, string seller, string category, double price)
    {
        if(id == Guid.Empty)
            return Errors.General.ValueIsInvalid("Id");

        if (string.IsNullOrEmpty(name))
            return Errors.General.ValueIsInvalid("Name");

        if (string.IsNullOrEmpty(description))
            return Errors.General.ValueIsInvalid("Description");

        if (string.IsNullOrEmpty(seller))
            return Errors.General.ValueIsInvalid("Seller");

        if (string.IsNullOrEmpty(category))
            return Errors.General.ValueIsInvalid("Category");

        if (price < 0)
            return Errors.General.ValueIsInvalid("Price");

        Product product = new(id, name, description, seller, category, price);


        return Result.Success(product);
    }
}
