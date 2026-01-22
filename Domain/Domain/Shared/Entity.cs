using System.Reflection;
using Domain.Logging.Events;
using Mapster;

namespace Domain.Shared;

public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = new();

    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    protected void AddDomainEvent(IDomainEvent domainEvent)
        => _domainEvents.Add(domainEvent);

    public void ClearDomainEvents()
        => _domainEvents.Clear();

    /// <summary>
    /// Create a deep copy of this object
    /// </summary>
    public Entity Snapshot()
    {
        // Use GetType to get the actual current type (like Party, and not Entity) so Mapster correctly makes a deep copy
        // Then cast back to generic Entity type
        return (Entity)this.Adapt(this.GetType(), this.GetType());
    }

    /// <summary>
    /// Alias for <see cref="Snapshot"/>
    /// </summary>
    public Entity DeepCopy()
    {
        return Snapshot();
    }

    /// <summary>
    /// Get the difference between 2 objects that inherit from <see cref="Entity"/>, where the current object has the new values
    /// </summary>
    /// <param name="oldEntity">The old object with old values</param>
    /// <returns>A list of <see cref="LogDiff"/>s containing all the changes in the current object compared to the old object</returns>
    /// <exception cref="ArgumentException">Gets thrown if the given <paramref name="oldEntity"/> is not of the same type as the current object</exception>
    public IEnumerable<LogDiff> GetDiffs(Entity oldEntity)
    {
        var logDiffs = new List<LogDiff>();

        var type = GetType();
        if (type != oldEntity.GetType())
        {
            throw new ArgumentException("Cannot compare objects of different types.");
        }

        var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var prop in props)
        {
            if (
                prop.DeclaringType == typeof(Entity) ||
                prop.DeclaringType == typeof(AggregateRoot<object>) ||
                !prop.CanRead
            ) continue;

            var oldValue = prop.GetValue(oldEntity);
            var newValue = prop.GetValue(this);

            if (!Equals(oldValue, newValue))
            {
                logDiffs.Add(new LogDiff(prop.Name, oldValue?.ToString() ?? "", newValue?.ToString() ?? ""));
            }
        }

        return logDiffs;
    }
}