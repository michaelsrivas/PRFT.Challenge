using PRFT.Challenge.Domain.Models;

namespace PRFT.Challenge.Domain.ClientAggregate.ValueObjects;

public sealed class ClientId : ValueObject
{
    public Guid Value { get; }

    public ClientId(Guid value)
    {
        Value = value;
    }

    public static ClientId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
