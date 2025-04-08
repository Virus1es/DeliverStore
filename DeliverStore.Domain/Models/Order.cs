namespace DeliverStore.Domain.Models;

public class Order
{
    public Guid Id { get; set; }

    // Идентификатор покупателя
    public int CustomerId { get; set; }

    // Дата заказа
    public DateTime OrderDate { get; set; }

    // Ожидаемая дата доставки
    public DateTime DeliverDate { get; set; }

    // Список покупок
    public List<OrderItem> OrderItems { get; set; }

    // Адрес доставки
    public string Address { get; set; }

    // Общая стоимость заказа
    public double Price { get; set; }
}
