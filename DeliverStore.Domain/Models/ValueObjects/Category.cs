using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models.ValueObjects;

public record Category
{
    public const int MAX_LENGTH = 100;

    public string Value { get; }

    private Category(string value)
    {
        Value = value;
    }

    public static Result<Category, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return Errors.General.ValueIsInvalid("Category");

        return new Category(value);
    }
}
