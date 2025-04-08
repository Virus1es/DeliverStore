using CSharpFunctionalExtensions;

namespace DeliverStore.Domain.Models;

public class Cart
{
    private Cart() { }

    public Guid Id { get; private set; }

    // Идентификатор на покупателя
    public int CustomerId { get; private set; }

    // Список идентификаторов на OrderItem
    public List<int> OrderItemIds { get; private set; }

    public static Cart CreateNewCart(Guid id, int customerId, List<int> orderItemIds)
    {
        return new Cart() {
            Id = id, 
            CustomerId = customerId, 
            OrderItemIds = orderItemIds 
        };
    }
}
