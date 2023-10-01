using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Suzim.Store.Common.Entities;
using Suzim.Store.Postgres.Extensions;

namespace Suzim.Store.Postgres.EntityConfigurations;

internal sealed class PaymentMethodEntityConfiguration : IEntityTypeConfiguration<PaymentMethodRecord>
{
    public void Configure(EntityTypeBuilder<PaymentMethodRecord> builder)
    {
        builder.ConfigureBaseEntity();
    }
}