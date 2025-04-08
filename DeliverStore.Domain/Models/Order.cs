using CSharpFunctionalExtensions;

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

    public static Result Create(Guid id, Guid customerId, DateOnly orderDate, DateOnly deliverDate, List<OrderItem> orderItems, 
                                string address, double totalPrice)
    {
        if(id == Guid.Empty)
            return Result.Failure("Invalid Id for Order");

        if(customerId == Guid.Empty)
            return Result.Failure("Invalid CustomerId for Order");

        if (orderDate.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Result.Failure("Invalid OrderDate for Order");

        if (deliverDate.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Result.Failure("Invalid DeliverDate for Order");

        if (orderItems.Count == 0)
            return Result.Failure("Invalid OrderItems for Order");

        if (string.IsNullOrEmpty(address))
            return Result.Failure("Invalid Address for Order");

        if (totalPrice < 0d)
            return Result.Failure("Invalid TotalPrice for Order");

        Order order = new(id, customerId, orderDate, deliverDate, orderItems, address, totalPrice);

        return Result.Success(order);
    }
}
