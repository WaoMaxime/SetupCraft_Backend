using Domain.Shared;
using Shared.Exceptions;

namespace Domain.Logging;

public sealed class CaseLogId : ValueObject
{
    public Guid Value { get; }

    private CaseLogId(Guid value)
    {
        if (value == Guid.Empty) throw new ArgumentException($"{nameof(value)} cannot be empty", nameof(value));
        Value = value;
    }

    public static CaseLogId New() => new(Guid.NewGuid());

    public static CaseLogId From(Guid value) => new(value);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public override string ToString() => Value.ToString();

    public NotFoundException NotFound() => new($"CaseLog `{Value}` not found");
}