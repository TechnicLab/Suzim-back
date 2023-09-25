using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Suzim.Store.Common.Entities;
using Suzim.Store.Postgres.Extensions;

namespace Suzim.Store.EntityConfigurations;

internal sealed class OrderEntityConfiguration : IEntityTypeConfiguration<OrderRecord>
{
    public void Configure(EntityTypeBuilder<OrderRecord> builder)
    {
        builder.ConfigureBaseEntity();
    }
}