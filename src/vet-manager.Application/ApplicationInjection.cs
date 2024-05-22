using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using vet_manager.Application.Consultations;
using vet_manager.Application.Consultations.Services;
using vet_manager.Application.Consultations.Services.Impl;
using vet_manager.Application.Mapper;
using vet_manager.Application.Register.Services;
using vet_manager.Application.Register.Services.Impl;

namespace vet_manager.Application;

public static class ApplicationInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddServices(configuration)
            .RegisterAutoMapper();
        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IRegisterService, RegisterService>();
        services.AddScoped<IConsultationService, ConsultationService>();
        return services;
    }

    private static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Marker));
        return services;
    }
}