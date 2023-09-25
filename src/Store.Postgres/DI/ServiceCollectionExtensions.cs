using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Suzim.Store.Common;

namespace Suzim.Store.Postgres.DI;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует контекст склада (имплементация Postgres)
    /// </summary>
    public static IServiceCollection AddWarehouseContextPostgres(this IServiceCollection services, string connectionName)
    {
        services.AddDbContextPool<SizumContextPostgres>((provider, builder) =>
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
