using CSharpFunctionalExtensions;

namespace DeliverStore.Domain.Models;

// сущность Покупка
public class OrderItem
{
    private OrderItem(Guid id, DateOnly deliverDate, Guid productId, int amount) {
        Id = id;
        DeliverDate = deliverDate;
        ProductId = productId;
        Amount = amount;
    }

    public Guid Id { get; private set; }

    // Ориентировочная дата доставки
    public DateOnly DeliverDate { get; private set; }

    // Идентификатор товара
    public Guid ProductId { get; private set; }

    public int Amount { get; private set; }

    public static Result Create(Guid id, DateOnly deliverDate, Guid productId, int amount)
    {
        if (id == Guid.Empty)
            return Result.Failure("Invalid Id for OrderItem");

        if (deliverDate.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Result.Failure("Invalid DeliverDate for OrderItem");

        if (productId == Guid.Empty)
            return Result.Failure("Invalid ProductId for OrderItem");

        if (amount <= 0)
            return Result.Failure("Invalid Amount for OrderItem");

        OrderItem orderItem = new(id, deliverDate, productId, amount);

        return Result.Success(orderItem);
    }
}
