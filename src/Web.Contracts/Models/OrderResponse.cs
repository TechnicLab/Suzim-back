namespace Suzim.Web.Contracts.Models;

public class OrderResponse
{
    public Guid Id { get; set; }
    
    public string? Status { get; set; }
    
    public DateTimeOffset? CreatedAt { get; set; }
    
    public DateTimeOffset? ModifiedAt { get; set; }
    
    public DateTimeOffset? DeletedAt { get; set; }
}