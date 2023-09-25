using Microsoft.OpenApi.Models;

namespace Suzim.Web.Host.Infrastructure;

internal static class SwaggerExtensions
{
    internal static IServiceCollection AddSwaggerServices(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "СУЗИМ API",
                Version = "v1",
                Description = "Api СУЗИМ"
            });
            var xmlFile = $"{WebAssemblyReference.Assembly.GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            options.IncludeXmlComments(xmlPath);
        });

        return services;
    }
}
