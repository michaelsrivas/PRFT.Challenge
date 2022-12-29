using PRFT.Challenge.Domain.Models;

namespace PRFT.Challenge.Domain.ClientAggregate.ValueObjects;

public sealed class BranchId : ValueObject
{
    public Guid Value { get; }

    public BranchId(Guid value)
    {
        Value = value;
    }

    public static BranchId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
