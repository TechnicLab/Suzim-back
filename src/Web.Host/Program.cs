
using Suzim.Store.Postgres;

namespace Suzim.Web.Host;

internal sealed class Program
{
    public static async Task Main(string[] args)
    {
        await MigrationManager.MigrateSuzimSchema();
        await MigrationManager.MigrateIdentityScheme();
      
        await CreateHostBuilder(args, b => ConfigureWebHostBuilder(b))
            .Build()
            .RunAsync();
    }

    private static IHostBuilder CreateHostBuilder(string[] args, Action<IWebHostBuilder> webHostBuilderConfigurator)
        => Microsoft.Extensions.Hosting.Host
            .CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webHostBuilderConfigurator);

    private static IWebHostBuilder ConfigureWebHostBuilder(IWebHostBuilder webHostBuilder)
        => webHostBuilder
            .UseStartup<Startup>();
}