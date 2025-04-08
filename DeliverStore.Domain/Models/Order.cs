namespace DeliverStore.Domain.Models;

public class Order
{
    public Guid Id { get; private set; }

    // Идентификатор покупателя
    public int CustomerId { get; private set; }

    // Дата заказа
    public DateOnly OrderDate { get; private set; }

    // Ожидаемая дата доставки
    public DateOnly DeliverDate { get; private set; }

    // Список покупок
    public List<OrderItem> OrderItems { get; private set; }

    // Адрес доставки
    public string Address { get; private set; }

    // Общая стоимость заказа
    public double TotalPrice { get; private set; }
}
