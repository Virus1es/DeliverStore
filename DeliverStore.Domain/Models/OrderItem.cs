using DeliverStore.Domain.Models.ValueObjects;

namespace DeliverStore.Domain.Models;

// сущность Покупка
public class OrderItem
{
    public OrderItem(Guid id, DeliverDate deliverDate, Guid productId, Amount amount) {
        Id = id;
        DeliverDate = deliverDate;
        ProductId = productId;
        Amount = amount;
    }

    public Guid Id { get; private set; }

    // Ориентировочная дата доставки
    public DeliverDate DeliverDate { get; private set; }

    // Идентификатор товара
    public Guid ProductId { get; private set; }

    public Amount Amount { get; private set; }
}
