using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models;

public class Cart
{
    private List<Guid> _orderItemIds => [];

    private Cart(Guid id, Guid customerId) { 
        Id = id; 
        CustomerId = customerId;
    }

    public Guid Id { get; private set; }

    // Идентификатор на покупателя
    public Guid CustomerId { get; private set; }

    // Список идентификаторов на OrderItem
    public IReadOnlyList<Guid> OrderItemIds => _orderItemIds;

    public static Result<Result<Cart>, Error> Create(Guid id, Guid customerId)
    {
        if (id == Guid.Empty)
            return Errors.General.ValueIsInvalid("Id");

        if (customerId == Guid.Empty)
            return Errors.General.ValueIsInvalid("CustomerId");

        Cart cart = new(id, customerId);

        return Result.Success(cart);
    }
}
