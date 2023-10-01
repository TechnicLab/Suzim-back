using Suzim.Store.Common.Contracts;

namespace Suzim.Store.Common.Entities;

public sealed class ProductRecord : IEntityWithId, INamedEntity, IAuditableEntity
{
    public ProductRecord(
        string name,
        decimal price)
    {
        Name = name;
        Price = price;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public string? Description { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset? ModifiedAt { get; set; }
    
    public DateTimeOffset? DeletedAt { get; set; }
}