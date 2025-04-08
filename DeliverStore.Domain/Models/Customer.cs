using CSharpFunctionalExtensions;

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

    public static Result Create(Guid id, string email, string phone, string fullName, DateOnly birthday)
    {
        if (id == Guid.Empty)
            return Result.Failure("Invalid Id for Customer");

        if (string.IsNullOrEmpty(email))
            return Result.Failure("Invalid Email for Customer");

        if (string.IsNullOrEmpty(phone))
            return Result.Failure("Invalid Phone for Customer");

        if (string.IsNullOrEmpty(fullName))
            return Result.Failure("Invalid FullName for Customer");

        if (birthday.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Result.Failure("Invalid Birthday for Customer");

        Customer customer = new(id, email, phone, fullName, birthday);

        return Result.Success(customer);
    }
}
