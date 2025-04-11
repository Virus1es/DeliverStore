using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Domain.Models;

public class Order
{
    private Order(Guid id, Guid customerId, DateOnly orderDate, DateOnly deliverDate, List<OrderItem> orderItems, string address, double totalPrice) 
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
    public DateOnly OrderDate { get; private set; }

    // Ожидаемая дата доставки
    public DateOnly DeliverDate { get; private set; }

    // Список покупок
    public List<OrderItem> OrderItems { get; private set; }

    // Адрес доставки
    public string Address { get; private set; }

    // Общая стоимость заказа
    public double TotalPrice { get; private set; }

    public static Result<Order, Error> Create(Guid id, Guid customerId, DateOnly orderDate, 
                                                      DateOnly deliverDate, List<OrderItem> orderItems, 
                                                      string address, double totalPrice)
    {
        if(id == Guid.Empty)
            return Errors.General.ValueIsInvalid("Id");

        if (customerId == Guid.Empty)
            return Errors.General.ValueIsInvalid("CustomerId");

        if (orderDate.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Errors.General.ValueIsInvalid("OrderDate");

        if (deliverDate.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Errors.General.ValueIsInvalid("DeliverDate");

        if (orderItems.Count == 0)
            return Errors.General.ValueIsInvalid("OrderItems");

        if (string.IsNullOrEmpty(address))
            return Errors.General.ValueIsInvalid("Address");

        if (totalPrice < 0d)
            return Errors.General.ValueIsInvalid("TotalPrice");

        return new Order(id, customerId, orderDate, deliverDate, orderItems, address, totalPrice);
    }
}
