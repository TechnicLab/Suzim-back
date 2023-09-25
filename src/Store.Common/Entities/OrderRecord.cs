using Suzim.Store.Common.Contracts;

namespace Suzim.Store.Common.Entities;

public sealed class OrderRecord: IAuditableEntity, IEntityWithId
{
    public OrderRecord(StatusRecord status)
    {
        Status = status;
    }

    public Guid Id { get; set; }
    
    public StatusRecord Status { get; set; }
    
    public DateTimeOffset? CreatedAt { get; set; }
    
    public DateTimeOffset? ModifiedAt { get; set; }
    
    public DateTimeOffset? DeletedAt { get; set; }
}