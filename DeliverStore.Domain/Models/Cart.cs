using CSharpFunctionalExtensions;

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

    public static Result Create(Guid id, Guid customerId)
    {
        if (id == Guid.Empty)
            Result.Failure("Invalid Id");

        if (customerId == Guid.Empty)
            Result.Failure("Invalid CustomerId for Cart");

        Cart cart = new(id, customerId);

        return Result.Success(cart);
    }
}
