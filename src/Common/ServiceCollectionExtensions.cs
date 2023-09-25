using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Suzim.Common;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Зарегистрировать типы, реализующие интерфейсы, помеченные маркерным интерфейсом.
    /// </summary>
    /// <param name="lifetime">Время жизни объекта</param>
    /// <typeparam name="TMarkerInterface">Тип маркерного интерфейса</typeparam>
    public static IServiceCollection AddAsImplementedInterfacesAssignableTo<TMarkerInterface>(
        this IServiceCollection services,
        ServiceLifetime lifetime)
    {
        var types = typeof(TMarkerInterface).Assembly.GetTypes()
            .Where(type => typeof(TMarkerInterface).IsAssignableFrom(type) && !type.IsAbstract);

        foreach (var type in types)
        {
            services.AddAsImplementedInterfaces(type, lifetime);
        }

        return services;
    }

    /// <summary>
    /// Зарегистрировать типы, реализующие интерфейсы, помеченные маркерным интерфейсом.
    /// </summary>
    /// <param name="lifetime">Время жизни объекта</param>
    /// <typeparam name="TMarkerInterface">Тип маркерного интерфейса</typeparam>
    public static IServiceCollection AddAsImplementedInterfacesAssignableTo<TMarkerInterface>(
        this IServiceCollection services, Assembly assembly,
        ServiceLifetime lifetime)
    {
        var types = assembly.GetTypes()
            .Where(type => typeof(TMarkerInterface).IsAssignableFrom(type) && !type.IsAbstract);

        foreach (var type in types)
        {
            services.AddAsImplementedInterfaces(type, lifetime);
        }

        return services;
    }


    /// <summary>
    /// Зарегистрировать сервисы, реализующий интерфейс
    /// </summary>
    /// <param name="lifetime">Время жизни объекта</param>
    /// <typeparam name="TInterface">Тип интерфейса</typeparam>
    public static IServiceCollection AddAssignableTo<TInterface>(
        this IServiceCollection services,
        ServiceLifetime lifetime)
    {
        var types = typeof(TInterface).Assembly.GetTypes()
            .Where(type => typeof(TInterface).IsAssignableFrom(type) && !type.IsAbstract);

        foreach (var type in types)
        {
            services.AddAs<TInterface>(type, lifetime);
        }

        return services;
    }

    /// <summary>
    /// Зарегистрировать сервисы, реализующий интерфейс
    /// </summary>
    /// <param name="lifetime">Время жизни объекта</param>
    /// <typeparam name="TInterface">Тип интерфейса</typeparam>
    public static IServiceCollection AddAssignableTo<TInterface>(
        this IServiceCollection services, Assembly assembly,
        ServiceLifetime lifetime)
    {
        var types = assembly.GetTypes()
            .Where(type => typeof(TInterface).IsAssignableFrom(type) && !type.IsAbstract);

        foreach (var type in types)
        {
            services.AddAs<TInterface>(type, lifetime);
        }

        return services;
    }

    private static IServiceCollection AddAsImplementedInterfaces(this IServiceCollection services, Type type, ServiceLifetime lifetime)
    {
        var interfaces = type.GetInterfaces();
        var assignableInterfaces = interfaces.Where(i => i.IsAssignableFrom(type));
        foreach (var interfaceType in assignableInterfaces)
        {
            services.Add(new ServiceDescriptor(interfaceType, type, lifetime));
        }

        return services;
    }

    private static IServiceCollection AddAs<T>(this IServiceCollection services, Type type, ServiceLifetime lifetime)
    {
        services.Add(new ServiceDescriptor(typeof(T), type, lifetime));

        return services;
    }

}
