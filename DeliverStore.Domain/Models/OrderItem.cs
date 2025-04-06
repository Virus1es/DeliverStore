namespace DeliverStore.Domain.Models;

// сущность Покупка
public class OrderItem
{
    // Идентификатор
    public int Id { get; set; }

    // Ориентировочная дата доставки
    public DateTime DeliverDate { get; set; }

    // Идентификатор товара
    public int ProductId { get; set; }

    // Количество
    public int Amount { get; set; }
}
