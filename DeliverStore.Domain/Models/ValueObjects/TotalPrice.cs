using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models.ValueObjects;

public record TotalPrice
{
    public const double MIN_PRICE = 0d;

    public double Value { get; }

    private TotalPrice(double value)
    {
        Value = value;
    }

    public static Result<TotalPrice, Error> Create(double value)
    {
        if (value < MIN_PRICE)
            return Errors.General.ValueIsInvalid("TotalPrice");

        return new TotalPrice(value);
    }
}
