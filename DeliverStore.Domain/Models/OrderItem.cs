namespace DeliverStore.Domain.Models;

// сущность Покупка
public class OrderItem
{
    public Guid Id { get; private set; }

    // Ориентировочная дата доставки
    public DateOnly DeliverDate { get; private set; }

    // Идентификатор товара
    public int ProductId { get; private set; }

    public int Amount { get; private set; }
}
