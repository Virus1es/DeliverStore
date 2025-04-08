namespace DeliverStore.Domain.Models;

public class Cart
{
    public Guid Id { get; set; }

    // Идентификатор на покупателя
    public Guid CustomerId { get; set; }

    // Список идентификаторов на OrderItem
    public List<Guid> OrderItemIds { get; set; }
}
