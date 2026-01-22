namespace Domain.Shared;

public interface IDomainEventCollector
{
    void AddRange(IEnumerable<IDomainEvent> events);
    IReadOnlyCollection<IDomainEvent> GetAllAndClear();
}
