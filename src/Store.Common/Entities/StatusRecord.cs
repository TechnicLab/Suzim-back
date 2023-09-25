using Suzim.Store.Common.Contracts;

namespace Suzim.Store.Common.Entities;

public class StatusRecord : INamedEntity, IEntityWithId
{
    public StatusRecord(string name)
    {
        Name = name;
    }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
}