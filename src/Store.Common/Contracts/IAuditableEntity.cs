namespace Suzim.Store.Common.Contracts;

public interface IAuditableEntity
{
    DateTimeOffset CreatedAt { get; set; }
    
    DateTimeOffset? ModifiedAt { get; set; }
    
    DateTimeOffset? DeletedAt { get; set; }
}