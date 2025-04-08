namespace DeliverStore.Domain.Models;

public class Cart
{
    public Guid Id { get; private set; }

    // Идентификатор на покупателя
    public int CustomerId { get; private set; }

    // Список идентификаторов на OrderItem
    public List<int> OrderItemIds { get; private set; }
}
