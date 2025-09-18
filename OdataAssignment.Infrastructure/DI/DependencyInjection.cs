using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Infrastructure.Persistence;
using OdataAssignment.Infrastructure.Persistence.Repositories;

namespace OdataAssignment.Infrastructure.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CovidDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("CovidDatabase")));

        services.AddScoped<ILocationRepository, LocationRepository>();
        services.AddScoped<IConfirmedRepository, ConfirmedRepository>();
        services.AddScoped<IDeathRepository, DeathRepository>();
        services.AddScoped<IRecoveredRepository, RecoveredRepository>();
        services.AddScoped<IDailyReportRepository, DailyReportRepository>();

        return services;
    }
}
