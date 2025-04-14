using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverStore.Domain.Models.ValueObjects;

public record Address
{
    public const int MAX_LENGTH = 150;

    public string Value { get; }

    private Address(string value)
    {
        Value = value;
    }

    public static Result<Address, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return Errors.General.ValueIsInvalid("Address");

        return new Address(value);
    }
}
