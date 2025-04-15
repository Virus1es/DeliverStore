

using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models.ValueObjects;

public record Amount
{
    public int Value { get; }

    private Amount(int value)
    {
        Value = value;
    }

    public static Result<Amount, Error> Create(int value)
    {
        if (value <= 0)
            return Errors.General.ValueIsInvalid("Amount");

        return new Amount(value);
    }
}
