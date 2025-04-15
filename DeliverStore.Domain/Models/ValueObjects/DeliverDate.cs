using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models.ValueObjects;

public record DeliverDate
{
    public DateOnly Value { get; }

    private DeliverDate(DateOnly value)
    {
        Value = value;
    }

    public static Result<DeliverDate, Error> Create(DateOnly value)
    {
        if (value.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Errors.General.ValueIsInvalid("DeliverDate");

        return new DeliverDate(value);
    }
}
