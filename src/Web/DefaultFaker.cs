using Bogus;

namespace Suzim.Web;

/// <summary>
/// Временный класс для генерации фейковых данных TODO:удалить когда будем имплементировать контроллеры
/// </summary>
public sealed class DefaultFaker<T> : Faker<T> where T : class
{
    public DefaultFaker()
    {
        RuleForType(typeof(string), faker => faker.Random.Word());
        RuleForType(typeof(DateTimeOffset?), faker => (DateTimeOffset?)DateTimeOffset.MinValue.AddYears(faker.Random.Int(2010, 2023)));
        RuleForId();
    }

    private Faker<T> RuleForId()
    {
        foreach (var property in typeof(T).GetProperties())
        {
            if (property.Name.EndsWith("Id"))
            {
                RuleFor(property.Name, faker => faker.Random.Guid().ToString());
            }
        }

        return this;
    }
}
