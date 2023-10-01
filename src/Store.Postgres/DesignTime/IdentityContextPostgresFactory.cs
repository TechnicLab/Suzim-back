using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Suzim.Store.Postgres.DesignTime.Abstract;

namespace Suzim.Store.Postgres.DesignTime;

internal sealed class IdentityContextPostgresFactory : ContextFactory<IdentityContextPostgres>
{
    private const string ConnectionName = "SuzimConnection";

    protected override DbContextOptionsBuilder<IdentityContextPostgres> CreateDbContextOptions()
    {
        return new DbContextOptionsBuilder<IdentityContextPostgres>()
            .UseNpgsql(GetConnectionString());
    }

    protected override string GetConnectionString()
        => Configuration.GetConnectionString(ConnectionName)
           ?? throw new InvalidOperationException($"Не удалось получить строку подключения {ConnectionName}");
}
