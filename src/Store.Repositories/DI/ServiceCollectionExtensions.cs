using Microsoft.Extensions.DependencyInjection;
using Suzim.Common;

namespace Suzim.Store.Repositories.DI;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositoriesModule(this IServiceCollection services)
    {
        services
            .AddAsImplementedInterfacesAssignableTo<IDbRepository>(ServiceLifetime.Transient);

        return services;
    }
}
