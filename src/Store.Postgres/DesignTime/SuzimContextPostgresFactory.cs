using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Suzim.Store.Postgres.DesignTime.Abstract;

namespace Suzim.Store.Postgres.DesignTime;

internal sealed class SuzimContextPostgresFactory : ContextFactory<SizumContextPostgres>
{
    private const string ConnectionName = "SuzimConnection";

    protected override DbContextOptionsBuilder<SizumContextPostgres> CreateDbContextOptions()
    {
        return new DbContextOptionsBuilder<SizumContextPostgres>()
            .UseNpgsql(GetConnectionString());
    }

    protected override string GetConnectionString()
        => Configuration.GetConnectionString(ConnectionName)
           ?? throw new InvalidOperationException($"Не удалось получить строку подключения {ConnectionName}");
}
