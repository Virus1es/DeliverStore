using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models.ValueObjects;

public record Seller
{
    public const int MAX_LENGTH = 100;

    public string Value { get; }

    private Seller(string value)
    {
        Value = value;
    }

    public static Result<Seller, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return Errors.General.ValueIsInvalid("Seller");

        return new Seller(value);
    }
}
