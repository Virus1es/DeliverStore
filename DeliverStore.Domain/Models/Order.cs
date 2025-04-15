using DeliverStore.Domain.Models.ValueObjects;

namespace DeliverStore.Domain.Models;

public class Order
{
    public Order(Guid id, Guid customerId, OrderDate orderDate, DeliverDate deliverDate, List<OrderItem> orderItems, 
                  Address address, TotalPrice totalPrice) 
    {
        Id = id;
        CustomerId = customerId;
        OrderDate = orderDate;
        DeliverDate = deliverDate;
        OrderItems = orderItems;
        Address = address;
        TotalPrice = totalPrice;
    }

    public Guid Id { get; private set; }

    // Идентификатор покупателя
    public Guid CustomerId { get; private set; }

    // Дата заказа
    public OrderDate OrderDate { get; private set; }

    // Ожидаемая дата доставки
    public DeliverDate DeliverDate { get; private set; }

    // Список покупок
    public List<OrderItem> OrderItems { get; private set; }

    // Адрес доставки
    public Address Address { get; private set; }

    // Общая стоимость заказа
    public TotalPrice TotalPrice { get; private set; }
}
