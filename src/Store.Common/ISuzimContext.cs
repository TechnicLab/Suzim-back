using Microsoft.EntityFrameworkCore;
using Suzim.Store.Common.Entities;

namespace Suzim.Store.Common;

public interface ISuzimContext : IDisposable
{
    /// <summary>
    /// заказы
    /// </summary>
    DbSet<OrderRecord> Orders { get; }

    /// <summary>
    /// Паллеты
    /// </summary>
    DbSet<StatusRecord> Statuses { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}