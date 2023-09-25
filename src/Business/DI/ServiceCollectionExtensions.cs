using Microsoft.Extensions.DependencyInjection;
using Suzim.Business.Abstract;
using Suzim.Common;
using Suzim.Store.Repositories.DI;

namespace Suzim.Business.DI;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBusinessModule(this IServiceCollection services)
    {
        services
            .AddRepositoriesModule()
            .AddAutoMapper(BusinessAssemblyReference.Assembly)
            .AddAsImplementedInterfacesAssignableTo<IBusinessService>(ServiceLifetime.Scoped);
            
        return services;
    }
}
