namespace DeliverStore.Domain.Models;

// сущность Покупка
public class OrderItem
{
    public Guid Id { get; set; }

    // Ориентировочная дата доставки
    public DateTime DeliverDate { get; set; }

    // Идентификатор товара
    public int ProductId { get; set; }

    public int Amount { get; set; }
}
