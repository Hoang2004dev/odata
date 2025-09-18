using Microsoft.Extensions.DependencyInjection;
using OdataAssignment.Application.Interfaces.Services;
using OdataAssignment.Application.Mapping;
using OdataAssignment.Application.Services;

namespace OdataAssignment.Application.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile).Assembly);

        services.AddScoped<ILocationService, LocationService>();
        services.AddScoped<IConfirmedService, ConfirmedService>();
        services.AddScoped<IDeathService, DeathService>();
        services.AddScoped<IRecoveredService, RecoveredService>();
        services.AddScoped<IDailyReportService, DailyReportService>();

        return services;
    }
}
