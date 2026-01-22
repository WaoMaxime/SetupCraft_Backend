namespace Domain.Shared;

public abstract class AggregateRoot<TId> : AggregateRoot
{
    public TId Id { get; protected set; }
}