namespace DeliverStore.Domain;

// сущность покупатель
public class Customer
{
    // Идентификатор
    public int Id { get; set; }

    // Почта
    public string Mail { get; set; }

    // Номер телефона
    public string Phone { get; set; }

    // ФИО
    public string FullName { get; set; }

    // Дата рождения
    public DateOnly Birthday { get; set; }
}
