using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace vet_manager.Application;

public static class ApplicationInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}