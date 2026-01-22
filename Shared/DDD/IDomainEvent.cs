namespace Shared.DDD;

public interface IDomainEvent
{
    DateTimeOffset OccurredOn { get; }
}

public abstract record DomainEvent : IDomainEvent
{
    public DateTimeOffset OccurredOn { get; } = DateTimeOffset.UtcNow;
}