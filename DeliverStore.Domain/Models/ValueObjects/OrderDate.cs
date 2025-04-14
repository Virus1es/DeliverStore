using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models.ValueObjects;

public record OrderDate
{
    public DateOnly Value { get; }

    private OrderDate(DateOnly value)
    {
        Value = value;
    }

    public static Result<OrderDate, Error> Create(DateOnly value)
    {
        if (value.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Errors.General.ValueIsInvalid("OrderDate");

        return new OrderDate(value);
    }
}
