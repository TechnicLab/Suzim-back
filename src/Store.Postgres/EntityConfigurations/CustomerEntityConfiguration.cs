using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Suzim.Store.Common.Entities;
using Suzim.Store.Postgres.Extensions;

namespace Suzim.Store.Postgres.EntityConfigurations;

internal sealed class CustomerEntityConfiguration : IEntityTypeConfiguration<CustomerRecord>
{
    public void Configure(EntityTypeBuilder<CustomerRecord> builder)
    {
        builder.ConfigureBaseEntity();
    }
}