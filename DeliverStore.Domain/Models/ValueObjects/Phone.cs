using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;
using System.Text.RegularExpressions;

namespace DeliverStore.Domain.Models.ValueObjects;

public record Phone
{
    public const int MAX_LENGTH = 20;

    public const string REG_VALIDATOR = @"^\+[0-9]{5,12}$";

    public string Value { get; }

    private Phone(string value)
    {
        Value = value;
    }

    public static Result<Phone, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH || Regex.IsMatch(value, REG_VALIDATOR))
            return Errors.General.ValueIsInvalid("Email");

        return new Phone(value);
    }
}
