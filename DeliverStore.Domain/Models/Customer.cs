namespace DeliverStore.Domain.Models;

public class Customer
{
    private Customer() { }

    public Guid Id { get; private set; }

    public string Email { get; private set; }

    public string Phone { get; private set; }

    public string FullName { get; private set; }

    public DateOnly Birthday { get; private set; }

    public static Customer CreateNewCustomer(Guid id, string email, string phone, string fullName, DateOnly birthday)
    {
        return new Customer()
        {
            Id = id,
            Email = email,
            Phone = phone,
            FullName = fullName,
            Birthday = birthday
        };
    }
}
