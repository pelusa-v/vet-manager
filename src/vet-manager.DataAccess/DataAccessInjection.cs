using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace vet_manager.DataAccess;

public static class DataAccessInjection
{
    public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
    {
        var dbConnectionString = configuration.GetConnectionString("Database");
        services
            .AddDbContext<AppDbContext>(options =>
                options.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString)))
            .AddRepositories(configuration);
        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
