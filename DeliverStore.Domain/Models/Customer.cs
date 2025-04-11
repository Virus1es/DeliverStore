using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models;

public class Customer
{
    private Customer(Guid id, string email, string phone, string fullName, DateOnly birthday) { 
        Id = id;
        Email = email;
        Phone = phone;
        FullName = fullName;
        Birthday = birthday;
    }

    public Guid Id { get; private set; }

    public string Email { get; private set; }

    public string Phone { get; private set; }

    public string FullName { get; private set; }

    public DateOnly Birthday { get; private set; }

    public static Result<Customer, Error> Create(Guid id, string email, string phone, string fullName, DateOnly birthday)
    {
        if (id == Guid.Empty)
            return Errors.General.ValueIsInvalid("Id");

        if (string.IsNullOrEmpty(email))
            return Errors.General.ValueIsInvalid("Email");

        if (string.IsNullOrEmpty(phone))
            return Errors.General.ValueIsInvalid("Phone");

        if (string.IsNullOrEmpty(fullName))
            return Errors.General.ValueIsInvalid("FullName");

        if (birthday.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Errors.General.ValueIsInvalid("Birthday");

        return new Customer(id, email, phone, fullName, birthday);
    }
}
