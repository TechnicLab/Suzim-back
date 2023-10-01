using Microsoft.EntityFrameworkCore;
using Suzim.Store.Common;
using Suzim.Store.Common.Entities;

namespace Suzim.Store.Postgres;

public sealed class SizumContextPostgres : DbContext, ISuzimContext
{
    public SizumContextPostgres(DbContextOptions<SizumContextPostgres> options) : base(options) { }
    
    public DbSet<OrderRecord> Orders  => Set<OrderRecord>();
    
    public DbSet<CustomerRecord> Customers => Set<CustomerRecord>();
    
    public DbSet<PaymentMethodRecord> PaymentMethods => Set<PaymentMethodRecord>();
    
    public DbSet<ProductRecord> Products => Set<ProductRecord>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }
}