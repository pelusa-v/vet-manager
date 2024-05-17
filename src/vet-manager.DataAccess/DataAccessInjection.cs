using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using vet_manager.DataAccess.Repositories.Clients;
using vet_manager.DataAccess.Repositories.Consultations;
using vet_manager.DataAccess.Repositories.Consultations.Impl;

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
        services.AddScoped<IConsultationRepository, ConsultationRepository>();
        services.AddScoped<IConsultationCategoryRepository, ConsultationCategoryRepository>();
        services.AddScoped<IConsultationTypeRepository, ConsultationTypeRepository>();
        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<IPetRepository, PetRepository>();
        return services;
    }
}
