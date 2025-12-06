using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Infrastructure service registrations go here

        // TODO: Add services to the IoC container , Infrastructure services often include data access,
        // caching and other low-level services that support the application layer.

        services.AddTransient<IUserRepository, UserRepository>();
        return services;
    }
}