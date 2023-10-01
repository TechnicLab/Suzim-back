using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Suzim.Store.Postgres.DesignTime.Abstract;

internal abstract class ContextFactory<TDbContext>
    : IDesignTimeDbContextFactory<TDbContext> where TDbContext : DbContext
{
    private TDbContext CreateContext(DbContextOptionsBuilder<TDbContext> options)
        => (TDbContext?)Activator.CreateInstance(typeof(TDbContext), options.Options)
           ?? throw new InvalidOperationException();

    public TDbContext CreateDbContext(string[] args) => CreateContext(CreateDbContextOptions());

    protected abstract DbContextOptionsBuilder<TDbContext> CreateDbContextOptions();

    protected abstract string GetConnectionString();

    protected IConfiguration Configuration =>
        new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
}
