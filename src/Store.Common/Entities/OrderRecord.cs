using Suzim.Store.Common.Contracts;
using Suzim.Store.Common.Enums;

namespace Suzim.Store.Common.Entities;

public sealed class OrderRecord: IAuditableEntity, IEntityWithId
{
    public OrderRecord(
        string number, 
        string address)
    {
        Number = number;
        Address = address;
        CreatedAt = DateTimeOffset.UtcNow;
    }
    
    public Guid Id { get; set; }
    
    /// <summary>
    /// Номер заказа
    /// </summary>
    public string Number { get; set; }
    
    /// <summary>
    /// Заказчик
    /// </summary>
    public CustomerRecord? Customer { get; set; }

    /// <summary>
    /// Способ оплаты
    /// </summary>
    public PaymentMethodRecord? PaymentMethod { get; set; }

    public IReadOnlyList<ProductRecord> Products { get; set; } = Array.Empty<ProductRecord>();

    /// <summary>
    /// Статус заказа
    /// </summary>
    public OrderStatus Status { get; set; }
    
    /// <summary>
    /// Адрес
    /// </summary>
    public string Address { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    
    public DateTimeOffset? ModifiedAt { get; set; }
    
    public DateTimeOffset? DeletedAt { get; set; }
}