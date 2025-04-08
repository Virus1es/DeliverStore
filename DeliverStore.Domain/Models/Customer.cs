namespace DeliverStore.Domain.Models;

public class Customer
{
    public Guid Id { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string FullName { get; set; }

    public DateOnly Birthday { get; set; }
}
