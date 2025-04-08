namespace DeliverStore.Domain.Models;

// сущность Покупка
public class OrderItem
{
    private OrderItem() { }

    public Guid Id { get; private set; }

    // Ориентировочная дата доставки
    public DateOnly DeliverDate { get; private set; }

    // Идентификатор товара
    public Guid ProductId { get; private set; }

    public int Amount { get; private set; }

    public static OrderItem CreateNewOrderItem(Guid id, DateOnly deliverDate, Guid productId, int amount)
    {
        return new OrderItem()
        {
            Id = id,
            DeliverDate = deliverDate,
            ProductId = productId,
            Amount = amount
        };
    }
}
