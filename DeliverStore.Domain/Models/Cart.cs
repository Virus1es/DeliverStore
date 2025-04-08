namespace DeliverStore.Domain.Models;

public class Cart
{
    public Guid Id { get; set; }

    // Идентификатор на покупателя
    public int CustomerId { get; set; }

    // Список идентификаторов на OrderItem
    public List<int> OrderItemIds { get; set; }
}
