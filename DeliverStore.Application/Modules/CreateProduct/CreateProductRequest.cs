namespace DeliverStore.Application.Modules.CreateProduct;

public record CreateProductRequest(string Name, string Description, string Seller, string Category, double Price);
