using CSharpFunctionalExtensions;

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

    public static Result Create(Guid id, string name, string description, string seller, string category, double price)
    {
        if(id == Guid.Empty)
            return Result.Failure("Invalid Id for Product");

        if (string.IsNullOrEmpty(name))
            return Result.Failure("Invalid Name for Product");

        if (string.IsNullOrEmpty(description))
            return Result.Failure("Invalid Description for Product");

        if (string.IsNullOrEmpty(seller))
            return Result.Failure("Invalid Seller for Product");

        if (string.IsNullOrEmpty(category))
            return Result.Failure("Invalid Category for Product");

        if(price < 0)
            return Result.Failure("Invalid Price for Product");

        Product product = new(id, name, description, seller, category, price);


        return Result.Success(product);
    }
}
