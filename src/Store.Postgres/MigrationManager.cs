using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Suzim.Store.Postgres.DesignTime;

namespace Suzim.Store.Postgres;

public static class MigrationManager
{
    public static async Task MigrateSuzimSchema()
    {
        Console.WriteLine("Запуск миграции схемы СУЗИМ");

        await Migrate<SizumContextPostgres, SuzimContextPostgresFactory>().ConfigureAwait(false);

        Console.WriteLine("Успешно");
    }

    public static async Task MigrateIdentityScheme()
    {
        Console.WriteLine("Запуск миграции схемы Identity");

        await Migrate<IdentityContextPostgres, IdentityContextPostgresFactory>().ConfigureAwait(false);

        Console.WriteLine("Успешно");
    }

    private static async Task Migrate<TDbContext, TDbContextFactory>()
        where TDbContext : DbContext
        where TDbContextFactory : IDesignTimeDbContextFactory<TDbContext>, new()
    {
        var dbContextFactory = new TDbContextFactory();
        await using var dbContext = dbContextFactory.CreateDbContext(Array.Empty<string>());

        await dbContext.Database.MigrateAsync().ConfigureAwait(false);
    }
}