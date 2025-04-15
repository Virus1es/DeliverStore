using CSharpFunctionalExtensions;
using DeliverStore.Domain.Models;
using DeliverStore.Domain.Models.ValueObjects;
using DeliverStore.Domain.Shared;

namespace DeliverStore.Application.Modules.CreateProduct;

public class CreateProductHandler
{
    public async Task<Result<Guid, Error>> Handle(CreateProductRequest request, CancellationToken cancellationToken = default)
    {
        var productId = Guid.NewGuid();

        var nameResult = Name.Create(request.Name);
        if (nameResult.IsFailure)
            return nameResult.Error;

        var descriptionResult = Description.Create(request.Description);
        if (descriptionResult.IsFailure)
            return descriptionResult.Error;

        var sellerResult = Seller.Create(request.Seller);
        if (sellerResult.IsFailure)
            return sellerResult.Error;

        var categoryResult = Category.Create(request.Category);
        if (categoryResult.IsFailure)
            return categoryResult.Error;

        var priceResult = Price.Create(request.Price);
        if (priceResult.IsFailure)
            return priceResult.Error;


        var product = new Product(productId, nameResult.Value, descriptionResult.Value, sellerResult.Value, categoryResult.Value, priceResult.Value);

        // сохранение в БД

        return product.Id;
    }

}
