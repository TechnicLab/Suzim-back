using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Suzim.Store.Common.Entities;
using Suzim.Store.Postgres.Extensions;

namespace Suzim.Store.Postgres.EntityConfigurations;

internal sealed class ProductEntityConfiguration : IEntityTypeConfiguration<ProductRecord>
{
    public void Configure(EntityTypeBuilder<ProductRecord> builder)
    {
        builder.ConfigureBaseEntity();
    }
}