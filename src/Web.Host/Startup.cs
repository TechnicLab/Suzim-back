using Microsoft.AspNetCore.Identity;
using Suzim.Store.Common;
using Suzim.Store.Postgres;
using Suzim.Store.Postgres.DI;
using Suzim.Web.Host.Infrastructure;

namespace Suzim.Web.Host;

internal sealed class Startup
{
    private readonly IConfiguration configuration;

    public Startup(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        //
        services.AddSuzimContextPostgres("SuzimConnection");

        services.AddDefaultIdentity<IdentityUser>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<IdentityContextPostgres>();
        
        // services.AddBusinessModule();
        // services.AddAutoMapper(WebAssemblyReference.Assembly);
        //
        // services.AddFluentValidationAutoValidation()
        //     .AddFluentValidationClientsideAdapters();
        // services.AddValidatorsFromAssembly(WebAssemblyReference.Assembly);
        services.AddSwaggerServices();
    }

    public static void Configure(IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            options.RoutePrefix = string.Empty;
        });
        
        app.UseRouting();
        
        app.UseAuthorization();
        app.UseAuthentication();

        app.UseEndpoints(options =>
            options.MapControllers());
    }
}
