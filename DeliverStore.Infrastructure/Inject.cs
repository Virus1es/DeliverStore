using Microsoft.Extensions.DependencyInjection;

namespace DeliverStore.Infrastructure;

public static class Inject
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // services.AddScoped<AppDbContext>();

        // services.AddScoped<IModulesRepository, ModulesRepository>();

        return services;
    }
}
