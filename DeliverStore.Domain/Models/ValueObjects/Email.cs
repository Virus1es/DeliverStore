using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;
using System.Text.RegularExpressions;

namespace DeliverStore.Domain.Models.ValueObjects;

public record Email
{
    public const int MAX_LENGTH = 100;

    public const string REG_VALIDATOR = @"^\w+@\w+\.\w+";

    public string Value { get; }

    private Email(string value)
    {
        Value = value;
    }

    public static Result<Email, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH || Regex.IsMatch(value, REG_VALIDATOR))
            return Errors.General.ValueIsInvalid("Email");

        return new Email(value);
    }
}
