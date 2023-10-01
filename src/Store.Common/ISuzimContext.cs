using Microsoft.EntityFrameworkCore;
using Suzim.Store.Common.Entities;

namespace Suzim.Store.Common;

public interface ISuzimContext : IDisposable
{
    /// <summary>
    /// Заказы
    /// </summary>
    DbSet<OrderRecord> Orders { get; }
    
    /// <summary>
    /// Заказчики
    /// </summary>
    DbSet<CustomerRecord> Customers { get; }
    
    /// <summary>
    /// Способы оплаты
    /// </summary>
    DbSet<PaymentMethodRecord> PaymentMethods { get; }

    /// <summary>
    /// Продукты
    /// </summary>
    DbSet<ProductRecord> Products { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}