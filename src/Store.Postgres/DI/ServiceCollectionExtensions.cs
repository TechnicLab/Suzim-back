using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Suzim.Store.Common;

namespace Suzim.Store.Postgres.DI;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует контекст СУЗИМ (имплементация Postgres)
    /// </summary>
    public static IServiceCollection AddSuzimContextPostgres(this IServiceCollection services, string connectionName)
    {
        services.AddDbContext<SizumContextPostgres>((provider, builder) =>
        {
            var connectionString = provider.GetRequiredService<IConfiguration>()
                                       .GetConnectionString(connectionName)
                                   ?? throw new InvalidOperationException($"Не удалось получить строку подключения: {connectionName}");

            builder.UseNpgsql(connectionString);
        });
        
        services.AddDbContext<IdentityContextPostgres>((provider, builder) =>
        {
            var connectionString = provider.GetRequiredService<IConfiguration>()
                                       .GetConnectionString(connectionName)
                                   ?? throw new InvalidOperationException($"Не удалось получить строку подключения: {connectionName}");

            builder.UseNpgsql(connectionString);
        });

        services.AddScoped<ISuzimContext>(provider => provider.GetRequiredService<ISuzimContext>());
        
        return services;
    }
}
