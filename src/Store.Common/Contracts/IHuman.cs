namespace Suzim.Store.Common.Contracts;

public interface IHuman
{
    string Surname { get; set; }
    
    string Name { get; set; }
    
    string? Patronymic { get; set; }

    string PhoneNumber { get; set; }
    
    string? Email { get; set; }
}