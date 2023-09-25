using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Suzim.Store.Common.Contracts;

namespace Suzim.Store.Postgres.Extensions;

internal static class ConfigurationExtensions
{
    public static EntityTypeBuilder<TEntity> ConfigureBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : class, IEntityWithId
    {
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Id).ValueGeneratedNever();

        return builder;
    }
}