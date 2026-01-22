namespace Shared.DDD;

public abstract class Entity<TId> : IEquatable<Entity<TId>>
    where TId : notnull
{
    public TId Id { get; protected init; }

    protected Entity(TId id) => Id = id;

    public override bool Equals(object? obj)
        => obj is Entity<TId> other && Equals(other);

    public bool Equals(Entity<TId>? other)
        => other is not null && EqualityComparer<TId>.Default.Equals(Id, other.Id);

    public override int GetHashCode()
        => EqualityComparer<TId>.Default.GetHashCode(Id);
}