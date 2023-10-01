using Suzim.Store.Common.Contracts;

namespace Suzim.Store.Common.Entities;

public sealed class PaymentMethodRecord : IEntityWithId, INamedEntity, IAuditableEntity
{
    public PaymentMethodRecord(string name)
    {
        Name = name;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    
    public DateTimeOffset? ModifiedAt { get; set; }
    
    public DateTimeOffset? DeletedAt { get; set; }
}