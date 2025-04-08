namespace DeliverStore.Domain.Models;

public class Customer
{
    public Guid Id { get; private set; }

    public string Email { get; private set; }

    public string Phone { get; private set; }

    public string FullName { get; private set; }

    public DateOnly Birthday { get; private set; }
}
