using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models.ValueObjects;

public record Birthday
{
    public const int MAX_LENGTH = 150;

    public DateOnly Value { get; }

    private Birthday(DateOnly value)
    {
        Value = value;
    }

    public static Result<Birthday, Error> Create(DateOnly value)
    {
        if (value.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Errors.General.ValueIsInvalid("Birthday");

        return new Birthday(value);
    }
}
