using Suzim.Store.Common.Contracts;

namespace Suzim.Store.Common.Entities;

/// <summary>
/// Заказчик
/// </summary>
public sealed class CustomerRecord : IEntityWithId, IHuman, IAuditableEntity
{
    public CustomerRecord(
        string surname, 
        string name,
        string phoneNumber)
    {
        Surname = surname;
        Name = name;
        PhoneNumber = phoneNumber;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    public Guid Id { get; set; }
    
    public string Surname { get; set; }
    
    public string Name { get; set; }
    
    public string? Patronymic { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public string? Email { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
    
    public DateTimeOffset? ModifiedAt { get; set; }
    
    public DateTimeOffset? DeletedAt { get; set; }
}