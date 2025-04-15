using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models;

public class Cart
{
    private List<Guid> _orderItemIds => [];

    public Cart(Guid id, Guid customerId) { 
        Id = id; 
        CustomerId = customerId;
    }

    public Guid Id { get; private set; }

    // Идентификатор на покупателя
    public Guid CustomerId { get; private set; }

    // Список идентификаторов на OrderItem
    public IReadOnlyList<Guid> OrderItemIds => _orderItemIds;
}
