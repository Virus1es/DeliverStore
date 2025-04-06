namespace DeliverStore.Domain;

// сущность Корзина
public class Cart
{
    // Идентификатор
    public int Id { get; set; }

    // Идентификатор на покупателя
    public int CustomerId { get; set; }

    // Список идентификаторов на OrderItem
    public List<int> OrderItemsId { get; set; }
}
