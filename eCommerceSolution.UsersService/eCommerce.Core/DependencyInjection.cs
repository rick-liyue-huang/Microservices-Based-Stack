using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        // Core service registrations go here
        // TODO: Add services to the IoC container , Core services often include business logic,
        // domain models, and application services that encapsulate the main functionality of the application.
        
        return services;
    }
}