using CSharpFunctionalExtensions;
using DeliverStore.Domain.Models.ValueObjects;

namespace DeliverStore.Domain.Models;

public class Customer
{
    public Customer(Guid id, Email email, Phone phone, FullName fullName, Birthday birthday) { 
        Id = id;
        Email = email;
        Phone = phone;
        FullName = fullName;
        Birthday = birthday;
    }

    public Guid Id { get; private set; }

    public Email Email { get; private set; }

    public Phone Phone { get; private set; }

    public FullName FullName { get; private set; }

    public Birthday Birthday { get; private set; }
}
