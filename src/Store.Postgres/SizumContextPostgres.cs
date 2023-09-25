using Microsoft.EntityFrameworkCore;
using Suzim.Store.Common;
using Suzim.Store.Common.Entities;

namespace Suzim.Store;

internal sealed class SizumContextPostgres : DbContext, ISuzimContext
{
    public SizumContextPostgres(DbContextOptions<SizumContextPostgres> options) : base(options) { }
    
    public DbSet<OrderRecord> Orders  => Set<OrderRecord>();
    
    public DbSet<StatusRecord> Statuses => Set<StatusRecord>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}