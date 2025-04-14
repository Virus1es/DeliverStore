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
            return Errors.General.ValueIsInvalid("Name");

        var descriptionResult = Description.Create(request.Description);
        if (descriptionResult.IsFailure)
            return Errors.General.ValueIsInvalid("Description");

        var sellerResult = Seller.Create(request.Seller);
        if (sellerResult.IsFailure)
            return Errors.General.ValueIsInvalid("Seller");

        var categoryResult = Category.Create(request.Category);
        if (categoryResult.IsFailure)
            return Errors.General.ValueIsInvalid("Category");

        var priceResult = Price.Create(request.Price);
        if (priceResult.IsFailure)
            return Errors.General.ValueIsInvalid("Price");


        var productResult = Product.Create(productId, nameResult.Value, descriptionResult.Value, sellerResult.Value, categoryResult.Value, priceResult.Value);
        if (productResult.IsFailure)
            return Errors.General.ValueIsInvalid("Product");

        var product = productResult.Value;


        return product.Id;
    }

}
