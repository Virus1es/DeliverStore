namespace DeliverStore.Domain;

// сущность Товар
public class Product
{
    // Идентификатор
    public int Id { get; set; }

    // Название
    public string Name { get; set; }

    // Описание
    public string Description { get; set; }

    // Продавец
    public string Seller { get; set; }

    // Категория
    public string Category { get; set; }

    // Цена
    public double Price { get; set; }
}
