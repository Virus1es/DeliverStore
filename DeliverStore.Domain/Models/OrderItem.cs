using CSharpFunctionalExtensions;
using DeliverStore.Domain.Shared;

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

    public static Result<Result<OrderItem>, Error> Create(Guid id, DateOnly deliverDate, Guid productId, int amount)
    {
        if (id == Guid.Empty)
            return Errors.General.ValueIsInvalid("Id");

        if (deliverDate.CompareTo(DateOnly.Parse($"{DateTime.Now:dd.MM.yyyy}")) > 0)
            return Errors.General.ValueIsInvalid("DeliverDate");

        if (productId == Guid.Empty)
            return Errors.General.ValueIsInvalid("ProductId");

        if (amount <= 0)
            return Errors.General.ValueIsInvalid("Amount");

        OrderItem orderItem = new(id, deliverDate, productId, amount);

        return Result.Success(orderItem);
    }
}
