using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models.ValueObjects;

public record FullName
{
    public const int MAX_LENGTH = 150;

    public string Value { get; }

    private FullName(string value)
    {
        Value = value;
    }

    public static Result<FullName, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return Errors.General.ValueIsInvalid("FullName");

        return new FullName(value);
    }
}
