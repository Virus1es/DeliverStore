using DeliverStore.Application.Modules.CreateProduct;
using DeliverStore.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace DeliverStore.Web.Controllers;

public class ProductController : ApplicationController
{
    [HttpPost]
    public async Task<ActionResult<Guid>> Create(
        [FromServices] CreateProductHandler handler,
        [FromBody] CreateProductRequest request, CancellationToken cancellationToken)
    {
        var result = await handler.Handle(request, cancellationToken);

        return result.ToResponse();
    }
}
