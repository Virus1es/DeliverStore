namespace DeliverStore.Domain.Models;

public class Order
{
    private Order() { }

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

    public static Order CreateNewOrder(Guid id, int customerId, DateOnly orderDate, DateOnly deliverDate, List<OrderItem> orderItems, string address, double totalPrice)
    {
        return new Order() { 
            Id = id, 
            CustomerId = customerId, 
            OrderDate = orderDate, 
            DeliverDate = deliverDate, 
            OrderItems = orderItems, 
            Address = address, 
            TotalPrice = totalPrice 
        };
    }
}
