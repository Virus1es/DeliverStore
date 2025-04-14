using DeliverStore.Application.Modules.CreateProduct;
using Microsoft.Extensions.DependencyInjection;

namespace DeliverStore.Application;

public static class Inject
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<CreateProductHandler>();

        return services;
    }
}
